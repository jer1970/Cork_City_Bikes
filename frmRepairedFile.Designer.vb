<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepairedFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepairedFile))
        Me.tlbRepaired = New System.Windows.Forms.ToolStrip()
        Me.btnsave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDone = New System.Windows.Forms.ToolStripButton()
        Me.txtRepaired = New System.Windows.Forms.TextBox()
        Me.lstRepairs = New System.Windows.Forms.ListBox()
        Me.tlbRepaired.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlbRepaired
        '
        Me.tlbRepaired.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnsave, Me.ToolStripSeparator1, Me.btnDone})
        Me.tlbRepaired.Location = New System.Drawing.Point(0, 0)
        Me.tlbRepaired.Name = "tlbRepaired"
        Me.tlbRepaired.Size = New System.Drawing.Size(284, 25)
        Me.tlbRepaired.TabIndex = 0
        Me.tlbRepaired.Text = "ToolStrip1"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(35, 22)
        Me.btnsave.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDone.Image = CType(resources.GetObject("btnDone.Image"), System.Drawing.Image)
        Me.btnDone.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(39, 22)
        Me.btnDone.Text = "Done"
        '
        'txtRepaired
        '
        Me.txtRepaired.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRepaired.Location = New System.Drawing.Point(0, 25)
        Me.txtRepaired.Multiline = True
        Me.txtRepaired.Name = "txtRepaired"
        Me.txtRepaired.Size = New System.Drawing.Size(284, 236)
        Me.txtRepaired.TabIndex = 1
        '
        'lstRepairs
        '
        Me.lstRepairs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lstRepairs.FormattingEnabled = True
        Me.lstRepairs.Location = New System.Drawing.Point(0, 192)
        Me.lstRepairs.Name = "lstRepairs"
        Me.lstRepairs.Size = New System.Drawing.Size(284, 69)
        Me.lstRepairs.TabIndex = 2
        '
        'frmRepairedFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lstRepairs)
        Me.Controls.Add(Me.txtRepaired)
        Me.Controls.Add(Me.tlbRepaired)
        Me.Name = "frmRepairedFile"
        Me.Text = "Repaired File"
        Me.tlbRepaired.ResumeLayout(False)
        Me.tlbRepaired.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlbRepaired As ToolStrip
    Friend WithEvents btnsave As ToolStripButton
    Friend WithEvents txtRepaired As TextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnDone As ToolStripButton
    Friend WithEvents lstRepairs As ListBox
End Class
