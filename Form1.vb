' Form1.vb

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use the functions from Functions.vb
        Dim name As String = "John"
        MessageBox.Show(Greet(name), "Greeting")

        Dim num1 As Integer = 5
        Dim num2 As Integer = 10
        Dim result As Integer = AddNumbers(num1, num2)

        MessageBox.Show($"The sum of {num1} and {num2} is: {result}", "Addition")
    End Sub

End Class
