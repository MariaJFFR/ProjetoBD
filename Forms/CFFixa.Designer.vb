<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CFFixa
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
        Me.VALORBOX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NOMEBOX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IDBOX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(683, 524)
        Me.DataGridView1.TabIndex = 0
        '
        'VALORBOX
        '
        Me.VALORBOX.Enabled = False
        Me.VALORBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.VALORBOX.Location = New System.Drawing.Point(781, 406)
        Me.VALORBOX.Margin = New System.Windows.Forms.Padding(4)
        Me.VALORBOX.Name = "VALORBOX"
        Me.VALORBOX.Size = New System.Drawing.Size(132, 30)
        Me.VALORBOX.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(781, 378)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Valor:"
        '
        'NOMEBOX
        '
        Me.NOMEBOX.Enabled = False
        Me.NOMEBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NOMEBOX.Location = New System.Drawing.Point(781, 273)
        Me.NOMEBOX.Margin = New System.Windows.Forms.Padding(4)
        Me.NOMEBOX.Name = "NOMEBOX"
        Me.NOMEBOX.Size = New System.Drawing.Size(155, 30)
        Me.NOMEBOX.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(781, 245)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nome:"
        '
        'IDBOX
        '
        Me.IDBOX.Enabled = False
        Me.IDBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.IDBOX.Location = New System.Drawing.Point(781, 151)
        Me.IDBOX.Margin = New System.Windows.Forms.Padding(4)
        Me.IDBOX.Name = "IDBOX"
        Me.IDBOX.Size = New System.Drawing.Size(132, 30)
        Me.IDBOX.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(776, 123)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID:"
        '
        'CFFixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.VALORBOX)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NOMEBOX)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IDBOX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CFFixa"
        Me.Text = "CFFixa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VALORBOX As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NOMEBOX As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IDBOX As TextBox
    Friend WithEvents Label1 As Label
End Class
