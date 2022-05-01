using (StreamReader sr = new StreamReader("../../../sample_ts1_input.txt"))
{
    int Count = Convert.ToInt32(sr.ReadLine());
    while (Count-- > 0)
    {
        string strNumbers = sr.ReadLine();
        int m = Convert.ToInt32(strNumbers.Split(" ")[0]);
        int n = Convert.ToInt32(strNumbers.Split(" ")[1]);
        int[,] iPressure = new int[m, n];
        List<int> lstPressures = new List<int>();
        for(int i = 0; i < m; i++)
        {
            string Inputs = sr.ReadLine();
            int j = 0;
            foreach(string Input in Inputs.Split(" "))
            {
                iPressure[i, j++] = Convert.ToInt32(Input);
            }
        }
        int lastIndex = 0;
        for (int c = 0; c < m; c++)
        {
            int indexColumn = 0;
            int oldIndex = 0;
            bool isFound = false;
            if (c != 0)
                while (iPressure[c - 1, n - 1] == iPressure[c, oldIndex])
                {
                    oldIndex++;
                    isFound = true;
                }
            if (!isFound)
                for (int i = 1; i <= n; i++)
                {
                    if (iPressure[c, indexColumn] > iPressure[c, i - 1])
                    {
                        indexColumn = i - 1;
                    }
                }
            if (c == 0)
                lstPressures.Add(iPressure[c, indexColumn]);
            else
                lstPressures.Add(Math.Abs(iPressure[c, indexColumn] - iPressure[c - 1, lastIndex]));
            int tempIndex = indexColumn;
            while (true)
            {
                lastIndex = tempIndex;
                tempIndex++;
                if (tempIndex == n)
                {
                    tempIndex = 0;
                }
                if (tempIndex == indexColumn)
                {
                    break;
                }
                lstPressures.Add(Math.Abs(iPressure[c, tempIndex] - iPressure[c, lastIndex]));
            }
        }
        Int64 Sum = 0;
        for (int i = 0; i < lstPressures.Count; i++)
        {
            Sum += lstPressures[i];
        }
        Console.WriteLine(Sum);
    }
}