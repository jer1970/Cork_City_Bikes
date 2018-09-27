<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditCard
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
        Me.lblCreditCard = New System.Windows.Forms.Label()
        Me.lblCardType = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblcardNum = New System.Windows.Forms.Label()
        Me.lblCvv = New System.Windows.Forms.Label()
        Me.lblExpiry = New System.Windows.Forms.Label()
        Me.grpCreditCard = New System.Windows.Forms.GroupBox()
        Me.txtTopUp = New System.Windows.Forms.TextBox()
        Me.lblTopUp = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.txtCvv = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.cmbCreditCards = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.grpSubscription = New System.Windows.Forms.GroupBox()
        Me.lblThreeEuro = New System.Windows.Forms.Label()
        Me.lblTenEuro = New System.Windows.Forms.Label()
        Me.opt3Day = New System.Windows.Forms.RadioButton()
        Me.optAnnual = New System.Windows.Forms.RadioButton()
        Me.lbl3Day = New System.Windows.Forms.Label()
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.grpCreditCard.SuspendLayout()
        Me.grpSubscription.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCreditCard
        '
        Me.lblCreditCard.AutoSize = True
        Me.lblCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCard.Location = New System.Drawing.Point(92, 16)
        Me.lblCreditCard.Name = "lblCreditCard"
        Me.lblCreditCard.Size = New System.Drawing.Size(136, 20)
        Me.lblCreditCard.TabIndex = 0
        Me.lblCreditCard.Text = "Credit card details"
        '
        'lblCardType
        '
        Me.lblCardType.AutoSize = True
        Me.lblCardType.Location = New System.Drawing.Point(21, 52)
        Me.lblCardType.Name = "lblCardType"
        Me.lblCardType.Size = New System.Drawing.Size(52, 13)
        Me.lblCardType.TabIndex = 1
        Me.lblCardType.Text = "Card type"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Handwriting", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(435, 87)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Cork City Bikes"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcardNum
        '
        Me.lblcardNum.AutoSize = True
        Me.lblcardNum.Location = New System.Drawing.Point(21, 86)
        Me.lblcardNum.Name = "lblcardNum"
        Me.lblcardNum.Size = New System.Drawing.Size(69, 13)
        Me.lblcardNum.TabIndex = 3
        Me.lblcardNum.Text = "Card Number"
        '
        'lblCvv
        '
        Me.lblCvv.AutoSize = True
        Me.lblCvv.Location = New System.Drawing.Point(21, 119)
        Me.lblCvv.Name = "lblCvv"
        Me.lblCvv.Size = New System.Drawing.Size(28, 13)
        Me.lblCvv.TabIndex = 4
        Me.lblCvv.Text = "CVV"
        '
        'lblExpiry
        '
        Me.lblExpiry.AutoSize = True
        Me.lblExpiry.Location = New System.Drawing.Point(21, 154)
        Me.lblExpiry.Name = "lblExpiry"
        Me.lblExpiry.Size = New System.Drawing.Size(59, 13)
        Me.lblExpiry.TabIndex = 5
        Me.lblExpiry.Text = "Expiry date"
        '
        'grpCreditCard
        '
        Me.grpCreditCard.Controls.Add(Me.lblEuro)
        Me.grpCreditCard.Controls.Add(Me.txtTopUp)
        Me.grpCreditCard.Controls.Add(Me.lblTopUp)
        Me.grpCreditCard.Controls.Add(Me.btnCancel)
        Me.grpCreditCard.Controls.Add(Me.txtname)
        Me.grpCreditCard.Controls.Add(Me.lblCreditCard)
        Me.grpCreditCard.Controls.Add(Me.cmbYear)
        Me.grpCreditCard.Controls.Add(Me.cmbMonth)
        Me.grpCreditCard.Controls.Add(Me.txtCvv)
        Me.grpCreditCard.Controls.Add(Me.txtCardNumber)
        Me.grpCreditCard.Controls.Add(Me.cmbCreditCards)
        Me.grpCreditCard.Controls.Add(Me.btnRegister)
        Me.grpCreditCard.Controls.Add(Me.lblName)
        Me.grpCreditCard.Controls.Add(Me.lblCardType)
        Me.grpCreditCard.Controls.Add(Me.lblExpiry)
        Me.grpCreditCard.Controls.Add(Me.lblcardNum)
        Me.grpCreditCard.Controls.Add(Me.lblCvv)
        Me.grpCreditCard.Location = New System.Drawing.Point(53, 157)
        Me.grpCreditCard.Name = "grpCreditCard"
        Me.grpCreditCard.Size = New System.Drawing.Size(325, 327)
        Me.grpCreditCard.TabIndex = 6
        Me.grpCreditCard.TabStop = False
        '
        'txtTopUp
        '
        Me.txtTopUp.Location = New System.Drawing.Point(173, 227)
        Me.txtTopUp.Name = "txtTopUp"
        Me.txtTopUp.Size = New System.Drawing.Size(105, 20)
        Me.txtTopUp.TabIndex = 16
        '
        'lblTopUp
        '
        Me.lblTopUp.AutoSize = True
        Me.lblTopUp.Location = New System.Drawing.Point(21, 230)
        Me.lblTopUp.Name = "lblTopUp"
        Me.lblTopUp.Size = New System.Drawing.Size(80, 13)
        Me.lblTopUp.TabIndex = 15
        Me.lblTopUp.Text = "Top-up Amount"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(203, 277)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(157, 185)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(121, 20)
        Me.txtname.TabIndex = 13
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(218, 151)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(60, 21)
        Me.cmbYear.TabIndex = 12
        Me.cmbYear.Text = "Year"
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(157, 151)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(54, 21)
        Me.cmbMonth.TabIndex = 11
        Me.cmbMonth.Text = "Month"
        '
        'txtCvv
        '
        Me.txtCvv.Location = New System.Drawing.Point(157, 116)
        Me.txtCvv.Name = "txtCvv"
        Me.txtCvv.Size = New System.Drawing.Size(121, 20)
        Me.txtCvv.TabIndex = 10
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(157, 83)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtCardNumber.TabIndex = 9
        '
        'cmbCreditCards
        '
        Me.cmbCreditCards.FormattingEnabled = True
        Me.cmbCreditCards.Location = New System.Drawing.Point(157, 49)
        Me.cmbCreditCards.Name = "cmbCreditCards"
        Me.cmbCreditCards.Size = New System.Drawing.Size(121, 21)
        Me.cmbCreditCards.TabIndex = 8
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(24, 277)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 7
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(21, 188)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(92, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Card holder Name"
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Location = New System.Drawing.Point(10, 16)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(159, 13)
        Me.lblChoose.TabIndex = 7
        Me.lblChoose.Text = "Please choose your subscription"
        '
        'grpSubscription
        '
        Me.grpSubscription.Controls.Add(Me.lblThreeEuro)
        Me.grpSubscription.Controls.Add(Me.lblTenEuro)
        Me.grpSubscription.Controls.Add(Me.opt3Day)
        Me.grpSubscription.Controls.Add(Me.optAnnual)
        Me.grpSubscription.Controls.Add(Me.lbl3Day)
        Me.grpSubscription.Controls.Add(Me.lblAnnual)
        Me.grpSubscription.Controls.Add(Me.lblChoose)
        Me.grpSubscription.Location = New System.Drawing.Point(112, 68)
        Me.grpSubscription.Name = "grpSubscription"
        Me.grpSubscription.Size = New System.Drawing.Size(200, 83)
        Me.grpSubscription.TabIndex = 8
        Me.grpSubscription.TabStop = False
        '
        'lblThreeEuro
        '
        Me.lblThreeEuro.AutoSize = True
        Me.lblThreeEuro.Location = New System.Drawing.Point(104, 64)
        Me.lblThreeEuro.Name = "lblThreeEuro"
        Me.lblThreeEuro.Size = New System.Drawing.Size(19, 13)
        Me.lblThreeEuro.TabIndex = 13
        Me.lblThreeEuro.Text = "€3"
        '
        'lblTenEuro
        '
        Me.lblTenEuro.AutoSize = True
        Me.lblTenEuro.Location = New System.Drawing.Point(98, 43)
        Me.lblTenEuro.Name = "lblTenEuro"
        Me.lblTenEuro.Size = New System.Drawing.Size(25, 13)
        Me.lblTenEuro.TabIndex = 12
        Me.lblTenEuro.Text = "€10"
        '
        'opt3Day
        '
        Me.opt3Day.AutoSize = True
        Me.opt3Day.Location = New System.Drawing.Point(138, 64)
        Me.opt3Day.Name = "opt3Day"
        Me.opt3Day.Size = New System.Drawing.Size(14, 13)
        Me.opt3Day.TabIndex = 11
        Me.opt3Day.TabStop = True
        Me.opt3Day.UseVisualStyleBackColor = True
        '
        'optAnnual
        '
        Me.optAnnual.AutoSize = True
        Me.optAnnual.Location = New System.Drawing.Point(138, 43)
        Me.optAnnual.Name = "optAnnual"
        Me.optAnnual.Size = New System.Drawing.Size(14, 13)
        Me.optAnnual.TabIndex = 10
        Me.optAnnual.TabStop = True
        Me.optAnnual.UseVisualStyleBackColor = True
        '
        'lbl3Day
        '
        Me.lbl3Day.AutoSize = True
        Me.lbl3Day.Location = New System.Drawing.Point(43, 64)
        Me.lbl3Day.Name = "lbl3Day"
        Me.lbl3Day.Size = New System.Drawing.Size(35, 13)
        Me.lbl3Day.TabIndex = 9
        Me.lbl3Day.Text = "3 Day"
        '
        'lblAnnual
        '
        Me.lblAnnual.AutoSize = True
        Me.lblAnnual.Location = New System.Drawing.Point(43, 43)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(40, 13)
        Me.lblAnnual.TabIndex = 8
        Me.lblAnnual.Text = "Annual"
        '
        'lblEuro
        '
        Me.lblEuro.AutoSize = True
        Me.lblEuro.Location = New System.Drawing.Point(154, 230)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(13, 13)
        Me.lblEuro.TabIndex = 17
        Me.lblEuro.Text = "€"
        '
        'frmCreditCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(435, 504)
        Me.Controls.Add(Me.grpSubscription)
        Me.Controls.Add(Me.grpCreditCard)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmCreditCard"
        Me.Text = "Credit card Details"
        Me.grpCreditCard.ResumeLayout(False)
        Me.grpCreditCard.PerformLayout()
        Me.grpSubscription.ResumeLayout(False)
        Me.grpSubscription.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCreditCard As Label
    Friend WithEvents lblCardType As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblcardNum As Label
    Friend WithEvents lblCvv As Label
    Friend WithEvents lblExpiry As Label
    Friend WithEvents grpCreditCard As GroupBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents txtCvv As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents cmbCreditCards As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblChoose As Label
    Friend WithEvents grpSubscription As GroupBox
    Friend WithEvents opt3Day As RadioButton
    Friend WithEvents optAnnual As RadioButton
    Friend WithEvents lbl3Day As Label
    Friend WithEvents lblAnnual As Label
    Friend WithEvents lblThreeEuro As Label
    Friend WithEvents lblTenEuro As Label
    Friend WithEvents txtTopUp As TextBox
    Friend WithEvents lblTopUp As Label
    Friend WithEvents lblEuro As Label
End Class
