string[] GetArr(string message)
{
    Console.WriteLine(message);
    string text = Console.ReadLine();
    string[] textArr = text.Split(',');
    Console.WriteLine("[{0}]", string.Join(", ", textArr));
    return textArr;
}

void Element(string[] arr)
{
    string[] result = Array.Empty<string>();
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Array.Resize(ref result, j + 1);
            result[j] = arr[i];
            j++;
        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", result));
}

string[] array = GetArr("Введите элеметны массива через запятую");
Element(array);