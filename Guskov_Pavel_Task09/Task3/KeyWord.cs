using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class KeyWord
    {
        public string Word;
        public int Count;

        public KeyWord(string word, int count)
        {
            this.Word = word;
            this.Count = count;
        }


        public override string ToString()
        {
            return $"{Word} - {Count}";
        }
    }
}
