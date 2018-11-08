# .NET C# | CMD 1

Mostrar el mensaje "Hello World from c#" en una aplicación tipo consola.

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
class Principal{
    public static void Main(){
        System.Console.Write("Hello World from c#");
    }
}
```


## EJECUTAR EJEMPLO

```sh
# comandos cmd ---
# ingresar al directorio de trabajo donde esta ubicado el archivo main.cs
$ csc main.cs
```

## REQUISITOS 

* Tener instalado el compilador c sharp

* Notepad ó Notepad++

* visual studio code