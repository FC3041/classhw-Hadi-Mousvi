#include<iostream>
#include<string>
#include<vector>

using namespace std;

int main()
{
    vector<int> nums;
    for(int i=0;i<60;i++)
    {
        cout << "capacity: " << nums.capacity() << "\tsize: " << nums.size() << endl;
        nums.push_back(i);
    }
    return 0;   
}

int main3()
{
    vector<int> nums; // TODO1 vector_int
    nums.push_back(5); // TODO2 (append)
    nums.push_back(10);
    for(int i=0;i<nums.size();i++) // TODO3
        cout << nums.at(i) << endl; //TODO4
    nums.insert(nums.begin() , 2); //5,10 ==> 2,5,10 
    // nums.insert(0 , 2); //5,19 ==> 2,5,10 TODO5
    nums.erase(nums.begin()); // 2 , 5, 10 ==> 5 , 10 
    // nums.erase(3) // TODO6
    // cout << nums[i] << endl;
    cout << nums.capacity() << endl; //TODO7
    nums.clear(); //TODO 8 
    return 0;
}   

int main2()
{
    // string name("ali"); //TODO1
    // string name2; //TODO2
    // name2.assign("mozhdeh"); //TODO3
    // name.append(" + ");//TODO 6
    // name.append(name2);//TODO 7
    // name.append("\n");
    string name = "Ali";
    string name2 = "Zhale";
    cout << name.c_str() << ":" << name.size() << endl; //TODO 4 , 5
    name += " + " + name2 + "\n";
    cout << name.c_str() <<endl;
    return 0;
}