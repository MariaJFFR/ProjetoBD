Public Class Inicio
    Private WithEvents MyNo As clsNO
    Private WithEvents myPARI As clsPARI
    Private WithEvents MyCF As clsCLIENTEFINAL

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim myPARI = New clsPARI(DbCnnstr)


        myPARI.sql_PARI_SEL1(100)
        Me.EMPRnome.Text = myPARI.VAL
        myPARI.sql_PARI_SEL1(101)
        Me.EMPRmorada.Text = myPARI.VAL
        myPARI.sql_PARI_SEL1(102)
        Me.EMPRnif.Text = myPARI.VAL
        myPARI.sql_PARI_SEL1(103)
        Me.EMPRtelefone.Text = myPARI.VAL

    End Sub
    Private Sub SAIR_Click(sender As Object, e As EventArgs) Handles SAIR.Click
        Me.Close()
    End Sub

    Private Sub AcercaDe_Click(sender As Object, e As EventArgs) Handles AcercaDe.Click
        acercadefixe.ShowDialog()
    End Sub

    Private Sub No_Click(sender As Object, e As EventArgs) Handles No.Click

    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        Dim MyNo = New clsNO(DbCnnstr)
        Dim tbl As New DataTable
        NoLista.DataGridView1.DataSource = MyNo.sql_NO_SELLALL
        NoLista.ShowDialog()
    End Sub

    Private Sub ListaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem1.Click
        Dim MyCF = New clsCLIENTEFINAL(DbCnnstr)
        Dim tbl As New DataTable
        CFLista.DataGridView1.DataSource = MyCF.sql_CLIENTEFINAL_SELALL
        CFLista.ShowDialog()
    End Sub

    Private Sub FichaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichaToolStripMenuItem.Click
        Dim MyNo = New clsNO(DbCnnstr)
        Dim tbl As New DataTable
        NoFixa.CodBox.Text = ""
        NoFixa.TNCodBox.Text = ""
        NoFixa.CFIDBox.Text = ""
        NoFixa.ValorBox.Text = ""
        NoFixa.DataGridView1.DataSource = MyNo.sql_NO_SELLALL
        NoFixa.ShowDialog()
    End Sub

    Private Sub FichaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FichaToolStripMenuItem1.Click
        Dim MyCF = New clsCLIENTEFINAL(DbCnnstr)
        Dim tbl As New DataTable
        CFFixa.NOMEBOX.Text = ""
        CFFixa.IDBOX.Text = ""
        CFFixa.VALORBOX.Text = ""
        CFFixa.DataGridView1.DataSource = MyCF.sql_CLIENTEFINAL_SELALL
        CFFixa.ShowDialog()
    End Sub

    Private Sub QuadroNosClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuadroNosClienteToolStripMenuItem.Click
        quadro.Show()
    End Sub
End Class
