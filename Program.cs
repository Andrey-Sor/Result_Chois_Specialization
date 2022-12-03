string[] CreateInitialArray()
{
    Console.Write("Input the number of words: ");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] arrayInitial = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Enter the word: ");
        arrayInitial[i] = Console.ReadLine();

        if(arrayInitial[i] == string.Empty) 
        {
            Console.WriteLine("You didn't enter a word. Please, enter the word: ");
        }
    }
    return arrayInitial;
}

void ShowArray(string[] array)
{
    Console.Write("Your string: [");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write('"' + array[i] + '"');
        if(i < array.Length - 1)
            Console.Write(", ");
    }       
    Console.WriteLine("]");
}



string[] initialArray = CreateInitialArray();
ShowArray(initialArray);