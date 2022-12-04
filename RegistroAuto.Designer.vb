<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroAuto
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.TextCodigo = New System.Windows.Forms.TextBox()
        Me.GrpAuto = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextMillaje = New System.Windows.Forms.TextBox()
        Me.TextAño = New System.Windows.Forms.TextBox()
        Me.TextPuertas = New System.Windows.Forms.TextBox()
        Me.TextMotor = New System.Windows.Forms.TextBox()
        Me.TextColor = New System.Windows.Forms.TextBox()
        Me.TextMarca = New System.Windows.Forms.TextBox()
        Me.TextModelo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DatosAuto = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GrpAuto.SuspendLayout()
        CType(Me.DatosAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.BtnGenerar)
        Me.GroupBox1.Controls.Add(Me.TextCodigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar Código Auto"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(526, 29)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(159, 29)
        Me.BtnAgregar.TabIndex = 5
        Me.BtnAgregar.Text = "Agregar Auto"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerar.Location = New System.Drawing.Point(290, 29)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(159, 29)
        Me.BtnGenerar.TabIndex = 2
        Me.BtnGenerar.Text = "Generar Código"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'TextCodigo
        '
        Me.TextCodigo.Location = New System.Drawing.Point(20, 29)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(161, 29)
        Me.TextCodigo.TabIndex = 0
        '
        'GrpAuto
        '
        Me.GrpAuto.Controls.Add(Me.Label8)
        Me.GrpAuto.Controls.Add(Me.TextMillaje)
        Me.GrpAuto.Controls.Add(Me.TextAño)
        Me.GrpAuto.Controls.Add(Me.TextPuertas)
        Me.GrpAuto.Controls.Add(Me.TextMotor)
        Me.GrpAuto.Controls.Add(Me.TextColor)
        Me.GrpAuto.Controls.Add(Me.TextMarca)
        Me.GrpAuto.Controls.Add(Me.TextModelo)
        Me.GrpAuto.Controls.Add(Me.Label7)
        Me.GrpAuto.Controls.Add(Me.Label6)
        Me.GrpAuto.Controls.Add(Me.Label5)
        Me.GrpAuto.Controls.Add(Me.Label3)
        Me.GrpAuto.Controls.Add(Me.Label2)
        Me.GrpAuto.Controls.Add(Me.Label1)
        Me.GrpAuto.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpAuto.ForeColor = System.Drawing.Color.DarkRed
        Me.GrpAuto.Location = New System.Drawing.Point(12, 126)
        Me.GrpAuto.Name = "GrpAuto"
        Me.GrpAuto.Size = New System.Drawing.Size(764, 169)
        Me.GrpAuto.TabIndex = 1
        Me.GrpAuto.TabStop = False
        Me.GrpAuto.Text = "Datos del Auto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Modelo"
        '
        'TextMillaje
        '
        Me.TextMillaje.Location = New System.Drawing.Point(487, 100)
        Me.TextMillaje.Name = "TextMillaje"
        Me.TextMillaje.Size = New System.Drawing.Size(170, 29)
        Me.TextMillaje.TabIndex = 19
        '
        'TextAño
        '
        Me.TextAño.Location = New System.Drawing.Point(487, 65)
        Me.TextAño.Name = "TextAño"
        Me.TextAño.Size = New System.Drawing.Size(126, 29)
        Me.TextAño.TabIndex = 18
        '
        'TextPuertas
        '
        Me.TextPuertas.Location = New System.Drawing.Point(487, 29)
        Me.TextPuertas.Name = "TextPuertas"
        Me.TextPuertas.Size = New System.Drawing.Size(207, 29)
        Me.TextPuertas.TabIndex = 17
        '
        'TextMotor
        '
        Me.TextMotor.Location = New System.Drawing.Point(112, 134)
        Me.TextMotor.Name = "TextMotor"
        Me.TextMotor.Size = New System.Drawing.Size(207, 29)
        Me.TextMotor.TabIndex = 16
        '
        'TextColor
        '
        Me.TextColor.Location = New System.Drawing.Point(112, 100)
        Me.TextColor.Name = "TextColor"
        Me.TextColor.Size = New System.Drawing.Size(172, 29)
        Me.TextColor.TabIndex = 15
        '
        'TextMarca
        '
        Me.TextMarca.Location = New System.Drawing.Point(112, 65)
        Me.TextMarca.Name = "TextMarca"
        Me.TextMarca.Size = New System.Drawing.Size(144, 29)
        Me.TextMarca.TabIndex = 14
        '
        'TextModelo
        '
        Me.TextModelo.Location = New System.Drawing.Point(112, 32)
        Me.TextModelo.Name = "TextModelo"
        Me.TextModelo.Size = New System.Drawing.Size(207, 29)
        Me.TextModelo.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(399, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Millaje"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(399, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Año"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Puertas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Motor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Color"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(346, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Registro de Autos "
        '
        'DatosAuto
        '
        Me.DatosAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosAuto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DatosAuto.Location = New System.Drawing.Point(20, 324)
        Me.DatosAuto.Name = "DatosAuto"
        Me.DatosAuto.Size = New System.Drawing.Size(826, 150)
        Me.DatosAuto.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Modelo"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Marca"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Color"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Motor"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Puertas"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Año"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Millaje"
        Me.Column8.Name = "Column8"
        '
        'RegistroAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 489)
        Me.Controls.Add(Me.DatosAuto)
        Me.Controls.Add(Me.GrpAuto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "RegistroAuto"
        Me.Text = "RegistroAuto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpAuto.ResumeLayout(False)
        Me.GrpAuto.PerformLayout()
        CType(Me.DatosAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextCodigo As TextBox
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents GrpAuto As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextModelo As TextBox
    Friend WithEvents TextMillaje As TextBox
    Friend WithEvents TextAño As TextBox
    Friend WithEvents TextPuertas As TextBox
    Friend WithEvents TextMotor As TextBox
    Friend WithEvents TextColor As TextBox
    Friend WithEvents TextMarca As TextBox
    Friend WithEvents DatosAuto As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
End Class
