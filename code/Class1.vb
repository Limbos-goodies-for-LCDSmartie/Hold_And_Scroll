Imports System.Text

Public Class LCDSmartie
    Dim QQ As Integer



    Public Function function1(ByVal param1 As String, ByVal param2 As String) As String
        If param1 = "about" And param2 = "function" Then
            Return " keeps steady the first parameter and scrolls the second parameter text in given length (before " / " symbol)"

        Else
            Dim Scroll = Split(param2, "/")
            If Scroll(0) > 1 Then
                Dim i As Integer
                For i = 0 To (Scroll(0) - 1)
                    Scroll(1) = " " & Scroll(1)
                Next i
            End If

            If QQ < Len(Scroll(1)) + 1 Then
                QQ = QQ + 1
            Else
                QQ = 1
            End If
            Return param1 & Mid(Scroll(1), QQ, Scroll(0))
        End If

    End Function




    Public Function function20(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" And param2 = "function" Then
            Return "  Developer: Nikos Georgousis "

        Else
            Return " holdnscroll v1.0 by Limbo"

        End If

    End Function
    Public Function SmartieDemo()
        Dim demolist As New StringBuilder()

        demolist.AppendLine("holdnscroll plugin for LCD Smartie")
        demolist.AppendLine("This plugin keeps steady one part of the screen and scrolls a text in given length of the rest if the screen.")
        demolist.AppendLine("TIP: You must disable 'scroll this line' ")
        demolist.AppendLine("------ Function1 ------")
        demolist.AppendLine("keeps steady the first parameter and scrolls the second parameter text in given length (before '/' symbol)")
        demolist.AppendLine("Example: $dll(holdnscroll,1,Steady:,12/This is the long text to scroll) ")
        demolist.AppendLine("Winamp: $dll(holdnscroll,1,Artist:,12/$dll(splittitle,11,$WinampTitle,-)) ")
        demolist.AppendLine("------ Function20 ------")
        demolist.AppendLine(">>>  Credits <<<")
        demolist.AppendLine("---------------------------------------------------------------------------------------------------------")
        demolist.AppendLine(" *** Visit ***")
        demolist.AppendLine("> Home page")
        demolist.AppendLine("https://lcdsmartie.sourceforge.net")
        demolist.AppendLine("> Forums")
        demolist.AppendLine("https://www.lcdsmartie.org")
        demolist.AppendLine("> Active development branch (latest version)")
        demolist.AppendLine("https://github.com/stokie-ant/lcdsmartie-laz")
        demolist.AppendLine("")

        Dim result As String = demolist.ToString()
        Return result
    End Function

    Public Function SmartieInfo()
        Return "Developer: Nikos Georgousis (limbo)" & vbNewLine & "Version: 1.0 "
    End Function

End Class
