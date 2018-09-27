Imports System.IO
Public Class frmTandC
    Private Sub frmTandC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using tAndc As StreamReader = New StreamReader("..\..\Resources\TermsAndConditions.txt")
            While Not tAndc.EndOfStream
                txtTandC.Text = tAndc.ReadToEnd
            End While
            tAndc.Close()
        End Using
    End Sub
End Class