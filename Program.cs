Random random = new Random();

//// номер 1

//int[] mas= new int[10];
//for (int i = 1; i <= 10; i++)
//{
//    Console.Write($"Введите {i}-й элемент массива ");
//    int n=int.Parse( Console.ReadLine() );
//    mas[i - 1] = n;
//}
//Array.Sort( mas );
//foreach (int n in mas)
//{
//    Console.Write(n+" ");
//}
//Console.WriteLine();
//Console.WriteLine("Введите чисдо для поиска ");
//int m =int.Parse( Console.ReadLine() );
//int index = Array.IndexOf(mas, m);
//if (index!=-1)
//Console.WriteLine("индекс элемента = "index);
//else Console.WriteLine("Ошибка!");

// номер 2

double[] mas1 = new double[2];
double[] mas2 = new double[2];
double[] mas3 = new double[2];
double[] mas4 = new double[2];
for (int i = 0; i < 2; i++)
{
    mas1[i] = random.Next(51);
    mas2[i] = random.Next(51);
    mas3[i] = random.Next(51);
    mas4[i] = random.Next(51);
}
for (int i = 0; i < 2; i++)
{
    Console.Write(mas1[i]+" ");
}
Console.WriteLine();
for (int i = 0; i < 2; i++)
{
    Console.Write(mas2[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 2; i++)
{
    Console.Write(mas3[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 2; i++)
{
    Console.Write(mas4[i] + " ");
}
Console.WriteLine();
Console.WriteLine();
double[] mas1_2 = new double[2];
double[] mas3_4 = new double[2];
Console.Write("среднее арифметическое массивов 1 и 2 = ");
for (int i = 0; i <2; i++)
{
    mas1_2[i] = (mas1[i] + mas2[i]) / 2;
    Console.Write(mas1_2[i]+" ");
}
Console.WriteLine();
Console.Write("среднее арифметическое массивов 3 и 4 = ");
for (int i = 0; i < 2; i++)
{
    mas3_4[i] = (mas3[i] + mas4[i]) / 2;
    Console.Write(mas3_4[i] + " ");
}
Console.WriteLine();
Console.Write("Поизведение массивов со средними арифметическими значениями = ");
double[] mas1_2_3_4 = new double[2];
for (int i = 0; i < 2; i++)
{
    mas1_2_3_4[i] = (mas1_2[i] * mas3_4[i]);
    Console.Write(mas1_2_3_4[i] +" ");
}
Console.WriteLine();