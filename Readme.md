# ASPxRichEdit - Save the words added via the "Add to Dictionary" to a physical dictionary


Currently, ASPxRichEdit doesn't save words added by a user via the <em>"Add to Dictionary"</em> option in the physical dictionary file and stores these changes in a Session variable.<br><br>If it's necessary to save changes from the temporary dictionary stored in Session to a physical dictionary file on demand, you can accomplish this task programmatically, for example, on a button click. Get the temporary dictionary that has the SpellCheckerCachedCustomDictionary type from Session in the following way:<br>


```cs
SpellCheckerCachedCustomDictionary dic = Session[ASPxRichEdit1.Settings.SpellChecker.Dictionaries[0].CacheKey] as SpellCheckerCachedCustomDictionary;
```


Note that you need to pass an index of your custom dictionary to the collection of other dictionaries used in your project as the Dictionaries collection index in this code.<br><br>Then, pass words from that temporary dictionary to a new instance of your custom dictionary class derived from <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraSpellCheckerSpellCheckerCustomDictionarytopic">SpellCheckerCustomDictionary</a> and save this custom dictionary to the appropriate physical path obtained from the temporary dictionary's DictionaryPath property:<br>


```cs
        MyCustomDictionary dictionary = new MyCustomDictionary();
        for (int i = 0; i < dic.WordCount; i++)
            dictionary.AddWord(dic[i]);
        dictionary.SaveAs(dic.DictionaryPath);
```



<br/>


