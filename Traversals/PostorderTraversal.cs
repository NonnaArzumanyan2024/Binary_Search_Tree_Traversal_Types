using BinarySearchTreeTraversals.Models;

namespace BinarySearchTreeTraversals.Traversals;

public static class PostorderTraversal
{
    public static void Traverse(TreeNode? node, List<int> result)
    {
        if (node == null)
            return;

        Traverse(node.Left, result);
        Traverse(node.Right, result);

        result.Add(node.Value);
    }
}