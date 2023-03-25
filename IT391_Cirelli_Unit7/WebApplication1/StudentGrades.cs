using System;
using System.Collections;
using System.Xml;

namespace WebApplication1
{
    public class StudentGrades
    {
        private ArrayList GradeList;

        public int MaxGrade = 0;
        public int MinGrade = 0;
        public int AvgGrade = 0;

        public StudentGrades()
        {
            GradeList = new ArrayList();
        }

        public StudentGrades(string gradefileName)
        {
            GradeList = new ArrayList();
            ReadGradeDataFromXML(gradefileName);
            AvgGrade = CalculateAverage();
            MaxGrade = CalculateMax();
            MinGrade = CalculateMin();
         }

        private void addGrade(int aGrade)
        {
            GradeList.Add(aGrade);
        }
        private int CalculateMin()
        {
            GradeList.Sort();
            int min = (int)GradeList[0];
            return min;
        }
        private int CalculateMax()
        {
            GradeList.Sort();
            int max = (int)GradeList[GradeList.Count - 1];
            return max;
        }
        private int CalculateAverage()
        {
            int avg = 0;
            int sum = 0;
            foreach (int grade in GradeList)
            {
                sum = sum + grade;
            }
            avg = sum / GradeList.Count;
            return avg;
        }
        private void ReadGradeDataFromXML(string gradefileName)
        {
            XmlTextReader reader = new XmlTextReader(gradefileName);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        System.Diagnostics.Debug.Write("<" + reader.Name);
                        System.Diagnostics.Debug.Write(">");
                        break;
                    case XmlNodeType.Text:
                        System.Diagnostics.Debug.Write(reader.Value);
                        int val = Convert.ToInt32(reader.Value);
                        addGrade(val);
                        break;
                    case XmlNodeType.EndElement:
                        System.Diagnostics.Debug.Write("</" + reader.Name);
                        System.Diagnostics.Debug.Write(">");
                        break;
                }
            }
        }
    }
}