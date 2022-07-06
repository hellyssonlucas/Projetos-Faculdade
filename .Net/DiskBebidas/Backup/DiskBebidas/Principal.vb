Public Class Principal

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        'MenuStrip1.Visible = False
        'Login.ShowDialog()
    End Sub

    Private Sub SairDoSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairDoSistemaToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        FormCadCliente.MdiParent = Me
        FormCadCliente.Show()
        MenuStrip1.Enabled = False
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click
        FormCadFornecedor.MdiParent = Me
        FormCadFornecedor.Show()
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutoToolStripMenuItem.Click
        FormCadProduto.MdiParent = Me
        FormCadProduto.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        FormCadUsuario.MdiParent = Me
        FormCadUsuario.Show()
    End Sub
End Class