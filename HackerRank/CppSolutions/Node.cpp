#include <cstddef>

namespace TreesNameSpace
{
	struct Node
	{
		int data;
		struct Node* left, * right;

		Node(int data)
		{
			this->data = data;
			left = right = NULL;
		}
	};
}
