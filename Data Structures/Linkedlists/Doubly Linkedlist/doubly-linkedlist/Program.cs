public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Doubly Linkedlist - C#");
        Console.WriteLine("----------------------");

        DoublyLinkedlist doublyLinkedlist = new DoublyLinkedlist();
        doublyLinkedlist.PrintDSStats();

        doublyLinkedlist.InsertHead(2);
        doublyLinkedlist.InsertHead(11);
        doublyLinkedlist.InsertHead(-7);
        doublyLinkedlist.InsertHead(556);

        doublyLinkedlist.RemoveHead();
        doublyLinkedlist.RemoveHead();
        doublyLinkedlist.RemoveHead();
        doublyLinkedlist.RemoveHead();
        doublyLinkedlist.RemoveHead(); // Removal error expected on empty/null singly linkedlist.

        doublyLinkedlist.InsertTail(2);
        doublyLinkedlist.InsertTail(11);
    }
}