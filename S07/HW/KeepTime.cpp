#include<iostream>
#include<windows.h>

using namespace std;

class KeepTime
{
    unsigned long long m_InitialTick;
    unsigned long long m_FinalTick;

    public:

        KeepTime ()
        {
            m_InitialTick = GetTickCount64();
        }
        ~KeepTime()
        {
            m_FinalTick = GetTickCount64();
            long double t = (m_FinalTick -m_InitialTick) * (15.625);
            cout << "This loop took " << (m_FinalTick -m_InitialTick) << " tick and " << t << " milliseconds." << endl;
        }

};


int main()
{
    return 0;
}