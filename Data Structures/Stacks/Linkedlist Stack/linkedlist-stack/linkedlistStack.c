#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

struct Node {
    int data;
    struct Node *next;
    struct Node *prev;
} *head = NULL, *tail = NULL;

int totalElements = 0;

bool isEmpty() {
    if (head == NULL) {
        return true;
    } else {
        return false;
    }
}

void printDS() {
    if (isEmpty()) {
        printf("  EMPTY\n");
        printf("---------\n");
        printf("  STACK\n");
    } else {
        struct Node *currentNode = tail;
        while (currentNode != NULL) {
            printf("\t%d\n", currentNode -> data);
            currentNode = currentNode -> prev;
        }
        printf("---------\n");
        printf("  STACK\n");
    }
}

void printDSStats() {
    printDS();
    printf("\ttotalElements: %d\n", totalElements);
}

void push(int data) {
    printf("\npush(%d) called -->\n", data);
    if (isEmpty()) {
        struct Node *newNode = (struct Node*) malloc(sizeof(struct Node));
        newNode -> data = data;
        newNode -> next = NULL;
        newNode -> prev = NULL;
        head = newNode;
        tail = newNode;
        totalElements++;
    }
    printDSStats();
}

int main(int argc, char* argv[]) {
    printf("\nLinkedlist Stack - C\n");
    printf("--------------------\n");

    printDSStats();

    return EXIT_SUCCESS;
}