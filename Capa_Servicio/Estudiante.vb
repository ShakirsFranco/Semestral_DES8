Imports System.Data.SqlClient
Imports Capa_Datos

Public Class Estudiante
    Dim obj_BD As BD
    Dim lista_parametros As List(Of Parametros)
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqlAdapter As SqlDataAdapter
    Private _cedula, _nombre, _apellido, _direccion, _celular,
        _correo, _cod_facultad, _cod_carrera, _indice_academico, _sexo, _estatus As String


    Public Sub New()

        obj_BD = New BD()
        lista_parametros = New List(Of Parametros)
        connection = obj_BD.conexion
        _cedula = ""
        _nombre = ""
        _apellido = ""
        _direccion = ""
        _celular = ""
        _correo = ""
        _cod_facultad = ""
        _cod_carrera = ""
        _indice_academico = ""
        _sexo = ""
        _estatus = ""
    End Sub

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
    Public Property cod_carrera As String
        Get
            Return _cod_carrera
        End Get
        Set(value As String)
            _cod_carrera = value
        End Set
    End Property
    Public Property indice_academico As String
        Get
            Return _indice_academico
        End Get
        Set(value As String)
            _indice_academico = value
        End Set
    End Property
    Public Property sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
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
        ds = obj_BD.sp_reader("sp_Estudiante_Select", lista_parametros)
        ds.Tables(0).Columns.Remove("id")
        ds.Tables(0).Columns.Remove("cod_facultad")
        ds.Tables(0).Columns.Remove("cod_carrera")
        ds.Tables(0).Columns.Remove("id1")
        ds.Tables(0).Columns.Remove("id2")
        ds.Tables(0).Columns.Remove("cod_fac")
        ds.Tables(0).Columns.Remove("codigo_carrera")
        Return ds
    End Function

    Public Function buscar(cedula As String) As Boolean

        Dim ds As New DataSet
        Dim encontrado As Boolean

        _cedula = cedula
        Try
            lista_parametros.Clear()
            lista_parametros.Add(New Parametros("@cedula", _cedula))
            ds = obj_BD.sp_reader("sp_Estudiante_Select", lista_parametros)

            If ds.Tables(0).Rows.Count > 0 Then
                encontrado = True
                _nombre = ds.Tables(0).Rows(0).Item("nombre")
                _apellido = ds.Tables(0).Rows(0).Item("apellido")
                _direccion = ds.Tables(0).Rows(0).Item("direccion")
                _celular = ds.Tables(0).Rows(0).Item("celular")
                _correo = ds.Tables(0).Rows(0).Item("correo")
                _cod_facultad = ds.Tables(0).Rows(0).Item("cod_facultad")
                _cod_carrera = ds.Tables(0).Rows(0).Item("cod_carrera")
                _indice_academico = ds.Tables(0).Rows(0).Item("indice_academico")
                _sexo = ds.Tables(0).Rows(0).Item("sexo")
                _estatus = ds.Tables(0).Rows(0).Item("estatus")
            Else
                encontrado = False
                _nombre = ""
                _apellido = ""
                _direccion = ""
                _celular = ""
                _correo = ""
                _cod_facultad = ""
                _cod_carrera = ""
                _indice_academico = ""
                _sexo = ""
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
        Return obj_BD.sp_NoQuery("sp_Estudiante_Insert", lista_parametros)

    End Function

    Public Function modificar() As Boolean
        asignar_parametros()
        Return obj_BD.sp_NoQuery("sp_Estudiante_Update", lista_parametros)
    End Function

    Public Function eliminar() As Boolean
        MsgBox("Se ha eliminado el registro")
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@cedula", _cedula))
        Return obj_BD.sp_NoQuery("sp_Estudiante_Delete", lista_parametros)

    End Function

    Private Sub asignar_parametros()
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@cedula", _cedula))
        lista_parametros.Add(New Parametros("@nombre", _nombre))
        lista_parametros.Add(New Parametros("@apellido", _apellido))
        lista_parametros.Add(New Parametros("@direccion", _direccion))
        lista_parametros.Add(New Parametros("@correo", _correo))
        lista_parametros.Add(New Parametros("@celular", _celular))
        lista_parametros.Add(New Parametros("@cod_facultad", _cod_facultad))
        lista_parametros.Add(New Parametros("@cod_carrera", _cod_carrera))
        lista_parametros.Add(New Parametros("@indice_academico", _indice_academico))
        lista_parametros.Add(New Parametros("@sexo", _sexo))
        lista_parametros.Add(New Parametros("@estatus", _estatus))

    End Sub
End Class
