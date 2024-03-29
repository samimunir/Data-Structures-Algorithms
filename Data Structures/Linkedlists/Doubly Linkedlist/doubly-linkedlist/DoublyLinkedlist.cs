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

    public void InsertHead(int data) {
        Console.WriteLine("\nInsertHead(" + data + ") called --->");
        if (IsEmpty()) {
            Node newNode = new Node(data);
            this.head = newNode;
            this.tail = newNode;
            this.totalElements++;
        } else {
            if (this.head.GetNext() == null) {
                Node newNode = new Node(data);
                this.head.SetPrev(newNode);
                newNode.SetNext(this.head);
                this.head = this.head.GetPrev();
                this.tail = this.tail.GetNext();
                this.totalElements++;
            } else {
                Node newNode = new Node(data);
                this.head.SetPrev(newNode);
                newNode.SetNext(this.head);
                this.head = this.head.GetPrev();
                this.totalElements++;
            }
        }
        PrintDSStats();
    }

    public void RemoveHead() {
        if (IsEmpty()) {
            Console.WriteLine("\n--<ERROR>-- removeHead() called on empty doubly linkedlist.");
        } else {
            Console.WriteLine("\nremoveHead(" + this.head.GetData() + ") called --->");
            if (this.head.GetNext() == null) {
                this.head = null;
                this.tail = null;
                this.totalElements = 0;
            } else {
                this.head = this.head.GetNext();
                this.head.SetPrev(null);
                this.totalElements--;
            }
        }
        PrintDSStats();
    }

    public void InsertTail(int data) {
        Console.WriteLine("\ninsertTail(" + data + ") called --->");
        if (IsEmpty()) {
            Node newNode = new Node(data);
            this.head = newNode;
            this.tail = newNode;
            this.totalElements++;
        } else {
            if (this.head.GetNext() == null) {
                Node newNode = new Node(data);
                newNode.SetPrev(this.head);
                this.head.SetNext(newNode);
                this.tail = this.tail.GetNext();
                this.totalElements++;
            } else {
                Node newNode = new Node(data);
                newNode.SetPrev(this.tail);
                this.tail.SetNext(newNode);
                this.tail = this.tail.GetNext();
                this.totalElements++;
            }
        }
        PrintDSStats();
    }

    public void RemoveTail() {
        if (IsEmpty()) {
            Console.WriteLine("\n--<ERROR>-- removeTail() called on empty doubly linkedlist.");
        } else {
            Console.WriteLine("\nremoveTail(" + this.tail.GetData() + ") called --->");
            if (this.head.GetNext() == null) {
                this.head = null;
                this.tail = null;
                this.totalElements = 0;
            } else {
                this.tail = this.tail.GetPrev();
                this.tail.SetNext(null);
                this.totalElements--;
            }
        }
        PrintDSStats();
    }

    public void PrintDSReverse() {
        Console.WriteLine("\nPrintDSReverse() called --->");
        if (IsEmpty()) {
            Console.WriteLine("\tNULL <-> (EMPTY) <-> HEAD");
        } else {
            Node currentNode = this.tail;
            Console.Write("\tNULL");
            while (currentNode != null) {
                Console.Write(" <-> " + currentNode.GetData());
                currentNode = currentNode.GetPrev();
            }
            Console.WriteLine(" <-> HEAD");
        }
    }
}