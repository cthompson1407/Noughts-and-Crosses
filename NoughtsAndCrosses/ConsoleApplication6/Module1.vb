Module Module1
    Dim grid(3, 3) As Char
    Dim o_over As Boolean = False
    Dim over As Boolean = False
    Sub Main()
        Dim value1 As Integer = "1"     ' grid(1, 1)
        Dim value2 As Integer = "2"     ' grid(0,0)(2,0)(0,2)(2,2)
        Dim value3 As Integer = "3"     ' grid(1,0)(0,1)(1,2)(2,1)
        Dim a1 As Integer = "0"
        Dim a2 As Integer = "0"
        Dim a3 As Integer = "0"
        Dim b1 As Integer = "0"
        Dim b2 As Integer = "0"
        Dim b3 As Integer = "0"
        Dim c1 As Integer = "0"
        Dim c2 As Integer = "0"
        Dim c3 As Integer = "0"

        SetGrid()

        While grid(0, 0) = "-" Or grid(0, 1) = "-" Or grid(0, 2) = "-" Or grid(1, 0) = "-" Or grid(1, 1) = "-" Or grid(1, 2) = "-" Or grid(2, 0) = "-" Or grid(2, 1) = "-" Or grid(2, 2) = "-"
            If over = False Then
                'checks to see if the game is over
                Console.Clear()
                WriteGrid()
                Console.WriteLine("Where would you like to put your X ?")
                Console.WriteLine("A1,A2,A3,B1,B2,B3,C1,C2,C3")
                Dim answer2 As String = Console.ReadLine()
                o_over = False
                'changes the end of the computers true to false

                Select Case answer2.ToUpper()
                    Case "A1"
                        If grid(0, 0) = "-" Then
                            grid(0, 0) = "X"
                        ElseIf grid(0, 0) = "X" Or grid(0, 0) = "O" Then
                            Console.WriteLine("Select again")
                            o_over = True
                        End If
                    'changes the entered place into an X, unless it is already taken
                    Case "A2"
                        If grid(0, 1) = "-" Then
                            grid(0, 1) = "X"
                        ElseIf grid(0, 1) = "X" Or grid(0, 1) = "O" Then
                            Console.WriteLine("Select again")
                            o_over = True
                        End If
                    Case "A3"
                        If grid(0, 2) = "-" Then
                            grid(0, 2) = "X"
                        ElseIf grid(0, 2) = "X" Or grid(0, 2) = "O" Then
                            Console.WriteLine("Select again")
                            o_over = True
                        End If
                    Case "B1"
                        If grid(1, 0) = "-" Then
                            grid(1, 0) = "X"
                        ElseIf grid(1, 0) = "X" Or grid(1, 0) = "O" Then
                            Console.WriteLine("Select again")
                            o_over = True
                        End If
                    Case "B2"
                        If grid(1, 1) = "-" Then
                            grid(1, 1) = "X"
                        ElseIf grid(1, 1) = "X" Or grid(1, 1) = "O" Then
                            Console.WriteLine("Select again")
                            o_over = True
                        End If
                    Case "B3"
                        If grid(1, 2) = "-" Then
                            grid(1, 2) = "X"
                        ElseIf grid(1, 2) = "X" Or grid(1, 2) = "O" Then
                            Console.WriteLine("Select again")
                            o_over = True
                        End If
                    Case "C1"
                        If grid(2, 0) = "-" Then
                            grid(2, 0) = "X"
                        ElseIf grid(2, 0) = "X" Or grid(2, 0) = "O" Then
                            Console.WriteLine("Select again")
                            o_over = True
                        End If
                    Case "C2"
                        If grid(2, 1) = "-" Then
                            grid(2, 1) = "X"
                        ElseIf grid(2, 1) = "X" Or grid(2, 1) = "O" Then
                            Console.WriteLine("Select again")
                            o_over = True
                        End If
                    Case "C3"
                        If grid(2, 2) = "-" Then
                            grid(2, 2) = "X"
                        ElseIf grid(2, 2) = "X" Or grid(2, 2) = "O" Then
                            Console.WriteLine("Select again")
                            o_over = True
                        End If
                    Case Else
                        Console.WriteLine("Select again")
                        o_over = True
                End Select

                If grid(0, 0) = "-" Or grid(0, 1) = "-" Or grid(0, 2) = "-" Or grid(1, 0) = "-" Or grid(1, 1) = "-" Or grid(1, 2) = "-" Or grid(2, 0) = "-" Or grid(2, 1) = "-" Or grid(2, 2) = "-" Then
                    'posibilities()
                    'makes the machine able block or win on its move and then ends its turn
                    If o_over = False Then
                        Dim xpos As Integer = -1
                        Dim ypos As Integer = -1
                        Dim random As New Random
                        Do
                            Do
                                xpos = random.Next(0, 3)
                                ypos = random.Next(0, 3)
                            Loop Until grid(xpos, ypos) = "-"
                            'randomly generates a coordinate until that space is empty
                            If xpos = 0 And ypos = 0 Then
                                a1 = a1 + 1
                                If a1 = value2 Then
                                    grid(xpos, ypos) = "O"
                                End If
                                'these add one to the value of the space and then checks to see if that is equal to the value of the space
                                'before entering it into the space
                            ElseIf xpos = 1 And ypos = 0 Then
                                a2 = a2 + 1
                                If a2 = value3 Then
                                    grid(xpos, ypos) = "O"
                                End If
                            ElseIf xpos = 2 And ypos = 0 Then
                                a3 = a3 + 1
                                If a3 = value2 Then
                                    grid(xpos, ypos) = "O"
                                End If
                            ElseIf xpos = 0 And ypos = 1 Then
                                b1 = b1 + 1
                                If b1 = value3 Then
                                    grid(xpos, ypos) = "O"
                                End If
                            ElseIf xpos = 1 And ypos = 1 Then
                                b2 = b2 + 1
                                If b2 = value1 Then
                                    grid(xpos, ypos) = "O"
                                End If
                            ElseIf xpos = 2 And ypos = 1 Then
                                b3 = b3 + 1
                                If b3 = value3 Then
                                    grid(xpos, ypos) = "O"
                                End If
                            ElseIf xpos = 0 And ypos = 2 Then
                                c1 = c1 + 1
                                If c1 = value2 Then
                                    grid(xpos, ypos) = "O"
                                End If
                            ElseIf xpos = 1 And ypos = 2 Then
                                c2 = c2 + 1
                                If c2 = value3 Then
                                    grid(xpos, ypos) = "O"
                                End If
                            ElseIf xpos = 2 And ypos = 2 Then
                                c3 = c3 + 1
                                If c3 = value2 Then
                                    grid(xpos, ypos) = "O"
                                End If
                            End If
                        Loop Until grid(xpos, ypos) = "O"
                        'above is looped until an O is enterd
                        a1 = 0
                        a2 = 0
                        a3 = 0
                        b1 = 0
                        b2 = 0
                        b3 = 0
                        c1 = 0
                        c2 = 0
                        c3 = 0
                        'resets the value of the spaces
                    End If
                Else
                    over = True
                    Console.WriteLine("Game over")
                    Console.WriteLine("Do you want to play again?")
                    Console.ReadLine()
                End If
                Console.Clear()
                WriteGrid()
            ElseIf over = True Then
                Console.WriteLine("Game over")
                Console.WriteLine("Do you want to play again?")
                Console.ReadLine()
            End If
            game_over()
        End While
        Console.ReadLine()
    End Sub
    Sub WriteGrid()
        Console.WriteLine("  A B C")
        Console.WriteLine("1 " & grid(0, 0) & " " & grid(1, 0) & " " & grid(2, 0))
        Console.WriteLine("2 " & grid(0, 1) & " " & grid(1, 1) & " " & grid(2, 1))
        Console.WriteLine("3 " & grid(0, 2) & " " & grid(1, 2) & " " & grid(2, 2))

    End Sub
    Sub game_over()
        If (grid(0, 0) = "X" And grid(1, 0) = "X" And grid(2, 0) = "X") Then
            Console.WriteLine("Game over, X won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(0, 0) = "O" And grid(1, 0) = "O" And grid(2, 0) = "O") Then
            Console.WriteLine("Game over, O won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(0, 1) = "X" And grid(1, 1) = "X" And grid(2, 1) = "X") Then
            Console.WriteLine("Game over, X won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(0, 1) = "O" And grid(1, 1) = "O" And grid(2, 1) = "O") Then
            Console.WriteLine("Game over, O won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(0, 2) = "X" And grid(1, 2) = "X" And grid(2, 2) = "X") Then
            Console.WriteLine("Game over, X won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(0, 2) = "O" And grid(1, 2) = "O" And grid(2, 2) = "O") Then
            Console.WriteLine("Game over, O won.")
            Console.WriteLine("Do you want to play again?")
            over = True

        ElseIf (grid(0, 0) = "X" And grid(0, 1) = "X" And grid(0, 2) = "X") Then
            Console.WriteLine("Game over, X won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(0, 0) = "O" And grid(0, 1) = "O" And grid(0, 1) = "O") Then
            Console.WriteLine("Game over, O won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(1, 0) = "X" And grid(1, 1) = "X" And grid(1, 2) = "X") Then
            Console.WriteLine("Game over, X won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(1, 0) = "O" And grid(1, 1) = "O" And grid(1, 2) = "O") Then
            Console.WriteLine("Game over, O won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(2, 0) = "X" And grid(2, 1) = "X" And grid(2, 2) = "X") Then
            Console.WriteLine("Game over, X won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(2, 0) = "O" And grid(2, 1) = "O" And grid(2, 2) = "O") Then
            Console.WriteLine("Game over, O won.")
            Console.WriteLine("Do you want to play again?")
            over = True

        ElseIf (grid(0, 0) = "X" And grid(1, 1) = "X" And grid(2, 2) = "X") Then
            Console.WriteLine("Game over, X won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(0, 0) = "O" And grid(1, 1) = "O" And grid(2, 2) = "O") Then
            Console.WriteLine("Game over, O won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(2, 0) = "X" And grid(1, 1) = "X" And grid(0, 2) = "X") Then
            Console.WriteLine("Game over, X won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf (grid(2, 0) = "O" And grid(1, 1) = "O" And grid(0, 2) = "O") Then
            Console.WriteLine("Game over, O won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        ElseIf Not (grid(0, 0) = "-" Or grid(0, 1) = "-" Or grid(0, 2) = "-" Or grid(1, 0) = "-" Or grid(1, 1) = "-" Or grid(1, 2) = "-" Or grid(2, 0) = "-" Or grid(2, 1) = "-" Or grid(2, 2) = "-") Then
            Console.WriteLine("Game over, X won.")
            Console.WriteLine("Do you want to play again?")
            over = True
        End If
        If over = True Then
            Dim answer3 As String = Console.ReadLine()
            If answer3.ToLower() = "yes" Then
                'resarts the game settings
                over = False
                SetGrid()
            Else
                End
            End If
        End If
    End Sub
    Sub SetGrid()
        For a As Integer = 0 To 2
            For b As Integer = 0 To 2
                grid(a, b) = "-"
                'sets all of the grid to a "-"
            Next
        Next
        Console.Clear()
        WriteGrid()
    End Sub
End Module
