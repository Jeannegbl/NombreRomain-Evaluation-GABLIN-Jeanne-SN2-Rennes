namespace NombreRomainEval
{
    public class NombreRomain
    {
        public static string Convertir(int nombre)
        {
            return nombre switch
            {
                <= 50 => NombreChiffreRomain.Nombre(nombre),
                _ => throw new NotImplementedException()
            };
        }

    }
}