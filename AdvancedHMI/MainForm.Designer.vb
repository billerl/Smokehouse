<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SerialDF1forSLCMicroCom1 = New AdvancedHMIDrivers.SerialDF1forSLCMicroCom(Me.components)
        Me.SevenSegment21 = New AdvancedHMIControls.SevenSegment2()
        Me.SevenSegment22 = New AdvancedHMIControls.SevenSegment2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SevenSegment23 = New AdvancedHMIControls.SevenSegment2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChartBySampling1 = New AdvancedHMIControls.ChartBySampling()
        Me.SerialDF1forSLCMicroCom2 = New AdvancedHMIDrivers.SerialDF1forSLCMicroCom(Me.components)
        Me.Emailer1 = New AdvancedHMIControls.Emailer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ChartBySampling2 = New AdvancedHMIControls.ChartBySampling()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.HydraulicCylinder1 = New AdvancedHMIControls.HydraulicCylinder()
        Me.Emailer2 = New AdvancedHMIControls.Emailer(Me.components)
        Me.BasicButton2 = New AdvancedHMIControls.BasicButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialDF1forSLCMicroCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartBySampling1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialDF1forSLCMicroCom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Emailer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartBySampling2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Emailer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 1836)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1455, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 47)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'SerialDF1forSLCMicroCom1
        '
        Me.SerialDF1forSLCMicroCom1.BaudRate = "AUTO"
        Me.SerialDF1forSLCMicroCom1.CheckSumType = MfgControl.AdvancedHMI.Drivers.DF1Transport.ChecksumOption.Crc
        Me.SerialDF1forSLCMicroCom1.ComPort = "COM4"
        Me.SerialDF1forSLCMicroCom1.DisableSubscriptions = False
        Me.SerialDF1forSLCMicroCom1.EnableLogging = False
        Me.SerialDF1forSLCMicroCom1.IniFileName = ""
        Me.SerialDF1forSLCMicroCom1.IniFileSection = Nothing
        Me.SerialDF1forSLCMicroCom1.IsPLC5 = False
        Me.SerialDF1forSLCMicroCom1.MaxPCCCPacketSize = 236
        Me.SerialDF1forSLCMicroCom1.MyNode = 0
        Me.SerialDF1forSLCMicroCom1.Parity = System.IO.Ports.Parity.None
        Me.SerialDF1forSLCMicroCom1.PollRateOverride = 500
        Me.SerialDF1forSLCMicroCom1.TargetNode = 0
        '
        'SevenSegment21
        '
        Me.SevenSegment21.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment21.ComComponent = Me.SerialDF1forSLCMicroCom1
        Me.SevenSegment21.DecimalPosition = 0
        Me.SevenSegment21.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment21.ForeColorInLimits = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SevenSegment21.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment21.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment21.ForeColorUnderLowLimit = System.Drawing.Color.Lime
        Me.SevenSegment21.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment21.KeypadMaxValue = 0R
        Me.SevenSegment21.KeypadMinValue = 0R
        Me.SevenSegment21.KeypadScaleFactor = 1.0R
        Me.SevenSegment21.KeypadText = Nothing
        Me.SevenSegment21.KeypadWidth = 300
        Me.SevenSegment21.Location = New System.Drawing.Point(57, 171)
        Me.SevenSegment21.Name = "SevenSegment21"
        Me.SevenSegment21.NumberOfDigits = 5
        Me.SevenSegment21.PLCAddressKeypad = ""
        Me.SevenSegment21.PLCAddressText = ""
        Me.SevenSegment21.PLCAddressValue = CType(resources.GetObject("SevenSegment21.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment21.PLCAddressVisible = ""
        Me.SevenSegment21.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment21.ShowOffSegments = True
        Me.SevenSegment21.Size = New System.Drawing.Size(608, 158)
        Me.SevenSegment21.TabIndex = 43
        Me.SevenSegment21.Text = "SevenSegment21"
        Me.SevenSegment21.Value = 0R
        '
        'SevenSegment22
        '
        Me.SevenSegment22.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment22.ComComponent = Me.SerialDF1forSLCMicroCom1
        Me.SevenSegment22.DecimalPosition = 0
        Me.SevenSegment22.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment22.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment22.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment22.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment22.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment22.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment22.KeypadMaxValue = 0R
        Me.SevenSegment22.KeypadMinValue = 0R
        Me.SevenSegment22.KeypadScaleFactor = 1.0R
        Me.SevenSegment22.KeypadText = Nothing
        Me.SevenSegment22.KeypadWidth = 300
        Me.SevenSegment22.Location = New System.Drawing.Point(724, 171)
        Me.SevenSegment22.Name = "SevenSegment22"
        Me.SevenSegment22.NumberOfDigits = 5
        Me.SevenSegment22.PLCAddressKeypad = ""
        Me.SevenSegment22.PLCAddressText = ""
        Me.SevenSegment22.PLCAddressValue = CType(resources.GetObject("SevenSegment22.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment22.PLCAddressVisible = ""
        Me.SevenSegment22.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment22.ShowOffSegments = True
        Me.SevenSegment22.Size = New System.Drawing.Size(608, 158)
        Me.SevenSegment22.TabIndex = 44
        Me.SevenSegment22.Text = "SevenSegment22"
        Me.SevenSegment22.Value = 0R
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(206, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 23)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "MEAT TEMPERATURE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(864, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(297, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "OVEN ACTUAL TEMPERATURE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(181, 368)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 30)
        Me.TextBox1.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(83, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 23)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "SET MEAT CHECK  TEMPERATURE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(181, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 102)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "SET TEXT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(83, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(329, 23)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "SET MEAT FINISH TEMPERATURE"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(181, 440)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 30)
        Me.TextBox2.TabIndex = 50
        '
        'SevenSegment23
        '
        Me.SevenSegment23.BackColor = System.Drawing.Color.Transparent
        Me.SevenSegment23.ComComponent = Me.SerialDF1forSLCMicroCom1
        Me.SevenSegment23.DecimalPosition = 0
        Me.SevenSegment23.ForecolorHighLimitValue = 999999.0R
        Me.SevenSegment23.ForeColorInLimits = System.Drawing.Color.White
        Me.SevenSegment23.ForecolorLowLimitValue = -999999.0R
        Me.SevenSegment23.ForeColorOverHighLimit = System.Drawing.Color.Red
        Me.SevenSegment23.ForeColorUnderLowLimit = System.Drawing.Color.Yellow
        Me.SevenSegment23.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.SevenSegment23.KeypadMaxValue = 0R
        Me.SevenSegment23.KeypadMinValue = 0R
        Me.SevenSegment23.KeypadScaleFactor = 1.0R
        Me.SevenSegment23.KeypadText = Nothing
        Me.SevenSegment23.KeypadWidth = 300
        Me.SevenSegment23.Location = New System.Drawing.Point(724, 368)
        Me.SevenSegment23.Name = "SevenSegment23"
        Me.SevenSegment23.NumberOfDigits = 5
        Me.SevenSegment23.PLCAddressKeypad = "N7:3"
        Me.SevenSegment23.PLCAddressText = ""
        Me.SevenSegment23.PLCAddressValue = CType(resources.GetObject("SevenSegment23.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.SevenSegment23.PLCAddressVisible = ""
        Me.SevenSegment23.ResolutionOfLastDigit = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SevenSegment23.ShowOffSegments = True
        Me.SevenSegment23.Size = New System.Drawing.Size(608, 158)
        Me.SevenSegment23.TabIndex = 55
        Me.SevenSegment23.Text = "SevenSegment23"
        Me.SevenSegment23.Value = 0R
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(864, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(261, 23)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "OVEN SET TEMPERATURE"
        '
        'ChartBySampling1
        '
        Me.ChartBySampling1.BackColor = System.Drawing.Color.DimGray
        Me.ChartBySampling1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter
        Me.ChartBySampling1.BorderlineColor = System.Drawing.Color.Transparent
        Me.ChartBySampling1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Me.ChartBySampling1.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.ChartBySampling1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss
        ChartArea1.Name = "ChartArea1"
        Me.ChartBySampling1.ChartAreas.Add(ChartArea1)
        Me.ChartBySampling1.ComComponent = Me.SerialDF1forSLCMicroCom2
        Legend1.Name = "Legend1"
        Me.ChartBySampling1.Legends.Add(Legend1)
        Me.ChartBySampling1.Location = New System.Drawing.Point(-388, 560)
        Me.ChartBySampling1.MaximumActivePoints = 100
        Me.ChartBySampling1.Name = "ChartBySampling1"
        Me.ChartBySampling1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Me.ChartBySampling1.PLCAddressItems.Add(CType(resources.GetObject("ChartBySampling1.PLCAddressItems"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.ChartBySampling1.PLCAddressYAxisMax = CType(resources.GetObject("ChartBySampling1.PLCAddressYAxisMax"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ChartBySampling1.PLCAddressYAxisMin = CType(resources.GetObject("ChartBySampling1.PLCAddressYAxisMin"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Series1.BorderColor = System.Drawing.Color.Red
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Legend = "Legend1"
        Series1.Name = "TEMPERATURE"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series1.YValuesPerPoint = 5
        Me.ChartBySampling1.Series.Add(Series1)
        Me.ChartBySampling1.Size = New System.Drawing.Size(849, 344)
        Me.ChartBySampling1.TabIndex = 58
        Me.ChartBySampling1.Text = "ChartBySampling1"
        Title1.BackColor = System.Drawing.Color.Silver
        Title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Title1.Font = New System.Drawing.Font("Modern No. 20", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "MEAT TEMPERATURE BY MINUTES PAST"
        Me.ChartBySampling1.Titles.Add(Title1)
        Me.ChartBySampling1.YAxisMax = Double.NaN
        Me.ChartBySampling1.YAxisMin = Double.NaN
        '
        'SerialDF1forSLCMicroCom2
        '
        Me.SerialDF1forSLCMicroCom2.BaudRate = "AUTO"
        Me.SerialDF1forSLCMicroCom2.CheckSumType = MfgControl.AdvancedHMI.Drivers.DF1Transport.ChecksumOption.Crc
        Me.SerialDF1forSLCMicroCom2.ComPort = "COM4"
        Me.SerialDF1forSLCMicroCom2.DisableSubscriptions = False
        Me.SerialDF1forSLCMicroCom2.EnableLogging = False
        Me.SerialDF1forSLCMicroCom2.IniFileName = ""
        Me.SerialDF1forSLCMicroCom2.IniFileSection = Nothing
        Me.SerialDF1forSLCMicroCom2.IsPLC5 = False
        Me.SerialDF1forSLCMicroCom2.MaxPCCCPacketSize = 236
        Me.SerialDF1forSLCMicroCom2.MyNode = 0
        Me.SerialDF1forSLCMicroCom2.Parity = System.IO.Ports.Parity.None
        Me.SerialDF1forSLCMicroCom2.PollRateOverride = 60000
        Me.SerialDF1forSLCMicroCom2.TargetNode = 0
        '
        'Emailer1
        '
        Me.Emailer1.ComComponent = Me.SerialDF1forSLCMicroCom1
        Me.Emailer1.ErrorMessageDisplayLabel = Nothing
        Me.Emailer1.MessageBody = ""
        Me.Emailer1.MessageFrom = "BILLER.LUKE@GMAIL.COM"
        Me.Emailer1.MessageSubject = "SMOKEHOUSE ALERT"
        Me.Emailer1.MessageTo = "4199375993@txt.att.net"
        Me.Emailer1.PLCAddressValue = CType(resources.GetObject("Emailer1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.Emailer1.ServerPresets = MfgControl.AdvancedHMI.Controls.EmailerEx.ServerPresetsEnum.SelectOne
        Me.Emailer1.SmtpLoginPassword = "Archer@2"
        Me.Emailer1.SmtpLoginUserName = "biller.luke@gmail.com"
        Me.Emailer1.SmtpPort = 587
        Me.Emailer1.SmtpServer = "smtp.gmail.com"
        Me.Emailer1.TargetValue = "300"
        Me.Emailer1.TriggerType = MfgControl.AdvancedHMI.Controls.EmailerEx.TriggerTypeEnum.AboveTargetValue
        Me.Emailer1.UseSsl = True
        Me.Emailer1.Value = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(1092, 669)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 23)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "SET TEXT ALERT"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1096, 695)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 30)
        Me.TextBox3.TabIndex = 60
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1096, 731)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 102)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "TEXTING OFF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ChartBySampling2
        '
        Me.ChartBySampling2.BackColor = System.Drawing.Color.DimGray
        Me.ChartBySampling2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter
        Me.ChartBySampling2.BorderlineColor = System.Drawing.Color.Transparent
        Me.ChartBySampling2.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Me.ChartBySampling2.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.ChartBySampling2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss
        ChartArea2.Name = "ChartArea1"
        Me.ChartBySampling2.ChartAreas.Add(ChartArea2)
        Me.ChartBySampling2.ComComponent = Me.SerialDF1forSLCMicroCom2
        Legend2.Name = "Legend1"
        Me.ChartBySampling2.Legends.Add(Legend2)
        Me.ChartBySampling2.Location = New System.Drawing.Point(241, 368)
        Me.ChartBySampling2.MaximumActivePoints = 100
        Me.ChartBySampling2.Name = "ChartBySampling2"
        Me.ChartBySampling2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Me.ChartBySampling2.PLCAddressItems.Add(CType(resources.GetObject("ChartBySampling2.PLCAddressItems"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.ChartBySampling2.PLCAddressYAxisMax = CType(resources.GetObject("ChartBySampling2.PLCAddressYAxisMax"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.ChartBySampling2.PLCAddressYAxisMin = CType(resources.GetObject("ChartBySampling2.PLCAddressYAxisMin"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Series2.BorderColor = System.Drawing.Color.Red
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Legend = "Legend1"
        Series2.Name = "TEMPERATURE"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series2.YValuesPerPoint = 5
        Me.ChartBySampling2.Series.Add(Series2)
        Me.ChartBySampling2.Size = New System.Drawing.Size(849, 344)
        Me.ChartBySampling2.TabIndex = 62
        Me.ChartBySampling2.Text = "ChartBySampling2"
        Title2.BackColor = System.Drawing.Color.Silver
        Title2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Title2.Font = New System.Drawing.Font("Modern No. 20", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "HOUSE TEMPERATURE BY MINUTES PAST"
        Me.ChartBySampling2.Titles.Add(Title2)
        Me.ChartBySampling2.YAxisMax = Double.NaN
        Me.ChartBySampling2.YAxisMin = Double.NaN
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.Black
        Me.BasicButton1.ComComponent = Me.SerialDF1forSLCMicroCom1
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(956, 731)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton1.PLCAddressClick = "B3:0/0"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(134, 102)
        Me.BasicButton1.TabIndex = 63
        Me.BasicButton1.Text = "OPEN EXHAUST"
        Me.BasicButton1.TextAlternate = Nothing
        Me.BasicButton1.UseVisualStyleBackColor = True
        Me.BasicButton1.ValueToWrite = 0
        '
        'HydraulicCylinder1
        '
        Me.HydraulicCylinder1.BackColor = System.Drawing.Color.Black
        Me.HydraulicCylinder1.ComComponent = Me.SerialDF1forSLCMicroCom1
        Me.HydraulicCylinder1.ForeColor = System.Drawing.Color.LightGray
        Me.HydraulicCylinder1.Location = New System.Drawing.Point(280, 449)
        Me.HydraulicCylinder1.Name = "HydraulicCylinder1"
        Me.HydraulicCylinder1.OutputType = AdvancedHMIControls.HydraulicCylinder.OutputTypes.MomentarySet
        Me.HydraulicCylinder1.PLCAddressClick = ""
        Me.HydraulicCylinder1.PLCAddressText = ""
        Me.HydraulicCylinder1.PLCAddressValue = "B3:0/1"
        Me.HydraulicCylinder1.PLCAddressVisible = ""
        Me.HydraulicCylinder1.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.HydraulicCylinder1.Size = New System.Drawing.Size(287, 105)
        Me.HydraulicCylinder1.TabIndex = 64
        Me.HydraulicCylinder1.Text = "EXHAUST"
        Me.HydraulicCylinder1.Value = False
        '
        'Emailer2
        '
        Me.Emailer2.ComComponent = Me.SerialDF1forSLCMicroCom1
        Me.Emailer2.ErrorMessageDisplayLabel = Nothing
        Me.Emailer2.MessageBody = ""
        Me.Emailer2.MessageFrom = "BILLER.LUKE@GMAIL.COM"
        Me.Emailer2.MessageSubject = "SMOKEHOUSE ALERT"
        Me.Emailer2.MessageTo = "4199375993@txt.att.net"
        Me.Emailer2.PLCAddressValue = CType(resources.GetObject("Emailer2.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.Emailer2.ServerPresets = MfgControl.AdvancedHMI.Controls.EmailerEx.ServerPresetsEnum.SelectOne
        Me.Emailer2.SmtpLoginPassword = "Archer@2"
        Me.Emailer2.SmtpLoginUserName = "biller.luke@gmail.com"
        Me.Emailer2.SmtpPort = 587
        Me.Emailer2.SmtpServer = "smtp.gmail.com"
        Me.Emailer2.TargetValue = "150"
        Me.Emailer2.TriggerType = MfgControl.AdvancedHMI.Controls.EmailerEx.TriggerTypeEnum.AboveTargetValue
        Me.Emailer2.UseSsl = True
        Me.Emailer2.Value = Nothing
        '
        'BasicButton2
        '
        Me.BasicButton2.BackColor = System.Drawing.Color.Black
        Me.BasicButton2.ComComponent = Me.SerialDF1forSLCMicroCom1
        Me.BasicButton2.ForeColor = System.Drawing.Color.Black
        Me.BasicButton2.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton2.Highlight = False
        Me.BasicButton2.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton2.Location = New System.Drawing.Point(629, 361)
        Me.BasicButton2.MaximumHoldTime = 3000
        Me.BasicButton2.MinimumHoldTime = 500
        Me.BasicButton2.Name = "BasicButton2"
        Me.BasicButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BasicButton2.PLCAddressClick = "B3:0/3"
        Me.BasicButton2.SelectTextAlternate = False
        Me.BasicButton2.Size = New System.Drawing.Size(134, 102)
        Me.BasicButton2.TabIndex = 70
        Me.BasicButton2.Text = "USE BLOWER"
        Me.BasicButton2.TextAlternate = Nothing
        Me.BasicButton2.UseVisualStyleBackColor = True
        Me.BasicButton2.ValueToWrite = 0
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1413, 825)
        Me.Controls.Add(Me.BasicButton2)
        Me.Controls.Add(Me.HydraulicCylinder1)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.ChartBySampling2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ChartBySampling1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SevenSegment23)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SevenSegment22)
        Me.Controls.Add(Me.SevenSegment21)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SMOKEHOUSE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialDF1forSLCMicroCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBySampling1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialDF1forSLCMicroCom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Emailer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBySampling2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Emailer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents SerialDF1forSLCMicroCom1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents SevenSegment21 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents SevenSegment22 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents SevenSegment23 As AdvancedHMIControls.SevenSegment2
    Friend WithEvents Label7 As Label
    Friend WithEvents ChartBySampling1 As AdvancedHMIControls.ChartBySampling
    Friend WithEvents SerialDF1forSLCMicroCom2 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents Emailer1 As AdvancedHMIControls.Emailer
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ChartBySampling2 As AdvancedHMIControls.ChartBySampling
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents HydraulicCylinder1 As AdvancedHMIControls.HydraulicCylinder
    Friend WithEvents Emailer2 As AdvancedHMIControls.Emailer
    Friend WithEvents BasicButton2 As AdvancedHMIControls.BasicButton
End Class
