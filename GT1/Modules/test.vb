
Module test

    Public Function SubAmountStr(ByVal subAmount As Object, ByVal IsPacket As Object, ByVal UnitPriceInv As Object) As String
        Dim str As String = ""

        If IsPacket = True AndAlso IsNumeric(subAmount) AndAlso subAmount > 1 Then

            Dim SubPrice As Decimal = UnitPriceInv / subAmount

            str = "العبوة " & Format(subAmount, "#,##0.##") & " السعر " & Format(SubPrice, "#,##0.00")

        End If



        Return str
    End Function



    Public Function GetInfo(ByVal AcountID As String, ByVal AcountName As String, ByVal InvoiceNumber As Int64, ByVal InvoiceTypeName As String, ByVal AgentName As String, ByVal ExpenseType As String, ByVal OtherPaymentAcountName As String, ByVal Note As String, ByVal AgentBalance As Object) As String

        Dim str As String = ""

        Select Case AcountID
            Case 1
                str = "حساب الفواتير النقدية | " & InvoiceTypeName & " نقدية رقم " & InvoiceNumber.ToString
            Case 2
                str = "حساب سداد العملاء | " & AgentName
            Case 3
                str = "حساب المصروفات | " & ExpenseType
            Case 4
                str = "حسابات أخرى | " & OtherPaymentAcountName
        End Select

        str = str & IIf(IsNothing(Note) = True, "", " | " & "ملاحضة : " & Note)

        If IsNumeric(AgentBalance) Then

            str = str & vbNewLine & "الرصيد الحالي للعميل " & IIf(AgentBalance > 0, "له ", "عليه ") & Format(Math.Abs(AgentBalance), "#,##0.00# دينار")
        End If

        Return str
    End Function


End Module
