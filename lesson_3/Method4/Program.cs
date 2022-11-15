// // Method4 Что-то принимает, что-то возвращает

// // Типовая конструкция
// // Аргументы могут быть указаны в теле метода или предварительно
// int Method4(аргумент(ы), с указанием типа данных)
// {
// Действие
// return результат действия;
// }

// // Для вызова этого метода требуется:
// int res = Method4 (значения аргумента(ов), без указания типа данных);
// Console.WriteLine(res);

// // Вызов аргументов в теле метода
int Method4(int a, int b)
{
int result = a + b;
return result;
}

int res = Method4 (3, 4);
Console.WriteLine(res);

// Предварительный ввод значений аргумента 
// int a = 3;
// int b = 4; 
// int Method4(int a, int b)
// {
// int result = a + b;
// return result;
// }

// int res = Method4 (a, b);
// Console.WriteLine(res);


// Другие типы данных
// string Method4(int count, string text)
// {
//    int i = 0;
//    string result = String.Empty;
 
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
  
// }
// // Для вызова этого метода требуется:
// string res = Method4 (3, " GL");
// Console.WriteLine(res);

