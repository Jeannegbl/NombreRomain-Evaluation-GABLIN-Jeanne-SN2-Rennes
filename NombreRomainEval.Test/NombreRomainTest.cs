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
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]
        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        [InlineData(23)]
        [InlineData(25)]
        [InlineData(26)]
        [InlineData(27)]
        public void Nombres(int n)
        {
            // ETANT DONNER un nombre <n> compris entre 1 et 27 sans 4, 9, 14, 19 et 24

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

            // ALORS on obtient son nombre romain comprit entre I et XXVII sans IV, IX, XIV, XIX et XXIV
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
        [Fact]
        public void Nombre14()
        {
            // ETANT DONNEE le nombre 14
            const int nombre = 14;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre XIV
            var attendu = "XIV";

            Assert.Equal(attendu, resultat);
        }
        [Fact]
        public void Nombre19()
        {
            // ETANT DONNEE le nombre 19
            const int nombre = 19;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre XIX
            var attendu = "XIX";

            Assert.Equal(attendu, resultat);
        }
        [Fact]
        public void Nombre24()
        {
            // ETANT DONNEE le nombre 24
            const int nombre = 24;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre XXIV
            var attendu = "XXIV";

            Assert.Equal(attendu, resultat);
        }
    }
}