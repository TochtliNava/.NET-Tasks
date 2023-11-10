﻿using homework.Task_2;
using System;
using System.Text;
using System.Threading.Tasks;

namespace homework._Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Task 2.1
   
            //  Test if someone tries to set mass to a negative value
            Point point1 = new Point(1, 3, 4, -4);
            double mass = point1.GetMass();
            bool isZero = point1.IsZero();

            //  Test if someone set all coordinates to 0
            Point point2 = new Point(0, 0, 0, 3);
            isZero = point2.IsZero();
            mass = point2.GetMass();

            //  Test CalculateDistance()
            double distance = point2.CalculateDistance(point1);

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

            int[] diagonal = {};
            int[] diagonal1 = { 1, 2, 3, 0, 3, 1 };

            DiagonalMatrix matrix = new DiagonalMatrix(diagonal);
            DiagonalMatrix matrix1 = new DiagonalMatrix(diagonal1);

            Console.Write(matrix1.ToString());

            //  Extension Method
            matrix.SumDiagonals(matrix1);
        }
    }
}