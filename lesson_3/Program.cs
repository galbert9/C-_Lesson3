// Method1 Ничего не принимают, ничего не возвращают

void Method1()
{
 Console.WriteLine("Текст "); 
}
// Этот метод вызывается следующим образом
Method1();

// Method2 Что принимает, ничего не возвращает
// void Method2 (string msg)
// {
//     Console.WriteLine(msg);
// }
// // Этот метод вызывается командой:
// Method2 ("Текст сообщения");

// // Более 2- аргументов
// void Method2 (string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Этот метод вызывается командой:
// Method2 (msg: "Текст сообщения", count: 4);

// // Method3 Ничего не принимает, но что-то возвращает
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// // // Method4 Что-то принимает, что-то возвращает

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
    
// }
// // Для вызова этого метода требуется:
// string res = Method4 (10, "GL");
// Console.WriteLine(res);

// // Цикл for (4-я группа)
// string Method4(int count, string text)
// {
//         string result = String.Empty;
//         for ( int i = 0; i < count; i++)
//         {
//         result = result + text;
//         }
//     return result;
    
// }
// // Для вызова этого метода требуется:
// string res = Method4(10, "GL");
// Console.WriteLine(res);

// Цикл в цикле Таблица умножения

// for (int i = 2; i<=10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}*{j} = {i*j}");
//     }
// Console.WriteLine();
// }
