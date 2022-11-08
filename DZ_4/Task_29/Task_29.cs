// напишите программу,которая задет массив из n элементов и выводит их на экран\\
Random RndSizeArrey = new Random();
Random ArreyItems = new Random();
byte[] MyArr = new byte[RndSizeArrey.Next(0, 256)];     // массив случайного размера
for (byte i =0; i<MyArr.Length;i++)
{
  MyArr[i]=(byte)ArreyItems.Next(0, 256);
}
for (byte i =0; i<MyArr.Length;i++)
{
  string chars=", ";
  if (i==0)
    {
      Console.Write( "[");
    }
  if(i==(byte)(MyArr.Length-1))
    {
      chars=("]"+"\n");
    }
Console.Write( MyArr[i]+chars);
}
