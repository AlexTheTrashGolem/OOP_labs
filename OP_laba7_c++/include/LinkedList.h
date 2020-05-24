#ifndef LINKEDLIST_H
#define LINKEDLIST_H


class LinkedList
{
public:
	LinkedList();
	void Push(char);
	int Size();
	char& operator[](const int index);
	void RemoveAt(int);
	void PopFront();
	void Print();
	void RemoveA();
	int FirstExclamation();
private:
	class Node {
	public:
		Node* pNext;
		char data;
		Node(char, Node*);
	};
	Node *_head;
	int _size;
};
#endif // LINKEDLIST_H
