Imports System.Data.SQLite

Public Class RegistroProductos

    Private Sub cargargrilla()
        Dim conexion As New SQLiteConnection("datasource=c:\inventario\bdinventario.db;version=3;")

        Try
            conexion.Open()
            DataGridView1.Columns.Clear()
            DataGridView1.Rows.Clear()

            Dim comando As New SQLiteCommand("SELECT * FROM Productos", conexion)
            Dim lector As SQLiteDataReader = comando.ExecuteReader()

            DataGridView1.Columns.Add("IdProducto", "IdProducto")
            DataGridView1.Columns.Add("Nombreproducto", "Nombreproducto")
            DataGridView1.Columns.Add("Descripción", "Descripción")
            DataGridView1.Columns.Add("Precio", "Precio")
            DataGridView1.Columns.Add("Stock", "Stock")

            While lector.Read()
                DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
        Catch ex As Exception
            MessageBox.Show("Error al cargar la grilla: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private Sub desactivar()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        RichTextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        Button3.Enabled = True
    End Sub

    Private Sub RegistroProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrilla()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        desactivar()

        Dim conexion As New SQLiteConnection("datasource=c:\inventario\bdinventario.db;version=3;")
        conexion.Open()
        ' Guardar un nuevo producto
        Dim comando As New SQLiteCommand("INSERT INTO Productos(IDproducto, nombreproducto, descripcion, precio, stock) VALUES (@IDproducto, @nombreproducto, @descripcion, @precio, @stock)", conexion)
        comando.Parameters.AddWithValue("@IDproducto", TextBox1.Text)
        comando.Parameters.AddWithValue("@nombreproducto", TextBox2.Text)
        comando.Parameters.AddWithValue("@descripcion", RichTextBox1.Text)
        comando.Parameters.AddWithValue("@precio", TextBox3.Text)
        comando.Parameters.AddWithValue("@stock", TextBox4.Text)
        comando.ExecuteNonQuery()
        MsgBox("Producto registrado correctamente")

        conexion.Close()

    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        'cuando recibe el foco el textbox selecciono todo el texto
        TextBox1.SelectAll()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'cuando presiona enter pasa al siguiente control
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
        End If

    End Sub
    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        TextBox2.SelectAll()
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()
        End If
    End Sub
    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        TextBox3.SelectAll()
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox4.Focus()
        End If
    End Sub
    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        TextBox4.SelectAll()
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox4.Focus()
        End If
    End Sub
    Private Sub Richtext1_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox1.GotFocus
        RichTextBox1.SelectAll()
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button2.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        RichTextBox1.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        cargargrilla()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        Dim connectionString = "datasource=c:\inventario\bdinventario.db;version=3;"

        Using conexion As New SQLiteConnection(connectionString)
            Try
                conexion.Open()
                Dim comando As New SQLiteCommand("SELECT * FROM Productos", conexion)
                Dim lector = comando.ExecuteReader

                ' Agregar las columnas al DataGridView, si no tiene columnas
                DataGridView1.Columns.Add("IdProducto", "IdProducto")
                DataGridView1.Columns("IdProducto").Width = 70
                DataGridView1.Columns.Add("NombreProducto", "NombreProducto")
                DataGridView1.Columns("NombreProducto").Width = 200
                DataGridView1.Columns.Add("Descripcion", "Descripcion")
                DataGridView1.Columns("Descripcion").Width = 330
                DataGridView1.Columns.Add("Precio", "Precio")
                DataGridView1.Columns("Precio").Width = 100
                DataGridView1.Columns.Add("Stock", "Stock")
                DataGridView1.Columns("Stock").Width = 100

                ' Leer los datos del lector y agregarlos a las filas del DataGridView
                While lector.Read
                    DataGridView1.Rows.Add(lector("IdProducto"), lector("NombreProducto"), lector("Descripcion"), lector("Precio"), lector("Stock"))
                End While

            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        RichTextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Eliminarproductos.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ModificarProductos.ShowDialog()
    End Sub
End Class