<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Profesores
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
        Me.cb_cod_cat = New System.Windows.Forms.ComboBox()
        Me.cb_cod_fac = New System.Windows.Forms.ComboBox()
        Me.btn_limpiarP = New System.Windows.Forms.Button()
        Me.btn_EliminarP = New System.Windows.Forms.Button()
        Me.btn_ModificarP = New System.Windows.Forms.Button()
        Me.btn_AgregarP = New System.Windows.Forms.Button()
        Me.btn_buscarP = New System.Windows.Forms.Button()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_cedulaP = New System.Windows.Forms.TextBox()
        Me.txt_estatusP = New System.Windows.Forms.TextBox()
        Me.txt_salario_base = New System.Windows.Forms.TextBox()
        Me.txt_correoP = New System.Windows.Forms.TextBox()
        Me.txt_celularP = New System.Windows.Forms.TextBox()
        Me.txt_direccionP = New System.Windows.Forms.TextBox()
        Me.txt_apellidoP = New System.Windows.Forms.TextBox()
        Me.txt_nombreP = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgv_Profesor = New System.Windows.Forms.DataGridView()
        Me.btn_listar2 = New System.Windows.Forms.Button()
        CType(Me.dgv_Profesor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_cod_cat
        '
        Me.cb_cod_cat.FormattingEnabled = True
        Me.cb_cod_cat.Location = New System.Drawing.Point(591, 106)
        Me.cb_cod_cat.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_cod_cat.Name = "cb_cod_cat"
        Me.cb_cod_cat.Size = New System.Drawing.Size(172, 21)
        Me.cb_cod_cat.TabIndex = 90
        '
        'cb_cod_fac
        '
        Me.cb_cod_fac.FormattingEnabled = True
        Me.cb_cod_fac.Location = New System.Drawing.Point(591, 63)
        Me.cb_cod_fac.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_cod_fac.Name = "cb_cod_fac"
        Me.cb_cod_fac.Size = New System.Drawing.Size(172, 21)
        Me.cb_cod_fac.TabIndex = 89
        '
        'btn_limpiarP
        '
        Me.btn_limpiarP.Location = New System.Drawing.Point(844, 159)
        Me.btn_limpiarP.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_limpiarP.Name = "btn_limpiarP"
        Me.btn_limpiarP.Size = New System.Drawing.Size(75, 40)
        Me.btn_limpiarP.TabIndex = 88
        Me.btn_limpiarP.Text = "Limpiar"
        Me.btn_limpiarP.UseVisualStyleBackColor = True
        '
        'btn_EliminarP
        '
        Me.btn_EliminarP.Location = New System.Drawing.Point(796, 91)
        Me.btn_EliminarP.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_EliminarP.Name = "btn_EliminarP"
        Me.btn_EliminarP.Size = New System.Drawing.Size(75, 36)
        Me.btn_EliminarP.TabIndex = 87
        Me.btn_EliminarP.Text = "Eliminar"
        Me.btn_EliminarP.UseVisualStyleBackColor = True
        '
        'btn_ModificarP
        '
        Me.btn_ModificarP.Location = New System.Drawing.Point(898, 89)
        Me.btn_ModificarP.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ModificarP.Name = "btn_ModificarP"
        Me.btn_ModificarP.Size = New System.Drawing.Size(75, 40)
        Me.btn_ModificarP.TabIndex = 86
        Me.btn_ModificarP.Text = "Modificar"
        Me.btn_ModificarP.UseVisualStyleBackColor = True
        '
        'btn_AgregarP
        '
        Me.btn_AgregarP.Location = New System.Drawing.Point(898, 25)
        Me.btn_AgregarP.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_AgregarP.Name = "btn_AgregarP"
        Me.btn_AgregarP.Size = New System.Drawing.Size(75, 41)
        Me.btn_AgregarP.TabIndex = 85
        Me.btn_AgregarP.Text = "Agregar"
        Me.btn_AgregarP.UseVisualStyleBackColor = True
        '
        'btn_buscarP
        '
        Me.btn_buscarP.Location = New System.Drawing.Point(796, 25)
        Me.btn_buscarP.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscarP.Name = "btn_buscarP"
        Me.btn_buscarP.Size = New System.Drawing.Size(75, 41)
        Me.btn_buscarP.TabIndex = 84
        Me.btn_buscarP.Text = "Buscar"
        Me.btn_buscarP.UseVisualStyleBackColor = True
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(290, 36)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(76, 20)
        Me.txt_codigo.TabIndex = 83
        '
        'txt_cedulaP
        '
        Me.txt_cedulaP.Location = New System.Drawing.Point(290, 72)
        Me.txt_cedulaP.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cedulaP.Name = "txt_cedulaP"
        Me.txt_cedulaP.Size = New System.Drawing.Size(76, 20)
        Me.txt_cedulaP.TabIndex = 82
        '
        'txt_estatusP
        '
        Me.txt_estatusP.Location = New System.Drawing.Point(591, 203)
        Me.txt_estatusP.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_estatusP.Name = "txt_estatusP"
        Me.txt_estatusP.Size = New System.Drawing.Size(76, 20)
        Me.txt_estatusP.TabIndex = 81
        '
        'txt_salario_base
        '
        Me.txt_salario_base.Location = New System.Drawing.Point(591, 159)
        Me.txt_salario_base.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_salario_base.Name = "txt_salario_base"
        Me.txt_salario_base.Size = New System.Drawing.Size(76, 20)
        Me.txt_salario_base.TabIndex = 80
        '
        'txt_correoP
        '
        Me.txt_correoP.Location = New System.Drawing.Point(591, 25)
        Me.txt_correoP.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_correoP.Name = "txt_correoP"
        Me.txt_correoP.Size = New System.Drawing.Size(172, 20)
        Me.txt_correoP.TabIndex = 79
        '
        'txt_celularP
        '
        Me.txt_celularP.Location = New System.Drawing.Point(290, 233)
        Me.txt_celularP.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_celularP.Name = "txt_celularP"
        Me.txt_celularP.Size = New System.Drawing.Size(76, 20)
        Me.txt_celularP.TabIndex = 78
        '
        'txt_direccionP
        '
        Me.txt_direccionP.Location = New System.Drawing.Point(290, 196)
        Me.txt_direccionP.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_direccionP.Name = "txt_direccionP"
        Me.txt_direccionP.Size = New System.Drawing.Size(76, 20)
        Me.txt_direccionP.TabIndex = 77
        '
        'txt_apellidoP
        '
        Me.txt_apellidoP.Location = New System.Drawing.Point(290, 149)
        Me.txt_apellidoP.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_apellidoP.Name = "txt_apellidoP"
        Me.txt_apellidoP.Size = New System.Drawing.Size(76, 20)
        Me.txt_apellidoP.TabIndex = 76
        '
        'txt_nombreP
        '
        Me.txt_nombreP.Location = New System.Drawing.Point(290, 106)
        Me.txt_nombreP.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombreP.Name = "txt_nombreP"
        Me.txt_nombreP.Size = New System.Drawing.Size(76, 20)
        Me.txt_nombreP.TabIndex = 75
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(526, 210)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 74
        Me.Label19.Text = "Estado"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(210, 43)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "Codigo"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(511, 166)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "Salario_base"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(526, 114)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Categoria"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(526, 71)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Facultad"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(480, 35)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Correo Institucional"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(210, 240)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Telefono"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(207, 203)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Dirección"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(215, 156)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Apellido"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 109)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 79)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Cedula"
        '
        'dgv_Profesor
        '
        Me.dgv_Profesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Profesor.Location = New System.Drawing.Point(11, 308)
        Me.dgv_Profesor.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Profesor.Name = "dgv_Profesor"
        Me.dgv_Profesor.ReadOnly = True
        Me.dgv_Profesor.RowHeadersWidth = 51
        Me.dgv_Profesor.RowTemplate.Height = 24
        Me.dgv_Profesor.Size = New System.Drawing.Size(1035, 219)
        Me.dgv_Profesor.TabIndex = 91
        '
        'btn_listar2
        '
        Me.btn_listar2.Location = New System.Drawing.Point(11, 275)
        Me.btn_listar2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_listar2.Name = "btn_listar2"
        Me.btn_listar2.Size = New System.Drawing.Size(111, 29)
        Me.btn_listar2.TabIndex = 92
        Me.btn_listar2.Text = "Listar "
        Me.btn_listar2.UseVisualStyleBackColor = True
        '
        'Frm_Profesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 648)
        Me.Controls.Add(Me.btn_listar2)
        Me.Controls.Add(Me.dgv_Profesor)
        Me.Controls.Add(Me.cb_cod_cat)
        Me.Controls.Add(Me.cb_cod_fac)
        Me.Controls.Add(Me.btn_limpiarP)
        Me.Controls.Add(Me.btn_EliminarP)
        Me.Controls.Add(Me.btn_ModificarP)
        Me.Controls.Add(Me.btn_AgregarP)
        Me.Controls.Add(Me.btn_buscarP)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_cedulaP)
        Me.Controls.Add(Me.txt_estatusP)
        Me.Controls.Add(Me.txt_salario_base)
        Me.Controls.Add(Me.txt_correoP)
        Me.Controls.Add(Me.txt_celularP)
        Me.Controls.Add(Me.txt_direccionP)
        Me.Controls.Add(Me.txt_apellidoP)
        Me.Controls.Add(Me.txt_nombreP)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_Profesores"
        Me.Text = "Profesores"
        CType(Me.dgv_Profesor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_cod_cat As ComboBox
    Friend WithEvents cb_cod_fac As ComboBox
    Friend WithEvents btn_limpiarP As Button
    Friend WithEvents btn_EliminarP As Button
    Friend WithEvents btn_ModificarP As Button
    Friend WithEvents btn_AgregarP As Button
    Friend WithEvents btn_buscarP As Button
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_cedulaP As TextBox
    Friend WithEvents txt_estatusP As TextBox
    Friend WithEvents txt_salario_base As TextBox
    Friend WithEvents txt_correoP As TextBox
    Friend WithEvents txt_celularP As TextBox
    Friend WithEvents txt_direccionP As TextBox
    Friend WithEvents txt_apellidoP As TextBox
    Friend WithEvents txt_nombreP As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgv_Profesor As DataGridView
    Friend WithEvents btn_listar2 As Button
End Class
