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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMeasurments = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.radSubCentimeters = New System.Windows.Forms.RadioButton()
        Me.radSubInches = New System.Windows.Forms.RadioButton()
        Me.radFuncCentimeters = New System.Windows.Forms.RadioButton()
        Me.radFuncInches = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radFuncWeight = New System.Windows.Forms.RadioButton()
        Me.radSubWeight = New System.Windows.Forms.RadioButton()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.cboPlanets = New System.Windows.Forms.ComboBox()
        Me.txtEarthWeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Measurements"
        '
        'txtMeasurments
        '
        Me.txtMeasurments.Location = New System.Drawing.Point(37, 40)
        Me.txtMeasurments.Name = "txtMeasurments"
        Me.txtMeasurments.Size = New System.Drawing.Size(86, 20)
        Me.txtMeasurments.TabIndex = 1
        Me.txtMeasurments.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Result"
        '
        'lblResults
        '
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResults.Location = New System.Drawing.Point(34, 107)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(100, 23)
        Me.lblResults.TabIndex = 3
        '
        'radSubCentimeters
        '
        Me.radSubCentimeters.AutoSize = True
        Me.radSubCentimeters.Checked = True
        Me.radSubCentimeters.Location = New System.Drawing.Point(215, 40)
        Me.radSubCentimeters.Name = "radSubCentimeters"
        Me.radSubCentimeters.Size = New System.Drawing.Size(152, 17)
        Me.radSubCentimeters.TabIndex = 4
        Me.radSubCentimeters.TabStop = True
        Me.radSubCentimeters.Text = "Sub: Inches to Centimeters"
        Me.radSubCentimeters.UseVisualStyleBackColor = True
        '
        'radSubInches
        '
        Me.radSubInches.AutoSize = True
        Me.radSubInches.Location = New System.Drawing.Point(215, 63)
        Me.radSubInches.Name = "radSubInches"
        Me.radSubInches.Size = New System.Drawing.Size(152, 17)
        Me.radSubInches.TabIndex = 5
        Me.radSubInches.TabStop = True
        Me.radSubInches.Text = "Sub: Centimeters to Inches"
        Me.radSubInches.UseVisualStyleBackColor = True
        '
        'radFuncCentimeters
        '
        Me.radFuncCentimeters.AutoSize = True
        Me.radFuncCentimeters.Location = New System.Drawing.Point(215, 86)
        Me.radFuncCentimeters.Name = "radFuncCentimeters"
        Me.radFuncCentimeters.Size = New System.Drawing.Size(174, 17)
        Me.radFuncCentimeters.TabIndex = 6
        Me.radFuncCentimeters.TabStop = True
        Me.radFuncCentimeters.Text = "Function: Inches to Centimeters"
        Me.radFuncCentimeters.UseVisualStyleBackColor = True
        '
        'radFuncInches
        '
        Me.radFuncInches.AutoSize = True
        Me.radFuncInches.Location = New System.Drawing.Point(215, 113)
        Me.radFuncInches.Name = "radFuncInches"
        Me.radFuncInches.Size = New System.Drawing.Size(168, 17)
        Me.radFuncInches.TabIndex = 7
        Me.radFuncInches.TabStop = True
        Me.radFuncInches.Text = "Funtion: Centimeters to Inches"
        Me.radFuncInches.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(457, 395)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 169)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p418 #15 & 16: Measurment Converter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radFuncWeight)
        Me.GroupBox2.Controls.Add(Me.radSubWeight)
        Me.GroupBox2.Controls.Add(Me.lblWeight)
        Me.GroupBox2.Controls.Add(Me.cboPlanets)
        Me.GroupBox2.Controls.Add(Me.txtEarthWeight)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 171)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p426-427 #4-6: Weight on different planets"
        '
        'radFuncWeight
        '
        Me.radFuncWeight.AutoSize = True
        Me.radFuncWeight.Location = New System.Drawing.Point(229, 98)
        Me.radFuncWeight.Name = "radFuncWeight"
        Me.radFuncWeight.Size = New System.Drawing.Size(66, 17)
        Me.radFuncWeight.TabIndex = 7
        Me.radFuncWeight.TabStop = True
        Me.radFuncWeight.Text = "Function"
        Me.radFuncWeight.UseVisualStyleBackColor = True
        '
        'radSubWeight
        '
        Me.radSubWeight.AutoSize = True
        Me.radSubWeight.Checked = True
        Me.radSubWeight.Location = New System.Drawing.Point(229, 74)
        Me.radSubWeight.Name = "radSubWeight"
        Me.radSubWeight.Size = New System.Drawing.Size(44, 17)
        Me.radSubWeight.TabIndex = 6
        Me.radSubWeight.TabStop = True
        Me.radSubWeight.Text = "Sub"
        Me.radSubWeight.UseVisualStyleBackColor = True
        '
        'lblWeight
        '
        Me.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeight.Location = New System.Drawing.Point(117, 103)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(78, 23)
        Me.lblWeight.TabIndex = 5
        '
        'cboPlanets
        '
        Me.cboPlanets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanets.FormattingEnabled = True
        Me.cboPlanets.Location = New System.Drawing.Point(117, 60)
        Me.cboPlanets.Name = "cboPlanets"
        Me.cboPlanets.Size = New System.Drawing.Size(78, 21)
        Me.cboPlanets.TabIndex = 4
        '
        'txtEarthWeight
        '
        Me.txtEarthWeight.Location = New System.Drawing.Point(24, 62)
        Me.txtEarthWeight.Name = "txtEarthWeight"
        Me.txtEarthWeight.Size = New System.Drawing.Size(73, 20)
        Me.txtEarthWeight.TabIndex = 3
        Me.txtEarthWeight.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Calculate Using"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Weight On"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Earth Weight"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 442)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.radFuncInches)
        Me.Controls.Add(Me.radFuncCentimeters)
        Me.Controls.Add(Me.radSubInches)
        Me.Controls.Add(Me.radSubCentimeters)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMeasurments)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "ncarlson3c1 Measurement Converter"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMeasurments As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents radSubCentimeters As RadioButton
    Friend WithEvents radSubInches As RadioButton
    Friend WithEvents radFuncCentimeters As RadioButton
    Friend WithEvents radFuncInches As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radFuncWeight As RadioButton
    Friend WithEvents radSubWeight As RadioButton
    Friend WithEvents lblWeight As Label
    Friend WithEvents cboPlanets As ComboBox
    Friend WithEvents txtEarthWeight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
