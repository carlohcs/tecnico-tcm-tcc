Public Class frmLogin
    'Função para  deixar cantos do formulário arredondados
    Private Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer


    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'EFEITO FADE IN E OUT
        Me.Opacity = 0
        Timer1.Interval = 20 'Quantas vezes temporizador irá repetir o código (em milisegundos)
        Timer1.Enabled = True
        Timer2.Interval = 20
        Timer2.Enabled = False


        'Deixar os cantos do formulário arredondados
        Dim regionHandle As IntPtr = New IntPtr(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 20, 20))

        Me.Region = Region.FromHrgn(regionHandle)
        Region.ReleaseHrgn(regionHandle)
        Me.FormBorderStyle = FormBorderStyle.None
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.Opacity = 1 Then
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MDIPrincipal.Show()

    End Sub
End Class
