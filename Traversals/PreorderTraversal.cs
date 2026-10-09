using BinarySearchTreeTraversals.Models;

namespace BinarySearchTreeTraversals.Traversals;

public static class PreorderTraversal
{
    public static void Traverse(TreeNode? node, List<int> result)
    {
        if (node == null)
            return;

        result.Add(node.Value);

        Traverse(node.Left, result);
        Traverse(node.Right, result);
    }
}