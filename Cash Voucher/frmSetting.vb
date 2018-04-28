Public Class frmSetting
    Dim series As Integer
    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        series = My.Settings.Series + 1
        If My.Settings.Series >= 1000 Then
            TextBox1.Text = "0000" & series
        ElseIf My.Settings.Series >= 10000 Then
            TextBox1.Text = "000" & series
        ElseIf My.Settings.Series >= 100000 Then
            TextBox1.Text = "00" & series
        ElseIf My.Settings.Series >= 100000 Then
            TextBox1.Text = "0" & series
        ElseIf My.Settings.Series >= 100000 Then
            TextBox1.Text = series

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Series = Val(TextBox1.Text) - 1
        My.Settings.Save()
        Me.Close()
    End Sub
End Class