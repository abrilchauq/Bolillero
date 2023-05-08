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
        // Assert.True();
    }

    [Fact]
    public void JugarPierde()
    {
        // Assert.False();
    }
}