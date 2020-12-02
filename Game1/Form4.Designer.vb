<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Avatar = New System.Windows.Forms.PictureBox()
        Me.WaddleDee = New System.Windows.Forms.PictureBox()
        Me.OneWall = New System.Windows.Forms.PictureBox()
        Me.FourWall = New System.Windows.Forms.PictureBox()
        Me.ThreeWall = New System.Windows.Forms.PictureBox()
        Me.TwoWall = New System.Windows.Forms.PictureBox()
        Me.WIN = New System.Windows.Forms.PictureBox()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaddleDee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OneWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FourWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThreeWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwoWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Avatar
        '
        Me.Avatar.BackColor = System.Drawing.Color.Transparent
        Me.Avatar.Image = CType(resources.GetObject("Avatar.Image"), System.Drawing.Image)
        Me.Avatar.Location = New System.Drawing.Point(10, 84)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(79, 89)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar.TabIndex = 0
        Me.Avatar.TabStop = False
        '
        'WaddleDee
        '
        Me.WaddleDee.BackColor = System.Drawing.Color.Transparent
        Me.WaddleDee.Image = CType(resources.GetObject("WaddleDee.Image"), System.Drawing.Image)
        Me.WaddleDee.Location = New System.Drawing.Point(504, 100)
        Me.WaddleDee.Name = "WaddleDee"
        Me.WaddleDee.Size = New System.Drawing.Size(74, 69)
        Me.WaddleDee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WaddleDee.TabIndex = 1
        Me.WaddleDee.TabStop = False
        '
        'OneWall
        '
        Me.OneWall.BackColor = System.Drawing.Color.Transparent
        Me.OneWall.Location = New System.Drawing.Point(0, 175)
        Me.OneWall.Name = "OneWall"
        Me.OneWall.Size = New System.Drawing.Size(158, 282)
        Me.OneWall.TabIndex = 2
        Me.OneWall.TabStop = False
        '
        'FourWall
        '
        Me.FourWall.BackColor = System.Drawing.Color.Transparent
        Me.FourWall.Location = New System.Drawing.Point(265, 172)
        Me.FourWall.Name = "FourWall"
        Me.FourWall.Size = New System.Drawing.Size(320, 28)
        Me.FourWall.TabIndex = 3
        Me.FourWall.TabStop = False
        '
        'ThreeWall
        '
        Me.ThreeWall.BackColor = System.Drawing.Color.Transparent
        Me.ThreeWall.Location = New System.Drawing.Point(696, 172)
        Me.ThreeWall.Name = "ThreeWall"
        Me.ThreeWall.Size = New System.Drawing.Size(118, 285)
        Me.ThreeWall.TabIndex = 4
        Me.ThreeWall.TabStop = False
        '
        'TwoWall
        '
        Me.TwoWall.BackColor = System.Drawing.Color.Transparent
        Me.TwoWall.Location = New System.Drawing.Point(-7, 394)
        Me.TwoWall.Name = "TwoWall"
        Me.TwoWall.Size = New System.Drawing.Size(821, 63)
        Me.TwoWall.TabIndex = 5
        Me.TwoWall.TabStop = False
        '
        'WIN
        '
        Me.WIN.BackColor = System.Drawing.Color.Transparent
        Me.WIN.Image = CType(resources.GetObject("WIN.Image"), System.Drawing.Image)
        Me.WIN.Location = New System.Drawing.Point(753, 130)
        Me.WIN.Name = "WIN"
        Me.WIN.Size = New System.Drawing.Size(35, 36)
        Me.WIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WIN.TabIndex = 6
        Me.WIN.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WIN)
        Me.Controls.Add(Me.TwoWall)
        Me.Controls.Add(Me.ThreeWall)
        Me.Controls.Add(Me.FourWall)
        Me.Controls.Add(Me.OneWall)
        Me.Controls.Add(Me.WaddleDee)
        Me.Controls.Add(Me.Avatar)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaddleDee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OneWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FourWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThreeWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwoWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Avatar As PictureBox
    Friend WithEvents WaddleDee As PictureBox
    Friend WithEvents OneWall As PictureBox
    Friend WithEvents FourWall As PictureBox
    Friend WithEvents ThreeWall As PictureBox
    Friend WithEvents TwoWall As PictureBox
    Friend WithEvents WIN As PictureBox
End Class
