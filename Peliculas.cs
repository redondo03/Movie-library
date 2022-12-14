using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDePeliculas
{
    internal class Peliculas
    {
        private String nombre;
        private String fecha;
        private double nota;
        private int historial;

        public Peliculas()
        {
        }
        public Peliculas(String nombre, Fecha fecha, double nota, int historial) 
        {
            this.nombre = nombre;
            this.fecha = fecha.toString();
            this.nota = nota;
            this.historial = historial+1;
        }

        public String toString()
        {
            return historial+"--nombre: "+nombre
                    +"\nfecha: "+fecha+"                      nota: "+nota+"\n\n";
        }

        public bool comprobarHistorial(int hist)
        {
            if (this.historial==hist)
            {
                return true;
            }
            return false;
        }

        public int getHistorial()
        {
            return this.historial;
        }
        
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setfecha(Fecha fecha)
        {
            this.fecha = fecha.toString();
        }
        public void setNota(double nota)
        {
            this.nota = nota;
        }


    }
}
