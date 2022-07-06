Public Class FormCadProduto

    Private Sub ProdutoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProdutoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

    End Sub

    Private Sub FormCadProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BancoDataSet.produto' table. You can move, or remove it, as needed.
        Me.ProdutoTableAdapter.Fill(Me.BancoDataSet.produto)

    End Sub
End Class