namespace OOP_Task3
{
    internal class NoteBook:Product
    {
        public int Storage;
        public NoteBook(string name, double price, int storage) : base(name,price)
        {
            Storage = storage;
        }
    }
}
