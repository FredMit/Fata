Public Class Form1

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim Name As String
        Name = InputBox("Enter your name;")
        MessageBox.Show("My name is ," & Name)
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
