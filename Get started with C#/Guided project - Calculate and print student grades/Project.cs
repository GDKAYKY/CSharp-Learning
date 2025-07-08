using System;

namespace StudentGrades
{
    class StudentGradesClass
    {
        public static void StudentGradesMethod(string[] args)
        {
            int currentAssignments = 5;

            int ana1 = 93;
            int ana2 = 87;
            int ana3 = 98;
            int ana4 = 95;
            int ana5 = 100;

            int paul1 = 80;
            int paul2 = 83;
            int paul3 = 82;
            int paul4 = 88;
            int paul5 = 85;

            int john1 = 84;
            int john2 = 96;
            int john3 = 73;
            int john4 = 85;
            int john5 = 79;

            int mark1 = 90;
            int mark2 = 92;
            int mark3 = 98;
            int mark4 = 100;
            int mark5 = 97;

            int anaSum = ana1 + ana2 + ana3 + ana4 + ana5;
            int paulSum = paul1 + paul2 + paul3 + paul4 + paul5;
            int johnSum = john1 + john2 + john3 + john4 + john5;
            int markSum = mark1 + mark2 + mark3 + mark4 + mark5;

            decimal anaScore = (decimal) anaSum / currentAssignments;
            decimal paulScore = (decimal) paulSum / currentAssignments;
            decimal johnScore = (decimal) johnSum / currentAssignments;
            decimal markScore = (decimal) markSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Ana:\t\t" + anaScore + "\tA");
            Console.WriteLine("Paul:\t\t" + paulScore + "\tB");
            Console.WriteLine("John:\t\t" + johnScore + "\tB");
            Console.WriteLine("Mark:\t\t" + markScore + "\tA");

        }
    }
}