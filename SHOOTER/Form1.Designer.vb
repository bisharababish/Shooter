<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Shooter = New System.Windows.Forms.PictureBox()
        Me.Shot = New System.Windows.Forms.PictureBox()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Shooter
        '
        Me.Shooter.BackColor = System.Drawing.Color.Transparent
        Me.Shooter.Image = CType(resources.GetObject("Shooter.Image"), System.Drawing.Image)
        Me.Shooter.Location = New System.Drawing.Point(1, 502)
        Me.Shooter.Name = "Shooter"
        Me.Shooter.Size = New System.Drawing.Size(88, 110)
        Me.Shooter.TabIndex = 1
        Me.Shooter.TabStop = False
        '
        'Shot
        '
        Me.Shot.BackColor = System.Drawing.Color.DarkRed
        Me.Shot.Location = New System.Drawing.Point(48, 408)
        Me.Shot.Name = "Shot"
        Me.Shot.Size = New System.Drawing.Size(10, 20)
        Me.Shot.TabIndex = 2
        Me.Shot.TabStop = False
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(310, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Replay"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(310, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 70)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(824, 614)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Shot)
        Me.Controls.Add(Me.Shooter)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "SHOOTER"
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Shooter As PictureBox
    Friend WithEvents Shot As PictureBox
    Friend WithEvents TimerMain As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
