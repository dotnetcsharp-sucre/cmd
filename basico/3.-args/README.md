# .NET C# | CMD 3


Elaborar una Aplicación que permita obtener los argumentos escritos
al programa cs , mediante el cmd

Ej. mono main.exe abrir-formulario ahora


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
using System.Linq;
class ProgramaPrincipal
{
    static void Main(string[] args)
    {

        foreach (var item in args.Select((element,index) => element.Contains("formulario")))
        {
            System.Console.WriteLine($"{(item?"CUMPLIÓ":"-")}");
        }

        

        System.Console.ReadLine();
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

* visual studio code