Imports Capa_Servicio
Public Class Menu
    Private Sub EstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudiantesToolStripMenuItem.Click
        Dim frm_Estudiantes As New Frm_Estudiantes()
        'mostrar formulario dentro del form principal'
        frm_Estudiantes.MdiParent = Me
        frm_Estudiantes.Show()
        'al abrir esta ventana se cierra la ventana que se encuentra abierta'
        frm_Estudiantes.WindowState = FormWindowState.Maximized

        'Si esta ventana esta en uso se cierran las demas ventanas'
        For Each frm As Form In Me.MdiChildren
            If frm.Name <> frm_Estudiantes.Name Then
                frm.Close()
            End If
        Next

        'Redimensionar al tamaño del form principal'
        frm_Estudiantes.Size = Me.Size



    End Sub

    Private Sub ProfesoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesoresToolStripMenuItem.Click
        Dim frm_Profesores As New Frm_Profesores()
        frm_Profesores.MdiParent = Me
        frm_Profesores.Show()
        'al abrir esta ventana se cierra la ventana que se encuentra abierta'
        frm_Profesores.WindowState = FormWindowState.Maximized

        'Si esta ventana esta en uso se cierran las demas ventanas'
        For Each frm As Form In Me.MdiChildren
            If frm.Name <> frm_Profesores.Name Then
                frm.Close()
            End If
        Next
        'Redimensionar al tamaño del form principal'
        frm_Profesores.Size = Me.Size


    End Sub

    Private Sub PresentacionToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PresentacionToolStripMenuItem.Click
        Dim frm_Estudiantes As New Frm_Estudiantes()
        'mostrar formulario dentro del form principal'
        Presentacion.MdiParent = Me
        Presentacion.Show()
        'al abrir esta ventana se cierra la ventana que se encuentra abierta'
        Presentacion.WindowState = FormWindowState.Maximized

        'Si esta ventana esta en uso se cierran las demas ventanas'
        For Each frm As Form In Me.MdiChildren
            If frm.Name <> Presentacion.Name Then
                frm.Close()
            End If
        Next
        'Redimensionar al tamaño del form principal'
        Presentacion.Size = Me.Size

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'cerrar todos los formularios'
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
        'cerrar el form principal'
        Me.Close()


    End Sub
End Class