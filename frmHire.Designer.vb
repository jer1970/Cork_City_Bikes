<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHire
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
        Me.lstAvailableBikes = New System.Windows.Forms.ListBox()
        Me.lstSelectedBikes = New System.Windows.Forms.ListBox()
        Me.cmbStationNumber = New System.Windows.Forms.ComboBox()
        Me.lblEnterNum = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblChooseABike = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAvailableBikes
        '
        Me.lstAvailableBikes.FormattingEnabled = True
        Me.lstAvailableBikes.Location = New System.Drawing.Point(43, 194)
        Me.lstAvailableBikes.Name = "lstAvailableBikes"
        Me.lstAvailableBikes.Size = New System.Drawing.Size(120, 95)
        Me.lstAvailableBikes.TabIndex = 0
        '
        'lstSelectedBikes
        '
        Me.lstSelectedBikes.FormattingEnabled = True
        Me.lstSelectedBikes.Location = New System.Drawing.Point(301, 194)
        Me.lstSelectedBikes.Name = "lstSelectedBikes"
        Me.lstSelectedBikes.Size = New System.Drawing.Size(120, 95)
        Me.lstSelectedBikes.TabIndex = 1
        '
        'cmbStationNumber
        '
        Me.cmbStationNumber.FormattingEnabled = True
        Me.cmbStationNumber.Location = New System.Drawing.Point(43, 141)
        Me.cmbStationNumber.Name = "cmbStationNumber"
        Me.cmbStationNumber.Size = New System.Drawing.Size(121, 21)
        Me.cmbStationNumber.TabIndex = 3
        '
        'lblEnterNum
        '
        Me.lblEnterNum.AutoSize = True
        Me.lblEnterNum.Location = New System.Drawing.Point(42, 115)
        Me.lblEnterNum.Name = "lblEnterNum"
        Me.lblEnterNum.Size = New System.Drawing.Size(122, 13)
        Me.lblEnterNum.TabIndex = 4
        Me.lblEnterNum.Text = "Enter the station number"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(193, 214)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblChooseABike
        '
        Me.lblChooseABike.AutoSize = True
        Me.lblChooseABike.Location = New System.Drawing.Point(42, 178)
        Me.lblChooseABike.Name = "lblChooseABike"
        Me.lblChooseABike.Size = New System.Drawing.Size(197, 13)
        Me.lblChooseABike.TabIndex = 6
        Me.lblChooseABike.Text = "Click on a bike number and press Select"
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(193, 254)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
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
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Cork City Bikes"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(322, 131)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(99, 23)
        Me.btnReturn.TabIndex = 9
        Me.btnReturn.Text = "Return to Menu"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmHire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 347)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblChooseABike)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblEnterNum)
        Me.Controls.Add(Me.cmbStationNumber)
        Me.Controls.Add(Me.lstSelectedBikes)
        Me.Controls.Add(Me.lstAvailableBikes)
        Me.Name = "frmHire"
        Me.Text = "Hire a Bike"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstAvailableBikes As ListBox
    Friend WithEvents lstSelectedBikes As ListBox
    Friend WithEvents cmbStationNumber As ComboBox
    Friend WithEvents lblEnterNum As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblChooseABike As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnReturn As Button
End Class
