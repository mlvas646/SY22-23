﻿Imports System.IO

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim myVariable As Decimal
        If TextBox.Text = "" Then
            myVariable = 32
        Else
            Decimal.TryParse(textBox1.Text, myVariable)
        End If
        Dim myVariable2 As Decimal
        textBox1.Text = myVariable
        Decimal.TryParse(textBox1.Text, myVariable2)
        textBox1.Text = myVariable2 / 2
    End Sub
    Private Sub Bold_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontWeight = FontWeights.Bold
    End Sub

    Private Sub Bold_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontWeight = FontWeights.Normal
    End Sub

    Private Sub Italic_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontStyle = FontStyles.Italic
    End Sub

    Private Sub Italic_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontStyle = FontStyles.Normal
    End Sub
    Dim myrandomthing As Decimal = 1.02
    Private Sub IncreaseFont_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If textBox1.FontSize < 1800000 Then
            textBox1.FontSize += myrandomthing
            myrandomthing ^= 2
        End If
    End Sub

    Private Sub DecreaseFont_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If textBox1.FontSize > 10 Then
            textBox1.FontSize -= 2
        End If
    End Sub

    Private Sub Save_Click()
        ' Create OpenFileDialog
        Dim dlg As New Microsoft.Win32.SaveFileDialog()

        ' Set filter for file extension and default file extension
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"

        ' Display OpenFileDialog by calling ShowDialog method
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox
        If result = True Then
            ' Open document
            Dim filename As String = dlg.FileName
            SaveFile(filename)
        End If
    End Sub
    Private Sub Open_Click()
        ' Create OpenFileDialog
        Dim dlg As New Microsoft.Win32.OpenFileDialog()

        ' Set filter for file extension and default file extension
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"

        ' Display OpenFileDialog by calling ShowDialog method
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox
        If result = True Then
            ' Open document
            Dim filename As String = dlg.FileName
            ShowFile(filename)
        End If
    End Sub
    Sub ShowFile(fName As String)
        Dim fileReader As System.IO.StreamReader
        fileReader = New StreamReader(fName)

        Dim stringReader As String
        stringReader = fileReader.ReadToEnd()
        textBox1.Text = stringReader
        fileReader.Close()
    End Sub
    Sub SaveFile(fName As String)
        Dim fileWriter As StreamWriter
        fileWriter = New StreamWriter(fName)
        fileWriter.Write(textBox1.Text)
        fileWriter.Close()
    End Sub
    Sub Exit_Click()
        Me.Close()
    End Sub
End Class
