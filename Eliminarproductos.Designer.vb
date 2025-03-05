<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminarproductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(262, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 23)
        Label1.TabIndex = 0
        Label1.Text = "Eliminar Productos"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(190, 61)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(556, 266)
        DataGridView1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.OrangeRed
        Button1.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.Window
        Button1.Location = New Point(190, 349)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 39)
        Button1.TabIndex = 2
        Button1.Text = "Eliminar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.OrangeRed
        Button2.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.Window
        Button2.Location = New Point(38, 176)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 39)
        Button2.TabIndex = 3
        Button2.Text = "Buscar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 18)
        Label2.TabIndex = 4
        Label2.Text = "Buscar por ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(22, 137)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(145, 23)
        TextBox1.TabIndex = 5
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.OrangeRed
        Button3.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.Window
        Button3.Location = New Point(634, 349)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 39)
        Button3.TabIndex = 6
        Button3.Text = "Salir"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Eliminarproductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(773, 435)
        Controls.Add(Button3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Eliminarproductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Eliminarproductos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
End Class
