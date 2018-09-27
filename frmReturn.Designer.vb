<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturn
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
        Me.lblEnterNum = New System.Windows.Forms.Label()
        Me.cmbStationNumber = New System.Windows.Forms.ComboBox()
        Me.lblReturnABike = New System.Windows.Forms.Label()
        Me.lstBikesToReturn = New System.Windows.Forms.ListBox()
        Me.lstReturnedBikes = New System.Windows.Forms.ListBox()
        Me.btnSelectBike = New System.Windows.Forms.Button()
        Me.btnDoneReturn = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.lblRentedBikes = New System.Windows.Forms.Label()
        Me.lblReturnedBikes = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterNum
        '
        Me.lblEnterNum.AutoSize = True
        Me.lblEnterNum.Location = New System.Drawing.Point(36, 107)
        Me.lblEnterNum.Name = "lblEnterNum"
        Me.lblEnterNum.Size = New System.Drawing.Size(122, 13)
        Me.lblEnterNum.TabIndex = 5
        Me.lblEnterNum.Text = "Enter the station number"
        '
        'cmbStationNumber
        '
        Me.cmbStationNumber.FormattingEnabled = True
        Me.cmbStationNumber.Location = New System.Drawing.Point(164, 107)
        Me.cmbStationNumber.Name = "cmbStationNumber"
        Me.cmbStationNumber.Size = New System.Drawing.Size(121, 21)
        Me.cmbStationNumber.TabIndex = 6
        '
        'lblReturnABike
        '
        Me.lblReturnABike.AutoSize = True
        Me.lblReturnABike.Location = New System.Drawing.Point(22, 140)
        Me.lblReturnABike.Name = "lblReturnABike"
        Me.lblReturnABike.Size = New System.Drawing.Size(164, 13)
        Me.lblReturnABike.TabIndex = 7
        Me.lblReturnABike.Text = "Select the bike you wish to return"
        '
        'lstBikesToReturn
        '
        Me.lstBikesToReturn.FormattingEnabled = True
        Me.lstBikesToReturn.Location = New System.Drawing.Point(12, 181)
        Me.lstBikesToReturn.Name = "lstBikesToReturn"
        Me.lstBikesToReturn.Size = New System.Drawing.Size(192, 108)
        Me.lstBikesToReturn.TabIndex = 8
        '
        'lstReturnedBikes
        '
        Me.lstReturnedBikes.FormattingEnabled = True
        Me.lstReturnedBikes.Location = New System.Drawing.Point(291, 181)
        Me.lstReturnedBikes.Name = "lstReturnedBikes"
        Me.lstReturnedBikes.Size = New System.Drawing.Size(201, 108)
        Me.lstReturnedBikes.TabIndex = 9
        '
        'btnSelectBike
        '
        Me.btnSelectBike.Location = New System.Drawing.Point(210, 181)
        Me.btnSelectBike.Name = "btnSelectBike"
        Me.btnSelectBike.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectBike.TabIndex = 10
        Me.btnSelectBike.Text = "Select"
        Me.btnSelectBike.UseVisualStyleBackColor = True
        '
        'btnDoneReturn
        '
        Me.btnDoneReturn.Location = New System.Drawing.Point(210, 266)
        Me.btnDoneReturn.Name = "btnDoneReturn"
        Me.btnDoneReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnDoneReturn.TabIndex = 11
        Me.btnDoneReturn.Text = "Done"
        Me.btnDoneReturn.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(210, 210)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectAll.TabIndex = 12
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'lblRentedBikes
        '
        Me.lblRentedBikes.AutoSize = True
        Me.lblRentedBikes.Location = New System.Drawing.Point(22, 165)
        Me.lblRentedBikes.Name = "lblRentedBikes"
        Me.lblRentedBikes.Size = New System.Drawing.Size(71, 13)
        Me.lblRentedBikes.TabIndex = 13
        Me.lblRentedBikes.Text = "Rented Bikes"
        '
        'lblReturnedBikes
        '
        Me.lblReturnedBikes.AutoSize = True
        Me.lblReturnedBikes.Location = New System.Drawing.Point(302, 165)
        Me.lblReturnedBikes.Name = "lblReturnedBikes"
        Me.lblReturnedBikes.Size = New System.Drawing.Size(79, 13)
        Me.lblReturnedBikes.TabIndex = 14
        Me.lblReturnedBikes.Text = "Returned bikes"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(210, 239)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 15
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Handwriting", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(504, 84)
        Me.lblTitle.TabIndex = 16
        Me.lblTitle.Text = "Cork City Bikes"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(331, 107)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(97, 23)
        Me.btnReturn.TabIndex = 17
        Me.btnReturn.Text = "Return to Menu"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 347)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblReturnedBikes)
        Me.Controls.Add(Me.lblRentedBikes)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.btnDoneReturn)
        Me.Controls.Add(Me.btnSelectBike)
        Me.Controls.Add(Me.lstReturnedBikes)
        Me.Controls.Add(Me.lstBikesToReturn)
        Me.Controls.Add(Me.lblReturnABike)
        Me.Controls.Add(Me.cmbStationNumber)
        Me.Controls.Add(Me.lblEnterNum)
        Me.Name = "frmReturn"
        Me.Text = "Return a Bike"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterNum As Label
    Friend WithEvents cmbStationNumber As ComboBox
    Friend WithEvents lblReturnABike As Label
    Friend WithEvents lstBikesToReturn As ListBox
    Friend WithEvents lstReturnedBikes As ListBox
    Friend WithEvents btnSelectBike As Button
    Friend WithEvents btnDoneReturn As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents lblRentedBikes As Label
    Friend WithEvents lblReturnedBikes As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnReturn As Button
End Class
