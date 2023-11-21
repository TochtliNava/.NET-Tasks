using System;

namespace homework._Task2
{
    public class Lesson : ICloneable
    {
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public object Clone()
        {
            Lesson lesson = new Lesson();
            lesson.Description = Description;
            return lesson;
        }
    }
}
