<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadCliente
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
        Me.components = New System.ComponentModel.Container
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim RazaoSocialLabel As System.Windows.Forms.Label
        Dim LogradouroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim TipoCliente_CodigoLabel As System.Windows.Forms.Label
        Dim CPFLabel1 As System.Windows.Forms.Label
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadCliente))
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet = New DiskBebidas.bancoDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.NomeTextBox = New System.Windows.Forms.TextBox
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox
        Me.LogradouroTextBox = New System.Windows.Forms.TextBox
        Me.CidadeTextBox = New System.Windows.Forms.TextBox
        Me.EstadoTextBox = New System.Windows.Forms.TextBox
        Me.BairroTextBox = New System.Windows.Forms.TextBox
        Me.NumeroTextBox = New System.Windows.Forms.TextBox
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox
        Me.BtLocalizar = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TipoCliente_CodigoTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnSair = New System.Windows.Forms.Button
        Me.BtFazerPedido = New System.Windows.Forms.Button
        Me.BtNovoCliente = New System.Windows.Forms.Button
        Me.BtSalvar = New System.Windows.Forms.Button
        Me.BtAlterarCliente = New System.Windows.Forms.Button
        Me.BtApagarCliente = New System.Windows.Forms.Button
        Me.BtDesfazer = New System.Windows.Forms.Button
        Me.ClienteTableAdapter = New DiskBebidas.bancoDataSetTableAdapters.clienteTableAdapter
        Me.TableAdapterManager = New DiskBebidas.bancoDataSetTableAdapters.TableAdapterManager
        Me.TipoclienteTableAdapter = New DiskBebidas.bancoDataSetTableAdapters.tipoclienteTableAdapter
        Me.TipoclienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CodigoLabel = New System.Windows.Forms.Label
        NomeLabel = New System.Windows.Forms.Label
        RazaoSocialLabel = New System.Windows.Forms.Label
        LogradouroLabel = New System.Windows.Forms.Label
        CidadeLabel = New System.Windows.Forms.Label
        EstadoLabel = New System.Windows.Forms.Label
        BairroLabel = New System.Windows.Forms.Label
        NumeroLabel = New System.Windows.Forms.Label
        ComplementoLabel = New System.Windows.Forms.Label
        TipoCliente_CodigoLabel = New System.Windows.Forms.Label
        CPFLabel1 = New System.Windows.Forms.Label
        CNPJLabel = New System.Windows.Forms.Label
        CEPLabel = New System.Windows.Forms.Label
        TelefoneLabel = New System.Windows.Forms.Label
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TipoclienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        CodigoLabel.Location = New System.Drawing.Point(10, 38)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(40, 13)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "Codigo"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(6, 12)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(35, 13)
        NomeLabel.TabIndex = 29
        NomeLabel.Text = "Nome"
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.Location = New System.Drawing.Point(5, 51)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(70, 13)
        RazaoSocialLabel.TabIndex = 33
        RazaoSocialLabel.Text = "Razao Social"
        '
        'LogradouroLabel
        '
        LogradouroLabel.AutoSize = True
        LogradouroLabel.Location = New System.Drawing.Point(6, 90)
        LogradouroLabel.Name = "LogradouroLabel"
        LogradouroLabel.Size = New System.Drawing.Size(61, 13)
        LogradouroLabel.TabIndex = 37
        LogradouroLabel.Text = "Logradouro"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(201, 131)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(40, 13)
        CidadeLabel.TabIndex = 39
        CidadeLabel.Text = "Cidade"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(394, 131)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(21, 13)
        EstadoLabel.TabIndex = 41
        EstadoLabel.Text = "UF"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(5, 131)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(34, 13)
        BairroLabel.TabIndex = 45
        BairroLabel.Text = "Bairro"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(311, 90)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(44, 13)
        NumeroLabel.TabIndex = 49
        NumeroLabel.Text = "Numero"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(370, 90)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(71, 13)
        ComplementoLabel.TabIndex = 51
        ComplementoLabel.Text = "Complemento"
        '
        'TipoCliente_CodigoLabel
        '
        TipoCliente_CodigoLabel.AutoSize = True
        TipoCliente_CodigoLabel.Location = New System.Drawing.Point(88, 6)
        TipoCliente_CodigoLabel.Name = "TipoCliente_CodigoLabel"
        TipoCliente_CodigoLabel.Size = New System.Drawing.Size(0, 13)
        TipoCliente_CodigoLabel.TabIndex = 33
        '
        'CPFLabel1
        '
        CPFLabel1.AutoSize = True
        CPFLabel1.Location = New System.Drawing.Point(373, 12)
        CPFLabel1.Name = "CPFLabel1"
        CPFLabel1.Size = New System.Drawing.Size(27, 13)
        CPFLabel1.TabIndex = 51
        CPFLabel1.Text = "CPF"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Location = New System.Drawing.Point(373, 51)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(34, 13)
        CNPJLabel.TabIndex = 52
        CNPJLabel.Text = "CNPJ"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(440, 131)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(28, 13)
        CEPLabel.TabIndex = 53
        CEPLabel.Text = "CEP"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(6, 179)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 54
        TelefoneLabel.Text = "Telefone:"
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Nothing
        Me.ClienteBindingNavigator.AutoSize = False
        Me.ClienteBindingNavigator.BackColor = System.Drawing.Color.Azure
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.CountItemFormat = "de {0}"
        Me.ClienteBindingNavigator.DeleteItem = Nothing
        Me.ClienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.ToolStripSeparator1})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 322)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(581, 57)
        Me.ClienteBindingNavigator.TabIndex = 50
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.BancoDataSet
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "bancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 54)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 54)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 54)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 54)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 54)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(25, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 57)
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(13, 54)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(48, 20)
        Me.CodigoTextBox.TabIndex = 20
        Me.CodigoTextBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(TelefoneLabel)
        Me.Panel1.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.Panel1.Controls.Add(CEPLabel)
        Me.Panel1.Controls.Add(Me.CEPMaskedTextBox)
        Me.Panel1.Controls.Add(CNPJLabel)
        Me.Panel1.Controls.Add(Me.CNPJMaskedTextBox)
        Me.Panel1.Controls.Add(CPFLabel1)
        Me.Panel1.Controls.Add(Me.CPFMaskedTextBox)
        Me.Panel1.Controls.Add(NomeLabel)
        Me.Panel1.Controls.Add(Me.NomeTextBox)
        Me.Panel1.Controls.Add(RazaoSocialLabel)
        Me.Panel1.Controls.Add(Me.RazaoSocialTextBox)
        Me.Panel1.Controls.Add(LogradouroLabel)
        Me.Panel1.Controls.Add(Me.LogradouroTextBox)
        Me.Panel1.Controls.Add(CidadeLabel)
        Me.Panel1.Controls.Add(Me.CidadeTextBox)
        Me.Panel1.Controls.Add(EstadoLabel)
        Me.Panel1.Controls.Add(Me.EstadoTextBox)
        Me.Panel1.Controls.Add(BairroLabel)
        Me.Panel1.Controls.Add(Me.BairroTextBox)
        Me.Panel1.Controls.Add(NumeroLabel)
        Me.Panel1.Controls.Add(Me.NumeroTextBox)
        Me.Panel1.Controls.Add(ComplementoLabel)
        Me.Panel1.Controls.Add(Me.ComplementoTextBox)
        Me.Panel1.Location = New System.Drawing.Point(13, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 233)
        Me.Panel1.TabIndex = 5
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneMaskedTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(9, 195)
        Me.TelefoneMaskedTextBox.Mask = "(00) 0000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneMaskedTextBox.TabIndex = 11
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPMaskedTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(443, 147)
        Me.CEPMaskedTextBox.Mask = "00,000-000"
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(87, 20)
        Me.CEPMaskedTextBox.TabIndex = 10
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNPJMaskedTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(372, 67)
        Me.CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(158, 20)
        Me.CNPJMaskedTextBox.TabIndex = 3
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPFMaskedTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(373, 28)
        Me.CPFMaskedTextBox.Mask = "999,999,99-99"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(157, 20)
        Me.CPFMaskedTextBox.TabIndex = 1
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.NomeTextBox.Location = New System.Drawing.Point(9, 28)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(358, 20)
        Me.NomeTextBox.TabIndex = 0
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazaoSocialTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(8, 67)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(359, 20)
        Me.RazaoSocialTextBox.TabIndex = 2
        '
        'LogradouroTextBox
        '
        Me.LogradouroTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.LogradouroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Logradouro", True))
        Me.LogradouroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogradouroTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LogradouroTextBox.Location = New System.Drawing.Point(8, 106)
        Me.LogradouroTextBox.Name = "LogradouroTextBox"
        Me.LogradouroTextBox.Size = New System.Drawing.Size(303, 20)
        Me.LogradouroTextBox.TabIndex = 4
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Cidade", True))
        Me.CidadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CidadeTextBox.Location = New System.Drawing.Point(204, 147)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(187, 20)
        Me.CidadeTextBox.TabIndex = 8
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Estado", True))
        Me.EstadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EstadoTextBox.Location = New System.Drawing.Point(397, 147)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(37, 20)
        Me.EstadoTextBox.TabIndex = 9
        '
        'BairroTextBox
        '
        Me.BairroTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Bairro", True))
        Me.BairroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BairroTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.BairroTextBox.Location = New System.Drawing.Point(8, 147)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(190, 20)
        Me.BairroTextBox.TabIndex = 7
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Numero", True))
        Me.NumeroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.NumeroTextBox.Location = New System.Drawing.Point(317, 106)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(53, 20)
        Me.NumeroTextBox.TabIndex = 5
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComplementoTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ComplementoTextBox.Location = New System.Drawing.Point(376, 106)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(154, 20)
        Me.ComplementoTextBox.TabIndex = 6
        '
        'BtLocalizar
        '
        Me.BtLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtLocalizar.Location = New System.Drawing.Point(231, 54)
        Me.BtLocalizar.Name = "BtLocalizar"
        Me.BtLocalizar.Size = New System.Drawing.Size(61, 20)
        Me.BtLocalizar.TabIndex = 1
        Me.BtLocalizar.Text = "Filtrar"
        Me.BtLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtLocalizar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = ""
        Me.TextBox1.AccessibleName = ""
        Me.TextBox1.Location = New System.Drawing.Point(67, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TipoCliente_CodigoTextBox
        '
        Me.TipoCliente_CodigoTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.TipoCliente_CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "TipoCliente_Codigo", True))
        Me.TipoCliente_CodigoTextBox.Location = New System.Drawing.Point(110, 25)
        Me.TipoCliente_CodigoTextBox.Name = "TipoCliente_CodigoTextBox"
        Me.TipoCliente_CodigoTextBox.Size = New System.Drawing.Size(27, 20)
        Me.TipoCliente_CodigoTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(64, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Busca por Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "1 - Pessoa Física"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "2 - Pessoa Jurídica"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TipoCliente_CodigoTextBox)
        Me.GroupBox1.Controls.Add(TipoCliente_CodigoLabel)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(310, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 49)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Cliente"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(6, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 312)
        Me.Panel2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(3, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "System Control"
        '
        'BtnSair
        '
        Me.BtnSair.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.EXIT5
        Me.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSair.Location = New System.Drawing.Point(505, 326)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(61, 50)
        Me.BtnSair.TabIndex = 19
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'BtFazerPedido
        '
        Me.BtFazerPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtFazerPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtFazerPedido.Image = Global.DiskBebidas.My.Resources.Resources.crdfle13
        Me.BtFazerPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtFazerPedido.Location = New System.Drawing.Point(468, 14)
        Me.BtFazerPedido.Name = "BtFazerPedido"
        Me.BtFazerPedido.Size = New System.Drawing.Size(98, 62)
        Me.BtFazerPedido.TabIndex = 20
        Me.BtFazerPedido.Text = "Fazer Pedido"
        Me.BtFazerPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtFazerPedido.UseVisualStyleBackColor = True
        '
        'BtNovoCliente
        '
        Me.BtNovoCliente.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.http___iconesbr_oficinadanet_com_6031_32x32
        Me.BtNovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtNovoCliente.Location = New System.Drawing.Point(173, 326)
        Me.BtNovoCliente.Name = "BtNovoCliente"
        Me.BtNovoCliente.Size = New System.Drawing.Size(61, 50)
        Me.BtNovoCliente.TabIndex = 15
        Me.BtNovoCliente.Text = "Novo"
        Me.BtNovoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtNovoCliente.UseVisualStyleBackColor = True
        '
        'BtSalvar
        '
        Me.BtSalvar.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.Save2796_32x32
        Me.BtSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtSalvar.ForeColor = System.Drawing.Color.Black
        Me.BtSalvar.Location = New System.Drawing.Point(307, 326)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(61, 50)
        Me.BtSalvar.TabIndex = 17
        Me.BtSalvar.Text = "Salvar"
        Me.BtSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSalvar.UseVisualStyleBackColor = True
        '
        'BtAlterarCliente
        '
        Me.BtAlterarCliente.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.cadastro
        Me.BtAlterarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtAlterarCliente.Location = New System.Drawing.Point(240, 326)
        Me.BtAlterarCliente.Name = "BtAlterarCliente"
        Me.BtAlterarCliente.Size = New System.Drawing.Size(61, 50)
        Me.BtAlterarCliente.TabIndex = 13
        Me.BtAlterarCliente.Text = "Alterar"
        Me.BtAlterarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtAlterarCliente.UseVisualStyleBackColor = True
        '
        'BtApagarCliente
        '
        Me.BtApagarCliente.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.CANCEL
        Me.BtApagarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtApagarCliente.Location = New System.Drawing.Point(374, 326)
        Me.BtApagarCliente.Name = "BtApagarCliente"
        Me.BtApagarCliente.Size = New System.Drawing.Size(61, 50)
        Me.BtApagarCliente.TabIndex = 18
        Me.BtApagarCliente.Text = "Excluir"
        Me.BtApagarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtApagarCliente.UseVisualStyleBackColor = True
        '
        'BtDesfazer
        '
        Me.BtDesfazer.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.NEXTPG
        Me.BtDesfazer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtDesfazer.Location = New System.Drawing.Point(240, 326)
        Me.BtDesfazer.Name = "BtDesfazer"
        Me.BtDesfazer.Size = New System.Drawing.Size(61, 50)
        Me.BtDesfazer.TabIndex = 43
        Me.BtDesfazer.Text = "Desfazer"
        Me.BtDesfazer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtDesfazer.UseVisualStyleBackColor = True
        Me.BtDesfazer.Visible = False
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.contaspagarTableAdapter = Nothing
        Me.TableAdapterManager.fornecedorTableAdapter = Nothing
        Me.TableAdapterManager.movimentacaoTableAdapter = Nothing
        Me.TableAdapterManager.pedidoTableAdapter = Nothing
        Me.TableAdapterManager.produto_fornecedorTableAdapter = Nothing
        Me.TableAdapterManager.produtoTableAdapter = Nothing
        Me.TableAdapterManager.tipoclienteTableAdapter = Me.TipoclienteTableAdapter
        Me.TableAdapterManager.tipomovimentacaoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DiskBebidas.bancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'TipoclienteTableAdapter
        '
        Me.TipoclienteTableAdapter.ClearBeforeFill = True
        '
        'TipoclienteBindingSource
        '
        Me.TipoclienteBindingSource.DataMember = "tipocliente"
        Me.TipoclienteBindingSource.DataSource = Me.BancoDataSet
        '
        'FormCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(581, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtDesfazer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtFazerPedido)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtNovoCliente)
        Me.Controls.Add(Me.BtSalvar)
        Me.Controls.Add(Me.BtLocalizar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtAlterarCliente)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Me.BtApagarCliente)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCadCliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TipoclienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancoDataSet As DiskBebidas.bancoDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As DiskBebidas.bancoDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As DiskBebidas.bancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RazaoSocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogradouroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComplementoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtLocalizar As System.Windows.Forms.Button
    Friend WithEvents BtApagarCliente As System.Windows.Forms.Button
    Friend WithEvents BtAlterarCliente As System.Windows.Forms.Button
    Friend WithEvents BtSalvar As System.Windows.Forms.Button
    Friend WithEvents BtNovoCliente As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtFazerPedido As System.Windows.Forms.Button
    Friend WithEvents TipoCliente_CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoclienteTableAdapter As DiskBebidas.bancoDataSetTableAdapters.tipoclienteTableAdapter
    Friend WithEvents TipoclienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CPFMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelefoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CEPMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CNPJMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtDesfazer As System.Windows.Forms.Button
End Class
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    