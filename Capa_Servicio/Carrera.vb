Imports System.Data.SqlClient
Imports Capa_Datos
Imports System.Windows.Forms


Public Class carrera

    Dim obj_BD As BD
    Dim lista_parametros As List(Of Parametros)
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqlAdapter As SqlDataAdapter
    Private _id, _cod_fac, _codigo_carrera, _carrera As String

    Public Sub New()
        obj_BD = New BD()
        lista_parametros = New List(Of Parametros)
        connection = obj_BD.conexion
        _id = ""
        _cod_fac = ""
        _codigo_carrera = ""
        _carrera = ""

    End Sub

    Public Property id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property cod_fac As String
        Get
            Return _cod_fac
        End Get
        Set(value As String)
            _cod_fac = value
        End Set
    End Property
    Public Property cod_carrera As String
        Get
            Return _codigo_carrera
        End Get
        Set(value As String)
            _codigo_carrera = value
        End Set
    End Property
    Public Property carrera As String
        Get
            Return _carrera
        End Get
        Set(value As String)
            _carrera = value
        End Set

    End Property


    Public Function cargar(ByRef cb As ComboBox) As DataSet
        cb.DataSource = obj_BD.sp_reader("sp_carrera_Select").Tables(0)
        cb.DisplayMember = "carrera"
        cb.ValueMember = "codigo_carrera"
    End Function


End Class

