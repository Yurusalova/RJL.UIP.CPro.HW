using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW5.VocabularyHashTable.Models
{
    class VocabularyItem
    {  
        public string EngWord { get; set; }
        public string RusWord { get; set; }
        public int Counter { get; } = 1;



        public VocabularyItem(string engWord, string rusWord) {
            EngWord = engWord;
            RusWord = rusWord;
        }
        public override string ToString()
        {
            return $"{EngWord} - {RusWord}";
        }

        //public override int GetHashCode()
        //{
        //    return 319299219 + EqualityComparer<string>.Default.GetHashCode(EngWord);
        //}
    }
}
