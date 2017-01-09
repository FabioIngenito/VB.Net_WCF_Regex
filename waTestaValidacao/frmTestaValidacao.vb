''' <summary>
''' O waTestaValidacao é uma 'Windows Application' para validar o funcionamento de um WCF - Windows Comunication Foundation
''' </summary>
''' <remarks>
''' Baseado nos sites:
''' - Macoratti - WCF - Windows Comunication Foundation - Introdução
''' http://www.macoratti.net/09/09/net_wcf1.htm
''' - Pinceladas na Web - 8 Expressões Regulares para PHP consideradas úteis
''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
''' - Informação útil:
''' http://aurelio.net/regex/guia/acentuacao.html
''' - TESTAR EXPRESSÃO REGULAR
''' https://regex101.com/
''' </remarks>
Public Class frmTestaValidacao
    ' criando uma instância do nosso serviço WCF
    Dim WCF_Valida As New ServiceReference1.ValidacaoClient()
    Dim WCF_Valida_Dados As New ServiceReference1.TipoComposto()

    ' ''' <summary>
    ' ''' Essa regra é para permitir usuários com nome de 3 a 30 caracteres, alfanuméricos e acentuados
    ' ''' </summary>
    ' ''' <param name="sender"></param>
    ' ''' <param name="e"></param>
    ' ''' <remarks>
    ' ''' É possível testar em: https://regex101.com/
    ' ''' IMPORTANTE - Veja isso também: http://aurelio.net/regex/guia/acentuacao.html
    ' ''' </remarks>
    Private Sub btnValidarNomeUsuario_Click(sender As Object, e As EventArgs) Handles btnValidarNomeUsuario.Click

        'usando o método ValidarNomeUsuario do nosso serviço
        If WCF_Valida.ValidarNomesUsuarios(txtNomeUsuario.Text) Then
            MessageBox.Show("Nome do Usuário Válido.")
        Else
            MessageBox.Show("Nome do Usuário Inválido")
        End If

    End Sub

    Private Sub btnValidarNumeroTelefonico_Click(sender As Object, e As EventArgs) Handles btnValidarNumeroTelefonico.Click

        'usando o método ValidarNumerosTelefonicos do nosso serviço
        If WCF_Valida.ValidarNumerosTelefonicos(mskNumeroTelefonico.Text) Then
            MessageBox.Show("Número telefônico Válido.")
        Else
            MessageBox.Show("Número telefônico Inválido")
        End If

    End Sub

    Private Sub btnValidarEmail_Click(sender As Object, e As EventArgs) Handles btnValidarEmail.Click

        'usando o método ValidarEmail do nosso serviço
        If WCF_Valida.ValidarEmail(txtEmail.Text) Then
            MessageBox.Show("Email Válido.")
        Else
            MessageBox.Show("Email Inválido")
        End If

    End Sub

    Private Sub btnValidarCodigoPostal_Click(sender As Object, e As EventArgs) Handles btnValidarCodigoPostal.Click

        'usando o método ValidarCodigosPostais do nosso serviço
        If WCF_Valida.ValidarCodigosPostais(mskCodigoPostal.Text) Then
            MessageBox.Show("Código Postal Válido.")
        Else
            MessageBox.Show("Código Postal Inválido")
        End If

    End Sub

    Private Sub btnValidarEnderecoIP_Click(sender As Object, e As EventArgs) Handles btnValidarEnderecoIP.Click

        'usando o método ValidarEnderecosIP do nosso serviço
        If WCF_Valida.ValidarEnderecosIP(txtEnderecoIP.Text) Then
            MessageBox.Show("Endereco IP Válido.")
        Else
            MessageBox.Show("Endereco IP Inválido")
        End If

    End Sub

    Private Sub btnValidarCorHexadecimal_Click(sender As Object, e As EventArgs) Handles btnValidarCorHexadecimal.Click

        'usando o método ValidarCoresHexadecimais do nosso serviço
        If WCF_Valida.ValidarCoresHexadecimais(mskCorHexadecimal.Text) Then
            MessageBox.Show("Cor Hexadecimal Válido.")
        Else
            MessageBox.Show("Cor Hexadecimal Inválido")
        End If

    End Sub

    Private Sub btnValidarComentarioMultiLinha_Click(sender As Object, e As EventArgs) Handles btnValidarComentarioMultiLinha.Click

        'usando o método ValidarComentariosMultiLinha do nosso serviço
        If WCF_Valida.ValidarComentariosMultiLinha(txtComentarioMultiLinha.Text) Then
            MessageBox.Show("Comentário Válido.")
        Else
            MessageBox.Show("Comentário Inválido")
        End If

    End Sub

    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click

        'usando o método ValidarDatas do nosso serviço
        If WCF_Valida.ValidarDatas(mskData.Text) Then
            MessageBox.Show("Data Válida.")
        Else
            MessageBox.Show("Data Inválida")
        End If

    End Sub

    Private Sub frmTestaValidacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' Digitar somente números
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtVoceDigitou_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr("0123456789", e.KeyChar) = 0 And Not Convert.ToInt32(e.KeyChar) = Keys.Back Then e.Handled = True
    End Sub

    Private Sub btnVoceDigitou_Click(sender As Object, e As EventArgs) Handles btnVoceDigitou.Click

        'usando o método ObterDados do nosso serviço
        MessageBox.Show(WCF_Valida.ObterDados(txtVoceDigitou.Text))

    End Sub

    Private Sub btnContratoDeDados_Click(sender As Object, e As EventArgs) Handles btnContratoDeDados.Click

        WCF_Valida_Dados.ValorString = txtContratoDeDados.Text
        WCF_Valida_Dados.ValorBoolean = chkContratoDeDados.Checked
        WCF_Valida_Dados.ValorDate = dtpContratoDeDados.Value

        WCF_Valida_Dados = WCF_Valida.ObterDadosUsandoContratoDeDados(WCF_Valida_Dados)

        lblContratoDeDadosResposta.Text = WCF_Valida_Dados.ValorString
    End Sub
End Class