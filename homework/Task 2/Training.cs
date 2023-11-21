using System;

namespace homework._Task2
{
    public class Training : ICloneable
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

        public object Clone()
        {
            string description = _description;
            Training clone = new Training(description);
            for (int i = 0; i < _resources.Length; i++)
            {
                clone.Add(_resources[i]);
            }
            return clone;
        }
    }
}
