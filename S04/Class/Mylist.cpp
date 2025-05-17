#include<iostream>
#include<stdlib.h>

using namespace std;

class MyList
{
    public:
        int m_length;
        int* m_Pnums;

        MyList (int lenght , int* nums):m_length(lenght)
        {
            m_Pnums = (int*)malloc(sizeof(int) * lenght);
            for(int i=0;i<lenght;i++)
            {
                m_Pnums[i] = nums[i];
            }
        }

        void append(double n)
        {
            resize(m_length+1);
            m_Pnums[m_length-1] = n;
        }

        private:
            void resize(int newsize)
            {
                int* newMem = (int*)malloc(sizeof(int)*newsize);
                for(int i=0;i<m_length;i++)
                {
                    newMem[i] = m_Pnums[i];
                }
                free(m_Pnums);
                m_length = newsize;
                m_Pnums = newMem;
                newMem = NULL;
            }
};

int main()
{
    int nums[5] = {1,2,3,4,5};
    MyList m1(5 , nums);
    m1.append(14);

    cout << m1.m_length << endl;
    for(int i=0;i<m1.m_length;i++)
    {
        cout << m1.m_Pnums[i] << endl;
    }
}