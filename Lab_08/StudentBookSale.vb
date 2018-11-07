' Author:       Keith Smith
' Date:         7 November 2018
' Description:  This file holds class information for a student book sale that reflects a 15% discount
'               compared to a standard book sale object

Public Class StudentBookSale
    Inherits BookSale

    ' Student Discount %
    Const STUDENT_DISCOUNT_PERCENT_Decimal As Decimal = 0.15D

    ' Create shared accumulator variable to hold total discount amount
    Private Shared TotalStudentDiscountDecimal As Decimal

    ' Create shared read-only property so that accumulator property can be accessed
    ' to show in summary window. Needs to be shared so that property can be accessed
    ' at the OBJECT level, not at the individual INSTANTIATED level
    Public Shared ReadOnly Property TotalStudentDiscountPrice() As Decimal
        Get
            Return TotalStudentDiscountDecimal
        End Get
    End Property

    Public Sub New(ByVal _TitleIn As String, ByVal _QuantityIn As Integer, ByVal _PriceIn As Decimal)
        ' Assign the property Values.
        MyBase.New(_TitleIn, _QuantityIn, _PriceIn)
    End Sub

    Protected Overrides Sub CalculateExtendedPrice()
        ' Calculate extended price using base class...
        MyBase.CalculateExtendedPrice()
        ' ...apply student discount
        MyBase.ExtendedPrice -= CalculateStudentDiscount()
    End Sub

    ' This function calculates the student discount, adds it to the shared accumulator property,
    ' and returns the calculated value for use in logic
    Private Function CalculateStudentDiscount() As Decimal
        ' Create variable to hold calculated discount amount
        Dim DiscountAmountDecimal As Decimal

        ' Calculate student discount
        DiscountAmountDecimal = MyBase.ExtendedPrice * STUDENT_DISCOUNT_PERCENT_Decimal

        ' Update shared accumulator
        TotalStudentDiscountDecimal += DiscountAmountDecimal

        ' Return discount amount
        Return DiscountAmountDecimal
    End Function
End Class
