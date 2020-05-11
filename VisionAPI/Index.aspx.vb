Imports System.Runtime.Serialization.Json
Imports System.Xml
Imports Newtonsoft.Json.Linq

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load





    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim jsonPost As New JsonPost("https://computervision2020-azure.cognitiveservices.azure.com/vision/v2.0/analyze?visualFeatures=Description,ImageType,Objects,Tags,Brands,Adult,Categories,Color,Faces&details=Landmarks,Celebrities&language=en")

        Dim dictData As New Dictionary(Of String, Object)

        dictData.Add("url", TextBox1.Text)

        Dim S As String = ""

        S = jsonPost.postData(dictData)


        Dim bytes() As Byte = Encoding.Unicode.GetBytes(S)
        Dim reader As XmlDictionaryReader = JsonReaderWriterFactory.CreateJsonReader(bytes, New XmlDictionaryReaderQuotas)
        Dim doc As New XmlDocument
        doc.Load(reader)
        Dim caption As String = doc.SelectSingleNode("root/description/captions/item/text").InnerXml
        Dim confidence As String = doc.SelectSingleNode("root/description/captions/item/confidence").InnerXml


        lbltitle.Text = caption & "(" & Math.Round(Decimal.Parse(confidence), 2).ToString & ") "
        lbltitle.Visible = True

        Dim jResults As JObject = JObject.Parse(S)
        Dim naming1 As [String] = jResults("adult")("isAdultContent")
        Dim naming2 As [String] = jResults("adult")("adultScore")
        Dim naming3 As [String] = jResults("adult")("isRacyContent")
        Dim naming4 As [String] = jResults("adult")("racyScore")
        Dim i As Int64 = jResults("objects").Count

        Dim json As String = S
        Dim ser As JObject = JObject.Parse(json)
        Dim data As List(Of JToken) = ser.Children().ToList

        Dim objects As String = ""

        Dim tags As String = ""

        Dim title As String = ""

        Dim brands As String = ""

        Dim celebs As String = ""


        For Each item As JProperty In data
            item.CreateReader()
            Select Case item.Name
                Case "tags" 'each record is inside the entries array
                    For Each Entry As JObject In item.Values

                        Dim factor As String = Entry("confidence")
                        tags = tags.ToString & Entry("name").ToString & "(" & Math.Round(Decimal.Parse(factor), 2).ToString & ") "

                        ' you can continue listing the array items untill you reach the end of you array
                    Next

                Case "objects" 'each record is inside the entries array
                    For Each Entry As JObject In item.Values
                        ''objects = objects.ToString & " " & Entry("object").ToString
                        Dim factor As String = Entry("confidence")
                        objects = objects.ToString & Entry("object").ToString & "(" & Math.Round(Decimal.Parse(factor), 2).ToString & ") "                        ' you can continue listing the array items untill you reach the end of you array        
                    Next

                Case "brands" 'each record is inside the entries array
                    For Each Entry As JObject In item.Values
                        ''brands = brands.ToString & " " & Entry("name").ToString
                        Dim factor As String = Entry("confidence")
                        brands = brands.ToString & Entry("name").ToString & "(" & Math.Round(Decimal.Parse(factor), 2).ToString & ") "

                        ' you can continue listing the array items untill you reach the end of you array        
                    Next

                Case "categories" 'each record is inside the entries array


                    Dim nodeList As XmlNodeList = doc.DocumentElement.SelectNodes("categories/item/detail/celebrities")

                    For Each _node As XmlNode In nodeList
                        celebs = _node.InnerText
                        ''MessageBox.Show(_nodeValue)
                    Next

            End Select
        Next

        lblObjects.Visible = True
        lblObjects.Text = objects

        lblTags.Visible = True
        lblTags.Text = tags


        lblBrands.Visible = True
        lblBrands.Text = brands

        lblCelebs.Visible = True
        lblCelebs.Text = celebs

        If DropDownList1.Text = "Guns" Then


            Dim jsonPost1 As New JsonPost("https://eastus.api.cognitive.microsoft.com/customvision/v3.0/Prediction/9d1be530-7620-48e3-8ca1-31f88343f2bc/detect/iterations/Iteration2/url")

            Dim dictData1 As New Dictionary(Of String, Object)

            dictData1.Add("url", TextBox1.Text)

            Dim S1 As String = ""

            S1 = jsonPost1.postData2(dictData1)

            Dim json1 As String = S1
            Dim ser1 As JObject = JObject.Parse(json1)
            Dim data1 As List(Of JToken) = ser1.Children().ToList
            Dim guns As String = ""
            For Each item As JProperty In data1
                item.CreateReader()
                Select Case item.Name
                    Case "predictions" 'each record is inside the entries array
                        For Each Entry As JObject In item.Values

                            Dim factor As String = Entry("probability")
                            ''Dim tag As String = Entry("tagName")
                            guns = guns.ToString & Entry("tagName").ToString & "(" & Math.Round(Decimal.Parse(factor), 2).ToString & ") "

                            ' you can continue listing the array items untill you reach the end of you array
                        Next


                        lblGuns.Text = guns
                        lblGuns.Visible = True

                End Select
            Next
        End If

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

        Select Case DropDownList1.Text

            Case "Select Image Type From Storage" 'each record is inside the entries array
                lblGuns.Visible = False

                TextBox1.Text = "Select Image Type From Storage"
                Button1.Enabled = False

            Case "Traffic Accident" 'each record is inside the entries array
                lblGuns.Visible = False

                TextBox1.Text = "https://i.ytimg.com/vi/apACfPmcMQE/maxresdefault.jpg"
                Button1.Enabled = True
            Case "Celebrities" 'each record is inside the entries array
                lblGuns.Visible = False

                TextBox1.Text = "https://www.businessinsider.in/photo/67318931/here-were-the-most-memorable-hugs-indian-politicians-unleashed-on-their-opponents-in-2018.jpg"
                Button1.Enabled = True
            Case "Violence" 'each record is inside the entries array
                lblGuns.Visible = False

                TextBox1.Text = "https://i.ytimg.com/vi/XCIfasdMkX4/maxresdefault.jpg"
                Button1.Enabled = True
            Case "Guns" 'each record is inside the entries array
                TextBox1.Text = "https://www.fwweekly.com/wp-content/uploads/2014/04/guns.jpg"
                Button1.Enabled = True




            Case "Brands" 'each record is inside the entries array
                lblGuns.Visible = False

                TextBox1.Text = "https://tobuz-dev-bkt.s3.amazonaws.com/15196638401591519663840146jemc7950093148145042086.jpg"
                Button1.Enabled = True

            Case "Mix" 'each record is inside the entries array
                lblGuns.Visible = False

                TextBox1.Text = "https://mpk732t12016clusterb.files.wordpress.com/2016/08/blog-91.png"
                Button1.Enabled = True

        End Select
        Image1.ImageUrl = TextBox1.Text

    End Sub
End Class