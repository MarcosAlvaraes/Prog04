Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aux As String

        If TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            aux = (TextBox1.Text * TextBox2.Text * TextBox3.Text)
            TextBox4.Text = aux
        End If

    End Sub
End Class