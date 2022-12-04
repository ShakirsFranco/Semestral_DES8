Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Capa_Datos
Public Class Categoria
    Dim obj_BD As BD
    Dim lista_parametros As List(Of Parametros)
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqlAdapter As SqlDataAdapter
    Private _id, _categoria As String

    Public Sub New()
        obj_BD = New BD()
        lista_parametros = New List(Of Parametros)
        connection = obj_BD.conexion
        _id = ""
        _categoria = ""

    End Sub

    Public Property id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Function cargar(ByRef cb As ComboBox) As DataSet
        cb.DataSource = obj_BD.sp_reader("sp_categoria_Select").Tables(0)
        cb.DisplayMember = "categoria"
        cb.ValueMember = "codigo_cat"

    End Function


End Class
