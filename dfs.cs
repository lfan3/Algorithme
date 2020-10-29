using System;

namespace Tree
{
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
	
	void printPreorder(Node root)
	{
		if(root == null)
			return;
		Console.Write(root.key + " ");
		printPreorder(root.left);
		printPreorder(root.right);
	}
	
	public void print(string orderType)
	{
		switch(orderType)
		{
			case "pre":
				printPreorder(root);
				break;
			case "in":
				printInorder(root);
				break;
			default:
				Console.Write("default");
				break;
		}
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
		
		Console.WriteLine("inorder:\n");
		tree.print("in");
		Console.WriteLine("\n");
		Console.WriteLine("preorder:\n");
		tree.print("pre");
	}
}
}
