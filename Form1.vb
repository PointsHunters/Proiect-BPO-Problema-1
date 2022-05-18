Public Class Form1
    Public i1 As Integer
    Public i2 As Integer
    Public semn As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
        Form2.Hide()
        Me.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        i1 = Me.ComboBox1.SelectedIndex
        semn = "nu"
        If i1 = 0 Then
            For i2 = 0 To Form2.ComboBox1.Items.Count - 1
                If Me.TextBox1.Text = Form2.ComboBox1.Items.Item(i2) Then
                    semn = "ok"
                    If Me.TextBox2.Text = Form2.ComboBox2.Items.Item(i2) Then
                        MsgBox("am inceput prelucrarea")

                        Me.Hide()
                        Form2.Show()
                    Else
                        MsgBox("parola este gresita")
                    End If
                End If
            Next
            If semn = "nu" Then

                MsgBox("utilizator incorect")
            End If
        End If
        semn = "nu"
        If i1 = 1 Then
            For i2 = 0 To Form2.ComboBox3.Items.Count - 1
                If Me.TextBox1.Text = Form2.ComboBox3.Items.Item(i2) Then
                    semn = "ok"
                    If Me.TextBox2.Text = Form2.ComboBox4.Items.Item(i2) Then
                        MsgBox("am inceput prelucrarea")
                        Me.Hide()
                        Form2.Show()
                    Else
                        MsgBox("parola este gresita")
                    End If
                End If
            Next
            If semn = "nu" Then

                MsgBox("utilizator incorect")
            End If
        End If
        semn = "nu"
        If i1 = 2 Then
            For i2 = 0 To Form2.ComboBox5.Items.Count - 1
                If Me.TextBox1.Text = Form2.ComboBox5.Items.Item(i2) Then
                    semn = "ok"
                    If Me.TextBox2.Text = Form2.ComboBox6.Items.Item(i2) Then
                        MsgBox("am inceput prelucrarea")

                        Me.Hide()
                        Form2.Show()
                    Else
                        MsgBox("parola este gresita")
                    End If
                End If
            Next
            If semn = "nu" Then

                MsgBox("utilizator incorect")
            End If
        End If
        semn = "nu"
        If i1 = 3 Then
            For i2 = 0 To Form2.ComboBox7.Items.Count - 1
                If Me.TextBox1.Text = Form2.ComboBox7.Items.Item(i2) Then
                    semn = "ok"
                    If Me.TextBox2.Text = Form2.ComboBox8.Items.Item(i2) Then
                        MsgBox("am inceput prelucrarea")

                        Me.Hide()
                        Form2.Show()
                    Else
                        MsgBox("parola este gresita")
                    End If
                End If
            Next
            If semn = "nu" Then

                MsgBox("utilizator incorect")
            End If
        End If
    End Sub
End Class
