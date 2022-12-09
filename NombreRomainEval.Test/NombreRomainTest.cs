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
        [Fact]
        public void Nombre2()
        {
            // ETANT DONNEE le nombre 2
            const int nombre = 2;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre I
            var attendu = "II";

            Assert.Equal(attendu, resultat);
        }
    }
}