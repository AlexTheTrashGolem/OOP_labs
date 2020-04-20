#include "UpperCaseLetters.h"


UpperCaseLetters::UpperCaseLetters(char *value) : ParentString(value) {
    int length = sizeof(value);
    int upper = 0;
    for (int i = 0; i < length; ++i) {
        if(std::isupper(value[i])) {
            upper++;
        }
    }
    if (!(length == upper))
    {
        throw std::runtime_error("String should only contain uppercase letters!");
    }
}

void UpperCaseLetters::Sort()
{
    std::sort(value, value+sizeof(value));

}
