Public Class Form1
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonCambiar_Click(sender As Object, e As EventArgs) Handles ButtonCambiar.Click
        If RadioButton6x4.Checked Then
            Width = 640
            Height = 480
            CenterToScreen()
        ElseIf RadioButton8x6.Checked Then
            Width = 800
            Height = 600
            CenterToScreen()
        ElseIf RadioButton10x7.Checked Then
            Width = 1024
            Height = 768
            CenterToScreen()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class
