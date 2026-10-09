using BinarySearchTreeTraversals.Models;

namespace BinarySearchTreeTraversals.Traversals;

public static class LevelOrderTraversal
{
    public static void Traverse(TreeNode? root, List<int> result)
    {
        if (root == null)
            return;

        Queue<TreeNode> queue = new();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();

            result.Add(current.Value);

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}