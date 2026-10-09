using BinarySearchTreeTraversals.Models;

namespace BinarySearchTreeTraversals.Traversals;

public static class InorderTraversal
{
    public static void Traverse(TreeNode? node, List<int> result)
    {
        if (node == null)
            return;

        Traverse(node.Left, result);

        result.Add(node.Value);

        Traverse(node.Right, result);
    }
}