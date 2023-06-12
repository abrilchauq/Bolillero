using Bolillero.Core;

namespace BolilleroTest
{
    public class SimulacionTest
    {
        public Bolilla bolillero { get; }
        public Simulacion simulacion { get; }
        public List<int> jugada { get; }
        public int cantidad { get; }
        private int hilos { get; }

        public SimulacionTest()
        {
            this.bolillero = new Bolilla(10, new ElegirPrimera());
            this.simulacion = new Simulacion();
            this.jugada = new List<int>(){ 0 }; 
            this.cantidad = 1;
            this.hilos = 4;
        }

        [Fact]
        public void simularSinHilos()
        {
            var ganadas = simulacion.simularSinHilos(bolillero, jugada, cantidad);
            Assert.Equal(1, ganadas);
        }

        [Fact]
        public void simularConHilos()
        {
            
        }
    }
}