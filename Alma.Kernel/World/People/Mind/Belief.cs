namespace Alma.Kernel.World.People.Mind;

internal class Belief(bool yes)
    : BeliefBase(yes)
{
    public bool Yes => (bool)_value;
    public bool No => !Yes;
}
