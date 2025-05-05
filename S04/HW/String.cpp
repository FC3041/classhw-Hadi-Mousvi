#include<iostream>
#include<stdlib.h>
#include<cstring> // for memeset

using namespace std;

class String
{
    public:
        int m_size;
        char* m_str;
        
        String (const char* str)
        {
            int i = 0;
            int size = 0;
            while(str[i] != 0)
            {
                size++;
                i++;
            }

            m_size = size;
            m_str = (char*)malloc(sizeof(char)*m_size);

            for( i = 0 ; i < m_size ; i++)
            {
                m_str[i] = str[i];
            }

            m_str[m_size] = 0;
        }

        String ()
        {
            m_size = 0;
            m_str = (char*)malloc(0);
        }
        

        void append(const char* chr)
        {
            int old_size = m_size;
            int newsize = 0;
            int j = 0;
            while(chr[j] != 0)
            {
                newsize++;
                j++;
            }

            m_size += newsize;
            char* newstr = (char*)malloc(sizeof(char) * m_size);
            memset(newstr , 0 , sizeof(char)*newsize);
            int i = 0;
            
            for(i ; i < old_size ; i++)
                newstr[i] = m_str[i];

            for(i ; i < m_size ; i++)
            {
                newstr[i] = chr[i-old_size];
            }
            free(m_str);
            m_str = newstr;
        }

        void append(const String& str2)
        {
            int oldsize = m_size;
            m_size += str2.m_size;
            char* newstr = (char*)malloc(sizeof(char) * m_size);
            int i = 0;
            for(i ; i < oldsize ; i++)
                newstr[i] = m_str[i];
            for(i ; i < m_size ; i++)
                newstr[i] = str2.m_str[i-oldsize];
            free(m_str);
            m_str = newstr;
        }

        void assign(const char* chr)
        {
            free(m_str);
            int size = 0;
            int i = 0;
            while(chr[i] != 0)
            {
                size++;
                i++;
            }
            m_size = size;
            m_str = (char*)malloc(sizeof(char) * m_size);
            for(i=0 ; i < m_size ; i++)
            {
                m_str[i] = chr[i];
            }

        }

        char* c_str()
        {
            return m_str;
        }

        int size()
        {
            return m_size;
        }
};

int main()
{
    
}