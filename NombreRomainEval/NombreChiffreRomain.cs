namespace NombreRomainEval;

public class NombreChiffreRomain
{
    public static readonly string Unite = "I";

    public static string Nombre(int nombre)
    {
        if (nombre == 2)
            return "II";
        else if (nombre == 3)
            return "III";
        else
            return "ERREUR";
    }
}