' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
' NOTA: Você pode usar o comando "Renomear" no menu de contexto para alterar o nome da interface "IService1" em ambos arquivos: de código e de configuração juntamente.
<ServiceContract()>
Public Interface IValidacao

    <OperationContract()>
    Function ObterDados(ByVal valor As Integer) As String

    <OperationContract()>
    Function ObterDadosUsandoContratoDeDados(ByVal composicao As TipoComposto) As TipoComposto

#Region "Validação"

    ''' <summary>
    ''' Validar nomes de usuários
    ''' </summary>
    ''' <param name="nomeUsuario">Nome do Usuário</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Essa regra é para permitir usuários com nome de 4 a 28 caracteres, alfanuméricos e acentuados:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    <OperationContract()> _
    Function ValidarNomesUsuarios(ByVal nomeUsuario As String) As Boolean

    ''' <summary>
    ''' Validar números telefônicos
    ''' </summary>
    ''' <param name="numeroTelefonico">Número telefônico</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Essa regra é para validar números de telefone, e os números devem ser escritos da seguinte maneira (###)###-####:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    <OperationContract()> _
    Function ValidarNumerosTelefonicos(ByVal numeroTelefonico As String) As Boolean

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
    <OperationContract()> _
    Function ValidarEmail(ByVal email As String) As Boolean

    ''' <summary>
    ''' Validar códigos postais
    ''' </summary>
    ''' <param name="codigoPostal">Código Postal</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Permite utilizar números no seguinte formato: xxxxx e xxxxx-xxxx:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    <OperationContract()> _
    Function ValidarCodigosPostais(ByVal codigoPostal As String) As Boolean

    ''' <summary>
    ''' Validar endereços IP
    ''' </summary>
    ''' <param name="EnderecoIP">Endereço IP</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Não é necessário efetuar PING ou qualquer coisa do tipo, essa regra é válida para verificar se os IPs foram escritos corretamente, como esse exemplo 255.255.255.0:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    <OperationContract()> _
    Function ValidarEnderecosIP(ByVal EnderecoIP As String) As Boolean

    ''' <summary>
    ''' Validar cores hexadecimais
    ''' </summary>
    ''' <param name="corHexadecimal">Cor hexadecimal</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Você também pode verificar valores hexadecimais em suas 2 formas, a normal e a abreviada: (#333, 333, #333333 o 333333) com o símbolo # opcional:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    <OperationContract()> _
    Function ValidarCoresHexadecimais(ByVal corHexadecimal As String) As Boolean

    ''' <summary>
    ''' Validar comentários multi-linha
    ''' </summary>
    ''' <param name="comentarioMultiLinha">Comentário multi-linha</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Uma forma simples de buscar e eliminar comentários multi-linha em PHP, CSS e outras linguagens:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    <OperationContract()> _
    Function ValidarComentariosMultiLinha(ByVal comentarioMultiLinha As String) As Boolean

    ''' <summary>
    ''' Validar datas
    ''' </summary>
    ''' <param name="data">Data</param>
    ''' <returns>Verdadeiro ou Falso</returns>
    ''' <remarks>
    ''' Um formato de data típico MM/DD/YYYY e sua validação é a seguinte:
    ''' http://www.pinceladasdaweb.com.br/blog/2008/01/21/8-expressoes-regulares-para-php-consideradas-uteis/
    ''' </remarks>
    <OperationContract()> _
    Function ValidarDatas(ByVal data As String) As Boolean

#End Region

End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.
' Use um contrato de dados, como ilustrado no exemplo abaixo, para adicionar tipos de compostos para operações de serviços.

<DataContract()>
Public Class TipoComposto

    <DataMember()>
    Public Property ValorBoolean() As Boolean

    <DataMember()>
    Public Property ValorString() As String

    <DataMember()>
    Public Property ValorDate() As Date

End Class