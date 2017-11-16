<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.lblTempTitel = New System.Windows.Forms.Label()
        Me.lblTempCBefore = New System.Windows.Forms.Label()
        Me.lblTempFBefore = New System.Windows.Forms.Label()
        Me.lblTempFAfter = New System.Windows.Forms.Label()
        Me.lblTempCAfter = New System.Windows.Forms.Label()
        Me.pnlGradeCalc = New System.Windows.Forms.Panel()
        Me.btnGradeInfo = New System.Windows.Forms.Button()
        Me.btnResetGradeCalc = New System.Windows.Forms.Button()
        Me.lblGradeCalcTitelMultiLine = New System.Windows.Forms.RichTextBox()
        Me.btnCalculateGrade = New System.Windows.Forms.Button()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblMark = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.PictureLinux = New System.Windows.Forms.PictureBox()
        Me.txtTempC = New System.Windows.Forms.TextBox()
        Me.txtTempF = New System.Windows.Forms.TextBox()
        Me.lblTempF = New System.Windows.Forms.Label()
        Me.lblTempC = New System.Windows.Forms.Label()
        Me.btnConvertCtoF = New System.Windows.Forms.Button()
        Me.btnConvertFtoC = New System.Windows.Forms.Button()
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.BestandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetAllesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SluitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinkemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MainTab = New System.Windows.Forms.TabPage()
        Me.btnResetTemp = New System.Windows.Forms.Button()
        Me.ExtraTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTipGradeCalc = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipTemp = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblSoundClick = New System.Windows.Forms.Label()
        Me.pnlGradeCalc.SuspendLayout()
        CType(Me.PictureLinux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenuStrip.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.MainTab.SuspendLayout()
        Me.ExtraTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitel.Location = New System.Drawing.Point(4, 31)
        Me.lblTitel.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(584, 30)
        Me.lblTitel.TabIndex = 0
        Me.lblTitel.Text = "Praktische Opdracht van Toine Rademacher"
        '
        'lblTempTitel
        '
        Me.lblTempTitel.AutoSize = True
        Me.lblTempTitel.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempTitel.Location = New System.Drawing.Point(3, 19)
        Me.lblTempTitel.Name = "lblTempTitel"
        Me.lblTempTitel.Size = New System.Drawing.Size(325, 34)
        Me.lblTempTitel.TabIndex = 2
        Me.lblTempTitel.Text = "Temperatuur Omzetter"
        '
        'lblTempCBefore
        '
        Me.lblTempCBefore.AutoSize = True
        Me.lblTempCBefore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTempCBefore.Location = New System.Drawing.Point(5, 74)
        Me.lblTempCBefore.Name = "lblTempCBefore"
        Me.lblTempCBefore.Size = New System.Drawing.Size(115, 16)
        Me.lblTempCBefore.TabIndex = 3
        Me.lblTempCBefore.Text = "Temperatuur in ºC"
        '
        'lblTempFBefore
        '
        Me.lblTempFBefore.AutoSize = True
        Me.lblTempFBefore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTempFBefore.Location = New System.Drawing.Point(5, 246)
        Me.lblTempFBefore.Name = "lblTempFBefore"
        Me.lblTempFBefore.Size = New System.Drawing.Size(114, 16)
        Me.lblTempFBefore.TabIndex = 4
        Me.lblTempFBefore.Text = "Temperatuur in ºF"
        '
        'lblTempFAfter
        '
        Me.lblTempFAfter.AutoSize = True
        Me.lblTempFAfter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempFAfter.Location = New System.Drawing.Point(246, 74)
        Me.lblTempFAfter.Name = "lblTempFAfter"
        Me.lblTempFAfter.Size = New System.Drawing.Size(114, 16)
        Me.lblTempFAfter.TabIndex = 5
        Me.lblTempFAfter.Text = "Temperatuur in ºF"
        '
        'lblTempCAfter
        '
        Me.lblTempCAfter.AutoSize = True
        Me.lblTempCAfter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTempCAfter.Location = New System.Drawing.Point(246, 246)
        Me.lblTempCAfter.Name = "lblTempCAfter"
        Me.lblTempCAfter.Size = New System.Drawing.Size(115, 16)
        Me.lblTempCAfter.TabIndex = 6
        Me.lblTempCAfter.Text = "Temperatuur in ºC"
        '
        'pnlGradeCalc
        '
        Me.pnlGradeCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlGradeCalc.Controls.Add(Me.btnGradeInfo)
        Me.pnlGradeCalc.Controls.Add(Me.btnResetGradeCalc)
        Me.pnlGradeCalc.Controls.Add(Me.lblGradeCalcTitelMultiLine)
        Me.pnlGradeCalc.Controls.Add(Me.btnCalculateGrade)
        Me.pnlGradeCalc.Controls.Add(Me.lblGrade)
        Me.pnlGradeCalc.Controls.Add(Me.lblMark)
        Me.pnlGradeCalc.Controls.Add(Me.txtGrade)
        Me.pnlGradeCalc.Controls.Add(Me.txtMark)
        Me.pnlGradeCalc.Location = New System.Drawing.Point(459, 12)
        Me.pnlGradeCalc.Name = "pnlGradeCalc"
        Me.pnlGradeCalc.Size = New System.Drawing.Size(297, 181)
        Me.pnlGradeCalc.TabIndex = 7
        '
        'btnGradeInfo
        '
        Me.btnGradeInfo.Location = New System.Drawing.Point(253, 107)
        Me.btnGradeInfo.Name = "btnGradeInfo"
        Me.btnGradeInfo.Size = New System.Drawing.Size(36, 35)
        Me.btnGradeInfo.TabIndex = 17
        Me.btnGradeInfo.Text = "?"
        Me.btnGradeInfo.UseVisualStyleBackColor = True
        '
        'btnResetGradeCalc
        '
        Me.btnResetGradeCalc.Location = New System.Drawing.Point(11, 145)
        Me.btnResetGradeCalc.Name = "btnResetGradeCalc"
        Me.btnResetGradeCalc.Size = New System.Drawing.Size(278, 30)
        Me.btnResetGradeCalc.TabIndex = 16
        Me.btnResetGradeCalc.Text = "R e s e t   G r a d e   C a l c u l a t o r"
        Me.ToolTipGradeCalc.SetToolTip(Me.btnResetGradeCalc, "Dit reset alle 2 de textboxen van de grade calculator.")
        Me.btnResetGradeCalc.UseVisualStyleBackColor = True
        '
        'lblGradeCalcTitelMultiLine
        '
        Me.lblGradeCalcTitelMultiLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGradeCalcTitelMultiLine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblGradeCalcTitelMultiLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeCalcTitelMultiLine.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblGradeCalcTitelMultiLine.Location = New System.Drawing.Point(10, 7)
        Me.lblGradeCalcTitelMultiLine.Name = "lblGradeCalcTitelMultiLine"
        Me.lblGradeCalcTitelMultiLine.ReadOnly = True
        Me.lblGradeCalcTitelMultiLine.Size = New System.Drawing.Size(279, 34)
        Me.lblGradeCalcTitelMultiLine.TabIndex = 15
        Me.lblGradeCalcTitelMultiLine.Text = "Grade Calculator uit opdracht 13 van VB Tutor.net, maar nu in een panel."
        '
        'btnCalculateGrade
        '
        Me.btnCalculateGrade.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateGrade.Location = New System.Drawing.Point(10, 107)
        Me.btnCalculateGrade.Name = "btnCalculateGrade"
        Me.btnCalculateGrade.Size = New System.Drawing.Size(237, 35)
        Me.btnCalculateGrade.TabIndex = 10
        Me.btnCalculateGrade.Text = "C a l c u l a t e   G r a d e"
        Me.ToolTipGradeCalc.SetToolTip(Me.btnCalculateGrade, resources.GetString("btnCalculateGrade.ToolTip"))
        Me.btnCalculateGrade.UseVisualStyleBackColor = True
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblGrade.Location = New System.Drawing.Point(7, 77)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(165, 16)
        Me.lblGrade.TabIndex = 9
        Me.lblGrade.Text = "Your Grade Appears Here"
        '
        'lblMark
        '
        Me.lblMark.AutoSize = True
        Me.lblMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblMark.Location = New System.Drawing.Point(8, 47)
        Me.lblMark.Name = "lblMark"
        Me.lblMark.Size = New System.Drawing.Size(161, 16)
        Me.lblMark.TabIndex = 8
        Me.lblMark.Text = "Please Enter Mark (0/100)"
        '
        'txtGrade
        '
        Me.txtGrade.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade.Location = New System.Drawing.Point(189, 72)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.ReadOnly = True
        Me.txtGrade.Size = New System.Drawing.Size(100, 26)
        Me.txtGrade.TabIndex = 7
        Me.txtGrade.Text = "#"
        '
        'txtMark
        '
        Me.txtMark.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtMark.Location = New System.Drawing.Point(189, 42)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(100, 26)
        Me.txtMark.TabIndex = 6
        '
        'PictureLinux
        '
        Me.PictureLinux.Image = CType(resources.GetObject("PictureLinux.Image"), System.Drawing.Image)
        Me.PictureLinux.InitialImage = Nothing
        Me.PictureLinux.Location = New System.Drawing.Point(459, 193)
        Me.PictureLinux.Name = "PictureLinux"
        Me.PictureLinux.Size = New System.Drawing.Size(297, 130)
        Me.PictureLinux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureLinux.TabIndex = 8
        Me.PictureLinux.TabStop = False
        '
        'txtTempC
        '
        Me.txtTempC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtTempC.Location = New System.Drawing.Point(7, 91)
        Me.txtTempC.Name = "txtTempC"
        Me.txtTempC.Size = New System.Drawing.Size(111, 22)
        Me.txtTempC.TabIndex = 9
        Me.ToolTipTemp.SetToolTip(Me.txtTempC, "Voer hier het aantal graden celcius in die je wilt laten omzetten," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en druk daarn" &
        "a op enter of klik op de knop met de pijl hiernaast.")
        '
        'txtTempF
        '
        Me.txtTempF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtTempF.Location = New System.Drawing.Point(7, 265)
        Me.txtTempF.Name = "txtTempF"
        Me.txtTempF.Size = New System.Drawing.Size(111, 22)
        Me.txtTempF.TabIndex = 10
        Me.ToolTipTemp.SetToolTip(Me.txtTempF, "Voer hier het aantal fahrenheit in die je wilt laten omzetten," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en druk daarna op" &
        " enter of klik op de knop met de pijl hiernaast.")
        '
        'lblTempF
        '
        Me.lblTempF.AutoSize = True
        Me.lblTempF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTempF.Location = New System.Drawing.Point(248, 94)
        Me.lblTempF.Name = "lblTempF"
        Me.lblTempF.Size = New System.Drawing.Size(169, 16)
        Me.lblTempF.TabIndex = 11
        Me.lblTempF.Text = "Voer eerst aantal graden in"
        '
        'lblTempC
        '
        Me.lblTempC.AutoSize = True
        Me.lblTempC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTempC.Location = New System.Drawing.Point(248, 268)
        Me.lblTempC.Name = "lblTempC"
        Me.lblTempC.Size = New System.Drawing.Size(184, 16)
        Me.lblTempC.TabIndex = 12
        Me.lblTempC.Text = "Voer eerst aantal fahrenheit in"
        '
        'btnConvertCtoF
        '
        Me.btnConvertCtoF.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertCtoF.Location = New System.Drawing.Point(125, 74)
        Me.btnConvertCtoF.Name = "btnConvertCtoF"
        Me.btnConvertCtoF.Size = New System.Drawing.Size(115, 39)
        Me.btnConvertCtoF.TabIndex = 13
        Me.btnConvertCtoF.Text = "==>"
        Me.ToolTipTemp.SetToolTip(Me.btnConvertCtoF, "Als je op deze knop klikt (je kan ook op enter drukken in de textbox), dan wordt " &
        "het aantal graden celcius omgezet in fahrenheit." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnConvertCtoF.UseVisualStyleBackColor = True
        '
        'btnConvertFtoC
        '
        Me.btnConvertFtoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertFtoC.Location = New System.Drawing.Point(123, 246)
        Me.btnConvertFtoC.Name = "btnConvertFtoC"
        Me.btnConvertFtoC.Size = New System.Drawing.Size(117, 41)
        Me.btnConvertFtoC.TabIndex = 14
        Me.btnConvertFtoC.Text = "==>"
        Me.ToolTipTemp.SetToolTip(Me.btnConvertFtoC, "Als je op deze knop klikt (je kan ook op enter drukken in de textbox)," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dan wordt" &
        " het aantal fahrenheit omgezet in graden celcius.")
        Me.btnConvertFtoC.UseVisualStyleBackColor = True
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BestandToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Margin = New System.Windows.Forms.Padding(2)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(769, 24)
        Me.MainMenuStrip.TabIndex = 1
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        'BestandToolStripMenuItem
        '
        Me.BestandToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetAllesToolStripMenuItem, Me.ToolStripSeparator2, Me.SluitenToolStripMenuItem})
        Me.BestandToolStripMenuItem.Name = "BestandToolStripMenuItem"
        Me.BestandToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.BestandToolStripMenuItem.Text = "Beheer"
        '
        'ResetAllesToolStripMenuItem
        '
        Me.ResetAllesToolStripMenuItem.Name = "ResetAllesToolStripMenuItem"
        Me.ResetAllesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetAllesToolStripMenuItem.Text = "Reset Alles"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'SluitenToolStripMenuItem
        '
        Me.SluitenToolStripMenuItem.Name = "SluitenToolStripMenuItem"
        Me.SluitenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SluitenToolStripMenuItem.Text = "Sluiten"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OverToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'OverToolStripMenuItem
        '
        Me.OverToolStripMenuItem.Name = "OverToolStripMenuItem"
        Me.OverToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.OverToolStripMenuItem.Text = "Over"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.YouTubeToolStripMenuItem, Me.MinkemaToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.InfoToolStripMenuItem.Text = "Websites"
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.GoogleToolStripMenuItem.Text = "Google"
        '
        'YouTubeToolStripMenuItem
        '
        Me.YouTubeToolStripMenuItem.Name = "YouTubeToolStripMenuItem"
        Me.YouTubeToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.YouTubeToolStripMenuItem.Text = "YouTube"
        '
        'MinkemaToolStripMenuItem
        '
        Me.MinkemaToolStripMenuItem.Name = "MinkemaToolStripMenuItem"
        Me.MinkemaToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.MinkemaToolStripMenuItem.Text = "Minkema"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.MainTab)
        Me.TabControl1.Controls.Add(Me.ExtraTab)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TabControl1.Location = New System.Drawing.Point(5, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(763, 352)
        Me.TabControl1.TabIndex = 15
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.btnResetTemp)
        Me.MainTab.Controls.Add(Me.PictureLinux)
        Me.MainTab.Controls.Add(Me.lblTempC)
        Me.MainTab.Controls.Add(Me.btnConvertFtoC)
        Me.MainTab.Controls.Add(Me.lblTempF)
        Me.MainTab.Controls.Add(Me.lblTempCAfter)
        Me.MainTab.Controls.Add(Me.pnlGradeCalc)
        Me.MainTab.Controls.Add(Me.btnConvertCtoF)
        Me.MainTab.Controls.Add(Me.lblTempTitel)
        Me.MainTab.Controls.Add(Me.lblTempFAfter)
        Me.MainTab.Controls.Add(Me.lblTempCBefore)
        Me.MainTab.Controls.Add(Me.txtTempC)
        Me.MainTab.Controls.Add(Me.txtTempF)
        Me.MainTab.Controls.Add(Me.lblTempFBefore)
        Me.MainTab.Location = New System.Drawing.Point(4, 25)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTab.Size = New System.Drawing.Size(755, 323)
        Me.MainTab.TabIndex = 0
        Me.MainTab.Text = "PO Opdracht"
        Me.MainTab.UseVisualStyleBackColor = True
        '
        'btnResetTemp
        '
        Me.btnResetTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetTemp.Location = New System.Drawing.Point(8, 139)
        Me.btnResetTemp.Name = "btnResetTemp"
        Me.btnResetTemp.Size = New System.Drawing.Size(424, 66)
        Me.btnResetTemp.TabIndex = 15
        Me.btnResetTemp.Text = "R e s e t   T e m p e r a t u u r   O m z e t t e r"
        Me.ToolTipTemp.SetToolTip(Me.btnResetTemp, "Dit reset alle 2 de textboxen en alle 2 de uitvoer labels van de temperatuur omze" &
        "tter.")
        Me.btnResetTemp.UseVisualStyleBackColor = True
        '
        'ExtraTab
        '
        Me.ExtraTab.Controls.Add(Me.Label1)
        Me.ExtraTab.Location = New System.Drawing.Point(4, 25)
        Me.ExtraTab.Name = "ExtraTab"
        Me.ExtraTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ExtraTab.Size = New System.Drawing.Size(755, 323)
        Me.ExtraTab.TabIndex = 1
        Me.ExtraTab.Text = "Extra's"
        Me.ExtraTab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coming Soon"
        '
        'ToolTipGradeCalc
        '
        Me.ToolTipGradeCalc.ToolTipTitle = "Grade Calculator"
        '
        'ToolTipTemp
        '
        Me.ToolTipTemp.ToolTipTitle = "Temperatuur Omzetter"
        '
        'lblSoundClick
        '
        Me.lblSoundClick.AutoSize = True
        Me.lblSoundClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSoundClick.Location = New System.Drawing.Point(599, 39)
        Me.lblSoundClick.Name = "lblSoundClick"
        Me.lblSoundClick.Size = New System.Drawing.Size(147, 16)
        Me.lblSoundClick.TabIndex = 16
        Me.lblSoundClick.Text = "<= CLICK FOR SOUND!"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(769, 417)
        Me.Controls.Add(Me.lblSoundClick)
        Me.Controls.Add(Me.lblTitel)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PO Havo4 - Toine Rademacher"
        Me.pnlGradeCalc.ResumeLayout(False)
        Me.pnlGradeCalc.PerformLayout()
        CType(Me.PictureLinux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.MainTab.ResumeLayout(False)
        Me.MainTab.PerformLayout()
        Me.ExtraTab.ResumeLayout(False)
        Me.ExtraTab.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitel As Label
    Friend WithEvents lblTempTitel As Label
    Friend WithEvents lblTempCBefore As Label
    Friend WithEvents lblTempFBefore As Label
    Friend WithEvents lblTempFAfter As Label
    Friend WithEvents lblTempCAfter As Label
    Friend WithEvents pnlGradeCalc As Panel
    Friend WithEvents PictureLinux As PictureBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtMark As TextBox
    Friend WithEvents txtTempC As TextBox
    Friend WithEvents txtTempF As TextBox
    Friend WithEvents lblTempF As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblMark As Label
    Friend WithEvents lblTempC As Label
    Friend WithEvents btnCalculateGrade As Button
    Friend WithEvents btnConvertCtoF As Button
    Friend WithEvents btnConvertFtoC As Button
    Friend WithEvents lblGradeCalcTitelMultiLine As RichTextBox
    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents BestandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SluitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents MainTab As TabPage
    Friend WithEvents ExtraTab As TabPage
    Friend WithEvents ToolTipGradeCalc As ToolTip
    Friend WithEvents btnResetTemp As Button
    Friend WithEvents btnResetGradeCalc As Button
    Friend WithEvents ToolTipTemp As ToolTip
    Friend WithEvents btnGradeInfo As Button
    Friend WithEvents GoogleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YouTubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinkemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetAllesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents lblSoundClick As Label
    Friend WithEvents Label1 As Label
End Class
