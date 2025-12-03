namespace Adapter
{
    public class Road : IRoad
    {
        private string _roadType;

        public Road(string roadType)
        {
            _roadType = roadType;
        }

        public string GetRoadType()
        {
            return _roadType;
        }
    }
}

