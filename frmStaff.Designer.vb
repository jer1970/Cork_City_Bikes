<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaff
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnRepaired = New System.Windows.Forms.Button()
        Me.btnAlerts = New System.Windows.Forms.Button()
        Me.btnDamage = New System.Windows.Forms.Button()
        Me.btnGarage = New System.Windows.Forms.Button()
        Me.lstDamagedBikes = New System.Windows.Forms.ListBox()
        Me.cmbStationNumber = New System.Windows.Forms.ComboBox()
        Me.lblStationNum = New System.Windows.Forms.Label()
        Me.lstForRepair = New System.Windows.Forms.ListBox()
        Me.lbldamagedBikes = New System.Windows.Forms.Label()
        Me.lblBikesForRepair = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnSelectBike = New System.Windows.Forms.Button()
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
        Me.lblTitle.Size = New System.Drawing.Size(535, 74)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Cork City Bikes"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRepaired
        '
        Me.btnRepaired.Location = New System.Drawing.Point(280, 86)
        Me.btnRepaired.Name = "btnRepaired"
        Me.btnRepaired.Size = New System.Drawing.Size(115, 23)
        Me.btnRepaired.TabIndex = 22
        Me.btnRepaired.Text = "Repaired Log"
        Me.btnRepaired.UseVisualStyleBackColor = True
        '
        'btnAlerts
        '
        Me.btnAlerts.Location = New System.Drawing.Point(401, 86)
        Me.btnAlerts.Name = "btnAlerts"
        Me.btnAlerts.Size = New System.Drawing.Size(111, 23)
        Me.btnAlerts.TabIndex = 23
        Me.btnAlerts.Text = "Alerts"
        Me.btnAlerts.UseVisualStyleBackColor = True
        '
        'btnDamage
        '
        Me.btnDamage.Location = New System.Drawing.Point(28, 86)
        Me.btnDamage.Name = "btnDamage"
        Me.btnDamage.Size = New System.Drawing.Size(124, 23)
        Me.btnDamage.TabIndex = 24
        Me.btnDamage.Text = "Damage Reports"
        Me.btnDamage.UseVisualStyleBackColor = True
        '
        'btnGarage
        '
        Me.btnGarage.Location = New System.Drawing.Point(158, 86)
        Me.btnGarage.Name = "btnGarage"
        Me.btnGarage.Size = New System.Drawing.Size(116, 23)
        Me.btnGarage.TabIndex = 25
        Me.btnGarage.Text = "Garage"
        Me.btnGarage.UseVisualStyleBackColor = True
        '
        'lstDamagedBikes
        '
        Me.lstDamagedBikes.FormattingEnabled = True
        Me.lstDamagedBikes.Location = New System.Drawing.Point(12, 163)
        Me.lstDamagedBikes.Name = "lstDamagedBikes"
        Me.lstDamagedBikes.Size = New System.Drawing.Size(240, 108)
        Me.lstDamagedBikes.TabIndex = 27
        '
        'cmbStationNumber
        '
        Me.cmbStationNumber.FormattingEnabled = True
        Me.cmbStationNumber.Location = New System.Drawing.Point(188, 119)
        Me.cmbStationNumber.Name = "cmbStationNumber"
        Me.cmbStationNumber.Size = New System.Drawing.Size(67, 21)
        Me.cmbStationNumber.TabIndex = 28
        '
        'lblStationNum
        '
        Me.lblStationNum.AutoSize = True
        Me.lblStationNum.Location = New System.Drawing.Point(25, 122)
        Me.lblStationNum.Name = "lblStationNum"
        Me.lblStationNum.Size = New System.Drawing.Size(157, 13)
        Me.lblStationNum.TabIndex = 29
        Me.lblStationNum.Text = "Remove bikes from station"
        '
        'lstForRepair
        '
        Me.lstForRepair.FormattingEnabled = True
        Me.lstForRepair.Location = New System.Drawing.Point(272, 163)
        Me.lstForRepair.Name = "lstForRepair"
        Me.lstForRepair.Size = New System.Drawing.Size(240, 108)
        Me.lstForRepair.TabIndex = 30
        '
        'lbldamagedBikes
        '
        Me.lbldamagedBikes.AutoSize = True
        Me.lbldamagedBikes.Location = New System.Drawing.Point(25, 147)
        Me.lbldamagedBikes.Name = "lbldamagedBikes"
        Me.lbldamagedBikes.Size = New System.Drawing.Size(95, 13)
        Me.lbldamagedBikes.TabIndex = 31
        Me.lbldamagedBikes.Text = "Damaged Bikes"
        '
        'lblBikesForRepair
        '
        Me.lblBikesForRepair.AutoSize = True
        Me.lblBikesForRepair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBikesForRepair.Location = New System.Drawing.Point(279, 147)
        Me.lblBikesForRepair.Name = "lblBikesForRepair"
        Me.lblBikesForRepair.Size = New System.Drawing.Size(98, 13)
        Me.lblBikesForRepair.TabIndex = 32
        Me.lblBikesForRepair.Text = "Bikes for Repair"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(272, 298)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(87, 23)
        Me.btnRemove.TabIndex = 36
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(177, 298)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(87, 23)
        Me.btnSelectAll.TabIndex = 35
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(365, 298)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(87, 23)
        Me.btnDone.TabIndex = 34
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnSelectBike
        '
        Me.btnSelectBike.Location = New System.Drawing.Point(83, 298)
        Me.btnSelectBike.Name = "btnSelectBike"
        Me.btnSelectBike.Size = New System.Drawing.Size(87, 23)
        Me.btnSelectBike.TabIndex = 33
        Me.btnSelectBike.Text = "Select"
        Me.btnSelectBike.UseVisualStyleBackColor = True
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 333)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnSelectBike)
        Me.Controls.Add(Me.lblBikesForRepair)
        Me.Controls.Add(Me.lbldamagedBikes)
        Me.Controls.Add(Me.lstForRepair)
        Me.Controls.Add(Me.lblStationNum)
        Me.Controls.Add(Me.cmbStationNumber)
        Me.Controls.Add(Me.lstDamagedBikes)
        Me.Controls.Add(Me.btnGarage)
        Me.Controls.Add(Me.btnDamage)
        Me.Controls.Add(Me.btnAlerts)
        Me.Controls.Add(Me.btnRepaired)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmStaff"
        Me.Text = "Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnRepaired As Button
    Friend WithEvents btnAlerts As Button
    Friend WithEvents btnDamage As Button
    Friend WithEvents btnGarage As Button
    Friend WithEvents lstDamagedBikes As ListBox
    Friend WithEvents cmbStationNumber As ComboBox
    Friend WithEvents lblStationNum As Label
    Friend WithEvents lstForRepair As ListBox
    Friend WithEvents lbldamagedBikes As Label
    Friend WithEvents lblBikesForRepair As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents btnSelectBike As Button
End Class
