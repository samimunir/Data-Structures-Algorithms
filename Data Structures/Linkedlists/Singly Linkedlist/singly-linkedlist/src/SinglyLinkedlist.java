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
            System.out.println(" -> NULL");
        }
    }

    public void printDSStats() {
        System.out.println("Singly Linkedlist DS Stats...");
        printDS();
        System.out.println("\t\ttotal elements: " + this.totalElements);
    }

    public void insertHead(int data) {
        System.out.println("\ninsertHead(" + data + ") called --->");
        if (isEmpty()) {
            Node newNode = new Node(data, null);
            this.head = newNode;
            this.totalElements++;
        } else {
            Node newNode = new Node(data, this.head);
            this.head = newNode;
            this.totalElements++;
        }
        printDSStats();
    }

    public void removeHead() {
        if (isEmpty()) {
            System.out.println("\n--<ERROR>-- removeHead() called on empty singly linkedlist.");
            printDSStats();
        } else {
            System.out.println("\nremoveHead(" + this.head.getData() + ") called --->");
            this.head = this.head.getNext();
            this.totalElements--;
            printDSStats();
        }
    }

    public void insertTail(int data) {
        System.out.println("\ninsertTail(" + data + ") called --->");
        if (isEmpty()) {
            Node newNode = new Node(data, null);
            this.head = newNode;
            this.totalElements++;
        } else {
            if (this.head.getNext() == null) {
                Node newNode = new Node(data, null);
                Node tempHead = this.head;
                tempHead.setNext(newNode);
                this.head = tempHead;
                this.totalElements++;
            } else {
                Node tempHead = this.head;
                Node currentNode = tempHead;
                while (currentNode != null) {
                    if (currentNode.getNext() == null) {
                        break;
                    }
                    currentNode = currentNode.getNext();
                }
                Node newNode = new Node(data, null);
                currentNode.setNext(newNode);
                this.head = tempHead;
                this.totalElements++;
            }
        }
        printDSStats();
    }

    public void removeTail() {
        if (isEmpty()) {
            System.out.println("\n--<ERROR>-- removeTail() called on empty singly linkedlist.");
            printDSStats();
        } else {
            if (this.head.getNext() == null) {
                System.out.println("\nremoveTail(" + this.head.getData() + ") called...");
                this.head = null;
                this.totalElements--;
            } else {
                Node tempHead = this.head;
                Node currentNode = tempHead;
                while (currentNode != null) {
                    if (currentNode.getNext().getNext() == null) {
                        break;
                    }
                    currentNode = currentNode.getNext();
                }
                System.out.println("\nremoveTail(" + currentNode.getNext().getData() + ") called...");
                currentNode.setNext(null);
                this.head = tempHead;
                this.totalElements--;
            }
            printDSStats();
        }
    }
}