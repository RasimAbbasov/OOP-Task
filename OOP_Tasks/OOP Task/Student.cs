using System.Threading.Channels;

namespace OOP_Task
{
    internal class Student
    {
        public string Fullname;
        public string BirthDate;
        public int GroupNo;
        public double Point;
        public Student(string fullname, double point)
        {
            if (fullname == null)

                Console.WriteLine("Tam ad bos ola bilmez");

            if (point < 0 || point > 100)

                Console.WriteLine("Bali duzgun daxil edin");
            Fullname = fullname;
            Point=point;    
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Fullname:{Fullname} BirthDate:{BirthDate} GroupNo:{GroupNo} Point:{Point}");
        }
        
    }
}
