namespace NombreRomainEval
{
    public class NombreRomain
    {
        public static string Convertir(int nombre)
        {
            return nombre switch
            {
                1 => NombreChiffreRomain.Unite,
                2 => NombreChiffreRomain.Nombre(2),
                3 => NombreChiffreRomain.Nombre(3),
                4 => NombreChiffreRomain.Nombre(4),
                _ => throw new NotImplementedException()
            };
        }

    }
}