Public Class ENTIDADU
    Private CORREO As String
    Private CONTRASEÑA As String
    Private IDTIPOU As String
    'agregar referencias en datos a entidad
    Public Property _CORREO
        Get
            Return CORREO
        End Get
        Set(value)
            CORREO = value
        End Set
    End Property
    Public Property _CONTRASEÑA
        Get
            Return CONTRASEÑA
        End Get
        Set(value)
            CONTRASEÑA = value
        End Set
    End Property
    Public Property _IDTIPOU
        Get
            Return IDTIPOU
        End Get
        Set(value)
            IDTIPOU = value
        End Set
    End Property
    Public Sub New()
    End Sub
End Class

