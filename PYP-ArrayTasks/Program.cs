using System;
using System.Linq;

namespace PYP_ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            //Console.WriteLine(CheckRepeatItemArray(2, 4, 5, 6,6, 7, 8, 9));

            //Task-2
            //Console.WriteLine(CheckFindItem(10,3,5,7,4,5));

            //Task-3
            //PrintArray(0, 2, 4, 5, 6, 7, 8, 9);

            //Task-4
            //string[] result = ArrayItemsStratContains("sa", "salam", "merhaba", "saqol", "necesen", "salamat");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Task-5
            //int[] arr1 = { 1, 3, 5, 7, 8, 10 };
            //int[] arr2 = { 5, 7, 8, 9, 10 };
            //PrintTwoArrayElement(arr1, arr2);

            //Task-6
            //int[] arr1 = { 1, 2, 5, 7, 8, 10 };
            //int[] arr2 = { 5, 7, 8, 9, 10 };
            //DifferentNumberArray(arr1, arr2);
        }
        //1) bir dizi içerisinde bir eleman birden fazla olup olmadığını kontrol eden bir kod bloğu
        static bool CheckRepeatItemArray(params int[] arr) //4,3,3,2,5
        {
            return Array.Exists(arr, x => arr.Count(y => y == x) > 1);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i]==arr[j]&&i!=j)
            //        {
            //            return true;
            //        }
            //    }
            //}
        }
        //2) dizi içerisinde bir elemanın var olup olmadığını kontrol ediniz, bu değer bool tipinde olacak
        static bool CheckFindItem(int item, params int[] arr)
        {
            return Array.Exists(arr, x => x == item);
        }

        //3) içerisinde birden fazla eleman tanımladığınız dizi içerisindeki elemanları, for, foreach, while, do-while döngüsü kullanmadan ekrana yazdırınız
        static void PrintArray(int index,params int[] arr)
        {
            #region Array class method
            //if (arr.Length>0)
            //{
            //    Array.ForEach(arr, x => Console.WriteLine(x.ToString()));
            //}
            //else
            //{
            //    Console.WriteLine("array contains no elements");
            //}
            #endregion
            Console.WriteLine(arr[index]);
            if (index!=arr.Length-1)
            {
                index++;
                PrintArray(index, arr);
            }
            return;
        }
        //4) metinsel bir dizi içerisindeki değerlerde,verdiğiniz değer ile başlayan tüm elemanları ekrana yazdırınız.
        static string[] ArrayItemsStratContains(string word,params string[] arr)
        {
            #region Custom
            //int i = 0;
            //int j = 0;
            //string[] result = new string[0];
            //foreach (var item in arr)
            //{
            //    while (i< word.Length)
            //    {
            //        if (item[i] != word[j])
            //        {
            //            break;
            //        }
            //        j++;
            //        i++;
            //        if (i==word.Length)
            //        {
            //            Array.Resize(ref result, result.Length+1);
            //            result[result.Length-1] = item;
            //            j = 0;
            //            i = 0;
            //            break;
            //        }
            //    }

            //}
            #endregion
            string[] result = Array.FindAll(arr,x=>x.StartsWith(word));
            return result;
        }
        //var olan 2 dizinin elemanlarını ekrana yazdırınız.
        static void PrintTwoArrayElement(int[] arr1,int[]arr2)
        {
            PrintArray(0, arr1);
            PrintArray(0, arr2);
        }
        //6) sayısal 2 dizi içerisinde yer alan farklı elemanları yeni bir diziye, aynı olanları yeni bir diziye ekleyiniz.
        static void DifferentNumberArray(int[] arr1, int[] arr2)   
        {
            int[] sameArr = Array.FindAll(arr1, x => Array.Exists(arr2, y => x == y));

            int[] differentArr = Array.FindAll(arr1, x => !Array.Exists(arr2, y => x == y));
            foreach (var item in sameArr)
            {
                Console.WriteLine(item);
            }
            foreach (var item in differentArr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
