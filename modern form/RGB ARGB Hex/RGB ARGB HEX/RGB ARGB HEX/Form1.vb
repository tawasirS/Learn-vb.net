Option Explicit On
Option Strict On

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetColor1()
        SetColor2() ' Uncomment if you want to use SetColor2
    End Sub

    Private Sub SetColor1()
        Dim colorCode As String = TextBox1.Text.Trim()

        Try
            Dim c As Color = ColorTranslator.FromHtml(colorCode)
            Panel1.BackColor = c
        Catch ex As Exception
            MessageBox.Show("Invalid color code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetColor2()
        Dim colorCode As String = TextBox1.Text.Trim()
        Dim alpha As Byte

        Dim c As Color = Color.FromArgb(alpha, colorCode(0), colorCode(1), colorCode(2))
        Panel3.BackColor = c
    End Sub
End Class
