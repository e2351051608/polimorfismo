using System;

namespace PolimorfismoWashingtonBriones3B
{
    class Program
    {
        static void Main(string[] args)
        {
            PERSONAS ESTADOCIVIL = new PERSONAS();
            ESTADOCIVIL.NUEVOESTADO();

            EMPLEADOS númerodedespacho = new EMPLEADOS();
            númerodedespacho.NUEVODESPACHO();

            ESTUDIANTES cursodematricula = new ESTUDIANTES();
            cursodematricula.NUEVAMATRICULA();

            PROFESORES departamento = new PROFESORES();
            departamento.NUEVODEPARTAMENTO();

            EMPLEADOS seccion = new EMPLEADOS();
            seccion.NUEVASECCION();
           
            PERSONAS imprimir_INFORMACION = new PERSONAS();
            imprimir_INFORMACION.ImprimirINFORMACION();


        }
    }
}   
