Public Class Main
    '=================Main Form Load==============='
    'load form ' 
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    '================Losse dingen==================='

    Private Sub lblTitel_Click(sender As Object, e As EventArgs) Handles lblTitel.Click
        My.Computer.Audio.Play(My.Resources.Google, AudioPlayMode.Background)
        'Speel geluid als je op de titel klikt ' 
    End Sub


    Private Sub PictureLinux_Click(sender As Object, e As EventArgs) Handles PictureLinux.Click
        Process.Start("https://www.nllgg.nl/")
        'Als je op het Linux plaatje klikt ga je naar de website,'
        'van de Nederlandse Linux Gebruikers Groep.'
    End Sub

    '=============================================='



    '================MainMENUSTRIP====================='

    Private Sub OverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverToolStripMenuItem.Click
        MsgBox("Dit programmaatje is gemaakt door Toine Rademacher uit klas 4hb. Docent informatica Marcel Voorn. Schooljaar 2015-2016")
        ' Over knop geeft info message box' 
    End Sub


    Private Sub SluitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SluitenToolStripMenuItem.Click
        Me.Close()
        ' Sluit programma ipv op rood kruisje te kliken' 
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleToolStripMenuItem.Click
        Process.Start("https://www.google.nl/")
        ' Ga naar google' 

    End Sub

    Private Sub YouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeToolStripMenuItem.Click
        Process.Start("https://www.YouTube.nl/")
        ' Ga naar youtube' 

    End Sub

    Private Sub MinkemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinkemaToolStripMenuItem.Click
        Process.Start("https://www.minkema.nl/")
        ' Ga naar minkema site' 
    End Sub


    '==============================================='

    '================TEMPCONVERT===================='

    Private Sub btnConvertCtoF_Click(sender As Object, e As EventArgs) Handles btnConvertCtoF.Click
        If txtTempC.Text.Length = 0 Then
            MsgBox("Je moet minimaal één cijfer invoeren!")
        Else
            lblTempF.Text = (((txtTempC.Text) * 1.8) + 32)
            ' Van C naar F omrekening' 

        End If
    End Sub


    Private Sub btnConvertFtoC_Click(sender As Object, e As EventArgs) Handles btnConvertFtoC.Click
        If txtTempF.Text.Length <= 0 Then
            MsgBox("Je moet minimaal één cijfer invoeren!")
        Else
            lblTempC.Text = (((txtTempF.Text) - 32) / 1.8)
            ' Van F naar C omrekening' 
        End If
    End Sub


    Private Sub txtTempF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTempF.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                ' Alleen cijfers invoeren ascii karakters' 

            End If
        End If
    End Sub

    Private Sub txtTempC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTempC.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            ' Alleen cijfers invoeren ascii karakters' 
        End If
    End Sub

    Private Sub txtTempC_TextChanged(sender As Object, e As EventArgs) Handles txtTempC.TextChanged
        AcceptButton = btnConvertCtoF
        'Je kan op enter drukken om omrekening uit te voeren ipv op de pijlknop te klikken ' 

    End Sub

    Private Sub txtTempF_TextChanged(sender As Object, e As EventArgs) Handles txtTempF.TextChanged
        AcceptButton = btnConvertFtoC
        'Je kan op enter drukken om omrekening uit te voeren ipv op de pijlknop te klikken ' 

    End Sub

    Private Sub btnResetTemp_Click(sender As Object, e As EventArgs) Handles btnResetTemp.Click
        txtTempC.Text = Nothing
        lblTempF.Text = ("Voer eerst aantal graden in")
        txtTempF.Text = Nothing
        lblTempC.Text = "Voer eerst aantal fahrenheit in"
        'Zoals je hierboven ziet heb ik voor de label reset, 1 met en 1 zonder haakjes gebruikt. Ze werken allebei gewoon'
    End Sub

    '==============================================='

    '==================GRADE CALC==================='

    Private Sub btnCalculateGrade_Click(sender As Object, e As EventArgs) Handles btnCalculateGrade.Click
        If txtMark.Text.Length <= 0 Then
            MsgBox("Je moet minimaal één cijfer invoeren!")
        Else
            Dim Mark As Integer
            Dim Grade As String

            Mark = txtMark.Text
            If Mark >= 90 And Mark <= 100 Then
                Grade = “A”

            ElseIf Mark >= 80 And Mark < 90 Then
                Grade = “B”

            ElseIf Mark >= 70 And Mark < 80 Then
                Grade = “C”

            ElseIf Mark >= 65 And Mark < 70 Then
                Grade = “D”

            ElseIf Mark >= 0 And Mark < 65 Then
                Grade = “E/F (Fail)”

            Else
                Grade = “Out of Range”

            End If

            txtGrade.Text = Grade
            'De omrekening van grade naar mark ' 
        End If
    End Sub


    Private Sub btnResetGradeCalc_Click(sender As Object, e As EventArgs) Handles btnResetGradeCalc.Click
        txtMark.Text = Nothing
        txtGrade.Text = "#"
        'Grade calc reset ' 
    End Sub


    Private Sub txtMark_TextChanged(sender As Object, e As EventArgs) Handles txtMark.TextChanged
        AcceptButton = btnCalculateGrade
        'Je kan op enter drukken om omrekening uit te voeren ipv op de calculate knop te klikken ' 
    End Sub


    Private Sub txtMark_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMark.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        'Je kan alleen geen letters invoeren  invoeren in de invoer textbox van je Mark (cijfer)'

    End Sub


    Private Sub btnCalculateGrade_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCalculateGrade.MouseDown
        If e.Button = MouseButtons.Right Then
            GradeCalcFoto.Show()
        End If
        'Als je rechtermuisknop klikt op calculate grade, dan krijg je het omzettabelletje'
    End Sub

    Private Sub btnGradeInfo_Click(sender As Object, e As EventArgs) Handles btnGradeInfo.Click
        MsgBox("TIP: ALS JE OP DE CALCULATE KNOP MET JE RECHTERMUISKNOP KLIKT, KRIJG JE EEN POP-UP MET EEN PLAATJE VAN DE AMERIKAANSE OMZETTABEL")
        ' Vraagteken button geeft uitleg popup' 
    End Sub

    Private Sub ResetAllesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResetAllesToolStripMenuItem.Click
        txtTempC.Text = Nothing
        lblTempF.Text = ("Voer eerst aantal graden in")
        txtTempF.Text = Nothing
        lblTempC.Text = "Voer eerst aantal fahrenheit in"
        '---' 
        txtMark.Text = Nothing
        txtGrade.Text = "#"
        ' Reset alles terug' 
    End Sub




    '============================================'

End Class