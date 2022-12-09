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
    }
}