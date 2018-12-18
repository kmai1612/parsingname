Public Class Form1
    Private Sub btnBeggin_Click(sender As Object, e As EventArgs) Handles btnBeggin.Click

        ' create the variables
        Dim strName As String
        Dim strYes_No As String
        Dim strFirstName, strMiddleAndLast, strMiddleName, strLastName As String
        Dim i As Integer

        lstName.Items.Clear()
        lstName.Items.Add("First Name" & vbTab & "Middle Name" & vbTab & "Last Name")
        strYes_No = InputBox("Do you want to enter a name? Type Yes or No", "Answer Question")
        strYes_No = strYes_No.ToUpper()

        Do While strYes_No = "YES"

            strName = InputBox("Enter A Full Name Please", "Enter A Full Name")

            i = strName.IndexOf(" ")

            strFirstName = strName.Substring(0, i).ToString()
            'Get first name
            strMiddleAndLast = strName.Substring(i + 1).ToString()
            i = strMiddleAndLast.IndexOf(" ")

            strMiddleName = strMiddleAndLast.Substring(0, i).ToString()
            'get middle name
            strLastName = strMiddleAndLast.Substring(i + 1).ToString()
            'Get last name

            'Output of Name into the listbox
            lstName.Items.Add(strFirstName & vbTab & vbTab & strMiddleName & vbTab & vbTab & strLastName)

            strYes_No = InputBox("Do you want to enter a name? Type Yes or No", "Answer Question")
            strYes_No = strYes_No.ToUpper()
        Loop


    End Sub
End Class
