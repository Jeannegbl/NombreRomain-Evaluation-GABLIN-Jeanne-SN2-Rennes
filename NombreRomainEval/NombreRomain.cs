namespace NombreRomainEval
{
    public class NombreRomain
    {
        public static string Convertir(int nombre)
        {
            return nombre switch
            {
                1 => NombreChiffreRomain.Unite,
                _ => throw new NotImplementedException()
            };
        }

    }
}