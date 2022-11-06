Public Class Form1
    Dim SRight As Boolean
    Dim SLeft As Boolean
    Dim ShooterSpeed As Integer
    Dim ShotSpeed As Integer
    Dim InvaderSpeed As Integer
    Dim InvaderDrop As Integer
    Const NumOfInvaders As Integer = 100
    Dim IRight(NumOfInvaders) As Boolean
    Dim Invaders(NumOfInvaders) As PictureBox
    Dim x As Integer
    Dim ShotDown As Integer

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        Button2.Visible = False
        MoveShooter()
        FireShot()
        MoveInvader()
        CheckHit()
        CheckGameOver()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then
            SRight = True
            SLeft = False
        End If
        If e.KeyValue = Keys.Left Then
            SLeft = True
            SRight = False
        End If
    End Sub

    Private Sub MoveShooter()
        If SRight = True And Shooter.Left + Shooter.Width < Me.ClientRectangle.Width Then
            Shooter.Left += ShooterSpeed
        End If
        If SLeft = True And Shooter.Left > Me.ClientRectangle.Left Then
            Shooter.Left -= ShooterSpeed
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then
            SRight = False
        End If
        If e.KeyValue = Keys.Left Then
            SLeft = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Visible = False
        Button2.Visible = False

        LoadSetting()
        LoadInvaders()
    End Sub
    Private Sub LoadSetting()
        ShotSpeed = 30
        ShooterSpeed = 50
        Shot.Visible = False
        For Me.x = 1 To NumOfInvaders
            IRight(x) = True
        Next
        InvaderSpeed = 10
        InvaderDrop = 50
    End Sub
    Private Sub FireShot()
        If Shot.Visible = True Then
            Shot.Top -= ShotSpeed
        End If

        If Shot.Top + Shot.Height < Me.ClientRectangle.Top Then
            Shot.Visible = False
        End If
    End Sub
    Private Sub MoveInvader()

        For Me.x = 1 To NumOfInvaders
            If IRight(x) = True Then
                Invaders(x).Left += InvaderSpeed
            Else
                Invaders(x).Left -= InvaderSpeed
            End If

            If Invaders(x).Left + Invaders(x).Width > Me.ClientRectangle.Width And IRight(x) = True Then
                IRight(x) = False
                Invaders(x).Top += InvaderDrop
            End If

            If Invaders(x).Left < Me.ClientRectangle.Left And IRight(x) = False Then
                IRight(x) = True
                Invaders(x).Top += InvaderDrop
            End If
        Next

    End Sub

    Private Sub CheckGameOver()
        For Me.x = 1 To NumOfInvaders
            If Invaders(x).Top + Invaders(x).Height >= Shooter.Top And Invaders(x).Visible = True Then
                TimerMain.Enabled = False
                Me.x = NumOfInvaders
                MsgBox("You Lost!")
                Button1.Visible = True
                Button2.Visible = False
            End If
        Next
        If ShotDown = NumOfInvaders Then
            TimerMain.Enabled = False
            MsgBox("You Won!")
            Button1.Visible = True
            Button2.Visible = False
        End If
    End Sub

    Private Sub CheckHit()
        For Me.x = 1 To NumOfInvaders
            If (Shot.Top + Shot.Height >= Invaders(x).Top) And (Shot.Top <= Invaders(x).Top + Invaders(x).Height) And (Shot.Left + Shot.Width >= Invaders(x).Left) And (Shot.Left <= Invaders(x).Left + Invaders(x).Width) And Shot.Visible = True And Invaders(x).Visible = True Then
                Invaders(x).Visible = False

                Shot.Visible = False
                ShotDown += 1
            End If
        Next

    End Sub
    Private Sub LoadInvaders()
        Button2.Visible = False
        For Me.x = 1 To NumOfInvaders
            Invaders(x) = New PictureBox
            Invaders(x).Image = My.Resources._44
            Invaders(x).Width = 50
            Invaders(x).Height = 50
            Invaders(x).BackColor = Color.Transparent
            Invaders(x).Left = (-50 * x) - (x * 5)
            Controls.Add(Invaders(x))
        Next
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If Shot.Visible = False Then
            Shot.Top = Shooter.Top
            Shot.Left = Shooter.Left + (Shooter.Width / 2) - (Shot.Width / 2)
            Shot.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub

End Class