using BinarySearchTreeTraversals;
using BinarySearchTreeTraversals.Traversals;

BinarySearchTree tree = new();

tree.Insert(5);
tree.Insert(10);
tree.Insert(3);
tree.Insert(7);
tree.Insert(2);
tree.Insert(4);
tree.Insert(6);
tree.Insert(8);
tree.Insert(1);
tree.Insert(9);



List<int> inorderResult = new();
InorderTraversal.Traverse(tree.Root, inorderResult);

List<int> preorderResult = new();
PreorderTraversal.Traverse(tree.Root, preorderResult);

List<int> postorderResult = new();
PostorderTraversal.Traverse(tree.Root, postorderResult);

List<int> levelOrderResult = new();
LevelOrderTraversal.Traverse(tree.Root, levelOrderResult);

Console.WriteLine($"Inorder: {string.Join(", ", inorderResult)}");
Console.WriteLine($"Preorder: {string.Join(", ", preorderResult)}");
Console.WriteLine($"Postorder: {string.Join(", ", postorderResult)}");
Console.WriteLine($"Level Order: {string.Join(", ", levelOrderResult)}");