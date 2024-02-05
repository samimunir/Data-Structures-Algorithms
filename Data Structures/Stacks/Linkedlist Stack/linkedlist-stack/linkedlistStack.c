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
            printf("   %d\n", currentNode -> data);
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
    } else {
        struct Node *newNode = (struct Node*) malloc(sizeof(struct Node));
        newNode -> data = data;
        if (head -> next == NULL) {
            newNode -> next = NULL;
            newNode -> prev = head;
            head -> next = newNode;
            tail = tail -> next;
            totalElements++;
        } else {
            newNode -> next = NULL;
            newNode -> prev = tail;
            tail -> next = newNode;
            tail = tail -> next;
            totalElements++;
        }
    }
    printDSStats();
}

int main(int argc, char* argv[]) {
    printf("\nLinkedlist Stack - C\n");
    printf("--------------------\n");

    printDSStats();

    push(2);
    push(11);
    push(-7);
    push(556);

    return EXIT_SUCCESS;
}