Partial Public Class Form1
    Inherits Form
    Private i As Integer = 0 'variavel contadora
    Public Sub New()
        InitializeComponent()

        Dim tempo As New Timer() 'declaracao do controle que controla o tempo
        tempo.Interval = 1000 'tempo em milisegundos
        tempo.Enabled = True 'habilita o controle
        '   AddHandler tempo.Tick, AddressOf tempo_Tick  'adiciona o evento
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' pctImagem1.Load("artigos2.png")

        'ZeraTudo() 'carrega tudo no form e depois oculta
    End Sub
    '  Private Sub tempo_Tick(ByVal sender As Object, ByVal e As EventArgs)
    'i += 1 'incrementa variavel
    '   Select Case i
    '  Case (1)
    '        pctImagem0.Visible = True 'a cada segundo que passa habilita 1 deles
    '   Exit Select
    '  Case (2)
    '        pctImagem1.Visible = True
    '   Exit Select
    '  Case (3)
    ' ZeraTudo()
    '  Exit Select
    ' End Select
    'End Sub
    ' Private Sub ZeraTudo() 'zera a variavel contadora e oculta todas imagens
    '   i = 0
    ''   pctImagem0.Visible = False
    'pctImagem1.Visible = False
    ' End' Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        If MsgBox("Deseja mesmo sair?", MsgBoxStyle.YesNo, "Atenção") = vbYes Then


        End If

    End Sub
End Class