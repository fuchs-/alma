using System.Collections;
using Alma.Kernel.Utils;

namespace Alma.Kernel.People;

internal partial class Needs : IEnumerable<Need>
{
    public Need Tension { get; } = new Need(50);
    public IEnumerator<Need> GetEnumerator() { yield return Tension; }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Tick(RNG rng)
    {
        foreach (var need in this)
            need.Increase(rng.Generate(10));
    }
}
