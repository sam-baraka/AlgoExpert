using System;
using System.Collections.Generic;

public class DepthFirstProgram {
	// Do not edit the class below except
	// for the DepthFirstSearch method.
	// Feel free to add new properties
	// and methods to the class.

    public static void DMain(string[] args)
    {
        Node node = new Node("A");
        node.children = new List<Node>();
        node.children.Add(new Node("B"));
        node.children.Add(new Node("C"));
        node.children.Add(new Node("D"));
        node.children[0].children = new List<Node>();
        node.children[0].children.Add(new Node("E"));
        node.children[0].children.Add(new Node("F"));
        node.children[2].children = new List<Node>();
        node.children[2].children.Add(new Node("G"));
        node.children[2].children.Add(new Node("H"));
        node.children[2].children.Add(new Node("I"));
        node.children[0].children[1].children = new List<Node>();
        node.children[0].children[1].children.Add(new Node("J"));
        node.children[0].children[1].children.Add(new Node("K"));
        node.children[2].children[2].children = new List<Node>();
        node.children[2].children[2].children.Add(new Node("L"));
        node.children[2].children[2].children.Add(new Node("M"));
        List<string> result = node.DepthFirstSearch(new List<string>());
        foreach (string a in result)
        {
            Console.WriteLine(a + " ");
        }

    }

    
	public class Node {
		public string name;
		public List<Node> children = new List<Node>();

		public Node(string name) {
			this.name = name;
		}

		public List<string> DepthFirstSearch(List<string> array) {
            array.Add(name);
            foreach(Node child in this.children){
                child.DepthFirstSearch(array);
            }
			
			return array;
		}

		public Node AddChild(string name) {
			Node child = new Node(name);
			children.Add(child);
			return this;
		}
	}
}
