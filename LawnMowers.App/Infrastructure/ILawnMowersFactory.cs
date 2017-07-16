using System.Collections.Generic;

namespace LawnMowers.App.Infrastructure
{
    public interface ILawnMowersFactory
    {
        IEnumerable<ILawnMower> CreateLawnMowers(InputData inputData);
    }
}