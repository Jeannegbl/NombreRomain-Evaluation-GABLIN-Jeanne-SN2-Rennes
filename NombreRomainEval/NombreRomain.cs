namespace NombreRomainEval
{
    public class NombreRomain
    {
        public static string Convertir(int nombre)
        {
            return nombre switch
            {
                4 => NombreChiffreRomain.Nombre(4),
                9 => NombreChiffreRomain.Nombre(9),
                14 => NombreChiffreRomain.Nombre(14),
                19 => NombreChiffreRomain.Nombre(19),
                <= 23 => NombreChiffreRomain.Nombre(nombre),
                24 => NombreChiffreRomain.Nombre(24),
                _ => throw new NotImplementedException()
            };
        }

    }
}