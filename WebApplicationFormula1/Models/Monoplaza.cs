using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationFormula1.Models
{
    
    public class Monoplaza
    {
        public Monoplaza()
        {

        }

        public Monoplaza(int dorsal, string nombre, string color): this(dorsal, nombre, new Random().Next(900, 1100), color)
        {
        }

        public Monoplaza(int dorsal, string nombre, int potencia, string color)
        {
            this.dorsal = dorsal;
            this.nombre = nombre;
            this.potencia = potencia;
            this.color = color;
        }

        
        private int dorsal;
        private string nombre;
        private int potencia;
        private string color;

        [Key]
        public int Dorsal { get => dorsal; set => dorsal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Potencia { get => potencia; set => potencia = value; }
        public string Color { get => color; set => color = value; }
    }
}
