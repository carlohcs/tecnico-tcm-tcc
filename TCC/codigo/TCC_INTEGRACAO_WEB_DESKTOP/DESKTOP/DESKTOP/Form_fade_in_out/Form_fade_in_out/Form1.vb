Public Class Form1

    Private Sub DataRepeater1_CurrentItemIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.Opacity = 1 Then
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Interval = 20 'Quantas vezes temporizador irá repetir o código (em milisegundos)
        Timer1.Enabled = True
        Timer2.Interval = 20
        Timer2.Enabled = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Opacity = 1 Then
            Timer1.Stop()
        Else
            Me.Opacity += 0.02
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Opacity = 0 Then
            Timer2.Stop()
            End  'fechar o aplicativo
        Else
            Me.Opacity -= 0.02 'Opacity irá diminuir com 0,02
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.Opacity = 1 Then
            Timer2.Enabled = True
        End If


    End Sub
End Class
