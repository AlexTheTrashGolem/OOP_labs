#include "ParentString.h"

int ParentString::GetLength()
{
    return sizeof(this->value);
}

char *ParentString::GetValue()
{
    return this->value;
}

ParentString::ParentString(char *value)
{
    this->value = value;
}

void ParentString::Sort(){}
