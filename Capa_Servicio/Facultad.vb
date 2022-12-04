Imports System.Data.SqlClient
Imports Capa_Datos
Imports System.Windows.Forms

Public Class Facultad
    Dim obj_BD As BD
    Dim lista_parametros As List(Of Parametros)
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqlAdapter As SqlDataAdapter
    Private _id, _codigo_fac, _facultad As String

    Public Sub New()
        obj_BD = New BD()
        lista_parametros = New List(Of Parametros)
        connection = obj_BD.conexion
        _id = ""
        _codigo_fac = ""
        _facultad = ""
    End Sub

    Public Property id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property codigo As String
        Get
            Return _codigo_fac
        End Get
        Set(value As String)
            _codigo_fac = value
        End Set
    End Property
    Public Property facultad As String
        Get
            Return _facultad
        End Get
        Set(value As String)
            _facultad = value
        End Set
    End Property

    Public Function cargar(ByRef cb As ComboBox) As DataSet
        cb.DataSource = obj_BD.sp_reader("sp_Facultad_Select").Tables(0)
        cb.DisplayMember = "facultad"
        cb.ValueMember = "codigo_fac"

    End Function

    'Mostrar carreras de la facultad seleccionada en el combobox'
    Public Function cargar_carreras(ByRef cb As ComboBox, ByVal codigo_fac As String) As DataSet
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@codigo_fac", codigo_fac))
        cb.DataSource = obj_BD.sp_reader("sp_carrera_SelectByFacultad", lista_parametros).Tables(0)
        cb.DisplayMember = "carrera"
        cb.ValueMember = "codigo_carrera"
    End Function


End Class
