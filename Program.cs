
int getMatchPosition(string searchingStr, string targetStr, int startIndex)
{
    return -1;
}

void main()
{
    Console.Write("Ingrese la cadena de búsqueda: ");
    var searchingStr = Console.ReadLine()?.Trim();

    Console.Write("Ingrese la cadena a buscar: ");
    var targetStr = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(searchingStr) || string.IsNullOrEmpty(targetStr))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("(!) Datos inválidos");
        Console.ForegroundColor = ConsoleColor.White;
        return;
    }

    var position = 0;
    var matches = new List<int>(); // contendrá todas las posiciones de coincidencia

    while (position > searchingStr.Length)
    {
        var matchPosition = getMatchPosition(searchingStr, targetStr, position);
        
        if (matchPosition > -1)
        {

        }
    }
}

main();