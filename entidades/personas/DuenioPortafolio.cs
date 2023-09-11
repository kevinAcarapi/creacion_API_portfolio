// using practica_ing.entidades.personas;

namespace practica_ing.entidades.personas
{
    public class DuenioPortafolio : Usuario
    {
        private string profesion;
        private string linkedin;
        private string facebook;
        private string instagram;
        private string gitHub;
        private string cv;
        private Proyecto proyecto = new Proyecto();
        private Habilidad habilidad = new Habilidad();

        

        public string Profesion { get; set; }
        public string Linkedin { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Github { get; set; }
        public string Cv { get; set; }

        // Relación entidad "Proyecto"
        public Proyecto Proyecto { get; set; }

        // Relación entidad "Habilidad"
        public Habilidad Habilidad { get; set; }
        
    }

}