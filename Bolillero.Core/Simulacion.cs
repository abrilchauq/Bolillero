namespace Bolillero.Core
{
    public class Simulacion
    {
        public long simularSinHilos(Bolilla bolillero, List<int> jugada, int cantidad)
            => bolillero.JugarNVeces(jugada, cantidad);

        public long simularConHilos(Bolilla bolillero, List<int> jugada, int simulaciones, int hilos)
        {
            Task<long>[] tareas = new Task<long>[hilos];
            for (int i = 0; i < hilos; i++)
            {
                var clon = bolillero.Clonar();
            }
        }
    }
}