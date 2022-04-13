Public Class Form1
    Dim myArray(10)
    Dim random As New Random()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        For i As Integer = 0 To myArray.Length - 1
            myArray(i) = random.Next(0, 10)
            TextBox1.AppendText(Str(myArray(i)))
        Next
        Array.Sort(myArray)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Clear()
        For j As Integer = 0 To myArray.Length - 1
            TextBox2.AppendText(Str(myArray(j)))
        Next
    End Sub
End Class