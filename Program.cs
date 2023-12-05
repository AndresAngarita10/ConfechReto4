// See https://aka.ms/new-console-template for more information
Console.WriteLine("Corfech!");
Console.WriteLine("Ingrese la cantidad de universaidades participantes");
int CantUniversidades = Convert.ToInt32(Console.ReadLine());
int contador = 1;
int UAceptan = 0; int URechazan = 0; int UEmpate = 0;
List<List<string>> ListaUniversidades = new();

while (contador <= CantUniversidades)
{
    string voto = "";
    List<string> VotosUniversidad = new();
    Console.WriteLine("Ingrese el Nombre de la universidad: ");
    string Nombre = Console.ReadLine();
    VotosUniversidad.Add(Nombre);
    while (voto.ToLower() != "x")
    {
        Console.WriteLine(" ");
        Console.WriteLine("Ingrese el voto");
        voto = Console.ReadLine().ToLower();
        if (voto == "a" || voto == "r" || voto == "n" || voto == "b" || voto == "x")
        {
            VotosUniversidad.Add(voto);
        }
    }
    ListaUniversidades.Add(VotosUniversidad);
    contador += 1;
}

Console.WriteLine("Numero de universidades: " + (contador - 1));
foreach (var list in ListaUniversidades)
{
    int aceptan = 0; int rechazan = 0; int blancos = 0; int nulos = 0;
    Console.WriteLine(" ");
    Console.WriteLine("Universidad: " + list[0]);
    for (int i = 1; i < list.Count; i++)
    {
        Console.WriteLine("Voto: " + list[i]);
        switch (list[i])
        {
            case "a":
                aceptan += 1;
                break;
            case "r":
                rechazan += 1;
                break;
            case "b":
                blancos += 1;
                break;
            case "n":
                nulos += 1;
                break;
            default:

                break;
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine(list[0] + ": " + aceptan + " aceptan, " + rechazan + " rechazan, " + blancos + " blancos, " + nulos + " nulos");
    Console.WriteLine(" ");
    if (aceptan > rechazan)
    {
        UAceptan += 1;
    }
    else if (rechazan > aceptan)
    {
        URechazan += 1;
    }
    else if (aceptan == rechazan)
    {
        UEmpate += 1;
    }

}
Console.WriteLine(" ");
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine(" ");
Console.WriteLine("Universidades que aceptan: " + UAceptan);
Console.WriteLine("Universidades que rechazan: " + URechazan);
Console.WriteLine("Universidades con empate: " + UEmpate);