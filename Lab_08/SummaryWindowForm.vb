Public Class SummaryWindowForm

    Private Sub SummaryWindowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SalesTotalTextBox.Text = BookSale.SalesTotal.ToString("C")
        SalesCountTextBox.Text = BookSale.SalesCount.ToString()
        TotalStudentDiscountTextBox.Text = StudentBookSale.TotalStudentDiscountPrice.ToString("C")
    End Sub

    Private Sub CloseWindowButton_Click(sender As Object, e As EventArgs) Handles CloseWindowButton.Click
        Me.Close()
    End Sub
End Class