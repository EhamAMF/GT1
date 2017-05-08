Imports System.Management
Imports System.Text
Imports System.Security.Cryptography

Imports ByteClassLibrary.MyFunctions

Module HardwareInfo


    Public Function HashedHWInfo() As String
        Dim str As String

        Dim hd As String

        Try
            hd = HarDriveInfo()
        Catch ex As Exception
            hd = "NotFound"
        End Try




        Dim mb As String
        Try
            mb = MotherboardInfo()
        Catch ex As Exception
            mb = "NotFound"
        End Try



        Dim cpu As String
        Try
            cpu = CpuInfo()
        Catch ex As Exception
            cpu = "NotFound"
        End Try



        For n = 1 To 58
            hd = GenerateHashDigest(hd, HashMethod.MD5)
        Next

        For n = 1 To 89
            mb = GenerateHashDigest(mb, HashMethod.SHA1)
        Next

        For n = 1 To 112
            cpu = GenerateHashDigest(cpu, HashMethod.SHA384)
        Next


        str = hd & mb & cpu
        For n = 1 To 111
            str = GenerateHashDigest(str, HashMethod.SHA384)
        Next


        Return str
    End Function
    Public Function HWInfo() As String

        Dim hd As String
        Dim mb As String
        Dim cpu As String






        Try
            hd = HarDriveInfo()
        Catch ex As Exception
            hd = "NotFound"
        End Try

        Try
            mb = MotherboardInfo()
        Catch ex As Exception
            mb = "NotFound"
        End Try

        Try
            cpu = CpuInfo()
        Catch ex As Exception
            cpu = "NotFound"
        End Try


        Dim all As String

        all = hd & vbNewLine & mb & vbNewLine & cpu

        Return all

    End Function

    Public Function HardwareID() As String
        Dim str As String = AllHardwareInfo()

        str = GenerateHashDigest(str, HashMethod.MD5)
        str = GenerateHashDigest(str, HashMethod.SHA1)
        str = GenerateHashDigest(str, HashMethod.MD5)
        str = GenerateHashDigest(str, HashMethod.SHA384)
        str = GenerateHashDigest(str, HashMethod.SHA384)
        str = GenerateHashDigest(str, HashMethod.SHA384)

        Return str
    End Function
    Public Function AllHardwareInfo() As String
        Return HarDriveInfo() & MotherboardInfo() & CpuInfo() & BiosInfo()
    End Function

    Public Function HarDriveInfo()
        Dim str As String = "HardDrive Info" & vbNewLine


        Dim hdd As New ManagementObjectSearcher("select * from Win32_DiskDrive")

        For Each hd In hdd.Get
            If IsNullNothing(hd("MediaType"), "") = "Fixed hard disk media" Then

                str = str & "SerialNumber" & " : " & IsNullNothing(hd("SerialNumber"), "") & vbNewLine
                str = str & "Model" & " : " & IsNullNothing(hd("Model"), "") & vbNewLine
                str = str & "Signature" & " : " & IsNullNothing(hd("Signature"), "") & vbNewLine
                str = str & "Manufacturer" & " : " & IsNullNothing(hd("Manufacturer"), "") & vbNewLine
                str = str & "MediaType" & " : " & IsNullNothing(hd("MediaType"), "") & vbNewLine
                str = str & "Description" & " : " & IsNullNothing(hd("Description"), "") & vbNewLine
                str = str & "Size" & " : " & IsNullNothing(hd("Size"), "") & vbNewLine

                str = str & "------------------------------------" & vbNewLine


            End If




        Next






        Return str
    End Function
    Public Function MotherboardInfo()
        Dim str As String = "MotherBoard Info" & vbNewLine


        Dim mboard As New ManagementObjectSearcher("select * from Win32_BaseBoard ")


        For Each mb In mboard.Get

            str = str & "Manufacturer" & " : " & IsNullNothing(mb("Manufacturer"), "") & vbNewLine
            str = str & "Model" & " : " & IsNullNothing(mb("Model"), "") & vbNewLine
            str = str & "Name" & " : " & IsNullNothing(mb("Name"), "") & vbNewLine
            str = str & "OtherIdentifyingInfo" & " : " & IsNullNothing(mb("OtherIdentifyingInfo"), "") & vbNewLine
            str = str & "PartNumber" & " : " & IsNullNothing(mb("PartNumber"), "") & vbNewLine
            str = str & "SerialNumber" & " : " & IsNullNothing(mb("SerialNumber"), "") & vbNewLine
            str = str & "Tag" & " : " & IsNullNothing(mb("Tag"), "") & vbNewLine


            str = str & "------------------------------------" & vbNewLine
        Next






        Return str
    End Function
    Public Function CpuInfo()
        Dim str As String = "CPU Info" & vbNewLine
        Dim cpu As New ManagementObjectSearcher("select * from Win32_Processor")

        For Each c In cpu.Get

            str = str & "Caption" & " : " & IsNullNothing(c("Caption"), "") & vbNewLine
            str = str & "Description" & " : " & IsNullNothing(c("Description"), "") & vbNewLine
            str = str & "DeviceID" & " : " & IsNullNothing(c("DeviceID"), "") & vbNewLine
            str = str & "Family" & " : " & IsNullNothing(c("Family"), "") & vbNewLine
            str = str & "Manufacturer" & " : " & IsNullNothing(c("Manufacturer"), "") & vbNewLine
            str = str & "Name" & " : " & IsNullNothing(c("Name"), "") & vbNewLine
            str = str & "OtherFamilyDescription" & " : " & IsNullNothing(c("OtherFamilyDescription"), "") & vbNewLine
            str = str & "PartNumber" & " : " & IsNullNothing(c("PartNumber"), "") & vbNewLine
            str = str & "ProcessorId" & " : " & IsNullNothing(c("ProcessorId"), "") & vbNewLine
            str = str & "ProcessorType" & " : " & IsNullNothing(c("ProcessorType"), "") & vbNewLine
            str = str & "SerialNumber" & " : " & IsNullNothing(c("SerialNumber"), "") & vbNewLine
            str = str & "UniqueId" & " : " & IsNullNothing(c("UniqueId"), "") & vbNewLine

       

            str = str & "------------------------------------" & vbNewLine

        Next

        'DeviceID :Unique identifier of a processor on the system. This property is inherited from CIM_LogicalDevice.


        Return str
    End Function
    Public Function BiosInfo()
        Dim str As String = "BIOS Info" & vbNewLine
        Dim cpu As New ManagementObjectSearcher("select * from Win32_BIOS")

        For Each c In cpu.Get
            str = str & "Caption" & " : " & IsNullNothing(c("Caption"), "") & vbNewLine
            str = str & "Description" & " : " & IsNullNothing(c("Description"), "") & vbNewLine
            str = str & "IdentificationCode" & " : " & IsNullNothing(c("IdentificationCode"), "") & vbNewLine
            str = str & "Manufacturer" & " : " & IsNullNothing(c("Manufacturer"), "") & vbNewLine
            str = str & "Name" & " : " & IsNullNothing(c("Name"), "") & vbNewLine
            str = str & "SerialNumber" & " : " & IsNullNothing(c("SerialNumber"), "") & vbNewLine




            str = str & "------------------------------------" & vbNewLine

        Next

        'DeviceID :Unique identifier of a processor on the system. This property is inherited from CIM_LogicalDevice.


        Return str
    End Function



    Enum HashMethod
        MD5
        SHA1
        SHA384
    End Enum
    Public Function GenerateHashDigest(ByVal source As String, ByVal algorithm As HashMethod) As String
        Dim hashAlgorithm As HashAlgorithm = Nothing

        Select Case algorithm
            Case HashMethod.MD5
                hashAlgorithm = New MD5CryptoServiceProvider
            Case HashMethod.SHA1
                hashAlgorithm = New SHA1CryptoServiceProvider
            Case HashMethod.SHA384
                hashAlgorithm = New SHA384Managed
            Case Else
                ' Error case.
        End Select

        Dim byteValue() As Byte = Encoding.UTF8.GetBytes(source)
        Dim hashValue() As Byte = hashAlgorithm.ComputeHash(byteValue)
        Return Convert.ToBase64String(hashValue)
    End Function

End Module
