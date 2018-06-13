using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenNet
{
    public class OrderRange
    {

        public TwoArrays Build(int[] Cadena)
        {
            List<int> Pares = new List<int>();
            List<int> Impares = new List<int>();

            for (int i = 0; i < Cadena.Count(); i++)
            {

                if ((Cadena[i] % 2) == 0)
                    Pares.Add(Cadena[i]);
                else
                    Impares.Add(Cadena[i]);
            }

            int[] ParesOrder = orderBy(Pares.ToArray());

            int[] ImparesOrder = orderBy(Pares.ToArray());
            return new TwoArrays { X = ParesOrder, Y = ImparesOrder };


        }


        private int[] orderBy(int[] arr)
        {

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            return arr; ;

        }
        public class TwoArrays
        {
            public int[] X { get; set; }
            public int[] Y { get; set; }
        }


    }
}
