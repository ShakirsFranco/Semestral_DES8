Imports System.Data.SqlClient
Public Class BD
    Dim connectionString As String
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqlAdapter As SqlDataAdapter

    Public Sub New()
        connectionString = "Data Source=SHAKIRSF02\SQLEXPRESS;Initial Catalog=UTP_1;User ID=Shakirs_Franco;Password=0000"
        connection = New SqlConnection(connectionString)
    End Sub

    Public Function conexion() As SqlConnection
        Return connection
    End Function


    Public Function executeReader(sql As String) As DataSet
        Dim ds As New DataSet
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("error al conectar con la base de datos")
        Finally
            connection.Close()
        End Try
    End Function


    Public Function executeNoQuery(sql As String) As Boolean
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            command.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox("error al abrir la base de datos")
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function listar() As DataSet
        Dim ds As New DataSet

        Try
            connection.Open()
            command = New SqlCommand("sp_Estudiante_Select", connection)
            command.CommandType = CommandType.StoredProcedure
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("error al listar estudiantes")
        Finally
            connection.Close()
        End Try

    End Function

    Public Function listar_Profesores() As DataSet
        Dim ds As New DataSet

        Try
            connection.Open()
            command = New SqlCommand("sp_Profesor_Select", connection)
            command.CommandType = CommandType.StoredProcedure
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("error al listar profesores")
        Finally
            connection.Close()
        End Try

    End Function

    Public Function buscar(cedula As String) As DataSet
        Dim ds As New DataSet

        Try
            connection.Open()
            command = New SqlCommand("sp_Estudiante_Select", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cedula", cedula)
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("error al buscar estudiantes")
        Finally
            connection.Close()
        End Try
    End Function

    Public Function Agregar(cedula As String, nombre As String, Apellido As String, direccion As String, celular As String, correo As String,
                            cod_facultad As String, cod_carrera As String, indice_academico As String, sexo As String, estatus As String) As Boolean
        Try
            connection.Open()
            command = New SqlCommand("sp_Cliente_Insert", connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cedula", cedula)
            command.Parameters.AddWithValue("@nombre", nombre)
            command.Parameters.AddWithValue("@apellido", Apellido)
            command.Parameters.AddWithValue("@direccion", direccion)
            command.Parameters.AddWithValue("@celular", celular)
            command.Parameters.AddWithValue("@correo", correo)
            command.Parameters.AddWithValue("@cod_fcultad", cod_facultad)
            command.Parameters.AddWithValue("@cod_carrera", cod_carrera)
            command.Parameters.AddWithValue("@indice_academico", indice_academico)
            command.Parameters.AddWithValue("@sexo", sexo)
            command.Parameters.AddWithValue("@estatus", estatus)

            command.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch ex As Exception
            MsgBox("error al agregar estudiantes")
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function sp_reader(nombre_sp As String) As DataSet
        Dim ds As New DataSet()
        Try
            connection.Open()
            command = New SqlCommand(nombre_sp, connection)
            command.CommandType = CommandType.StoredProcedure
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("error" & ex.ToString)
        Finally
            connection.Close()
        End Try
    End Function


    Public Function sp_reader(nombre_sp As String, lista_parametro As List(Of Parametros)) As DataSet
        Dim ds As New DataSet()

        Try
            connection.Open()
            command = New SqlCommand(nombre_sp, connection)
            command.CommandType = CommandType.StoredProcedure
            For Each p As Parametros In lista_parametro
                command.Parameters.AddWithValue(p.campo, p.valor)
            Next
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("error" & ex.ToString)
        Finally
            connection.Close()
        End Try
    End Function

    Public Function sp_NoQuery(nombre_sp As String, lista_parametros As List(Of Parametros)) As Boolean
        Try
            connection.Open()
            command = New SqlCommand(nombre_sp, connection)
            command.CommandType = CommandType.StoredProcedure
            For Each p As Parametros In lista_parametros
                command.Parameters.AddWithValue(p.campo, p.valor)
            Next
            command.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox("error" & ex.ToString)
            Return False
        Finally
            connection.Close()
        End Try

    End Function
End Class
