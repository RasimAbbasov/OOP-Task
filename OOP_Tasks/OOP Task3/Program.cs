namespace OOP_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {TechStore store1= new TechStore("AzTech",10);

         NoteBook notebook1= new NoteBook("Asus TUF",2400,512);
         NoteBook notebook2 = new NoteBook("Lenovo Legion", 2200, 1);
         NoteBook notebook3 = new NoteBook("MSI Katana", 3000, 512);

         store1.AddMethod(notebook1);
            store1.AddMethod(notebook2);
                store1.AddMethod(notebook3);

            NoteBook NoteBook = store1.Find("Lenovo Legion");
            if (NoteBook != null)
            {
                Console.WriteLine($"NoteBook:{NoteBook.Name}  Price:{NoteBook.Price} Storage:{NoteBook.Storage}");
            }
            else
            {
                Console.WriteLine("NoteBook movcud deyil");
            }
        }
    }
}
