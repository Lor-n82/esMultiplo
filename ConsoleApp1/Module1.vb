Module Module1

    Sub Main()
        'Realiza una función que nos indica si un número es múltiplo de otro. 
        'Pedimos los dos números por teclado. Esta función debe devolver un Booleano, 
        'donde True significa que si es múltiplo y False que no lo es. Según este valor, que muestre por consola si es múltiplo o no.
        Dim a, b As Integer
        Dim sw, sw2, sw3 As Boolean
        Dim resp As String


        Do
            Do
                sw2 = False
                Try
                    Console.Write("Introduce el primer numero: ")
                    a = Console.ReadLine()
                    Console.Write("Introduce el segundo numero: ")
                    b = Console.ReadLine()

                    sw = multiplo(a, b)
                Catch
                    Console.WriteLine("Operacion incorrecta" & vbNewLine)
                    sw2 = True
                End Try
            Loop While sw2 = True

            If sw Then
                Console.WriteLine("El numero " & a & " es multiplo de " & b)
            Else
                Console.WriteLine("El numero " & a & " NO es multiplo de " & b)
            End If

            Do

                Console.Write("¿Deseas continuar?(Si/No): ")
                resp = Console.ReadLine().ToLower

                If resp = "si" Then
                    sw2 = True
                ElseIf resp = "no" Then
                    sw2 = False
                    Console.WriteLine("Fin del programa")
                ElseIf resp <> "si" And resp <> "no" Then
                    Console.WriteLine("Comando erroneo")
                End If

            Loop While resp <> "si" And resp <> "no"
        Loop While sw2 = True

            Console.ReadLine()

    End Sub

    Function multiplo(x As Integer, y As Integer) As Boolean
        Dim sw As Boolean
        If x Mod y = 0 Then

            sw = True
        Else
            sw = False
        End If
        Return sw
    End Function

End Module
