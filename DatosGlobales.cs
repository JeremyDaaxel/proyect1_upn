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
    
    //datos del triaje que registra tópico (presion, temperatura y peso separados, observaciones, seguro y costo)
    public class Triaje
    {
        public int Dni;
        public string PresionArterial = "";
        public string Temperatura = "";
        public string Peso = "";
        public string TemperaturaPeso => $"{Temperatura} °C / {Peso} kg";
        public string Observaciones = "";
        public string Seguro = "";
        public int Costo = 0;
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
        public static Paciente[] pacientes = new Paciente[100];
        public static int contadorPacientes = 0;

        public static Triaje[] atenciones = new Triaje[100];
        public static int contadorAtenciones = 0;

        public static Diagnostico[] diagnosticos = new Diagnostico[100];
        public static int contadorDiagnosticos = 0;

        public static Cita[] citas = new Cita[100];
        public static int contadorCitas = 0;
    }
}
