string[] strings = { "ни", "чего", "не","понятно", "но" , "очень", "интересно"};


static int ArrayLength (string[] strings)
{
    int count = 0;
    for (int i = 0; i < strings.Length; i++)
    {
       if (strings[i].Length<=3)
        {
            count++;
        }
       
    }
  return count;
}

string[] Count = new string[ArrayLength(strings)];

void Array (string[] strings,string[] Count)
{
    int count = 0;
    for(int i = 0; i < strings.Length; i++)
    {
        if(strings[i].Length <= 3)
        {
            Count[count] = strings[i];
           
            count++;

        }
    }
}

ArrayLength(strings);
Array(strings, Count);
Console.Write($"{string.Join(", ", Count)}");