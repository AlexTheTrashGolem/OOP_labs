#ifndef MYSTRING_H
#define MYSTRING_H

#include <string>
#include <cstring>
using namespace std;

class MyString {
private:
    char* value;
public:
    explicit MyString(char* MyString);
    int getLength();
    char* getMyString();
};

#endif
