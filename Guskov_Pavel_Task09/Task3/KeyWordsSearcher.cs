using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task3
{
    class KeyWordsSearcher
    {
        private string text;
        public List<KeyWord> KeyWords = new List<KeyWord>();


        public KeyWordsSearcher(string text)
        {

            this.text = text;

        }

        public void setKeyWords()
        {
            string[] strArr = Regex.Split(text, @"\b\W+\b", RegexOptions.IgnoreCase);

            for (int i = 1; i < strArr.Length; i++)
            {
                for (int k = i + 1; k < strArr.Length; k++)
                {
                    if (strArr[i].ToLower().CompareTo(strArr[k].ToLower()) == 0)
                    {
                        strArr[k] = ""; 
                    }
                }
            }

            for (int i = 0; i < strArr.Length; i++)
            {
                if(strArr[i] != "")
                {
                    KeyWords.Add(new KeyWord(strArr[i], 0));
                }
            }
        }

        public void CountKeyWords()
        {
            for (int i = 0; i < KeyWords.Count; i++)
            {
                if (!string.IsNullOrWhiteSpace(KeyWords[i].Word))
                {
                    string pattern = @"\b" + KeyWords[i].Word + @"\b";

                    Regex wordsCounterRegex = new Regex(pattern);
                    MatchCollection matches = wordsCounterRegex.Matches(text);

                    if (matches.Count > 0)
                    {
                        foreach (Match match in matches)
                            KeyWords[i].Count++;
                    }
                }
            }
        }

        public override string ToString()
        {
            string output = "The result is:\n";

            for (int i = 0; i < KeyWords.Count; i++)
            {
                output = $"{output} {KeyWords[i]}\n";
            }

            return output;
        }
    }

}
