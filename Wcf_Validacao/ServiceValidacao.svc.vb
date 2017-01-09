' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTA: Você pode usar o comando "Renomear" no menu de contexto para alterar o nome da classe "Service1" no: arquivo de código, SVC e configuração juntos.

' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
' NOTA: A fim de lançar WCF cliente de teste para testar este serviço, por favor selecione Service1.svc ou Service1.svc.vb no Solution Explorer e iniciar a depuração.

'8 Expressões Regulares muito Úteis
'http://www.fzmaster.com/2009/01/26/8-expressoes-regulares-muito-uteis/
' http://jhonnymakis.com.br/blog/2010/10/15/8-expressoes-regulares-para-php-consideradas-uteis/

'WCF Test Client (WcfTestClient.exe)
'https://msdn.microsoft.com/en-us/library/bb552364(v=vs.110).aspx

'veja também:
'http://www.linhadecodigo.com.br/artigo/3362/expressoes-regulares-em-csharp-resolvendo-problemas-de-identificacao-de-textos.aspx

'REGULAR EXPRESSIONS
'https://regex101.com/

'EXTRA! Notação Húngara
'http://contembits.com.br/Minicursos/c-sharp/Notacao-Hungara.aspx

Public Class ServiceValidacao
    Implements IValidacao

    Public Sub New()
    End Sub

    Public Function ObterDados(ByVal valor As Integer) As String Implements IValidacao.ObterDados
        Return String.Format("Você Digitou: {0}", valor)
    End Function

    Public Function ObterDadosUsandoContratoDeDados(ByVal composicao As TipoComposto) As TipoComposto Implements IValidacao.ObterDadosUsandoContratoDeDados

        If composicao Is Nothing Then
            Throw New ArgumentNullException("composição")
        End If

        If composicao.ValorBoolean Then
            composicao.ValorString &= ", " & FormatDateTime(composicao.ValorDate, DateFormat.LongDate) & " às " & FormatDateTime(composicao.ValorDate, DateFormat.ShortTime)
        End If

        Return composicao
    End Function

#Region "Validação"

    ''' <summary>
    ''' Validar nomes de usuários
    ''' </summary>
    ''' <param name="nomeUsuario">Nome do Usuário</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Essa regra é para permitir usuários com nome de 3 a 30 caracteres, alfanuméricos e acentuados:
    ''' IMPORTANTE sobre Acentuação: 
    ''' http://aurelio.net/regex/guia/acentuacao.html
    ''' Teste a Expressão Regular aqui:
    ''' https://regex101.com/
    ''' </remarks>
    Public Function ValidarNomeUsuario(ByVal nomeUsuario As String) As Boolean Implements IValidacao.ValidarNomesUsuarios
        Dim validaUsuario As String = "^[A-Za-zÀ-ú0-9]{3,30}$"

        Return Regex.IsMatch(nomeUsuario, validaUsuario)
    End Function

    ''' <summary>
    ''' Validar números telefônicos
    ''' </summary>
    ''' <param name="numeroTelefonico">Número telefônico - Formato: "(99) 000-000-000":</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Essa regra é para validar números de telefone, e os números devem ser escritos da seguinte maneira (##) ###-###-###:
    ''' </remarks>
    Public Function ValidarNumerosTelefonicos(numeroTelefonico As String) As Boolean Implements IValidacao.ValidarNumerosTelefonicos
        Dim validaNumeroTelefonico As String = "(\(?[0-9]{2}\))[ ][0-9]{3,3}[-. ]?[0-9]{3,3}[-. ]?[0-9]{3,3}$"

        Return Regex.IsMatch(numeroTelefonico, validaNumeroTelefonico)
    End Function

    ''' <summary>
    ''' Validar email
    ''' </summary>
    ''' <param name="email">email</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' http://www.macoratti.net/09/09/net_wcf1.htm
    ''' A regra para validar e-mails é a seguinte:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    Public Function ValidarEmail(ByVal email As String) As Boolean Implements IValidacao.ValidarEmail
        Dim validaEmail As String = "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-z]{2,4}|[0-9]{1,3})(\]?)$"

        Return Regex.IsMatch(email, validaEmail)
    End Function

    ''' <summary>
    ''' Validar códigos postais
    ''' </summary>
    ''' <param name="codigoPostal">Código Postal</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Permite utilizar números no seguinte formato: xxxx-xxxx
    ''' http://www.buscacep.correios.com.br/servicos/dnec/menuAction.do?Metodo=menuEndereco
    ''' </remarks>
    Public Function ValidarCodigosPostais(codigoPostal As String) As Boolean Implements IValidacao.ValidarCodigosPostais
        Dim validaCodigoPostal As String = "^[0-9]{5,5}[-]?[0-9]{3,3}?$"

        Return Regex.IsMatch(codigoPostal, validaCodigoPostal)
    End Function

    ''' <summary>
    ''' Validar endereços IP
    ''' </summary>
    ''' <param name="EnderecoIP">Endereço IP</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Não é necessário efetuar PING ou qualquer coisa do tipo, essa regra é válida para verificar se os IPs foram escritos corretamente, como esse exemplo 255.255.255.0:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    Public Function ValidarEnderecosIP(EnderecoIP As String) As Boolean Implements IValidacao.ValidarEnderecosIP
        Dim validaEnderecoIP As String = "^(?:25[0-5]|2[0-4]\d|1\d\d|[1-9]\d|\d)(?:[.](?:25[0-5]|2[0-4]\d|1\d\d|[1-9]\d|\d)){3}$"

        Return Regex.IsMatch(EnderecoIP, validaEnderecoIP)
    End Function

    ''' <summary>
    ''' Validar cores hexadecimais
    ''' </summary>
    ''' <param name="corHexadecimal">Cor hexadecimal</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Você também pode verificar valores hexadecimais em suas 2 formas, a normal e a abreviada: (#333, 333, #333333 o 333333) com o símbolo # opcional:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    Public Function ValidarCoresHexadecimais(corHexadecimal As String) As Boolean Implements IValidacao.ValidarCoresHexadecimais
        Dim validaCorHexadecimal As String = "^#(?:(?:[a-fA-F\d]{3}){1,2})$"

        Return Regex.IsMatch(corHexadecimal, validaCorHexadecimal)
    End Function

    ''' <summary>
    ''' Validar comentários multi-linha
    ''' </summary>
    ''' <param name="comentarioMultiLinha">Comentário multi-linha</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Uma forma simples de buscar e eliminar comentários multi-linha em PHP, CSS e outras linguagens:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    Public Function ValidarComentariosMultiLinha(comentarioMultiLinha As String) As Boolean Implements IValidacao.ValidarComentariosMultiLinha
        Dim validaComentarioMultiLinha As String = "^[\/*]+[(*\/)]"

        Return Regex.IsMatch(comentarioMultiLinha, validaComentarioMultiLinha)
    End Function

    ''' <summary>
    ''' Validar datas
    ''' </summary>
    ''' <param name="data">Data</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Um formato de data típico MM/DD/YYYY e sua validação é a seguinte:
    ''' </remarks>
    Public Function ValidarDatas(data As String) As Boolean Implements IValidacao.ValidarDatas
        Dim validaData As String = "^\d{1,2}\/\d{1,2}\/\d{4}$"
        Dim strDia As String = Strings.Left(data, 2)
        Dim strMes As String = Strings.Mid(data, 4, 2)
        Dim strAno As String = Strings.Right(data, 4)
        Dim blnValidarDatas As Boolean

        blnValidarDatas = Regex.IsMatch(data, validaData)

        If blnValidarDatas Then

            Select Case strMes
                Case "00"
                    blnValidarDatas = False

                Case "01", "03", "05", "07", "08", "10", "12"
                    If strDia > 31 Then blnValidarDatas = False

                Case "04", "06", "09", "11"
                    If strDia > 30 Then blnValidarDatas = False

                Case "02"

                    If IsDate("29/02/" & strAno) = True Then
                        If strDia > 29 Then blnValidarDatas = False
                    Else
                        If strDia > 28 Then blnValidarDatas = False
                    End If

                Case Is > "12"
                    blnValidarDatas = False

            End Select

        End If

        Return blnValidarDatas

    End Function

#End Region

End Class