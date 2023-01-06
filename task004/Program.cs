Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int [] Array = new int (num);
int Array [0] = 0;
int Array [1] = 1;
int i = 2;

while (i <num)
{
    Array[i] = Array [i] + i;
    i++;

}

Console.WriteLine();
