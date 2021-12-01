using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolimorfismoWashingtonBriones3B
{
    public abstract class PROFESORPORCONTRATO : PROFESORES
    {
        public class PROFESORPORCONTRATO
        {
            double preciodehoratrabajada, sueldoporhoras;
            int numerodehorastrabajadas;
            public PROFESORPORCONTRATO(double preciohoratrabajada, int numerodehorastrabajadas)
            {
                this.preciodehoratrabajada = preciohoratrabajada;
                this.numerodehorastrabajadas = numerodehorastrabajadas;
                sueldoporhoras = preciohoratrabajada * numerodehorastrabajadas;
            }
            public double getsueldoporhoras()
            {
                return sueldoporhoras;
            }
            public void setsueldoporhoras(double sueldoporhoras)
            {
                this.sueldoporhoras = sueldoporhoras;
            }
        }
    }
}