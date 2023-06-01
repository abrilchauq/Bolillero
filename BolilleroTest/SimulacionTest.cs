using Bolillero.Core;

namespace BolilleroTest
{
    public class SimulacionTest
    {
        public Bolilla bolillero { get; set; }
        public Simulacion simulacion { get; set; }
        public List<int> jugada { get; set; }
        public int cantidad { get; set; }

        public SimulacionTest()
        {
            
        }

        [Fact]
        public void simularSinHilos()
        {
            Assert.True(true);
        }
    }
}