#include <iostream>
#include "LinkedList.h"

using namespace std;

int main()
{
	LinkedList list = LinkedList();
	list.Push('i');
	list.Push('!');
	list.Push('a');
	list.Print();
	cout << list.FirstExclamation()<< endl;
	list.RemoveA();
	list.Print();
	cout << list.FirstExclamation()<< endl;
}
