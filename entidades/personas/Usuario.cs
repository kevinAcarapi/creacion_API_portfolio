using practica_ing.Controllers;

namespace practica_ing.entidades.personas
{   
    public class Usuario
    {
        #region atributos privados
        private int id2;
        private int id;
        private string gmail;
        private string nombre;
        private string apellido;
        private string contrasenia;
        private bool activo;

        #endregion

        public int Id  
        { 
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Gmail  
        { 
            get
            {
                return this.gmail;
            }
            set
            {
                this.gmail = value;
            }
        }
        public string Nombre  
        { 
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido  
        { 
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string Contrasenia  
        { 
            get
            {
                return this.contrasenia;
            }
            set
            {
                this.contrasenia = value;
            }
        }
        public bool Activo
        { 
            get
            {
                return this.activo;
            }
            set
            {
                this.activo = value;
            }
        }
   
    }

}
 