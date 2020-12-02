
Public Class GameLevel1
    Dim Direction As Integer
    Dim xOffset As Integer
    Dim yOffset As Integer
    Dim r As New Random()

    Sub Move(obj As PictureBox, x As Integer, y As Integer)
        obj.Location = New Point(obj.Location.X + x, obj.Location.Y + y)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        chase(BrontoBurt)
        Move(sirKibble, -3, 0)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Left, Keys.A
                MoveTo(Avatar, -15, 0)
            Case Keys.Right, Keys.D
                MoveTo(Avatar, +15, 0)
            Case Keys.Up, Keys.W
                MoveTo(Avatar, 0, -100)
                Timer3.Enabled = True
            Case Keys.Down, Keys.S
                MoveTo(Avatar, 0, +10)
            Case Keys.Space
                Bullet.Location = Avatar.Location
                Timer2.Enabled = True

            Case Keys.R
                Direction = Direction + 1
                Avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                Me.Refresh()
            Case Keys.L
                Direction = Direction - 1
                Avatar.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                Me.Refresh()

        End Select

    End Sub

    'Sub RandomMove(p As PictureBox)
    'Dim xDir As Integer = r.Next(-20, 20)
    'Dim yDir As Integer = r.Next(-20, 20)
    'MoveTo(p, xDir, yDir)
    'End Sub






    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(RightWall.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > Avatar.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)

    End Sub



    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If
        Dim other As Object = Nothing
        If p.Name = "Avatar" And Collision(p, "WIN", other) Then
            Me.BackColor = Color.Green
            other.visible = False
            WinScreen.Visible = True
            BrontoBurt.Visible = False
            Return

        End If

        If p.Name = "Avatar" And Collision(p, "sirKibble", other) Then
            Avatar.Image = Cutter.Image
            other.visible = False
            Bullet.Visible = True
            Return

        End If

        If p.Name = "Bullet" And Collision(p, "BrontoBurt", other) Then
            BrontoBurt.Visible = False
        End If

        If p.Name = "Avatar" And Collision(p, "BrontoBurt", other) Then
            Avatar.Visible = False
            Bullet.Visible = False
            LoseScreen.Visible = True
        End If

        If p.Name = "Avatar" And Collision(p, "RightWall", other) Then

        End If

    End Sub




    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Direction < 0 Then
            MoveTo(Bullet, -5, 0)
        End If
        MoveTo(Bullet, 50, 0)
        MoveTo(Bullet, 5, 0)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MoveTo(Avatar, 0, yOffset + 15)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        MoveTo(sirKibble, 0, 20)
    End Sub


    'Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
    'RandomMove(BrontoBurt)

    'End Sub

End Class

