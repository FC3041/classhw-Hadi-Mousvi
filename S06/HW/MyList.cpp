// sort method is in the 95th line

#include<iostream>
#include<stdlib.h>

using namespace std;

template<typename T>

class MyList
{
    public:
        int m_size;
        int m_capacity;
        T* m_Pnums;

        MyList ():m_size(0),m_capacity(0),m_Pnums(nullptr){}

        MyList(int size , int capacity , const T* nums):m_size(size),m_capacity(capacity)
        {
            m_Pnums = (T*)malloc(sizeof(T) * m_capacity);
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

        void append(T value)
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

        void insert(int index , T value)
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
                T x = m_Pnums[i];
                m_Pnums[i] = m_Pnums[m_size-1-i];
                m_Pnums[m_size-1-i] = x;
            }
        }

        T at(int index)
        {
            if((index<m_size) && (index>-1))
                return m_Pnums[index];
            throw out_of_range("out of range");
        }

        void sort()
        {
            T swap;
            int index;
            T min;
            for(int i=0; i < m_size-1 ; i++)
            {
                index = i;
                min = m_Pnums[i];
                for(int j=i+1; j < m_size ; j++)
                {
                    if(min > m_Pnums[j])
                    {
                        index = j;
                        min = m_Pnums[j];
                    }
                }
                swap = m_Pnums[i];
                m_Pnums[i] = m_Pnums[index];
                m_Pnums[index] = swap;
            }
        }

        private:
            void resize(int newsize)
            {
                T* newNums = (T*)malloc(sizeof(int) * newsize);
                for(int i = 0 ; i < m_size ; i++)
                    newNums[i] = m_Pnums[i];
                free(m_Pnums);
                m_Pnums = newNums;
                m_capacity = newsize;
            }
};


int main()
{

}