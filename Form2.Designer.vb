<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignUp
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.lblfemale = New System.Windows.Forms.Label()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.optFemale = New System.Windows.Forms.RadioButton()
        Me.optMale = New System.Windows.Forms.RadioButton()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtAddress3 = New System.Windows.Forms.TextBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.lblConfirmPin = New System.Windows.Forms.Label()
        Me.txtConfirmPin = New System.Windows.Forms.TextBox()
        Me.lblTandC = New System.Windows.Forms.Label()
        Me.chkTandC = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.txtIntPrefix = New System.Windows.Forms.TextBox()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.lblIntPrefix = New System.Windows.Forms.Label()
        Me.lblPrefix = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.btnTandC = New System.Windows.Forms.Button()
        Me.cmbCounty = New System.Windows.Forms.ComboBox()
        Me.cmbCountries = New System.Windows.Forms.ComboBox()
        Me.grpGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Handwriting", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(484, 94)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Cork City Bikes"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(53, 80)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(55, 13)
        Me.lblFname.TabIndex = 1
        Me.lblFname.Text = "First name"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(139, 74)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(254, 20)
        Me.txtFname.TabIndex = 2
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(52, 110)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(56, 13)
        Me.lblLname.TabIndex = 3
        Me.lblLname.Text = "Last name"
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(139, 103)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(254, 20)
        Me.txtLname.TabIndex = 4
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Location = New System.Drawing.Point(53, 143)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(66, 13)
        Me.lblDob.TabIndex = 5
        Me.lblDob.Text = "Date of Birth"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(53, 174)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 7
        Me.lblGender.Text = "Gender"
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.Location = New System.Drawing.Point(6, 12)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(16, 13)
        Me.lblMale.TabIndex = 8
        Me.lblMale.Text = "M"
        '
        'lblfemale
        '
        Me.lblfemale.AutoSize = True
        Me.lblfemale.Location = New System.Drawing.Point(61, 12)
        Me.lblfemale.Name = "lblfemale"
        Me.lblfemale.Size = New System.Drawing.Size(13, 13)
        Me.lblfemale.TabIndex = 9
        Me.lblfemale.Text = "F"
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.optFemale)
        Me.grpGender.Controls.Add(Me.optMale)
        Me.grpGender.Controls.Add(Me.lblfemale)
        Me.grpGender.Controls.Add(Me.lblMale)
        Me.grpGender.Location = New System.Drawing.Point(139, 162)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(117, 36)
        Me.grpGender.TabIndex = 10
        Me.grpGender.TabStop = False
        '
        'optFemale
        '
        Me.optFemale.AutoSize = True
        Me.optFemale.Location = New System.Drawing.Point(80, 12)
        Me.optFemale.Name = "optFemale"
        Me.optFemale.Size = New System.Drawing.Size(14, 13)
        Me.optFemale.TabIndex = 11
        Me.optFemale.TabStop = True
        Me.optFemale.UseVisualStyleBackColor = True
        '
        'optMale
        '
        Me.optMale.AutoSize = True
        Me.optMale.Location = New System.Drawing.Point(28, 12)
        Me.optMale.Name = "optMale"
        Me.optMale.Size = New System.Drawing.Size(14, 13)
        Me.optMale.TabIndex = 10
        Me.optMale.TabStop = True
        Me.optMale.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(52, 210)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(139, 203)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(254, 20)
        Me.txtEmail.TabIndex = 12
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(52, 263)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(72, 13)
        Me.lblMobile.TabIndex = 13
        Me.lblMobile.Text = "Mobile Phone"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(211, 260)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(182, 20)
        Me.txtMobile.TabIndex = 14
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(52, 292)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 15
        Me.lblAddress.Text = "Address"
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(139, 289)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(254, 20)
        Me.txtAddress1.TabIndex = 16
        Me.txtAddress1.Text = "Address line 1"
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(139, 315)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(254, 20)
        Me.txtAddress2.TabIndex = 17
        Me.txtAddress2.Text = "Address line 2 (optional)"
        '
        'txtAddress3
        '
        Me.txtAddress3.Location = New System.Drawing.Point(139, 341)
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(254, 20)
        Me.txtAddress3.TabIndex = 18
        Me.txtAddress3.Text = "Address line 3 (optional)"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(55, 370)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(40, 13)
        Me.lblCounty.TabIndex = 19
        Me.lblCounty.Text = "County"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(54, 403)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(43, 13)
        Me.lblCountry.TabIndex = 21
        Me.lblCountry.Text = "Country"
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Location = New System.Drawing.Point(55, 430)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(136, 13)
        Me.lblPin.TabIndex = 23
        Me.lblPin.Text = "Create a 4-digit Pin Number"
        '
        'txtPin
        '
        Me.txtPin.Location = New System.Drawing.Point(197, 427)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(100, 20)
        Me.txtPin.TabIndex = 24
        '
        'lblConfirmPin
        '
        Me.lblConfirmPin.AutoSize = True
        Me.lblConfirmPin.Location = New System.Drawing.Point(54, 464)
        Me.lblConfirmPin.Name = "lblConfirmPin"
        Me.lblConfirmPin.Size = New System.Drawing.Size(100, 13)
        Me.lblConfirmPin.TabIndex = 25
        Me.lblConfirmPin.Text = "Confirm Pin Number"
        '
        'txtConfirmPin
        '
        Me.txtConfirmPin.Location = New System.Drawing.Point(196, 461)
        Me.txtConfirmPin.Name = "txtConfirmPin"
        Me.txtConfirmPin.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmPin.TabIndex = 26
        '
        'lblTandC
        '
        Me.lblTandC.AutoSize = True
        Me.lblTandC.Location = New System.Drawing.Point(55, 504)
        Me.lblTandC.Name = "lblTandC"
        Me.lblTandC.Size = New System.Drawing.Size(241, 13)
        Me.lblTandC.TabIndex = 27
        Me.lblTandC.Text = "I have read and accept the Terms and Conditions"
        '
        'chkTandC
        '
        Me.chkTandC.AutoSize = True
        Me.chkTandC.Location = New System.Drawing.Point(312, 503)
        Me.chkTandC.Name = "chkTandC"
        Me.chkTandC.Size = New System.Drawing.Size(15, 14)
        Me.chkTandC.TabIndex = 28
        Me.chkTandC.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(106, 548)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 29
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(273, 548)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(139, 140)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(74, 21)
        Me.cmbDay.TabIndex = 31
        Me.cmbDay.Text = "Select day"
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(219, 140)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(88, 21)
        Me.cmbMonth.TabIndex = 32
        Me.cmbMonth.Text = "Select Month"
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(313, 140)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(80, 21)
        Me.cmbYear.TabIndex = 33
        Me.cmbYear.Text = "Select Year"
        '
        'txtIntPrefix
        '
        Me.txtIntPrefix.Location = New System.Drawing.Point(139, 260)
        Me.txtIntPrefix.Name = "txtIntPrefix"
        Me.txtIntPrefix.Size = New System.Drawing.Size(28, 20)
        Me.txtIntPrefix.TabIndex = 34
        Me.txtIntPrefix.Text = "353"
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(173, 260)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(32, 20)
        Me.txtPrefix.TabIndex = 35
        '
        'lblIntPrefix
        '
        Me.lblIntPrefix.AutoSize = True
        Me.lblIntPrefix.Location = New System.Drawing.Point(139, 241)
        Me.lblIntPrefix.Name = "lblIntPrefix"
        Me.lblIntPrefix.Size = New System.Drawing.Size(19, 13)
        Me.lblIntPrefix.TabIndex = 36
        Me.lblIntPrefix.Text = "Int"
        '
        'lblPrefix
        '
        Me.lblPrefix.AutoSize = True
        Me.lblPrefix.Location = New System.Drawing.Point(172, 241)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(33, 13)
        Me.lblPrefix.TabIndex = 37
        Me.lblPrefix.Text = "Prefix"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(219, 241)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(44, 13)
        Me.lblNumber.TabIndex = 38
        Me.lblNumber.Text = "Number"
        '
        'btnTandC
        '
        Me.btnTandC.Location = New System.Drawing.Point(187, 499)
        Me.btnTandC.Name = "btnTandC"
        Me.btnTandC.Size = New System.Drawing.Size(120, 23)
        Me.btnTandC.TabIndex = 39
        Me.btnTandC.Text = "Terms and Conditions"
        Me.btnTandC.UseVisualStyleBackColor = True
        '
        'cmbCounty
        '
        Me.cmbCounty.FormattingEnabled = True
        Me.cmbCounty.Location = New System.Drawing.Point(139, 370)
        Me.cmbCounty.Name = "cmbCounty"
        Me.cmbCounty.Size = New System.Drawing.Size(254, 21)
        Me.cmbCounty.TabIndex = 40
        '
        'cmbCountries
        '
        Me.cmbCountries.FormattingEnabled = True
        Me.cmbCountries.Location = New System.Drawing.Point(139, 400)
        Me.cmbCountries.Name = "cmbCountries"
        Me.cmbCountries.Size = New System.Drawing.Size(254, 21)
        Me.cmbCountries.TabIndex = 41
        '
        'frmSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(484, 593)
        Me.Controls.Add(Me.cmbCountries)
        Me.Controls.Add(Me.cmbCounty)
        Me.Controls.Add(Me.btnTandC)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblPrefix)
        Me.Controls.Add(Me.lblIntPrefix)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.txtIntPrefix)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.chkTandC)
        Me.Controls.Add(Me.lblTandC)
        Me.Controls.Add(Me.txtConfirmPin)
        Me.Controls.Add(Me.lblConfirmPin)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.lblPin)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.txtAddress3)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.grpGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmSignUp"
        Me.Text = "Sign Up"
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFname As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents lblLname As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents lblDob As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblMale As Label
    Friend WithEvents lblfemale As Label
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents txtAddress3 As TextBox
    Friend WithEvents lblCounty As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblPin As Label
    Friend WithEvents txtPin As TextBox
    Friend WithEvents lblConfirmPin As Label
    Friend WithEvents txtConfirmPin As TextBox
    Friend WithEvents lblTandC As Label
    Friend WithEvents chkTandC As CheckBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents optFemale As RadioButton
    Friend WithEvents optMale As RadioButton
    Friend WithEvents txtIntPrefix As TextBox
    Friend WithEvents txtPrefix As TextBox
    Friend WithEvents lblIntPrefix As Label
    Friend WithEvents lblPrefix As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents btnTandC As Button
    Friend WithEvents cmbCounty As ComboBox
    Friend WithEvents cmbCountries As ComboBox
End Class
