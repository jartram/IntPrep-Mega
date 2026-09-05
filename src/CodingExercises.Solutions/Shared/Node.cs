using System.Collections.Generic;

namespace CodingExercises.Solutions.Shared;

public class Node
{
    public int val;
    public int data { get => val; set => val = value; }
    public Node left;
    public Node right;
    public Node next;
    public IList<Node> children;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
