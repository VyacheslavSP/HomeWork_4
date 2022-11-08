// напишите программу,которая принимает на вход число и выдает сумму цифр в числе\\
byte Summ=0;
string Number="";
bool FlagError=false;
Console.WriteLine("Введите число");
try
{
  int TmpNum= Convert.ToInt32(Console.ReadLine());
  Number=Convert.ToString(Math.Abs(TmpNum));
}
catch
{
  Console.WriteLine("Неккоректный ввод числа");
  FlagError=!FlagError;
}
finally
{
for (byte i =0;i<Number.Length;i++)
  {
    string TmpStr=Convert.ToString(Number[i]);
    byte TmpByte=Convert.ToByte(TmpStr);
    Summ=(byte)(Summ+TmpByte);
    }
if(!FlagError)
{
Console.WriteLine("Сумма чисел " + Summ);
}
}
