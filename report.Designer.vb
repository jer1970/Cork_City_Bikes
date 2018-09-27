<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblChooseABike = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblEnterNum = New System.Windows.Forms.Label()
        Me.cmbStationNumber = New System.Windows.Forms.ComboBox()
        Me.lstSelectedBikes = New System.Windows.Forms.ListBox()
        Me.lstAvailableBikes = New System.Windows.Forms.ListBox()
        Me.txtDamage = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
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
        Me.lblTitle.Size = New System.Drawing.Size(499, 84)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Cork City Bikes"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(194, 208)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 14
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblChooseABike
        '
        Me.lblChooseABike.AutoSize = True
        Me.lblChooseABike.Location = New System.Drawing.Point(42, 133)
        Me.lblChooseABike.Name = "lblChooseABike"
        Me.lblChooseABike.Size = New System.Drawing.Size(197, 13)
        Me.lblChooseABike.TabIndex = 13
        Me.lblChooseABike.Text = "Click on a bike number and press Select"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(194, 168)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 12
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblEnterNum
        '
        Me.lblEnterNum.AutoSize = True
        Me.lblEnterNum.Location = New System.Drawing.Point(42, 92)
        Me.lblEnterNum.Name = "lblEnterNum"
        Me.lblEnterNum.Size = New System.Drawing.Size(122, 13)
        Me.lblEnterNum.TabIndex = 11
        Me.lblEnterNum.Text = "Enter the station number"
        '
        'cmbStationNumber
        '
        Me.cmbStationNumber.FormattingEnabled = True
        Me.cmbStationNumber.Location = New System.Drawing.Point(184, 89)
        Me.cmbStationNumber.Name = "cmbStationNumber"
        Me.cmbStationNumber.Size = New System.Drawing.Size(55, 21)
        Me.cmbStationNumber.TabIndex = 10
        '
        'lstSelectedBikes
        '
        Me.lstSelectedBikes.FormattingEnabled = True
        Me.lstSelectedBikes.Location = New System.Drawing.Point(299, 149)
        Me.lstSelectedBikes.Name = "lstSelectedBikes"
        Me.lstSelectedBikes.Size = New System.Drawing.Size(120, 95)
        Me.lstSelectedBikes.TabIndex = 9
        '
        'lstAvailableBikes
        '
        Me.lstAvailableBikes.FormattingEnabled = True
        Me.lstAvailableBikes.Location = New System.Drawing.Point(43, 149)
        Me.lstAvailableBikes.Name = "lstAvailableBikes"
        Me.lstAvailableBikes.Size = New System.Drawing.Size(120, 95)
        Me.lstAvailableBikes.TabIndex = 8
        '
        'txtDamage
        '
        Me.txtDamage.Location = New System.Drawing.Point(43, 281)
        Me.txtDamage.Multiline = True
        Me.txtDamage.Name = "txtDamage"
        Me.txtDamage.Size = New System.Drawing.Size(383, 95)
        Me.txtDamage.TabIndex = 15
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(42, 265)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(115, 13)
        Me.lblDescription.TabIndex = 16
        Me.lblDescription.Text = "Description of Damage"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(320, 87)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(99, 23)
        Me.btnReturn.TabIndex = 17
        Me.btnReturn.Text = "Return to Menu"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 400)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtDamage)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblChooseABike)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblEnterNum)
        Me.Controls.Add(Me.cmbStationNumber)
        Me.Controls.Add(Me.lstSelectedBikes)
        Me.Controls.Add(Me.lstAvailableBikes)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmReport"
        Me.Text = "Damage Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents lblChooseABike As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblEnterNum As Label
    Friend WithEvents cmbStationNumber As ComboBox
    Friend WithEvents lstSelectedBikes As ListBox
    Friend WithEvents lstAvailableBikes As ListBox
    Friend WithEvents txtDamage As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnReturn As Button
End Class
