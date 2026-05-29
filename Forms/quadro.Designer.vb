<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quadro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcfvalor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcfnome = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcfid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NCodBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.valorbox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TNBox = New System.Windows.Forms.ComboBox()
        Me.ClrNo = New System.Windows.Forms.Button()
        Me.btneditartn = New System.Windows.Forms.Button()
        Me.btnbusca = New System.Windows.Forms.Button()
        Me.btngravartn = New System.Windows.Forms.Button()
        Me.btnapagartn = New System.Windows.Forms.Button()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btngravar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(51, 232)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1069, 361)
        Me.DataGridView1.TabIndex = 4
        '
        'txtcfvalor
        '
        Me.txtcfvalor.Location = New System.Drawing.Point(98, 162)
        Me.txtcfvalor.Name = "txtcfvalor"
        Me.txtcfvalor.ReadOnly = True
        Me.txtcfvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtcfvalor.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Valor"
        '
        'txtcfnome
        '
        Me.txtcfnome.Location = New System.Drawing.Point(98, 111)
        Me.txtcfnome.Name = "txtcfnome"
        Me.txtcfnome.Size = New System.Drawing.Size(100, 20)
        Me.txtcfnome.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nome:"
        '
        'txtcfid
        '
        Me.txtcfid.Enabled = False
        Me.txtcfid.Location = New System.Drawing.Point(98, 59)
        Me.txtcfid.Name = "txtcfid"
        Me.txtcfid.ReadOnly = True
        Me.txtcfid.Size = New System.Drawing.Size(100, 20)
        Me.txtcfid.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "CF ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(145, 604)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Codigo:"
        '
        'NCodBox
        '
        Me.NCodBox.Location = New System.Drawing.Point(148, 620)
        Me.NCodBox.Name = "NCodBox"
        Me.NCodBox.Size = New System.Drawing.Size(70, 20)
        Me.NCodBox.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(462, 603)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "TipoNo:"
        '
        'valorbox
        '
        Me.valorbox.Location = New System.Drawing.Point(749, 623)
        Me.valorbox.Name = "valorbox"
        Me.valorbox.Size = New System.Drawing.Size(100, 20)
        Me.valorbox.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(631, 606)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(746, 607)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Valor:"
        '
        'TNBox
        '
        Me.TNBox.FormattingEnabled = True
        Me.TNBox.Location = New System.Drawing.Point(465, 620)
        Me.TNBox.Name = "TNBox"
        Me.TNBox.Size = New System.Drawing.Size(121, 21)
        Me.TNBox.TabIndex = 29
        '
        'ClrNo
        '
        Me.ClrNo.Location = New System.Drawing.Point(51, 617)
        Me.ClrNo.Name = "ClrNo"
        Me.ClrNo.Size = New System.Drawing.Size(35, 23)
        Me.ClrNo.TabIndex = 30
        Me.ClrNo.Text = "Clr"
        Me.ClrNo.UseVisualStyleBackColor = True
        '
        'btneditartn
        '
        Me.btneditartn.Location = New System.Drawing.Point(1012, 620)
        Me.btneditartn.Name = "btneditartn"
        Me.btneditartn.Size = New System.Drawing.Size(69, 23)
        Me.btneditartn.TabIndex = 31
        Me.btneditartn.Text = "Modificar"
        Me.btneditartn.UseVisualStyleBackColor = True
        '
        'btnbusca
        '
        Me.btnbusca.Location = New System.Drawing.Point(17, 10)
        Me.btnbusca.Name = "btnbusca"
        Me.btnbusca.Size = New System.Drawing.Size(75, 23)
        Me.btnbusca.TabIndex = 32
        Me.btnbusca.Text = "busca"
        Me.btnbusca.UseVisualStyleBackColor = True
        '
        'btngravartn
        '
        Me.btngravartn.Location = New System.Drawing.Point(943, 620)
        Me.btngravartn.Name = "btngravartn"
        Me.btngravartn.Size = New System.Drawing.Size(63, 23)
        Me.btngravartn.TabIndex = 33
        Me.btngravartn.Text = "Gravar"
        Me.btngravartn.UseVisualStyleBackColor = True
        '
        'btnapagartn
        '
        Me.btnapagartn.Location = New System.Drawing.Point(1087, 621)
        Me.btnapagartn.Name = "btnapagartn"
        Me.btnapagartn.Size = New System.Drawing.Size(50, 23)
        Me.btnapagartn.TabIndex = 34
        Me.btnapagartn.Text = "Apagar"
        Me.btnapagartn.UseVisualStyleBackColor = True
        '
        'btnnovo
        '
        Me.btnnovo.Location = New System.Drawing.Point(98, 10)
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(75, 23)
        Me.btnnovo.TabIndex = 35
        Me.btnnovo.Text = "novo"
        Me.btnnovo.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(260, 10)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 37
        Me.btneliminar.Text = "eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(179, 10)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(75, 23)
        Me.btneditar.TabIndex = 36
        Me.btneditar.Text = "editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btngravar
        '
        Me.btngravar.Location = New System.Drawing.Point(422, 10)
        Me.btngravar.Name = "btngravar"
        Me.btngravar.Size = New System.Drawing.Size(75, 23)
        Me.btngravar.TabIndex = 39
        Me.btngravar.Text = "gravar"
        Me.btngravar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(341, 10)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 38
        Me.btncancelar.Text = "cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'quadro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 668)
        Me.Controls.Add(Me.btngravar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnnovo)
        Me.Controls.Add(Me.btnapagartn)
        Me.Controls.Add(Me.btngravartn)
        Me.Controls.Add(Me.btnbusca)
        Me.Controls.Add(Me.btneditartn)
        Me.Controls.Add(Me.ClrNo)
        Me.Controls.Add(Me.TNBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.valorbox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.NCodBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcfid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcfnome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcfvalor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "quadro"
        Me.Text = "quadro"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtcfvalor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcfnome As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcfid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NCodBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents valorbox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TNBox As ComboBox
    Friend WithEvents ClrNo As Button
    Friend WithEvents btneditartn As Button
    Friend WithEvents btnbusca As Button
    Friend WithEvents btngravartn As Button
    Friend WithEvents btnapagartn As Button
    Friend WithEvents btnnovo As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btngravar As Button
    Friend WithEvents btncancelar As Button
End Class
