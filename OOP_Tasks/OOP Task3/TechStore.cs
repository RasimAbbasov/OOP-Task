using System.Threading.Channels;

namespace OOP_Task3
{
    internal class TechStore
    {
        public string Name;
        public NoteBook[] noteBooks;
        int notebookCount;
        public TechStore(string name, int size)
        {
            Name = name;
            noteBooks = new NoteBook[size];
            notebookCount = 0;
        }
        public void AddMethod(NoteBook noteBook)
        {
            if (notebookCount >= noteBooks.Length)
                Console.WriteLine("Bos yer yoxdur");
            noteBooks[notebookCount] = noteBook;
            notebookCount++;
            
        }
        public NoteBook Find(string name)
        {
            for (int i = 0; i < notebookCount; i++)
            {
                if (noteBooks[i].Name.Equals(name,StringComparison.OrdinalIgnoreCase))
                {
                    return noteBooks[i];
                }
            }
            return null;

        }
    }
}
