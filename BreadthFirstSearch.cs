using System;
using System.Collections.Generic;

public class BreadthFirstProgram {
	// Do not edit the class below except
	// for the BreadthFirstSearch method.
	// Feel free to add new properties
	// and methods to the class.
	public class Node {

        public static void Main(string[] args)
        {

        }
		public string name;
		public List<Node> children = new List<Node>();

		public Node(string name) {
			this.name = name;
		}

		public List<string> BreadthFirstSearch(List<string> array) {
			// Write your code here.
			List<Node> queue=new List<Node>{this};
			while(queue.Count>0)
			{
				Node currentNode=queue[0];
				queue.RemoveAt(0);
				array.Add(currentNode.name);
				foreach(Node child in currentNode.children){
					queue.Add(child);
				}

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
