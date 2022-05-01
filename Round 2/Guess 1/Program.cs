int n = Convert.ToInt32(Console.ReadLine());
List<int> lsDiv = new List<int>();
for(int i = 0; i <= n; i++)
{
    if(i % 3 == 0 || i % 5 == 0)
    {
        lsDiv.Add(i);
    }
}
for(int i = 0; i < lsDiv.Count; i++)
{
    for(int j = lsDiv[i]; j >= 1; j--)
    {
        lsDiv[i] = lsDiv[i] * j;
    }
}
Console.WriteLine(String.Join(",", lsDiv));