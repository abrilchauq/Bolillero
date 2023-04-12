namespace Bolillero.Core;
public class Bolilla
{
    public int cantidad { get; set; }
    public List<int> Bolillas { get; set; }
    public IAzar Azar { get; set; }
    
    public Bolilla(int cantidad, int Bolillas, IAzar azar)
    {
        this.cantidad = cantidad;
        this.Bolillas = new List<int>();
        this.Azar = azar;
    }

    
}
