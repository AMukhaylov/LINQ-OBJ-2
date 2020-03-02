using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        // Вариант 2 Objects
        // Задача 2
        static void Main(string[] args)
        {
            List<Note> notes = new List<Note>();
            try
            {
                notes.Add(new Note(1, 2000, 10, 8));
                notes.Add(new Note(2, 2000, 11, 10));
                notes.Add(new Note(5, 2001, 12, 14));
                notes.Add(new Note(8, 2010, 13, 20));
                notes.Add(new Note(1, 2009, 14, 8));
                notes.Add(new Note(5, 2009, 15, 20));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            var maxNote = notes.Where(note => note._classDuration == notes.Max(x => x._classDuration));

            foreach (var i in maxNote)
            {
                Console.WriteLine(string.Format("Максимальная продолжительность = {0},  Год = {1}, Месяц = {2}", i._classDuration, i._year, i._month));
            }

            Console.ReadKey();
        }
    }
}

