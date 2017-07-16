using System.Collections.Generic;

namespace LawnMowers.App.Infrastructure
{
    public class InputData
    {
        public int LawnWidth { get; set; }

        public int LawnHeight { get; set; }

        public IList<MoverData> MoverData { get; set; }

        public InputData()
        {
            MoverData = new List<MoverData>();
        }
    }
}