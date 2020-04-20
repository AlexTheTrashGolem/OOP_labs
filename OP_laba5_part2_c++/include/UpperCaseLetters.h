#ifndef UPPERCASELETTERS_H
#define UPPERCASELETTERS_H

#include <ParentString.h>


class UpperCaseLetters : public ParentString
{
    public:
        UpperCaseLetters(char* value);
        void Sort() override;
};

#endif // UPPERCASELETTERS_H
