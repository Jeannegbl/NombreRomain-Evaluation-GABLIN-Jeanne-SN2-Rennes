namespace NombreRomainEval;

public class NombreChiffreRomain
{
    public static readonly string Unite = "I";
    public static readonly string Cinq = "V";

    public static string Nombre(int nombre)
    {
        return nombre switch
        {
            <= 3 => NombreBoucle(nombre),
            4 => Unite + Cinq,
            5 => Cinq,
            _ => throw new NotImplementedException(),
        };
    }

    public static string NombreBoucle(int nombre)
    {
        var resultat_romain = "";
        for (int i = 0; i < nombre; i++)
        {
            resultat_romain = resultat_romain + Unite;
        }

        return resultat_romain;
    }
}