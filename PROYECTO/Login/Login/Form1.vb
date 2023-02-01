Imports Datos
Imports Entidad

Public Class Form1

    Dim Fu As New Fusuario
    Dim Eu As New Eusuario


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click

        Try
            If txt_usuario.Text <> "" And txt_contra.Text <> "" Then
                Dim dt As New DataTable
                Eu._Nombre = txt_usuario.Text
                Eu._Contraseña = txt_contra.Text
                dt = Fu.validarusuario(Eu)

                If dt.Rows.Count > 0 Then
                    Dim roll As String
                    roll = dt.Rows(0)("Roll")
                    If roll = "Administrador" Then
                        MsgBox("BIENVENIDO ADMINISTRADOR ")
                        Form2.Show()
                        Me.Hide()
                    Else
                        If roll = "Cliente" Then
                            MsgBox("BIENVENIDO CLIENTE ")
                            Form2.Show()
                            Me.Hide()
                        Else
                            MsgBox("BIENVENIDA SECRETARIA ")
                            Form2.Show()
                            Me.Hide()
                        End If
                    End If
                End If


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

End Class
