using System;
using System.Text;
using System.Threading.Tasks;

namespace homework._Task2
{
    internal class LectureLesson : Lesson
    {
        private string _description { get; }

        public LectureLesson(string description)
        {
            _description = description;
        }
    }
}
