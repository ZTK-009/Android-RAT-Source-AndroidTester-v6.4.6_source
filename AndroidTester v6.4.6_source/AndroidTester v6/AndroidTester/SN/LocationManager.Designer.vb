<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LocationManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MapBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LonText = New System.Windows.Forms.Label()
        Me.LatText = New System.Windows.Forms.Label()
        Me.ThemeSeparator3 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.LastUpdate = New System.Windows.Forms.Label()
        Me.YandexMapsButton = New SpyNote_V6._4.SN.ThemeButton()
        Me.GoogleMapsButton = New SpyNote_V6._4.SN.ThemeButton()
        Me.LABProvider = New System.Windows.Forms.Label()
        Me.ThemeSeparator2 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.ThemeSeparator1 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.LABAccuracyAccuracy = New System.Windows.Forms.Label()
        Me.BTNSty = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LBLZOOM = New System.Windows.Forms.Label()
        Me.BTNMIN = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LABSty = New System.Windows.Forms.Label()
        Me.BTNZay = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.TProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.LBER = New System.Windows.Forms.Label()
        Me.PNLERRORS = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New SpyNote_V6._4.SN.ThemeProgressBar()
        Me.MAPProgressBar1 = New SpyNote_V6._4.SN.ThemeProgressBar()
        CType(Me.MapBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PNLERRORS.SuspendLayout()
        Me.SuspendLayout()
        '
        'MapBox
        '
        Me.MapBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MapBox.Location = New System.Drawing.Point(-1, -1)
        Me.MapBox.Name = "MapBox"
        Me.MapBox.Size = New System.Drawing.Size(450, 450)
        Me.MapBox.TabIndex = 0
        Me.MapBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LonText)
        Me.Panel1.Controls.Add(Me.LatText)
        Me.Panel1.Controls.Add(Me.ThemeSeparator3)
        Me.Panel1.Controls.Add(Me.LastUpdate)
        Me.Panel1.Controls.Add(Me.YandexMapsButton)
        Me.Panel1.Controls.Add(Me.GoogleMapsButton)
        Me.Panel1.Controls.Add(Me.LABProvider)
        Me.Panel1.Controls.Add(Me.ThemeSeparator2)
        Me.Panel1.Controls.Add(Me.ThemeSeparator1)
        Me.Panel1.Controls.Add(Me.LABAccuracyAccuracy)
        Me.Panel1.Controls.Add(Me.BTNSty)
        Me.Panel1.Controls.Add(Me.LBLZOOM)
        Me.Panel1.Controls.Add(Me.BTNMIN)
        Me.Panel1.Controls.Add(Me.LABSty)
        Me.Panel1.Controls.Add(Me.BTNZay)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(447, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 407)
        Me.Panel1.TabIndex = 3
        '
        'LonText
        '
        Me.LonText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LonText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LonText.Location = New System.Drawing.Point(30, 215)
        Me.LonText.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LonText.Name = "LonText"
        Me.LonText.Size = New System.Drawing.Size(150, 20)
        Me.LonText.TabIndex = 15
        Me.LonText.Text = "Lon: n/a"
        Me.LonText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LatText
        '
        Me.LatText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LatText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LatText.Location = New System.Drawing.Point(30, 190)
        Me.LatText.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LatText.Name = "LatText"
        Me.LatText.Size = New System.Drawing.Size(150, 20)
        Me.LatText.TabIndex = 14
        Me.LatText.Text = "Lat: n/a"
        Me.LatText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ThemeSeparator3
        '
        Me.ThemeSeparator3.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator3.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator3.Location = New System.Drawing.Point(23, 265)
        Me.ThemeSeparator3.Name = "ThemeSeparator3"
        Me.ThemeSeparator3.Size = New System.Drawing.Size(139, 10)
        Me.ThemeSeparator3.TabIndex = 13
        Me.ThemeSeparator3.Text = "ThemeSeparator3"
        '
        'LastUpdate
        '
        Me.LastUpdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LastUpdate.Location = New System.Drawing.Point(30, 240)
        Me.LastUpdate.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LastUpdate.Name = "LastUpdate"
        Me.LastUpdate.Size = New System.Drawing.Size(150, 20)
        Me.LastUpdate.TabIndex = 12
        Me.LastUpdate.Text = "Updated: n/a"
        Me.LastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'YandexMapsButton
        '
        Me.YandexMapsButton.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.YandexMapsButton.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.YandexMapsButton.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.YandexMapsButton.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.YandexMapsButton.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.YandexMapsButton.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.YandexMapsButton.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.YandexMapsButton.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.YandexMapsButton.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.YandexMapsButton.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.YandexMapsButton.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.YandexMapsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YandexMapsButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.YandexMapsButton.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.YandexMapsButton.ImageChoice = Nothing
        Me.YandexMapsButton.Location = New System.Drawing.Point(23, 298)
        Me.YandexMapsButton.Name = "YandexMapsButton"
        Me.YandexMapsButton.ShowImage = False
        Me.YandexMapsButton.ShowText = True
        Me.YandexMapsButton.Size = New System.Drawing.Size(126, 40)
        Me.YandexMapsButton.TabIndex = 11
        Me.YandexMapsButton.Tag = ""
        Me.YandexMapsButton.Text = "Yandex Maps"
        Me.YandexMapsButton.TextAlignment = System.Drawing.StringAlignment.Center
        Me.YandexMapsButton.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.YandexMapsButton.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.YandexMapsButton.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'GoogleMapsButton
        '
        Me.GoogleMapsButton.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GoogleMapsButton.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GoogleMapsButton.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GoogleMapsButton.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GoogleMapsButton.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GoogleMapsButton.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GoogleMapsButton.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GoogleMapsButton.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GoogleMapsButton.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.GoogleMapsButton.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GoogleMapsButton.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.GoogleMapsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GoogleMapsButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.GoogleMapsButton.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.GoogleMapsButton.ImageChoice = Nothing
        Me.GoogleMapsButton.Location = New System.Drawing.Point(23, 347)
        Me.GoogleMapsButton.Name = "GoogleMapsButton"
        Me.GoogleMapsButton.ShowImage = False
        Me.GoogleMapsButton.ShowText = True
        Me.GoogleMapsButton.Size = New System.Drawing.Size(126, 40)
        Me.GoogleMapsButton.TabIndex = 10
        Me.GoogleMapsButton.Tag = ""
        Me.GoogleMapsButton.Text = "Google Maps"
        Me.GoogleMapsButton.TextAlignment = System.Drawing.StringAlignment.Center
        Me.GoogleMapsButton.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GoogleMapsButton.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GoogleMapsButton.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LABProvider
        '
        Me.LABProvider.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABProvider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LABProvider.Location = New System.Drawing.Point(30, 165)
        Me.LABProvider.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LABProvider.Name = "LABProvider"
        Me.LABProvider.Size = New System.Drawing.Size(150, 20)
        Me.LABProvider.TabIndex = 9
        Me.LABProvider.Text = "Provider: n/a"
        Me.LABProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ThemeSeparator2
        '
        Me.ThemeSeparator2.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator2.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator2.Location = New System.Drawing.Point(23, 125)
        Me.ThemeSeparator2.Name = "ThemeSeparator2"
        Me.ThemeSeparator2.Size = New System.Drawing.Size(139, 10)
        Me.ThemeSeparator2.TabIndex = 8
        Me.ThemeSeparator2.Text = "ThemeSeparator2"
        '
        'ThemeSeparator1
        '
        Me.ThemeSeparator1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator1.Location = New System.Drawing.Point(23, 61)
        Me.ThemeSeparator1.Name = "ThemeSeparator1"
        Me.ThemeSeparator1.Size = New System.Drawing.Size(139, 10)
        Me.ThemeSeparator1.TabIndex = 7
        Me.ThemeSeparator1.Text = "ThemeSeparator1"
        '
        'LABAccuracyAccuracy
        '
        Me.LABAccuracyAccuracy.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABAccuracyAccuracy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LABAccuracyAccuracy.Location = New System.Drawing.Point(30, 140)
        Me.LABAccuracyAccuracy.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LABAccuracyAccuracy.Name = "LABAccuracyAccuracy"
        Me.LABAccuracyAccuracy.Size = New System.Drawing.Size(150, 20)
        Me.LABAccuracyAccuracy.TabIndex = 6
        Me.LABAccuracyAccuracy.Text = "Accuracy: n/a"
        Me.LABAccuracyAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTNSty
        '
        Me.BTNSty.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNSty.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNSty.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNSty.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNSty.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNSty.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNSty.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNSty.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNSty.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNSty.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNSty.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNSty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNSty.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Middle
        Me.BTNSty.ImageChoice = Nothing
        Me.BTNSty.Location = New System.Drawing.Point(3, 17)
        Me.BTNSty.Name = "BTNSty"
        Me.BTNSty.ShowImage = False
        Me.BTNSty.ShowText = False
        Me.BTNSty.Size = New System.Drawing.Size(20, 20)
        Me.BTNSty.TabIndex = 5
        Me.BTNSty.Tag = "0"
        Me.BTNSty.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNSty.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNSty.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNSty.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LBLZOOM
        '
        Me.LBLZOOM.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLZOOM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LBLZOOM.Location = New System.Drawing.Point(30, 90)
        Me.LBLZOOM.Name = "LBLZOOM"
        Me.LBLZOOM.Size = New System.Drawing.Size(150, 17)
        Me.LBLZOOM.TabIndex = 4
        Me.LBLZOOM.Text = "Zoom:0%"
        '
        'BTNMIN
        '
        Me.BTNMIN.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNMIN.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNMIN.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNMIN.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNMIN.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNMIN.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNMIN.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNMIN.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNMIN.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNMIN.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNMIN.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNMIN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNMIN.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Middle
        Me.BTNMIN.ImageChoice = Nothing
        Me.BTNMIN.Location = New System.Drawing.Point(3, 109)
        Me.BTNMIN.Name = "BTNMIN"
        Me.BTNMIN.ShowImage = False
        Me.BTNMIN.ShowText = False
        Me.BTNMIN.Size = New System.Drawing.Size(20, 20)
        Me.BTNMIN.TabIndex = 3
        Me.BTNMIN.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNMIN.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNMIN.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNMIN.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LABSty
        '
        Me.LABSty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABSty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LABSty.Location = New System.Drawing.Point(30, 18)
        Me.LABSty.Name = "LABSty"
        Me.LABSty.Size = New System.Drawing.Size(150, 17)
        Me.LABSty.TabIndex = 2
        Me.LABSty.Text = "Roadmap"
        '
        'BTNZay
        '
        Me.BTNZay.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNZay.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNZay.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNZay.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNZay.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNZay.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNZay.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNZay.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNZay.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNZay.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNZay.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNZay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNZay.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Middle
        Me.BTNZay.ImageChoice = Nothing
        Me.BTNZay.Location = New System.Drawing.Point(3, 71)
        Me.BTNZay.Name = "BTNZay"
        Me.BTNZay.ShowImage = False
        Me.BTNZay.ShowText = False
        Me.BTNZay.Size = New System.Drawing.Size(20, 20)
        Me.BTNZay.TabIndex = 0
        Me.BTNZay.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNZay.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNZay.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNZay.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'TProgressBar
        '
        Me.TProgressBar.Interval = 1
        '
        'LBER
        '
        Me.LBER.AutoSize = True
        Me.LBER.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBER.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LBER.Location = New System.Drawing.Point(0, 0)
        Me.LBER.Name = "LBER"
        Me.LBER.Size = New System.Drawing.Size(37, 15)
        Me.LBER.TabIndex = 0
        Me.LBER.Text = "Errors"
        Me.LBER.Visible = False
        '
        'PNLERRORS
        '
        Me.PNLERRORS.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PNLERRORS.Controls.Add(Me.LBER)
        Me.PNLERRORS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNLERRORS.Location = New System.Drawing.Point(0, 407)
        Me.PNLERRORS.Name = "PNLERRORS"
        Me.PNLERRORS.Size = New System.Drawing.Size(621, 19)
        Me.PNLERRORS.TabIndex = 4
        Me.PNLERRORS.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Animated = True
        Me.ProgressBar1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ProgressBar1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ProgressBar1.Customization = "AAAAAAAAAAAAAAAAAAAAAA=="
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ProgressBar1.Image = Nothing
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 426)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.NoRounding = False
        Me.ProgressBar1.Size = New System.Drawing.Size(621, 10)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Text = "ThemeProgressBar1"
        Me.ProgressBar1.Transparent = False
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = False
        '
        'MAPProgressBar1
        '
        Me.MAPProgressBar1.Animated = True
        Me.MAPProgressBar1.Colour0 = System.Drawing.Color.CornflowerBlue
        Me.MAPProgressBar1.Colour1 = System.Drawing.Color.CornflowerBlue
        Me.MAPProgressBar1.Customization = "AAAAAAAAAAAAAAAAAAAAAA=="
        Me.MAPProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MAPProgressBar1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.MAPProgressBar1.Image = Nothing
        Me.MAPProgressBar1.Location = New System.Drawing.Point(0, 436)
        Me.MAPProgressBar1.Maximum = 100
        Me.MAPProgressBar1.Minimum = 0
        Me.MAPProgressBar1.Name = "MAPProgressBar1"
        Me.MAPProgressBar1.NoRounding = False
        Me.MAPProgressBar1.Size = New System.Drawing.Size(621, 10)
        Me.MAPProgressBar1.TabIndex = 1
        Me.MAPProgressBar1.TabStop = False
        Me.MAPProgressBar1.Text = "ThemeProgressBar1"
        Me.MAPProgressBar1.Transparent = False
        Me.MAPProgressBar1.Value = 0
        Me.MAPProgressBar1.Visible = False
        '
        'LocationManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(621, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MapBox)
        Me.Controls.Add(Me.PNLERRORS)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MAPProgressBar1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LocationManager"
        Me.Opacity = 0R
        Me.Text = "Location Manager"
        CType(Me.MapBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PNLERRORS.ResumeLayout(False)
        Me.PNLERRORS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MapBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNZay As SN.ThemeButtonImge
    Friend WithEvents LABSty As Label
    Friend WithEvents LBLZOOM As Label
    Friend WithEvents BTNMIN As SN.ThemeButtonImge
    Friend WithEvents BTNSty As SN.ThemeButtonImge
    Friend WithEvents ThemeSeparator2 As SN.ThemeSeparator
    Friend WithEvents ThemeSeparator1 As SN.ThemeSeparator
    Friend WithEvents LABAccuracyAccuracy As Label
    Friend WithEvents LABProvider As Label
    Friend WithEvents Trans As Timer
    Friend WithEvents TProgressBar As Timer
    Friend WithEvents GoogleMapsButton As SN.ThemeButton
    Friend WithEvents YandexMapsButton As SN.ThemeButton
    Friend WithEvents LastUpdate As Label
    Friend WithEvents ThemeSeparator3 As SN.ThemeSeparator
    Friend WithEvents LBER As Label
    Friend WithEvents PNLERRORS As Panel
    Friend WithEvents ProgressBar1 As SN.ThemeProgressBar
    Friend WithEvents MAPProgressBar1 As SN.ThemeProgressBar
    Friend WithEvents LonText As Label
    Friend WithEvents LatText As Label
End Class
