public class ProgramBranchSum {
	// This is the class of the input root. Do not edit it.
static void BMain(string[] args){
		BinaryTree root = new BinaryTree(1);
		root.left = new BinaryTree(2);
		root.right = new BinaryTree(3);
		root.left.left = new BinaryTree(4);
		root.left.right = new BinaryTree(5);
		root.right.left = new BinaryTree(6);
		root.right.right = new BinaryTree(7);
		root.left.left.left = new BinaryTree(8);
		root.left.left.right = new BinaryTree(9);
		root.left.right.left = new BinaryTree(10);
		var sums = BranchSums(root);
		int[] finalSums = new int[sums.Count];
		foreach (var sum in sums) {
finalSums[sums.IndexOf(sum)] = sum;
		}
		Console.WriteLine(finalSums);
}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			this.left = null;
			this.right = null;
		}
	}

	public static List<int> BranchSums(BinaryTree root) {
		
		List<int> sums = new List<int>();
		BranchSums(root, 0, sums);
		return sums;
	}

	public static void BranchSums(BinaryTree root, int sum, List<int> sums) {
		if (root == null) return;
		int newSum = sum + root.value;
		if (root.left == null && root.right == null) {
			sums.Add(newSum);
			return;
		}
		BranchSums(root.left, newSum, sums);
		BranchSums(root.right, newSum, sums);
	}
}