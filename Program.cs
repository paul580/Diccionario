using System;

using System.Linq;

using System.Collections.Generic;



namespace count_chars

{

    class Program

    {

        static void Main(string[] args)

        {

            //string data = "gwvuv syrbk sjrwf yspsm akpki yhznw wkpbt kpboq rjlpe nejku sxteo ihufz lgsiu jlypa lgqin ubave hjxav mgoeu gddnp mdicm dynxu pkcyf plubt aotmi ymbtr yczgi eacns oklwp buvve naymc wrbgv yjdif fjcgp xcyxs pnlcx fgrjt jvuzh pcvqq zhgwq keuyd cwdam weptg uidvz pfoug uvmaq wuzho utbln arsoj nnwid bjfeu mnqmp mziej phacb nymoz uqbzr fdzjp gmshg ckvjs jyeik xfgyp";

            string data = "asdfghjklkjhigasdsljiy rrrftyfrtyj";

            Dictionary<char, int> countByChar = new Dictionary<char, int>();



            foreach (var caracter in data)

            {

                //Saltearse espacios vacíos

                if (caracter == ' ')

                {

                    continue;

                }



                if (countByChar.ContainsKey(caracter))

                {

                    countByChar.TryGetValue(caracter, out int currentCount);



                    int nextCount = currentCount + 1;



                    countByChar.Remove(caracter);

                    countByChar.Add(caracter, nextCount);

                }

                else

                {

                    countByChar.Add(caracter, 1);

                }

            }





            char highestRepeatedChar = ' ';

            int highestRepeatedCount = 0;



            foreach (var item in countByChar)

            {



                //item es de tipo KeyValuePair<char, int>



                //item.Key es la llave

                //item.Value es el valor



                if (item.Value > highestRepeatedCount)

                {

                    highestRepeatedChar = item.Key;

                    highestRepeatedCount = item.Value;



                }

                System.Console.WriteLine($"{item.Key} -> {item.Value}");

            }



            char lessRepeatedChar = ' ';

            int lessRepeatedCount = countByChar.Count;

            foreach (var item2 in countByChar)

            {

                if (item2.Value < lessRepeatedCount)

                {

                    lessRepeatedChar = item2.Key;

                    lessRepeatedCount = item2.Value;

                }

                System.Console.WriteLine($"{item2.Key} -> {item2.Value}");

            }



            System.Console.WriteLine($"Highest Count: {highestRepeatedChar} -> {highestRepeatedCount}");

            System.Console.WriteLine($"Less Count: {lessRepeatedChar} -> {lessRepeatedCount}");



        }

    }

}