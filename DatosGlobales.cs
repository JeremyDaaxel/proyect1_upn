using System.Collections.Generic;

namespace proyecto1
{
    public class Paciente
    {  //como me enseñaron en el cibertec :v
        //datos globales de el paciente y diras pq lo ponemos aca?
        //lo ponemos aca para que cualquier Form puede acceder a ellos, easy vrd?
        public int Dni;
        public string Nombre = "";
        public string Apellido = "";
        public string Correo = "";
        public int Celular;
        public string Seguro = "";
    }
    
    //clase estatica, osea q no va a cambiar pe
    //lo mismo que en paciente
    public static class Datos
    {
        public static List<Paciente> pacientes = new List<Paciente>();
    }
}
