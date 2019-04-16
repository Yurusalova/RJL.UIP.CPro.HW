using RJL.UIP.CPro.HW5.VocabularyHashTable.Models;
using RJL.UIP.CPro.HW5.VocabularyHashTable.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW5.VocabularyHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            EngRusVocabularyHashTable EngRusVocabulary = new EngRusVocabularyHashTable(200);
            EngRusVocabulary.insert(new VocabularyItem("Cat", "Кошка"));
           
            EngRusVocabulary.insert(new VocabularyItem("Dog", "Собака"));
            EngRusVocabulary.insert(new VocabularyItem("Boy", "Мальчик"));
            EngRusVocabulary.insert(new VocabularyItem("Girl", "Девочка"));
            EngRusVocabulary.insert(new VocabularyItem("Toy", "Игрушка"));
            EngRusVocabulary.insert(new VocabularyItem("Ball", "Мяч"));
            EngRusVocabulary.displayTable();
            Console.WriteLine("----------------------");
            Console.WriteLine(EngRusVocabulary.find("Ball"));


            Console.WriteLine(EngRusVocabulary.delete("Boy"));
            Console.WriteLine("----------------------");
            EngRusVocabulary.displayTable();
            Console.WriteLine("----------------------");

            Console.ReadLine();
        }
    }
}
