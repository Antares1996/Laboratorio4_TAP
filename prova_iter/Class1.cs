using System;
using System.Collections.Generic;

namespace prova_iter
{
    public class iter
    {
        public static T[] MacroExpansion<T>(T[] sequenze, T value, T[] newvalues)
        {
            if (sequenze == null)
                throw new ArgumentNullException(nameof(sequenze));
            if (newvalues == null)
                throw new ArgumentNullException(nameof(newvalues));

            if (!Array.Exists(sequenze, elem => elem.Equals(value)))
                return sequenze;

            var newSeq = new List<T>();
            var seq_enumerator = sequenze.GetEnumerator();
            var newval_enumerator = newvalues.GetEnumerator();

            do
            {
                var current = seq_enumerator.Current;
                if (current.Equals(value)) 
                    AddNewValues(ref newSeq, newvalues);
                else
                    newSeq.Add((T)current);
            }
            while (seq_enumerator.MoveNext() && (seq_enumerator.Current != null));

            return newSeq.ToArray();
        }

        private static void AddNewValues<T>(ref List<T> l, T[] values)
        {
            var newval_enumerator = values.GetEnumerator();
            do
            {
                var current = newval_enumerator.Current;
                l.Add((T)current);

            } while (newval_enumerator.MoveNext() && (newval_enumerator.Current != null));
        }
    }
}
