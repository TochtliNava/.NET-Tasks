namespace homework._Task2
{
    public class Training
    {
        private string _description;
        private Lesson[] _resources = new Lesson[0];

        public Training(string description)
        {
            _description = description;
        }

        public void Add(Lesson lesson)
        {
            int resourcesSize = _resources.Length + 1;
            Lesson[] tempResources = new Lesson[resourcesSize];
            for (int index = 0; index < _resources.Length; index++)
            {
                tempResources[index] = _resources[index];
            }
            tempResources[resourcesSize - 1] = lesson;
            _resources = tempResources;
        }

        public bool IsPractical()
        {
            foreach (var resource in _resources) 
            {
                if (!(resource is PracticalLesson))
                {
                    return false;
                }
            }
            return true;
        }

        public Training Clone()
        {
            Training clone = (Training) this.MemberwiseClone();
            clone._description = string.Copy(_description);
            clone._resources = (Lesson[]) _resources.Clone();
            return clone;
        }
    }
}
