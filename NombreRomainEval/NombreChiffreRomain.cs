namespace NombreRomainEval;

public class NombreChiffreRomain
{
    public static readonly string Unite = "I";
    public static readonly string Cinq = "V";
    public static readonly string Dix = "X";

    public static string Nombre(int nombre)
    {
        return nombre switch
        {
            
            4 => Unite + Cinq,
            9 => Unite + Dix,
            <= 13 => NombreBoucle(nombre),
            _ => throw new NotImplementedException(),
        };
    }

    public static string NombreBoucle(int nombre)
    {
        var resultat_romain = "";
        if (nombre >= 10)
        {
            nombre = nombre - 10;
            resultat_romain = "X";
        }
        if (nombre >= 5)
        {
            nombre = nombre - 5;
            resultat_romain = "V";
        }
        for (int i = 0; i < nombre; i++)
        {
            resultat_romain = resultat_romain + Unite;
        }
        return resultat_romain;
    }
}