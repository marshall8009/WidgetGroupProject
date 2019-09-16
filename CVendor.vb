<Serializable()> Public Class CVender

    Private csName As String
    Private csAddress As String
    Private csCity As String

    ''Changed Zip and Phone to string
    ''If phone number is entered, the value resets to zero due to arithmitic overflow
    ''If number starts with zero, it will now display the zero instead of removing it
    Private ciZipcode As String
    Private ciPhoneArea As String
    Private ciPhoneExchange As String
    Private ciPhoneNumber As String
    Private esState As EStates

    Private cbDirty As Boolean

    Public Sub New(ByVal psName As String, Optional ByVal psAddr As String = "", Optional ByVal psCity As String = "",
                   Optional ByVal ciZip As String = "", Optional ByVal ciPhone As String = "",
                   Optional ByVal esStates As EStates = 0
                   )
        csName = psName
        csAddress = psAddr
        csCity = psCity
        ciZipcode = ciZip
        ciPhoneNumber = ciPhone
        esState = [Enum].Parse(GetType(EStates), esStates)

        cbDirty = False
    End Sub

    Public Shared Sub DisableButton(sender As Button)
        Dim button As Button = DirectCast(sender, Button)
        button.Enabled = False
    End Sub

#Region " Interface Properties of the Class "
    Public Property PhoneAreaCode() As String
        Get
            Return ciPhoneArea
        End Get
        Set(ByVal value As String)
            If value <> ciPhoneArea Then
                Dirtied = True
            End If
            ciPhoneArea = value
        End Set
    End Property
    Public Property PhoneExchangeCode() As String
        Get
            Return ciPhoneExchange
        End Get
        Set(ByVal value As String)
            If value <> ciPhoneExchange Then
                Dirtied = True
            End If
            ciPhoneExchange = value
        End Set
    End Property
    Public Property PhoneNumber() As String
        Get
            Return ciPhoneNumber
        End Get
        Set(ByVal value As String)
            If value <> ciPhoneNumber Then
                Dirtied = True
            End If
            ciPhoneNumber = value
        End Set
    End Property
    Public Property State() As EStates
        Get
            Return esState
        End Get
        Set(ByVal value As EStates)
            If esState.CompareTo(value) <> 0 Then
                Dirtied = True
            End If
            esState = value
        End Set
    End Property
    Public Property Zipcode() As String
        Get
            Return ciZipcode
        End Get
        Set(ByVal value As String)
            If value <> ciZipcode Then
                Dirtied = True
            End If
            ciZipcode = value
        End Set
    End Property
    Public Property CompanyName() As String
        Get
            Return csName
        End Get
        Set(ByVal Value As String)
            If csName.CompareTo(Value) <> 0 Then
                Dirtied = True
            End If
            csName = Value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return csAddress
        End Get
        Set(ByVal Value As String)
            If csAddress.CompareTo(Value) <> 0 Then
                Dirtied = True
            End If
            csAddress = Value
        End Set
    End Property

    Public Property City() As String
        Get
            Return csCity
        End Get
        Set(ByVal Value As String)
            If csCity.CompareTo(Value) <> 0 Then
                Dirtied = True
            End If
            csCity = Value
        End Set
    End Property

    Public Property Dirtied() As Boolean
        Get
            Return cbDirty
        End Get
        Set(ByVal value As Boolean)
            cbDirty = value
        End Set
    End Property
#End Region

End Class
