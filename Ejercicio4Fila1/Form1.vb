Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.MaxLength = 10

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsSymbol(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar <> " - " Then



            e.Handled = True



            Exit Sub

        End If


        Dim pos As Integer = TextBox1.SelectionStart





        If pos = 2 And e.KeyChar <> " - " Or e.KeyChar <> "/" Or e.KeyChar <> "." Or e.KeyChar <> "," Then


            e.Handled = True

            Exit Sub

        End If

        If e.KeyChar = " - " Or e.KeyChar = " / " And pos <> 2 Or pos <> 6 Then

            e.Handled = True
            Exit Sub

        End If

    End Sub

End Class
