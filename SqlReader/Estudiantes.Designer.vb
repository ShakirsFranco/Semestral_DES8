<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Estudiantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bnt_listar = New System.Windows.Forms.Button()
        Me.lbl_cedula = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.dgv_Cliente = New System.Windows.Forms.DataGridView()
        Me.cb_facultad = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cb_carrera = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.indice_academico = New System.Windows.Forms.TextBox()
        Me.txt_estatus = New System.Windows.Forms.TextBox()
        Me.txt_sexo = New System.Windows.Forms.TextBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgv_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnt_listar
        '
        Me.bnt_listar.Location = New System.Drawing.Point(19, 221)
        Me.bnt_listar.Margin = New System.Windows.Forms.Padding(2)
        Me.bnt_listar.Name = "bnt_listar"
        Me.bnt_listar.Size = New System.Drawing.Size(111, 29)
        Me.bnt_listar.TabIndex = 1
        Me.bnt_listar.Text = "Listar "
        Me.bnt_listar.UseVisualStyleBackColor = True
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Location = New System.Drawing.Point(167, 19)
        Me.lbl_cedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(40, 13)
        Me.lbl_cedula.TabIndex = 2
        Me.lbl_cedula.Text = "Cedula"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(167, 49)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(167, 79)
        Me.lbl_apellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 4
        Me.lbl_apellido.Text = "Apellido"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(209, 17)
        Me.txt_cedula.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(76, 20)
        Me.txt_cedula.TabIndex = 5
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(209, 47)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(76, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(209, 77)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(76, 20)
        Me.txt_apellido.TabIndex = 7
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(686, 31)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(81, 36)
        Me.btn_buscar.TabIndex = 8
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Enabled = False
        Me.btn_agregar.Location = New System.Drawing.Point(793, 31)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(81, 36)
        Me.btn_agregar.TabIndex = 9
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(686, 89)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(81, 38)
        Me.btn_modificar.TabIndex = 10
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Location = New System.Drawing.Point(793, 89)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(81, 39)
        Me.btn_eliminar.TabIndex = 11
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'dgv_Cliente
        '
        Me.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Cliente.Location = New System.Drawing.Point(19, 254)
        Me.dgv_Cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Cliente.Name = "dgv_Cliente"
        Me.dgv_Cliente.RowHeadersWidth = 51
        Me.dgv_Cliente.RowTemplate.Height = 24
        Me.dgv_Cliente.Size = New System.Drawing.Size(986, 223)
        Me.dgv_Cliente.TabIndex = 12
        '
        'cb_facultad
        '
        Me.cb_facultad.FormattingEnabled = True
        Me.cb_facultad.Location = New System.Drawing.Point(474, 16)
        Me.cb_facultad.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_facultad.Name = "cb_facultad"
        Me.cb_facultad.Size = New System.Drawing.Size(185, 21)
        Me.cb_facultad.TabIndex = 14
        '
        'cb_carrera
        '
        Me.cb_carrera.FormattingEnabled = True
        Me.cb_carrera.Location = New System.Drawing.Point(474, 49)
        Me.cb_carrera.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_carrera.Name = "cb_carrera"
        Me.cb_carrera.Size = New System.Drawing.Size(185, 21)
        Me.cb_carrera.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 149)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Facultad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Carrera"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(359, 96)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "IndiceDelEstudiante"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(410, 126)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Sexo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(401, 161)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Estado"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(209, 140)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(76, 20)
        Me.txt_direccion.TabIndex = 24
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(211, 169)
        Me.txt_celular.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(76, 20)
        Me.txt_celular.TabIndex = 25
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(211, 108)
        Me.txt_correo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(76, 20)
        Me.txt_correo.TabIndex = 26
        '
        'indice_academico
        '
        Me.indice_academico.Location = New System.Drawing.Point(474, 89)
        Me.indice_academico.Margin = New System.Windows.Forms.Padding(2)
        Me.indice_academico.Name = "indice_academico"
        Me.indice_academico.Size = New System.Drawing.Size(76, 20)
        Me.indice_academico.TabIndex = 29
        '
        'txt_estatus
        '
        Me.txt_estatus.Location = New System.Drawing.Point(474, 158)
        Me.txt_estatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_estatus.Name = "txt_estatus"
        Me.txt_estatus.Size = New System.Drawing.Size(76, 20)
        Me.txt_estatus.TabIndex = 30
        '
        'txt_sexo
        '
        Me.txt_sexo.Location = New System.Drawing.Point(474, 119)
        Me.txt_sexo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_sexo.Name = "txt_sexo"
        Me.txt_sexo.Size = New System.Drawing.Size(76, 20)
        Me.txt_sexo.TabIndex = 31
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(741, 161)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(81, 43)
        Me.btn_limpiar.TabIndex = 60
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Frm_Estudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 571)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.txt_sexo)
        Me.Controls.Add(Me.txt_estatus)
        Me.Controls.Add(Me.indice_academico)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_carrera)
        Me.Controls.Add(Me.cb_facultad)
        Me.Controls.Add(Me.dgv_Cliente)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_cedula)
        Me.Controls.Add(Me.bnt_listar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_Estudiantes"
        Me.Text = "Estudiantes"
        CType(Me.dgv_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnt_listar As Button
    Friend WithEvents lbl_cedula As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents dgv_Cliente As DataGridView
    Friend WithEvents cb_facultad As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cb_carrera As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents indice_academico As TextBox
    Friend WithEvents txt_estatus As TextBox
    Friend WithEvents txt_sexo As TextBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
