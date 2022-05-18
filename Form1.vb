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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        semn = "nu"
        If (String.IsNullOrEmpty(Me.ComboBox1.Text)) Then
            MsgBox("Selecteaza grupul")
        Else
            If (String.IsNullOrEmpty(Me.TextBox1.Text)) And (String.IsNullOrEmpty(Me.TextBox2.Text)) Then
                MsgBox("Trebuie sa introduci un utilizator si o parola")
            Else
                If (String.IsNullOrEmpty(Me.TextBox1.Text)) Then
                    MsgBox("Trebuie sa introduci un utilizator")
                ElseIf (String.IsNullOrEmpty(Me.TextBox2.Text)) Then
                    MsgBox("Trebuie sa introduci o parola")
                Else
                    If i1 = 0 Then
                        For i2 = 0 To Form2.ComboBox1.Items.Count - 1
                            If Me.TextBox1.Text = Form2.ComboBox1.Items.Item(i2) Then
                                semn = "ok"
                                If Me.TextBox2.Text = Form2.ComboBox2.Items.Item(i2) Then
                                    MsgBox("Am inceput prelucrarea")

                                    Me.Hide()
                                    Form2.Show()
                                Else
                                    MsgBox("Parola este gresita")
                                End If
                            End If
                        Next
                    End If

                    If i1 = 1 Then
                        For i2 = 0 To Form2.ComboBox3.Items.Count - 1
                            If Me.TextBox1.Text = Form2.ComboBox3.Items.Item(i2) Then
                                semn = "ok"
                                If Me.TextBox2.Text = Form2.ComboBox4.Items.Item(i2) Then
                                    MsgBox("Am inceput prelucrarea")
                                    Me.Hide()
                                    Form2.Show()
                                Else
                                    MsgBox("Parola este gresita")
                                End If
                            End If
                        Next
                    End If

                    If i1 = 2 Then
                        For i2 = 0 To Form2.ComboBox5.Items.Count - 1
                            If Me.TextBox1.Text = Form2.ComboBox5.Items.Item(i2) Then
                                semn = "ok"
                                If Me.TextBox2.Text = Form2.ComboBox6.Items.Item(i2) Then
                                    MsgBox("Am inceput prelucrarea")

                                    Me.Hide()
                                    Form2.Show()
                                Else
                                    MsgBox("Parola este gresita")
                                End If
                            End If
                        Next
                    End If

                    If i1 = 3 Then
                        For i2 = 0 To Form2.ComboBox7.Items.Count - 1
                            If Me.TextBox1.Text = Form2.ComboBox7.Items.Item(i2) Then
                                semn = "ok"
                                If Me.TextBox2.Text = Form2.ComboBox8.Items.Item(i2) Then
                                    MsgBox("Am inceput prelucrarea")

                                    Me.Hide()
                                    Form2.Show()
                                Else
                                    MsgBox("Parola este gresita")
                                End If
                            End If
                        Next
                    End If
                    If semn = "nu" Then

                        MsgBox("Utilizator incorect")
                    End If
                End If
            End If
        End If
    End Sub
End Class
