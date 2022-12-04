
Imports Capa_Servicio
Public Class Frm_Profesores

    Dim obj_Cliente As Estudiante = New Estudiante()
    Dim obj_Facultad As Facultad = New Facultad()
    Dim obj_carrera As carrera = New carrera()
    Dim obj_Profesor As Profesor = New Profesor()
    Dim obj_Categoria As Categoria = New Categoria()

    Public Sub New()

        InitializeComponent()
        obj_Facultad.cargar(cb_cod_fac)
        obj_Categoria.cargar(cb_cod_cat)

    End Sub

    Private Sub btn_listar2_Click(sender As Object, e As EventArgs) Handles btn_listar2.Click
        dgv_Profesor.DataSource = obj_Profesor.listar().Tables(0)
    End Sub

    Private Sub btn_buscarP_Click_1(sender As Object, e As EventArgs) Handles btn_buscarP.Click
        If obj_Profesor.buscar(txt_codigo.Text) Then
            txt_cedulaP.Text() = obj_Profesor.cedula
            txt_nombreP.Text() = obj_Profesor.nombre
            txt_apellidoP.Text() = obj_Profesor.apellido
            txt_direccionP.Text() = obj_Profesor.direccion
            txt_celularP.Text() = obj_Profesor.celular
            txt_correoP.Text() = obj_Profesor.correo
            cb_cod_fac.SelectedValue = obj_Profesor.cod_facultad
            cb_cod_cat.SelectedValue = obj_Profesor.cod_categoria

            txt_salario_base.Text() = obj_Profesor.salario_base
            txt_estatusP.Text() = obj_Profesor.estatus

            btn_ModificarP.Enabled = True
            btn_EliminarP.Enabled = True
            btn_AgregarP.Enabled = False
        Else
            txt_apellidoP.Text() = ""
            txt_nombreP.Text() = ""
            txt_apellidoP.Text() = ""
            txt_direccionP.Text() = ""
            txt_celularP.Text() = ""
            txt_correoP.Text() = ""
            cb_cod_fac.SelectedValue = ""
            cb_cod_cat.SelectedValue = ""

            txt_salario_base.Text() = ""
            txt_estatusP.Text() = ""

            btn_AgregarP.Enabled = True
            btn_ModificarP.Enabled = False
            btn_EliminarP.Enabled = False
            btn_buscarP.Enabled = False
        End If
    End Sub

    Private Sub btn_AgregarP_Click(sender As Object, e As EventArgs) Handles btn_AgregarP.Click
        obj_Profesor.cedula = txt_cedulaP.Text
        obj_Profesor.codigo = txt_codigo.Text()
        obj_Profesor.nombre = txt_nombreP.Text
        obj_Profesor.apellido = txt_apellidoP.Text
        obj_Profesor.direccion = txt_direccionP.Text()
        obj_Profesor.celular = txt_celularP.Text()
        obj_Profesor.correo = txt_correoP.Text()
        obj_Profesor.cod_facultad = cb_cod_fac.SelectedValue
        obj_Profesor.cod_categoria = cb_cod_cat.SelectedValue

        obj_Profesor.salario_base = txt_salario_base.Text()
        obj_Profesor.estatus = txt_estatusP.Text()

        If obj_Profesor.Agregar() Then
            MsgBox("Profesor agregado exitosamente")
        Else
            MsgBox("Error al agregar Profesor")
        End If
    End Sub

    Private Sub btn_EliminarP_Click(sender As Object, e As EventArgs) Handles btn_EliminarP.Click
        obj_Profesor.cedula = txt_cedulaP.Text
        If obj_Profesor.eliminar() Then
            MsgBox("Profesor eliminado")
        Else
            MsgBox("El Profesor no existe o no se encuentra registrado")
        End If
    End Sub

    Private Sub btn_ModificarP_Click_1(sender As Object, e As EventArgs) Handles btn_ModificarP.Click
        obj_Profesor.codigo = txt_codigo.Text
        obj_Profesor.nombre = txt_nombreP.Text
        obj_Profesor.apellido = txt_apellidoP.Text
        obj_Profesor.direccion = txt_direccionP.Text
        obj_Profesor.celular = txt_celularP.Text
        obj_Profesor.correo = txt_correoP.Text
        obj_Profesor.cod_facultad = cb_cod_fac.SelectedValue
        obj_Profesor.cod_categoria = cb_cod_cat.SelectedValue
        obj_Profesor.salario_base = txt_salario_base.Text
        obj_Profesor.estatus = txt_estatusP.Text

        If obj_Profesor.modificar() Then
            MsgBox("Datos del profesor modificado/actualizado")
        Else
            MsgBox("Error al actualizar Profesor")
        End If
    End Sub



    Private Sub btn_limpiarP_Click(sender As Object, e As EventArgs) Handles btn_limpiarP.Click
        txt_codigo.Clear()
        txt_cedulaP.Clear()
        txt_nombreP.Clear()
        txt_apellidoP.Clear()
        txt_direccionP.Clear()
        txt_celularP.Clear()
        txt_correoP.Clear()
        cb_cod_fac.SelectedValue = ""
        cb_cod_cat.SelectedValue = ""

        txt_salario_base.Clear()
        txt_estatusP.Clear()
    End Sub

    Private Sub txt_codigo_TextChanged(sender As Object, e As EventArgs) Handles txt_codigo.TextChanged

    End Sub
End Class

