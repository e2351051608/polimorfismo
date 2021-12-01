using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolimorfismoWashingtonBriones3B
{
    public abstract class PROFESORES : PERSONAS
    {
        public class PROFESORES
        {
            int añodeincorporación;
            int númerodedespacho;
            string departamento;
            public PROFESORES(int añodeincorporación, int númerodedespacho, string departamento)
            {
                this.añodeincorporación = añodeincorporación;
                this.númerodedespacho = númerodedespacho;
                this.departamento = departamento;
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
            public string getdepartamento()
            {
                return departamento;
            }
            public void setdepartamento(string departamento)
            {
                this.departamento = departamento;
            }
           
        }

        internal void NUEVODEPARTAMENTO()
        {
            throw new NotImplementedException();
            Console.WriteLine("departamento: " + getdepartamento());

            Console.ReadKey();
        }
    }
}