# Binary Search Tree Traversal Types in C#

This project is a small educational C# console application that demonstrates the main traversal techniques used with a **Binary Search Tree (BST)**.
The project includes four common tree traversal algorithms:
- Inorder Traversal
- Preorder Traversal
- Postorder Traversal
- Level Order Traversal

# 1. What Is a Tree?

A **tree** is a non-linear data structure that stores data in a hierarchical form.
Unlike arrays or linked lists, where elements are usually organized one after another, a tree organizes elements using parent-child relationships.
A tree consists of objects called **nodes**.

Example:
          A
        /   \
       B     C
      / \   / \
     D   E F   G

In this example:
- `A` is the root of the tree.
- `B` and `C` are children of `A`.
- `A` is the parent of `B` and `C`.
- `D` and `E` are children of `B`.
- `F` and `G` are children of `C`.
- `D`, `E`, `F`, and `G` are leaf nodes because they do not have children.

Trees are widely used in computer science.
Some common examples include:
- file systems;
- databases;
- search algorithms;
- syntax trees;
- decision trees;
- organization structures;
- HTML DOM;
- routing systems.


# 2. Important Tree Terminology

Before learning tree traversal, it is useful to understand several important terms.

## Node

A **node** is an element of a tree.

A node can contain:
- a value;
- a reference to another node;
- references to its children.

For example: 50
can represent one node containing the value `50`.


## Root

The **root** is the first and highest node of a tree.

For example:
       50
      /  \
    30    70

Here: 50  is the root.
A tree normally has only one root.

## Parent

A node that has another node below it is called a **parent**.

Example:
       50
      /
    30

`50` is the parent of `30`.


## Child

A node directly connected below another node is called a **child**.
In the previous example: `30` is a child of `50`.


## Sibling

Nodes that have the same parent are called **siblings**.

Example:
       50
      /  \
    30    70

`30` and `70` are siblings.


## Leaf Node

A node without children is called a **leaf node**.

Example:
       50
      /  \
    30    70

If `30` and `70` have no children, both are leaf nodes.

## Subtree

Any node together with all of its descendants forms a **subtree**.

For example:
       50
      /  \
    30    70
   / \
 20  40

The node `30` together with `20` and `40` forms a subtree.


## Height

The **height** of a tree is related to the longest path from the root to a leaf.
Tree height is important because it affects the performance of many Binary Search Tree operations.


# 3. What Is a Binary Tree?

A **Binary Tree** is a tree where every node can have at most two children.

These children are called:
- left child;
- right child.

For example:
          50
        /    \
      30      70
     /  \    /  \
   20   40  60   80

Every node has zero, one, or two children.

For example: `50` has:
Left child  = 30
Right child = 70

A binary tree does not automatically define how values must be organized.

For example, this is still a valid binary tree:
          50
        /    \
      100     20

However, it is **not** a Binary Search Tree because it does not follow the Binary Search Tree ordering rules.


# 4. What Is a Binary Search Tree?

A **Binary Search Tree**, usually called a **BST**, is a special type of binary tree.

It follows an ordering rule.

For every node:
Values smaller than the node go to the left.
Values greater than the node go to the right.


In a simple BST with unique values, we can describe the rule as: Left < Root < Right

Example:
          50
        /    \
      30      70
     /  \    /  \
   20   40  60   80

Look at the root: 50

Values smaller than `50` are on the left:
20
30
40

Values greater than `50` are on the right:
60
70
80
```

The same rule must also be true for every subtree.

For node `30`: 20 < 30 < 40
For node `70`: 60 < 70 < 80

This ordering property makes Binary Search Trees useful for searching, inserting, and organizing values.


# 5. Binary Tree vs Binary Search Tree

A **Binary Tree** only has one main structural rule: > Each node can have at most two children.
A **Binary Search Tree** has the same structural rule, but it also has an ordering rule: Left values < Node value < Right values
Therefore: > Every Binary Search Tree is a Binary Tree.
But: > Not every Binary Tree is a Binary Search Tree.


# 6. Example Binary Search Tree Used in This Project

This project uses values such as: 50, 30, 70, 20, 40, 60, 80
When these values are inserted into a BST, the result is:

          50
        /    \
      30      70
     /  \    /  \
   20   40  60   80


Insertion happens by comparing the new value with the current node.

For example, to insert `40`: 40 < 50
Go left to `30`.
Then: 40 > 30
Go right. The right position is empty, so `40` is inserted there.


# 7. What Is Tree Traversal?

**Tree traversal** means visiting the nodes of a tree in a specific order.
Unlike an array, where we can simply move from index `0` to index `1`, `2`, `3`, and so on, a tree has multiple possible paths.
Becouse of this, we need rules that define the order in which nodes should be visited.

This project demonstrates four common traversal methods:
1. Inorder
2. Preorder
3. Postorder
4. Level Order

The first three are commonly implemented using **Depth-First Search (DFS)**.
Level Order traversal uses **Breadth-First Search (BFS)**.


# 8. Depth-First Search

Depth-First Search explores one branch of the tree deeply before moving to another branch.

The following traversals are DFS traversals:
- Inorder
- Preorder
- Postorder

These three traversals are commonly implemented using recursion.
The main difference between them is the moment when the current node is visited.


# 9. Inorder Traversal

## Order
Inorder traversal follows this order: Left → Root → Right

The algorithm performs these steps:
1. Traverse the left subtree.
2. Visit the current node.
3. Traverse the right subtree.

For this BST:

          50
        /    \
      30      70
     /  \    /  \
   20   40  60   80

Inorder traversal works like this:
20
30
40
50
60
70
80

Result: 20, 30, 40, 50, 60, 70, 80

## Important Property of Inorder Traversal
Inorder traversal has a very important property when it is used with a Binary Search Tree: > Inorder traversal of a BST returns the values in ascending sorted order.
This happens because a BST stores smaller values on the left and greater values on the right.
The traversal uses: Left → Root → Right
Therefore, smaller values are visited before larger values.
This property is specific to the ordering of a Binary Search Tree.


# 10. Preorder Traversal

## Order

Preorder traversal follows: Root → Left → Right

The current node is visited **before** its children.

Steps:
1. Visit the current node.
2. Traverse the left subtree.
3. Traverse the right subtree.

Using the same BST:
          50
        /    \
      30      70
     /  \    /  \
   20   40  60   80

The traversal starts from the root: 50

Then the left subtree:
30
20
40

Then the right subtree:
70
60
80

Result: 50, 30, 20, 40, 70, 60, 80

## When Is Preorder Useful?

Preorder traversal can be useful when:

- the parent must be processed before its children;
- copying or serializing some tree structures;
- representing hierarchical structures;
- processing directory-like structures from parent to child.

The important idea is: > Root is processed first.


# 11. Postorder Traversal

## Order

Postorder traversal follows: Left → Right → Root

The current node is visited **after** both of its children.

Steps:
1. Traverse the left subtree.
2. Traverse the right subtree.
3. Visit the current node.

For the example BST:

          50
        /    \
      30      70
     /  \    /  \
   20   40  60   80

First process the left subtree:
20
40
30

Then the right subtree:
60
80
70

Finally process the root: 50
Result: 20, 40, 30, 60, 80, 70, 50


## When Is Postorder Useful?

Postorder is useful when children must be processed before their parent.

Examples include:
- deleting tree structures;
- calculating information from child nodes before the parent;
- evaluating expression trees;
- processing directory contents before processing the directory itself.

The important idea is: > Root is processed last.


# 12. Level Order Traversal

Level Order traversal is different from the previous three traversals.
It visits nodes **level by level**, from top to bottom.
It uses **Breadth-First Search (BFS)**.

For this tree:
          50
        /    \
      30      70
     /  \    /  \
   20   40  60   80

The levels are:
Level 0: 50
Level 1: 30, 70
Level 2: 20, 40, 60, 80

Therefore the result is: 50, 30, 70, 20, 40, 60, 80


# 13. Why Does Level Order Use a Queue?

Level Order traversal usually uses a **Queue** data structure.
A queue follows the rule:FIFO
FIFO means: First In, First Out

The first element added to the queue is the first element removed.

For example:
Enqueue 50
Enqueue 30
Enqueue 70


The removal order will be:
50
30
70


This behavior is perfect for Level Order traversal because nodes must be processed in the same order in which they are discovered.

A simplified algorithm is:

1. Add the root to the queue.

2. While the queue is not empty:
   - Remove the first node.
   - Visit it.
   - Add its left child to the queue.
   - Add its right child to the queue.


# 14. DFS vs BFS

The four traversals can be divided into two groups.

## Depth-First Search

DFS explores deeply into a branch before moving to another branch.

The following traversals use DFS:
Inorder
Preorder
Postorder

They are commonly implemented using recursion or an explicit stack.

## Breadth-First Search

BFS explores the tree level by level.

Level Order traversal uses BFS.

It is usually implemented with a queue.


# 15. Recursive Tree Traversal

Inorder, Preorder, and Postorder are naturally implemented using recursion.

A recursive method is a method that calls itself.

A recursive tree traversal usually contains two important parts:

## Base Case

if (node == null)
    return;

This stops the recursion when there is no node.

Without a base case, recursion would not know when to stop.

## Recursive Calls

For example:
Traverse(node.Left);
Traverse(node.Right);

Each call works with a smaller subtree.
Eventually the traversal reaches a leaf node and then reaches `null`.
At this point, the recursive calls start returning.


# 16. Comparison of the Four Traversals

Using this BST:

          50
        /    \
      30      70
     /  \    /  \
   20   40  60   80

we get:

| Traversal   | Order Rule          | Result                       |
|-------------|---------------------|------------------------------|
| Inorder     | Left → Root → Right | `20, 30, 40, 50, 60, 70, 80` |
| Preorder    | Root → Left → Right | `50, 30, 20, 40, 70, 60, 80` |
| Postorder   | Left → Right → Root | `20, 40, 30, 60, 80, 70, 50` |
| Level Order | Level by Level      | `50, 30, 70, 20, 40, 60, 80` |

A simple way to remember the three DFS traversals is to look at the position of **Root**:
Preorder  → Root is first
Inorder   → Root is in the middle
Postorder → Root is last


# 17. Time Complexity

Let: n = number of nodes in the tree

Every traversal must visit every node exactly once.
Therefore: Time Complexity = O(n)

for all four traversal algorithms.

| Traversal   | Time Complexity |
|-------------|-----------------|
| Inorder     | O(n)            |
| Preorder    | O(n)            |
| Postorder   | O(n)            |
| Level Order | O(n)            |

For example, if a tree contains 1,000 nodes, a complete traversal must process all 1,000 nodes.
There is no way to completely traverse the tree without visiting the nodes.


# 18. Space Complexity of Recursive Traversals

For recursive DFS traversals, additional memory is used by the **call stack**.

These traversals are:
- Inorder
- Preorder
- Postorder

Their auxiliary space complexity is: O(h)
where: h = height of the tree

This happens because recursive calls stay in memory while the algorithm moves deeper into the tree.


# 19. Balanced Tree

Consider a balanced tree:

          50
        /    \
      30      70
     /  \    /  \
   20   40  60   80

The height is approximately: log n

Therefore the recursive stack space is approximately: O(log n) for a balanced tree.


# 20. Skewed Tree

A Binary Search Tree can become unbalanced.
For example, inserting: 10, 20, 30, 40, 50


can create:
10
  \
   20
     \
      30
        \
         40
           \
            50


This is called a **skewed tree**.

Its height is approximately: n

Therefore recursive traversal can require: O(n) stack space in the worst case.

So for recursive DFS traversals:
Balanced tree: O(log n)
Worst case:    O(n)
General form:  O(h)


# 21. Space Complexity of Level Order Traversal

Level Order traversal uses a queue.
It auxiliary space complexity is: O(w)
where: w = maximum width of the tree

The maximum width means the largest number of nodes that exist on the same level.

For example:
          50
        /    \
      30      70
     /  \    /  \
   20   40  60   80

The last level contains four nodes:  20, 40, 60, 80
At some point, several of these nodes may be stored in the queue together.
In the worst case, Level Order traversal may require: O(n) additional space.


# 22. Complexity Summary

| Traversal   | Algorithm Type | Time | Auxiliary Space |
|-------------|----------------|------|-----------------|
| Inorder     | DFS            | O(n) | O(h)            |
| Preorder    | DFS            | O(n) | O(h)            |
| Postorder   | DFS            | O(n) | O(h)            |
| Level Order | BFS            | O(n) | O(w)            |

Where:
n = number of nodes
h = height of the tree
w = maximum width of the tree

For a balanced Binary Search Tree: h ≈ log n
Therefore DFS space complexity is approximately: O(log n)
For a completely skewed tree: h ≈ n
Therefore DFS space complexity becomes: O(n)


# 23. Important Note About Result Storage

The complexities above describe **auxiliary space**, meaning the extra memory required by the traversal algorithm itself.
If the traversal also stores every visited value inside a result list such as: List<int> - then the result list itself requires: O(n) space because it stores all `n` values.
Therefore, when including the output collection, total memory usage can be `O(n)`.


# Conclusion

Tree traversal is a fundamental topic in Data Structures and Algorithms.
A Binary Search Tree organizes values using the rule: Left < Root < Right
Different traversal algorithms allow us to process the same tree in different orders.

**Inorder** 
visits: Left → Root → Right - and returns BST values in sorted ascending order.

**Preorder** 
visits: Root → Left → Right - and processes the parent before its children.

**Postorder** 
visits: Left → Right → Root - and processes children before their parent.

**Level Order**  
visits: Level by Level - using Breadth-First Search and a queue.


