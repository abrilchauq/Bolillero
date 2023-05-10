using Bolillero.Core;

namespace BolilleroTest;

public class BolilleroTest
{
    public Bolilla bolillero { get; set; }
    public BolilleroTest() => bolillero = new Bolilla(10, new ElegirPrimera());

    [Fact]
    public void SacarBolilla()
    {
        var bolilla = bolillero.SacarBolilla();
        Assert.Equal(0, bolilla);
        Assert.Equal(9, bolillero.Bolillas.Count);
        Assert.Equal(1, bolillero.Afuera.Count);
    }

    [Fact]
    public void MeterBolillas()
    {
        Assert.Equal(10, bolillero.Bolillas.Count);
        bolillero.SacarBolilla();
        Assert.NotEmpty(bolillero.Afuera);
        bolillero.MeterBolillas();
        Assert.Empty(bolillero.Afuera);
    }

    [Fact]
    public void JugarGana()
    {
        var victoria = bolillero.Jugar(jugada: new List<int> {0, 1, 2, 3});
        Assert.True(victoria);
    }

    [Fact]
    public void JugarPierde()
    {
        var perdida = bolillero.Jugar(jugada: new List<int> {4, 2, 1});
        Assert.False(perdida);
    }

    [Fact]
    public void GanarNveces()
    {
        var ganada = bolillero.JugarNVeces(jugada: new List<int> {0, 1}, cantidad: 1);
        Assert.Equal(1, ganada);
    }
}