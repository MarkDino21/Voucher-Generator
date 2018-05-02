Public Class frmSetting
    Dim series As Integer
    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.cv = "RMMC" Then
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
            BackgroundImage = My.Resources.cash_voucher_rm
        ElseIf Form1.cv = "RDC" Then
            series = My.Settings.Series2 + 1
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
            BackgroundImage = My.Resources.cash_voucher_realty
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form1.cv = "RMMC" Then
            My.Settings.Series = Val(TextBox1.Text) - 1
            My.Settings.Save()
        ElseIf Form1.cv = "RDC" Then
            My.Settings.Series2 = Val(TextBox1.Text) - 1
            My.Settings.Save()
        End If
        Close()
    End Sub
End Class