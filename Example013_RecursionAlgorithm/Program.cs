string[,] table = new string[2, 5];
// String.Empty инициализация строк
// table [0,0] table [0,1] table [0,2] table [0,3]
// table [0,0] table [1,1] table [1,2] table [1,3]
//table[1, 2] = "слово";//обращение к нужному элементу массива (1 строка, 2 столбец)

//for (int rows = 0; rows < 2; rows++)
//{
    //for (int columns = 0; columns < 5; columns++)
    //{
        //Console.WriteLine($"{table[rows, columns]}-");
    //}
//}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)//matrix(имя массива).GetLength(0) новый функционал (0 количество строк)
    {
        for (int j = 0; j < matr.GetLength(1); j++)//matrix(имя массива).GetLength(0) новый функционал (1 количество столбцов)
        {
            Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
 }
}
void FillArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 matr[i,j] = new Random().Next(1,10);//[1; 10)
 }
 }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);



//Рекурсия
int Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;  // если n = 1, возвращаем 1.
 else return n * Factorial(n-1); // В противном случае берём текущее 
 //значение и умножаем на факториал предыдущего числа (n - 1).
}
Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6

//или
int Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
 Console.WriteLine(Factorial(i));
}
//числа Фибоначчи через рекурсию, возврат
double Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
 Console.WriteLine(Fibonacci(i));
}
