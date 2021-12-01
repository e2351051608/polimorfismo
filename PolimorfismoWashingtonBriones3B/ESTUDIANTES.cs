using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolimorfismoWashingtonBriones3B
{
    public abstract class ESTUDIANTES : PERSONAS
    {
        public class ESTUDIANTES
        {
            string cursodematricula;
            public ESTUDIANTES(string cursodematricula)
            {
                this.cursodematricula = cursodematricula;
            }

            public int getcursodematricula()
            {
                return cursodematricula;
            }
            public void setcursodematricula(string cursodematricula)
            {
                this.cursodematricula = cursodematricula;
            }
        }

        internal void NUEVAMATRICULA()
        {
            throw new NotImplementedException();
            Console.WriteLine("cursodematricul: " + setcursodematricula());

            Console.ReadKey();
        }
    }
}