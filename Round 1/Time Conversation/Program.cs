Console.Write("Hours: ");
int Hours = Convert.ToInt32(Console.ReadLine());
Console.Write("Minutes: ");
int Minutes = Convert.ToInt32(Console.ReadLine());
Console.Write("AM or PM: ");
string strMode = Console.ReadLine();
if (strMode == "PM")
{
    Hours += 12;
}
if(Hours == 12 && strMode == "AM")
{
    Hours = 0;
}
Console.WriteLine(Hours + ":" + Minutes);