using System.Collections.Generic;

namespace LawnMowers.App.Infrastructure
{
    public class InputData
    {
        public int LawnWidth { get; set; }

        public int LawnHeight { get; set; }

        public IList<MoverData> MowerData { get; set; }

        public InputData()
        {
            MowerData = new List<MoverData>();
        }
    }
}