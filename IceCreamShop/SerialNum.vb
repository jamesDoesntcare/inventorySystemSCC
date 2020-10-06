Public Class SerialNum

    Private Sub SerialNum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load all products in listview
        PopulateProducts(lvSerial, "")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class