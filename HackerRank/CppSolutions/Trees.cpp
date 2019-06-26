#include "pch.h"
#include "Trees.h"
#include <cstddef>

namespace TreesNameSpace
{
	bool Trees::isBSTUtil(struct Node* root, Node*& prev)
	{
		// traverse the tree in inorder fashion and  
		// keep track of prev node 
		if (root)
		{
			if (!isBSTUtil(root->left, prev))
				return false;

			// Allows only distinct valued nodes
			if (prev != NULL && root->data <= prev->data)
				return false;

			prev = root;

			return isBSTUtil(root->right, prev);
		}

		return true;
	}

	bool Trees::isBST(Node* root)
	{
		Node* prev = NULL;
		return isBSTUtil(root, prev);
	}

	void Trees::traverseInorder(struct Node* node, int& current, int& max)
	{
		if (node == NULL)
			return;

		current++;
		if (current > max)
			max = current;

		// first recur on left child
		traverseInorder(node->left, current, max);

		// now recur on right child
		traverseInorder(node->right, current, max);

		current--;
	}

	int Trees::getHeight(Node* root)
	{
		int maxHeight = 0;
		int currentHeight = -1; // minus 1 because the first entry is to root which is zero

		// Write your code here.
		traverseInorder(root, currentHeight, maxHeight);
		return maxHeight;
	}
}
