Console.WriteLine("Cantidad de tareas: ");
int.TryParse(Console.ReadLine(), out int valor) ;

// crear una lista vacía
List<Tarea>tareasPendientes = new List<Tarea>();
for (int i = 0; i < valor; i++)
{
    Tarea tarea = new Tarea ();
     Console.WriteLine($"Ingrese descripción de la tarea {i}: ");
    tarea.Descripcion = Console.ReadLine();
     tarea.Duracion = 13;
     tarea.TareaID = i;
     tareasPendientes.Add(tarea);
}

// recorrer la lista con foreach
foreach (Tarea f in tareasPendientes)
{
 Console.WriteLine("Lista de Tareas");
   Console.WriteLine(f.TareaID);
   Console.WriteLine(f.Descripcion);
   Console.WriteLine(f.Duracion);
   Console.WriteLine("\n");
}

List<Tarea>tareasRealizadas = new List<Tarea>();
foreach (Tarea f in tareasPendientes)
{
   if(f.Descripcion == "Realizadas")
    { 
        
        tareasRealizadas.Add(f);
    }
}

// elimina el bloque de tareas pendientes 
tareasPendientes.RemoveAll(f => f.Descripcion == "Realizadas");
foreach (Tarea T in tareasRealizadas)
{
   Console.WriteLine("Lista de Tareas Realizadas");
   Console.WriteLine(T.TareaID);
   Console.WriteLine(T.Descripcion);
   Console.WriteLine(T.Duracion);
   Console.WriteLine("\n");
}

Console.WriteLine("---------------------- Menu Principal ----------------------");
Console.WriteLine("Presione 1: Buscar tareas pendientes");
Console.WriteLine("Presione 2: Buscar tareas realizadas");
Console.WriteLine("Presione 3: Buscar por ID de la tarea");
int.TryParse(Console.ReadLine(), out int buscar) ;

if (buscar == 1)
{
 foreach (Tarea f in tareasPendientes)
{
 Console.WriteLine("Lista de Tareas");
   Console.WriteLine(f.TareaID);
   Console.WriteLine(f.Descripcion);
   Console.WriteLine(f.Duracion);
   Console.WriteLine("\n");
}
}
if (buscar == 2){
        foreach (Tarea T in tareasRealizadas)
{
   Console.WriteLine("Lista de Tareas Realizadas");
   Console.WriteLine(T.TareaID);
   Console.WriteLine(T.Descripcion);
   Console.WriteLine(T.Duracion);
   Console.WriteLine("\n");
}
}
if (buscar == 3)
{
 Console.WriteLine("ID que requiera encontrar: ");
int.TryParse(Console.ReadLine(), out int id) ;
      foreach (Tarea T in tareasRealizadas)
{
    if(T.TareaID == id){
   Console.WriteLine("encontrado en Tareas Realizadas");
   Console.WriteLine(T.TareaID);
   Console.WriteLine(T.Descripcion);
   Console.WriteLine(T.Duracion);
   Console.WriteLine("\n");
   }
}
      foreach (Tarea T in tareasPendientes)
{
    if(T.TareaID == id){
   Console.WriteLine("encontrado en Tareas Pealizadas");
   Console.WriteLine(T.TareaID);
   Console.WriteLine(T.Descripcion);
   Console.WriteLine(T.Duracion);
   Console.WriteLine("\n");
   }
}
}
    
