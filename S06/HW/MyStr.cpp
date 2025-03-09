#include<iostream>

using namespace std;

class MyStr
{
    public:
        int m_size;
        char* m_Pchars;

        MyStr ():m_size(0),m_Pchars(nullptr){};

        MyStr (const char* chars)
        {
            int i;
            for(i = 0 ; chars[i] != '\0' ; i++)
            m_size = i+1;

            m_Pchars = (char*)malloc(sizeof(char)*m_size);

            for(i=0 ; i < m_size ; i++)
                m_Pchars[i] = chars[i];
            m_Pchars[m_size] = '\0';
        }

        MyStr (const char* chars, int start , int count):m_size(count)
        {
            m_Pchars = (char*)malloc(sizeof(char)*(m_size+1));
            for(int i=0 ; i < m_size ; i++)
                m_Pchars[i] = chars[start+i];
            m_Pchars[m_size] = '\0';
        }

        void print_str()
        {
            cout << m_Pchars << endl;
        }

        int CheckSubstr(const MyStr& s)
        {

            for(int i=0 ; i < m_size ; i++)
            {
                if((m_Pchars[i]==s.m_Pchars[0]) && (m_size-i >= s.m_size))
                {
                    for(int j=0 ; j < s.m_size ; j++)
                    {
                        if(m_Pchars[i] != s.m_Pchars[j])
                            return 0;
                        i++; 
                    }
                    return 1;
                }
            }
            return 0;
        }

        int len()
        {
            return m_size;
        }

        void add(const MyStr& s)
        {
            resize(m_size + s.m_size);
            for(int i=0 ; i < s.m_size ; i++)
            {
                m_Pchars[(m_size - s.m_size)+i] = s.m_Pchars[i];
            }
            m_Pchars[m_size] = '\0';
        }

        private:
            void resize(int newsize)
            {
                char* newstr = (char*)malloc(sizeof(char) * newsize);
                for(int i = 0; i < m_size ; i++)
                {
                    newstr[i] = m_Pchars[i];
                }
                free(m_Pchars);
                m_Pchars = newstr;
                m_size = newsize;
            }

};

int main()
{
    
}