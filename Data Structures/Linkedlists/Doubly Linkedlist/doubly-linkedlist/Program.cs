public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Doubly Linkedlist - C#");
        Console.WriteLine("----------------------");

        DoublyLinkedlist doublyLinkedlist = new DoublyLinkedlist();
        doublyLinkedlist.PrintDSStats();

        // testing function InsertHead(data)
        doublyLinkedlist.InsertHead(2);
        doublyLinkedlist.InsertHead(11);
        doublyLinkedlist.InsertHead(-7);
        doublyLinkedlist.InsertHead(556);
    }
}