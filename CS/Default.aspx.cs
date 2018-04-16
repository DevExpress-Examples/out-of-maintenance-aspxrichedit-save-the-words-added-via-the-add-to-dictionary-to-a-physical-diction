using DevExpress.XtraSpellChecker;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ASPxButton1_Click(object sender, EventArgs e)
    {
        SpellCheckerCachedCustomDictionary dic = Session[ASPxRichEdit1.Settings.SpellChecker.Dictionaries[0].CacheKey] as SpellCheckerCachedCustomDictionary;
        MyCustomDictionary dictionary = new MyCustomDictionary();
        for (int i = 0; i < dic.WordCount; i++)
            dictionary.AddWord(dic[i]);
        dictionary.SaveAs(dic.DictionaryPath);
    }
}

public class MyCustomDictionary : SpellCheckerCustomDictionary
{
    public MyCustomDictionary() : base() { }
    public MyCustomDictionary(string dictionaryPath, CultureInfo culture) : base(dictionaryPath, culture) { }
    public override bool Loaded { get { return true; } }
}