public class SinglyLinkedlist {
    private Node head;
    private int totalElements;
    
    public SinglyLinkedlist() {
        this.head = null;
        this.totalElements = 0;
        System.out.println("\nSingly Linkedlist successfully created.");
    }

    private boolean isEmpty() {
        if (this.head == null) {
            return true;
        } else {
            return false;
        }
    }

    private void printDS() {
        if (isEmpty()) {
            System.out.println("\tHEAD -> (EMPTY) -> NULL");
        } else {
            Node currentNode = this.head;
            System.out.print("\tHEAD");
            while (currentNode != null) {
                System.out.print(" -> " + currentNode.getData());
                currentNode = currentNode.getNext();
            }
            System.out.println("NULL");
        }
    }

    public void printDSStats() {
        System.out.println("Singly Linkedlist DS Stats...");
        printDS();
        System.out.println("\t\ttotal elements: " + this.totalElements);
    }
}