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
        Me.btnDisplayDays = New System.Windows.Forms.Button()
        Me.txtMonthNumber = New System.Windows.Forms.TextBox()
        Me.lblDaysofMonth = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDoLoop = New System.Windows.Forms.Button()
        Me.btnForEachNext = New System.Windows.Forms.Button()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.lblLessthenAvg = New System.Windows.Forms.Label()
        Me.lblAvgSold = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstWholeSale = New System.Windows.Forms.ListBox()
        Me.lstRetail = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRetail = New System.Windows.Forms.Button()
        Me.btnWholesale = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDisplayDays)
        Me.GroupBox1.Controls.Add(Me.txtMonthNumber)
        Me.GroupBox1.Controls.Add(Me.lblDaysofMonth)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Days of the Month"
        '
        'btnDisplayDays
        '
        Me.btnDisplayDays.Location = New System.Drawing.Point(44, 87)
        Me.btnDisplayDays.Name = "btnDisplayDays"
        Me.btnDisplayDays.Size = New System.Drawing.Size(93, 23)
        Me.btnDisplayDays.TabIndex = 4
        Me.btnDisplayDays.Text = "Display Days"
        Me.btnDisplayDays.UseVisualStyleBackColor = True
        '
        'txtMonthNumber
        '
        Me.txtMonthNumber.Location = New System.Drawing.Point(91, 30)
        Me.txtMonthNumber.Name = "txtMonthNumber"
        Me.txtMonthNumber.Size = New System.Drawing.Size(35, 20)
        Me.txtMonthNumber.TabIndex = 3
        Me.txtMonthNumber.Text = "1"
        '
        'lblDaysofMonth
        '
        Me.lblDaysofMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDaysofMonth.Location = New System.Drawing.Point(91, 52)
        Me.lblDaysofMonth.Name = "lblDaysofMonth"
        Me.lblDaysofMonth.Size = New System.Drawing.Size(50, 23)
        Me.lblDaysofMonth.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of days"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Month Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDoLoop)
        Me.GroupBox2.Controls.Add(Me.btnForEachNext)
        Me.GroupBox2.Controls.Add(Me.btnForNext)
        Me.GroupBox2.Controls.Add(Me.lblLessthenAvg)
        Me.GroupBox2.Controls.Add(Me.lblAvgSold)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(258, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 136)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p. 522 # 9 avg. min sold"
        '
        'btnDoLoop
        '
        Me.btnDoLoop.Location = New System.Drawing.Point(180, 92)
        Me.btnDoLoop.Name = "btnDoLoop"
        Me.btnDoLoop.Size = New System.Drawing.Size(92, 23)
        Me.btnDoLoop.TabIndex = 7
        Me.btnDoLoop.Text = "Do...Loop"
        Me.btnDoLoop.UseVisualStyleBackColor = True
        '
        'btnForEachNext
        '
        Me.btnForEachNext.Location = New System.Drawing.Point(180, 58)
        Me.btnForEachNext.Name = "btnForEachNext"
        Me.btnForEachNext.Size = New System.Drawing.Size(92, 23)
        Me.btnForEachNext.TabIndex = 6
        Me.btnForEachNext.Text = "For Each...Next"
        Me.btnForEachNext.UseVisualStyleBackColor = True
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(180, 26)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(92, 23)
        Me.btnForNext.TabIndex = 5
        Me.btnForNext.Text = "For.....Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'lblLessthenAvg
        '
        Me.lblLessthenAvg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLessthenAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLessthenAvg.Location = New System.Drawing.Point(63, 82)
        Me.lblLessthenAvg.Name = "lblLessthenAvg"
        Me.lblLessthenAvg.Size = New System.Drawing.Size(78, 23)
        Me.lblLessthenAvg.TabIndex = 4
        Me.lblLessthenAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvgSold
        '
        Me.lblAvgSold.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAvgSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgSold.Location = New System.Drawing.Point(63, 51)
        Me.lblAvgSold.Name = "lblAvgSold"
        Me.lblAvgSold.Size = New System.Drawing.Size(78, 23)
        Me.lblAvgSold.TabIndex = 3
        Me.lblAvgSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "<avg"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Avg Sold"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Values: 250, 225, 193, 260"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnWholesale)
        Me.GroupBox3.Controls.Add(Me.btnRetail)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lstRetail)
        Me.GroupBox3.Controls.Add(Me.lstWholeSale)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 283)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "p 523 # 13, Wholesale, Rental Prices"
        '
        'lstWholeSale
        '
        Me.lstWholeSale.FormattingEnabled = True
        Me.lstWholeSale.Location = New System.Drawing.Point(28, 47)
        Me.lstWholeSale.Name = "lstWholeSale"
        Me.lstWholeSale.Size = New System.Drawing.Size(78, 212)
        Me.lstWholeSale.TabIndex = 0
        '
        'lstRetail
        '
        Me.lstRetail.FormattingEnabled = True
        Me.lstRetail.Location = New System.Drawing.Point(122, 47)
        Me.lstRetail.Name = "lstRetail"
        Me.lstRetail.Size = New System.Drawing.Size(78, 212)
        Me.lstRetail.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Wholesale:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(122, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Retail:"
        '
        'btnRetail
        '
        Me.btnRetail.Location = New System.Drawing.Point(209, 47)
        Me.btnRetail.Name = "btnRetail"
        Me.btnRetail.Size = New System.Drawing.Size(94, 60)
        Me.btnRetail.TabIndex = 4
        Me.btnRetail.Text = "Update Array to Rental Price"
        Me.btnRetail.UseVisualStyleBackColor = True
        '
        'btnWholesale
        '
        Me.btnWholesale.Location = New System.Drawing.Point(209, 140)
        Me.btnWholesale.Name = "btnWholesale"
        Me.btnWholesale.Size = New System.Drawing.Size(94, 62)
        Me.btnWholesale.TabIndex = 5
        Me.btnWholesale.Text = "Return Array to Wholesale price"
        Me.btnWholesale.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 477)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "ncarlson3d1 Arrays, subscripts, loops"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDisplayDays As Button
    Friend WithEvents txtMonthNumber As TextBox
    Friend WithEvents lblDaysofMonth As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDoLoop As Button
    Friend WithEvents btnForEachNext As Button
    Friend WithEvents btnForNext As Button
    Friend WithEvents lblLessthenAvg As Label
    Friend WithEvents lblAvgSold As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnWholesale As Button
    Friend WithEvents btnRetail As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lstRetail As ListBox
    Friend WithEvents lstWholeSale As ListBox
End Class
