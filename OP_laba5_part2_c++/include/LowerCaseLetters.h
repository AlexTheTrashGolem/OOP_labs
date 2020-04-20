#ifndef LOWERCASELETTERS_H
#define LOWERCASELETTERS_H

#include <ParentString.h>


class LowerCaseLetters : public ParentString
{
    public:
        LowerCaseLetters(char* value);
        void Sort() override;

};

#endif // LOWERCASELETTERS_H
