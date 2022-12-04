Imports System.Data.SqlClient
Imports Capa_Datos

Public Class Profesor
    Dim obj_BD As BD
    Dim lista_parametros As List(Of Parametros)
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqlAdapter As SqlDataAdapter
    Private _codigo, _cedula, _nombre, _apellido, _direccion, _celular,
        _correo, _cod_facultad, _cod_categoria, _salario_base, _estatus As String


    Public Sub New()

        obj_BD = New BD()
        lista_parametros = New List(Of Parametros)
        connection = obj_BD.conexion
        _codigo = ""
        _cedula = ""
        _nombre = ""
        _apellido = ""
        _direccion = ""
        _celular = ""
        _correo = ""
        _cod_facultad = ""
        _cod_categoria = ""
        _salario_base = ""
        _estatus = ""
    End Sub
    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    Public Property cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property
    Public Property celular As String
        Get
            Return _celular
        End Get
        Set(value As String)
            _celular = value
        End Set
    End Property
    Public Property correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property
    Public Property cod_facultad As String
        Get
            Return _cod_facultad
        End Get
        Set(value As String)
            _cod_facultad = value
        End Set
    End Property
    Public Property cod_categoria As String
        Get
            Return _cod_categoria
        End Get
        Set(value As String)
            _cod_categoria = value
        End Set
    End Property
    Public Property salario_base As String
        Get
            Return _salario_base
        End Get
        Set(value As String)
            _salario_base = value
        End Set
    End Property
    Public Property estatus As String
        Get
            Return _estatus
        End Get
        Set(value As String)
            _estatus = value
        End Set
    End Property

    Public Function listar() As DataSet
        Dim ds As New DataSet

        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@order", "cedula"))
        ds = obj_BD.sp_reader("sp_Profesor_Select", lista_parametros)
        ds.Tables(0).Columns.Remove("id")
        ds.Tables(0).Columns.Remove("id1")
        ds.Tables(0).Columns.Remove("id2")
        ds.Tables(0).Columns.Remove("cod_facultad")
        ds.Tables(0).Columns.Remove("codigo_cat")
        ds.Tables(0).Columns.Remove("codigo_fac")
        ds.Tables(0).Columns.Remove("cod_categoria")
        Return ds
    End Function

    Public Function buscar(codigo As String) As Boolean

        Dim ds As New DataSet
        Dim encontrado As Boolean

        _codigo = codigo
        Try
            lista_parametros.Clear()
            lista_parametros.Add(New Parametros("@codigo", _codigo))
            ds = obj_BD.sp_reader("sp_Profesor_Select", lista_parametros)

            If ds.Tables(0).Rows.Count > 0 Then
                encontrado = True
                _cedula = ds.Tables(0).Rows(0).Item("cedula")
                _nombre = ds.Tables(0).Rows(0).Item("nombre")
                _apellido = ds.Tables(0).Rows(0).Item("apellido")
                _direccion = ds.Tables(0).Rows(0).Item("direccion")
                _celular = ds.Tables(0).Rows(0).Item("celular")
                _correo = ds.Tables(0).Rows(0).Item("correo")
                _cod_facultad = ds.Tables(0).Rows(0).Item("cod_facultad")
                _cod_categoria = ds.Tables(0).Rows(0).Item("cod_categoria")
                _salario_base = ds.Tables(0).Rows(0).Item("salario_base")
                _estatus = ds.Tables(0).Rows(0).Item("estatus")
            Else
                encontrado = False
                _cedula = ""
                _nombre = ""
                _apellido = ""
                _direccion = ""
                _celular = ""
                _correo = ""
                _cod_facultad = ""
                _cod_categoria = ""
                _salario_base = ""
                _estatus = ""
            End If
            Return encontrado

        Catch ex As Exception
            MsgBox("error" & ex.ToString)
        Finally
            connection.Close()
        End Try
    End Function

    Public Function Agregar() As Boolean
        asignar_parametros()
        Return obj_BD.sp_NoQuery("sp_Profesor_Insert", lista_parametros)

    End Function

    Public Function modificar() As Boolean
        asignar_parametros()
        Return obj_BD.sp_NoQuery("sp_Profesor_Update", lista_parametros)
    End Function

    Public Function eliminar() As Boolean
        MsgBox("elimino en la clase")
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@cedula", _cedula))
        Return obj_BD.sp_NoQuery("sp_Profesor_Delete", lista_parametros)

    End Function

    Private Sub asignar_parametros()
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@codigo", _codigo))
        lista_parametros.Add(New Parametros("@cedula", _cedula))
        lista_parametros.Add(New Parametros("@nombre", _nombre))
        lista_parametros.Add(New Parametros("@apellido", _apellido))
        lista_parametros.Add(New Parametros("@direccion", _direccion))
        lista_parametros.Add(New Parametros("@correo", _correo))
        lista_parametros.Add(New Parametros("@celular", _celular))
        lista_parametros.Add(New Parametros("@cod_facultad", _cod_facultad))
        lista_parametros.Add(New Parametros("@cod_categoria", _cod_categoria))
        lista_parametros.Add(New Parametros("@salario_base", _salario_base))
        lista_parametros.Add(New Parametros("@estatus", _estatus))

    End Sub
End Class
