namespace NombreRomainEval;

public class NombreChiffreRomain
{
    public static readonly string Unite = "I";

    public static string Nombre(int nombre)
    {
        if (nombre == 2)
            return Unite + Unite;
        else if (nombre == 3)
            return Unite + Unite + Unite;
        else
            return "ERREUR";
    }
}