Imports System.Data.SqlClient

Public Class Settings




    Private Shared Function GetSettingValue(ByVal SettingName As String) As String
        Return ByteClassLibrary.MyFunctions.GetScalarValue(PubCn, "Settings", "SettingValue", "SettingName = '" & SettingName & "'")
    End Function


    Private Shared Sub SetSetting(ByVal SettingName As String, ByVal SettingValue As String)
        ByteClassLibrary.MyFunctions.UpdateValue(PubCn, "Settings", "SettingValue", SettingValue, "SettingName = '" & SettingName & "'")
    End Sub




    Public Shared Property IsMultiExDateAllowed As String
        Get
            Return GetSettingValue("IsMultiExDateAllowed")
        End Get
        Set(ByVal value As String)
            SetSetting("IsMultiExDateAllowed", value)
        End Set
    End Property
    Public Shared Property IsPacketDefault As String
        Get
            Return GetSettingValue("IsPacketDefault")
        End Get
        Set(ByVal value As String)
            SetSetting("IsPacketDefault", value)
        End Set
    End Property
    Public Shared Property OwenerID As String
        Get
            Return GetSettingValue("OwenerID")
        End Get
        Set(ByVal value As String)
            SetSetting("OwenerID", value)
        End Set
    End Property
    Public Shared Property OwnerName As String
        Get
            Return GetSettingValue("OwnerName")
        End Get
        Set(ByVal value As String)
            SetSetting("OwnerName", value)
        End Set
    End Property
    Public Shared Property ActivatedDate As String
        Get
            Return GetSettingValue("ActivatedDate")
        End Get
        Set(ByVal value As String)
            SetSetting("ActivatedDate", value)
        End Set
    End Property
    Public Shared Property InvoiceLayout As String
        Get
            Return GetSettingValue("InvoiceLayout")
        End Get
        Set(ByVal value As String)
            SetSetting("InvoiceLayout", value)
        End Set
    End Property
    Public Shared Property IsDebug As String
        Get
            Return GetSettingValue("IsDebug")
        End Get
        Set(ByVal value As String)
            SetSetting("IsDebug", value)
        End Set
    End Property
    Public Shared Property IsUpdateReady As String
        Get
            Return GetSettingValue("IsUpdateReady")
        End Get
        Set(ByVal value As String)
            SetSetting("IsUpdateReady", value)
        End Set
    End Property
    Public Shared Property HeaderSTR As String
        Get
            Return GetSettingValue("HeaderSTR")
        End Get
        Set(ByVal value As String)
            SetSetting("HeaderSTR", value)
        End Set
    End Property
    Public Shared Property FooterSTR As String
        Get
            Return GetSettingValue("FooterSTR")
        End Get
        Set(ByVal value As String)
            SetSetting("FooterSTR", value)
        End Set
    End Property
    Public Shared Property TreasuryLayout As String
        Get
            Return GetSettingValue("TreasuryLayout")
        End Get
        Set(ByVal value As String)
            SetSetting("TreasuryLayout", value)
        End Set
    End Property
    Public Shared Property IsProductDetailsShown As String
        Get
            Return GetSettingValue("IsProductDetailsShown")
        End Get
        Set(ByVal value As String)
            SetSetting("IsProductDetailsShown", value)
        End Set
    End Property
    Public Shared Property IsProductCodeShown As String
        Get
            Return GetSettingValue("IsProductCodeShown")
        End Get
        Set(ByVal value As String)
            SetSetting("IsProductCodeShown", value)
        End Set
    End Property
    Public Shared Property ModifyAllowedTime As String
        Get
            Return GetSettingValue("ModifyAllowedTime")
        End Get
        Set(ByVal value As String)
            SetSetting("ModifyAllowedTime", value)
        End Set
    End Property

    Public Shared Property IsBarcodeShown As String
        Get
            Return GetSettingValue("IsBarcodeShown")
        End Get
        Set(ByVal value As String)
            SetSetting("IsBarcodeShown", value)
        End Set
    End Property
    Public Shared Property IsRackShown As String
        Get
            Return GetSettingValue("IsRackShown")
        End Get
        Set(ByVal value As String)
            SetSetting("IsRackShown", value)
        End Set
    End Property
    Public Shared Property IsPacketSystem As String
        Get
            Return GetSettingValue("IsPacketSystem")
        End Get
        Set(ByVal value As String)
            SetSetting("IsPacketSystem", value)
        End Set
    End Property

    Public Shared Property IsExDateShown As String
        Get
            Return GetSettingValue("IsExDateShown")
        End Get
        Set(ByVal value As String)
            SetSetting("IsExDateShown", value)
        End Set
    End Property




End Class
