Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim therandom As New Random
        Timer1.Interval = therandom.Next(100, 1000)

        If ProgressBar1.Value = 100 Then
            Process.Start("Shope\Smart Shopee\bin\Debug\Smart Shopee.exe")
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Close()
        Else
            ProgressBar1.Value += therandom.Next(20, 20)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub


End Class
