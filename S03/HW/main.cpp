#include<iostream>
#include<string.h>
#include<stdlib.h>

class Student
{
    public:
        int m_stdNUmber;
        char m_firstname[20];
        char m_lastname[20];
        int m_CoursesPassed;
        int m_Credits[40];
        double m_Grades[40];
        char* m_CourseNames[40];

        void Copy_str(const char* str1 , char* str2)
        {
            int i=0;
            while (str1!=0)
            {
                str2[i] = str2[i];
                i++;
            }       
        }

        Student (int stdnum, const char* fname, const char* lname)
        {
            m_stdNUmber = stdnum;
            Copy_str(fname , m_firstname);
            Copy_str(lname , m_lastname);
        } 

        ~Student()
        {
            std::cout << "The student named "<<m_firstname<<" "<<m_lastname<<" with "<<m_CoursesPassed<<" courses and "<<m_Credits<<" credits passed."<<std::endl;
        }

        double GetGPA()
        {
            double sumGrade = 0;
            int sumCredits = 0;
            for(int i=0;i<m_CoursesPassed;i++)
            {
                sumGrade += m_Credits[i] * m_Credits[i];
                sumCredits += m_Credits[i]; 
            }
            return sumGrade / sumCredits;
        }

        void list_courses()
        {
            for(int i=0;i<m_CoursesPassed;i++)
            {
                std::cout << m_CourseNames[i] << ": " << m_Credits[i] << " : " << m_Grades[i] <<std::endl;
            }
        }

        void register_course(int credits,const char* name, double grade)
        {
            m_Credits[m_CoursesPassed] = credits;
            m_Grades[m_CoursesPassed] = grade;
            char* namecopy = new char[strlen(name)+1];
            // char* namecopy = (char*)malloc(strlen(name)+1);
            strcpy(namecopy , name);
            m_CourseNames[m_CoursesPassed] = namecopy;
            m_CoursesPassed++;
        }

        Student(){}
};

int main()
{
    Student s;
    
    Student* s2 = new Student();

    s.m_CoursesPassed = 0;
    char bufc[20];
    double grade;
    int credits;
    while(true)
    {
        std::cout << "course name?";
        std::cin >> bufc;
        if(*bufc == 'A')
            break;
        std::cout << "course credits?";
        std::cin >> credits;
        std::cout << "course grade?";
        std::cin >> grade;
    }
    s.register_course(credits , bufc , grade);
    s.list_courses();
    std::cout<<s.GetGPA()<<std::endl;
}