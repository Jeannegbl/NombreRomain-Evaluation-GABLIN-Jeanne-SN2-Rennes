namespace NombreRomainEval.Test
{
    public class NombreRomainTest
    {
        [Fact]
        public void Nombre1()
        {
            // ETANT DONNEE le nombre 1
            const int nombre = 1;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre I
            var attendu = "I";

            Assert.Equal(attendu, resultat);

        }
    }
}