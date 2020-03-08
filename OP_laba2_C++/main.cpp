#include <iostream>
#include <algorithm>
#include <cstring>
#include<vector>
using namespace std;

class MyString
{
public:
    char* Value;
    int _length;

    MyString(char* str)
    {
        this->Value = str;
    }
    char GetChar(int index)
    {
        return Value[index];
    }

    int GetLength()
    {
        return strlen(Value);
    }
};

class Text
{
public:

    vector<MyString> Value;

    void Add_String(MyString myString)
    {
        Value.push_back(myString);
    }

    void Remove_String(int index)
    {
        Value.erase(Value.begin() + index);
    }

    void ReplaseString(int index, MyString myString)
    {
        Value[index] = myString;
    }

    void EraseText()
    {
        Value.erase(Value.begin(), Value.end());
    }

    int GetLength()
    {
        return Value.size();
    }

    string ReturnNumbersOnly()
    {
        string numbers = "";
        for (int j = 0; j < Value.size(); j++)
        {
            for (int i = 0; i < Value[j].GetLength(); i++)
            {
                if(isdigit(Value[j].GetChar(i)))
                {
                    numbers += Value[j].GetChar(i);
                }
            }
        }

        return numbers;

    }
};

int main()
{
    MyString str = MyString({"a1b1c1"});

    Text text = Text();

    text.Add_String(str);

    cout << text.ReturnNumbersOnly();
}
