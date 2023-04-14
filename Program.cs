bool matchesFromLeft(string searchingStr, string targetStr, int position)
{
    for (int i = 0; i < targetStr.Length; i++)
    {
        if (searchingStr[position + i] != targetStr[i])
            return false;
    }

    return true;
}

int getMatchPosition(string searchingStr, string targetStr, int startPosition)
{
    while (startPosition < searchingStr.Length)
    {
        if (matchesFromLeft(searchingStr, targetStr, startPosition))
            return startPosition;

        startPosition++;
    }

    return -1;
}

void main()
{
    //Console.Write("Ingrese la cadena de búsqueda: ");
    var searchingStr = "Rindiendo la evAluación T1 de anAlisis de Algoritmos";//Console.ReadLine()?.Trim();

    //Console.Write("Ingrese la cadena a buscar: ");
    var targetStr = "Al";//Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(searchingStr) || string.IsNullOrEmpty(targetStr))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("(!) Datos inválidos");
        Console.ForegroundColor = ConsoleColor.White;
        return;
    }

    var position = 0;
    var matches = new List<int>(); // contendrá todas las posiciones de coincidencia

    while (position < searchingStr.Length)
    {
        var matchPosition = getMatchPosition(searchingStr, targetStr, position);

        if (matchPosition == -1)
            break;

        matches.Add(matchPosition);

        position = matchPosition + 1;
    }
}

main();