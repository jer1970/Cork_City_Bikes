<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblPinEnter = New System.Windows.Forms.Label()
        Me.txtPinEnter = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnStaffLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWelcome.Font = New System.Drawing.Font("Lucida Handwriting", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Red
        Me.lblWelcome.Location = New System.Drawing.Point(0, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(412, 108)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = " Welcome to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CORK CITY BIKES"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSignIn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSignIn.Location = New System.Drawing.Point(22, 228)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(75, 23)
        Me.btnSignIn.TabIndex = 1
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSignUp.Location = New System.Drawing.Point(303, 228)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(75, 23)
        Me.btnSignUp.TabIndex = 2
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(165, 228)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'lblPinEnter
        '
        Me.lblPinEnter.AutoSize = True
        Me.lblPinEnter.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPinEnter.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblPinEnter.Location = New System.Drawing.Point(5, 288)
        Me.lblPinEnter.Name = "lblPinEnter"
        Me.lblPinEnter.Size = New System.Drawing.Size(53, 13)
        Me.lblPinEnter.TabIndex = 4
        Me.lblPinEnter.Text = "Enter Pin "
        '
        'txtPinEnter
        '
        Me.txtPinEnter.Location = New System.Drawing.Point(91, 285)
        Me.txtPinEnter.Name = "txtPinEnter"
        Me.txtPinEnter.Size = New System.Drawing.Size(100, 20)
        Me.txtPinEnter.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.OrangeRed
        Me.btnLogin.Location = New System.Drawing.Point(258, 283)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.Red
        Me.btnStaff.Location = New System.Drawing.Point(337, 325)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(75, 23)
        Me.btnStaff.TabIndex = 7
        Me.btnStaff.Text = "Staff "
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(91, 312)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(100, 20)
        Me.txtpassword.TabIndex = 8
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblPassword.Location = New System.Drawing.Point(5, 315)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(81, 13)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Enter Password"
        '
        'btnStaffLogin
        '
        Me.btnStaffLogin.BackColor = System.Drawing.Color.Red
        Me.btnStaffLogin.Location = New System.Drawing.Point(258, 310)
        Me.btnStaffLogin.Name = "btnStaffLogin"
        Me.btnStaffLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnStaffLogin.TabIndex = 10
        Me.btnStaffLogin.Text = "Staff Login"
        Me.btnStaffLogin.UseVisualStyleBackColor = False
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.prjAssignment.My.Resources.Resources.bike2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(412, 347)
        Me.Controls.Add(Me.btnStaffLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPinEnter)
        Me.Controls.Add(Me.lblPinEnter)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "frmWelcome"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnSignIn As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents lblPinEnter As Label
    Friend WithEvents txtPinEnter As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnStaffLogin As Button
End Class
