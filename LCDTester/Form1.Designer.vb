<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.comport = New System.Windows.Forms.ComboBox
        Me.turnoff = New System.Windows.Forms.Button
        Me.turnon = New System.Windows.Forms.Button
        Me.brightness = New System.Windows.Forms.TrackBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.contrast = New System.Windows.Forms.TrackBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.red = New System.Windows.Forms.TrackBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.green = New System.Windows.Forms.TrackBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.blue = New System.Windows.Forms.TrackBar
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.led1off = New System.Windows.Forms.RadioButton
        Me.led1yellow = New System.Windows.Forms.RadioButton
        Me.led1green = New System.Windows.Forms.RadioButton
        Me.led1red = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.led2off = New System.Windows.Forms.RadioButton
        Me.led2yellow = New System.Windows.Forms.RadioButton
        Me.led2green = New System.Windows.Forms.RadioButton
        Me.led2red = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.led3off = New System.Windows.Forms.RadioButton
        Me.led3yellow = New System.Windows.Forms.RadioButton
        Me.led3green = New System.Windows.Forms.RadioButton
        Me.led3red = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.KeypadBrightness = New System.Windows.Forms.TrackBar
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Keys = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LCDType = New System.Windows.Forms.ComboBox
        CType(Me.brightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.green, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.KeypadBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'comport
        '
        Me.comport.FormattingEnabled = True
        Me.comport.Location = New System.Drawing.Point(12, 12)
        Me.comport.Name = "comport"
        Me.comport.Size = New System.Drawing.Size(121, 21)
        Me.comport.TabIndex = 1
        '
        'turnoff
        '
        Me.turnoff.Location = New System.Drawing.Point(132, 52)
        Me.turnoff.Name = "turnoff"
        Me.turnoff.Size = New System.Drawing.Size(103, 23)
        Me.turnoff.TabIndex = 2
        Me.turnoff.Text = "Turn Off Screen"
        Me.turnoff.UseVisualStyleBackColor = True
        '
        'turnon
        '
        Me.turnon.Location = New System.Drawing.Point(12, 52)
        Me.turnon.Name = "turnon"
        Me.turnon.Size = New System.Drawing.Size(103, 23)
        Me.turnon.TabIndex = 3
        Me.turnon.Text = "Turn On Screen"
        Me.turnon.UseVisualStyleBackColor = True
        '
        'brightness
        '
        Me.brightness.LargeChange = 64
        Me.brightness.Location = New System.Drawing.Point(87, 89)
        Me.brightness.Maximum = 255
        Me.brightness.Minimum = 1
        Me.brightness.Name = "brightness"
        Me.brightness.Size = New System.Drawing.Size(292, 45)
        Me.brightness.SmallChange = 16
        Me.brightness.TabIndex = 4
        Me.brightness.TickFrequency = 32
        Me.brightness.Value = 255
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Brightness"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contrast"
        '
        'contrast
        '
        Me.contrast.LargeChange = 64
        Me.contrast.Location = New System.Drawing.Point(87, 125)
        Me.contrast.Maximum = 255
        Me.contrast.Minimum = 1
        Me.contrast.Name = "contrast"
        Me.contrast.Size = New System.Drawing.Size(292, 45)
        Me.contrast.SmallChange = 16
        Me.contrast.TabIndex = 6
        Me.contrast.TickFrequency = 32
        Me.contrast.Value = 255
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Red"
        '
        'red
        '
        Me.red.LargeChange = 64
        Me.red.Location = New System.Drawing.Point(87, 161)
        Me.red.Maximum = 255
        Me.red.Minimum = 1
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(292, 45)
        Me.red.SmallChange = 16
        Me.red.TabIndex = 8
        Me.red.TickFrequency = 32
        Me.red.Value = 255
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Green"
        '
        'green
        '
        Me.green.LargeChange = 64
        Me.green.Location = New System.Drawing.Point(87, 196)
        Me.green.Maximum = 255
        Me.green.Minimum = 1
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(292, 45)
        Me.green.SmallChange = 16
        Me.green.TabIndex = 10
        Me.green.TickFrequency = 32
        Me.green.Value = 255
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Blue"
        '
        'blue
        '
        Me.blue.LargeChange = 64
        Me.blue.Location = New System.Drawing.Point(87, 229)
        Me.blue.Maximum = 255
        Me.blue.Minimum = 1
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(292, 45)
        Me.blue.SmallChange = 16
        Me.blue.TabIndex = 13
        Me.blue.TickFrequency = 32
        Me.blue.Value = 255
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "LCD Text"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 300)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 99)
        Me.TextBox1.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.led1off)
        Me.GroupBox1.Controls.Add(Me.led1yellow)
        Me.GroupBox1.Controls.Add(Me.led1green)
        Me.GroupBox1.Controls.Add(Me.led1red)
        Me.GroupBox1.Location = New System.Drawing.Point(268, 281)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 49)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LED 1"
        '
        'led1off
        '
        Me.led1off.AutoSize = True
        Me.led1off.Location = New System.Drawing.Point(178, 20)
        Me.led1off.Name = "led1off"
        Me.led1off.Size = New System.Drawing.Size(39, 17)
        Me.led1off.TabIndex = 3
        Me.led1off.TabStop = True
        Me.led1off.Text = "Off"
        Me.led1off.UseVisualStyleBackColor = True
        '
        'led1yellow
        '
        Me.led1yellow.AutoSize = True
        Me.led1yellow.Location = New System.Drawing.Point(118, 20)
        Me.led1yellow.Name = "led1yellow"
        Me.led1yellow.Size = New System.Drawing.Size(56, 17)
        Me.led1yellow.TabIndex = 2
        Me.led1yellow.TabStop = True
        Me.led1yellow.Text = "Yellow"
        Me.led1yellow.UseVisualStyleBackColor = True
        '
        'led1green
        '
        Me.led1green.AutoSize = True
        Me.led1green.Location = New System.Drawing.Point(58, 20)
        Me.led1green.Name = "led1green"
        Me.led1green.Size = New System.Drawing.Size(54, 17)
        Me.led1green.TabIndex = 1
        Me.led1green.TabStop = True
        Me.led1green.Text = "Green"
        Me.led1green.UseVisualStyleBackColor = True
        '
        'led1red
        '
        Me.led1red.AutoSize = True
        Me.led1red.Location = New System.Drawing.Point(7, 20)
        Me.led1red.Name = "led1red"
        Me.led1red.Size = New System.Drawing.Size(45, 17)
        Me.led1red.TabIndex = 0
        Me.led1red.TabStop = True
        Me.led1red.Text = "Red"
        Me.led1red.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.led2off)
        Me.GroupBox2.Controls.Add(Me.led2yellow)
        Me.GroupBox2.Controls.Add(Me.led2green)
        Me.GroupBox2.Controls.Add(Me.led2red)
        Me.GroupBox2.Location = New System.Drawing.Point(268, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 49)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LED 2"
        '
        'led2off
        '
        Me.led2off.AutoSize = True
        Me.led2off.Location = New System.Drawing.Point(178, 20)
        Me.led2off.Name = "led2off"
        Me.led2off.Size = New System.Drawing.Size(39, 17)
        Me.led2off.TabIndex = 4
        Me.led2off.TabStop = True
        Me.led2off.Text = "Off"
        Me.led2off.UseVisualStyleBackColor = True
        '
        'led2yellow
        '
        Me.led2yellow.AutoSize = True
        Me.led2yellow.Location = New System.Drawing.Point(118, 20)
        Me.led2yellow.Name = "led2yellow"
        Me.led2yellow.Size = New System.Drawing.Size(56, 17)
        Me.led2yellow.TabIndex = 2
        Me.led2yellow.TabStop = True
        Me.led2yellow.Text = "Yellow"
        Me.led2yellow.UseVisualStyleBackColor = True
        '
        'led2green
        '
        Me.led2green.AutoSize = True
        Me.led2green.Location = New System.Drawing.Point(58, 20)
        Me.led2green.Name = "led2green"
        Me.led2green.Size = New System.Drawing.Size(54, 17)
        Me.led2green.TabIndex = 1
        Me.led2green.TabStop = True
        Me.led2green.Text = "Green"
        Me.led2green.UseVisualStyleBackColor = True
        '
        'led2red
        '
        Me.led2red.AutoSize = True
        Me.led2red.Location = New System.Drawing.Point(7, 20)
        Me.led2red.Name = "led2red"
        Me.led2red.Size = New System.Drawing.Size(45, 17)
        Me.led2red.TabIndex = 0
        Me.led2red.TabStop = True
        Me.led2red.Text = "Red"
        Me.led2red.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.led3off)
        Me.GroupBox3.Controls.Add(Me.led3yellow)
        Me.GroupBox3.Controls.Add(Me.led3green)
        Me.GroupBox3.Controls.Add(Me.led3red)
        Me.GroupBox3.Location = New System.Drawing.Point(268, 391)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 49)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LED 3"
        '
        'led3off
        '
        Me.led3off.AutoSize = True
        Me.led3off.Location = New System.Drawing.Point(178, 20)
        Me.led3off.Name = "led3off"
        Me.led3off.Size = New System.Drawing.Size(39, 17)
        Me.led3off.TabIndex = 5
        Me.led3off.TabStop = True
        Me.led3off.Text = "Off"
        Me.led3off.UseVisualStyleBackColor = True
        '
        'led3yellow
        '
        Me.led3yellow.AutoSize = True
        Me.led3yellow.Location = New System.Drawing.Point(118, 20)
        Me.led3yellow.Name = "led3yellow"
        Me.led3yellow.Size = New System.Drawing.Size(56, 17)
        Me.led3yellow.TabIndex = 2
        Me.led3yellow.TabStop = True
        Me.led3yellow.Text = "Yellow"
        Me.led3yellow.UseVisualStyleBackColor = True
        '
        'led3green
        '
        Me.led3green.AutoSize = True
        Me.led3green.Location = New System.Drawing.Point(58, 20)
        Me.led3green.Name = "led3green"
        Me.led3green.Size = New System.Drawing.Size(54, 17)
        Me.led3green.TabIndex = 1
        Me.led3green.TabStop = True
        Me.led3green.Text = "Green"
        Me.led3green.UseVisualStyleBackColor = True
        '
        'led3red
        '
        Me.led3red.AutoSize = True
        Me.led3red.Location = New System.Drawing.Point(7, 20)
        Me.led3red.Name = "led3red"
        Me.led3red.Size = New System.Drawing.Size(45, 17)
        Me.led3red.TabIndex = 0
        Me.led3red.TabStop = True
        Me.led3red.Text = "Red"
        Me.led3red.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(266, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 408)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Set Text"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(99, 408)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Clear Text"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'KeypadBrightness
        '
        Me.KeypadBrightness.LargeChange = 64
        Me.KeypadBrightness.Location = New System.Drawing.Point(78, 26)
        Me.KeypadBrightness.Maximum = 255
        Me.KeypadBrightness.Minimum = 1
        Me.KeypadBrightness.Name = "KeypadBrightness"
        Me.KeypadBrightness.Size = New System.Drawing.Size(292, 45)
        Me.KeypadBrightness.SmallChange = 16
        Me.KeypadBrightness.TabIndex = 25
        Me.KeypadBrightness.TickFrequency = 32
        Me.KeypadBrightness.Value = 255
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Brightness"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(298, 52)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 23)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Cycle Fake Sensor Test"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Keys
        '
        Me.Keys.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keys.Location = New System.Drawing.Point(9, 64)
        Me.Keys.Multiline = True
        Me.Keys.Name = "Keys"
        Me.Keys.Size = New System.Drawing.Size(239, 99)
        Me.Keys.TabIndex = 28
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Keys)
        Me.GroupBox4.Controls.Add(Me.KeypadBrightness)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(553, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(378, 176)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Keypad"
        '
        'LCDType
        '
        Me.LCDType.FormattingEnabled = True
        Me.LCDType.Items.AddRange(New Object() {"Matrix Orbital", "Test Emulator"})
        Me.LCDType.Location = New System.Drawing.Point(139, 12)
        Me.LCDType.Name = "LCDType"
        Me.LCDType.Size = New System.Drawing.Size(121, 21)
        Me.LCDType.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 456)
        Me.Controls.Add(Me.LCDType)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.blue)
        Me.Controls.Add(Me.green)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.contrast)
        Me.Controls.Add(Me.brightness)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.turnon)
        Me.Controls.Add(Me.turnoff)
        Me.Controls.Add(Me.comport)
        Me.Name = "Form1"
        Me.Text = "Character LCD Tester"
        CType(Me.brightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.green, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.KeypadBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comport As System.Windows.Forms.ComboBox
    Friend WithEvents turnoff As System.Windows.Forms.Button
    Friend WithEvents turnon As System.Windows.Forms.Button
    Friend WithEvents brightness As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents contrast As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents red As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents green As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents blue As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents led1green As System.Windows.Forms.RadioButton
    Friend WithEvents led1red As System.Windows.Forms.RadioButton
    Friend WithEvents led1yellow As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents led2yellow As System.Windows.Forms.RadioButton
    Friend WithEvents led2green As System.Windows.Forms.RadioButton
    Friend WithEvents led2red As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents led3yellow As System.Windows.Forms.RadioButton
    Friend WithEvents led3green As System.Windows.Forms.RadioButton
    Friend WithEvents led3red As System.Windows.Forms.RadioButton
    Friend WithEvents led1off As System.Windows.Forms.RadioButton
    Friend WithEvents led2off As System.Windows.Forms.RadioButton
    Friend WithEvents led3off As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents KeypadBrightness As System.Windows.Forms.TrackBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Keys As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LCDType As System.Windows.Forms.ComboBox

End Class
