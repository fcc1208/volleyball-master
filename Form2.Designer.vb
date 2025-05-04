<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ime = New System.Windows.Forms.PictureBox()
        Me.boommov = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.enemove = New System.Windows.Forms.Timer(Me.components)
        Me.ball = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mejump = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.boom = New System.Windows.Forms.PictureBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ene = New System.Windows.Forms.PictureBox()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.block = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.reball = New System.Windows.Forms.PictureBox()
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mejump, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ene, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.block, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ime
        '
        Me.ime.BackColor = System.Drawing.Color.Transparent
        Me.ime.Image = CType(resources.GetObject("ime.Image"), System.Drawing.Image)
        Me.ime.Location = New System.Drawing.Point(90, 291)
        Me.ime.Name = "ime"
        Me.ime.Size = New System.Drawing.Size(150, 147)
        Me.ime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ime.TabIndex = 0
        Me.ime.TabStop = False
        '
        'boommov
        '
        Me.boommov.Interval = 1000
        '
        'Timer2
        '
        '
        'enemove
        '
        Me.enemove.Interval = 1000
        '
        'ball
        '
        Me.ball.BackColor = System.Drawing.Color.Transparent
        Me.ball.Image = CType(resources.GetObject("ball.Image"), System.Drawing.Image)
        Me.ball.Location = New System.Drawing.Point(200, 83)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(40, 35)
        Me.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ball.TabIndex = 3
        Me.ball.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("新細明體", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(701, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mejump
        '
        Me.mejump.BackColor = System.Drawing.Color.Transparent
        Me.mejump.Image = CType(resources.GetObject("mejump.Image"), System.Drawing.Image)
        Me.mejump.Location = New System.Drawing.Point(18, 46)
        Me.mejump.Name = "mejump"
        Me.mejump.Size = New System.Drawing.Size(150, 147)
        Me.mejump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mejump.TabIndex = 6
        Me.mejump.TabStop = False
        Me.mejump.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(525, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(150, 147)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'boom
        '
        Me.boom.Image = CType(resources.GetObject("boom.Image"), System.Drawing.Image)
        Me.boom.Location = New System.Drawing.Point(3, 353)
        Me.boom.Name = "boom"
        Me.boom.Size = New System.Drawing.Size(379, 85)
        Me.boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.boom.TabIndex = 8
        Me.boom.TabStop = False
        Me.boom.Visible = False
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(320, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 93)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ene
        '
        Me.ene.BackColor = System.Drawing.Color.Transparent
        Me.ene.Image = CType(resources.GetObject("ene.Image"), System.Drawing.Image)
        Me.ene.Location = New System.Drawing.Point(513, 291)
        Me.ene.Name = "ene"
        Me.ene.Size = New System.Drawing.Size(125, 118)
        Me.ene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ene.TabIndex = 10
        Me.ene.TabStop = False
        '
        'Timer5
        '
        '
        'Timer6
        '
        '
        'block
        '
        Me.block.BackColor = System.Drawing.Color.Black
        Me.block.Location = New System.Drawing.Point(388, 301)
        Me.block.Name = "block"
        Me.block.Size = New System.Drawing.Size(22, 375)
        Me.block.TabIndex = 11
        Me.block.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 440)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(387, 10)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 43)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(390, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 43)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "0"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(-5, -3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(372, 10)
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("新細明體", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.Location = New System.Drawing.Point(320, 170)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 93)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "one more"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'reball
        '
        Me.reball.BackColor = System.Drawing.Color.Transparent
        Me.reball.Image = CType(resources.GetObject("reball.Image"), System.Drawing.Image)
        Me.reball.Location = New System.Drawing.Point(279, 93)
        Me.reball.Name = "reball"
        Me.reball.Size = New System.Drawing.Size(40, 35)
        Me.reball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reball.TabIndex = 18
        Me.reball.TabStop = False
        Me.reball.Visible = False
        '
        'Timer7
        '
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(408, 439)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(394, 10)
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'Timer8
        '
        '
        'Timer9
        '
        '
        'Timer10
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.reball)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.block)
        Me.Controls.Add(Me.ene)
        Me.Controls.Add(Me.boom)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.mejump)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ball)
        Me.Controls.Add(Me.ime)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.ime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mejump, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ene, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.block, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ime As PictureBox
    Friend WithEvents boommov As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents enemove As Timer
    Friend WithEvents ball As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents mejump As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents boom As PictureBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents ene As PictureBox
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents block As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents reball As PictureBox
    Friend WithEvents Timer7 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Timer10 As Timer
    Friend WithEvents Timer1 As Timer
End Class
