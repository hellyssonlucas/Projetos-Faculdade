Public Class FormCadUsuario

    Private Sub FormCadUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsuarioTableAdapter.Fill(Me.BancoDataSet.usuario)
    End Sub

    Private Sub BtSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSalvar.Click

        Dim TbUsuario As DataTable = Nothing
        TbUsuario = UsuarioTableAdapter.GetDataByNome(NomeTextBox.Text)

        If SenhaTextBox.Text = "" Then
            MessageBox.Show("Senha Obrigatoria!! " & vbCrLf & "Digite uma Senha e Salve!!")
            SenhaTextBox.Focus()
        ElseIf TbUsuario.Rows.Count <> 0 Then
            MessageBox.Show("Nome de Usuario ja Cadastrado!! " & vbCrLf & "Digite outro Nome!!")
            NomeTextBox.Focus()
        Else
            Me.Validate()
            Me.UsuarioBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
            Me.UsuarioTableAdapter.Fill(Me.BancoDataSet.usuario)
            BtApagar.Enabled = True
        End If

    End Sub

    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtNovoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNovo.Click

        NomeTextBox.Focus()
        BtApagar.Enabled = False
        Try
            Me.UsuarioBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub BtApagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtApagar.Click

        UsuarioBindingSource.RemoveCurrent()
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.UsuarioTableAdapter.Update(Me.BancoDataSet.usuario)

    End Sub
End Class