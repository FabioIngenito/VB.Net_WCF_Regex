<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestaValidacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tipTestaValidacao = New System.Windows.Forms.ToolTip(Me.components)
        Me.mskCorHexadecimal = New System.Windows.Forms.MaskedTextBox()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.mskCodigoPostal = New System.Windows.Forms.MaskedTextBox()
        Me.btnData = New System.Windows.Forms.Button()
        Me.lblData = New System.Windows.Forms.Label()
        Me.btnValidarComentarioMultiLinha = New System.Windows.Forms.Button()
        Me.txtComentarioMultiLinha = New System.Windows.Forms.TextBox()
        Me.lblComentarioMultiLinha = New System.Windows.Forms.Label()
        Me.btnValidarCorHexadecimal = New System.Windows.Forms.Button()
        Me.lblCorHexadecimal = New System.Windows.Forms.Label()
        Me.btnValidarEnderecoIP = New System.Windows.Forms.Button()
        Me.txtEnderecoIP = New System.Windows.Forms.TextBox()
        Me.lblEnderecoIP = New System.Windows.Forms.Label()
        Me.btnValidarCodigoPostal = New System.Windows.Forms.Button()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.mskNumeroTelefonico = New System.Windows.Forms.MaskedTextBox()
        Me.btnValidarNumeroTelefonico = New System.Windows.Forms.Button()
        Me.lblNumeroTelefonico = New System.Windows.Forms.Label()
        Me.btnValidarNomeUsuario = New System.Windows.Forms.Button()
        Me.txtNomeUsuario = New System.Windows.Forms.TextBox()
        Me.lblNomeUsuario = New System.Windows.Forms.Label()
        Me.btnValidarEmail = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnContratoDeDados = New System.Windows.Forms.Button()
        Me.txtContratoDeDados = New System.Windows.Forms.TextBox()
        Me.lblContratoDeDados = New System.Windows.Forms.Label()
        Me.btnVoceDigitou = New System.Windows.Forms.Button()
        Me.txtVoceDigitou = New System.Windows.Forms.TextBox()
        Me.lblVoceDigitou = New System.Windows.Forms.Label()
        Me.lblContratoDeDadosResposta = New System.Windows.Forms.Label()
        Me.tbcValidacao = New System.Windows.Forms.TabControl()
        Me.tbpValidacao = New System.Windows.Forms.TabPage()
        Me.tbpOutros = New System.Windows.Forms.TabPage()
        Me.lblResposta = New System.Windows.Forms.Label()
        Me.dtpContratoDeDados = New System.Windows.Forms.DateTimePicker()
        Me.chkContratoDeDados = New System.Windows.Forms.CheckBox()
        Me.tbcValidacao.SuspendLayout()
        Me.tbpValidacao.SuspendLayout()
        Me.tbpOutros.SuspendLayout()
        Me.SuspendLayout()
        '
        'tipTestaValidacao
        '
        Me.tipTestaValidacao.Tag = "http://contembits.com.br/Minicursos/c-sharp/Notacao-Hungara.aspx"
        '
        'mskCorHexadecimal
        '
        Me.mskCorHexadecimal.Location = New System.Drawing.Point(276, 101)
        Me.mskCorHexadecimal.Mask = "\#AAAAAA"
        Me.mskCorHexadecimal.Name = "mskCorHexadecimal"
        Me.mskCorHexadecimal.Size = New System.Drawing.Size(241, 20)
        Me.mskCorHexadecimal.TabIndex = 54
        Me.mskCorHexadecimal.Text = "0000FF"
        Me.tipTestaValidacao.SetToolTip(Me.mskCorHexadecimal, "Um formato de data típico MM/DD/YYYY e sua validação é a seguinte:")
        '
        'mskData
        '
        Me.mskData.Location = New System.Drawing.Point(276, 257)
        Me.mskData.Mask = "00/00/0000"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(241, 20)
        Me.mskData.TabIndex = 53
        Me.mskData.Text = "31122025"
        Me.tipTestaValidacao.SetToolTip(Me.mskData, "Um formato de data típico MM/DD/YYYY e sua validação é a seguinte:")
        Me.mskData.ValidatingType = GetType(Date)
        '
        'mskCodigoPostal
        '
        Me.mskCodigoPostal.Location = New System.Drawing.Point(9, 257)
        Me.mskCodigoPostal.Mask = "00000-000"
        Me.mskCodigoPostal.Name = "mskCodigoPostal"
        Me.mskCodigoPostal.Size = New System.Drawing.Size(241, 20)
        Me.mskCodigoPostal.TabIndex = 52
        Me.mskCodigoPostal.Text = "05005000"
        Me.tipTestaValidacao.SetToolTip(Me.mskCodigoPostal, "Informe o código postal:")
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(276, 283)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(241, 23)
        Me.btnData.TabIndex = 51
        Me.btnData.Text = "Validar &Data"
        Me.tipTestaValidacao.SetToolTip(Me.btnData, "Um formato de data típico MM/DD/YYYY e sua validação é a seguinte:")
        Me.btnData.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(273, 241)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(147, 13)
        Me.lblData.TabIndex = 50
        Me.lblData.Text = "Informe a data (dd/MM/yyyy):"
        Me.tipTestaValidacao.SetToolTip(Me.lblData, "Um formato de data típico MM/DD/YYYY e sua validação é a seguinte:")
        '
        'btnValidarComentarioMultiLinha
        '
        Me.btnValidarComentarioMultiLinha.Location = New System.Drawing.Point(276, 206)
        Me.btnValidarComentarioMultiLinha.Name = "btnValidarComentarioMultiLinha"
        Me.btnValidarComentarioMultiLinha.Size = New System.Drawing.Size(241, 23)
        Me.btnValidarComentarioMultiLinha.TabIndex = 49
        Me.btnValidarComentarioMultiLinha.Text = "Validar comentário &multi-linha"
        Me.tipTestaValidacao.SetToolTip(Me.btnValidarComentarioMultiLinha, "Uma forma simples de buscar e eliminar comentários multi-linha em PHP, CSS e outr" &
        "as linguagens:")
        Me.btnValidarComentarioMultiLinha.UseVisualStyleBackColor = True
        '
        'txtComentarioMultiLinha
        '
        Me.txtComentarioMultiLinha.Location = New System.Drawing.Point(276, 180)
        Me.txtComentarioMultiLinha.Multiline = True
        Me.txtComentarioMultiLinha.Name = "txtComentarioMultiLinha"
        Me.txtComentarioMultiLinha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarioMultiLinha.Size = New System.Drawing.Size(241, 20)
        Me.txtComentarioMultiLinha.TabIndex = 48
        Me.txtComentarioMultiLinha.Text = "*/ TESTE1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TESTE2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TESTE3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TESTE4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TESTE5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*/"
        Me.tipTestaValidacao.SetToolTip(Me.txtComentarioMultiLinha, "Uma forma simples de buscar e eliminar comentários multi-linha em PHP, CSS e outr" &
        "as linguagens:")
        '
        'lblComentarioMultiLinha
        '
        Me.lblComentarioMultiLinha.AutoSize = True
        Me.lblComentarioMultiLinha.Location = New System.Drawing.Point(273, 164)
        Me.lblComentarioMultiLinha.Name = "lblComentarioMultiLinha"
        Me.lblComentarioMultiLinha.Size = New System.Drawing.Size(188, 13)
        Me.lblComentarioMultiLinha.TabIndex = 47
        Me.lblComentarioMultiLinha.Text = "Informe o comentário multi-linha (/* */):"
        Me.tipTestaValidacao.SetToolTip(Me.lblComentarioMultiLinha, "Uma forma simples de buscar e eliminar comentários multi-linha em PHP, CSS e outr" &
        "as linguagens:")
        '
        'btnValidarCorHexadecimal
        '
        Me.btnValidarCorHexadecimal.Location = New System.Drawing.Point(276, 127)
        Me.btnValidarCorHexadecimal.Name = "btnValidarCorHexadecimal"
        Me.btnValidarCorHexadecimal.Size = New System.Drawing.Size(241, 23)
        Me.btnValidarCorHexadecimal.TabIndex = 46
        Me.btnValidarCorHexadecimal.Text = "Validar &Cor Hexadecimal"
        Me.tipTestaValidacao.SetToolTip(Me.btnValidarCorHexadecimal, "Você também pode verificar valores hexadecimais em suas 2 formas, a normal e a ab" &
        "reviada: (#333, 333, #333333 o 333333) com o símbolo # opcional")
        Me.btnValidarCorHexadecimal.UseVisualStyleBackColor = True
        '
        'lblCorHexadecimal
        '
        Me.lblCorHexadecimal.AutoSize = True
        Me.lblCorHexadecimal.Location = New System.Drawing.Point(273, 85)
        Me.lblCorHexadecimal.Name = "lblCorHexadecimal"
        Me.lblCorHexadecimal.Size = New System.Drawing.Size(186, 13)
        Me.lblCorHexadecimal.TabIndex = 45
        Me.lblCorHexadecimal.Text = "Informe a cor hexadecimal (#000000):"
        Me.tipTestaValidacao.SetToolTip(Me.lblCorHexadecimal, "Você também pode verificar valores hexadecimais em suas 2 formas, a normal e a ab" &
        "reviada: (#333, 333, #333333 o 333333) com o símbolo # opcional")
        '
        'btnValidarEnderecoIP
        '
        Me.btnValidarEnderecoIP.Location = New System.Drawing.Point(276, 51)
        Me.btnValidarEnderecoIP.Name = "btnValidarEnderecoIP"
        Me.btnValidarEnderecoIP.Size = New System.Drawing.Size(241, 23)
        Me.btnValidarEnderecoIP.TabIndex = 44
        Me.btnValidarEnderecoIP.Text = "Validar Endereço &IP"
        Me.tipTestaValidacao.SetToolTip(Me.btnValidarEnderecoIP, "Não é necessário efetuar PING ou qualquer coisa do tipo, essa regra é válida para" &
        " verificar se os IPs foram escritos corretamente, como esse exemplo 255.255.255." &
        "0:")
        Me.btnValidarEnderecoIP.UseVisualStyleBackColor = True
        '
        'txtEnderecoIP
        '
        Me.txtEnderecoIP.Location = New System.Drawing.Point(276, 25)
        Me.txtEnderecoIP.Name = "txtEnderecoIP"
        Me.txtEnderecoIP.Size = New System.Drawing.Size(241, 20)
        Me.txtEnderecoIP.TabIndex = 43
        Me.txtEnderecoIP.Text = "128.0.0.1"
        Me.tipTestaValidacao.SetToolTip(Me.txtEnderecoIP, "Não é necessário efetuar PING ou qualquer coisa do tipo, essa regra é válida para" &
        " verificar se os IPs foram escritos corretamente, como esse exemplo 255.255.255." &
        "0:")
        '
        'lblEnderecoIP
        '
        Me.lblEnderecoIP.AutoSize = True
        Me.lblEnderecoIP.Location = New System.Drawing.Point(273, 9)
        Me.lblEnderecoIP.Name = "lblEnderecoIP"
        Me.lblEnderecoIP.Size = New System.Drawing.Size(205, 13)
        Me.lblEnderecoIP.TabIndex = 42
        Me.lblEnderecoIP.Text = "Informe o endereço IP (000.000.000.000):"
        Me.tipTestaValidacao.SetToolTip(Me.lblEnderecoIP, "Não é necessário efetuar PING ou qualquer coisa do tipo, essa regra é válida para" &
        " verificar se os IPs foram escritos corretamente, como esse exemplo 255.255.255." &
        "0:")
        '
        'btnValidarCodigoPostal
        '
        Me.btnValidarCodigoPostal.Location = New System.Drawing.Point(9, 283)
        Me.btnValidarCodigoPostal.Name = "btnValidarCodigoPostal"
        Me.btnValidarCodigoPostal.Size = New System.Drawing.Size(241, 23)
        Me.btnValidarCodigoPostal.TabIndex = 41
        Me.btnValidarCodigoPostal.Text = "Validar Código &Postal"
        Me.tipTestaValidacao.SetToolTip(Me.btnValidarCodigoPostal, "Permie utilizar números no seguinte formato: xxxxx e xxxxx-xxxx")
        Me.btnValidarCodigoPostal.UseVisualStyleBackColor = True
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Location = New System.Drawing.Point(6, 241)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(184, 13)
        Me.lblCodigoPostal.TabIndex = 40
        Me.lblCodigoPostal.Text = "Informe o código postal ""00000-000"":"
        Me.tipTestaValidacao.SetToolTip(Me.lblCodigoPostal, "Permie utilizar números no seguinte formato: xxxxx e xxxxx-xxxx")
        '
        'mskNumeroTelefonico
        '
        Me.mskNumeroTelefonico.Location = New System.Drawing.Point(9, 101)
        Me.mskNumeroTelefonico.Mask = "(99) 000-000-000"
        Me.mskNumeroTelefonico.Name = "mskNumeroTelefonico"
        Me.mskNumeroTelefonico.Size = New System.Drawing.Size(241, 20)
        Me.mskNumeroTelefonico.TabIndex = 39
        Me.mskNumeroTelefonico.Text = "11123456789"
        Me.tipTestaValidacao.SetToolTip(Me.mskNumeroTelefonico, "Essa regra é para validar números de telefone, e os números devem ser escritos da" &
        " seguinte maneira (##) ###-###-###:")
        '
        'btnValidarNumeroTelefonico
        '
        Me.btnValidarNumeroTelefonico.Location = New System.Drawing.Point(9, 127)
        Me.btnValidarNumeroTelefonico.Name = "btnValidarNumeroTelefonico"
        Me.btnValidarNumeroTelefonico.Size = New System.Drawing.Size(241, 23)
        Me.btnValidarNumeroTelefonico.TabIndex = 38
        Me.btnValidarNumeroTelefonico.Text = "Validar Numero &Telefônico"
        Me.tipTestaValidacao.SetToolTip(Me.btnValidarNumeroTelefonico, "Essa regra é para validar números de telefone, e os números devem ser escritos da" &
        " seguinte maneira (##) ###-###-###:")
        Me.btnValidarNumeroTelefonico.UseVisualStyleBackColor = True
        '
        'lblNumeroTelefonico
        '
        Me.lblNumeroTelefonico.AutoSize = True
        Me.lblNumeroTelefonico.Location = New System.Drawing.Point(6, 85)
        Me.lblNumeroTelefonico.Name = "lblNumeroTelefonico"
        Me.lblNumeroTelefonico.Size = New System.Drawing.Size(189, 13)
        Me.lblNumeroTelefonico.TabIndex = 37
        Me.lblNumeroTelefonico.Text = "Informe o telefone ""(99) 000-000-000"":"
        Me.tipTestaValidacao.SetToolTip(Me.lblNumeroTelefonico, "Essa regra é paravalidar números de telefone, e os números devem ser escritos da " &
        "seguinte maneira (##) ###-###-###:")
        '
        'btnValidarNomeUsuario
        '
        Me.btnValidarNomeUsuario.Location = New System.Drawing.Point(9, 51)
        Me.btnValidarNomeUsuario.Name = "btnValidarNomeUsuario"
        Me.btnValidarNomeUsuario.Size = New System.Drawing.Size(241, 23)
        Me.btnValidarNomeUsuario.TabIndex = 36
        Me.btnValidarNomeUsuario.Text = "Validar Nome do &Usuário"
        Me.tipTestaValidacao.SetToolTip(Me.btnValidarNomeUsuario, "Essa regra é para permitir usuários com nome de 3 a 30 caracteres, alfanuméricos " &
        "e acentuados:")
        Me.btnValidarNomeUsuario.UseVisualStyleBackColor = True
        '
        'txtNomeUsuario
        '
        Me.txtNomeUsuario.Location = New System.Drawing.Point(9, 25)
        Me.txtNomeUsuario.Name = "txtNomeUsuario"
        Me.txtNomeUsuario.Size = New System.Drawing.Size(241, 20)
        Me.txtNomeUsuario.TabIndex = 35
        Me.txtNomeUsuario.Text = "1T2eSTE3Ã0Oé10"
        Me.tipTestaValidacao.SetToolTip(Me.txtNomeUsuario, "Essa regra é para permitir usuários com nome de 3 a 30 caracteres, alfanuméricos " &
        "e acentuados:")
        '
        'lblNomeUsuario
        '
        Me.lblNomeUsuario.AutoSize = True
        Me.lblNomeUsuario.Location = New System.Drawing.Point(6, 9)
        Me.lblNomeUsuario.Name = "lblNomeUsuario"
        Me.lblNomeUsuario.Size = New System.Drawing.Size(174, 13)
        Me.lblNomeUsuario.TabIndex = 34
        Me.lblNomeUsuario.Text = "Informe o nome do usuário (3 a 30):"
        Me.tipTestaValidacao.SetToolTip(Me.lblNomeUsuario, "Essa regra é para permitir usuários com nome de 3 a 30 caracteres, alfanuméricos " &
        "e acentuados:")
        '
        'btnValidarEmail
        '
        Me.btnValidarEmail.Location = New System.Drawing.Point(9, 206)
        Me.btnValidarEmail.Name = "btnValidarEmail"
        Me.btnValidarEmail.Size = New System.Drawing.Size(241, 23)
        Me.btnValidarEmail.TabIndex = 33
        Me.btnValidarEmail.Text = "Validar &Email"
        Me.tipTestaValidacao.SetToolTip(Me.btnValidarEmail, "A regra para validar e-mails é a seguinte:")
        Me.btnValidarEmail.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(9, 180)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(241, 20)
        Me.txtEmail.TabIndex = 32
        Me.txtEmail.Text = "teste@teste.com.br"
        Me.tipTestaValidacao.SetToolTip(Me.txtEmail, "A regra para validar e-mails é a seguinte:")
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 164)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(81, 13)
        Me.lblEmail.TabIndex = 31
        Me.lblEmail.Text = "Informe o email:"
        Me.tipTestaValidacao.SetToolTip(Me.lblEmail, "A regra para validar e-mails é a seguinte:")
        '
        'btnContratoDeDados
        '
        Me.btnContratoDeDados.Location = New System.Drawing.Point(9, 219)
        Me.btnContratoDeDados.Name = "btnContratoDeDados"
        Me.btnContratoDeDados.Size = New System.Drawing.Size(241, 23)
        Me.btnContratoDeDados.TabIndex = 42
        Me.btnContratoDeDados.Text = "M&ostra o Uso do Contrato de Dados"
        Me.tipTestaValidacao.SetToolTip(Me.btnContratoDeDados, "Mostra o que foi digitado...")
        Me.btnContratoDeDados.UseVisualStyleBackColor = True
        '
        'txtContratoDeDados
        '
        Me.txtContratoDeDados.Location = New System.Drawing.Point(9, 144)
        Me.txtContratoDeDados.MaxLength = 3
        Me.txtContratoDeDados.Name = "txtContratoDeDados"
        Me.txtContratoDeDados.Size = New System.Drawing.Size(241, 20)
        Me.txtContratoDeDados.TabIndex = 41
        Me.txtContratoDeDados.Text = "São Paulo"
        Me.tipTestaValidacao.SetToolTip(Me.txtContratoDeDados, "Mostra o que foi digitado...")
        '
        'lblContratoDeDados
        '
        Me.lblContratoDeDados.AutoSize = True
        Me.lblContratoDeDados.Location = New System.Drawing.Point(6, 128)
        Me.lblContratoDeDados.Name = "lblContratoDeDados"
        Me.lblContratoDeDados.Size = New System.Drawing.Size(114, 13)
        Me.lblContratoDeDados.TabIndex = 40
        Me.lblContratoDeDados.Text = "Digite um texto abaixo:"
        Me.tipTestaValidacao.SetToolTip(Me.lblContratoDeDados, "Mostra o que foi digitado...")
        '
        'btnVoceDigitou
        '
        Me.btnVoceDigitou.Location = New System.Drawing.Point(9, 51)
        Me.btnVoceDigitou.Name = "btnVoceDigitou"
        Me.btnVoceDigitou.Size = New System.Drawing.Size(241, 23)
        Me.btnVoceDigitou.TabIndex = 39
        Me.btnVoceDigitou.Text = "Mostra o que digitou &acima usando o WCF"
        Me.tipTestaValidacao.SetToolTip(Me.btnVoceDigitou, "Mostra o que foi digitado...")
        Me.btnVoceDigitou.UseVisualStyleBackColor = True
        '
        'txtVoceDigitou
        '
        Me.txtVoceDigitou.Location = New System.Drawing.Point(9, 25)
        Me.txtVoceDigitou.MaxLength = 3
        Me.txtVoceDigitou.Name = "txtVoceDigitou"
        Me.txtVoceDigitou.Size = New System.Drawing.Size(241, 20)
        Me.txtVoceDigitou.TabIndex = 38
        Me.txtVoceDigitou.Text = "2"
        Me.tipTestaValidacao.SetToolTip(Me.txtVoceDigitou, "Mostra o que foi digitado...")
        '
        'lblVoceDigitou
        '
        Me.lblVoceDigitou.AutoSize = True
        Me.lblVoceDigitou.Location = New System.Drawing.Point(6, 9)
        Me.lblVoceDigitou.Name = "lblVoceDigitou"
        Me.lblVoceDigitou.Size = New System.Drawing.Size(77, 13)
        Me.lblVoceDigitou.TabIndex = 37
        Me.lblVoceDigitou.Text = "Você Digitou..."
        Me.tipTestaValidacao.SetToolTip(Me.lblVoceDigitou, "Mostra o que foi digitado...")
        '
        'lblContratoDeDadosResposta
        '
        Me.lblContratoDeDadosResposta.BackColor = System.Drawing.SystemColors.Window
        Me.lblContratoDeDadosResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblContratoDeDadosResposta.Location = New System.Drawing.Point(6, 250)
        Me.lblContratoDeDadosResposta.Name = "lblContratoDeDadosResposta"
        Me.lblContratoDeDadosResposta.Size = New System.Drawing.Size(519, 47)
        Me.lblContratoDeDadosResposta.TabIndex = 45
        Me.lblContratoDeDadosResposta.Text = "RESPOSTA DO CONTRATO DE DADOS"
        Me.lblContratoDeDadosResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipTestaValidacao.SetToolTip(Me.lblContratoDeDadosResposta, "Mostra o que foi digitado...")
        '
        'tbcValidacao
        '
        Me.tbcValidacao.Controls.Add(Me.tbpValidacao)
        Me.tbcValidacao.Controls.Add(Me.tbpOutros)
        Me.tbcValidacao.Location = New System.Drawing.Point(12, 12)
        Me.tbcValidacao.Name = "tbcValidacao"
        Me.tbcValidacao.SelectedIndex = 0
        Me.tbcValidacao.Size = New System.Drawing.Size(539, 340)
        Me.tbcValidacao.TabIndex = 37
        '
        'tbpValidacao
        '
        Me.tbpValidacao.Controls.Add(Me.mskCorHexadecimal)
        Me.tbpValidacao.Controls.Add(Me.mskData)
        Me.tbpValidacao.Controls.Add(Me.mskCodigoPostal)
        Me.tbpValidacao.Controls.Add(Me.btnData)
        Me.tbpValidacao.Controls.Add(Me.lblData)
        Me.tbpValidacao.Controls.Add(Me.btnValidarComentarioMultiLinha)
        Me.tbpValidacao.Controls.Add(Me.txtComentarioMultiLinha)
        Me.tbpValidacao.Controls.Add(Me.lblComentarioMultiLinha)
        Me.tbpValidacao.Controls.Add(Me.btnValidarCorHexadecimal)
        Me.tbpValidacao.Controls.Add(Me.lblCorHexadecimal)
        Me.tbpValidacao.Controls.Add(Me.btnValidarEnderecoIP)
        Me.tbpValidacao.Controls.Add(Me.txtEnderecoIP)
        Me.tbpValidacao.Controls.Add(Me.lblEnderecoIP)
        Me.tbpValidacao.Controls.Add(Me.btnValidarCodigoPostal)
        Me.tbpValidacao.Controls.Add(Me.lblCodigoPostal)
        Me.tbpValidacao.Controls.Add(Me.mskNumeroTelefonico)
        Me.tbpValidacao.Controls.Add(Me.btnValidarNumeroTelefonico)
        Me.tbpValidacao.Controls.Add(Me.lblNumeroTelefonico)
        Me.tbpValidacao.Controls.Add(Me.btnValidarNomeUsuario)
        Me.tbpValidacao.Controls.Add(Me.txtNomeUsuario)
        Me.tbpValidacao.Controls.Add(Me.lblNomeUsuario)
        Me.tbpValidacao.Controls.Add(Me.btnValidarEmail)
        Me.tbpValidacao.Controls.Add(Me.txtEmail)
        Me.tbpValidacao.Controls.Add(Me.lblEmail)
        Me.tbpValidacao.Location = New System.Drawing.Point(4, 22)
        Me.tbpValidacao.Name = "tbpValidacao"
        Me.tbpValidacao.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpValidacao.Size = New System.Drawing.Size(531, 314)
        Me.tbpValidacao.TabIndex = 0
        Me.tbpValidacao.Text = "Validação"
        Me.tbpValidacao.UseVisualStyleBackColor = True
        '
        'tbpOutros
        '
        Me.tbpOutros.Controls.Add(Me.lblResposta)
        Me.tbpOutros.Controls.Add(Me.lblContratoDeDadosResposta)
        Me.tbpOutros.Controls.Add(Me.dtpContratoDeDados)
        Me.tbpOutros.Controls.Add(Me.chkContratoDeDados)
        Me.tbpOutros.Controls.Add(Me.btnContratoDeDados)
        Me.tbpOutros.Controls.Add(Me.txtContratoDeDados)
        Me.tbpOutros.Controls.Add(Me.lblContratoDeDados)
        Me.tbpOutros.Controls.Add(Me.btnVoceDigitou)
        Me.tbpOutros.Controls.Add(Me.txtVoceDigitou)
        Me.tbpOutros.Controls.Add(Me.lblVoceDigitou)
        Me.tbpOutros.Location = New System.Drawing.Point(4, 22)
        Me.tbpOutros.Name = "tbpOutros"
        Me.tbpOutros.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOutros.Size = New System.Drawing.Size(531, 314)
        Me.tbpOutros.TabIndex = 1
        Me.tbpOutros.Text = "Outros"
        Me.tbpOutros.UseVisualStyleBackColor = True
        '
        'lblResposta
        '
        Me.lblResposta.AutoSize = True
        Me.lblResposta.Location = New System.Drawing.Point(6, 273)
        Me.lblResposta.Name = "lblResposta"
        Me.lblResposta.Size = New System.Drawing.Size(0, 13)
        Me.lblResposta.TabIndex = 46
        '
        'dtpContratoDeDados
        '
        Me.dtpContratoDeDados.Location = New System.Drawing.Point(9, 193)
        Me.dtpContratoDeDados.Name = "dtpContratoDeDados"
        Me.dtpContratoDeDados.Size = New System.Drawing.Size(241, 20)
        Me.dtpContratoDeDados.TabIndex = 44
        '
        'chkContratoDeDados
        '
        Me.chkContratoDeDados.AutoSize = True
        Me.chkContratoDeDados.Checked = True
        Me.chkContratoDeDados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkContratoDeDados.Location = New System.Drawing.Point(9, 170)
        Me.chkContratoDeDados.Name = "chkContratoDeDados"
        Me.chkContratoDeDados.Size = New System.Drawing.Size(241, 17)
        Me.chkContratoDeDados.TabIndex = 43
        Me.chkContratoDeDados.Text = "Mostra a Data e Hora no Contrato de Dados?"
        Me.chkContratoDeDados.UseVisualStyleBackColor = True
        '
        'frmTestaValidacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 366)
        Me.Controls.Add(Me.tbcValidacao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTestaValidacao"
        Me.ShowIcon = False
        Me.Text = "Testa Validação (form for test validation)"
        Me.tbcValidacao.ResumeLayout(False)
        Me.tbpValidacao.ResumeLayout(False)
        Me.tbpValidacao.PerformLayout()
        Me.tbpOutros.ResumeLayout(False)
        Me.tbpOutros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tipTestaValidacao As System.Windows.Forms.ToolTip
    Friend WithEvents tbcValidacao As System.Windows.Forms.TabControl
    Friend WithEvents tbpValidacao As System.Windows.Forms.TabPage
    Friend WithEvents mskCorHexadecimal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCodigoPostal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnData As System.Windows.Forms.Button
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents btnValidarComentarioMultiLinha As System.Windows.Forms.Button
    Friend WithEvents txtComentarioMultiLinha As System.Windows.Forms.TextBox
    Friend WithEvents lblComentarioMultiLinha As System.Windows.Forms.Label
    Friend WithEvents btnValidarCorHexadecimal As System.Windows.Forms.Button
    Friend WithEvents lblCorHexadecimal As System.Windows.Forms.Label
    Friend WithEvents btnValidarEnderecoIP As System.Windows.Forms.Button
    Friend WithEvents txtEnderecoIP As System.Windows.Forms.TextBox
    Friend WithEvents lblEnderecoIP As System.Windows.Forms.Label
    Friend WithEvents btnValidarCodigoPostal As System.Windows.Forms.Button
    Friend WithEvents lblCodigoPostal As System.Windows.Forms.Label
    Friend WithEvents mskNumeroTelefonico As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnValidarNumeroTelefonico As System.Windows.Forms.Button
    Friend WithEvents lblNumeroTelefonico As System.Windows.Forms.Label
    Friend WithEvents btnValidarNomeUsuario As System.Windows.Forms.Button
    Friend WithEvents txtNomeUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblNomeUsuario As System.Windows.Forms.Label
    Friend WithEvents btnValidarEmail As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents tbpOutros As System.Windows.Forms.TabPage
    Friend WithEvents btnContratoDeDados As System.Windows.Forms.Button
    Friend WithEvents txtContratoDeDados As System.Windows.Forms.TextBox
    Friend WithEvents lblContratoDeDados As System.Windows.Forms.Label
    Friend WithEvents btnVoceDigitou As System.Windows.Forms.Button
    Friend WithEvents txtVoceDigitou As System.Windows.Forms.TextBox
    Friend WithEvents lblVoceDigitou As System.Windows.Forms.Label
    Friend WithEvents dtpContratoDeDados As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkContratoDeDados As System.Windows.Forms.CheckBox
    Friend WithEvents lblResposta As System.Windows.Forms.Label
    Friend WithEvents lblContratoDeDadosResposta As System.Windows.Forms.Label

End Class
