namespace Program
{
    public class Jarmu
    {
        public const string LP_DEFAULT = "ISMERETLEN";
        private string m_Rendszam = LP_DEFAULT;
        public string Rendszam { get => m_Rendszam; set => m_Rendszam = string.IsNullOrEmpty(value) ? LP_DEFAULT : value; }

        public const int A_MIN = 0;
        public const int A_MAX = 50;
        private int m_Kor;
        public int Kor { get => m_Kor; set => m_Kor = Math.Clamp(value, A_MIN, A_MAX); }

        public const int KM_MIN = 0;
        private int m_KilometerOra;
        public int KilometerOra { get => m_KilometerOra; set => m_KilometerOra = Math.Max(0, value); }

        public const int F_MIN = 0;
        public const int F_MAX = 100;
        private int m_UzemanyagSzint;
        public int UzemanyagSzint { get => m_UzemanyagSzint; set => m_UzemanyagSzint = Math.Clamp(value, F_MIN, F_MAX); }

        public bool SzervizSzukseges => KilometerOra >= 200_000;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            UzemanyagSzint = uzemanyagSzint;
        }

        public virtual void InformaciotAd() => Console.WriteLine($"{Rendszam} - {Kor} éves elektromos autó, {KilometerOra} km-rel.");

        public virtual void Szervizel(int dij) {
            if (dij > 100_000) KilometerOra -= 10_000;
            UzemanyagSzint -= 10;
            Console.WriteLine("a jármű szervizelése megtörtént");
        }
    }
}
