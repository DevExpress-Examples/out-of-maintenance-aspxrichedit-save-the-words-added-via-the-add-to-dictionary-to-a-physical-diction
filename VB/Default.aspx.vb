Imports Microsoft.VisualBasic
Imports DevExpress.XtraSpellChecker
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	
	Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim dic As SpellCheckerCachedCustomDictionary = TryCast(Session(ASPxRichEdit1.Settings.SpellChecker.Dictionaries(0).CacheKey), SpellCheckerCachedCustomDictionary)
		Dim dictionary As New MyCustomDictionary()
		For i As Integer = 0 To dic.WordCount - 1
			dictionary.AddWord(dic(i))
		Next i
		dictionary.SaveAs(dic.DictionaryPath)
	End Sub
End Class

Public Class MyCustomDictionary
	Inherits SpellCheckerCustomDictionary
	Public Sub New()
		MyBase.New()
	End Sub
	Public Sub New(ByVal dictionaryPath As String, ByVal culture As CultureInfo)
		MyBase.New(dictionaryPath, culture)
	End Sub
Public Overrides Property Loaded As Boolean
        Get
            Return True
        End Get
        Protected Set(value As Boolean)
            MyBase.Loaded = value
        End Set
    End Property
End Class
