using System.Globalization;

namespace Task_table_3
{
    internal class Student
    {
        public string Name;
        public double Grade1, Grade2, Grade3;

        public double FinalGrade()
        {
            return Grade1 + Grade2 + Grade3;
        }

        public bool Approved()
        {
            if (FinalGrade() >= 60.0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double PointsLeft()
        {
            if (Approved())
            {
                return 0.0;
            } else
            {
                return 60.0 - FinalGrade();
            }
        }
    }
}
