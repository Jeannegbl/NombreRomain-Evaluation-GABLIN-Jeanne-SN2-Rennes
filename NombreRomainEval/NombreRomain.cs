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
                <= 13 => NombreChiffreRomain.Nombre(nombre),
                14 => NombreChiffreRomain.Nombre(14),
                _ => throw new NotImplementedException()
            };
        }

    }
}