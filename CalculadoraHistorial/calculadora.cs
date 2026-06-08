public class Operacion{
 private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
 private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
 private TipoOperacion operacion;// El tipo de operación realizada

 public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion) //Asigno los valores de campos privados
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
    }
    public double Resultado{
 /* Lógica para calcular o devolver el resultado */
 get{
       switch (operacion)
{
    case TipoOperacion.Suma:
        return resultadoAnterior + nuevoValor;
    case TipoOperacion.Resta:
        return resultadoAnterior - nuevoValor;
    case TipoOperacion.Multiplicacion:
        return resultadoAnterior * nuevoValor;
    case TipoOperacion.Division:
        return resultadoAnterior / nuevoValor;
    default:
        return resultadoAnterior;
 }
  }
   }
// Propiedad pública para acceder al nuevo valor utilizado en la operación
 public double NuevoValor{
 get => nuevoValor;
 }
// Constructor u otros métodos necesarios para inicializar y gestionar la operación
// ...
} 
public enum TipoOperacion{
 Suma,
 Resta,
 Multiplicacion,
 Division,
 Limpiar // Representa la acción de borrar el resultado actual o el historial
 }
 public class Calculadora
{
    private double resultadoActual = 0;
    private List<Operacion> historial = new List<Operacion>();

    public void Operar(double nuevoValor, TipoOperacion opera)
    {
        Operacion op = new Operacion(resultadoActual, nuevoValor, opera);
        resultadoActual = op.Resultado;
        historial.Add(op); 
    }

    public double ResultadoActual { get => resultadoActual; }

    public void MostrarHistorial()
    {
        Console.WriteLine("--- Historial ---");
        foreach (Operacion op in historial)
        {
            Console.WriteLine("Resultado: "+op.Resultado);
        }
    }
}