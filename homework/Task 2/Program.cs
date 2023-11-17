using homework.Task_2;
using System;

namespace homework._Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Task 2.1
   
            //  Test if someone tries to set mass to a negative value
            Point point1 = new Point(1, 3, 4, -4);
            double mass = point1.Mass;
            bool isZero = point1.IsZero();

            //  Test if someone set all coordinates to 0
            Point point2 = new Point(0, 0, 0, 3);
            isZero = point2.IsZero();
            mass = point2.Mass;

            //  Test CalculateDistance()
            double distance = point2.CalculateDistance(point1);

            //  Task 2.2

            //  Create diagonals to test
            int[] diagonal = { 1, 1, 1, 1 };
            int[] diagonal1 = { 1, 2, 3 };
            int[] diagonal2 = { };

            //  Create matrixes
            DiagonalMatrix matrix = new DiagonalMatrix(diagonal);
            DiagonalMatrix matrix1 = new DiagonalMatrix(diagonal1);

            //  null parameters -> 0 size matrix
            DiagonalMatrix matrix2 = new DiagonalMatrix(diagonal2);

            // Override method
            Console.Write(matrix1.ToString());

            //  Check if they're equal
            bool isEqual = matrix.Equals(matrix1);

            //  Extension Method
            DiagonalMatrix sumMatrix = matrix.SumDiagonals(matrix1);
            Console.WriteLine(sumMatrix.ToString());

            //  Clone
            DiagonalMatrix nonClonedMatrix = new DiagonalMatrix(diagonal);
            DiagonalMatrix clonedMatrix = (DiagonalMatrix)nonClonedMatrix.Clone();
            clonedMatrix[2, 2] = 3;

            //  Task 2.3

            //  Create two training instances to check practical
            Training training = new Training("true");
            Training training2 = new Training("false");

            //  Create 2 lessons
            PracticalLesson lesson = new PracticalLesson(null, null, null);
            PracticalLesson lesson2 = new PracticalLesson(null, null, null);

            // Create a lecture lesson
            LectureLesson lecture = new LectureLesson("POO en México");
            
            // Add the two practical lessons to training 1
            training.Add(lesson);
            training.Add(lesson2);

            // Add one lecture lesson and one practical lesson
            training2.Add(lesson);
            training2.Add(lecture);

            //  Clone
            Training cloned = training.Clone();

            bool isPractical = training.IsPractical();  // true
            isPractical = training2.IsPractical();      // false
        }
    }
}
