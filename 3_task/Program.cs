//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] array1 =new int[20];
for (int i=0;i<array1.Length;i++)
{
array1[i]=new Random().Next(0,1000);
Console.Write(array1[i]+ " ");
}
void Method1 ()
{
int subtract=0;
int min=array1[0];
int max=array1[0];
for (int i=0;i<array1.Length;i++) 
{
if (array1[i] > max) max=array1[i];
if (array1[i] < min) min=array1[i];
}
subtract=max-min;
Console.WriteLine(" ");
Console.WriteLine($"Разница между максимальным и минимальным  числом равна {subtract} ");
}
Method1();