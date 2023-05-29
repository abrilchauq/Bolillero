namespace Bolillero.Core;
public class Bolilla
{
    public List<int> Bolillas { get; set; }
    public List<int> Afuera { get; set; }
    public List<int> Adentro { get; set; }
    public IAzar Azar { get; set; }

    public Bolilla(int Bolillas, IAzar azar)
    {
        this.Bolillas = new List<int>();
        this.Afuera = new List<int>();
        this.Adentro = new List<int>();
        this.Azar = azar;
        CrearBolilla(Bolillas);
    }

    private Bolilla(Bolilla original)
    {
        Adentro = new List<int>(original.Adentro);
        Afuera = new List<int>(original.Afuera);
        Azar = original.Azar;
    }

    public bool Jugar(List<int> jugada)
    {
        for (int i = 0; i < jugada.Count; i++)
        {
            var bolilla = SacarBolilla();
            if (bolilla != jugada[i])
                return false;
        }
        return true;
    }

    public void CrearBolilla(int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
            Bolillas.Add(i);
    }

    public int SacarBolilla()
    {
        var bolilla = Azar.indiceAleatorio(Bolillas);
        Bolillas.Remove(bolilla);
        Afuera.Add(bolilla);
        return bolilla;
    }

    public void MeterBolillas()
    {
        Bolillas.AddRange(Afuera);
        Afuera.Clear();
    }

    public int JugarNVeces(List<int> jugada, int cantidad)
    {
        int ganadas = 0;
        for (int i = 0; i < cantidad; i++)
        {
            if (Jugar(jugada))
            {
                ganadas++;
            }
        }
        return ganadas;
    }

    public Bolilla Clonar() => new Bolilla(this);
}