'' Testes
'' 7 [5,3,4,7] = [7]
'' [3,4]
'' [7]

'' 8 [2,3,5] = [3, 5]

'' 5 [1,1,1,2,3] = [2, 3]
'' [1,1,1,1,1]
'' [1,1,1,2]
'' [1,1,3]
'' [3,2]

Public Class frmBestSoma
    Dim dicionarioSomas As New Dictionary(Of Integer, List(Of Integer))

    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        Dim numeros As New List(Of Integer)

        For Each row As DataGridViewRow In Me.dtgDados.Rows
            If row.Cells("numero").Value > 0 Then
                numeros.Add(row.Cells("numero").Value)
            End If
        Next

        If dicionarioSomas.ContainsKey(Me.txtNumero.Text) Then
            Dim combinacao As List(Of Integer) = dicionarioSomas(Me.txtNumero.Text)
            If ExisteCombinacao(combinacao) Then
                MsgBox(String.Join(",", combinacao.ToArray()))
                Return
            End If
        End If

        Dim lista = BestSum(Me.txtNumero.Text, numeros)

        If Not dicionarioSomas.ContainsKey(Me.txtNumero.Text) Then
            dicionarioSomas.Add(Me.txtNumero.Text, lista)
        End If

        If lista IsNot Nothing Then
            MsgBox(String.Join(",", lista.ToArray()))
        End If
    End Sub

    Private Sub btnTeste_Click(sender As Object, e As EventArgs) Handles btnTeste.Click
        Dim listaNumeros As New List(Of Integer)
        listaNumeros.Add(5)
        listaNumeros.Add(3)
        listaNumeros.Add(4)
        listaNumeros.Add(7)

        Dim lista1 = BestSum(7, listaNumeros)

        Console.WriteLine($"Alvo: 7 | Numeros=[5,3,4,7] | Melhor Soma= {String.Join(",", lista1.ToArray())}")

        listaNumeros.Clear()
        listaNumeros.Add(2)
        listaNumeros.Add(3)
        listaNumeros.Add(5)

        Dim lista2 = BestSum(8, listaNumeros)

        Console.WriteLine($"Alvo: 8 | Numeros=[2,3,5] | Melhor Soma= {String.Join(",", lista2.ToArray())}")

        listaNumeros.Clear()
        listaNumeros.Add(1)
        listaNumeros.Add(1)
        listaNumeros.Add(1)
        listaNumeros.Add(2)
        listaNumeros.Add(3)

        Dim lista3 = BestSum(5, listaNumeros)

        Console.WriteLine($"Alvo: 5 | Numeros=[1,1,1,2,3] | Melhor Soma= {String.Join(",", lista3.ToArray())}")
    End Sub

    Private Function BestSum(ByVal numeroAlvo As Integer, listaNumeros As List(Of Integer)) As List(Of Integer)
        If numeroAlvo < 0 Then
            Return Nothing
        End If

        If numeroAlvo.Equals(0) Then
            Return New List(Of Integer)
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

    Function ExisteCombinacao(menorCombinacao As List(Of Integer)) As Boolean
        If menorCombinacao Is Nothing Then Return False
        For Each numero As Integer In menorCombinacao
            Dim existeNumero As Boolean = False
            For Each row As DataGridViewRow In Me.dtgDados.Rows
                If row.Cells("numero").Value = numero Then
                    existeNumero = True
                    Exit For
                End If
            Next
            If Not existeNumero Then
                Return False
            End If
        Next
        Return True
    End Function

End Class