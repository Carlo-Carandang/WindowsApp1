'  File ContactForm
'  Sample code was taken from:
'  'https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-read-from-comma-delimited-text-files
' 
' Requirements:
' Exapand on the below example to create a Display the contents of the CSV file created in Assignment1
' For contacts with the following data
' First Name (TextBox)
' Last Name (TextBox)
' Street Number (TextBox)
' City (TextBox) 
' Province (TextBox)
' Country (TextBox)
' Postal Code  (TextBox)( https://stackoverflow.com/questions/16614648/canadian-postal-code-regex)
' Phone Number (TextBox)( http://www.visual-basic-tutorials.com/Tutorials/Strings/validate-phone-number-in-visual-basic.htm)
' email Address (TextBox)( https://stackoverflow.com/questions/1331084/how-do-i-validate-email-address-formatting-with-the-net-framework)
'
' Add Next and Prevous Buttons to navigate through the file ( handle index 0 and max index)
' Display the current index at all times
' Add a Status TextBox and dispaly any formatting errors that are encoutered, 
' If multiple errors exist only show last one.
'
' Please always try to write clean And readable code
' Here Is a good reference doc http://ricardogeek.com/docs/clean_code.html  
' Submit to Bitbucket under Assignment2


Public Class ContactForm

    Dim index As Integer = 0

    'hashtable sample code
    ' https://support.microsoft.com/en-ca/help/307933/how-to-work-with-the-hashtable-collection-in-visual-basic--net-or-in-v
    '
    Dim allData As New Dictionary(Of Integer, Customer)

    Dim RowIdxFirstName As Integer = 0
    Public Property csvFile As String = "C:\Users\dpenny\Documents\Source\Repos\mcda5510_assignments\WindowsApp1\names.csv"

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles bn_next.Click
        'TODO check for max

        'index = index + 1

        'UpdateData(index)

    End Sub

    Private Sub UpdateDataForDB(key As Integer)
        Dim cust As Customer = allData(key)
        tb_index.Text = key
        fname.Text = cust.firstName
    End Sub


    Private Sub UpdateData(index As Integer)
        Dim personData As Customer = Nothing
        If allData.TryGetValue(index, personData) Then
            tb_index.Text = index
            fname.Text = personData.firstName
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'LoadFromCSVFile()
        LoadFromDatabase()

    End Sub

    Private Sub LoadFromDatabase()
        Using context As New Model1
            Dim listOfCustomers = context.Customers.ToList

            For Each cust As Customer In listOfCustomers
                allData.Add(cust.Id, cust)
                UpdateDataForDB(cust.Id)
            Next
            Dim NewCust As New Customer
            NewCust.firstName = "Daniel"
            NewCust.Id = 44
            context.Customers.Add(NewCust)
            context.SaveChanges()

        End Using
    End Sub

    'Private Sub LoadFromCSVFile()
    '    Using MyReader As New Microsoft.VisualBasic.
    '                          FileIO.TextFieldParser(
    '                            csvFile)
    '        MyReader.TextFieldType = FileIO.FieldType.Delimited
    '        MyReader.SetDelimiters(",")
    '        Dim currentRow As String()
    '        Dim rowNumber As Integer = 0
    '        While Not MyReader.EndOfData
    '            Try
    '                currentRow = MyReader.ReadFields()
    '                Dim rowData As New ArrayList
    '                Dim currentField As String
    '                For Each currentField In currentRow
    '                    rowData.Add(currentField)
    '                Next
    '                allData.Add(rowNumber, rowData)
    '                rowNumber = rowNumber + 1
    '            Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
    '                MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
    '            End Try
    '        End While
    '    End Using
    '    UpdateData(0)
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'TODO check for 0

        'index = index - 1

        'UpdateData(index)

    End Sub

End Class
