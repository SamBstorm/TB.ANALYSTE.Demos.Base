using System;

namespace TB.ANALYSTE.Demos.Base.Boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boucles sur valeurs numériques
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int x = 0;
            //while (x < 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            #endregion

            #region Boucles sur valeurs non-numériques
            //for (string valeur = ""; valeur != "OUI"; valeur = Console.ReadLine())
            //{
            //    Console.WriteLine("Veuillez écrire OUI :");
            //}

            //string condition = "";
            //while (condition != "OUI")
            //{
            //    Console.WriteLine("Veuillez écrire OUI :");
            //    condition = Console.ReadLine();
            //}
            #endregion

            int[] array = { 0, 1, 2, 3, 4 };
            int[] array2 = array;

            array2[1] = 5;

            foreach (int value in array)
            {
                //value = 2;    //IMPOSSIBLE de modifier
                Console.WriteLine(value);
            }
        }
    }
}
