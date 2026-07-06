namespace Alma.Kernel;

internal class Time
{
    private readonly List<ITemporalEntity> _entities = [];

    public void AddEntity(ITemporalEntity entity)
    {
        if (_entities.Contains(entity))
            throw new Exception($"Trying to add TemporalEntity {entity} but it's already on the list");
        
        _entities.Add(entity);
    }

    public void Tick()
    {
        foreach (var entity in _entities) 
            entity.Tick();
    }
}
