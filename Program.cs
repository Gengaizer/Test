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

string[] newStrings = new string[ArrayLength(strings)];

void Array (string[] strings,string[] newStrings)
{
    int count2 = 0;
    for(int i = 0; i < strings.Length; i++)
    {
        if(strings[i].Length <= 3)
        {
            newStrings[count2] = strings[i];
           
            count2++;

        }
    }
}

ArrayLength(strings);
Array(strings, newStrings);
Console.Write($"{string.Join(", ", newStrings)}");
