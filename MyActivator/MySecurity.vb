Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class MySecurity

    Protected Shared key As String = "Eh@b_@1i"

    Public Sub New()
        'constructor
    End Sub

    Public Shared Function encryptString(ByVal strtext As String) As String
        Return Encrypt(strtext, key)
    End Function
    Public Shared Function decryptString(ByVal strtext As String) As String
        Return Decrypt(strtext, key)
    End Function

    'The function used to encrypt the text
    Private Shared Function Encrypt(ByVal strText As String, ByVal strEncrKey _
             As String) As String
        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(Left(strEncrKey, 8))

            Dim des As New DESCryptoServiceProvider()
            Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(strText)
            Dim ms As New MemoryStream()
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    'The function used to decrypt the text
    Private Shared Function Decrypt(ByVal strText As String, ByVal sDecrKey _
               As String) As String
        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim inputByteArray(strText.Length) As Byte

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(Left(sDecrKey, 8))
            Dim des As New DESCryptoServiceProvider()
            inputByteArray = Convert.FromBase64String(strText)
            Dim ms As New MemoryStream()
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)

            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8

            Return encoding.GetString(ms.ToArray())

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function




    Enum HashMethod
        MD5
        SHA1
        SHA384
    End Enum
    Private Shared Function GenerateHashDigest(ByVal source As String, ByVal algorithm As HashMethod) As String
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

    Public Shared Function HashStringOf(ByVal Str As String) As String

        Dim out As String = Str


        For n = 1 To 58
            out = GenerateHashDigest(out, HashMethod.MD5)
        Next

        For n = 1 To 89
            out = GenerateHashDigest(out, HashMethod.SHA1)
        Next

        For n = 1 To 112
            out = GenerateHashDigest(out, HashMethod.SHA384)
        Next

        Return out

    End Function



End Class
