﻿<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxRichEdit.v16.2, Version=16.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRichEdit" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v16.2, Version=16.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	 <dx:ASPxRichEdit ID="ASPxRichEdit1" runat="server" Height="700px" Width="100%">
	  <SettingsDocumentSelector>
	   <UploadSettings Enabled="true" />
	  </SettingsDocumentSelector>
	  <Settings>
	   <SpellChecker Enabled="True">
		<Dictionaries>
		 <dx:ASPxSpellCheckerCustomDictionary AlphabetPath="~/EnglishAlphabet.txt" DictionaryPath="~/CustomEnglish.dic" CacheKey="Key1" />
		</Dictionaries>
		<OptionsSpelling IgnoreUpperCaseWords="true" />
	   </SpellChecker>
	  </Settings>
	 </dx:ASPxRichEdit>
	 <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Save new added words to the dictionary" OnClick="ASPxButton1_Click">
	 </dx:ASPxButton>
	</form>
</body>
</html>