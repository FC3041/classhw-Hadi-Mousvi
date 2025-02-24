#include<iostream>

class Student
{
    public:
        char m_name[20];
        int m_stdno;
};

using namespace std;

int main()
{
    Student s;
    Student* ps = &s;
    int x;
    s.m_name[0] = 'A';
    s.m_name[1] = 0;
    s.m_stdno = 403522;
    // cout << s << endl;
    cout << s.m_name << endl;
}