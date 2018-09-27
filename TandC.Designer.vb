<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTandC
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
        Me.txtTandC = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtTandC
        '
        Me.txtTandC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTandC.Location = New System.Drawing.Point(0, 0)
        Me.txtTandC.Multiline = True
        Me.txtTandC.Name = "txtTandC"
        Me.txtTandC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTandC.Size = New System.Drawing.Size(284, 261)
        Me.txtTandC.TabIndex = 0
        '
        'frmTandC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtTandC)
        Me.Name = "frmTandC"
        Me.Text = "Terms and Conditions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTandC As TextBox
End Class
