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
        Me.calcOr = New System.Windows.Forms.Button()
        Me.calcAnd = New System.Windows.Forms.Button()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtYN = New System.Windows.Forms.TextBox()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.calcNotEqual = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.calcOr)
        Me.GroupBox1.Controls.Add(Me.calcAnd)
        Me.GroupBox1.Controls.Add(Me.lblCharge)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtYN)
        Me.GroupBox1.Controls.Add(Me.txtOrder)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Free shipping for orders over $100"
        '
        'calcOr
        '
        Me.calcOr.Location = New System.Drawing.Point(354, 65)
        Me.calcOr.Name = "calcOr"
        Me.calcOr.Size = New System.Drawing.Size(86, 23)
        Me.calcOr.TabIndex = 7
        Me.calcOr.Text = "Calculate(Or)"
        Me.calcOr.UseVisualStyleBackColor = True
        '
        'calcAnd
        '
        Me.calcAnd.Location = New System.Drawing.Point(354, 21)
        Me.calcAnd.Name = "calcAnd"
        Me.calcAnd.Size = New System.Drawing.Size(86, 23)
        Me.calcAnd.TabIndex = 6
        Me.calcAnd.Text = "Calculate(And)"
        Me.calcAnd.UseVisualStyleBackColor = True
        '
        'lblCharge
        '
        Me.lblCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCharge.Location = New System.Drawing.Point(198, 48)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(100, 23)
        Me.lblCharge.TabIndex = 5
        Me.lblCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Shipping Charge"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Savannah Y/N"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Order Amount"
        '
        'txtYN
        '
        Me.txtYN.Location = New System.Drawing.Point(106, 51)
        Me.txtYN.Name = "txtYN"
        Me.txtYN.Size = New System.Drawing.Size(43, 20)
        Me.txtYN.TabIndex = 1
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(19, 51)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(66, 20)
        Me.txtOrder.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.calcNotEqual)
        Me.GroupBox2.Controls.Add(Me.btnEqual)
        Me.GroupBox2.Controls.Add(Me.lblCommission)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtSales)
        Me.GroupBox2.Controls.Add(Me.txtId)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "15% commission for sales > 25000 for codes A1, B2, C3"
        '
        'calcNotEqual
        '
        Me.calcNotEqual.Location = New System.Drawing.Point(354, 65)
        Me.calcNotEqual.Name = "calcNotEqual"
        Me.calcNotEqual.Size = New System.Drawing.Size(86, 23)
        Me.calcNotEqual.TabIndex = 7
        Me.calcNotEqual.Text = "Calculate <>"
        Me.calcNotEqual.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Location = New System.Drawing.Point(354, 21)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(86, 23)
        Me.btnEqual.TabIndex = 6
        Me.btnEqual.Text = "Calculate ="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(198, 48)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(100, 23)
        Me.lblCommission.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Commission"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(81, 26)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(33, 13)
        Me.lbl4.TabIndex = 3
        Me.lbl4.Text = "Sales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Id"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(84, 51)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(87, 20)
        Me.txtSales.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(19, 51)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(32, 20)
        Me.txtId.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(225, 328)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 377)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "ncarlson AndAlso, Or/Else"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtYN As TextBox
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents lblCharge As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents calcOr As Button
    Friend WithEvents calcAnd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents calcNotEqual As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents lblCommission As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnExit As Button
End Class
