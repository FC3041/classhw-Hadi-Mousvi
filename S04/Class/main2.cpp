#include<iostream>

using namespace std;

class Date
{
    public:
        int day;
        int month;
        int year;
};

class Person
{
    public:
        int m_NID;
        char m_fname[20];
        char m_lname[20];
        Date m_BD;

        Person (int ID , char* firstname, char* lastname, Date BD):m_BD(BD),m_NID(ID)
        {
            int i=0;
            while(firstname!=0)
            {
                m_fname[i] = firstname[i];
                i++;
            }
            m_fname[i] = '\0';
            
            int j=0;
            while(lastname!=0)
            {
                m_lname[j] = lastname[j];
                j++;
            }
            m_lname[j] = '\0';
        }

        void print_person()
        {
            cout << "Name : " << m_fname << " " << m_lname << endl;
        }
};

int main()
{
    Date d;
    Person p(125345,"Ali", "Mohammady" , d);

    p.print_person();
}