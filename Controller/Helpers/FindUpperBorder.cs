namespace Wetterstation
{
    partial class main
    {
        static int FindUpperBorder(ref Datensatz[] Wetterdaten)
        {
            Defragment(ref Wetterdaten);
            int Pos = 0;
            for (Pos = 0; Pos < Wetterdaten.Length; Pos++)
            {
                if (Wetterdaten[Pos].Datum == "  .  .    ")
                {
                    Pos--;
                    break;
                }
            }
            return Pos;
        }
    }
}
