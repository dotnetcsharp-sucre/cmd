# .NET C# | CMD 2


Elaborar una Aplicación que permita al usuario introducir una cantidad de segundos que estén entre un rango de 1 a 15 segundos, 
luego al presionar enter que le muestre la cuenta de dichos segundos en pantalla 
,

por ej: 

> "Esperando => 1 seg"

> "Esperando => 2 seg"

> "Esperando => 3 seg" 

> "Esperando => ....." 

Asi hasta llegar a la cantidad de seg. que introdujo.

En caso de que la cantidad de segundos no se encuentre en el rango permitido mostrar un mensaje

Por ej: "Lo siento no podemos administrar la cantidad de seg. asignado :("


## PASOS

```sh
# comandos cmd ---
# crear carpeta llamada dotnet-sucre
$ mkdir dotnet-sucre 
# ingresar en el interior de la carpeta creada
$ cd dotnet-sucre
# establecer directorio actual como un repositorio git
$ git init
# abrir la carpeta actual en visual studio code
$ code .
```

## CÓDIGO

```cs
using System;
using System.Threading;

namespace ConsoleApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cuantos segundos deseas esperar?");
            Console.WriteLine("--NOTA : puede seleccionar entre 1 a 15 segundos--");
            byte segundos = byte.Parse(Console.ReadLine());

            if (segundos < 1 || segundos > 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo siento no podemos administrar la cantidad de seg. asignado :(");
                Console.WriteLine("<Presione una tecla para finalizar>");
                Console.ReadLine();
                return;
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Esperemos juntos :)");

            for (byte i = 0; i < segundos; i++)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Esperando => " + (i + 1) +" seg.");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gracias por tu ayuda :)");

            Console.WriteLine("<Presione ENTER para finalizar>");
            Console.ReadLine();
        }
    }
}
```


## EJECUTAR EJEMPLO

```sh
# comandos cmd ---
# ingresar al directorio de trabajo donde esta ubicado el archivo main.cs
$ csc main.cs
# ejecutar con mono
$ mono main.exe
```

## REQUISITOS 

* Tener instalado el compilador c sharp
* Tener instalado mono
* visual studio code