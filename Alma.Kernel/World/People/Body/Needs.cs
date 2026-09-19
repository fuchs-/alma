using System.Collections;
using Alma.Kernel.Utils;

namespace Alma.Kernel.World.People.Body;

internal partial class Needs : IEnumerable<Need>
{
    public Need Tension { get; } = new Need("Tension", 50);
    public Need Social { get; } = new Need("Social", 50);

    public IEnumerator<Need> GetEnumerator()
    {
        yield return Tension;
        yield return Social;
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Tick(RNG rng)
    {
        foreach (var need in this)
            need.Increase(rng.Generate(10));
    }
}
