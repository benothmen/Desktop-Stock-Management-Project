
Imports System.Data.SqlClient

Public Class Form1
    Private id As String
    Private password As String
    Private idx As String
    Private passwordX As String
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        id = "MicrosoftVBDotNet"
        password = "AsULike2019"
        idx = BunifuTextBoxUserName.Text
        passwordX = BunifuTextBoxPassword.Text
        If id.Equals(idx) And password.Equals(passwordX) Then
            WaitForm1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Check your Username or password")
        End If
    End Sub
End Class
