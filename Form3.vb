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
            Me.ListBox1.Items.Add("Letter " & alphabet(index) & ": " & counter(index))  'afisam lista de caractere si de cate ori se repeta
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim str As String
        Dim i, l, words As Integer
        str = Me.RichTextBox1.Text

        str = LTrim(str) 'strege spatile in plus de la inceputul textului
        str = RTrim(str) 'sterge spatile in plus de la sfarsitul textului
        l = str.Length
        i = 0
        words = 0
        While (i < l)
            If str(i) = " " Then
                words = words + 1
                i = i + 1
                While str(i) = " "  'sterge spatiu in caz ca sunt lipite impreuna
                    i = i + 1
                End While
            Else
                i = i + 1
            End If

        End While

        words = words + 1 'adauga ultimul cuvant 
        Me.ListBox1.Items.Add("words: " & words)
    End Sub
End Class