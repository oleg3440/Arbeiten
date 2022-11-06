// Метод вид 1 ничего не принимает, ничего не возврашает
void Method1 ();
{
    Console.WriteLine("Автор....");
} 
Method1();

// Метод вид 2 что-то принимает, ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текс сообщения");

void Method21(string msg, int count) //int count количество раз в методе сообщений count
{
    int i = 0;
    while (i < count)
    Console.WriteLine(msg);
    i++;
}
Method21(msg: "Текс сообщения", coun: 4 ); //4 раза выводится string msg

// Метод вид 3 ничего не принимают, что-то возвращают
int Method3()              //тип данных значение которого иы ожидаем
{
    return DataTime.Now.Year;  //тело метода, какая-то работа
}

int year = Method3();//идентификатор переменной, который выводится = вызов метода      
Console.WriteLine(year);

// Метод вид 4 и приниамет и возвращет
// string Method4(int count, string text) // строку text компонуем count раз
// {
//     int i = 0;
//     string result = string.Empty; //string result переменная куда кладется результат 

//     while (i < count)
//     {
//         result = result + text; // переменная 
//         i++;
//     }
//     return result;   //возврат результата или переменной из метода
// }
// string res = Method4(10, "z"); //чтобы вызвать метод создаем переменную
// Console.WriteLine(res);

// Метод вид 4 и приниамет и возвращет с for
string Method4(int count, string text) // строку text компонуем count раз
{
    string result = string.Empty; //string result переменная куда кладется результат 
    for (int i = 0; i < count; i++)//инициализация счетчика; проверка условия; инкримент, увеличения счетчика 
    {
        result = result + text; // переменная 
    }
    return result;   //возврат результата или переменной из метода
}
string res = Method4(10, "z"); //чтобы вызвать метод создаем переменную
Console.WriteLine(res);
//Таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($”{i} * {j} = {i * j}”);
    }
Console.WriteLine();
}

/*Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
заменить большими «К», а большие «С» заменить на маленькие «с».*/
// string s = “qwerty”
// 012345
// s[3] // r
string Replase(string text, char oldValue, char newValue)
{
string result = String.Empty; //строке присваивается пустое значение
int length = text Length; //количество символов в строке
for (int i = 0; i < length; i++)
{
if(text[i] ==oldValue) result + $”{NewValue}”;/*если текущий сиивол i совпал с тем символом, 
который мы хотели заменить oldValue, то в результат мы положим значение в виде строки newValue*/
else result + $”{str[i]}”; //если соврадений не обнаружено добавим в resultсимвол, который был
}
return result
}
string newText = replace(text, ‘ ’, ‘ | ‘);
Console.WriteLine(newText);

/*1. Найти позицию минимального элемента в неотсортированной части массива.
2. Произвести обмен этого значения со значением первой неотсортированной позиции.
3. Повторять пока есть неотсортированные элементы.*/
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PtintArray(int[] array) // в качестве аргумента приходит массив
{
int count = array.Length
for (int i = 0; i < count; i++)
{
Console.Write($”{array[i]}”); //пробегаем по всем элементам массива и выводим
}
Console.WriteLine();// выводим пустую строку
}
void selectionSort(int[] array)//метод упорядочивает массив
{
for (int i = 0; i < array.Length - 1; i++)
{
int minPosition = i; 
for (int j = i+1; j < array.Length; j++)  //ищем максимальный элемент
{
if(array[j] < array[minPosition]) minPosition = j; 
{
minPosition = j
}
} 
int temporary = array[i]       //замена двух переменных местами
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
PrintArray(arr);
SelectionSort(arr);  //вызываем упорядочивание массива
PrintArray(arr);