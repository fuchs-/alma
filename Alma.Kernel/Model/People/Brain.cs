namespace Alma.Kernel.Model.People;

internal class Brain(Person owner)
{
    private readonly Person _owner = owner;

    // Fun Fact: 
    // for approximately 15 minutes
    // the world almost had GPU, TPU and CPU
    //
    // PlanProcessingUnit was going to be TaskProcessingUnit
    // and ActionProcessingUnit was going to be aCtionProcessingUnit...
    //
    // but .net had other *plans* for the word Task...
    private readonly GoalProcessingUnit _gpu = new();
    private readonly PlanProcessingUnit _ppu = new();
    private readonly ActionProcessingUnit _apu = new();
}
