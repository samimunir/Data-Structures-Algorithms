public class SinglyLinkedlist {
    private Node head;
    private int totalElements;
    
    public SinglyLinkedlist() {
        this.head = null;
        this.totalElements = 0;
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
            System.out.println("HEAD -> (EMPTY) -> NULL");
        } else {
            Node currentNode = this.head;
            System.out.print("HEAD");
            while (currentNode != null) {
                System.out.print(" -> " + currentNode.getData());
                currentNode = currentNode.getNext();
            }
            System.out.println("NULL");
        }
    }

    private void printDSStats() {
        System.out.println("Singly Linkedlist");
        printDS();
        System.out.println("total elements: " + this.totalElements);
    }
}