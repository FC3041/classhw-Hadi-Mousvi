#include<iostream>
#include<windows.h>

using namespace std;

template<typename T>

class KeepTime
{
    unsigned long long m_InitialTick;
    unsigned long long m_FinalTick;

    public:

        KeepTime (T Function)
        {
            m_InitialTick = GetTickCount64();
            Function();
            m_FinalTick = GetTickCount64();
        }
        ~KeepTime()
        {
            long double t = (m_FinalTick -m_InitialTick) * (15.625);
            cout << "This loop took " << (m_FinalTick -m_InitialTick) << " tick and " << t << " milliseconds." << endl;
        }

};


void function()
{
    int result = 1;
    for(int i = 0 ; i < 10000*1000 ; i++)
        result++;
}

int main()
{
    KeepTime v(function);
    return 0;
}