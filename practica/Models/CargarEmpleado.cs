using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica.Models
{
    public class CargarEmpleado
    {
        private string nombre;
        private string apellido;
        private DateTime nacimiento;
        private DateTime anioIngreso;
        private double sueldo;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public DateTime AnioIngreso { get => anioIngreso; set => anioIngreso = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public CargarEmpleado(string nombre,string apellido,DateTime nacimiento,DateTime anioIngreso,double sueldo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacimiento = nacimiento;
            this.AnioIngreso = anioIngreso;
            this.Sueldo = sueldo + AdiccionalSalario(antiguedad()) - (sueldo * 0.15);

        }
       public int antiguedad()
        {
            int anti = (DateTime.Now - anioIngreso).Days / 365;
            return anti;
        }
       
        public double AdiccionalSalario(float anti)
        {

            if (anti<1)
            {
                return sueldo;
            }
            if (anti >= 1 && anti<=20)
            {
                return sueldo * anti / 100;
            }
            if (anti > 20)
            {
                return sueldo * 0.25;
            }
            else
                return -999;
                
        }
       
    }
}
