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

int main(int argc, char* argv[]) {
    printf("Binary Tree - C\n");
    printf("---------------\n");

    return EXIT_SUCCESS;
}