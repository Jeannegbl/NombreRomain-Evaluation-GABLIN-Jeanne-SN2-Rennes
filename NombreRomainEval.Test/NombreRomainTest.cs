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

            // ALORS on obtient le nombre II
            var attendu = "II";

            Assert.Equal(attendu, resultat);
        }
        [Fact]
        public void Nombre3()
        {
            // ETANT DONNEE le nombre 3
            const int nombre = 3;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre III
            var attendu = "III";

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
        public void Nombre5()
        {
            // ETANT DONNEE le nombre 5
            const int nombre = 5;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre V
            var attendu = "V";

            Assert.Equal(attendu, resultat);
        }
        [Fact]
        public void Nombre6()
        {
            // ETANT DONNEE le nombre 6
            const int nombre = 6;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre VI
            var attendu = "VI";

            Assert.Equal(attendu, resultat);
        }
        [Fact]
        public void Nombre7()
        {
            // ETANT DONNEE le nombre 7
            const int nombre = 7;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre VII
            var attendu = "VII";

            Assert.Equal(attendu, resultat);
        }
        [Fact]
        public void Nombre8()
        {
            // ETANT DONNEE le nombre 8
            const int nombre = 8;

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(nombre);

            // ALORS on obtient le nombre VIII
            var attendu = "VIII";

            Assert.Equal(attendu, resultat);
        }
    }
}