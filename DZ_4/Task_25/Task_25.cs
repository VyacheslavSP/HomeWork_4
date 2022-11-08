int a=0;
int b=0;
double Result=1;
try
{
  Console.WriteLine("Введите первое число");
  a=Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите второе число");
  b=Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Неккоректный ввод числа");
}
finally
{
  for(int i=0;i<Math.Abs(b);++i)
  {
    Result=Result*a;
  }
  if(b<0)
  {
  Result=1/Result;
  }
  Console.WriteLine("Результат " + Result);
}
