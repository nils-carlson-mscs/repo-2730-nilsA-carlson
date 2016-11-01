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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.chkMorethen10 = New System.Windows.Forms.CheckBox()
        Me.chkTraveling = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.lblAdditional = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalcIfThen = New System.Windows.Forms.Button()
        Me.btnCalcNestedIf = New System.Windows.Forms.Button()
        Me.btnCalcIfElseIf = New System.Windows.Forms.Button()
        Me.btnCalcSelectCase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 312)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission Calculations"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 225)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(156, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Traveling                           $700"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 203)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(155, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "> 10 years                         $500"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Additional amounts:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(167, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "$3120 + 14% of sales > 30000 "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = ">30000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(167, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "$120 + 13% of sales > 6000"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "6000 - 29,999.99"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(167, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "10% of sales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "1 - 5999.99"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(170, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Commission"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(6, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Sales ($)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Sales:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(32, 55)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 2
        Me.txtSales.Text = "abab"
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkMorethen10
        '
        Me.chkMorethen10.AutoSize = True
        Me.chkMorethen10.Location = New System.Drawing.Point(32, 97)
        Me.chkMorethen10.Name = "chkMorethen10"
        Me.chkMorethen10.Size = New System.Drawing.Size(74, 17)
        Me.chkMorethen10.TabIndex = 3
        Me.chkMorethen10.Text = ">10 Years"
        Me.chkMorethen10.UseVisualStyleBackColor = True
        '
        'chkTraveling
        '
        Me.chkTraveling.AutoSize = True
        Me.chkTraveling.Location = New System.Drawing.Point(32, 121)
        Me.chkTraveling.Name = "chkTraveling"
        Me.chkTraveling.Size = New System.Drawing.Size(70, 17)
        Me.chkTraveling.TabIndex = 4
        Me.chkTraveling.Text = "Traveling"
        Me.chkTraveling.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Commission Only:"
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(32, 177)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(100, 23)
        Me.lblCommission.TabIndex = 6
        Me.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAdditional
        '
        Me.lblAdditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditional.Location = New System.Drawing.Point(32, 231)
        Me.lblAdditional.Name = "lblAdditional"
        Me.lblAdditional.Size = New System.Drawing.Size(100, 23)
        Me.lblAdditional.TabIndex = 8
        Me.lblAdditional.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Additional Amount:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(32, 289)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total Commission "
        '
        'btnCalcIfThen
        '
        Me.btnCalcIfThen.Location = New System.Drawing.Point(184, 80)
        Me.btnCalcIfThen.Name = "btnCalcIfThen"
        Me.btnCalcIfThen.Size = New System.Drawing.Size(91, 23)
        Me.btnCalcIfThen.TabIndex = 11
        Me.btnCalcIfThen.Text = "If Then"
        Me.btnCalcIfThen.UseVisualStyleBackColor = True
        '
        'btnCalcNestedIf
        '
        Me.btnCalcNestedIf.Location = New System.Drawing.Point(184, 109)
        Me.btnCalcNestedIf.Name = "btnCalcNestedIf"
        Me.btnCalcNestedIf.Size = New System.Drawing.Size(91, 23)
        Me.btnCalcNestedIf.TabIndex = 12
        Me.btnCalcNestedIf.Text = "Nested If"
        Me.btnCalcNestedIf.UseVisualStyleBackColor = True
        '
        'btnCalcIfElseIf
        '
        Me.btnCalcIfElseIf.Location = New System.Drawing.Point(184, 138)
        Me.btnCalcIfElseIf.Name = "btnCalcIfElseIf"
        Me.btnCalcIfElseIf.Size = New System.Drawing.Size(91, 23)
        Me.btnCalcIfElseIf.TabIndex = 13
        Me.btnCalcIfElseIf.Text = "If ElseIf"
        Me.btnCalcIfElseIf.UseVisualStyleBackColor = True
        '
        'btnCalcSelectCase
        '
        Me.btnCalcSelectCase.Location = New System.Drawing.Point(184, 167)
        Me.btnCalcSelectCase.Name = "btnCalcSelectCase"
        Me.btnCalcSelectCase.Size = New System.Drawing.Size(91, 23)
        Me.btnCalcSelectCase.TabIndex = 14
        Me.btnCalcSelectCase.Text = "Select Case"
        Me.btnCalcSelectCase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(184, 196)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 427)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcSelectCase)
        Me.Controls.Add(Me.btnCalcIfElseIf)
        Me.Controls.Add(Me.btnCalcNestedIf)
        Me.Controls.Add(Me.btnCalcIfThen)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAdditional)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkTraveling)
        Me.Controls.Add(Me.chkMorethen10)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "ncarlson Marshall Sales Commission"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents chkMorethen10 As CheckBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblAdditional As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCalcIfThen As Button
    Friend WithEvents btnCalcNestedIf As Button
    Friend WithEvents btnCalcIfElseIf As Button
    Friend WithEvents btnCalcSelectCase As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
