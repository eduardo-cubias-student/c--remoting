namespace Comun
{
    public enum TipoMoneda
    {
        DolarEuro,
        EuroDolar
    }

    public interface IMoneda
    {
        double Convertir(TipoMoneda tipo, double cantidad);
    }
}
