Console.Write("Введи цифру, обозначающую день недели: ");
int day= Convert.ToInt32(Console.ReadLine());

if(day<=5){

Console.WriteLine("рабочий");
}
else
{
Console.WriteLine("выходной");
}

Console.ReadLine();