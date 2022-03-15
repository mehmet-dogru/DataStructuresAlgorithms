using System;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Array.CreateInstance(typeof(int), 4);
            arr.SetValue(23, 0);
            arr.SetValue(44, 1);
            arr.SetValue(61, 2);
            arr.SetValue(55, 3);

        }
    }
}
