<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadFornecedor
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
        Dim RazaoSocialLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim LogradouroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CNPJLabel1 As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadFornecedor))
        Me.FornecedorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.FornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet = New DiskBebidas.bancoDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.RazaoSocialTextBox = New System.Windows.Forms.TextBox
        Me.CidadeTextBox = New System.Windows.Forms.TextBox
        Me.EstadoTextBox = New System.Windows.Forms.TextBox
        Me.LogradouroTextBox = New System.Windows.Forms.TextBox
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox
        Me.NumeroTextBox = New System.Windows.Forms.TextBox
        Me.BairroTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtLocalizar = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.BtnSair = New System.Windows.Forms.Button
        Me.BtNovoFornecedor = New System.Windows.Forms.Button
        Me.BtSalvar = New System.Windows.Forms.Button
        Me.BtAlterarFornecedor = New System.Windows.Forms.Button
        Me.BtApagarFornecedor = New System.Windows.Forms.Button
        Me.FornecedorTableAdapter = New DiskBebidas.bancoDataSetTableAdapters.fornecedorTableAdapter
        Me.TableAdapterManager = New DiskBebidas.bancoDataSetTableAdapters.TableAdapterManager
        Me.BtDesfazer = New System.Windows.Forms.Button
        CodigoLabel = New System.Windows.Forms.Label
        RazaoSocialLabel = New System.Windows.Forms.Label
        CidadeLabel = New System.Windows.Forms.Label
        EstadoLabel = New System.Windows.Forms.Label
        LogradouroLabel = New System.Windows.Forms.Label
        ComplementoLabel = New System.Windows.Forms.Label
        NumeroLabel = New System.Windows.Forms.Label
        BairroLabel = New System.Windows.Forms.Label
        CNPJLabel1 = New System.Windows.Forms.Label
        CEPLabel = New System.Windows.Forms.Label
        TelefoneLabel = New System.Windows.Forms.Label
        CType(Me.FornecedorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FornecedorBindingNavigator.SuspendLayout()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        CodigoLabel.Location = New System.Drawing.Point(3, 26)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(40, 13)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "Codigo"
        '
        'RazaoSocialLabel
        '
        RazaoSocialLabel.AutoSize = True
        RazaoSocialLabel.Location = New System.Drawing.Point(9, 10)
        RazaoSocialLabel.Name = "RazaoSocialLabel"
        RazaoSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazaoSocialLabel.TabIndex = 3
        RazaoSocialLabel.Text = "Razao Social:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(202, 88)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 7
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(395, 88)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(21, 13)
        EstadoLabel.TabIndex = 9
        EstadoLabel.Text = "UF"
        '
        'LogradouroLabel
        '
        LogradouroLabel.AutoSize = True
        LogradouroLabel.Location = New System.Drawing.Point(6, 49)
        LogradouroLabel.Name = "LogradouroLabel"
        LogradouroLabel.Size = New System.Drawing.Size(64, 13)
        LogradouroLabel.TabIndex = 13
        LogradouroLabel.Text = "Logradouro:"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Location = New System.Drawing.Point(378, 49)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(74, 13)
        ComplementoLabel.TabIndex = 15
        ComplementoLabel.Text = "Complemento:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(315, 49)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(47, 13)
        NumeroLabel.TabIndex = 19
        NumeroLabel.Text = "Numero:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(6, 88)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 21
        BairroLabel.Text = "Bairro:"
        '
        'CNPJLabel1
        '
        CNPJLabel1.AutoSize = True
        CNPJLabel1.Location = New System.Drawing.Point(374, 10)
        CNPJLabel1.Name = "CNPJLabel1"
        CNPJLabel1.Size = New System.Drawing.Size(37, 13)
        CNPJLabel1.TabIndex = 22
        CNPJLabel1.Text = "CNPJ:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(441, 88)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(31, 13)
        CEPLabel.TabIndex = 23
        CEPLabel.Text = "CEP:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(6, 127)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 24
        TelefoneLabel.Text = "Telefone:"
        '
        'FornecedorBindingNavigator
        '
        Me.FornecedorBindingNavigator.AddNewItem = Nothing
        Me.FornecedorBindingNavigator.AutoSize = False
        Me.FornecedorBindingNavigator.BackColor = System.Drawing.Color.Azure
        Me.FornecedorBindingNavigator.BindingSource = Me.FornecedorBindingSource
        Me.FornecedorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FornecedorBindingNavigator.CountItemFormat = "de {0}"
        Me.FornecedorBindingNavigator.DeleteItem = Nothing
        Me.FornecedorBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FornecedorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1})
        Me.FornecedorBindingNavigator.Location = New System.Drawing.Point(0, 324)
        Me.FornecedorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FornecedorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FornecedorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FornecedorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FornecedorBindingNavigator.Name = "FornecedorBindingNavigator"
        Me.FornecedorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FornecedorBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.FornecedorBindingNavigator.Size = New System.Drawing.Size(579, 54)
        Me.FornecedorBindingNavigator.TabIndex = 0
        Me.FornecedorBindingNavigator.Text = "BindingNavigator1"
        '
        'FornecedorBindingSource
        '
        Me.FornecedorBindingSource.DataMember = "fornecedor"
        Me.FornecedorBindingSource.DataSource = Me.BancoDataSet
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "bancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 51)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 51)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 51)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 51)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 51)
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(6, 42)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(48, 20)
        Me.CodigoTextBox.TabIndex = 2
        '
        'RazaoSocialTextBox
        '
        Me.RazaoSocialTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.RazaoSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "RazaoSocial", True))
        Me.RazaoSocialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazaoSocialTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RazaoSocialTextBox.Location = New System.Drawing.Point(9, 26)
        Me.RazaoSocialTextBox.Name = "RazaoSocialTextBox"
        Me.RazaoSocialTextBox.Size = New System.Drawing.Size(359, 20)
        Me.RazaoSocialTextBox.TabIndex = 4
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Cidade", True))
        Me.CidadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CidadeTextBox.Location = New System.Drawing.Point(205, 104)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(187, 20)
        Me.CidadeTextBox.TabIndex = 8
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Estado", True))
        Me.EstadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EstadoTextBox.Location = New System.Drawing.Point(398, 104)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(37, 20)
        Me.EstadoTextBox.TabIndex = 10
        '
        'LogradouroTextBox
        '
        Me.LogradouroTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.LogradouroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Logradouro", True))
        Me.LogradouroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogradouroTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LogradouroTextBox.Location = New System.Drawing.Point(9, 65)
        Me.LogradouroTextBox.Name = "LogradouroTextBox"
        Me.LogradouroTextBox.Size = New System.Drawing.Size(303, 20)
        Me.LogradouroTextBox.TabIndex = 14
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComplementoTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ComplementoTextBox.Location = New System.Drawing.Point(377, 65)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(154, 20)
        Me.ComplementoTextBox.TabIndex = 16
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Numero", True))
        Me.NumeroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.NumeroTextBox.Location = New System.Drawing.Point(318, 65)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(53, 20)
        Me.NumeroTextBox.TabIndex = 20
        '
        'BairroTextBox
        '
        Me.BairroTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Bairro", True))
        Me.BairroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BairroTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.BairroTextBox.Location = New System.Drawing.Point(9, 104)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(190, 20)
        Me.BairroTextBox.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(3, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "System Control"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtLocalizar)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(CodigoLabel)
        Me.Panel1.Controls.Add(Me.CodigoTextBox)
        Me.Panel1.Location = New System.Drawing.Point(6, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 312)
        Me.Panel1.TabIndex = 24
        '
        'BtLocalizar
        '
        Me.BtLocalizar.Location = New System.Drawing.Point(224, 42)
        Me.BtLocalizar.Name = "BtLocalizar"
        Me.BtLocalizar.Size = New System.Drawing.Size(61, 20)
        Me.BtLocalizar.TabIndex = 27
        Me.BtLocalizar.Text = "Filtrar"
        Me.BtLocalizar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(60, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(57, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Busca por Nome"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(TelefoneLabel)
        Me.Panel2.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.Panel2.Controls.Add(CEPLabel)
        Me.Panel2.Controls.Add(Me.CEPMaskedTextBox)
        Me.Panel2.Controls.Add(CNPJLabel1)
        Me.Panel2.Controls.Add(Me.CNPJMaskedTextBox)
        Me.Panel2.Controls.Add(Me.CidadeTextBox)
        Me.Panel2.Controls.Add(Me.ComplementoTextBox)
        Me.Panel2.Controls.Add(RazaoSocialLabel)
        Me.Panel2.Controls.Add(Me.NumeroTextBox)
        Me.Panel2.Controls.Add(Me.RazaoSocialTextBox)
        Me.Panel2.Controls.Add(BairroLabel)
        Me.Panel2.Controls.Add(Me.BairroTextBox)
        Me.Panel2.Controls.Add(NumeroLabel)
        Me.Panel2.Controls.Add(ComplementoLabel)
        Me.Panel2.Controls.Add(Me.LogradouroTextBox)
        Me.Panel2.Controls.Add(LogradouroLabel)
        Me.Panel2.Controls.Add(Me.EstadoTextBox)
        Me.Panel2.Controls.Add(EstadoLabel)
        Me.Panel2.Controls.Add(CidadeLabel)
        Me.Panel2.Location = New System.Drawing.Point(6, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(555, 193)
        Me.Panel2.TabIndex = 24
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneMaskedTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(9, 143)
        Me.TelefoneMaskedTextBox.Mask = "(00) 0000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneMaskedTextBox.TabIndex = 25
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPMaskedTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(441, 104)
        Me.CEPMaskedTextBox.Mask = "00,000-000"
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(87, 20)
        Me.CEPMaskedTextBox.TabIndex = 24
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNPJMaskedTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(372, 26)
        Me.CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(157, 20)
        Me.CNPJMaskedTextBox.TabIndex = 23
        '
        'BtnSair
        '
        Me.BtnSair.BackgroundImage = CType(resources.GetObject("BtnSair.BackgroundImage"), System.Drawing.Image)
        Me.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSair.Location = New System.Drawing.Point(505, 326)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(61, 50)
        Me.BtnSair.TabIndex = 41
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'BtNovoFornecedor
        '
        Me.BtNovoFornecedor.BackgroundImage = CType(resources.GetObject("BtNovoFornecedor.BackgroundImage"), System.Drawing.Image)
        Me.BtNovoFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtNovoFornecedor.Location = New System.Drawing.Point(173, 326)
        Me.BtNovoFornecedor.Name = "BtNovoFornecedor"
        Me.BtNovoFornecedor.Size = New System.Drawing.Size(61, 50)
        Me.BtNovoFornecedor.TabIndex = 37
        Me.BtNovoFornecedor.Text = "Novo"
        Me.BtNovoFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtNovoFornecedor.UseVisualStyleBackColor = True
        '
        'BtSalvar
        '
        Me.BtSalvar.BackgroundImage = CType(resources.GetObject("BtSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtSalvar.ForeColor = System.Drawing.Color.Black
        Me.BtSalvar.Location = New System.Drawing.Point(307, 326)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(61, 50)
        Me.BtSalvar.TabIndex = 39
        Me.BtSalvar.Text = "Salvar"
        Me.BtSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSalvar.UseVisualStyleBackColor = True
        '
        'BtAlterarFornecedor
        '
        Me.BtAlterarFornecedor.BackgroundImage = CType(resources.GetObject("BtAlterarFornecedor.BackgroundImage"), System.Drawing.Image)
        Me.BtAlterarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtAlterarFornecedor.Location = New System.Drawing.Point(240, 326)
        Me.BtAlterarFornecedor.Name = "BtAlterarFornecedor"
        Me.BtAlterarFornecedor.Size = New System.Drawing.Size(61, 50)
        Me.BtAlterarFornecedor.TabIndex = 38
        Me.BtAlterarFornecedor.Text = "Alterar"
        Me.BtAlterarFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtAlterarFornecedor.UseVisualStyleBackColor = True
        '
        'BtApagarFornecedor
        '
        Me.BtApagarFornecedor.BackgroundImage = CType(resources.GetObject("BtApagarFornecedor.BackgroundImage"), System.Drawing.Image)
        Me.BtApagarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtApagarFornecedor.Location = New System.Drawing.Point(374, 326)
        Me.BtApagarFornecedor.Name = "BtApagarFornecedor"
        Me.BtApagarFornecedor.Size = New System.Drawing.Size(61, 50)
        Me.BtApagarFornecedor.TabIndex = 40
        Me.BtApagarFornecedor.Text = "Excluir"
        Me.BtApagarFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtApagarFornecedor.UseVisualStyleBackColor = True
        '
        'FornecedorTableAdapter
        '
        Me.FornecedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.contaspagarTableAdapter = Nothing
        Me.TableAdapterManager.fornecedorTableAdapter = Me.FornecedorTableAdapter
        Me.TableAdapterManager.movimentacaoTableAdapter = Nothing
        Me.TableAdapterManager.pedidoTableAdapter = Nothing
        Me.TableAdapterManager.produto_fornecedorTableAdapter = Nothing
        Me.TableAdapterManager.produtoTableAdapter = Nothing
        Me.TableAdapterManager.tipoclienteTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimentacaoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DiskBebidas.bancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'BtDesfazer
        '
        Me.BtDesfazer.BackgroundImage = CType(resources.GetObject("BtDesfazer.BackgroundImage"), System.Drawing.Image)
        Me.BtDesfazer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtDesfazer.Location = New System.Drawing.Point(240, 326)
        Me.BtDesfazer.Name = "BtDesfazer"
        Me.BtDesfazer.Size = New System.Drawing.Size(61, 50)
        Me.BtDesfazer.TabIndex = 44
        Me.BtDesfazer.Text = "Desfazer"
        Me.BtDesfazer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtDesfazer.UseVisualStyleBackColor = True
        Me.BtDesfazer.Visible = False
        '
        'FormCadFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(579, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtDesfazer)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtNovoFornecedor)
        Me.Controls.Add(Me.BtAlterarFornecedor)
        Me.Controls.Add(Me.BtApagarFornecedor)
        Me.Controls.Add(Me.BtSalvar)
        Me.Controls.Add(Me.FornecedorBindingNavigator)
        Me.Name = "FormCadFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Fornecedores"
        CType(Me.FornecedorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FornecedorBindingNavigator.ResumeLayout(False)
        Me.FornecedorBindingNavigator.PerformLayout()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BancoDataSet As DiskBebidas.bancoDataSet
    Friend WithEvents FornecedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FornecedorTableAdapter As DiskBebidas.bancoDataSetTableAdapters.fornecedorTableAdapter
    Friend WithEvents TableAdapterManager As DiskBebidas.bancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FornecedorBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RazaoSocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogradouroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComplementoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents BtNovoFornecedor As System.Windows.Forms.Button
    Friend WithEvents BtSalvar As System.Windows.Forms.Button
    Friend WithEvents BtAlterarFornecedor As System.Windows.Forms.Button
    Friend WithEvents BtApagarFornecedor As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtLocalizar As System.Windows.Forms.Button
    Friend WithEvents CNPJMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CEPMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelefoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BtDesfazer As System.Windows.Forms.Button
End Class
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      