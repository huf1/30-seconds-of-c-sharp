﻿using System;
using System.Collections.Generic;

namespace conplement.snippets.Enumerable
{
    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Removes elements in an Enumerable until the passed function returns true. Returns the remaining elements in the Enumerable.
        /// </summary>
        public static IEnumerable<T> DropWhile<T>(this IEnumerable<T> list, Func<T, bool> filter)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            var reachedDropPoint = false;

            foreach (var element in list)
            {
                if (!reachedDropPoint && !filter(element))
                {
                    continue;
                }

                reachedDropPoint = true;

                yield return element;
            }

            yield break;
        }
    }
}
