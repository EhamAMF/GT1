


Class ByteDGV
    Inherits System.Windows.Forms.DataGridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        TryCast(FindForm(), Frm_Invoice).MyKeyHandler(DirectCast(Me, DataGridView), keyData)
        'return base.ProcessCmdKey(ref msg, keyData);


        Dim o As Object = TryCast(FindForm(), Frm_Invoice).ActiveControl




        If keyData = Keys.Down Or keyData = Keys.Up Or keyData = Keys.Right Or keyData = Keys.Left Then
            Return True
        Else
            Return False
        End If



    End Function
End Class

