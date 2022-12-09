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
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]
        [InlineData(19)]
        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        [InlineData(23)]
        [InlineData(24)]
        [InlineData(25)]
        [InlineData(26)]
        [InlineData(27)]
        [InlineData(28)]
        [InlineData(29)]
        [InlineData(30)]
        public void Nombres(int n)
        {
            // ETANT DONNER un nombre <n> compris entre 1 et 30

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(n);
            nb = n;
            while (nb >= 10)
            {
                nb = nb - 10;
                nombre = nombre + "X";
            }
            if (nb == 9)
            {
                nb = nb - 9;
                nombre = nombre + "IX";
            }
            if (nb == 4)
            {
                nb = nb - 4;
                nombre = nombre + "IV";
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

            // ALORS on obtient son nombre romain comprit entre I et XXX
            var attendu = nombre;

            Assert.Equal(attendu, resultat);
        }
        [Theory]
        [InlineData(31)]
        [InlineData(32)]
        [InlineData(33)]
        [InlineData(34)]
        [InlineData(35)]
        [InlineData(36)]
        [InlineData(37)]
        [InlineData(38)]
        [InlineData(39)]
        [InlineData(40)]
        [InlineData(41)]
        [InlineData(42)]
        [InlineData(43)]
        [InlineData(44)]
        [InlineData(45)]
        [InlineData(46)]
        [InlineData(47)]
        [InlineData(48)]
        [InlineData(49)]
        [InlineData(50)]
        public void NombresBonus(int n)
        {
            // ETANT DONNER un nombre <n> compris entre 31 et 50

            // QUAND on le convertit en nombres romains
            var resultat = NombreRomain.Convertir(n);
            nb = n;
            if (nb >= 40 && nb < 50)
            {
                nb = nb - 40;
                nombre = nombre + "XL";
            }
            while (nb >= 50)
            {
                nb = nb - 50;
                nombre = nombre + "L";
            }
            while (nb >= 10)
            {
                nb = nb - 10;
                nombre = nombre + "X";
            }
            if (nb == 9)
            {
                nb = nb - 9;
                nombre = nombre + "IX";
            }
            if (nb == 4)
            {
                nb = nb - 4;
                nombre = nombre + "IV";
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

            // ALORS on obtient son nombre romain comprit entre XXXI et L
            var attendu = nombre;

            Assert.Equal(attendu, resultat);
        }
    }
}