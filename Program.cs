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




string[] initialArray = CreateInitialArray();
