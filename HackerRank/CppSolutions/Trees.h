#pragma once
#include "Node.cpp"

namespace TreesNameSpace
{
	class Trees
	{
	public:
		static bool isBST(Node* root);
		static int getHeight(Node* root);

	private:
		static bool isBSTUtil(struct Node* root, Node*& prev);
		static void traverseInorder(struct Node* node, int& current, int& max);
	};
}
