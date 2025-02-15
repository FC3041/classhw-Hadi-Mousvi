#include<iostream>
#include<math.h>

using namespace std;

class Point
{
    public:
        double x;
        double y; 

        Point ()
        {
            // x=0;
            // y=0;
        }

        // Point (Point* p0)
        // {
        //     x = p0->x;
        //     y = p0->y;
        // }

        //                _________________
        //      __________|_______________|________
        //      |         |               |       |
        Point (const Point& p0) //refrence // const correctness
        {
            x = p0.x;
            // p0.y += 1;
            y = p0.y;
        }

        Point (double t, double r)
        {
            x=t;
            y=r;
            cout<<"x in c:"<<x<<" , y in c:"<<y<<endl;
        }

        Point (double w)
        {
            x=w;
        }

        void print_point()
        {
            cout<<"x:"<<x<<" , y:"<<y<<endl;
        }

        double distance(Point p2)
        {
            double dx = pow((x-p2.x),2);
            double dy = pow((y-p2.y),2);
            double dr = sqrt((dx+dy));
            return dr;
        }

        
        ~Point()
        {
            cout<<"x in d:"<<x<<", y in d:"<<y<<endl;
        }
};

int main()
{
    Point p1(1,2);
    int c=5;
    if(c>3)
        Point p2(2,2);
    else
        Point p3(3,3);
}

int main1()
{
    // Point p1;
    Point p1(4,5);

    // p1.x = 4;
    // p1.y = 5;

    Point p2;
    p2.x = -5;
    p2.y = 10;
    p2.print_point();

    Point p3(p2);

    p3.print_point();

    p1.print_point();
    // print_point(p1);
    // print_point(p2);



    double r = p1.distance(p2);
    cout<<"r:"<<r;
    // cout<<p1.x<<endl;
    // int a;
    // cin>>a;
    // cout<<"a:"<<a<<endl;
    return  0;
}

