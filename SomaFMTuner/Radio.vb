Public Class Radio 
    Private Image As Image
    Private Name As String
    Private URL As String
    Private Quality As Integer
    Private ImageLocation As String
    Public Property pImageLocation() As String
        Get
            Return ImageLocation
        End Get
        Set(ByVal value As String)
            ImageLocation = value
        End Set
    End Property
    Public Property pQuality() As Integer
        Get
            Return Quality
        End Get
        Set(ByVal value As Integer)
            Quality = value
        End Set
    End Property
    Public Property pImage() As Image
        Get
            Return Image
        End Get
        Set(ByVal value As Image)
            Image = value
        End Set
    End Property
    Public Property pName() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            Name = value
        End Set
    End Property
    Public Property pURL() As String
        Get
            Return URL
        End Get
        Set(ByVal value As String)
            URL = value
        End Set
    End Property

    Public Sub New(ByVal RadioName As String)
        Name = RadioName
        URL = "http://ice.somafm.com/" + Name
        ImageLocation = "C:\Projects\vb.net\somatuner\SomaFMTuner\Resources\" + Name + ".png"

    End Sub
End Class
