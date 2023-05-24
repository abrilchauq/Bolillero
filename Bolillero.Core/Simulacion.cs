namespace Bolillero.Core
{
    public class Simulacion
    {
        public long simularSinHilos(Bolilla bolillero, List<int> jugada, int cantidad) 
            => bolillero.JugarNVeces(jugada, cantidad);

        public long simularConHilos(Bolilla bolillero, List<int> jugada, int cantidad)
        {
            Task<long>
        }
        // declarar vector tipo Task<long> implementar for
    } 
}