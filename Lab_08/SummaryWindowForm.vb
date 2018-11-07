'Program:		Lab #8
'Programmer:	Keith Smith
'Date:			7 November 2018
'Description:	Displays the calculated data from book sales to the user in a modal window

Public Class SummaryWindowForm
    ' Update textboxes on form load with calculated data
    Private Sub SummaryWindowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call update summary
        UpdateSummary()
    End Sub

    ' Close window button
    Private Sub CloseWindowButton_Click(sender As Object, e As EventArgs) Handles CloseWindowButton.Click
        ' Closes SummaryWindowForm, not the program
        Me.Close()
    End Sub

    ' Update textboxes with data from booksale and studentbooksale objects, public for use
    ' in salesform so it can be called
    Public Sub UpdateSummary()
        SalesTotalTextBox.Text = BookSale.SalesTotal.ToString("C")
        SalesCountTextBox.Text = BookSale.SalesCount.ToString()
        TotalStudentDiscountTextBox.Text = StudentBookSale.TotalStudentDiscountPrice.ToString("C")
    End Sub
End Class