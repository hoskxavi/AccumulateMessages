
Imports System
Imports System.Threading

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        'your code here
        Dim messages As String
        Static oldMessage As String 'static variable retains it's value

        If clear = False Then
            If newMessage = "" Then
                messages = oldMessage
            Else
                oldMessage &= newMessage + vbCrLf
                messages = oldMessage
            End If
        Else  'clears messages when the "CLEAR" command is given
                oldMessage = ""
            messages = oldMessage
        End If

        Return messages
    End Function


End Module
