namespace Bolillero.Core
{
    public class ElegirPrimera : IAzar
    {
        public int indiceAleatorio(List<int> bolillas)
        {
            return bolillas[0];
        }
    }
}