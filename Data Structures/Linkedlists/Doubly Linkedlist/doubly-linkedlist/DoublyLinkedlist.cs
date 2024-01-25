public class DoublyLinkedlist {
    private Node head;
    private Node tail;
    private int totalElements;

    public DoublyLinkedlist() {
        this.head = null;
        this.tail = null;
        this.totalElements = 0;
        Console.WriteLine("\nDoubly linkedlist successfully created.");
    }

    private Boolean IsEmpty() {
        if (this.head == null) {
            return true;
        } else {
            return false;
        }
    }

    private void PrintDS() {
        if (IsEmpty()) {
            Console.WriteLine("\tHEAD <-> (EMPTY) <-> NULL");
        } else {
            Node currentNode = this.head;
            Console.Write("\tHEAD");
            while (currentNode != null) {
                Console.Write(" <-> " + currentNode.GetData());
                currentNode = currentNode.GetNext();
            }
            Console.WriteLine(" <-> NULL");
        }
    }

    public void PrintDSStats() {
        Console.WriteLine("Doubly Linkedlist DS Stats...");
        PrintDS();
        Console.WriteLine("\t\ttotalElements: " + this.totalElements);
    }
}