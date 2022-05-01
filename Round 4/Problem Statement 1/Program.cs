using (StreamReader sr = new StreamReader("../../../sample_ts1_input.txt"))
{
    int Count = Convert.ToInt32(sr.ReadLine());
    while (Count-- > 0)
    {
        int Size = Convert.ToInt32(sr.ReadLine());
        string Colors = sr.ReadLine();
        int Combination = 0;
        while (true)
        {
            int Continuous = 1;
            int i = 0;
            while (true)
            {
                if (i < Size)
                {
                    if (Colors[i].ToString() == Colors[i + 1].ToString())
                    {
                        Continuous++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (Continuous > 2)
            {
                Combination++;
            }
            int tempI = i;
            while (true)
            {
                if (tempI < Size)
                {
                    if (Colors[i].ToString() != Colors[tempI].ToString())
                    {
                        tempI++;
                    }
                    else
                    {
                        Combination++;
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}