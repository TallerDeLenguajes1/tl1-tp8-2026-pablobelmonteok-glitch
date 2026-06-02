public class Tarea {
    private int duracion;
 public int TareaID { get; set; }
 public string Descripcion { get; set; }
 public int Duracion {
     get =>duracion; 
     set{
            if(value >10 && value <100){
                duracion = value;
            }
        }
        } // Validar que esté entre 10 y 100
 // Puedes añadir un constructor y métodos auxiliares si lo consideras necesarios
}
