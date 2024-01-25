public class Node {
    private int data;
    private Node next;
    private Node prev;

    public Node(int data) {
        this.data = data;
        this.next = null;
        this.prev = null;
    }

    public Node(int data, Node next) {
        this.data = data;
        this.next = next;
        this.prev = null;
    }

    public Node(int data, Node next, Node prev) {
        this.data = data;
        this.next = next;
        this.prev = prev;
    }

    public void SetData(int data) {
        this.data = data;
    }

    public int GetData() {
        return this.data;
    }

    public void SetNext(Node next) {
        this.next = next;
    }

    public Node GetNext() {
        return this.next;
    }

    public void SetPrev(Node prev) {
        this.prev = prev;
    }

    public Node GetPrev() {
        return this.prev;
    }

    override public string ToString() {
        return "data: " + this.data + "\nnext.data: " + this.next.data + "\nprev.data: " + this.prev.data;
    }
}