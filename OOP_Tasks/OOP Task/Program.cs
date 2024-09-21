namespace OOP_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fullname, BirthDate, GroupNo, Point xüsusiyyətlərinə və ShowInfo metoduna sahib Student class yaradırsınız.
            //FullName və Point dəyəri təyin olunmamış student obyekti yaradıla bilməz.
            Student student1 = new Student("Yusif",86);
            student1.BirthDate = "12.07.2005";
            student1.GroupNo = 305;
            student1.ShowInfo();
        }
    }
}
