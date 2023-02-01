Imports System.Data.SqlClient
Imports Entidad

Public Class Fusuario

    Inherits conexion
    Public Function validarusuario(ByVal dts As Eusuario) As DataTable
        conectado()
        cmd = New SqlCommand("iniciar")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con

        cmd.Parameters.AddWithValue("@Nombre", dts._Nombre)
        cmd.Parameters.AddWithValue("@Contraseña", dts._Contraseña)


        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If
    End Function
End Class
