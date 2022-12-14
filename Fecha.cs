using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDePeliculas
{
    internal class Fecha
    {
        private int day;
        private int month;
        private int year;

        public Fecha(int day, int month, int year) 
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public Fecha() { }
        public static bool comprobacionFecha(int day, int month, int year)
        {
            if(year< 0) { return false; }
            else if (month < 0 && month > 12) { return false; }
            else if (day < 0 && day >diasMes(month) ){ return false; }
            else { return true; }
        }

        private static int diasMes(int month)
        {
            switch (month)
            {
                case 1: return 31;
                case 2: return 28;
                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                default: return 31;
            }
        }

        public void setFecha(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public String toString()
        {
            return day+"/"+month+"/"+year;
        }

    }
}
