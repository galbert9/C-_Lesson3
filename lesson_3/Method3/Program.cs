//  Method3 Ничего не принимает, но что-то возвращает
int Method3()
{
   return DateTime.Now.Year;
}
 
int year = Method3();
Console.WriteLine(year);

