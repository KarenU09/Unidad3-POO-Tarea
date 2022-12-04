Public Class Auto

    'Declaración de Propiedades 

    Private codigo As String
    Private modelo As String
    Private marca As String
    Private color As String
    Private motor As String
    Private puertas As String
    Private año As String
    Private millaje As String

    'Indica si todos los datos están completos

    Private datosCompletos As Boolean

    'Métodos de la clase

    'Método para modelo
    Public Property modeloAuto() As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    'Método para marca
    Public Property marcaAuto() As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    'Método para color
    Public Property colorAuto() As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property

    'Método para motor
    Public Property motorAuto() As String
        Get
            Return motor
        End Get
        Set(value As String)
            motor = value
        End Set
    End Property

    'Método para puertas
    Public Property puertasAuto() As String
        Get
            Return puertas
        End Get
        Set(value As String)
            puertas = value
        End Set
    End Property

    'Método para año
    Public Property añoAuto() As String
        Get
            Return año
        End Get
        Set(value As String)
            año = value
        End Set
    End Property

    'Método para millaje
    Public Property millajeAuto() As String
        Get
            Return millaje
        End Get
        Set(value As String)
            millaje = value
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

    Public Sub datosAuto(ByVal codigoAuto As String,
                           ByVal modeloA As String,
                           ByVal marcaA As String,
                           ByVal colorA As String,
                           ByVal motorA As String,
                           ByVal puertasA As String,
                           ByVal añoA As String,
                           ByVal millajeA As String)

        datosCompletos = False

        If codigoAuto.Length = 0 Then
            MsgBox("Debe generar el codigo")
        Else
            codigo = codigoAuto
        End If

        If modeloA.Length = 0 Then
            MsgBox("Debe generar el modelo")
        Else
            modelo = modeloA

        End If

        If marcaA.Length = 0 Then
            MsgBox("Debe generar el marca")
        Else
            marca = modeloA
        End If

        If colorA.Length = 0 Then
            MsgBox("Debe generar el color")
        Else
            color = colorA
        End If

        If motorA.Length = 0 Then
            MsgBox("Debe generar el motor")
        Else
            motor = motorA
        End If

        If puertasA.Length = 0 Then
            MsgBox("Debe generar el puertas")
        Else
            puertas = puertasA
        End If

        If añoA.Length = 0 Then
            MsgBox("Debe generar el año")
        Else
            año = añoA
        End If

        If millaje.Length = 0 Then
            MsgBox("Debe generar el millaje")
        Else
            millaje = millajeA
        End If


    End Sub

    Public Function generarCodigo(ByVal nombre As String)

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 75

        Return valor1 & numero & valor2

    End Function




End Class
