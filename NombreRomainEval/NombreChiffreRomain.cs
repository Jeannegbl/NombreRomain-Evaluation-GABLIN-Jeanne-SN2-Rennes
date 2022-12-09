namespace NombreRomainEval;

public class NombreChiffreRomain
{
    public static readonly string Unite = "I";
    public static readonly string Cinq = "V";

    public static string Nombre(int nombre)
    {
        if (nombre == 1)
            return Unite;
        if (nombre == 2)
            return Unite + Unite;
        else if (nombre == 3)
            return Unite + Unite + Unite;
        else if (nombre == 4)
            return Unite + Cinq;
        else if (nombre == 5)
            return Cinq;
        else
            throw new NotImplementedException();
    }
}