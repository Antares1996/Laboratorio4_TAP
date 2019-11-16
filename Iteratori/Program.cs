using System;

namespace Iteratore
{
    class iteratori
    {

        static T[] MacroExpansion<T>(T[] sequenze, T value, T[] newvalues)
        {
            if (sequenze == null)
                throw new ArgumentNullException(nameof(sequenze));
            if(newvalues == null)
                throw new ArgumentNullException(nameof(newvalues));

            return sequenze;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
