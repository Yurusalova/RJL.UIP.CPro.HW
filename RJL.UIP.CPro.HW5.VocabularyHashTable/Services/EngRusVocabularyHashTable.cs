using RJL.UIP.CPro.HW5.VocabularyHashTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW5.VocabularyHashTable.Services
{
    class EngRusVocabularyHashTable
    {
        
            private VocabularyItem[] hashArray; // Массив ячеек хеш-таблицы
            private int arraySize;
            // -------------------------------------------------------------
            public EngRusVocabularyHashTable(int size) // Конструктор
            {
                arraySize = size;
                hashArray = new VocabularyItem[arraySize];
                VocabularyItem nonItem = new VocabularyItem("",""); // Ключ удаленного элемента
            }
            // -------------------------------------------------------------
            public void displayTable()
            {
                Console.WriteLine("Table: ");
                for (int j = 0; j < arraySize; j++)
                {
                    if (hashArray[j] != null)
                        Console.WriteLine(hashArray[j].ToString() + ";");
                    else
                        Console.Write("*");
                }
                Console.WriteLine("");
            }
            // -------------------------------------------------------------
            public int hashFunc(string key)
            {
            int hashVal = 0;
            for (int j = 0; j < key.Length; j++) // Слева направо
            {
                int letter = (int)key[j]; // Получение кода символа
                hashVal = (hashVal * 27 + letter) % arraySize; // Оператор %
            }
            return hashVal;
        }
            // -------------------------------------------------------------
            public void insert(VocabularyItem item) // Вставка элемента данных
                                                    // (Метод предполагает, что таблица не заполнена)
            {
                string key = item.EngWord; // Получение ключа
                int hashVal = hashFunc(key); // Хеширование ключа
                                             // Пока не будет найдена
                while (hashArray[hashVal] != null && // пустая ячейка или -1,
                hashArray[hashVal].GetHashCode() != -1)
                {
                    ++hashVal; // Переход к следующей ячейке
                    hashVal %= arraySize; // При достижении конца таблицы
                } // происходит возврат к началу
                hashArray[hashVal] = item; // Вставка элемента
            }
            // -------------------------------------------------------------
            public VocabularyItem delete(string key) // Удаление элемента данных
            {
                int hashVal = hashFunc(key); // Хеширование ключа
                while (hashArray[hashVal] != null) // Пока не будет найдена
                                                   // пустая ячейка
                { // Ключ найден?
                    if (hashArray[hashVal].EngWord == key)
                    {
                        VocabularyItem temp = hashArray[hashVal]; // Временное сохранение
                        hashArray[hashVal]= new VocabularyItem("", ""); // Удаление элемента
                        return temp; // Метод возвращает элемент
                    }
                    ++hashVal; // Переход к следующей ячейке
                    hashVal %= arraySize; // При достижении конца таблицы
                } // происходит возврат к началу
                return null; // Элемент не найден
            }
            // -------------------------------------------------------------

            public VocabularyItem find(String key) // Поиск элемента с заданным ключом
                                                // (Метод предполагает, что таблица не заполнена)
            {
                int hashVal = hashFunc(key); // Хеширование ключа
                while (hashArray[hashVal] != null) // Пока не будет найдена
                                                   // пустая ячейка
                { // Ключ найден?
                    if (hashArray[hashVal].EngWord == key)
                        return hashArray[hashVal]; // Да, вернуть элемент
                    ++hashVal; // Переход к следующей ячейке
                    hashVal %= arraySize; // При достижении конца таблицы
                } // происходит возврат к началу
                return null; // Элемент не найден
            }
            // -------------------------------------------------------------
        } // Конец класса HashTable
          ////////////////////////////////////////////////////////////////
    
}
