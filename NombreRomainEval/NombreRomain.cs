namespace NombreRomainEval
{
    public class NombreRomain
    {
        public static string Convertir(int nombre)
        {
            return nombre switch
            {
                <= 3 => NombreChiffreRomain.Nombre(nombre),
                4 => NombreChiffreRomain.Nombre(4),
                <= 8 => NombreChiffreRomain.Nombre(nombre),
                9 => NombreChiffreRomain.Nombre(9),
                <= 11 => NombreChiffreRomain.Nombre(nombre),
                _ => throw new NotImplementedException()
            };
        }

    }
}