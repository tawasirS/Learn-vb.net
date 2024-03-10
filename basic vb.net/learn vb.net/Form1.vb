Partial Class Form1
    Dim arraynum(4) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arraynum(0) = 10
        arraynum(1) = 3
        arraynum(2) = 9
        arraynum(3) = 11
        arraynum(4) = 20
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To 4
            MsgBox(arraynum(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        Dim show As String
        For i = 0 To 4
            show = show & arraynum(i) & vbNewLine
        Next
        MsgBox(show)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        Dim show As Integer
        show = 0
        For i = 0 To 4
            show = show + arraynum(i)
        Next
        MsgBox(show)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer
        Dim show As Integer
        show = 0
        For i = 0 To 4
            show = show + arraynum(i)
        Next
        MsgBox(show / 5)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer
        Dim show As String
        For i = 0 To 4
            If arraynum(i) > 10 Then
                show = show & arraynum(i) & vbNewLine
            End If
        Next
        MsgBox(show)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim i As Integer
        Dim max As Integer
        max = arraynum(0)
        For i = 0 To 4
            If arraynum(i) > max Then
                max = arraynum(i)
            End If
        Next
        MsgBox(max)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim i As Integer
        Dim min As Integer
        min = arraynum(0)
        For i = 0 To 4
            If arraynum(i) < min Then
                min = arraynum(i)
            End If
        Next
        MsgBox(min)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim i As Integer
        Dim show As String
        For i = 0 To 4
            arraynum(i) = 2 * arraynum(i)
        Next
        For i = 0 To 4
            show = show & arraynum(i) & vbNewLine
        Next
        MsgBox(show)
    End Sub
End Class
