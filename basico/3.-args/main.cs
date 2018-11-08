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