namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        public new const int A_MIN = 0;
        public new const int A_MAX = 100;
        private int m_AkkumulatorSzint;
        public int AkkumulatorSzint { get => m_AkkumulatorSzint; set => m_AkkumulatorSzint = Math.Clamp(value, A_MIN, A_MAX); }

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, 0) {
            AkkumulatorSzint = akkumulatorSzint;
        }

        public override void InformaciotAd() => Console.WriteLine($"{Rendszam} - {Kor} éves elektromos autó, {KilometerOra} km-rel, {AkkumulatorSzint} % töltöttséggel.");

        public override void Szervizel(int dij)
        {
            if (dij > 100_000) KilometerOra -= 10_000;
            AkkumulatorSzint += 20;
            Console.WriteLine("hogy a jármű szervizelése megtörtént");
        }
    }
}
