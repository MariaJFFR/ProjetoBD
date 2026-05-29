<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EMPRnome = New System.Windows.Forms.TextBox()
        Me.EMPRnif = New System.Windows.Forms.TextBox()
        Me.EMPRmorada = New System.Windows.Forms.TextBox()
        Me.EMPRtelefone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.No = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteFinal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadroNosClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIR = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EMPRnome
        '
        Me.EMPRnome.BackColor = System.Drawing.Color.Indigo
        Me.EMPRnome.Enabled = False
        Me.EMPRnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.EMPRnome.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.EMPRnome.Location = New System.Drawing.Point(115, 123)
        Me.EMPRnome.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EMPRnome.Name = "EMPRnome"
        Me.EMPRnome.Size = New System.Drawing.Size(346, 35)
        Me.EMPRnome.TabIndex = 2
        '
        'EMPRnif
        '
        Me.EMPRnif.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.EMPRnif.Enabled = False
        Me.EMPRnif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.EMPRnif.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.EMPRnif.Location = New System.Drawing.Point(115, 182)
        Me.EMPRnif.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EMPRnif.Name = "EMPRnif"
        Me.EMPRnif.Size = New System.Drawing.Size(346, 26)
        Me.EMPRnif.TabIndex = 1
        '
        'EMPRmorada
        '
        Me.EMPRmorada.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.EMPRmorada.Enabled = False
        Me.EMPRmorada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.EMPRmorada.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.EMPRmorada.Location = New System.Drawing.Point(115, 231)
        Me.EMPRmorada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EMPRmorada.Name = "EMPRmorada"
        Me.EMPRmorada.Size = New System.Drawing.Size(346, 26)
        Me.EMPRmorada.TabIndex = 2
        '
        'EMPRtelefone
        '
        Me.EMPRtelefone.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.EMPRtelefone.Enabled = False
        Me.EMPRtelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.EMPRtelefone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EMPRtelefone.Location = New System.Drawing.Point(115, 280)
        Me.EMPRtelefone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EMPRtelefone.Name = "EMPRtelefone"
        Me.EMPRtelefone.Size = New System.Drawing.Size(346, 26)
        Me.EMPRtelefone.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Label1.Location = New System.Drawing.Point(224, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Grupo 07"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu, Me.AcercaDe})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menu
        '
        Me.Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.No, Me.ClienteFinal, Me.QuadroNosClienteToolStripMenuItem, Me.SAIR})
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(50, 20)
        Me.Menu.Text = "Menu"
        '
        'No
        '
        Me.No.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaToolStripMenuItem, Me.FichaToolStripMenuItem})
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(180, 22)
        Me.No.Text = "No"
        '
        'ListaToolStripMenuItem
        '
        Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ListaToolStripMenuItem.Text = "Lista"
        '
        'FichaToolStripMenuItem
        '
        Me.FichaToolStripMenuItem.Name = "FichaToolStripMenuItem"
        Me.FichaToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.FichaToolStripMenuItem.Text = "Ficha"
        '
        'ClienteFinal
        '
        Me.ClienteFinal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaToolStripMenuItem1, Me.FichaToolStripMenuItem1})
        Me.ClienteFinal.Name = "ClienteFinal"
        Me.ClienteFinal.Size = New System.Drawing.Size(180, 22)
        Me.ClienteFinal.Text = "ClienteFinal"
        '
        'ListaToolStripMenuItem1
        '
        Me.ListaToolStripMenuItem1.Name = "ListaToolStripMenuItem1"
        Me.ListaToolStripMenuItem1.Size = New System.Drawing.Size(102, 22)
        Me.ListaToolStripMenuItem1.Text = "Lista"
        '
        'FichaToolStripMenuItem1
        '
        Me.FichaToolStripMenuItem1.Name = "FichaToolStripMenuItem1"
        Me.FichaToolStripMenuItem1.Size = New System.Drawing.Size(102, 22)
        Me.FichaToolStripMenuItem1.Text = "Ficha"
        '
        'QuadroNosClienteToolStripMenuItem
        '
        Me.QuadroNosClienteToolStripMenuItem.Name = "QuadroNosClienteToolStripMenuItem"
        Me.QuadroNosClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuadroNosClienteToolStripMenuItem.Text = "Quadro NosCliente"
        '
        'SAIR
        '
        Me.SAIR.Name = "SAIR"
        Me.SAIR.Size = New System.Drawing.Size(180, 22)
        Me.SAIR.Text = "SAIR"
        '
        'AcercaDe
        '
        Me.AcercaDe.Name = "AcercaDe"
        Me.AcercaDe.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDe.Text = "Acerca de"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EMPRtelefone)
        Me.Controls.Add(Me.EMPRmorada)
        Me.Controls.Add(Me.EMPRnif)
        Me.Controls.Add(Me.EMPRnome)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EMPRnome As TextBox
    Friend WithEvents EMPRnif As TextBox
    Friend WithEvents EMPRmorada As TextBox
    Friend WithEvents EMPRtelefone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Menu As ToolStripMenuItem
    Friend WithEvents No As ToolStripMenuItem
    Friend WithEvents ClienteFinal As ToolStripMenuItem
    Friend WithEvents SAIR As ToolStripMenuItem
    Friend WithEvents AcercaDe As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FichaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FichaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuadroNosClienteToolStripMenuItem As ToolStripMenuItem
End Class
