namespace Program
{
    public class TeherAuto : Jarmu
    {
        public const int R_MIN = 0;
        public const int R_MAX = 20;
        private int m_Rakomany;
        public int Rakomany { get => m_Rakomany; set => m_Rakomany = Math.Clamp(value, R_MIN, R_MAX); }

        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany) : base(rendszam, kor, kilometerOra, uzemanyagSzint) {
            Rakomany = rakomany;
        }

        public override void InformaciotAd() => Console.WriteLine($"{Rendszam} - {Kor} éves teherautó, {KilometerOra} km-rel, rakomány: {Rakomany} tonna.");

        public override void Szervizel(int dij)
        {
            Rakomany = 0;
            base.Szervizel(dij);
        }
    }
}
