<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblCompanyDetails = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblAddressDetails = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblCityDetails = New System.Windows.Forms.Label()
        Me.lblZipcode = New System.Windows.Forms.Label()
        Me.lblZipcodeDetails = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblPhoneDetails = New System.Windows.Forms.Label()
        Me.lblStateDetails = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(366, 205)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(45, 23)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(85, 13)
        Me.lblCompany.TabIndex = 1
        Me.lblCompany.Text = "Company Name:"
        '
        'lblCompanyDetails
        '
        Me.lblCompanyDetails.AutoSize = True
        Me.lblCompanyDetails.Location = New System.Drawing.Point(180, 23)
        Me.lblCompanyDetails.Name = "lblCompanyDetails"
        Me.lblCompanyDetails.Size = New System.Drawing.Size(0, 13)
        Me.lblCompanyDetails.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(45, 51)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address:"
        '
        'lblAddressDetails
        '
        Me.lblAddressDetails.AutoSize = True
        Me.lblAddressDetails.Location = New System.Drawing.Point(180, 51)
        Me.lblAddressDetails.Name = "lblAddressDetails"
        Me.lblAddressDetails.Size = New System.Drawing.Size(0, 13)
        Me.lblAddressDetails.TabIndex = 4
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(45, 76)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City:"
        '
        'lblCityDetails
        '
        Me.lblCityDetails.AutoSize = True
        Me.lblCityDetails.Location = New System.Drawing.Point(180, 76)
        Me.lblCityDetails.Name = "lblCityDetails"
        Me.lblCityDetails.Size = New System.Drawing.Size(0, 13)
        Me.lblCityDetails.TabIndex = 6
        '
        'lblZipcode
        '
        Me.lblZipcode.AutoSize = True
        Me.lblZipcode.Location = New System.Drawing.Point(44, 100)
        Me.lblZipcode.Name = "lblZipcode"
        Me.lblZipcode.Size = New System.Drawing.Size(49, 13)
        Me.lblZipcode.TabIndex = 7
        Me.lblZipcode.Text = "Zipcode:"
        '
        'lblZipcodeDetails
        '
        Me.lblZipcodeDetails.AutoSize = True
        Me.lblZipcodeDetails.Location = New System.Drawing.Point(180, 100)
        Me.lblZipcodeDetails.Name = "lblZipcodeDetails"
        Me.lblZipcodeDetails.Size = New System.Drawing.Size(0, 13)
        Me.lblZipcodeDetails.TabIndex = 8
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(44, 122)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblPhoneNumber.TabIndex = 9
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblPhoneDetails
        '
        Me.lblPhoneDetails.AutoSize = True
        Me.lblPhoneDetails.Location = New System.Drawing.Point(180, 122)
        Me.lblPhoneDetails.Name = "lblPhoneDetails"
        Me.lblPhoneDetails.Size = New System.Drawing.Size(0, 13)
        Me.lblPhoneDetails.TabIndex = 10
        '
        'lblStateDetails
        '
        Me.lblStateDetails.AutoSize = True
        Me.lblStateDetails.Location = New System.Drawing.Point(181, 148)
        Me.lblStateDetails.Name = "lblStateDetails"
        Me.lblStateDetails.Size = New System.Drawing.Size(0, 13)
        Me.lblStateDetails.TabIndex = 12
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(45, 148)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 11
        Me.lblState.Text = "State:"
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 258)
        Me.Controls.Add(Me.lblStateDetails)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblPhoneDetails)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblZipcodeDetails)
        Me.Controls.Add(Me.lblZipcode)
        Me.Controls.Add(Me.lblCityDetails)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddressDetails)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCompanyDetails)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.cmdClose)
        Me.Name = "frmDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdClose As Button
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblCompanyDetails As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblAddressDetails As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblCityDetails As Label
    Friend WithEvents lblZipcode As Label
    Friend WithEvents lblZipcodeDetails As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblPhoneDetails As Label
    Friend WithEvents lblStateDetails As Label
    Friend WithEvents lblState As Label
End Class
