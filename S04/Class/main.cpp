#include<iostream>
#include<math.h>

using namespace std;

class Point
{
    public:
        double m_x;
        double m_y;

        Point (){};

        Point(double x, double y)
        {
            m_x = x;
            m_y = y;
        }

        void print_point()
        {
            cout << "x:" << m_x << " y:" << m_y << endl;
        }

        double DistanceTo(const Point& p)
        {
            double dx = m_x - p.m_x;
            double dy = m_y - p.m_y;
            return sqrt(dx * dx + dy * dy);
        }
};

class Circle
{
    public:
        Point m_o;
        double m_r;

        // Circle (const Point& o, double r)
        // {
        //     m_o = o;
        //     m_r = r;
        // }

        Circle (const Point& o, double r):m_o(o),m_r(r){};

        Circle (){};

        double DistanceTo(Circle& c)
        {
            return DistanceTo(c.m_o);
        }

        double DistanceTo(Point& p)
        {
            return p.DistanceTo(p);
        }

        // double Distance(Point )
};

int main()
{
    Point p1;
    Point p2(4,7);
    Point p3(1,5);
    Circle c1(p1, 12.3);
    Circle c3(Point (1,9) , 13);
    Circle c2(p3, 12);

    cout << c1.DistanceTo(c2) << endl;
    cout << c1.DistanceTo(p1) << endl;
    cout << p1.DistanceTo(p2) << endl;
}