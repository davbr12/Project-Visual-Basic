﻿Imports System.Data.SqlClient

Public Class EJERCONEXION
    Public cnn As New SqlConnection
    Public cmd As New SqlCommand
    Public Function conectado()
        Try
            cnn = New SqlConnection(My.Settings.USUARIOS)
            cnn.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function
End Class

