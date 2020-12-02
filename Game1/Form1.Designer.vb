<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameLevel1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameLevel1))
        Me.Avatar = New System.Windows.Forms.PictureBox()
        Me.BrontoBurt = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LeftWall = New System.Windows.Forms.PictureBox()
        Me.RightWall = New System.Windows.Forms.PictureBox()
        Me.TopWall = New System.Windows.Forms.PictureBox()
        Me.BottomWall = New System.Windows.Forms.PictureBox()
        Me.Ground1Wall = New System.Windows.Forms.PictureBox()
        Me.Ground3Wall = New System.Windows.Forms.PictureBox()
        Me.Ground5Wall = New System.Windows.Forms.PictureBox()
        Me.Ground2Wall = New System.Windows.Forms.PictureBox()
        Me.Ground4Wall = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.WIN = New System.Windows.Forms.PictureBox()
        Me.sirKibble = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Cutter = New System.Windows.Forms.PictureBox()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrontoBurt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ground1Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ground3Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ground5Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ground2Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ground4Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sirKibble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cutter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Avatar
        '
        Me.Avatar.BackColor = System.Drawing.Color.Transparent
        Me.Avatar.Image = CType(resources.GetObject("Avatar.Image"), System.Drawing.Image)
        Me.Avatar.Location = New System.Drawing.Point(14, 215)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(81, 93)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar.TabIndex = 0
        Me.Avatar.TabStop = False
        '
        'BrontoBurt
        '
        Me.BrontoBurt.BackColor = System.Drawing.Color.Transparent
        Me.BrontoBurt.Image = CType(resources.GetObject("BrontoBurt.Image"), System.Drawing.Image)
        Me.BrontoBurt.Location = New System.Drawing.Point(685, 105)
        Me.BrontoBurt.Name = "BrontoBurt"
        Me.BrontoBurt.Size = New System.Drawing.Size(49, 49)
        Me.BrontoBurt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BrontoBurt.TabIndex = 1
        Me.BrontoBurt.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 75
        '
        'LeftWall
        '
        Me.LeftWall.BackColor = System.Drawing.Color.Transparent
        Me.LeftWall.Location = New System.Drawing.Point(-125, 0)
        Me.LeftWall.Name = "LeftWall"
        Me.LeftWall.Size = New System.Drawing.Size(133, 450)
        Me.LeftWall.TabIndex = 2
        Me.LeftWall.TabStop = False
        '
        'RightWall
        '
        Me.RightWall.BackColor = System.Drawing.Color.Transparent
        Me.RightWall.Location = New System.Drawing.Point(796, 0)
        Me.RightWall.Name = "RightWall"
        Me.RightWall.Size = New System.Drawing.Size(10, 450)
        Me.RightWall.TabIndex = 3
        Me.RightWall.TabStop = False
        '
        'TopWall
        '
        Me.TopWall.BackColor = System.Drawing.Color.Transparent
        Me.TopWall.Location = New System.Drawing.Point(-2, -110)
        Me.TopWall.Name = "TopWall"
        Me.TopWall.Size = New System.Drawing.Size(804, 120)
        Me.TopWall.TabIndex = 4
        Me.TopWall.TabStop = False
        '
        'BottomWall
        '
        Me.BottomWall.BackColor = System.Drawing.Color.Transparent
        Me.BottomWall.Location = New System.Drawing.Point(-2, 440)
        Me.BottomWall.Name = "BottomWall"
        Me.BottomWall.Size = New System.Drawing.Size(804, 91)
        Me.BottomWall.TabIndex = 5
        Me.BottomWall.TabStop = False
        '
        'Ground1Wall
        '
        Me.Ground1Wall.BackColor = System.Drawing.Color.Transparent
        Me.Ground1Wall.Location = New System.Drawing.Point(0, 309)
        Me.Ground1Wall.Name = "Ground1Wall"
        Me.Ground1Wall.Size = New System.Drawing.Size(500, 10)
        Me.Ground1Wall.TabIndex = 6
        Me.Ground1Wall.TabStop = False
        '
        'Ground3Wall
        '
        Me.Ground3Wall.BackColor = System.Drawing.Color.Transparent
        Me.Ground3Wall.Location = New System.Drawing.Point(468, 264)
        Me.Ground3Wall.Name = "Ground3Wall"
        Me.Ground3Wall.Size = New System.Drawing.Size(275, 17)
        Me.Ground3Wall.TabIndex = 7
        Me.Ground3Wall.TabStop = False
        '
        'Ground5Wall
        '
        Me.Ground5Wall.BackColor = System.Drawing.Color.Transparent
        Me.Ground5Wall.Location = New System.Drawing.Point(736, 176)
        Me.Ground5Wall.Name = "Ground5Wall"
        Me.Ground5Wall.Size = New System.Drawing.Size(66, 10)
        Me.Ground5Wall.TabIndex = 8
        Me.Ground5Wall.TabStop = False
        '
        'Ground2Wall
        '
        Me.Ground2Wall.BackColor = System.Drawing.Color.Transparent
        Me.Ground2Wall.Location = New System.Drawing.Point(468, 264)
        Me.Ground2Wall.Name = "Ground2Wall"
        Me.Ground2Wall.Size = New System.Drawing.Size(11, 56)
        Me.Ground2Wall.TabIndex = 9
        Me.Ground2Wall.TabStop = False
        '
        'Ground4Wall
        '
        Me.Ground4Wall.BackColor = System.Drawing.Color.Transparent
        Me.Ground4Wall.Location = New System.Drawing.Point(735, 176)
        Me.Ground4Wall.Name = "Ground4Wall"
        Me.Ground4Wall.Size = New System.Drawing.Size(10, 105)
        Me.Ground4Wall.TabIndex = 10
        Me.Ground4Wall.TabStop = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.Image = CType(resources.GetObject("Bullet.Image"), System.Drawing.Image)
        Me.Bullet.Location = New System.Drawing.Point(723, 380)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(67, 58)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 11
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'WIN
        '
        Me.WIN.BackColor = System.Drawing.Color.Transparent
        Me.WIN.Image = CType(resources.GetObject("WIN.Image"), System.Drawing.Image)
        Me.WIN.Location = New System.Drawing.Point(757, 127)
        Me.WIN.Name = "WIN"
        Me.WIN.Size = New System.Drawing.Size(44, 43)
        Me.WIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WIN.TabIndex = 12
        Me.WIN.TabStop = False
        '
        'sirKibble
        '
        Me.sirKibble.BackColor = System.Drawing.Color.Transparent
        Me.sirKibble.Image = CType(resources.GetObject("sirKibble.Image"), System.Drawing.Image)
        Me.sirKibble.Location = New System.Drawing.Point(376, 236)
        Me.sirKibble.Name = "sirKibble"
        Me.sirKibble.Size = New System.Drawing.Size(65, 67)
        Me.sirKibble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sirKibble.TabIndex = 13
        Me.sirKibble.TabStop = False
        '
        'Timer3
        '
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 300
        '
        'Cutter
        '
        Me.Cutter.BackColor = System.Drawing.Color.Transparent
        Me.Cutter.Image = CType(resources.GetObject("Cutter.Image"), System.Drawing.Image)
        Me.Cutter.Location = New System.Drawing.Point(542, 324)
        Me.Cutter.Name = "Cutter"
        Me.Cutter.Size = New System.Drawing.Size(100, 110)
        Me.Cutter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cutter.TabIndex = 14
        Me.Cutter.TabStop = False
        Me.Cutter.Visible = False
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        '
        'GameLevel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Cutter)
        Me.Controls.Add(Me.sirKibble)
        Me.Controls.Add(Me.WIN)
        Me.Controls.Add(Me.Ground4Wall)
        Me.Controls.Add(Me.Ground2Wall)
        Me.Controls.Add(Me.Ground5Wall)
        Me.Controls.Add(Me.Ground3Wall)
        Me.Controls.Add(Me.Ground1Wall)
        Me.Controls.Add(Me.BottomWall)
        Me.Controls.Add(Me.TopWall)
        Me.Controls.Add(Me.RightWall)
        Me.Controls.Add(Me.LeftWall)
        Me.Controls.Add(Me.Avatar)
        Me.Controls.Add(Me.BrontoBurt)
        Me.Controls.Add(Me.Bullet)
        Me.DoubleBuffered = True
        Me.Name = "GameLevel1"
        Me.Text = "Level1"
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrontoBurt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ground1Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ground3Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ground5Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ground2Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ground4Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sirKibble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cutter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents BrontoBurt As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LeftWall As PictureBox
    Friend WithEvents RightWall As PictureBox
    Friend WithEvents TopWall As PictureBox
    Friend WithEvents BottomWall As PictureBox
    Friend WithEvents Ground1Wall As PictureBox
    Friend WithEvents Ground3Wall As PictureBox
    Friend WithEvents Ground5Wall As PictureBox
    Friend WithEvents Ground2Wall As PictureBox
    Friend WithEvents Ground4Wall As PictureBox
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents WIN As PictureBox
    Friend WithEvents sirKibble As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Cutter As PictureBox
    Friend WithEvents Timer5 As Timer
End Class
