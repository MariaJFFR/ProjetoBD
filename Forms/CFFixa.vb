Public Class CFFixa
    Private linha As DataGridViewRow
    Private Sub CFFixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        linha = New DataGridViewRow
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        linha = Me.DataGridView1.CurrentRow
        IDBOX.Text = linha.Cells("CF_ID").Value
        NOMEBOX.Text = linha.Cells("CF_Nome").Value
        VALORBOX.Text = linha.Cells("CF_Valor").Value
    End Sub

End Class