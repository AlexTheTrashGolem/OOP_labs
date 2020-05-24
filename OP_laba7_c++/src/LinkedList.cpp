#include "LinkedList.h"
#include <iostream>

LinkedList::LinkedList() {
	_head = nullptr;
	_size = 0;
}

void LinkedList::Push(char data) {
	_head = new Node(data, _head);
	_size++;
}

LinkedList::Node::Node(char data, Node* pNext = nullptr) {
	this->data = data;
	this->pNext = pNext;
}

int LinkedList::Size() {
	return _size;
}

char& LinkedList::operator[](const int index) {
	int counter = 0;
	Node* current = this->_head;
	while (current != nullptr) {
		if (counter == index)
			return current->data;
		current = current->pNext;
		counter++;
	}
}

int LinkedList::FirstExclamation()
{
    for (int i = 0; i < this->_size; i++)
    {
        if (this->operator[](i) == '!')
        {
            return i;
        }
    }
    return -1;
}

void LinkedList::RemoveA() {
	Node* current = this->_head;
	int counter = 0;
	while (current != nullptr) {
		if (current->data == 'a') {
			current = current->pNext;
			RemoveAt(counter);
			continue;
		}
		counter++;
		current = current->pNext;
	}
}

void LinkedList::RemoveAt(int index) {
	if (index == 0)
		this->PopFront();
	else {
		Node* previous = this->_head;
		for (int i = 0; i < index - 1; i++)
			previous = previous->pNext;
		Node* temp = previous->pNext;
		previous->pNext = temp->pNext;
		delete temp;
		_size--;
	}
}

void LinkedList::PopFront() {
	Node* temp = this->_head;
	_head = _head->pNext;
	delete temp;
	_size--;
}

void LinkedList::Print() {
	std::cout << "Your list: ";
	for (int i = 0; i < this->_size; i++) {
		std::cout << this->operator[](i);
		if (i == this->_size- 1)
			std::cout << "\n";
		else
			std::cout << "->";
	}
}
