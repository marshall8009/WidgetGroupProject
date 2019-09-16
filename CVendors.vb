<Serializable()> Public Class CVenders
    Inherits CollectionBase

    Public Event Dirty(ByVal DataDirty As Boolean)

    Public Function Add(ByVal lobjVen As CVender) As Integer
        Return MyBase.List.Add(lobjVen)
    End Function

    ''' <summary>
    ''' Item property that takes an integer as a key, 
    ''' </summary>
    ''' <param name="Key">Zero based</param>
    Default Public Overridable Property Item(ByVal Key As Integer) As Object
        Get
            Return DirectCast(MyBase.List.Item(Key), Object)
        End Get
        Set(ByVal value As Object)
            MyBase.List.Item(Key) = value
        End Set
    End Property

    Public Sub Remove(ByVal pnID As Integer)
        If MyBase.List.Contains(Item(pnID)) Then
            Dim lobjAxis As CVender = Item(pnID)

            MyBase.List.Remove(lobjAxis)
        End If
    End Sub

    Public Sub GetVendors()
        Add(New CVender("Ackme", "256 S. May", "Oklahoma City", "0", "0", "25"))
        Add(New CVender("BrickStone", "346 N. Broadway", "Oklahoma City"))
        Add(New CVender("FooBar", "3465 E. Dumbar", "Oklahoma City"))
        Add(New CVender("MeterCo", "Windcrest Ln.", "Fort Worth"))
        Add(New CVender("GramInc", "Creighton Rd.", "Pensacola"))
        Add(New CVender("LiterLlc", "Montreal Dr.", "Hurst"))
        ''Added companies
        Add(New CVender("Krusty Krab", "831 Bottom Feeder Lane", "Bikini Bottom"))
        Add(New CVender("Central Perk", "199 Lafayette St", "New York", "10012", "0", "33"))
        Add(New CVender("In-N-Out", "13850 Francisquito Ave", "Baldwin Park", "91706", "9143217744", "5"))
    End Sub

    'Handler of the sub items and class dirty property
    Private Sub HandleDirty(ByVal DataDirty As Boolean)
        RaiseEvent Dirty(DataDirty)
    End Sub
End Class
