namespace Wetterstation
{
    partial class main
    {
        static void FreeASpot(ref Datensatz[] Wetterdaten, int Position)
        {
            for (int UpperBorder = FindUpperBorder(ref Wetterdaten); UpperBorder > Position; UpperBorder--)
            {
                Swap(ref Wetterdaten, UpperBorder, UpperBorder - 1);
            }
        }
    }
}
