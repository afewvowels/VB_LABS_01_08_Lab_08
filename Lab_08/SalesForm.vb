'Program:		Lab #8
'Programmer:	Keith Smith
'Date:			7 November 2018
'Description:	Calculate sales price using the BookSale class.
'				Instantiate TheBookSale as a new object of the BookSale class.

Public Class SalesForm
    ' Declare the new object.
    Private TheBookSale As BookSale
    Private TheStudentBookSale As StudentBookSale
    Private SummaryWindow As SummaryWindowForm

    Private Sub CalculateSaleToolStripMenuItem_Click(ByVal sender As System.Object,
     ByVal e As System.EventArgs) Handles CalculateSaleToolStripMenuItem.Click
        ' Calculate the extended price for the sale.
        If StudentCheckBox.Checked Then
            CalculateStudentBookSale()
        Else
            CalculateBookSale()
        End If

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clear the screen controls.

        QuantityTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedPriceTextBox.Clear()
        With TitleTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exit the program.

        Me.Close()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Display the sales summary information modally.
        SummaryWindowForm.Show()
    End Sub

    ' Logic to take in textbox entries and creates a booksale object
    ' and updates shared properties
    Private Sub CalculateBookSale()
        Try
            ' Instantiate the BookSale object and set the properties.
            TheBookSale = New BookSale(TitleTextBox.Text,
                  Integer.Parse(QuantityTextBox.Text), Decimal.Parse(PriceTextBox.Text))
            ' Calculate and format the result.
            ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("C")
            ' Update summary window form data
            SummaryWindowForm.UpdateSummary()
        Catch ex As Exception
            MessageBox.Show("Enter numeric data.", "R 'n R Book Sales",
              MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ' Logic to take in textbox entries and creates a studentbooksale object
    ' and updates shared properties
    Private Sub CalculateStudentBookSale()
        Try
            ' Instantiate the BookSale object and set the properties.
            TheStudentBookSale = New StudentBookSale(TitleTextBox.Text,
                  Integer.Parse(QuantityTextBox.Text), Decimal.Parse(PriceTextBox.Text))
            ' Calculate and format the result.
            ExtendedPriceTextBox.Text = TheStudentBookSale.ExtendedPrice.ToString("C")
            ' Update summary window form data
            SummaryWindowForm.UpdateSummary()
        Catch ex As Exception
            MessageBox.Show("Enter numeric data.", "R 'n R Book Sales",
              MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
