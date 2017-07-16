using System.Collections.Generic;

namespace LawnMowers.App.Infrastructure
{
    public class MoversFactory : IMoversFactory
    {
        public IEnumerable<IMover> CreateMovers(InputData inputdata)
        {
            ILawn lawn = new Lawn(inputdata.LawnWidth, inputdata.LawnHeight);

            var movers = new List<IMover>();
            foreach (var moverData in inputdata.MoverData)
            {
                IPosition position = new Position(lawn, moverData.StartCoordinates);
                IMover mover = new Mover(position, moverData.Instructions);
                movers.Add(mover);
            }

            return movers;
        }
    }
}