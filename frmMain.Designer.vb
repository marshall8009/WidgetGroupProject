<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdPrev = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.gbxSupplyVendor = New System.Windows.Forms.GroupBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCoName = New System.Windows.Forms.TextBox()
        Me.lblZipcode = New System.Windows.Forms.Label()
        Me.lblCoName = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.cmdDetails = New System.Windows.Forms.Button()
        Me.gbxSupplyVendor.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLoad
        '
        Me.cmdLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLoad.Location = New System.Drawing.Point(68, 222)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(55, 24)
        Me.cmdLoad.TabIndex = 14
        Me.cmdLoad.Text = "Load"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(10, 221)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(52, 24)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save"
        '
        'cmdPrev
        '
        Me.cmdPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrev.Location = New System.Drawing.Point(343, 221)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(60, 24)
        Me.cmdPrev.TabIndex = 10
        Me.cmdPrev.Text = "Previous"
        '
        'cmdNext
        '
        Me.cmdNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNext.Location = New System.Drawing.Point(409, 221)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(60, 24)
        Me.cmdNext.TabIndex = 11
        Me.cmdNext.Text = "Next"
        '
        'gbxSupplyVendor
        '
        Me.gbxSupplyVendor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxSupplyVendor.Controls.Add(Me.cmbState)
        Me.gbxSupplyVendor.Controls.Add(Me.txtZipCode)
        Me.gbxSupplyVendor.Controls.Add(Me.lblState)
        Me.gbxSupplyVendor.Controls.Add(Me.txtPhoneNumber)
        Me.gbxSupplyVendor.Controls.Add(Me.txtCity)
        Me.gbxSupplyVendor.Controls.Add(Me.txtAddress)
        Me.gbxSupplyVendor.Controls.Add(Me.txtCoName)
        Me.gbxSupplyVendor.Controls.Add(Me.lblZipcode)
        Me.gbxSupplyVendor.Controls.Add(Me.lblCoName)
        Me.gbxSupplyVendor.Controls.Add(Me.lblPhoneNumber)
        Me.gbxSupplyVendor.Controls.Add(Me.lblCity)
        Me.gbxSupplyVendor.Controls.Add(Me.lblAddress)
        Me.gbxSupplyVendor.Location = New System.Drawing.Point(10, 12)
        Me.gbxSupplyVendor.Name = "gbxSupplyVendor"
        Me.gbxSupplyVendor.Size = New System.Drawing.Size(458, 194)
        Me.gbxSupplyVendor.TabIndex = 9
        Me.gbxSupplyVendor.TabStop = False
        Me.gbxSupplyVendor.Text = "Supply Vendors"
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(96, 95)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(121, 21)
        Me.cmbState.TabIndex = 6
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(333, 95)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(119, 20)
        Me.txtZipCode.TabIndex = 7
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(11, 98)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhoneNumber.Location = New System.Drawing.Point(96, 126)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(356, 20)
        Me.txtPhoneNumber.TabIndex = 8
        '
        'txtCity
        '
        Me.txtCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCity.Location = New System.Drawing.Point(96, 68)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(356, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(96, 44)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(356, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtCoName
        '
        Me.txtCoName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCoName.Location = New System.Drawing.Point(96, 20)
        Me.txtCoName.Name = "txtCoName"
        Me.txtCoName.Size = New System.Drawing.Size(356, 20)
        Me.txtCoName.TabIndex = 3
        '
        'lblZipcode
        '
        Me.lblZipcode.AutoSize = True
        Me.lblZipcode.Location = New System.Drawing.Point(255, 98)
        Me.lblZipcode.Name = "lblZipcode"
        Me.lblZipcode.Size = New System.Drawing.Size(49, 13)
        Me.lblZipcode.TabIndex = 1
        Me.lblZipcode.Text = "Zipcode:"
        '
        'lblCoName
        '
        Me.lblCoName.AutoSize = True
        Me.lblCoName.Location = New System.Drawing.Point(11, 24)
        Me.lblCoName.Name = "lblCoName"
        Me.lblCoName.Size = New System.Drawing.Size(85, 13)
        Me.lblCoName.TabIndex = 0
        Me.lblCoName.Text = "Company Name:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(11, 130)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblPhoneNumber.TabIndex = 1
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(11, 72)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 1
        Me.lblCity.Text = "City:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(11, 48)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address:"
        '
        'cmdDetails
        '
        Me.cmdDetails.Location = New System.Drawing.Point(203, 223)
        Me.cmdDetails.Name = "cmdDetails"
        Me.cmdDetails.Size = New System.Drawing.Size(75, 23)
        Me.cmdDetails.TabIndex = 15
        Me.cmdDetails.Text = "Details"
        Me.cmdDetails.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 258)
        Me.Controls.Add(Me.cmdDetails)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.gbxSupplyVendor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Widget Group Company"
        Me.gbxSupplyVendor.ResumeLayout(False)
        Me.gbxSupplyVendor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdLoad As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdPrev As Button
    Friend WithEvents cmdNext As Button
    Friend WithEvents gbxSupplyVendor As GroupBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCoName As TextBox
    Friend WithEvents lblCoName As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblState As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblZipcode As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents cmdDetails As Button
    Friend WithEvents cmbState As ComboBox
End Class
