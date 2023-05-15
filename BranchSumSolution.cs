// // Solve the branch sum problem

// public class Program
// {
//     // Create the binary tree class

//     public class BinaryTree
//     {
//         public int value;
//         public BinaryTree left;
//         public BinaryTree right;

//         public BinaryTree(int value)
//         {
//             this.value = value;
//             left = null;
//             right = null;
//         }
//     }
//     public static int BranchSums(BinaryTree root)
//     {
//         int[] sums = new int[0];
//         calculateBranchSums(root, 0, sums);
//         return sums;

//     }
//     // Calculate the branch sums
//     public static void calculateBranchSums(BinaryTree node, int runningSum, int[] sums)
//     {
//         if (node == null) return;

//         int newRunningSum = runningSum + node.value;
//         if (node.left == null && node.right == null)
//         {
//             sums = append(sums, newRunningSum);
//         }
//         calculateBranchSums(node.left, newRunningSum, sums);
//         calculateBranchSums(node.right, newRunningSum, sums);

//     }

//     // Append the sums
//     public static int[] append(int[] sums, int value)
//     {
//         int[] newSums = new int[sums.Length + 1];
//         for (int i = 0; i < sums.Length; i++)
//         {
//             newSums[i] = sums[i];
//         }
//         newSums[newSums.Length - 1] = value;
//         return newSums;

//     }

// }
// // This code is contributed by divyesh072019.

