#include <stdio.h>
#include <stdlib.h>

struct TreeNode {
    int data;
    struct TreeNode *left;
    struct TreeNode *right;
};

struct TreeNode* createNode(int data) {
    struct TreeNode *newNode = (struct TreeNode*) malloc(sizeof(struct TreeNode));
    if (newNode == NULL) {
        printf("\n--<ERROR>-- Memory allocation failure!\n");
        exit(1);
    }
    newNode -> data = data;
    newNode -> left = NULL;
    newNode -> right = NULL;
    return newNode;
}

struct TreeNode* insert(struct TreeNode *root, int data) {
    if (root == NULL) {
        return createNode(data);
    }
    if (data < root -> data) {
        root -> left = insert(root -> left, data);
    } else if (data > root -> data) {
        root -> right = insert(root -> right, data);
    }
    return root;
}

void inorderTraversal(struct TreeNode *root) {
    if (root != NULL) {
        inorderTraversal(root -> left);
        printf("%d ", root -> data);
        inorderTraversal(root -> right);
    }
}

struct TreeNode* findMin(struct TreeNode *node) {
    struct TreeNode *current = node;
    while (current && current -> left != NULL) {
        current = current -> left;
    }
    return current;
}

struct TreeNode* deleteNode(struct TreeNode *root, int key) {
    if (root == NULL) {
        return root;
    }
    if (key < root -> data) {
        root -> left = deleteNode(root -> left, key);
    } else if (key > root -> data) {
        root -> right = deleteNode(root -> right, key);
    } else {
        if (root -> left == NULL) {
            struct TreeNode *temp = root -> right;
            free(root);
            return temp;
        } else if (root -> right == NULL) {
            struct TreeNode *temp = root -> left;
            free(root);
            return temp;
        }
        struct TreeNode *temp = findMin(root -> right);
        root -> data = temp -> data;
        root -> right = deleteNode(root -> right, temp -> data);
    }
    return root;
}

int main(int argc, char* argv[]) {
    printf("Binary Tree - C\n");
    printf("---------------\n");

    struct TreeNode *root = NULL;

    root = insert(root, 50);
    root = insert(root, 30);
    root = insert(root, 20);
    root = insert(root, 40);
    root = insert(root, 70);
    root = insert(root, 60);
    root = insert(root, 80);

    printf("Inorder traversal of the binary tree --> ");
    inorderTraversal(root);
    printf("\n");

    return EXIT_SUCCESS;
}