Module Module1


    ''' <summary>
    ''' '''''''FIX STRING BUILDER TO PROPERLY DO EVEN AND ODD NUMBERS'''''''''''''
    ''' </summary>




    Public Sub Main()

        Dim T = Convert.ToInt32(Console.ReadLine())
        If (T >= 1 AndAlso T <= 10) Then
            For j As Integer = 0 To T - 1 Step 1

                Dim S As String = Console.ReadLine()
                If (S.Length >= 2 & S.Length <= 10000) Then
                    Dim X = S.Substring(S.IndexOf(S), 1)
                    Dim sb As New Text.StringBuilder

                    For i As Integer = 0 To S.Length - 1 Step 1

                        X = S.Substring(S.IndexOf(S) + i, 1)

                        If (i Mod 2 = 0) Then

                            sb.Append(X)


                        ElseIf (i Mod 2 = 1) Then

                            sb.Append(X)

                        End If
                    Next

                    Dim finalStr = sb.ToString()
                    Console.WriteLine(finalStr)
                End If
            Next

        End If
        Console.ReadLine()
    End Sub


End Module