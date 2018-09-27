<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientAction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnHire = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnTopUp = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblbike = New System.Windows.Forms.Label()
        Me.lblTopUpAction = New System.Windows.Forms.Label()
        Me.lblEuroAction = New System.Windows.Forms.Label()
        Me.txtTopUpAction = New System.Windows.Forms.TextBox()
        Me.btnSubmitTopUp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHire
        '
        Me.btnHire.Location = New System.Drawing.Point(28, 97)
        Me.btnHire.Name = "btnHire"
        Me.btnHire.Size = New System.Drawing.Size(100, 23)
        Me.btnHire.TabIndex = 0
        Me.btnHire.Text = "Hire a Bike"
        Me.btnHire.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(28, 149)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(100, 23)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return a Bike"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnTopUp
        '
        Me.btnTopUp.Location = New System.Drawing.Point(28, 205)
        Me.btnTopUp.Name = "btnTopUp"
        Me.btnTopUp.Size = New System.Drawing.Size(100, 23)
        Me.btnTopUp.TabIndex = 2
        Me.btnTopUp.Text = "Top Up Account"
        Me.btnTopUp.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(28, 256)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(100, 23)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Report an Issue"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Handwriting", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(501, 84)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Cork City Bikes"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblbike
        '
        Me.lblbike.Image = Global.prjAssignment.My.Resources.Resources.bike2
        Me.lblbike.Location = New System.Drawing.Point(149, 84)
        Me.lblbike.Name = "lblbike"
        Me.lblbike.Size = New System.Drawing.Size(330, 209)
        Me.lblbike.TabIndex = 5
        '
        'lblTopUpAction
        '
        Me.lblTopUpAction.AutoSize = True
        Me.lblTopUpAction.Location = New System.Drawing.Point(173, 210)
        Me.lblTopUpAction.Name = "lblTopUpAction"
        Me.lblTopUpAction.Size = New System.Drawing.Size(108, 13)
        Me.lblTopUpAction.TabIndex = 16
        Me.lblTopUpAction.Text = "Enter Top-up Amount"
        '
        'lblEuroAction
        '
        Me.lblEuroAction.AutoSize = True
        Me.lblEuroAction.Location = New System.Drawing.Point(311, 210)
        Me.lblEuroAction.Name = "lblEuroAction"
        Me.lblEuroAction.Size = New System.Drawing.Size(13, 13)
        Me.lblEuroAction.TabIndex = 18
        Me.lblEuroAction.Text = "€"
        '
        'txtTopUpAction
        '
        Me.txtTopUpAction.Location = New System.Drawing.Point(330, 208)
        Me.txtTopUpAction.Name = "txtTopUpAction"
        Me.txtTopUpAction.Size = New System.Drawing.Size(105, 20)
        Me.txtTopUpAction.TabIndex = 19
        '
        'btnSubmitTopUp
        '
        Me.btnSubmitTopUp.Location = New System.Drawing.Point(330, 255)
        Me.btnSubmitTopUp.Name = "btnSubmitTopUp"
        Me.btnSubmitTopUp.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmitTopUp.TabIndex = 20
        Me.btnSubmitTopUp.Text = "Submit"
        Me.btnSubmitTopUp.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(28, 295)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmClientAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 330)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmitTopUp)
        Me.Controls.Add(Me.txtTopUpAction)
        Me.Controls.Add(Me.lblEuroAction)
        Me.Controls.Add(Me.lblTopUpAction)
        Me.Controls.Add(Me.lblbike)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnTopUp)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnHire)
        Me.Name = "frmClientAction"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHire As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnTopUp As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblbike As Label
    Friend WithEvents lblTopUpAction As Label
    Friend WithEvents lblEuroAction As Label
    Friend WithEvents txtTopUpAction As TextBox
    Friend WithEvents btnSubmitTopUp As Button
    Friend WithEvents btnExit As Button
End Class
