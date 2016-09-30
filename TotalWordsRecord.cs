using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Code_Challenge_7_CSharp
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    class TotalWordsRecord
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        String word;
        long occurrences;

        public String getWord()
        {
            return this.word;
        }

        public long getOccurrences()
        {
            return this.occurrences;
        }

        public void setWord(String inputWord)
        {
            this.word = inputWord;
        }

        public void setOccurrences(long inputOccurrences)
        {
            this.occurrences = inputOccurrences;
        }

        //@Override
        public override bool Equals(Object obj)
        {
            bool equalsTest = false;
            if (((TotalWordsRecord)obj).word.Equals(this.word))
            {
                equalsTest = true;
            }
            return equalsTest;
        }
    }
}
