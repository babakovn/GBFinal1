string[] Getstringarray(int len)
{
    string[] strarr = new string[len];
    for(int i = 0; i < len; i++)
    {
        Console.Write("Введите строку массива:");
        strarr[i] = Console.ReadLine();

    }
    return strarr;
}

void Printstringarr(string[] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

//

int len = 0;
Console.Write("Введите количество строк в масииве:");
int.TryParse(Console.ReadLine(), out len);

string[] arr = Getstringarray(len);

string[] arrexit = new string[len];

int j = 0;
for(int i = 0; i < arr.GetLength(0); i++)
{
    if(arr[i].Length < 4)
    {
        arrexit[j] = arr[i];
        j++;
    }
}

Printstringarr(arrexit);
