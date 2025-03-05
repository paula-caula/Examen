<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroProductos
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        RichTextBox1 = New RichTextBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(317, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 23)
        Label1.TabIndex = 0
        Label1.Text = "Inventario"
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(235, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(235, 91)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Location = New Point(235, 223)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(151, 23)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Enabled = False
        TextBox4.Location = New Point(235, 252)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(151, 23)
        TextBox4.TabIndex = 9
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Enabled = False
        RichTextBox1.Location = New Point(235, 120)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(151, 97)
        RichTextBox1.TabIndex = 10
        RichTextBox1.Text = ""
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(410, 65)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(426, 210)
        DataGridView1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.OrangeRed
        Button1.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(505, 300)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 36)
        Button1.TabIndex = 12
        Button1.Text = "Nuevo"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.OrangeRed
        Button2.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(641, 300)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 36)
        Button2.TabIndex = 13
        Button2.Text = "Guardar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.OrangeRed
        Button3.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Location = New Point(135, 315)
        Button3.Name = "Button3"
        Button3.Size = New Size(162, 46)
        Button3.TabIndex = 14
        Button3.Text = "Otras Acciones"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.OrangeRed
        Button4.Enabled = False
        Button4.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Location = New Point(31, 385)
        Button4.Name = "Button4"
        Button4.Size = New Size(113, 35)
        Button4.TabIndex = 15
        Button4.Text = "Modificar"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.OrangeRed
        Button5.Enabled = False
        Button5.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button5.ForeColor = SystemColors.ButtonFace
        Button5.Location = New Point(161, 385)
        Button5.Name = "Button5"
        Button5.Size = New Size(113, 35)
        Button5.TabIndex = 16
        Button5.Text = "Eliminar"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.OrangeRed
        Button6.Enabled = False
        Button6.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button6.ForeColor = SystemColors.ButtonFace
        Button6.Location = New Point(291, 385)
        Button6.Name = "Button6"
        Button6.Size = New Size(113, 35)
        Button6.TabIndex = 17
        Button6.Text = "Buscar"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.OrangeRed
        Button7.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Button7.ForeColor = SystemColors.ButtonFace
        Button7.Location = New Point(723, 385)
        Button7.Name = "Button7"
        Button7.Size = New Size(113, 35)
        Button7.TabIndex = 18
        Button7.Text = "Salir"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Label6.Location = New Point(171, 257)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 18)
        Label6.TabIndex = 29
        Label6.Text = "Stock"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Label5.Location = New Point(161, 226)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 18)
        Label5.TabIndex = 28
        Label5.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Label4.Location = New Point(111, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 18)
        Label4.TabIndex = 27
        Label4.Text = "Descripción"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Label3.Location = New Point(31, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 18)
        Label3.TabIndex = 26
        Label3.Text = "Nombre del Producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Courier New", 12F, FontStyle.Bold)
        Label2.Location = New Point(111, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 18)
        Label2.TabIndex = 25
        Label2.Text = "ID Producto"
        ' 
        ' RegistroProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(868, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(RichTextBox1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "RegistroProductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegistroProductos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
