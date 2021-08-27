'' Testes
'' 7 [5,3,4,7] = [7]
'' 8 [2,3,5] = [3, 5]
'' 5 [1,1,1,1,1,2,3] = [25, 25, 25, 25]

Public Class frmBestSoma
    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        Dim numeros As New List(Of Integer)

        For Each row As DataGridViewRow In Me.dtgDados.Rows
            If row.Cells("numero").Value > 0 Then
                numeros.Add(row.Cells("numero").Value)
            End If
        Next

        Dim lista = BestSum(Me.txtNumero.Text, numeros)

        If lista IsNot Nothing Then
            MsgBox(String.Join(",", lista.ToArray()))
        End If
    End Sub


    Private Function BestSum(ByVal numeroAlvo As Integer, listaNumeros As List(Of Integer)) As List(Of Integer)

        If numeroAlvo.Equals(0) Then
            Return New List(Of Integer)
        End If

        If numeroAlvo < 0 Then
            Return Nothing
        End If

        Dim menorCombinacao As List(Of Integer) = Nothing

        For Each numero As Integer In listaNumeros
            Dim auxNumber As Integer = numeroAlvo - numero
            Dim combinacao As List(Of Integer) = Me.BestSum(auxNumber, listaNumeros)

            If combinacao IsNot Nothing Then
                combinacao.Add(numero)

                If menorCombinacao Is Nothing OrElse combinacao.Count < menorCombinacao.Count Then
                    menorCombinacao = combinacao
                End If

            End If
        Next

        Return menorCombinacao
    End Function
End Class
