Public Class FormPedido

    Private Sub FormPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ClienteTableAdapter.Fill(Me.BancoDataSet.cliente)
        Me.ProdutoTableAdapter.Fill(Me.BancoDataSet.produto)
        Me.PedidoTableAdapter.Fill(Me.BancoDataSet.pedido)

    End Sub

    Private Sub BtSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSalvar.Click
        Me.Validate()
        Me.PedidoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)


    End Sub
End Class