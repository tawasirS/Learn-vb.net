Public Class Form1
    Dim themecolorcode(7) As String
    Dim nowtheme As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize the theme color codes
        themecolorcode(0) = "#DFFF00"
        themecolorcode(1) = "#FFBF00"
        themecolorcode(2) = "#FF7F50"
        themecolorcode(3) = "#DE3163"
        themecolorcode(4) = "#9FE2BF"
        themecolorcode(5) = "#40E0D0"
        themecolorcode(6) = "#6495ED"
        themecolorcode(7) = "#CCCCFF"

        ' Initialize the theme index
        nowtheme = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Change the background color of the form
        Panel1.BackColor = ColorTranslator.FromHtml(themecolorcode(nowtheme))
        Button1.BackColor = ColorTranslator.FromHtml(themecolorcode(nowtheme))

        ' Increment the theme index
        nowtheme = (nowtheme + 1) Mod themecolorcode.Length
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
        Label1.Text = "ทดลองเปลี่ยนธีม"
        Label2.Text = "ภาษา"
        Button1.Text = "กดเพื่อเปลี่ยนธีม"
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        End If
        Label1.Text = "try to change theme"
        Label2.Text = "language"
        Button1.Text = "click to change theme"
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
        End If
        Label1.Text = "テーマを変更してみる"
        Label2.Text = "言語"
        Button1.Text = "テーマを変更するには押してください"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox2.Checked = True
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        Label1.Text = "try to change theme"
        Label2.Text = "language"
        Button1.Text = "click to change theme"
        Panel1.BackColor = ColorTranslator.FromHtml(themecolorcode(0))
        Button1.BackColor = ColorTranslator.FromHtml(themecolorcode(0))
    End Sub
End Class
