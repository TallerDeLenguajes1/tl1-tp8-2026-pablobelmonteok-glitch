Calculadora micalculadora = new Calculadora();
int sele=0;
int valor=0,seguir = 0;
do
{
    Console.WriteLine("Seleccione el tipo de operacion:");
    Console.WriteLine("1 : SUMA");
    Console.WriteLine("2 : RESTA");
    Console.WriteLine("3 : MULTIPLICACION");
    Console.WriteLine("4 : DIVICION");

    Console.WriteLine("Opcion elegida:");
    while (!int.TryParse(Console.ReadLine(), out sele)) 
        Console.WriteLine("Opcion invalida, ingrese un numero:");

    if (sele >= 1 && sele <= 5) // casos que usan numero entero
    {
        Console.WriteLine("Valor:");
        while (!int.TryParse(Console.ReadLine(), out valor)) // 
            Console.WriteLine("Valor invalido, ingrese un numero entero:");
    }

    switch (sele)
    {
        case 1:
               micalculadora.Operar(valor,TipoOperacion.Suma);
    
            break;
        case 2:
            micalculadora.Operar(valor,TipoOperacion.Resta);
            break;
        case 3:    
             micalculadora.Operar(valor,TipoOperacion.Multiplicacion);
            break;
        case 4:
             micalculadora.Operar(valor,TipoOperacion.Division);
            break;
        default:
            Console.WriteLine("Opcion invalida, elija entre 1 y 6");
            break;
    }
    Console.WriteLine("\n1 : Continuar  |  0 : Terminar");
    while (!int.TryParse(Console.ReadLine(), out seguir)) // 
        Console.WriteLine("Valor invalido, ingrese 1 o 0:");

} while (seguir == 1);
micalculadora.MostrarHistorial();