using System;

namespace PuebaSummit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var entrada = "";
            bool isNumeric = false;
            var sumatoria = 0;
            int vocales = 0;
            int consonantes = 0;

            char j;
            Console.WriteLine("Ingrese su usuario");
            entrada = Console.ReadLine();
            
            try
            {
                int.Parse(entrada);
                isNumeric = true;
            }
            catch (Exception ex)
            {
                isNumeric = false;
            }

            if (isNumeric)
            {
                char[] menor = entrada.ToCharArray();
                foreach (var item in menor)
                {
                   
                    int valor = Convert.ToInt32(item.ToString());
                    sumatoria += valor;
                }
                Array.Sort(menor);
                Console.WriteLine($"La sumatoria es: {sumatoria}");
                Console.WriteLine($"Su orden acendente es {menor}");
            }
            else
            {
                char[] charArray = entrada.ToCharArray();
                string reverse = String.Empty;
            
               
                int item;

                for (int i = charArray.Length -1; i>=0; i--)
                {
                    reverse += charArray[i];
                }
                for(item=0;item<entrada.Length; item++)
                {

                    j=entrada[item];

                    int c = char.ToLower(j);
                    if((c == 'a') | (c == 'e') | (c == 'i') | (c == 'o') | (c == 'u'))
                    {
                        vocales++;
                    }
                    else
                    {
                        consonantes++;
                    }
                }
                Console.WriteLine($"En la frase hay {vocales} vocales y {consonantes} consonantes ");
                Console.WriteLine($" {reverse}");

            }
        }
    }
}
