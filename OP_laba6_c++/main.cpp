#include <iostream>
#include "Expression.h"
using namespace std;

int main()
{
    Expression array [3] = {
        Expression(92, 0, 24),
        Expression(4, 0, 24),
        Expression(-1, 0, 24)
        };

    for (int i=0; i<=2; i++)
    {
    try
    {
        double result = array[i].Calculate();
        cout << "Result: " << result << endl;
    }
    catch (const char* e)
    {
        cout << e << endl;
    }

    }

}
