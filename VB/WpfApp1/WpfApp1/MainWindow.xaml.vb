Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim myVariable As Decimal
        If TextBox.Text = "" Then
            myVariable = 32
        Else
            Decimal.TryParse(TextBox.Text, myVariable)
        End If
        Dim myVariable2 As Decimal
        TextBox.Text = myVariable
        Decimal.TryParse(TextBox.Text, myVariable2)
        TextBox.Text = myVariable2 / 2
    End Sub
End Class
