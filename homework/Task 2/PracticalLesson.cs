namespace homework._Task2
{
    public class PracticalLesson : Lesson
    {
        private string _linkTask;
        private string _linkSolution;

        public PracticalLesson(string description, string linkTask, string linkSolution)
        {
            Description = description;
            _linkTask = linkTask;
            _linkSolution = linkSolution;
        }
    }
}
