int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
int count = 0;
while(true)
{
    int temp = b;
    b += a;
    a = temp;
    if (a >= n)
    {
        Console.Write(a + ", ");
        if (++count == 5)
            break;
    }
}