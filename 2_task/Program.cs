// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array1 =new int[12] { 45, 34, 86, 56, 84, 65, 42, 83, 25, 71, 14, 25};
void Method1()
{
int sum=0;
for(int i=1;i<array1.Length;i=2+i)
{
sum=sum+array1[i];
}
Console.WriteLine(sum);
}
Method1();