string[] array = new string[8] {"FOX", "4", "MIX", "finrir", "-1", "big", "record", "222"};
string[] array2 = new string[array.Length];        
int а = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <=3)
    {   
        array2[а] = array[i];
        а++; 
    }
}

WriteArray(array2);

void WriteArray(string[] array)      
{
    for ( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
                                       
    }
    Console.WriteLine();
}