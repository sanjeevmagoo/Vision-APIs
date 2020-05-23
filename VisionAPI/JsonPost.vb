'Install Newtonsoft.json
'-----------------------
'
'PM> Install-Package Newtonsoft.Json -Version 6.0.8

'Sample Usage
'------------

'Dim jsonPost As New JsonPost("http://192.168.254.104:8000")
'Dim dictData As New Dictionary(Of String, Object)
'dictData.Add("test_key", "test_value")
'jsonPost.postData(dictData)

Imports Newtonsoft.Json
Imports System.Net
Imports System.Text
Public Class JsonPost

    Private urlToPost As String = ""

    Public Sub New(ByVal urlToPost As String)
        Me.urlToPost = urlToPost
    End Sub

    Public Function postData(ByVal dictData As Dictionary(Of String, Object)) As String

        Dim webClient As New WebClient()
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte

        Try
            webClient.Headers("content-type") = "application/json"
            webClient.Headers("Ocp-Apim-Subscription-Key") = "dd3158b1d1a3474c805d7a02ce617148"

            reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented))
            resByte = webClient.UploadData(Me.urlToPost, "post", reqString)
            resString = Encoding.Default.GetString(resByte)
            Console.WriteLine(resString)
            webClient.Dispose()
            Return resString
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return False
    End Function


    Public Function postData2(ByVal dictData As Dictionary(Of String, Object)) As String

        Dim webClient As New WebClient()
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte

        Try
            webClient.Headers("content-type") = "application/json"
            webClient.Headers("Prediction-Key") = "dd3158b1d1a3474c805d7a02ce617148"

            reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented))
            resByte = webClient.UploadData(Me.urlToPost, "post", reqString)
            resString = Encoding.Default.GetString(resByte)
            Console.WriteLine(resString)
            webClient.Dispose()
            Return resString
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return False
    End Function
End Class
