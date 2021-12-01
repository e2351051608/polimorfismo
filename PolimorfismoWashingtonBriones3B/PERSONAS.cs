using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolimorfismoWashingtonBriones3B
{
    public class PERSONAS
    {
        private string apellidos;
        private string nombre;
        private int ID;
        private string ESTADOCIVIL;

        public PERSONAS(string apellidos, string nombre, int ID, string ESTADOCIVIL)
        {
            this.apellidos = apellidos;
            this.nombre = nombre;
            this.ID = ID;
            this.ESTADOCIVIL = ESTADOCIVIL;

        }
        public string getapellidos()
        {
            return apellidos;
        }
        public void setapellidos(string apeliidos)
        {
            this.apellidos = apeliidos;
        }

        public string getnombre()
        {
            return nombre;
        }
        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int getID()
        {
            return ID;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }

        public string getESTADOCIVIL()
        {
            return ESTADOCIVIL;
        }
        public void setESTADOCIVIL(string ESTADOCIVIL)
        {
            this.ESTADOCIVIL = ESTADOCIVIL;
        }
        public void ImprimirINFORMACION()
        {
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("                              INFORMACION                       ");
            Console.WriteLine("///////////////////////////////////////////////////////////////\n");


            Console.WriteLine("nombre: " + getnombre());
            Console.WriteLine("apellidos: " + getapellidos());
            Console.WriteLine("ID: " + getID());
            Console.WriteLine("ESTADOCIVIL: " + getESTADOCIVIL());

            Console.ReadKey();
        }
        public void NUEVOESTADO()
        {
            Console.WriteLine("ESTADOCIVIL: " + getESTADOCIVIL());

            Console.ReadKey();
        }


    }
}