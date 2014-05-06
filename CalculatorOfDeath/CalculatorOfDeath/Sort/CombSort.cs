namespace CalculatorOfDeath.Sort
{
    class CombSort: ISort
    {
        public int[] Sort(int[] mass)
        {
            double gap = mass.Length;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < mass.Length)
                {
                    int igap = i + (int)gap;
                    if (mass[i] > mass[igap])
                    {
                        int swap = mass[i];
                        mass[i] = mass[igap];
                        mass[igap] = swap;
                        swaps = true;
                    }
                    i++;
                }
            }
            return mass;
        }
    }
}
