#include<iostream>
#include<stdlib.h>

using namespace std;

class MyList
{
    public:
        int m_size;
        int m_capacity;
        int* m_Pnums;

        MyList ():m_size(0),m_capacity(0),m_Pnums(nullptr){}

        MyList(int size , int capacity , const int* nums):m_size(size),m_capacity(capacity)
        {
            m_Pnums = (int*)malloc(sizeof(int) * m_capacity);
            for(int i = 0 ; i < m_size ; i++)
                m_Pnums[i] = nums[i];
        }

        void print_list()
        {
            cout << "size : " << m_size << " capacity : " << m_capacity << endl;
            for(int i = 0 ; i < m_size ; i++)
                cout << m_Pnums[i] << " , ";
            cout << "\n";
        }

        int len(){return m_size;}

        void append(int value)
        {
            if(m_size == m_capacity)
            {
                if(m_size == 0){resize(1);}
                else
                {
                    resize(m_capacity * 2);
                }
            }
            m_Pnums[m_size] = value;
            m_size++;
        }

        void insert(int index , int value)
        {
            if(m_size == m_capacity)
            {
                if(m_size == 0){resize(1);}
                else{resize(m_capacity * 2);}
            }
            for(int i = m_size ; i>=index ; i--)
            {
                m_Pnums[i] = m_Pnums[i-1];
            }
            m_Pnums[index] = value;
            m_size++;
        }

        void clear()
        {
            m_size = 0;
            resize(1);
        }

        void erase(int index)
        {
            for(int i=index ; i < m_size-1 ; i++)
                m_Pnums[i] = m_Pnums[i+1];
            m_size--;
        }

        void reverse()
        {
            for(int i = 0 ; i < m_size/2 ; i++)
            {
                int x = m_Pnums[i];
                m_Pnums[i] = m_Pnums[m_size-1-i];
                m_Pnums[m_size-1-i] = x;
            }
        }

        int at(int index)
        {
            if((index<m_size) && (index>-1))
                return m_Pnums[index];
            throw out_of_range("out of range");
        }

        private:
            void resize(int newsize)
            {
                int* newNums = (int*)malloc(sizeof(int) * newsize);
                for(int i = 0 ; i < m_size ; i++)
                    newNums[i] = m_Pnums[i];
                free(m_Pnums);
                m_Pnums = newNums;
                m_capacity = newsize;
            }
};


int main()
{
    MyList l1;

    int nums[5] = {1,2,3,4,5};
    MyList l2(5 , 10 , nums);
    l2.print_list();
    l2.reverse();
    l2.print_list();
    l2.reverse();
    l2.append(55);
    l2.reverse();
    l2.print_list();

    // l2.sort() //TODO 1

    cout << l2.at(1) << endl;
    return 0;
}