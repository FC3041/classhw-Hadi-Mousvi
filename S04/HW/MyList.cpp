#include<iostream>
#include<stdlib.h>

using namespace std;

class MyList
{
    public:
        int m_length;
        int m_capacity;
        int* m_Pnums;

        MyList (int lenght , int* nums):m_length(lenght)
        {
            m_Pnums = (int*)malloc(sizeof(int) * lenght);
            for(int i=0;i<lenght;i++)
            {
                m_Pnums[i] = nums[i];
            }
        }

        MyList ()
        {
            
        }

        void append(double n)
        {
            if(m_length+1 < m_capacity)
            {
                resize(m_length+1 , "append");
                m_Pnums[m_length-1] = n;
            }
            else
            {
                cout << "New size is over the capacity." << endl;
            }
        }

        void pop(int index)
        {
            if ((index==(m_length - 1)))
            {
                resize(m_length-1 , "pop");       
            }
            else
            {
                int j = 0;
                for(int i=0 ; i<m_length ; i++)
                {
                    if( (index==i) && (i!=(m_length - 1)))
                    {
                        j += 1;
                    }        
                    m_Pnums[i] = m_Pnums[j];
                    j++;
                }
                resize(m_length - 1 , "pop");
            }
        }

        private:
            void resize(int newsize , string cmd)
            {
                if(cmd=="append")
                {
                    int* newMem = (int*)malloc(sizeof(int)*newsize);
                    for(int i=0;i<m_length;i++)
                    {
                        newMem[i] = m_Pnums[i];
                    }
                    free(m_Pnums);
                    m_length = newsize;
                    m_Pnums = newMem;
                    // newMem = NULL;
                }
                else if(cmd=="pop")
                {
                    
                    int* newMem = (int*)malloc(sizeof(int)*newsize);
                    for(int i=0 ; i < (m_length - 1) ; i++)
                    {
                        newMem[i] = m_Pnums[i];
                    }
                    free(m_Pnums);
                    m_length = newsize;
                    m_Pnums = newMem;
                }
            }
};

int main()
{
    int nums[5] = {1,2,3,4,5};
    MyList l;
    l.m_Pnums = nums;
    l.m_length = 5;
    l.pop(3);
    for(int i = 0 ; i < 4 ; i++)
        cout << l.m_Pnums[i] << " ";
    cout << l.m_length << endl;

}