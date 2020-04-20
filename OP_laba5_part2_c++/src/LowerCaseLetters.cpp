#include "LowerCaseLetters.h"

LowerCaseLetters::LowerCaseLetters(char *value) : ParentString(value) {
    int length = sizeof(value);
    int lower = 0;
    for (int i = 0; i < length; ++i) {
        if(std::islower(value[i])) {
            lower++;
        }
    }
    if (!(length == lower))
    {
        throw std::runtime_error("String should only contain lowercase letters!");
    }
}

void LowerCaseLetters::Sort()
{
    std::sort(value, value+sizeof(value));
    std::reverse(value, value+sizeof(value));
}
