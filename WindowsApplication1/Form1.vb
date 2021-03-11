Public Class Form1
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const cEUR As Double = 4.6
        Const cUSD As Double = 4.2
        Const cGBP As Double = 5
        Dim dec, nec As Double
        If IsNumeric(TextBox1.Text) Then
            dec = Convert.ToDouble(TextBox1.Text)
            If RadioButton1.Checked = True Then
                nec = dec / cEUR
                Label1.Text = ("Conversie in EUR reusita!")
            ElseIf RadioButton2.Checked Then
                nec = dec / cGBP
                Label1.Text = ("Conversie in GBP reusita!")
            ElseIf RadioButton3.Checked = True Then
                nec = dec / cUSD
                Label1.Text = ("Conversie in USD reusita!")

            Else
                MsgBox("Nicio valuta selectata", MsgBoxStyle.Critical, "Error")
                Label1.Text = ("Conversie nereusita. Criterii neindeplinite!")
                TextBox2.Clear()
                Exit Sub
            End If
            TextBox2.Text = nec.ToString()
        Else
            MsgBox("Valoarea introdusa nu este numerica", MsgBoxStyle.Critical, "Error")
            Label1.Text = ("Conversie nereusita. Criterii neindeplinite!")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
