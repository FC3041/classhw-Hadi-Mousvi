#include<iostream>
#include<math.h>

using namespace std;

double power(double a, int b)
{
    double result=1;
    for(int i=0;i<b;i++)
        result *= a;
    return result;
}

class Circle
{
    public:
        double ox;
        double oy;
        double r;
        double P;
        double S;

        // void C_perimiter(Circle c0)
        // {
        //     c0.P = (c0.r * 2 * 3.14);
        // }

        // void C_space(Circle c0)
        // {
        //     c0.S = c0.r*c0.r*3.14;
        // }

        Circle (double x,double y, double cr) // for S and P
        {
            ox = x;
            oy = y;
            r = cr;
            P = (r*2*3.14);
            S = (r*r*3.14);
        }

        double Center_distances(Circle c2)
        {
            double dx = power(ox-c2.ox,2);
            double dy = power(oy-c2.oy,2);
            return sqrt(dx+dy);
        }

        string in_circle(double x , double y)
        {
            double condition = power(x,2) + power(y,2);
            if(condition<=power(r,2))
                return "Is in the circle";
            else
                return "Is out of the circle";
        }

        double point_distance(double x,double y)
        {
            double dx = power(ox-x,2);
            double dy = power(oy-y,2);
            return sqrt(dx+dy);
        }
};

int main()
{

}