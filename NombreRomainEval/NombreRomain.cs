namespace NombreRomainEval
{
    public class NombreRomain
    {
        public static string Convertir(int nombre)
        {
            return nombre switch
            {
                <= 30 => NombreChiffreRomain.Nombre(nombre),
                _ => throw new NotImplementedException()
            };
        }

    }
}