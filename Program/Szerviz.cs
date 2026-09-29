namespace Program
{
    public class Szerviz
    {
        public List<Jarmu> Jarmuvek { get; } = [];

        public void JarmuFelvetele(Jarmu jarmu) {
            Jarmuvek.Add(jarmu);
            Console.WriteLine("a jármű megérkezett a szervizbe.");
        }

        public void InformaciokListazasa() {
            Jarmuvek.ForEach(it => it.InformaciotAd());
        }

        public void CsoportosSzerviz(int dij) {
            Jarmuvek.ForEach(it =>
            {
                if (it.SzervizSzukseges) it.Szervizel(dij);
                else Console.WriteLine($"A {it.Rendszam} szervizelése jelenleg nem szükséges.");
            });
        }
    }
}
