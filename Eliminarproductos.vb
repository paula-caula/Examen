Imports System.Data.SQLite
Public Class Eliminarproductos
    Dim ID_producto As Integer = 0
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

    Private Sub Eliminarproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrilla()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verificar que el campo de ID no esté vacío
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Por favor, ingresa un ID válido.")
            Return
        End If

        ' Cadena de conexión a la base de datos SQLite
        Dim connectionString = "datasource=c:\inventario\bdinventario.db;version=3;"
        Using conexion As New SQLiteConnection(connectionString)
            Try
                conexion.Open()

                ' Crear el comando SQL para eliminar el registro
                Dim comando As New SQLiteCommand("DELETE FROM Productos WHERE IdProducto = @IdProducto", conexion)

                ' Asignar el valor del parámetro de ID
                comando.Parameters.AddWithValue("@IdProducto", TextBox1.Text)
                Dim resultado = comando.ExecuteNonQuery

                ' Verificar si se eliminó algún registro
                If resultado > 0 Then
                    MessageBox.Show("Registro eliminado correctamente.")
                Else
                    MessageBox.Show("No se encontró ningún registro con ese ID.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error al eliminar el registro: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        Dim connectionString As String = "datasource=c:\inventario\bdinventario.db;version=3;"

        Using conexion As New SQLiteConnection(connectionString)
            Try
                conexion.Open()

                ' Crear el comando SQL para seleccionar todos los productos
                Dim comando As New SQLiteCommand("SELECT * FROM Productos", conexion)

                ' Ejecutar el comando y obtener un lector de datos
                Dim lector As SQLiteDataReader = comando.ExecuteReader()

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
                While lector.Read()
                    DataGridView1.Rows.Add(lector("IdProducto"), lector("NombreProducto"), lector("Descripcion"), lector("Precio"), lector("Stock"))
                End While

            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class