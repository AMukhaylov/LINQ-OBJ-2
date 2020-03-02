using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Note
    {
        public int _month;          // 1-12
        public int _year;           // 2000-2010
        public int _idClient;       // 10-99
        public int _classDuration;  // 1-30

        public Note(int month, int year, int idClient, int classDuration)
        {
            if (month < 1 || month > 12) throw new ArgumentOutOfRangeException("Месяц в диапизоне 1-12!");
            _month = month;

            if (year < 2000 || year > 2010) throw new ArgumentOutOfRangeException("Год в диапизоне 2000-2010!");
            _year = year;

            if (idClient < 10 || idClient > 99) throw new ArgumentOutOfRangeException("ID клиента в диапизоне 10-99!");
            _idClient = idClient;

            if (classDuration < 1 || classDuration > 30) throw new ArgumentOutOfRangeException("Продолжительность занятий в диапизоне 1-30!");
            _classDuration = classDuration;
        }
    }
}
