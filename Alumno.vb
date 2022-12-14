Public Class Alumno

    'Declaración de Propiedades 

    Private codigo As String
    Private nombre As String
    Private apellido As String
    Private genero As String
    Private direccion As String
    Private dui As String
    Private edad As String
    Private correo As String

    'Indica si todos los datos están completos

    Private datosCompletos As Boolean

    'Métodos de la clase

    'Método para nombre
    Public Property nombreAlumno() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    'Método para apellido
    Public Property apellidoAlumno() As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    'Método para genero
    Public Property generoAlumno() As String
        Get
            Return genero
        End Get
        Set(value As String)
            genero = value
        End Set
    End Property

    'Método para direccion
    Public Property direccionAlumno() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    'Método para dui
    Public Property duiAlumno() As String
        Get
            Return dui
        End Get
        Set(value As String)
            dui = value
        End Set
    End Property

    'Método para edad
    Public Property edadAlumno() As String
        Get
            Return edad
        End Get
        Set(value As String)
            edad = value
        End Set
    End Property

    'Método para correo
    Public Property correoAlumno() As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public ReadOnly Property datosAceptados() As Boolean
        Get
            Return datosCompletos
        End Get
    End Property

    'Método
    'Constructor de la clase
    Public Sub New()
        datosCompletos = False
        'Determina si los datos aun no han sido ingresados
    End Sub

    'Determina si los datos ingresados son concretos y asigna los atributos de la clase

    Public Sub datosAlumno(ByVal codigoA As String,
                           ByVal nombreA As String,
                           ByVal apellidoA As String,
                           ByVal generoA As String,
                           ByVal direccionA As String,
                           ByVal duiA As String,
                           ByVal edadA As String,
                           ByVal correoA As String)

        datosCompletos = False

        If codigoA.Length = 0 Then
            MsgBox("Debe generar el codigo")
        Else
            codigo = codigoA
        End If

        If nombreA.Length = 0 Then
            MsgBox("Debe generar el nombre")
        Else
            nombre = nombreA

        End If

        If apellidoA.Length = 0 Then
            MsgBox("Debe generar el apellido")
        Else
            apellido = apellidoA
        End If

        If generoA.Length = 0 Then
            MsgBox("Debe generar el genero")
        Else
            genero = generoA
        End If

        If direccionA.Length = 0 Then
            MsgBox("Debe generar el direccion")
        Else
            direccion = direccionA
        End If

        If duiA.Length = 0 Then
            MsgBox("Debe generar el dui")
        Else
            dui = duiA
        End If

        If edadA.Length = 0 Then
            MsgBox("Debe generar el edad")
        Else
            edad = edadA
        End If

        If correoA.Length = 0 Then
            MsgBox("Debe generar el correo")
        Else
            correo = correoA
        End If


    End Sub

    Public Function generarCodigo(ByVal nombre As String)

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 85

        Return valor1 & numero & valor2

    End Function




End Class
