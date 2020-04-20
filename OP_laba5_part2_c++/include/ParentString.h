#ifndef PARENTSTRING_H
#define PARENTSTRING_H
#include <cctype>
#include <stdexcept>
#include <algorithm>

class ParentString {
protected:
    char *value;

public:
    int GetLength();
    char * GetValue();
    virtual void Sort();
    ParentString(char *);
};
#endif // PARENTSTRING_H
