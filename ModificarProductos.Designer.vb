<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProductos
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
        Button2 = New Button()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        RichTextBox1 = New RichTextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.OrangeRed
        Button2.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(228, 322)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 36)
        Button2.TabIndex = 32
        Button2.Text = "Buscar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.OrangeRed
        Button1.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(521, 322)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 36)
        Button1.TabIndex = 31
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(401, 75)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(405, 215)
        DataGridView1.TabIndex = 30
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(228, 133)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(151, 97)
        RichTextBox1.TabIndex = 29
        RichTextBox1.Text = ""
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(228, 267)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(151, 23)
        TextBox4.TabIndex = 28
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(228, 236)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(151, 23)
        TextBox3.TabIndex = 27
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(228, 104)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 23)
        TextBox2.TabIndex = 26
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(228, 75)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 23)
        TextBox1.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Label6.Location = New Point(164, 272)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 18)
        Label6.TabIndex = 24
        Label6.Text = "Stock"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Label5.Location = New Point(154, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 18)
        Label5.TabIndex = 23
        Label5.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Label4.Location = New Point(104, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 18)
        Label4.TabIndex = 22
        Label4.Text = "Descripción"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Label3.Location = New Point(24, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 18)
        Label3.TabIndex = 21
        Label3.Text = "Nombre del Producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Label2.Location = New Point(104, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 18)
        Label2.TabIndex = 20
        Label2.Text = "ID Producto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(277, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 23)
        Label1.TabIndex = 19
        Label1.Text = "Modificar Productos"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.OrangeRed
        Button3.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(674, 322)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 36)
        Button3.TabIndex = 33
        Button3.Text = "Cancelar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ModificarProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(837, 389)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(RichTextBox1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ModificarProductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModificarProductos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
