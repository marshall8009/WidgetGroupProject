Public Class frmDetails
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Public Sub New(ByVal psName As String, ByVal psAddr As String, ByVal psCity As String,
                    ByVal ciZip As String, ByVal ciPhone As String,
                    ByVal esStates As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.lblCompanyDetails.Text = psName
        Me.lblAddressDetails.Text = psAddr
        Me.lblCityDetails.Text = psCity
        Me.lblZipcodeDetails.Text = ciZip
        Me.lblPhoneDetails.Text = ciPhone
        Me.lblStateDetails.Text = esStates
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class