namespace NombreRomainEval;

public class NombreChiffreRomain
{
    public static readonly string Unite = "I";
    public static readonly string Cinq = "V";

    public static string Nombre(int nombre)
    {
        return nombre switch
        {
            1 => Unite,
            2 => Unite + Unite,
            3 => Unite + Unite + Unite,
            4 => Unite + Cinq,
            5 => Cinq,
            _ => throw new NotImplementedException(),
        };
    }
}