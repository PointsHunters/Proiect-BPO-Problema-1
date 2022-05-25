Public Class Form3
    Public ltext As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim number As Integer
        ltext = Me.RichTextBox1.Text
        'number = 0
        'For Each letter In ltext
        'number = number + 1
        'Next
        MsgBox("The number of characters in the text is " & Len(ltext))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim counter = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim alphabet = New String() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Me.ListBox1.Items.Clear()
        ltext = Me.RichTextBox1.Text
        If Len(ltext) > 0 Then
            For Each letter In ltext
                For index = 0 To 25
                    If letter = alphabet(index) Then
                        counter(index) = counter(index) + 1
                        Exit For
                    End If
                Next
            Next
        End If
        For index = 0 To 25
            Me.ListBox1.Items.Add("Letter " & alphabet(index) & ": " & counter(index))
        Next
    End Sub
End Class