Imports System.Data.SQLite

Public Class ModificarProductos
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        ' Cadena de conexión a la base de datos SQLite
        Dim connectionString = "datasource=c:\inventario\bdinventario.db;version=3;"

        Using conexion As New SQLiteConnection(connectionString)
            Try

                conexion.Open()

                ' Crear el comando SQL para seleccionar todos los productos
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New SQLiteConnection("Data Source=c:\inventario\bdinventario.db;Version=3;")

        Try
            conexion.Open()
            ' Crear un comando para ejecutar una consulta SQL de actualización
            Dim comando As New SQLiteCommand("UPDATE Productos SET nombreproducto=@nombreproducto, descripcion=@descripcion, precio=@precio, stock=@stock WHERE IDProducto=@IDProducto", conexion)
            comando.Parameters.AddWithValue("@IDProducto", TextBox1.Text)
            comando.Parameters.AddWithValue("@nombreproducto", TextBox2.Text)
            comando.Parameters.AddWithValue("@descripcion", RichTextBox1.Text)
            comando.Parameters.AddWithValue("@precio", TextBox3.Text)
            comando.Parameters.AddWithValue("@stock", TextBox4.Text)
            comando.ExecuteNonQuery()

            MsgBox("Producto modificado correctamente")
        Catch ex As Exception
            MessageBox.Show("Error al modificar el producto: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        ' Desactivar campos y recargar la grilla
        desactivar()
        cargargrilla()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBox1.Text = row.Cells("IdProducto").Value.ToString()
            TextBox2.Text = row.Cells("Nombreproducto").Value.ToString()
            RichTextBox1.Text = row.Cells("Descripción").Value.ToString()
            TextBox3.Text = row.Cells("Precio").Value.ToString()
            TextBox4.Text = row.Cells("Stock").Value.ToString()

            TextBox1.Enabled = True
            TextBox2.Enabled = True
            RichTextBox1.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
        End If
    End Sub


    Private Sub ModificarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrilla()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class