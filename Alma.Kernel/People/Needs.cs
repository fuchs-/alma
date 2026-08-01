using System.Collections;
using Alma.Kernel.Utils;

namespace Alma.Kernel.People;

internal class Needs : IEnumerable<Need>
{
    public Need Tension { get; } = new Need(50);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerator<Need> GetEnumerator() { yield return Tension; }

    public void Tick(RNG rng)
    {
        foreach (var need in this)
            need.Increase(rng.Generate(10));
    }
}
