
Imports Capa_Servicio

Public Class Frm_Estudiantes

    Dim obj_Estudiante As Estudiante = New Estudiante()
    Dim obj_Facultad As Facultad = New Facultad()
    Dim obj_carrera As carrera = New carrera()
    Dim obj_Profesor As Profesor = New Profesor()
    Dim obj_Categoria As Categoria = New Categoria()

    Public Sub New()
        InitializeComponent()
        obj_Facultad.cargar(cb_facultad)
        obj_Facultad.cargar_carreras(cb_carrera, cb_facultad.SelectedValue)
        obj_carrera.cargar(cb_carrera)
    End Sub



    Private Sub bnt_listar_Click(sender As Object, e As EventArgs) Handles bnt_listar.Click
        dgv_Cliente.DataSource = obj_Estudiante.listar().Tables(0)
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        If obj_Estudiante.buscar(txt_cedula.Text) Then
            txt_nombre.Text() = obj_Estudiante.nombre
            txt_apellido.Text() = obj_Estudiante.apellido
            txt_direccion.Text() = obj_Estudiante.direccion
            txt_celular.Text() = obj_Estudiante.celular
            txt_correo.Text() = obj_Estudiante.correo
            cb_facultad.SelectedValue = obj_Estudiante.cod_facultad
            cb_carrera.SelectedValue = obj_Estudiante.cod_facultad
            indice_academico.Text() = obj_Estudiante.indice_academico
            txt_sexo.Text() = obj_Estudiante.sexo
            txt_estatus.Text() = obj_Estudiante.estatus

            btn_modificar.Enabled = True
            btn_eliminar.Enabled = True
            btn_agregar.Enabled = False
        Else

            txt_nombre.Text() = ""
            txt_apellido.Text() = ""
            txt_direccion.Text() = ""
            txt_celular.Text() = ""
            txt_correo.Text() = ""
            cb_facultad.SelectedValue = ""
            cb_carrera.SelectedValue = ""

            indice_academico.Text() = ""
            txt_sexo.Text() = ""
            txt_estatus.Text() = ""
            btn_agregar.Enabled = True
            btn_modificar.Enabled = False
            btn_eliminar.Enabled = False
            btn_buscar.Enabled = False

        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim c As String = txt_correo.Text()

        obj_Estudiante.nombre = txt_nombre.Text
        obj_Estudiante.apellido = txt_apellido.Text
        obj_Estudiante.direccion = txt_direccion.Text()
        obj_Estudiante.celular = txt_celular.Text()
        obj_Estudiante.correo = txt_correo.Text()
        obj_Estudiante.cod_facultad = cb_facultad.SelectedValue
        obj_Estudiante.cod_carrera = cb_carrera.SelectedValue
        obj_Estudiante.indice_academico = indice_academico.Text()
        obj_Estudiante.sexo = txt_sexo.Text()
        obj_Estudiante.estatus = txt_estatus.Text()


        If obj_Estudiante.Agregar() Then
            MsgBox("El estudiante fue agregado exitosamente")
        Else
            MsgBox("Error al agregar Estudiante")
        End If

    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_cedula.Clear()
        txt_nombre.Clear()
        txt_apellido.Clear()
        txt_direccion.Clear()
        txt_celular.Clear()
        txt_correo.Clear()
        cb_facultad.SelectedValue = ""
        cb_carrera.SelectedValue = ""
        indice_academico.Clear()
        txt_sexo.Clear()
        txt_estatus.Clear()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        obj_Estudiante.cedula = txt_cedula.Text
        If obj_Estudiante.eliminar() Then
            MsgBox("Cliente Estudiante ")
        Else
            MsgBox("Este estudiante no existe o no se encuentra registrado")
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

        obj_Estudiante.nombre = txt_nombre.Text
        obj_Estudiante.apellido = txt_apellido.Text
        obj_Estudiante.direccion = txt_direccion.Text
        obj_Estudiante.celular = txt_celular.Text
        obj_Estudiante.correo = txt_correo.Text
        obj_Estudiante.cod_facultad = cb_facultad.SelectedValue
        obj_Estudiante.cod_carrera = cb_carrera.SelectedValue
        obj_Estudiante.indice_academico = indice_academico.Text
        obj_Estudiante.sexo = txt_sexo.Text
        obj_Estudiante.estatus = txt_estatus.Text

        If obj_Estudiante.modificar() Then
            MsgBox("Datos del estudiante Modificado/Actualizado")
        Else
            MsgBox("Error al actualizar Estudiante ")
        End If
    End Sub

    'Ver carreras por facultad seleccionada'
    Private Sub cb_facultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_facultad.SelectedIndexChanged

        'convertir a string el valor seleccionado'
        'Dim cod_facultad As String = New Facultad().facultad(cb_facultad.SelectedValue).ToString()'
        'Convertir DataRowView a String'
        Dim cod_facultad As String = cb_facultad.SelectedValue.ToString()

        'bj_facultad.cargar_carreras(cb_carrera, cod_facultad)'

        'RemoveHandler cb_facultad.SelectedIndexChanged, AddressOf cb_facultad_SelectedIndexChanged '
        'cargar las carreras de la facultad seleccionada'
        obj_Facultad.cargar_carreras(cb_carrera, cod_facultad)
        'Reconvertir a integer el valor seleccionado'
        cb_carrera.SelectedValue = cod_facultad

    End Sub


End Class
