namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //-Inizializzazione array cibi preferiti
            string[] cibiPreferiti = { 
                "Spaghetti con le cozze", 
                "Pizza", 
                "Sushi", 
                "Fegato alla veneziana",
                "Ostriche",
                "Spaghetti con le cozze",
                "Pizza",
                "Sushi",
                "Fegato alla veneziana",
                "Ostriche",
            };

            //-La lunghezza della classifica
            int cibiPrefereritiLunghezza = cibiPreferiti.Length;
            Console.WriteLine("Lunghezza array:" + " " + cibiPrefereritiLunghezza);

            //-La vostra classifica(dunque stampare l’intero array in ordine indicando la posizione in classifica)
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine("Lista cibi:" + " " + i + " - " + cibiPreferiti[i]);
            }

            //-Il vostro cibo top(prima posizione della classifica)
            Console.WriteLine("Cibo preferito primo posto:" + " " + cibiPreferiti[0]);

            //-Il vostro cibo preferito ma non troppo(ultima posizione della classifica)
            Console.WriteLine("Cibo preferito primo Ultimo:" + " " + cibiPreferiti[4]);

            //BONUS
            int elementoCentrale = cibiPrefereritiLunghezza / 2;
            //Console.WriteLine("Cibo preferito primo in mezzo (Bonus):" + " " + cibiPreferiti[elementoCentrale]);

            if (cibiPrefereritiLunghezza % 2 == 0)
            {

                Console.WriteLine("Primo elemento centrale (Pari)" + " " + cibiPreferiti[elementoCentrale - 1]);
                Console.WriteLine("Secondo elemento centrale (Pari)" + " " + cibiPreferiti[elementoCentrale]);
                
            } else
            {
                Console.WriteLine("Elemento di mezzo (Dispari)" + " " + cibiPreferiti[elementoCentrale]);
            }
        }
    }
}
