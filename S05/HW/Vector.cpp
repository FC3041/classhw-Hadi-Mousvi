#include<iostream>
#include<vector>
using namespace std;


class Vector
{
    public:
        int m_size;
        int* m_nums;
        int m_capacity;

        Vector (const int* nums , int size)
        {
            m_size = size;
            m_nums = (int*)malloc(sizeof(int) * size);
            for(int i = 0 ; i < m_size ; i++)
            {
                m_nums[i] = nums[i];
            }
        }

        Vector ()
        {
            m_size = 0;
            m_nums = (int*)malloc(sizeof(int) * m_size);
        }


        void erase(int index)
        {
            int j = 0;
            for(int i = 0 ; i < m_size-1 ; i++)
            {
                if(i==index)
                    i++;
                m_nums[j] = m_nums[i];
                j++;
            }
            resize(m_size-1);
        }

    private:
        void resize(int newsize)
        {
            int* newnums = (int*)malloc(sizeof(int) * newsize);
            for(int i = 0 ; i < newsize ; i++)
            {
                newnums[i] = m_nums[i];
            }
            free(m_nums);
            m_nums = newnums;
            m_size = newsize;
        }

        void cap()
        {
            if(m_size==0)
                m_capacity = 0;
            else
            {
                m_capacity = 1
            }
        }
};

int main()
{
    int nums[5] = {1,2,3,4,5};
    Vector v(nums , 5);
    for(int i = 0 ; i < v.m_size ; i++)
        cout << v.m_nums[i] << " ";
    cout << v.m_size << endl;

    v.erase(3);
    for(int i = 0 ; i < 4 ; i++)
        cout << v.m_nums[i] << " ";
    cout << v.m_size << endl;
}