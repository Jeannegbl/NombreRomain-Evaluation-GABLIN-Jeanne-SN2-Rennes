namespace NombreRomainEval.Test
{
    public class NombreRomainTest
    {
        public int nb;
        public string nombre;
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        public void Nombres(int n)
        {
            // ETANT DONNER un nombre <n> compris entre 1 et 13 sans 4 et 9

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(n);
            nb = n;
            while (nb >= 10)
            {
                nb = nb - 10;
                nombre = nombre + "X";
            }
            while (nb >= 5)
            {
                nb = nb - 5;
                nombre = nombre + "V";
            }

            while (nb >= 1)
            {
                nb = nb - 1;
                nombre = nombre + "I";
            }

            // ALORS on obtient son nombre romain comprit entre I et XIII sans IV et IX
            var attendu = nombre;

            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void Nombre4()
        {
            // ETANT DONNEE le nombre 4
            const int nombre = 4;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre IV
            var attendu = "IV";

            Assert.Equal(attendu, resultat);
        }
        [Fact]
        public void Nombre9()
        {
            // ETANT DONNEE le nombre 9
            const int nombre = 9;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre IX
            var attendu = "IX";

            Assert.Equal(attendu, resultat);
        }
    }
}