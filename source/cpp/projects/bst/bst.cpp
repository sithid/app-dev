#include <iostream>

struct Node {
    int data;
    Node *left, *right;

    Node(int data) {
        this->data = data;
        left = right = NULL;
    }
};

class BST {
public:
    Node *root;

    BST() {
        root = NULL;
    }

    void insert(int data) {
        root = insertRec(root, data);
    }

    Node* insertRec(Node* root, int data) {
        if (root == NULL) {
            return new Node(data);
        }

        if (data < root->data) {
            root->left = insertRec(root->left, data);
        } else if (data > root->data) {
            root->right = insertRec(root->right, data);
        }

        return root;
    }

    void inorderTraversal(Node* root) {
        if (root != NULL) {
            inorderTraversal(root->left);
            std::cout << root->data << " ";
            inorderTraversal(root->right);
        }
    }
};

int main() {
    BST bst;
    bst.insert(50);
    bst.insert(30);
    bst.insert(70);
    bst.insert(20);
    bst.insert(40);
    bst.insert(60);
    bst.insert(80);

    bst.inorderTraversal(bst.root);

    return 0;
}