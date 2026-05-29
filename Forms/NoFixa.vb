Public Class NoFixa
    Private linha As DataGridViewRow
    Private Sub NoFixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        linha = New DataGridViewRow
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        linha = Me.DataGridView1.CurrentRow
        CodBox.Text = linha.Cells("N_Cod").Value
        TNCodBox.Text = linha.Cells("N_TN_Cod").Value
        CFIDBox.Text = linha.Cells("N_CF_ID").Value.ToString()
        ValorBox.Text = linha.Cells("N_Valor").Value
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class