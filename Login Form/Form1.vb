Imports System.ComponentModel
Public Class Form1
    Dim direction As Integer = -5
    'Register Animation
    Private Sub ElementsRegisterMove_Tick(sender As Object, e As EventArgs) Handles ElementsRegisterMove.Tick
        ElementsRegister.Location = New Point(ElementsRegister.Location.X - direction, ElementsRegister.Location.Y)
        ElementsRegisterMove.Stop()
        Select Case ElementsRegister.Location.X
            Case 0
                ElementsRegisterMove.Stop()
                AnimationEnd()
                Me.BackgroundImage = My.Resources.bkreg
            Case 200
                Panel1.Dock = DockStyle.None
                PanelMove.Start()
            Case Else
                ElementsRegisterMove.Start()
        End Select

    End Sub
    'Login Animation
    Private Sub ElementsLoginMove_Tick(sender As Object, e As EventArgs) Handles ElementsLoginMove.Tick
        ElementsLogin.Location = New Point(ElementsLogin.Location.X - direction, ElementsLogin.Location.Y)
        Select Case ElementsLogin.Location.X
            Case 0
                ElementsLoginMove.Stop()
                AnimationEnd()
                Me.BackgroundImage = My.Resources.bklog
            Case -200
                Panel1.Dock = DockStyle.None
                PanelMove.Start()
                ElementsLoginMove.Stop()
        End Select
    End Sub
    'Panel animation to left & right
    Private Sub PanelMove_Tick(sender As Object, e As EventArgs) Handles PanelMove.Tick
        Panel1.Location = New Point(Panel1.Location.X + direction * 4S, Panel1.Location.Y)
        PanelMove.Stop()
        Select Case Panel1.Location.X
            Case 700
                Panel1.Dock = DockStyle.Right
                ElementsRegisterMove.Start()
            Case 0
                Panel1.Dock = DockStyle.Left
                ElementsLoginMove.Start()
            Case Else
                PanelMove.Start()
        End Select
    End Sub
    'Animation terms (needed to avoid visual glitches and bugs)
    Sub AnimationBegin()
        Panel1.BackgroundImage = Nothing
        Panel1.BackColor = Color.FromArgb(64, 64, 64)
        ElementsLogin.BackColor = Color.FromArgb(64, 64, 64)
        ElementsRegister.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Sub AnimationEnd()
        Panel1.BackgroundImage = My.Resources.Black_Transparent_Gradient
        V0()
        Application.DoEvents()
    End Sub
    'Initialize components
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ElementsRegister.Location = New Point(200, 60)
        btnLog.ButtonText = "Login"
        btnReg1.ButtonText = "Sing Up"
        btnRegister.ButtonText = "New account"
        V0()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        direction *= -1
        Panel1.Dock = DockStyle.None
        AnimationBegin()
        ElementsLoginMove.Start()
    End Sub

    Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel5.Click
        direction *= -1
        Panel1.Dock = DockStyle.None
        AnimationBegin()
        ElementsRegisterMove.Start()
    End Sub

    Sub V0()
        Panel1.BackColor = Color.Transparent
        ElementsLogin.BackColor = Color.Transparent
        ElementsRegister.BackColor = Color.Transparent
        btnLog.BackColor = Color.Transparent
        btnRegister.BackColor = Color.Transparent
        btnReg1.BackColor = Color.Transparent
    End Sub

End Class
