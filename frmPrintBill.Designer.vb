<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintBill
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBikeNum = New System.Windows.Forms.Label()
        Me.lblStarttime = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lstCostOfHire = New System.Windows.Forms.ListBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
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
        Me.lblTitle.Size = New System.Drawing.Size(449, 84)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Cork City Bikes"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(46, 94)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name"
        '
        'lblBikeNum
        '
        Me.lblBikeNum.AutoSize = True
        Me.lblBikeNum.Location = New System.Drawing.Point(102, 94)
        Me.lblBikeNum.Name = "lblBikeNum"
        Me.lblBikeNum.Size = New System.Drawing.Size(68, 13)
        Me.lblBikeNum.TabIndex = 7
        Me.lblBikeNum.Text = "Bike Number"
        '
        'lblStarttime
        '
        Me.lblStarttime.AutoSize = True
        Me.lblStarttime.Location = New System.Drawing.Point(176, 94)
        Me.lblStarttime.Name = "lblStarttime"
        Me.lblStarttime.Size = New System.Drawing.Size(55, 13)
        Me.lblStarttime.TabIndex = 8
        Me.lblStarttime.Text = "Start Time"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(237, 94)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(52, 13)
        Me.lblEndTime.TabIndex = 9
        Me.lblEndTime.Text = "End Time"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(341, 94)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(62, 13)
        Me.lblCost.TabIndex = 10
        Me.lblCost.Text = "Cost of Hire"
        '
        'lstCostOfHire
        '
        Me.lstCostOfHire.FormattingEnabled = True
        Me.lstCostOfHire.Location = New System.Drawing.Point(40, 119)
        Me.lstCostOfHire.Name = "lstCostOfHire"
        Me.lstCostOfHire.Size = New System.Drawing.Size(374, 95)
        Me.lstCostOfHire.TabIndex = 16
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(296, 94)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(47, 13)
        Me.lblDuration.TabIndex = 17
        Me.lblDuration.Text = "Duration"
        '
        'BtnReturn
        '
        Me.BtnReturn.Location = New System.Drawing.Point(40, 252)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(99, 23)
        Me.BtnReturn.TabIndex = 18
        Me.BtnReturn.Text = "Return to menu"
        Me.BtnReturn.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(227, 252)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPrintBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 316)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lstCostOfHire)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.lblStarttime)
        Me.Controls.Add(Me.lblBikeNum)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmPrintBill"
        Me.Text = "frmPrintBill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblBikeNum As Label
    Friend WithEvents lblStarttime As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lstCostOfHire As ListBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents BtnReturn As Button
    Friend WithEvents btnExit As Button
End Class
