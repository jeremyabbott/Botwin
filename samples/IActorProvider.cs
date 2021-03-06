namespace Botwin.Samples
{
    using System.Collections.Generic;

    public interface IActorProvider
    {
        IEnumerable<Actor> Get();
        Actor Get(int id);
    }
}