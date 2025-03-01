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
};

int main()
{
    MyStr s1;
    MyStr s2("Hadi Mousavi" , 5 , 7);
    s2.print_str();

    // s2.CheckSubstr("fasdf") // TODO1;
    // s2.len(); //TODO2
    // s2.add(s1); //TODO3
}