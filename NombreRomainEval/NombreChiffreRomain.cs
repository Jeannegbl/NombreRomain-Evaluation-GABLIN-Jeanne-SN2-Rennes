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
            14 => Dix + Unite + Cinq,
            19 => Dix + Unite + Dix,
            <= 23 => NombreBoucle(nombre),
            _ => throw new NotImplementedException(),
        };
    }

    public static string NombreBoucle(int nombre)
    {
        var resultat_romain = "";
        while (nombre >= 10)
        {
            nombre = nombre - 10;
            resultat_romain = resultat_romain + "X";
        }
        while (nombre >= 5)
        {
            nombre = nombre - 5;
            resultat_romain = resultat_romain + "V";
        }
        for (int i = 0; i < nombre; i++)
        {
            resultat_romain = resultat_romain + Unite;
        }
        return resultat_romain;
    }
}