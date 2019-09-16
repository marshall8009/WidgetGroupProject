Imports System.IO

Public Class frmMain

#Region "Private Members"

    Private fobjVendors As CVenders
    Private fobjVen As CVender
    Private fnSelectionID As Integer
    Private selectedTextForStates As String = ""

#End Region

#Region "Public Methods"

    Public Sub Handler(ByVal DataDirty As Boolean)
        cmdSave.Enabled = DataDirty
    End Sub

#End Region

#Region "Private Methods"

    ''' <summary>
    ''' Creates and assigns bindings to all form fields.
    ''' </summary>
    Private Sub BindControls()
        fobjVen = fobjVendors.Item(fnSelectionID)

        txtCoName.DataBindings.Add("Text", fobjVen, "CompanyName")
        txtAddress.DataBindings.Add("Text", fobjVen, "Address")
        txtCity.DataBindings.Add("Text", fobjVen, "City")
        txtZipCode.DataBindings.Add("Text", fobjVen, "Zipcode")
        txtPhoneNumber.DataBindings.Add("Text", fobjVen, "PhoneNumber")

        ''This data binding will set the state value from sample data
        ''If state value gets changed, and focus is moved to another text box,
        ''This reverts back to original value
        ''ie: Original state value is OK, change to CA, upon leaving combobox, value reverts back to OK
        ''cmbState.DataBindings.Add("Text", fobjVen, "State")

        cmdSave.DataBindings.Add("Enabled", fobjVen, "Dirtied")
    End Sub

    ''' <summary>
    ''' Clear all bindings, then calls BindControls
    ''' </summary>
    Private Sub UpdateDataBindings()
        txtCoName.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtCity.DataBindings.Clear()
        txtZipCode.DataBindings.Clear()
        txtPhoneNumber.DataBindings.Clear()
        cmbState.DataBindings.Clear()
        cmdSave.DataBindings.Clear()

        BindControls()
    End Sub

    Private Sub TogglePreviousNext()
        cmdNext.Enabled = fnSelectionID < fobjVendors.Count - 1
        cmdPrev.Enabled = fnSelectionID > 0
    End Sub

#End Region

#Region "Event Handlers"
    Dim fileName As String = "C:\data\test.txt"
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'binds combo box to enum values
            cmbState.DisplayMember = "Value"
            cmbState.ValueMember = "Key"
            cmbState.DataSource = [Enum].GetValues(GetType(EStates))
            fobjVendors = New CVenders
            fobjVendors.GetVendors()

            fnSelectionID = 0
            UpdateDataBindings()
            TogglePreviousNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Scroll forward through vendor collection and toggle buttons accordingly.
    ''' </summary>
    Private Sub cmdNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If txtPhoneNumber.Text.All(AddressOf Char.IsDigit) And txtZipCode.Text.All(AddressOf Char.IsDigit) Then
            Try
                fnSelectionID += 1
                UpdateDataBindings()
                TogglePreviousNext()

                ' Switch to Company Name for editing purposes.
                txtCoName.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Please enter only digits for Zipcode and Phone number")
        End If
    End Sub

    ''' <summary>
    ''' Scroll back through vendor collection and toggle buttons accordingly.
    ''' </summary>
    Private Sub cmdPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        Try
            fnSelectionID -= 1
            UpdateDataBindings()
            TogglePreviousNext()

            ' Switch to Company Name for editing purposes.
            txtCoName.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Launch save file dialog.
    ''' </summary>
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim vendor As CVender = New CVender(txtCoName.Text, txtAddress.Text, txtCity.Text, txtZipCode.Text, txtPhoneNumber.Text, selectedTextForStates)

            If File.Exists(fileName) = True Then
                Dim list As List(Of String) = New List(Of String)
                If txtPhoneNumber.Text.All(AddressOf Char.IsDigit) And txtZipCode.Text.All(AddressOf Char.IsDigit) Then

                    list.Add($"{vendor.CompanyName}|")
                    list.Add($"{vendor.Address}|")
                    list.Add($"{vendor.City}|")
                    list.Add($"{vendor.Zipcode}|")
                    list.Add($"{vendor.State}|")
                    list.Add($"{vendor.PhoneNumber}")

                    Dim objWriter As New StreamWriter(fileName, True)

                    For Each item In list
                        objWriter.Write(item)
                    Next
                    objWriter.WriteLine()
                    objWriter.Close()

                    fobjVendors.Add(New CVender(vendor.CompanyName, vendor.Address, vendor.City, vendor.Zipcode, vendor.PhoneNumber, vendor.State))

                    MessageBox.Show("Text written to file")

                    CVender.DisableButton(cmdSave)
                Else
                    MessageBox.Show("Please enter only digits for Zipcode and Phone number")
                End If
            Else
                MessageBox.Show("File Does Not Exist")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Launch open file dialog.
    ''' </summary>
    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        Try
            If File.Exists(fileName) = True Then
                Dim fileReader As StreamReader
                fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\data\test.txt")
                Dim stringReader As String
                stringReader = fileReader.ReadToEnd()
                MessageBox.Show("File loaded")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CmdDetails_Click(sender As Object, e As EventArgs) Handles cmdDetails.Click
        'Displays all info correctly except for state, displays state as the ID number rather than 2 letter code
        'Dim vendor As CVender = New CVender(txtCoName.Text, txtAddress.Text, txtCity.Text, txtZipCode.Text, txtPhoneNumber.Text, cmbState.SelectedText)

        Dim frm As New frmDetails(txtCoName.Text, txtAddress.Text, txtCity.Text, txtZipCode.Text, txtPhoneNumber.Text, cmbState.Text)
        frm.Show()
    End Sub

    Private Sub CmbState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbState.SelectedIndexChanged
        ''sets the variable to index of selected state and goes to save event, 
        ''passes to class, then parse it to the enum
        selectedTextForStates = cmbState.SelectedIndex
        Handler(True)
    End Sub


#End Region

End Class
