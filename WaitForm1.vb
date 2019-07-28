Imports System.Threading

Public Class WaitForm1
    Sub New()
        InitializeComponent()
        Me.progressPanel1.AutoHeight = True
        For i As Integer = 1 To 10
            Thread.Sleep(1)
        Next
        Market.Show()
        Me.Hide()
    End Sub

    Public Overrides Sub SetCaption(ByVal caption As String)
        MyBase.SetCaption(caption)
        Me.progressPanel1.Caption = caption
    End Sub

    Public Overrides Sub SetDescription(ByVal description As String)
        MyBase.SetDescription(description)
        Me.progressPanel1.Description = description
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum WaitFormCommand
        SomeCommandId
    End Enum

    Private Sub tableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tableLayoutPanel1.Paint

    End Sub
End Class
