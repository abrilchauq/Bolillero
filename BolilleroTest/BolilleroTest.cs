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
        Assert.Equal(9, bolilla.);
        Assert.Equal(1, bolilla);
    }
}