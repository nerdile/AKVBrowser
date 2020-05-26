using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecretsGui.AKV
{
    public static class Converter<T>
    {
        public static async Task<List<T>> ToListAsync(IAsyncEnumerable<T> iae)
        {
            var retval = new List<T>();
            await foreach (var x in iae)
            {
                retval.Add(x);
            }
            return retval;
        }
    }
}