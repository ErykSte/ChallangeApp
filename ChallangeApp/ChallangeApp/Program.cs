//Zadanie domowe dzieñ 5 :)

var number = 4958;
var numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

Console.WriteLine("Wynik dla liczby: " + number);

int[] digit = new int[10];
digit[0] = 0;
digit[1] = 0;
digit[2] = 0;
digit[3] = 0;
digit[4] = 0;
digit[5] = 0;
digit[6] = 0;
digit[7] = 0;
digit[8] = 0;
digit[9] = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        digit[0]++;
    }
    else if (letter == '1')
    {
        digit[1]++;
    }
    else if (letter == '2')
    {
        digit[2]++;
    }
    else if (letter == '3')
    {
        digit[3]++;
    }
    else if (letter == '4')
    {
        digit[4]++;
    }
    else if (letter == '5')
    {
        digit[5]++;
    }
    else if (letter == '6')
    {
        digit[6]++;
    }
    else if (letter == '7')
    {
        digit[7]++;
    }
    else if (letter == '8')
    {
        digit[8]++;
    }
    else if (letter == '9')
    {
        digit[9]++;
    }
}

Console.WriteLine("Wyniki dla liczb:");
Console.WriteLine("0 => " + digit[0]);
Console.WriteLine("1 => " + digit[1]);
Console.WriteLine("2 => " + digit[2]);
Console.WriteLine("3 => " + digit[3]);
Console.WriteLine("4 => " + digit[4]);
Console.WriteLine("5 => " + digit[5]);
Console.WriteLine("6 => " + digit[6]);
Console.WriteLine("7 => " + digit[7]);
Console.WriteLine("8 => " + digit[8]);
Console.WriteLine("9 => " + digit[9]);