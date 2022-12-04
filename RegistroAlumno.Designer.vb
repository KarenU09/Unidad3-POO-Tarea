<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroAlumno
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextCodigo = New System.Windows.Forms.TextBox()
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.TextEdad = New System.Windows.Forms.TextBox()
        Me.TextCorreo = New System.Windows.Forms.TextBox()
        Me.TextDUI = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextDireccion = New System.Windows.Forms.TextBox()
        Me.TextGenero = New System.Windows.Forms.TextBox()
        Me.TextApellido = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpCodigo.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 0
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerar.Location = New System.Drawing.Point(259, 30)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(159, 23)
        Me.BtnGenerar.TabIndex = 1
        Me.BtnGenerar.Text = "Generar Código"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'TextCodigo
        '
        Me.TextCodigo.Location = New System.Drawing.Point(29, 27)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(156, 26)
        Me.TextCodigo.TabIndex = 3
        '
        'grpCodigo
        '
        Me.grpCodigo.Controls.Add(Me.BtnAgregar)
        Me.grpCodigo.Controls.Add(Me.BtnGenerar)
        Me.grpCodigo.Controls.Add(Me.TextCodigo)
        Me.grpCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCodigo.Location = New System.Drawing.Point(22, 24)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Size = New System.Drawing.Size(747, 72)
        Me.grpCodigo.TabIndex = 4
        Me.grpCodigo.TabStop = False
        Me.grpCodigo.Text = "Generar Código"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(512, 29)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(159, 23)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar Alumno"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label3"
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(138, 34)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(207, 26)
        Me.TextNombre.TabIndex = 4
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.TextEdad)
        Me.grpDatos.Controls.Add(Me.TextCorreo)
        Me.grpDatos.Controls.Add(Me.TextDUI)
        Me.grpDatos.Controls.Add(Me.Label10)
        Me.grpDatos.Controls.Add(Me.Label9)
        Me.grpDatos.Controls.Add(Me.Label8)
        Me.grpDatos.Controls.Add(Me.TextDireccion)
        Me.grpDatos.Controls.Add(Me.TextGenero)
        Me.grpDatos.Controls.Add(Me.TextApellido)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.Label5)
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.TextNombre)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(22, 102)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(746, 170)
        Me.grpDatos.TabIndex = 5
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos Alumnos"
        '
        'TextEdad
        '
        Me.TextEdad.Location = New System.Drawing.Point(484, 99)
        Me.TextEdad.Name = "TextEdad"
        Me.TextEdad.Size = New System.Drawing.Size(100, 26)
        Me.TextEdad.TabIndex = 17
        '
        'TextCorreo
        '
        Me.TextCorreo.Location = New System.Drawing.Point(484, 67)
        Me.TextCorreo.Name = "TextCorreo"
        Me.TextCorreo.Size = New System.Drawing.Size(225, 26)
        Me.TextCorreo.TabIndex = 16
        '
        'TextDUI
        '
        Me.TextDUI.Location = New System.Drawing.Point(484, 37)
        Me.TextDUI.Name = "TextDUI"
        Me.TextDUI.Size = New System.Drawing.Size(225, 26)
        Me.TextDUI.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(399, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Edad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(399, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Correo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(399, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "DUI"
        '
        'TextDireccion
        '
        Me.TextDireccion.Location = New System.Drawing.Point(138, 133)
        Me.TextDireccion.Name = "TextDireccion"
        Me.TextDireccion.Size = New System.Drawing.Size(207, 26)
        Me.TextDireccion.TabIndex = 11
        '
        'TextGenero
        '
        Me.TextGenero.Location = New System.Drawing.Point(138, 96)
        Me.TextGenero.Name = "TextGenero"
        Me.TextGenero.Size = New System.Drawing.Size(100, 26)
        Me.TextGenero.TabIndex = 10
        '
        'TextApellido
        '
        Me.TextApellido.Location = New System.Drawing.Point(138, 64)
        Me.TextApellido.Name = "TextApellido"
        Me.TextApellido.Size = New System.Drawing.Size(207, 26)
        Me.TextApellido.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Genero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 288)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(747, 162)
        Me.DataGridView1.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(311, -3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(205, 24)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Registro de Alumnos"
        '
        'RegistroAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 462)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistroAlumno"
        Me.Text = "Form1"
        Me.grpCodigo.ResumeLayout(False)
        Me.grpCodigo.PerformLayout()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextCodigo As TextBox
    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextDireccion As TextBox
    Friend WithEvents TextGenero As TextBox
    Friend WithEvents TextApellido As TextBox
    Friend WithEvents TextEdad As TextBox
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents TextDUI As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label11 As Label
End Class
