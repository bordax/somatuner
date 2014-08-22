Public Class frmMain
    Dim RadioName As String
    Dim RadioURL As String

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Just a test
        Dim objRadio As New Radio("dubstep")
        Dim RadioName As String = objRadio.pName
        Dim RadioURL As String = objRadio.pURL
        player.URL = RadioURL

    End Sub
End Class
