<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoFixa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodBox = New System.Windows.Forms.TextBox()
        Me.TNCodBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CFIDBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ValorBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(681, 524)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(727, 119)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo:"
        '
        'CodBox
        '
        Me.CodBox.Enabled = False
        Me.CodBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CodBox.Location = New System.Drawing.Point(732, 148)
        Me.CodBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CodBox.Name = "CodBox"
        Me.CodBox.Size = New System.Drawing.Size(132, 30)
        Me.CodBox.TabIndex = 2
        '
        'TNCodBox
        '
        Me.TNCodBox.Enabled = False
        Me.TNCodBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TNCodBox.Location = New System.Drawing.Point(732, 231)
        Me.TNCodBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TNCodBox.Name = "TNCodBox"
        Me.TNCodBox.Size = New System.Drawing.Size(155, 30)
        Me.TNCodBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(727, 203)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Codigo Tipo No:"
        '
        'CFIDBox
        '
        Me.CFIDBox.Enabled = False
        Me.CFIDBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CFIDBox.Location = New System.Drawing.Point(732, 316)
        Me.CFIDBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CFIDBox.Name = "CFIDBox"
        Me.CFIDBox.Size = New System.Drawing.Size(155, 30)
        Me.CFIDBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(732, 288)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ID ClienteFinal:"
        '
        'ValorBox
        '
        Me.ValorBox.Enabled = False
        Me.ValorBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ValorBox.Location = New System.Drawing.Point(732, 402)
        Me.ValorBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ValorBox.Name = "ValorBox"
        Me.ValorBox.Size = New System.Drawing.Size(132, 30)
        Me.ValorBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(732, 374)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Valor:"
        '
        'NoFixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.ValorBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CFIDBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TNCodBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CodBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "NoFixa"
        Me.Text = "NoFixa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CodBox As TextBox
    Friend WithEvents TNCodBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CFIDBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ValorBox As TextBox
    Friend WithEvents Label4 As Label
End Class
