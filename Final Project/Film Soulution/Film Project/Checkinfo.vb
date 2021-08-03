' Class filename:       Checkinfo.vb
' Created/revised by:   David Patterson on 12/5/16

Option Explicit On
Option Strict On
Option Infer Off

Public Class Checkinfo
    Public Property Name As String
    Public Property Address As String
    Public Property City As String
    Public Property Zip As String


    Public Sub New()
        _Name = String.Empty
        _Address = String.Empty
        _City = String.Empty
        _Zip = String.Empty

    End Sub

    Public Sub New(ByVal checkName As String, ByVal addressOfUser As String, ByVal zipOfUser As String,
                   ByVal cityOfUser As String)
        Name = checkName
        Address = addressOfUser
        City = cityOfUser
        Zip = zipOfUser

    End Sub

    Public Sub SaveCheckInfo(ByVal fileName As String, ByVal createNewFile As Boolean)
        ' saves the check information to a sequential access file

        Dim outFile As IO.StreamWriter

        If createNewFile Then
            outFile = IO.File.CreateText(fileName)
        Else
            outFile = IO.File.AppendText(fileName)
        End If

        outFile.WriteLine(_Name)
        outFile.WriteLine(_Address)
        outFile.WriteLine(_City)
        outFile.WriteLine(_Zip)

        outFile.Close()
    End Sub
End Class
