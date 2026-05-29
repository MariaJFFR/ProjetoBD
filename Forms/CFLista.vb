Public Class CFLista
    Private linha As DataGridViewRow

    Public ReadOnly Property Escolha As DataGridViewRow
        Get
            Escolha = linha
        End Get
    End Property

    Private Sub CFLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        linha = Nothing
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        linha = New DataGridViewRow
        linha = Me.DataGridView1.CurrentRow
        Me.Close()
    End Sub
End Class