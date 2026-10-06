namespace Program;

public class Tank : Jarmu
{
    public new const uint A_MAX = 10; // uint takes care of the min bound
    private uint m_Ammo;
    public uint Ammo { get => m_Ammo; set => m_Ammo = Math.Min(value, A_MAX); }

    public Tank(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, uint ammo=6) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
    {
        Ammo = ammo;
    }

    public override void InformaciotAd()
    {
        Console.WriteLine($"(Tank) {Rendszam}, {KilometerOra}, {Kor}, {Ammo}");
    }

    public override void Szervizel(int dij)
    {
        base.Szervizel(dij);
        if (dij > 0) Ammo += (uint)(dij) / 10000U;
    }
}
