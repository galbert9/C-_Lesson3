// // Method4 Что-то принимает, что-то возвращает
 
string Method4(int count, string text)
{
   int i = 0;
   string result = String.Empty;
 
   while (i < count)
   {
       result = result + text;
       i++;
   }
   return result;
  
}
// Для вызова этого метода требуется:
string res = Method4 (10, "GL");
Console.WriteLine(res);
