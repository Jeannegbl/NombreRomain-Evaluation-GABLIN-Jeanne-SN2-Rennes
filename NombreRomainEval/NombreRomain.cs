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
                _ => throw new NotImplementedException()
            };
        }

    }
}