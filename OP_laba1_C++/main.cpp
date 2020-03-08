#include <iostream>
#include <string>

using namespace std;

int Addition(int, int);
int Increment(int);
void ArgIncrement(int, int&);
bool IsGreater(int, int);
void ArgIsGreater(int, int, bool&);


int main(int argc, const char * argv[]) {
    cout<<Increment(31)<<endl;
    cout<<Increment(56)<<endl;
    cout<<Increment(-25)<<endl;
    bool a, b, c;
    ArgIsGreater(44, 44, a);
    cout<<boolalpha<<a<<endl;
    ArgIsGreater(46, -7, b);
    cout<<boolalpha<<b<<endl;
    ArgIsGreater(15, 30, c);
    cout<<boolalpha<<c<<endl;
}

int Addition(int number1, int number2)
{
    while (number2 != 0)
    {
        int carry = number1 & number2;
        number1 ^= number2;
        number2 = carry << 1;
    }
    return number1;
}

int Increment(int number)
{
    return -~number;
}

void ArgIncrement(int number, int& result)
{
    result = -~number;
}

bool IsGreater(int number1, int number2)
{
    if (!(number1^number2))
    {
        return false;
    }
    int sign = Addition(number1, Addition(~number2, 1)) >> 31;
    return sign == 0;
}


void ArgIsGreater(int number1, int number2, bool& result)
{
    if (!(number1^number2))
    {
        result = false;
        return;
    }
    int sign = Addition(number1, Addition(~number2, 1)) >> 31;
    result = (bool)(sign == 0);
}
