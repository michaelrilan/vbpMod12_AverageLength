Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1 As String
        Dim s2 As String
        Dim s3 As String
        Dim aver As Double
        s1 = sentence1.Text
        s2 = sentence2.Text
        s3 = sentence3.Text

        aver = (Len(s1) + Len(s2) + Len(s3)) / 3
        resultss.Text = "The average length of the 3 sentences is " & aver


    End Sub
End Class
