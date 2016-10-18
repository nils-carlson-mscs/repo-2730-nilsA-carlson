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
        Me.txtDollar = New System.Windows.Forms.TextBox()
        Me.btnConvertEq = New System.Windows.Forms.Button()
        Me.btnConvertNot = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalcTea = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrevious = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCalcTri = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBill = New System.Windows.Forms.Label()
        Me.txtPrevious = New System.Windows.Forms.TextBox()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.lblQuotient = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalcDiv = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "American dollar:"
        '
        'txtDollar
        '
        Me.txtDollar.Location = New System.Drawing.Point(4, 61)
        Me.txtDollar.Name = "txtDollar"
        Me.txtDollar.Size = New System.Drawing.Size(100, 20)
        Me.txtDollar.TabIndex = 1
        '
        'btnConvertEq
        '
        Me.btnConvertEq.Location = New System.Drawing.Point(125, 34)
        Me.btnConvertEq.Name = "btnConvertEq"
        Me.btnConvertEq.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertEq.TabIndex = 2
        Me.btnConvertEq.Text = "Convert ="
        Me.btnConvertEq.UseVisualStyleBackColor = True
        '
        'btnConvertNot
        '
        Me.btnConvertNot.Location = New System.Drawing.Point(125, 63)
        Me.btnConvertNot.Name = "btnConvertNot"
        Me.btnConvertNot.Size = New System.Drawing.Size(75, 23)
        Me.btnConvertNot.TabIndex = 3
        Me.btnConvertNot.Text = "Convert <>"
        Me.btnConvertNot.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Euro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "British pound:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(501, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "South African Rand:"
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(249, 62)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(100, 23)
        Me.lblEuro.TabIndex = 7
        '
        'lblPound
        '
        Me.lblPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPound.Location = New System.Drawing.Point(374, 62)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(100, 23)
        Me.lblPound.TabIndex = 8
        '
        'lblRand
        '
        Me.lblRand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRand.Location = New System.Drawing.Point(504, 62)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(100, 23)
        Me.lblRand.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEuro)
        Me.GroupBox1.Controls.Add(Me.lblRand)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblPound)
        Me.GroupBox1.Controls.Add(Me.txtDollar)
        Me.GroupBox1.Controls.Add(Me.btnConvertEq)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnConvertNot)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 109)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Currency Converter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.txtPounds)
        Me.GroupBox2.Controls.Add(Me.lblTotalDue)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnCalcTea)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(611, 100)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tea Time"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(132, 49)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(75, 20)
        Me.txtPrice.TabIndex = 8
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(19, 49)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(70, 20)
        Me.txtPounds.TabIndex = 7
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(407, 47)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalDue.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(404, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Due"
        '
        'btnCalcTea
        '
        Me.btnCalcTea.Location = New System.Drawing.Point(270, 47)
        Me.btnCalcTea.Name = "btnCalcTea"
        Me.btnCalcTea.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcTea.TabIndex = 4
        Me.btnCalcTea.Text = "Calculate"
        Me.btnCalcTea.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(129, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Price/lb"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pounds"
        '
        'lblPrevious
        '
        Me.lblPrevious.AutoSize = True
        Me.lblPrevious.Location = New System.Drawing.Point(16, 20)
        Me.lblPrevious.Name = "lblPrevious"
        Me.lblPrevious.Size = New System.Drawing.Size(48, 13)
        Me.lblPrevious.TabIndex = 0
        Me.lblPrevious.Text = "Previous"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(129, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Current"
        '
        'btnCalcTri
        '
        Me.btnCalcTri.Location = New System.Drawing.Point(270, 47)
        Me.btnCalcTri.Name = "btnCalcTri"
        Me.btnCalcTri.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcTri.TabIndex = 4
        Me.btnCalcTri.Text = "Calculate"
        Me.btnCalcTri.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(404, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Monthly Bill"
        '
        'lblBill
        '
        Me.lblBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBill.Location = New System.Drawing.Point(407, 47)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(100, 23)
        Me.lblBill.TabIndex = 6
        '
        'txtPrevious
        '
        Me.txtPrevious.Location = New System.Drawing.Point(19, 49)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.Size = New System.Drawing.Size(70, 20)
        Me.txtPrevious.TabIndex = 7
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(132, 49)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(75, 20)
        Me.txtCurrent.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCurrent)
        Me.GroupBox3.Controls.Add(Me.txtPrevious)
        Me.GroupBox3.Controls.Add(Me.lblBill)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.btnCalcTri)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblPrevious)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 268)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(611, 100)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tri County Electric"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSecond)
        Me.GroupBox4.Controls.Add(Me.txtFirst)
        Me.GroupBox4.Controls.Add(Me.lblQuotient)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.btnCalcDiv)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 407)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(611, 100)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Division Calculator"
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(132, 49)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(75, 20)
        Me.txtSecond.TabIndex = 8
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(19, 49)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(70, 20)
        Me.txtFirst.TabIndex = 7
        '
        'lblQuotient
        '
        Me.lblQuotient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuotient.Location = New System.Drawing.Point(407, 47)
        Me.lblQuotient.Name = "lblQuotient"
        Me.lblQuotient.Size = New System.Drawing.Size(100, 23)
        Me.lblQuotient.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(404, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Quotient"
        '
        'btnCalcDiv
        '
        Me.btnCalcDiv.Location = New System.Drawing.Point(270, 47)
        Me.btnCalcDiv.Name = "btnCalcDiv"
        Me.btnCalcDiv.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcDiv.TabIndex = 4
        Me.btnCalcDiv.Text = "Calculate"
        Me.btnCalcDiv.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(129, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Second #"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "First #"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 570)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "ncarlson2d1 If Else Statements"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDollar As TextBox
    Friend WithEvents btnConvertEq As Button
    Friend WithEvents btnConvertNot As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents lblPound As Label
    Friend WithEvents lblRand As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCalcTea As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtPounds As TextBox
    Friend WithEvents lblPrevious As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCalcTri As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBill As Label
    Friend WithEvents txtPrevious As TextBox
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents lblQuotient As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCalcDiv As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
