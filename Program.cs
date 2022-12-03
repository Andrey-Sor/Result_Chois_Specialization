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
            Console.Write("You didn't enter a word. Please, enter the word: ");
            arrayInitial[i] = Console.ReadLine();    
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

string[] FinalArray(string[] arrayInitial)
{
    Console.Write("How many characters in a word should be: "); //Сколько  символов в слове должно быть
    int charQuantity = Convert.ToInt32(Console.ReadLine());

    int arrayFinalLength = 0;  
    for(int i = 0; i < arrayInitial.Length; i++)
        if(arrayInitial[i].Length <= charQuantity)
            arrayFinalLength++;

    string[] arrayFinal = new string[arrayFinalLength];
    int j = 0;
        
    for(int i = 0; i < arrayInitial.Length; i++)
    {   
        if(arrayInitial[i].Length <= charQuantity)
        {        
            arrayFinal[j] = arrayInitial[i];
            j++;
        }  
    }
        return arrayFinal;
}

string[] initialArray = CreateInitialArray();
ShowArray(initialArray);
string[] finalArray = FinalArray(initialArray);
ShowArray(finalArray);