namespace NombreRomainEval;

public class NombreChiffreRomain
{
    public static readonly string Unite = "I";

    public static string Nombre(int nombre)
    {
        if (nombre == 2)
            return "II";
        else
            return "ERREUR";
    }
}