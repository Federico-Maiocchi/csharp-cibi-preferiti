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
                "Ostriche"
            };

            //-La lunghezza della classifica
            int cibiPrefereritiLunghezza = cibiPreferiti.Length;
            Console.WriteLine(cibiPrefereritiLunghezza);

            //-La vostra classifica(dunque stampare l’intero array in ordine indicando la posizione in classifica)
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine(cibiPreferiti[i]);
            }

            //-Il vostro cibo top(prima posizione della classifica)
            Console.WriteLine(cibiPreferiti[0]);

            //-Il vostro cibo preferito ma non troppo(ultima posizione della classifica)
            Console.WriteLine(cibiPreferiti[4]);
        }
    }
}
