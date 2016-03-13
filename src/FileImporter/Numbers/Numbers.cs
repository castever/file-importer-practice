using System.Collections.Generic;
using System.Collections.Immutable;

namespace FileImporter.Numbers
{
    /// <summary>
    /// Iterable list of numbers
    /// We should program to an interface.  It makes it more flexible.
    /// </summary>
    public interface Numbers : IEnumerable<int>
    {
        ImmutableList<int> GetNumbers();
    }
}
