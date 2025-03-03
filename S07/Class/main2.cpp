#include<iostream>

using namespace std;

class bigobj
{
    char buff[1000*1000];
};

void mest(bigobj& b)
{
    cout << "don mest" << endl; 
}

void test(bigobj& b)
{
    mest(b);
    cout << "don test" << endl; 
}

int main()
{
    bigobj bo;
    test(bo);
    cout << "done" << endl;
    return 0;
}