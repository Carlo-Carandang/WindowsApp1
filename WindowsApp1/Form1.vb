Public Class Form1

    Dim index As Integer = 0

    'hashtable sample code
    ' https://support.microsoft.com/en-ca/help/307933/how-to-work-with-the-hashtable-collection-in-visual-basic--net-or-in-v
    '
    Dim allData As New Hashtable

    Dim RowIdxFirstName As Integer = 0

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles bn_next.Click
        'TODO check for max

        index = index + 1

        updateData(index)

    End Sub

    Private Sub updateData(index As Integer)
        Dim personData As ArrayList = allData(index)

        fname.Text = personData.Item(RowIdxFirstName)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Sample code taken from
        'https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-read-from-comma-delimited-text-files
        '
        Using MyReader As New Microsoft.VisualBasic.
                              FileIO.TextFieldParser(
                                "C:\Users\dpenny\Documents\Visual Studio 2017\Projects\WindowsApp1\WindowsApp1\names.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            Dim rowNumber As Integer = 0
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim rowData As New ArrayList
                    Dim currentField As String
                    For Each currentField In currentRow
                        rowData.Add(currentField)
                    Next
                    allData.Add(rowNumber, rowData)
                    rowNumber = rowNumber + 1
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
        updateData(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'TODO check for 0

        index = index - 1

        updateData(index)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
