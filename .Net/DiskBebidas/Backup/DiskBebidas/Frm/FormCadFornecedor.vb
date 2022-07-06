Public Class FormCadFornecedor

    Private Sub FormCadFornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FornecedorTableAdapter.Fill(Me.BancoDataSet.fornecedor)
        ColorSomenteLeitura()
    End Sub

    Private Sub BtLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLocalizar.Click
        Try
            Dim prazao As String = TextBox1.Text + "%"
            Me.FornecedorTableAdapter.FillByRazao(Me.BancoDataSet.fornecedor, prazao)

            If BancoDataSet.fornecedor.Rows.Count = 0 Then
                MessageBox.Show("Fornecedor não Cadastrado!!!")
                Me.FornecedorTableAdapter.Fill(Me.BancoDataSet.fornecedor)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try
    End Sub

    Private Sub BtNovoFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNovoFornecedor.Click

        BtDesfazer.Visible = True
        BtAlterarFornecedor.Visible = False
        TextBox1.Enabled = False
        BtLocalizar.Enabled = False
        BtApagarFornecedor.Enabled = False
        FornecedorBindingNavigator.Enabled = False

        Try
            ColorEdicaoCadastro()
            Me.FornecedorBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub BtAlterarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAlterarFornecedor.Click

        Try
            FornecedorBindingNavigator.Enabled = False
            TextBox1.Enabled = False
            BtLocalizar.Enabled = False

            Dim RegistroAtual As DataRowView = Me.FornecedorBindingSource.Current()
            Dim Codigo As Integer = RegistroAtual.Item("Codigo")

            If Codigo = CodigoTextBox.Text Then
                ColorEdicaoCadastro()
                BtDesfazer.Visible = True
                BtAlterarFornecedor.Visible = False
                BtApagarFornecedor.Enabled = False
                BtNovoFornecedor.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub BtSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSalvar.Click

        Try
            ColorSomenteLeitura()
            Me.Validate()
            Me.FornecedorBindingSource.EndEdit()
            Me.FornecedorTableAdapter.Update(Me.BancoDataSet.fornecedor)

        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

        FornecedorBindingNavigator.Enabled = True
        TextBox1.Enabled = True
        BtLocalizar.Enabled = True
        BtDesfazer.Visible = False
        BtAlterarFornecedor.Visible = True
        BtApagarFornecedor.Enabled = True
        BtNovoFornecedor.Enabled = True

    End Sub

    Private Sub BtApagarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtApagarFornecedor.Click

        Try
            Dim RegistroAtual As DataRowView = Me.FornecedorBindingSource.Current()
            Dim nome As String = RegistroAtual.Item("RazaoSocial")

            Dim res As DialogResult = MessageBox.Show("Deseja apagar o cliente " & vbCrLf + nome + "??", "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            If res = Windows.Forms.DialogResult.Yes Then
                FornecedorBindingSource.RemoveCurrent()
                Me.Validate()
                Me.FornecedorBindingSource.EndEdit()
                Me.FornecedorTableAdapter.Update(Me.BancoDataSet.fornecedor)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub BtDesfazer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDesfazer.Click
        Try

            Me.FornecedorBindingSource.CancelEdit()

        Catch EX As Exception
            MessageBox.Show("Erro: " + EX.Message)
        End Try

        FornecedorBindingNavigator.Enabled = True
        TextBox1.Enabled = True
        BtLocalizar.Enabled = True
        ColorSomenteLeitura()
        BtDesfazer.Visible = False
        BtAlterarFornecedor.Visible = True
        BtApagarFornecedor.Enabled = True
        BtNovoFornecedor.Enabled = True
        Me.FornecedorTableAdapter.Fill(Me.BancoDataSet.fornecedor)

    End Sub

    Private Sub FormCadFornecedor_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.Validate()
            Me.FornecedorBindingSource.EndEdit()

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

    
    
End Class