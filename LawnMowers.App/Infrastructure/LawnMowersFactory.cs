using System.Collections.Generic;

namespace LawnMowers.App.Infrastructure
{
    public class LawnMowersFactory : ILawnMowersFactory
    {
        public IEnumerable<ILawnMower> CreateLawnMowers(InputData inputdata)
        {
            ILawn lawn = new Lawn(inputdata.LawnWidth, inputdata.LawnHeight);

            var mower = new List<ILawnMower>();
            foreach (var mowerData in inputdata.MowerData)
            {
                IPosition position = new Position(lawn, mowerData.StartCoordinates);
                ILawnMower lawnMower = new LawnMower(position, mowerData.Instructions);
                mower.Add(lawnMower);
            }

            return mower;
        }
    }
}