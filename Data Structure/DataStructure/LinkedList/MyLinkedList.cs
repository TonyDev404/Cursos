namespace LinkedList;

public class MyLinkedList
{
    public Node? First { get; set; }

    public void InsertFirst(int data)
    {
        //Create a new node
        Node newNode = new Node();
        //Put the data in the new node
        newNode.Data = data;
        //Put the old node in next of the new node
        newNode.Next = First;
        //Make first the new node
        First = newNode;
    }

    public Node DeleteFirst()
    {
        //Assign the temporary variable
        Node temp = First;
        //Assign the next head
        First = First.Next;
        return temp;
    }

    public void DisplayList()
    {
        Console.WriteLine("Iterating thru list...");
        Node current = First;

        while (current != null)
        {
            current.DisplayNode();
            current = current.Next;
        }
    }

    public void InsertLast(int data)
    {
        Node current = First;

        while (current.Next != null)
        {
            current = current.Next;
        }

        Node newNode = new Node();
        newNode.Data = data;
        current.Next = newNode;
    }
}