Public Class quadro
    Private WithEvents MyCF As clsCLIENTEFINAL
    Private WithEvents MyNo As clsNO
    Private WithEvents MyTipoNo As clsTIPONO
    Private novoNo As Boolean = True
    Private noSelecionadoCod As String = ""
    Private novoCF As Boolean = False

    Private Sub quadro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyCF = New clsCLIENTEFINAL(DbCnnstr)
        MyNo = New clsNO(DbCnnstr)
        MyTipoNo = New clsTIPONO(DbCnnstr)
        PrepForm(0)

        Dim dtTipoNo As DataTable = MyTipoNo.sql_TIPONO_SELALL()
        TNBox.DataSource = dtTipoNo
        TNBox.DisplayMember = "TN_NOME"   ' Altere para o nome correto do campo
        TNBox.ValueMember = "TN_COD"      ' Altere para o nome correto do campo
        TNBox.SelectedIndex = -1
        btngravartn.Text = "Inserir"
    End Sub

    Private Sub PrepForm(ByVal status As Integer)
        Select Case status
            Case 0
                btnbusca.Enabled = True
                btnnovo.Enabled = True
                btneditar.Enabled = False
                btneliminar.Enabled = False
                btncancelar.Enabled = False
                btngravar.Enabled = False
            Case 1 ' Editar
                btnbusca.Enabled = False
                btnnovo.Enabled = False
                btneditar.Enabled = False
                btneliminar.Enabled = False
                btncancelar.Enabled = True
                btngravar.Enabled = True
            Case 2 ' Novo
                btnbusca.Enabled = False
                btnnovo.Enabled = False
                btneditar.Enabled = False
                btneliminar.Enabled = False
                btncancelar.Enabled = True
                btngravar.Enabled = True
            Case 3 ' Registro carregado
                btnbusca.Enabled = True
                btnnovo.Enabled = True
                btneditar.Enabled = True
                btneliminar.Enabled = True
                btncancelar.Enabled = False
                btngravar.Enabled = False
        End Select
    End Sub

    Private Sub PrepararParaInserirNo()
        LimpaCamposNo()
        novoNo = True
        btngravartn.Text = "Inserir"
        NCodBox.Focus()
    End Sub

    Private Sub btnbusca_Click(sender As Object, e As EventArgs) Handles btnbusca.Click
        Dim tbl As New DataTable
        CFLista.DataGridView1.DataSource = MyCF.sql_CLIENTEFINAL_SELALL
        CFLista.ShowDialog()
        If CFLista.Escolha IsNot Nothing Then
            Dim cfid As Integer = CInt(CFLista.Escolha.Cells("CF_ID").Value)
            MyCF.sql_CLIENTEFINAL_SEL1(cfid)
            txtcfid.Text = CFLista.Escolha.Cells("CF_ID").Value
            txtcfnome.Text = CFLista.Escolha.Cells("CF_Nome").Value
            txtcfvalor.Text = CFLista.Escolha.Cells("CF_Valor").Value
            Me.DataGridView1.DataSource = MyNo.sql_NO_SELLCF(cfid)
            PrepForm(3)
        End If
    End Sub

    Private Sub btnnovo_Click(sender As Object, e As EventArgs) Handles btnnovo.Click
        LimpaCampos()
        PrepForm(2)
        novoCF = True
        txtcfnome.Focus()
        Me.DataGridView1.DataSource = Nothing
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        If txtcfid.Text <> "" Then
            PrepForm(1)
            novoCF = False
            txtcfnome.Focus()
        End If
    End Sub

    Private Sub btngravar_Click(sender As Object, e As EventArgs) Handles btngravar.Click
        If txtcfnome.Text.Trim() = "" Then
            MessageBox.Show("Preencha o nome do cliente final.")
            txtcfnome.Focus()
            Exit Sub
        End If

        Dim nome As String = txtcfnome.Text
        Dim valor As Integer = 0
        Integer.TryParse(txtcfvalor.Text, valor)
        Dim cfid As Integer = 0

        If novoCF Then
            ' INSERIR
            MyCF.sql_CLIENTEFINAL_INS(nome, valor)
            ' Recuperar o último ID inserido (ajuste conforme sua base de dados)
            ' Exemplo usando SQL Server SCOPE_IDENTITY()
            MyCF.sql_CLIENTEFINAL_SEL1(MyCF.ID) ' Certifique-se que MyCF.ID é atualizado após o insert
            cfid = MyCF.ID
        Else
            ' EDITAR
            Integer.TryParse(txtcfid.Text, cfid)
            MyCF.sql_CLIENTEFINAL_UPD(cfid, nome)
        End If

        ' Atualizar DataGridView1 para mostrar os nós do cliente atual
        Me.DataGridView1.DataSource = MyNo.sql_NO_SELLCF(cfid)

        PrepForm(0)
        LimpaCampos()
        novoCF = False
    End Sub

    Private Sub MyCF_Action(ByVal status As Integer) Handles MyCF.Action
        Select Case status
            Case 5
                MessageBox.Show("Registo com chave duplicada.", "Cliente Final", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Case 6
                MessageBox.Show("Registo eliminado.", "Cliente Final", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 7
                MessageBox.Show("Registo atualizado.", "Cliente Final", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 8
                MessageBox.Show("Registo inserido.", "Cliente Final", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub


    Private Sub LimpaCampos()
        txtcfid.Text = ""
        txtcfnome.Text = ""
        txtcfvalor.Text = ""
    End Sub

    ' Botão Cancelar: limpa os campos e volta ao estado inicial
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        LimpaCampos()
        PrepForm(0)
        Me.DataGridView1.DataSource = Nothing
    End Sub

    ' Botão Eliminar: elimina o cliente selecionado
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtcfid.Text = "" Then
            MessageBox.Show("Nenhum cliente selecionado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Pretende eliminar o registo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim cfid As Integer = 0
            Integer.TryParse(txtcfid.Text, cfid)
            MyCF.sql_CLIENTEFINAL_DEL(cfid)
            LimpaCampos()
            PrepForm(0)
            Me.DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub ClrNo_Click(sender As Object, e As EventArgs) Handles ClrNo.Click
        NCodBox.Text = ""
        TNBox.SelectedIndex = -1
        valorbox.Text = ""
        NCodBox.Focus()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow IsNot Nothing AndAlso DataGridView1.CurrentRow.Index >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.CurrentRow
            ' Ajuste os nomes das colunas conforme o seu DataTable
            NCodBox.Text = row.Cells("N_Cod").Value.ToString()
            valorbox.Text = row.Cells("N_Valor").Value.ToString()

            Dim tipoNome As String = row.Cells("TN_Nome").Value.ToString()
            Dim idx As Integer = TNBox.FindStringExact(tipoNome)
            If idx >= 0 Then
                TNBox.SelectedIndex = idx
            Else
                TNBox.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub btngravartn_Click(sender As Object, e As EventArgs) Handles btngravartn.Click
        If txtcfid.Text = "" Then
            MessageBox.Show("Selecione um cliente final primeiro.")
            Exit Sub
        End If
        If NCodBox.Text.Trim() = "" Or TNBox.SelectedIndex = -1 Or valorbox.Text.Trim() = "" Then
            MessageBox.Show("Preencha todos os campos do nó.")
            Exit Sub
        End If

        Dim cfid As Integer = CInt(txtcfid.Text)
        Dim nCod As String = NCodBox.Text
        Dim tnCod As String = TNBox.SelectedValue.ToString()
        Dim nValor As Integer = 0
        Integer.TryParse(valorbox.Text, nValor)

        If novoNo Then
            ' INSERIR
            MyNo.sql_NO_INS(nCod, tnCod, cfid, nValor)
            MessageBox.Show("Nó inserido com sucesso.", "Nó", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' EDITAR
            MyNo.sql_NO_UPD(nCod, tnCod, nValor)
            MessageBox.Show("Nó atualizado com sucesso.", "Nó", MessageBoxButtons.OK, MessageBoxIcon.Information)
            novoNo = True
        End If

        ' Atualizar DataGridView1
        Me.DataGridView1.DataSource = MyNo.sql_NO_SELLCF(cfid)

        ' Atualizar campos do cliente final
        Dim tbl As DataTable = MyCF.sql_CLIENTEFINAL_SEL1(cfid)
        If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
            txtcfid.Text = tbl.Rows(0)("CF_ID").ToString()
            txtcfnome.Text = tbl.Rows(0)("CF_Nome").ToString()
            txtcfvalor.Text = tbl.Rows(0)("CF_Valor").ToString()
        End If

        PrepararParaInserirNo()
    End Sub


    ' Limpa os campos do nó
    Private Sub LimpaCamposNo()
        NCodBox.Text = ""
        TNBox.SelectedIndex = -1
        valorbox.Text = ""
        NCodBox.Focus()
    End Sub

    Private Sub btneditartn_Click(sender As Object, e As EventArgs) Handles btneditartn.Click
        If DataGridView1.CurrentRow IsNot Nothing AndAlso DataGridView1.CurrentRow.Index >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.CurrentRow
            NCodBox.Text = row.Cells("N_Cod").Value.ToString()
            valorbox.Text = row.Cells("N_Valor").Value.ToString()
            Dim tipoNome As String = row.Cells("TN_Nome").Value.ToString()
            Dim idx As Integer = TNBox.FindStringExact(tipoNome)
            If idx >= 0 Then TNBox.SelectedIndex = idx
            novoNo = False
            btngravartn.Text = "Gravar"
        End If
    End Sub

    Private Sub btnapagartn_Click(sender As Object, e As EventArgs) Handles btnapagartn.Click
        If DataGridView1.CurrentRow Is Nothing OrElse DataGridView1.CurrentRow.Index < 0 Then
            MessageBox.Show("Selecione um nó para eliminar.")
            Exit Sub
        End If

        If MessageBox.Show("Pretende eliminar o nó selecionado?", "Eliminar Nó", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim nCod As String = DataGridView1.CurrentRow.Cells("N_Cod").Value.ToString()
            MyNo.sql_NO_DEL(nCod)
            Dim cfid As Integer = 0
            If Integer.TryParse(txtcfid.Text, cfid) Then
                Me.DataGridView1.DataSource = MyNo.sql_NO_SELLCF(cfid)
            Else
                Me.DataGridView1.DataSource = Nothing
            End If
            LimpaCamposNo()
            novoNo = True

        End If
        PrepararParaInserirNo()

    End Sub

    Private Sub MyNo_Action(ByVal status As Integer) Handles MyNo.Action
        If status = 6 Then
            MessageBox.Show("Nó eliminado com sucesso.", "Nó", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub MyNo_Errors(ByVal msg As Object) Handles MyNo.Errors
        Dim mensagem As String = msg.ToString()
        If mensagem.Contains("REFERENCE constraint") OrElse mensagem.Contains("conflicted with the REFERENCE constraint") Then
            MessageBox.Show("Não pode apagar o nó porque existe uma análise associada.", "Erro ao eliminar nó", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show(mensagem, "Erro ao eliminar nó", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class