using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolimorfismoWashingtonBriones3B
{
    public abstract class EMPLEADOS : PERSONAS
    {
        public class EMPLEADOS
        {
            int añodeincorporación;
            int númerodedespacho;
            string sección;
            public EMPLEADOS(int añodeincorporación, int númerodedespacho, string sección)
            {
                this.añodeincorporación = añodeincorporación;
                this.númerodedespacho = númerodedespacho;
                this.sección = sección;
            }
            public int getañodeincorporación()
            {
                return añodeincorporación;
            }
            public void setañodeincorporación(int añodeincorporación)
            {
                this.añodeincorporación = añodeincorporación;
            }
            public int getnúmerodedespacho()
            {
                return númerodedespacho;
            }
            public void setnúmerodedespacho(int númerodedespacho)
            {
                this.númerodedespacho = númerodedespacho;
            }
            public string getsección()
            {
                return sección;
            }
            public void setsección(string sección)
            {
                this.sección = sección;
            }
            
          
        }

        internal void NUEVASECCION()
        {
            throw new NotImplementedException();
            Console.WriteLine("sección: " + getsección());

            Console.ReadKey();
        }

        internal void NUEVODESPACHO()
        {
            throw new NotImplementedException();
            Console.WriteLine("númerodedespacho: " + getnúmerodedespacho());

            Console.ReadKey();
        }
    }
}