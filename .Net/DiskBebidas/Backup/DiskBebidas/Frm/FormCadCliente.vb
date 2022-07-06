Public Class FormCadCliente

    Private Sub FormCadCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TipoclienteTableAdapter.Fill(Me.BancoDataSet.tipocliente)
        Me.ClienteTableAdapter.Fill(Me.BancoDataSet.cliente)
        ColorSomenteLeitura()
    End Sub

    Private Sub BtLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLocalizar.Click
        Try
            Dim pnome As String = TextBox1.Text + "%"
            Dim nome = Me.ClienteTableAdapter.FillByNome(Me.BancoDataSet.cliente, pnome)

            If BancoDataSet.cliente.Rows.Count = 0 Then
                MessageBox.Show("Nome não Cadastrado!!!")
                Me.ClienteTableAdapter.Fill(Me.BancoDataSet.cliente)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub BtNovoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNovoCliente.Click

        BtDesfazer.Visible = True
        BtAlterarCliente.Visible = False
        TextBox1.Enabled = False
        BtLocalizar.Enabled = False
        BtApagarCliente.Enabled = False
        ClienteBindingNavigator.Enabled = False

        Try
            ColorEdicaoCadastro()
            Me.ClienteBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub BtAlterarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAlterarCliente.Click

        Try
            ClienteBindingNavigator.Enabled = False
            TextBox1.Enabled = False
            BtLocalizar.Enabled = False

            Dim RegistroAtual As DataRowView = Me.ClienteBindingSource.Current()
            Dim Codigo As Integer = RegistroAtual.Item("Codigo")

            If Codigo = CodigoTextBox.Text Then
                ColorEdicaoCadastro()
                BtDesfazer.Visible = True
                BtAlterarCliente.Visible = False
                BtApagarCliente.Enabled = False
                BtNovoCliente.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub BtSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSalvar.Click

        Try
            ColorSomenteLeitura()

            Me.Validate()
            Me.ClienteBindingSource.EndEdit()
            Me.ClienteTableAdapter.Update(Me.BancoDataSet.cliente)
            Me.ClienteTableAdapter.Fill(Me.BancoDataSet.cliente)

        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

        ClienteBindingNavigator.Enabled = True
        TextBox1.Enabled = True
        BtLocalizar.Enabled = True
        BtDesfazer.Visible = False
        BtAlterarCliente.Visible = True
        BtApagarCliente.Enabled = True
        BtNovoCliente.Enabled = True


    End Sub

    Private Sub BtApagarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtApagarCliente.Click
        Try
            Dim RegistroAtualNome As DataRowView = Me.ClienteBindingSource.Current()
            Dim nome As String = RegistroAtualNome.Item("Nome")

            Dim RegistroAtualRazao As DataRowView = Me.ClienteBindingSource.Current()
            Dim Razao As String = RegistroAtualRazao.Item("Razaosocial")

            Dim res As DialogResult = MessageBox.Show("Deseja apagar o cliente " & vbCrLf + nome + "??", "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If res = Windows.Forms.DialogResult.Yes Then
                ClienteBindingSource.RemoveCurrent()
                Me.Validate()
                Me.ClienteBindingSource.EndEdit()
                Me.ClienteTableAdapter.Update(Me.BancoDataSet.cliente)
            End If
            Me.ClienteTableAdapter.Fill(Me.BancoDataSet.cliente)
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub BtDesfazer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDesfazer.Click
        Try

            Me.ClienteBindingSource.CancelEdit()

        Catch EX As Exception
            MessageBox.Show("Erro: " + EX.Message)
        End Try

        ClienteBindingNavigator.Enabled = True
        TextBox1.Enabled = True
        BtLocalizar.Enabled = True
        ColorSomenteLeitura()
        BtDesfazer.Visible = False
        BtAlterarCliente.Visible = True
        BtApagarCliente.Enabled = True
        BtNovoCliente.Enabled = True
        Me.ClienteTableAdapter.Fill(Me.BancoDataSet.cliente)

    End Sub


    Private Sub FormCadCliente_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.Validate()
            Me.ClienteBindingSource.EndEdit()

            If Me.BancoDataSet.cliente.GetChanges IsNot Nothing Then
                Dim res As DialogResult = MessageBox.Show("Existe alterações pendentes! Deseja Fechar mesmo assim??", "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                If res = Windows.Forms.DialogResult.No Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSair.Click
        Try
            Me.Close()
            Principal.MenuStrip1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try


    End Sub

    Private Sub ColorEdicaoCadastro()
        TipoCliente_CodigoTextBox.ReadOnly = False
        TipoCliente_CodigoTextBox.BackColor = Color.White
        NomeTextBox.ReadOnly = False
        NomeTextBox.BackColor = Color.White
        CPFMaskedTextBox.ReadOnly = False
        CPFMaskedTextBox.BackColor = Color.White
        RazaoSocialTextBox.ReadOnly = False
        RazaoSocialTextBox.BackColor = Color.White
        CNPJMaskedTextBox.ReadOnly = False
        CNPJMaskedTextBox.BackColor = Color.White
        LogradouroTextBox.ReadOnly = False
        LogradouroTextBox.BackColor = Color.White
        NumeroTextBox.ReadOnly = False
        NumeroTextBox.BackColor = Color.White
        ComplementoTextBox.ReadOnly = False
        ComplementoTextBox.BackColor = Color.White
        BairroTextBox.ReadOnly = False
        BairroTextBox.BackColor = Color.White
        CidadeTextBox.ReadOnly = False
        CidadeTextBox.BackColor = Color.White
        EstadoTextBox.ReadOnly = False
        EstadoTextBox.BackColor = Color.White
        CEPMaskedTextBox.ReadOnly = False
        CEPMaskedTextBox.BackColor = Color.White
        TelefoneMaskedTextBox.ReadOnly = False
        TelefoneMaskedTextBox.BackColor = Color.White
    End Sub

    Private Sub ColorSomenteLeitura()
        TipoCliente_CodigoTextBox.ReadOnly = True
        TipoCliente_CodigoTextBox.BackColor = Color.LemonChiffon
        NomeTextBox.ReadOnly = True
        NomeTextBox.BackColor = Color.LemonChiffon
        CPFMaskedTextBox.ReadOnly = True
        CPFMaskedTextBox.BackColor = Color.LemonChiffon
        RazaoSocialTextBox.ReadOnly = True
        RazaoSocialTextBox.BackColor = Color.LemonChiffon
        CNPJMaskedTextBox.ReadOnly = True
        CNPJMaskedTextBox.BackColor = Color.LemonChiffon
        LogradouroTextBox.ReadOnly = True
        LogradouroTextBox.BackColor = Color.LemonChiffon
        NumeroTextBox.ReadOnly = True
        NumeroTextBox.BackColor = Color.LemonChiffon
        ComplementoTextBox.ReadOnly = True
        ComplementoTextBox.BackColor = Color.LemonChiffon
        BairroTextBox.ReadOnly = True
        BairroTextBox.BackColor = Color.LemonChiffon
        CidadeTextBox.ReadOnly = True
        CidadeTextBox.BackColor = Color.LemonChiffon
        EstadoTextBox.ReadOnly = True
        EstadoTextBox.BackColor = Color.LemonChiffon
        CEPMaskedTextBox.ReadOnly = True
        CEPMaskedTextBox.BackColor = Color.LemonChiffon
        TelefoneMaskedTextBox.ReadOnly = True
        TelefoneMaskedTextBox.BackColor = Color.LemonChiffon
    End Sub

    Private Sub BtFazerPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFazerPedido.Click
        FormPedido.Show()
    End Sub

    Private Sub BtSalvar_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BtSalvar.Validating

        'Try
        If TipoCliente_CodigoTextBox.Text = "" Then
            Dim res1 As DialogResult = MessageBox.Show("Tipo de Cliente Invalido!" & vbCrLf & "Defina 1 ou 2", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If res1 = Windows.Forms.DialogResult.OK Then
                ColorEdicaoCadastro()
                e.Cancel = True
            End If
        End If
        'Catch ex As Exception
        '    MessageBox.Show("Erro: " + ex.Message)
        'End Try

    End Sub
End Class