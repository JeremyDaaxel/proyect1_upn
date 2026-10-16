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
    
    //datos del triaje que registra tópico (presion, temperatura y peso, observaciones)
    public class Triaje
    {
        public int Dni;
        public string PresionArterial = "";
        public string TemperaturaPeso = "";
        public string Observaciones = "";
    }

    //datos del diagnostico que registra el doctor (sintomas, diagnostico, receta)
    public class Diagnostico
    {
        public int Dni;
        public string Sintomas = "";
        public string DiagnosticoMedico = "";
        public string Receta = "";
    }

    //datos de la cita que registra el paciente (especialidad, fecha, costo segun SIS)
    public class Cita
    {
        public int Dni;
        public string Especialidad = "";
        public string Fecha = "";
        public int Costo;
    }

    //clase estatica, osea q no va a cambiar pe
    //lo mismo que en paciente
    public static class Datos
    {
        public static List<Paciente> pacientes = new List<Paciente>();
        public static List<Triaje> atenciones = new List<Triaje>();
        public static List<Diagnostico> diagnosticos = new List<Diagnostico>();
        public static List<Cita> citas = new List<Cita>();
    }
}
