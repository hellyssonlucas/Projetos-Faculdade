<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPedido
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
        Dim DataPedidoLabel As System.Windows.Forms.Label
        Dim DataVencimentoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPedido))
        Dim Cliente_TipoCliente_CodigoLabel As System.Windows.Forms.Label
        Dim Cliente_CodigoLabel As System.Windows.Forms.Label
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim ValorUnitarioLabel As System.Windows.Forms.Label
        Dim ValorTotalLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet = New DiskBebidas.bancoDataSet
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.DataPedidoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.DataVencimentoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ProdutoDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.PedidoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtDesfazer = New System.Windows.Forms.Button
        Me.BtnSair = New System.Windows.Forms.Button
        Me.BtNovoCliente = New System.Windows.Forms.Button
        Me.BtSalvar = New System.Windows.Forms.Button
        Me.BtApagarCliente = New System.Windows.Forms.Button
        Me.PedidoTableAdapter = New DiskBebidas.bancoDataSetTableAdapters.pedidoTableAdapter
        Me.TableAdapterManager = New DiskBebidas.bancoDataSetTableAdapters.TableAdapterManager
        Me.ClienteTableAdapter = New DiskBebidas.bancoDataSetTableAdapters.clienteTableAdapter
        Me.ProdutoTableAdapter = New DiskBebidas.bancoDataSetTableAdapters.produtoTableAdapter
        Me.Cliente_CodigoTextBox = New System.Windows.Forms.TextBox
        Me.Cliente_TipoCliente_CodigoTextBox = New System.Windows.Forms.TextBox
        Me.QuantidadeTextBox = New System.Windows.Forms.TextBox
        Me.ValorUnitarioTextBox = New System.Windows.Forms.TextBox
        Me.ValorTotalTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CodigoLabel = New System.Windows.Forms.Label
        DataPedidoLabel = New System.Windows.Forms.Label
        DataVencimentoLabel = New System.Windows.Forms.Label
        Cliente_TipoCliente_CodigoLabel = New System.Windows.Forms.Label
        Cliente_CodigoLabel = New System.Windows.Forms.Label
        QuantidadeLabel = New System.Windows.Forms.Label
        ValorUnitarioLabel = New System.Windows.Forms.Label
        ValorTotalLabel = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PedidoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PedidoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(5, 13)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 0
        CodigoLabel.Text = "Codigo:"
        '
        'DataPedidoLabel
        '
        DataPedidoLabel.AutoSize = True
        DataPedidoLabel.Location = New System.Drawing.Point(122, 13)
        DataPedidoLabel.Name = "DataPedidoLabel"
        DataPedidoLabel.Size = New System.Drawing.Size(69, 13)
        DataPedidoLabel.TabIndex = 2
        DataPedidoLabel.Text = "Data Pedido:"
        '
        'DataVencimentoLabel
        '
        DataVencimentoLabel.AutoSize = True
        DataVencimentoLabel.Location = New System.Drawing.Point(5, 44)
        DataVencimentoLabel.Name = "DataVencimentoLabel"
        DataVencimentoLabel.Size = New System.Drawing.Size(92, 13)
        DataVencimentoLabel.TabIndex = 4
        DataVencimentoLabel.Text = "Data Vencimento:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Cliente_CodigoTextBox)
        Me.Panel1.Controls.Add(Me.Cliente_TipoCliente_CodigoTextBox)
        Me.Panel1.Controls.Add(Cliente_TipoCliente_CodigoLabel)
        Me.Panel1.Controls.Add(Cliente_CodigoLabel)
        Me.Panel1.Controls.Add(QuantidadeLabel)
        Me.Panel1.Controls.Add(Me.QuantidadeTextBox)
        Me.Panel1.Controls.Add(ValorUnitarioLabel)
        Me.Panel1.Controls.Add(Me.ValorUnitarioTextBox)
        Me.Panel1.Controls.Add(ValorTotalLabel)
        Me.Panel1.Controls.Add(Me.ValorTotalTextBox)
        Me.Panel1.Controls.Add(CodigoLabel)
        Me.Panel1.Controls.Add(Me.CodigoTextBox)
        Me.Panel1.Controls.Add(DataPedidoLabel)
        Me.Panel1.Controls.Add(Me.DataPedidoDateTimePicker)
        Me.Panel1.Controls.Add(DataVencimentoLabel)
        Me.Panel1.Controls.Add(Me.DataVencimentoDateTimePicker)
        Me.Panel1.Controls.Add(Me.ProdutoDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(13, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 332)
        Me.Panel1.TabIndex = 0
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
        'PedidoBindingSource
        '
        Me.PedidoBindingSource.DataMember = "pedido"
        Me.PedidoBindingSource.DataSource = Me.BancoDataSet
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(53, 10)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(44, 20)
        Me.CodigoTextBox.TabIndex = 1
        '
        'DataPedidoDateTimePicker
        '
        Me.DataPedidoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidoBindingSource, "DataPedido", True))
        Me.DataPedidoDateTimePicker.Location = New System.Drawing.Point(197, 9)
        Me.DataPedidoDateTimePicker.Name = "DataPedidoDateTimePicker"
        Me.DataPedidoDateTimePicker.Size = New System.Drawing.Size(219, 20)
        Me.DataPedidoDateTimePicker.TabIndex = 3
        '
        'DataVencimentoDateTimePicker
        '
        Me.DataVencimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidoBindingSource, "DataVencimento", True))
        Me.DataVencimentoDateTimePicker.Location = New System.Drawing.Point(8, 60)
        Me.DataVencimentoDateTimePicker.Name = "DataVencimentoDateTimePicker"
        Me.DataVencimentoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataVencimentoDateTimePicker.TabIndex = 5
        '
        'ProdutoDataGridView
        '
        Me.ProdutoDataGridView.AutoGenerateColumns = False
        Me.ProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProdutoDataGridView.DataSource = Me.ProdutoBindingSource
        Me.ProdutoDataGridView.Location = New System.Drawing.Point(22, 96)
        Me.ProdutoDataGridView.Name = "ProdutoDataGridView"
        Me.ProdutoDataGridView.Size = New System.Drawing.Size(464, 112)
        Me.ProdutoDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descricao"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DataEntrada"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DataEntrada"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Pedido_Codigo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pedido_Codigo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Pedido_Cliente_Codigo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pedido_Cliente_Codigo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Pedido_Cliente_TipoCliente_Codigo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pedido_Cliente_TipoCliente_Codigo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'ProdutoBindingSource
        '
        Me.ProdutoBindingSource.DataMember = "fk_produto_pedido1"
        Me.ProdutoBindingSource.DataSource = Me.PedidoBindingSource
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(6, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(561, 370)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(3, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "System Control"
        '
        'PedidoBindingNavigator
        '
        Me.PedidoBindingNavigator.AddNewItem = Nothing
        Me.PedidoBindingNavigator.AutoSize = False
        Me.PedidoBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PedidoBindingNavigator.BindingSource = Me.PedidoBindingSource
        Me.PedidoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PedidoBindingNavigator.CountItemFormat = "de {0}"
        Me.PedidoBindingNavigator.DeleteItem = Nothing
        Me.PedidoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PedidoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1})
        Me.PedidoBindingNavigator.Location = New System.Drawing.Point(0, 434)
        Me.PedidoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PedidoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PedidoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PedidoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PedidoBindingNavigator.Name = "PedidoBindingNavigator"
        Me.PedidoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PedidoBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.PedidoBindingNavigator.Size = New System.Drawing.Size(636, 57)
        Me.PedidoBindingNavigator.TabIndex = 2
        Me.PedidoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 53)
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
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 53)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 53)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 53)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 56)
        '
        'BtDesfazer
        '
        Me.BtDesfazer.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.NEXTPG
        Me.BtDesfazer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtDesfazer.Location = New System.Drawing.Point(241, 383)
        Me.BtDesfazer.Name = "BtDesfazer"
        Me.BtDesfazer.Size = New System.Drawing.Size(61, 50)
        Me.BtDesfazer.TabIndex = 48
        Me.BtDesfazer.Text = "Desfazer"
        Me.BtDesfazer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtDesfazer.UseVisualStyleBackColor = True
        Me.BtDesfazer.Visible = False
        '
        'BtnSair
        '
        Me.BtnSair.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.EXIT5
        Me.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSair.Location = New System.Drawing.Point(454, 384)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(61, 50)
        Me.BtnSair.TabIndex = 47
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'BtNovoCliente
        '
        Me.BtNovoCliente.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.http___iconesbr_oficinadanet_com_6031_32x32
        Me.BtNovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtNovoCliente.Location = New System.Drawing.Point(174, 383)
        Me.BtNovoCliente.Name = "BtNovoCliente"
        Me.BtNovoCliente.Size = New System.Drawing.Size(61, 50)
        Me.BtNovoCliente.TabIndex = 44
        Me.BtNovoCliente.Text = "Novo"
        Me.BtNovoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtNovoCliente.UseVisualStyleBackColor = True
        '
        'BtSalvar
        '
        Me.BtSalvar.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.Save2796_32x32
        Me.BtSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtSalvar.ForeColor = System.Drawing.Color.Black
        Me.BtSalvar.Location = New System.Drawing.Point(308, 383)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(61, 50)
        Me.BtSalvar.TabIndex = 45
        Me.BtSalvar.Text = "Salvar"
        Me.BtSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtSalvar.UseVisualStyleBackColor = True
        '
        'BtApagarCliente
        '
        Me.BtApagarCliente.BackgroundImage = Global.DiskBebidas.My.Resources.Resources.CANCEL
        Me.BtApagarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtApagarCliente.Location = New System.Drawing.Point(375, 383)
        Me.BtApagarCliente.Name = "BtApagarCliente"
        Me.BtApagarCliente.Size = New System.Drawing.Size(61, 50)
        Me.BtApagarCliente.TabIndex = 46
        Me.BtApagarCliente.Text = "Excluir"
        Me.BtApagarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtApagarCliente.UseVisualStyleBackColor = True
        '
        'PedidoTableAdapter
        '
        Me.PedidoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.contaspagarTableAdapter = Nothing
        Me.TableAdapterManager.fornecedorTableAdapter = Nothing
        Me.TableAdapterManager.movimentacaoTableAdapter = Nothing
        Me.TableAdapterManager.pedidoTableAdapter = Me.PedidoTableAdapter
        Me.TableAdapterManager.produto_fornecedorTableAdapter = Nothing
        Me.TableAdapterManager.produtoTableAdapter = Me.ProdutoTableAdapter
        Me.TableAdapterManager.tipoclienteTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimentacaoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DiskBebidas.bancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ProdutoTableAdapter
        '
        Me.ProdutoTableAdapter.ClearBeforeFill = True
        '
        'Cliente_CodigoTextBox
        '
        Me.Cliente_CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "Cliente_Codigo", True))
        Me.Cliente_CodigoTextBox.Location = New System.Drawing.Point(163, 268)
        Me.Cliente_CodigoTextBox.Name = "Cliente_CodigoTextBox"
        Me.Cliente_CodigoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.Cliente_CodigoTextBox.TabIndex = 26
        '
        'Cliente_TipoCliente_CodigoTextBox
        '
        Me.Cliente_TipoCliente_CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "Cliente_TipoCliente_Codigo", True))
        Me.Cliente_TipoCliente_CodigoTextBox.Location = New System.Drawing.Point(163, 294)
        Me.Cliente_TipoCliente_CodigoTextBox.Name = "Cliente_TipoCliente_CodigoTextBox"
        Me.Cliente_TipoCliente_CodigoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.Cliente_TipoCliente_CodigoTextBox.TabIndex = 28
        '
        'Cliente_TipoCliente_CodigoLabel
        '
        Cliente_TipoCliente_CodigoLabel.AutoSize = True
        Cliente_TipoCliente_CodigoLabel.Location = New System.Drawing.Point(20, 297)
        Cliente_TipoCliente_CodigoLabel.Name = "Cliente_TipoCliente_CodigoLabel"
        Cliente_TipoCliente_CodigoLabel.Size = New System.Drawing.Size(137, 13)
        Cliente_TipoCliente_CodigoLabel.TabIndex = 27
        Cliente_TipoCliente_CodigoLabel.Text = "Cliente Tipo Cliente Codigo:"
        '
        'Cliente_CodigoLabel
        '
        Cliente_CodigoLabel.AutoSize = True
        Cliente_CodigoLabel.Location = New System.Drawing.Point(20, 271)
        Cliente_CodigoLabel.Name = "Cliente_CodigoLabel"
        Cliente_CodigoLabel.Size = New System.Drawing.Size(78, 13)
        Cliente_CodigoLabel.TabIndex = 25
        Cliente_CodigoLabel.Text = "Cliente Codigo:"
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Location = New System.Drawing.Point(25, 212)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(65, 13)
        QuantidadeLabel.TabIndex = 19
        QuantidadeLabel.Text = "Quantidade:"
        '
        'QuantidadeTextBox
        '
        Me.QuantidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "Quantidade", True))
        Me.QuantidadeTextBox.Location = New System.Drawing.Point(28, 228)
        Me.QuantidadeTextBox.Name = "QuantidadeTextBox"
        Me.QuantidadeTextBox.Size = New System.Drawing.Size(62, 20)
        Me.QuantidadeTextBox.TabIndex = 20
        '
        'ValorUnitarioLabel
        '
        ValorUnitarioLabel.AutoSize = True
        ValorUnitarioLabel.Location = New System.Drawing.Point(138, 212)
        ValorUnitarioLabel.Name = "ValorUnitarioLabel"
        ValorUnitarioLabel.Size = New System.Drawing.Size(73, 13)
        ValorUnitarioLabel.TabIndex = 21
        ValorUnitarioLabel.Text = "Valor Unitario:"
        '
        'ValorUnitarioTextBox
        '
        Me.ValorUnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "ValorUnitario", True))
        Me.ValorUnitarioTextBox.Location = New System.Drawing.Point(130, 228)
        Me.ValorUnitarioTextBox.Name = "ValorUnitarioTextBox"
        Me.ValorUnitarioTextBox.Size = New System.Drawing.Size(144, 20)
        Me.ValorUnitarioTextBox.TabIndex = 22
        '
        'ValorTotalLabel
        '
        ValorTotalLabel.AutoSize = True
        ValorTotalLabel.Location = New System.Drawing.Point(298, 212)
        ValorTotalLabel.Name = "ValorTotalLabel"
        ValorTotalLabel.Size = New System.Drawing.Size(61, 13)
        ValorTotalLabel.TabIndex = 23
        ValorTotalLabel.Text = "Valor Total:"
        '
        'ValorTotalTextBox
        '
        Me.ValorTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoBindingSource, "ValorTotal", True))
        Me.ValorTotalTextBox.Location = New System.Drawing.Point(293, 228)
        Me.ValorTotalTextBox.Name = "ValorTotalTextBox"
        Me.ValorTotalTextBox.Size = New System.Drawing.Size(144, 20)
        Me.ValorTotalTextBox.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 56)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Adicionar Itens"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(457, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 56)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Emitir Nota"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(653, 484)
        Me.Controls.Add(Me.BtDesfazer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtApagarCliente)
        Me.Controls.Add(Me.BtNovoCliente)
        Me.Controls.Add(Me.BtSalvar)
        Me.Controls.Add(Me.PedidoBindingNavigator)
        Me.Name = "FormPedido"
        Me.Text = "Pedido"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PedidoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PedidoBindingNavigator.ResumeLayout(False)
        Me.PedidoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BancoDataSet As DiskBebidas.bancoDataSet
    Friend WithEvents PedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PedidoTableAdapter As DiskBebidas.bancoDataSetTableAdapters.pedidoTableAdapter
    Friend WithEvents TableAdapterManager As DiskBebidas.bancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PedidoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataPedidoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataVencimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProdutoTableAdapter As DiskBebidas.bancoDataSetTableAdapters.produtoTableAdapter
    Friend WithEvents ProdutoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdutoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtDesfazer As System.Windows.Forms.Button
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents BtNovoCliente As System.Windows.Forms.Button
    Friend WithEvents BtSalvar As System.Windows.Forms.Button
    Friend WithEvents BtApagarCliente As System.Windows.Forms.Button
    Friend WithEvents ClienteTableAdapter As DiskBebidas.bancoDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cliente_CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cliente_TipoCliente_CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorUnitarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTotalTextBox As System.Windows.Forms.TextBox
End Class
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      