
// Задача 25


Console.WriteLine("Программа возъведет число A в натуральную степень числа B ");

Console.WriteLine("Напишите число A ");
int.TryParse(Console.ReadLine(), out int a );

Console.WriteLine("Напишите число B ");
int.TryParse(Console.ReadLine(), out int b );
int a1=a;
b--;
while(true)
{
    if(b>0)
    {
        a*=a1;
        b-- ;
    }
    else
    {
    break;
    }
}

Console.WriteLine(a);




// задача 27
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
    
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

// Задачаь 29
int lenArray = ReaddInt("Введите длинну массива: ");

int[] userLen = new int[lenArray];
for (int i = 0; i < userLen.Length; i++)
{
    userLen[i] = new Random().Next(1,9);
    Console.Write(userLen[i] + " ");
}
int ReaddInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


 




