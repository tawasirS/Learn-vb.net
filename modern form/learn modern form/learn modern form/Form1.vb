Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colors As Array = [Enum].GetValues(GetType(KnownColor))

        For Each KC As KnownColor In colors
            Dim curColor As Color = Color.FromKnownColor(KC)

            If curColor.IsSystemColor Then
                ComboBox1.Items.Add(curColor.Name.ToString())
            ElseIf curcolor.IsKnownColor Then
                If curColor.Name.ToString() <> "Transparent" Then
                    ComboBox2.Items.Add(curColor.Name.ToString())
                End If
            End If
        Next

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim c As Color = Color.FromName(ComboBox1.SelectedItem.ToString())
        TextBox1.ForeColor = c
        Label1.ForeColor = c
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim c As Color = Color.FromName(ComboBox2.SelectedItem.ToString())
        TextBox2.ForeColor = c
        Label2.ForeColor = c
    End Sub
End Class
