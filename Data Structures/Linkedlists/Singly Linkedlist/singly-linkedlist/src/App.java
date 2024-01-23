public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Singly Linkedlist - Java");
        System.out.println("------------------------");
        
        SinglyLinkedlist singlyLinkedlist = new SinglyLinkedlist();
        singlyLinkedlist.printDSStats();

        singlyLinkedlist.insertHead(2);
        singlyLinkedlist.insertHead(11);
        singlyLinkedlist.insertHead(-7);
        singlyLinkedlist.insertHead(556);

        singlyLinkedlist.removeHead();
        singlyLinkedlist.removeHead();
        singlyLinkedlist.removeHead();
        singlyLinkedlist.removeHead();
        singlyLinkedlist.removeHead(); // Removal error expected on empty/null singly linkedlist.
    }
}
