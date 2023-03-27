Console.WriteLine("Elija un programa de los siguientes: A. C#    B. Java    C. C++");
String programa = Console.ReadLine();

switch (programa)
{
    case "A":
        Console.WriteLine("Usted ha elegido el programa C#");
        break;

    case "B":
        Console.WriteLine("Usted ha elegido el programa Java");
        break;

    case "C":
        Console.WriteLine("Usted ha elegido el programa C++");
        break;

    default:
        Console.WriteLine("No conozco ese dato");
        break;
}