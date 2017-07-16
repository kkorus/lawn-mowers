using System.Collections.Generic;

namespace LawnMowers.App.Infrastructure
{
    public interface IMoversFactory
    {
        IEnumerable<IMover> CreateMovers(InputData inputData);
    }
}