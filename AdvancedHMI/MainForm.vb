Public Class MainForm
    Public screenWidth As Single
    Public screenHeight As Single
    Public txtOn As Boolean
    Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height


    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Public Function Read(ByRef y As String, ByRef x As Boolean)
        x = SerialDF1forSLCMicroCom1.Read(y)
        Return x

    End Function

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then

            MessageBox.Show("YOU MUST ENTER A TEMPERATURE (NUMBER ONLY)")
            Exit Sub
        End If
        Emailer2.TargetValue = TextBox2.Text
        Button1.Text = "TEXT AT " + Emailer2.TargetValue + " DEGREE"
        Emailer2.MessageBody = "YOUR TEMPERATURE HAS EXCEEDED " + Emailer2.TargetValue + " DEGREES"
        SevenSegment21.ForecolorHighLimitValue = TextBox2.Text
        SevenSegment21.ForecolorLowLimitValue = TextBox1.Text
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ChartBySampling1.Location = New Point(intX - intX + 50, intY - 480)
        ChartBySampling1.Size = New Size(intX / 2.5, intX / 5)
        ChartBySampling2.Location = New Point(ChartBySampling1.Location.X + 1050, ChartBySampling1.Location.Y)
        ChartBySampling2.Size = New Size(intX / 2.5, intX / 5)
        SevenSegment22.Location = New Point(intX - 683, intY - 900)
        SevenSegment23.Location = New Point(SevenSegment22.Location.X, SevenSegment22.Location.Y + 190)
        SevenSegment21.Location = New Point(intX - intX + 75, SevenSegment22.Location.Y)

        Label3.Location = New Point(SevenSegment22.Location.X + 30, SevenSegment22.Location.Y - 30)
        Label7.Location = New Point(SevenSegment23.Location.X + 30, SevenSegment23.Location.Y - 30)
        Label2.Location = New Point(SevenSegment21.Location.X + 30, SevenSegment21.Location.Y - 30)
        Label4.Location = New Point(SevenSegment21.Location.X + 30, SevenSegment23.Location.Y - 30)
        Label5.Location = New Point(SevenSegment21.Location.X + 30, Label4.Location.Y + 65)
        Label6.Location = New Point(SevenSegment21.Location.X + 785, SevenSegment21.Location.Y)

        TextBox1.Location = New Point(SevenSegment21.Location.X + 50, Label4.Location.Y + 30)
        TextBox2.Location = New Point(TextBox1.Location.X, TextBox1.Location.Y + 60)
        TextBox3.Location = New Point(Label6.Location.X + 20, Label6.Location.Y + 30)
        Button1.Location = New Point(TextBox2.Location.X, TextBox2.Location.Y + 35)
        Button2.Location = New Point(TextBox3.Location.X, TextBox3.Location.Y + 35)
        BasicButton2.Location = New Point(Button2.Location.X, Button2.Location.Y + 100)
        BasicButton1.Location = New Point(Button2.Location.X, BasicButton2.Location.Y + 100)
        HydraulicCylinder1.Location = New Point(Button2.Location.X - 120, BasicButton1.Location.Y + 110)
        screenHeight = Screen.PrimaryScreen.Bounds.Height / 5
        screenWidth = Screen.PrimaryScreen.Bounds.Width / 4
        Button2.Text = "TEXT AT " + Emailer1.TargetValue + " DEGREES"
        Emailer1.TargetValue = 300
        Emailer1.MessageBody = "YOUR TEMPERATURE HAS EXCEEDED " + Emailer1.TargetValue + " DEGREES"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Then

            MessageBox.Show("YOU MUST ENTER A TEMPERATURE (NUMBER ONLY)")
            Exit Sub
        End If
        Emailer1.TargetValue = TextBox3.Text



        Button2.Text = "TEXT AT " + Emailer1.TargetValue + " DEGREE"
        Emailer1.MessageBody = "YOUR TEMPERATURE HAS EXCEEDED " + Emailer1.TargetValue + " DEGREES"
    End Sub

    Private Sub BasicButton1_Click(sender As Object, e As EventArgs) Handles BasicButton1.Click

    End Sub

    Private Sub SevenSegment22_Click(sender As Object, e As EventArgs) Handles SevenSegment22.Click

    End Sub

    Private Sub BasicButton2_Click(sender As Object, e As EventArgs) Handles BasicButton2.Click
        Dim result As Boolean
        Dim address As String
        Dim hi = "1"
        Dim low = "0"
        address = "B3:0/3"
        Read(address, result)

        If result = hi Then
            BasicButton2.Text = "BLOWER ON"
        Else
            BasicButton2.Text = "BLOWER OFF"
        End If
    End Sub
    Public Sub Write(ByRef y As String, ByRef x As Boolean)
        SerialDF1forSLCMicroCom1.Write(y, x)

    End Sub
End Class
