Public Class Form4
    Sub Move(obj As PictureBox, x As Integer, y As Integer)
        obj.Location = New Point(obj.Location.X + x, obj.Location.Y + y)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Move(WaddleDee, -5, 0)
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Left, Keys.A
                Move(Avatar, -15, 0)
            Case Keys.Right, Keys.D
                Move(Avatar, +15, 0)
            Case Keys.Up, Keys.W
                Move(Avatar, 0, -100)
            Case Keys.Down, Keys.S
                Move(Avatar, 0, +10)
        End Select

    End Sub


    Function getObject(p As String) As PictureBox
        For Each c In Controls
            If c.name.toupper.ToString.Contains(p.ToUpper) Then
                Return c
            End If
        Next
    End Function
    Function Collision(p As String, t As String, Optional ByRef other As Object = vbNull)
        For Each c In Controls
            If c.name.toupper.ToString.Contains(p.ToUpper) Then
                Return Collision(c, t, other)
            End If
        Next

    End Function
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
        If p Is Nothing Then
            Return
        End If
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If
        Dim other As Object = Nothing
        If Collision("Avatar", "WIN", other) Then
            Me.BackColor = Color.Green
            other.visible = False
            'Form5.Visible = True
            Return

        End If
    End Sub

















End Class