/*
 * EnumerableString.cs
 *
 * Copyright (c) 2022 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using System.Collections.Generic;
using System.Linq;

namespace StringUtility
{
    public class EnumerableString<T> : IEnumerable<string>
    {
        protected static void init()
        {
            typeof(T)
                .GetFields()
                .Where(f => f.GetValue(null) == null)
                .ToList()
                .ForEach(f => f.SetValue(null, f.Name));
        }

        public IEnumerator<string> GetEnumerator()
        {
            return typeof(T)
                .GetFields()
                .Select(f => f.GetValue(null))
                .Cast<string>()
                .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return typeof(T)
                .GetFields()
                .Select(f => f.GetValue(null))
                .GetEnumerator();
        }
    }
}
