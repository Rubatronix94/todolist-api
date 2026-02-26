using System.ComponentModel.DataAnnotations;

namespace todolist_api.Modelos
{
    public class Tareas
    {
        public int id { get; set; }


        [MaxLength(50, ErrorMessage ="el campo {0} debe tener maximo {1} caracteres")]
        public string titulo { get; set; } = null!;


        [DataType(DataType.MultilineText)] //PERMITE ESCRIBIR EN MULTIPLES LINEAS
        [MaxLength(500)]
        public string tarea { get; set; } = null!;


        public bool completado { get; set; } = false;
    }
}
