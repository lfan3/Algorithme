using System;

public class Node
{
	public int key;
	public Node left;
	public Node right;
	
	public Node(int item)
	{
		key = item;
		left = right = null;
	}
}
	
public class BinaryTree
{
	public Node root;
		
	public BinaryTree()
	{
		root = null;
	}
	
	void printInorder(Node node)
	{
		if(node == null)
			return;
		printInorder(node.left);
		Console.Write(node.key + " ");
		printInorder(node.right);
	}
	
	public void printInorder()
	{
		printInorder(root);
	}
}

public class TestDFSTree
{
	public static void Main(String [] args)
	{
		BinaryTree tree = new BinaryTree();
		tree.root = new Node(1);
		tree.root.left = new Node(2);
		tree.root.right = new Node(3); 
        tree.root.left.left = new Node(4); 
        tree.root.left.right = new Node(5); 
		tree.printInorder();
	}
}
