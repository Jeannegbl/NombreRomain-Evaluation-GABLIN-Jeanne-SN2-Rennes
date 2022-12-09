namespace NombreRomainEval;

public class NombreChiffreRomain
{
    public static readonly string Unite = "I";
    public static readonly string Cinq = "V";
    public static readonly string Dix = "X";
    public static readonly string Cinquante = "L";

    public static string Nombre(int nombre)
    {
        var resultat_romain = "";
        if (nombre >= 40 && nombre < 50)
        {
            nombre = nombre - 40;
            resultat_romain = resultat_romain + Dix + Cinquante;
        }
        while (nombre >= 50)
        {
            nombre = nombre - 50;
            resultat_romain = resultat_romain + Cinquante;
        }
        while (nombre >= 10)
        {
            nombre = nombre - 10;
            resultat_romain = resultat_romain + Dix;
        }
        if (nombre == 9)
        {
            nombre = nombre - 9;
            resultat_romain = resultat_romain + Unite + Dix;
        }
        if (nombre == 4)
        {
            nombre = nombre - 4;
            resultat_romain = resultat_romain + Unite + Cinq;
        }
        while (nombre >= 5)
        {
            nombre = nombre - 5;
            resultat_romain = resultat_romain + Cinq;
        }
        for (int i = 0; i < nombre; i++)
        {
            resultat_romain = resultat_romain + Unite;
        }
        return resultat_romain;
    }
}