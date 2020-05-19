#include <iostream>

using namespace std;

void SortByAscending(int* ls, int length) {

    for (int i = 0; i < length; i++)
    {
        for (int j = i; j < length; j++)
        {
            if (ls[i] > ls[j])
            {
                char temp = ls[i];
                ls[i] = ls[j];
                ls[j] = temp;
            }
        }
    }
}


void PrintArray (int arg[], int length)
{
  for (int n=0; n<length; ++n)
    cout << arg[n] << ' ';
  cout << '\n';
}

int main()
{
    int arr [5]= {3, 44, 67, 32, 23};
    PrintArray(arr, 5);

    void (*funcPtr[2]) (int*, int) = { SortByAscending, PrintArray };
    for (int i = 0; i < 2; i++)
    {
        funcPtr[i](arr, 5);
    }
     return 0;
}






