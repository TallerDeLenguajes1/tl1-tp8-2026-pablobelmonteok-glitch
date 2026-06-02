Console.WriteLine("Hello, World!");
// lista de objetos int
// crear una lista vacía

List<Tarea>tareasPendientes = new List<Tarea>();
tareasPendientes.Add(new Tarea { TareaID = 1, Descripcion = "pendiente", Duracion = 2});
tareasPendientes.Add(new Tarea { TareaID = 2, Descripcion = "pendiente", Duracion = 3});

for (int i = 0; i < Cantmax; i++)
{
    Tarea tarea = new Tarea ();
     tarea.Descripcion = "pediente";
     tarea.Duracion = 2;
     tarea.TareaID = i;
}
// inicializar con valores
//List<int> numeros = new List<int>() { 10, 20, 30 };
   // acceso por índice (base 0)
// "Manzana"

// recorrer con foreach
foreach (Tarea f in tareasPendientes)
{
   Console.WriteLine(f.TareaID);
   Console.WriteLine(f.Descripcion);
   Console.WriteLine(f.Duracion);
   Console.WriteLine("\n");
}

// cantidad de elementos
    // 3
