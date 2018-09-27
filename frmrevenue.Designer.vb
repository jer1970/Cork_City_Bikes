<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrevenue
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
        Me.cmbStationNumber = New System.Windows.Forms.ComboBox()
        Me.lblStationNum = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblOverall = New System.Windows.Forms.Label()
        Me.lblOverallDigits = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grprevenue = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.grprevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbStationNumber
        '
        Me.cmbStationNumber.FormattingEnabled = True
        Me.cmbStationNumber.Location = New System.Drawing.Point(33, 56)
        Me.cmbStationNumber.Name = "cmbStationNumber"
        Me.cmbStationNumber.Size = New System.Drawing.Size(46, 21)
        Me.cmbStationNumber.TabIndex = 11
        '
        'lblStationNum
        '
        Me.lblStationNum.AutoSize = True
        Me.lblStationNum.Location = New System.Drawing.Point(17, 16)
        Me.lblStationNum.Name = "lblStationNum"
        Me.lblStationNum.Size = New System.Drawing.Size(78, 13)
        Me.lblStationNum.TabIndex = 12
        Me.lblStationNum.Text = "Station number"
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Location = New System.Drawing.Point(101, 16)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(51, 13)
        Me.lblRevenue.TabIndex = 13
        Me.lblRevenue.Text = "Revenue"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(111, 59)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(28, 13)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "0.00"
        '
        'lblEuro
        '
        Me.lblEuro.AutoSize = True
        Me.lblEuro.Location = New System.Drawing.Point(101, 59)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(13, 13)
        Me.lblEuro.TabIndex = 15
        Me.lblEuro.Text = "€"
        '
        'lblOverall
        '
        Me.lblOverall.AutoSize = True
        Me.lblOverall.Location = New System.Drawing.Point(174, 16)
        Me.lblOverall.Name = "lblOverall"
        Me.lblOverall.Size = New System.Drawing.Size(87, 13)
        Me.lblOverall.TabIndex = 16
        Me.lblOverall.Text = "Overall Revenue"
        '
        'lblOverallDigits
        '
        Me.lblOverallDigits.AutoSize = True
        Me.lblOverallDigits.Location = New System.Drawing.Point(205, 59)
        Me.lblOverallDigits.Name = "lblOverallDigits"
        Me.lblOverallDigits.Size = New System.Drawing.Size(28, 13)
        Me.lblOverallDigits.TabIndex = 17
        Me.lblOverallDigits.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "€"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Handwriting", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(355, 82)
        Me.lblTitle.TabIndex = 19
        Me.lblTitle.Text = "Cork City Bikes"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grprevenue
        '
        Me.grprevenue.Controls.Add(Me.lblStationNum)
        Me.grprevenue.Controls.Add(Me.cmbStationNumber)
        Me.grprevenue.Controls.Add(Me.lblEuro)
        Me.grprevenue.Controls.Add(Me.Label1)
        Me.grprevenue.Controls.Add(Me.lblRevenue)
        Me.grprevenue.Controls.Add(Me.lblOverallDigits)
        Me.grprevenue.Controls.Add(Me.lblOverall)
        Me.grprevenue.Controls.Add(Me.lblTotal)
        Me.grprevenue.Location = New System.Drawing.Point(38, 76)
        Me.grprevenue.Name = "grprevenue"
        Me.grprevenue.Size = New System.Drawing.Size(287, 100)
        Me.grprevenue.TabIndex = 20
        Me.grprevenue.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(58, 191)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 21
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'frmrevenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 237)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.grprevenue)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmrevenue"
        Me.Text = "frmrevenue"
        Me.grprevenue.ResumeLayout(False)
        Me.grprevenue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbStationNumber As ComboBox
    Friend WithEvents lblStationNum As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents lblOverall As Label
    Friend WithEvents lblOverallDigits As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents grprevenue As GroupBox
    Friend WithEvents btnLogout As Button
End Class
