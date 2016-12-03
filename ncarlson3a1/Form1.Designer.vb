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
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnLoopWhile = New System.Windows.Forms.Button()
        Me.btnLoopuntil = New System.Windows.Forms.Button()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.btnSumDoWhile = New System.Windows.Forms.Button()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.btnSumLoopUntil = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.txtList = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDoUntil)
        Me.GroupBox1.Controls.Add(Me.btnLoopWhile)
        Me.GroupBox1.Controls.Add(Me.btnLoopuntil)
        Me.GroupBox1.Controls.Add(Me.btnFor)
        Me.GroupBox1.Controls.Add(Me.btnDoWhile)
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 330)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p. 347 Loop 2-20"
        '
        'btnDoUntil
        '
        Me.btnDoUntil.Location = New System.Drawing.Point(170, 90)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(170, 35)
        Me.btnDoUntil.TabIndex = 6
        Me.btnDoUntil.Text = "Pretest: Do Until"
        Me.btnDoUntil.UseVisualStyleBackColor = True
        '
        'btnLoopWhile
        '
        Me.btnLoopWhile.Location = New System.Drawing.Point(170, 148)
        Me.btnLoopWhile.Name = "btnLoopWhile"
        Me.btnLoopWhile.Size = New System.Drawing.Size(170, 35)
        Me.btnLoopWhile.TabIndex = 5
        Me.btnLoopWhile.Text = "Posttest: Loop While"
        Me.btnLoopWhile.UseVisualStyleBackColor = True
        '
        'btnLoopuntil
        '
        Me.btnLoopuntil.Location = New System.Drawing.Point(170, 206)
        Me.btnLoopuntil.Name = "btnLoopuntil"
        Me.btnLoopuntil.Size = New System.Drawing.Size(170, 35)
        Me.btnLoopuntil.TabIndex = 4
        Me.btnLoopuntil.Text = "Posttest: Loop Until"
        Me.btnLoopuntil.UseVisualStyleBackColor = True
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(170, 264)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(170, 35)
        Me.btnFor.TabIndex = 3
        Me.btnFor.Text = "Pretest: For"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(170, 32)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(170, 35)
        Me.btnDoWhile.TabIndex = 1
        Me.btnDoWhile.Text = "Pretest: Do While"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(20, 32)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(144, 270)
        Me.lblEven.TabIndex = 0
        '
        'btnSumDoWhile
        '
        Me.btnSumDoWhile.Location = New System.Drawing.Point(170, 158)
        Me.btnSumDoWhile.Name = "btnSumDoWhile"
        Me.btnSumDoWhile.Size = New System.Drawing.Size(170, 35)
        Me.btnSumDoWhile.TabIndex = 1
        Me.btnSumDoWhile.Text = "Sum. Do While"
        Me.btnSumDoWhile.UseVisualStyleBackColor = True
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(170, 274)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(170, 35)
        Me.btnSumForNext.TabIndex = 5
        Me.btnSumForNext.Text = "Sum. For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'btnSumLoopUntil
        '
        Me.btnSumLoopUntil.Location = New System.Drawing.Point(170, 216)
        Me.btnSumLoopUntil.Name = "btnSumLoopUntil"
        Me.btnSumLoopUntil.Size = New System.Drawing.Size(170, 35)
        Me.btnSumLoopUntil.TabIndex = 6
        Me.btnSumLoopUntil.Text = "Sum. Loop Until"
        Me.btnSumLoopUntil.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverage.Location = New System.Drawing.Point(170, 53)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(68, 36)
        Me.lblAverage.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.VScrollBar1)
        Me.GroupBox2.Controls.Add(Me.lblAverage)
        Me.GroupBox2.Controls.Add(Me.btnSumLoopUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.btnSumDoWhile)
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Location = New System.Drawing.Point(377, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 330)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p. 332_348 #22 Addition"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Count:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Average;"
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(257, 53)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(68, 36)
        Me.lblCount.TabIndex = 9
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(131, 42)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(27, 164)
        Me.VScrollBar1.TabIndex = 8
        '
        'txtList
        '
        Me.txtList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtList.Location = New System.Drawing.Point(20, 32)
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(144, 186)
        Me.txtList.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 369)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "ncarlson3a1 Loops, sum, count"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnLoopWhile As Button
    Friend WithEvents btnLoopuntil As Button
    Friend WithEvents btnFor As Button
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents lblEven As Label
    Friend WithEvents btnSumDoWhile As Button
    Friend WithEvents btnSumForNext As Button
    Friend WithEvents btnSumLoopUntil As Button
    Friend WithEvents lblAverage As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents txtList As Label
End Class
