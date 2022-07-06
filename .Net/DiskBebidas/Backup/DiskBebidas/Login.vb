
Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        logar()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Principal.Close()
    End Sub

    Private Sub logar()

        Dim TbUsuario As DataTable = Nothing
        Dim senha As String = ""
        TbUsuario = UsuarioTableAdapter.GetDataByNome(NomeTextBox.Text)

        If TbUsuario.Select().Length > 0 Then
            Dim registro As DataRow = TbUsuario.Rows(0)
            senha = registro("Senha")
        End If

        If SenhaTextBox.Text = senha Then
            Me.Hide()
            Principal.Show()
            Principal.MenuStrip1.Visible = True
        Else
            MessageBox.Show("Usuário ou Senha Incorretos!!")
        End If

    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class