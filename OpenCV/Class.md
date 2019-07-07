~~~cpp
#include "opencv2/opencv.hpp"
#include <iostream>

using namespace cv;
using namespace std;
int main()
{

	//Point Class
	Point pt1;
	pt1.x = 5; pt1.y = 10;
	Point pt2(10, 30);

	Point pt3 = pt1 + pt2;
	Point pt4 = pt1 * 2;
	int d1 = pt1.dot(pt2); //pt1, pt2의 내적. 5*10 + 10*30 = 350
	bool b1 = (pt1 == pt2);
	cout << "Point Class" << endl;
	cout << "pt1: " << pt1 << endl;
	cout << "pt2: " << pt2 << endl;

	//Size Class
	Size sz1, sz2(10, 20);
	sz1.width = 5; sz1.height = 10;
	Size sz3 = sz1 + sz2;
	Size sz4 = sz1 * 2;
	int area1 = sz4.area();
	cout << endl << "Size Class" << endl;
	cout << "sz3: " << sz3 << endl;
	cout << "sz4: " << sz4 << endl;

	//Rect Class
	Rect rc1;
	Rect rc2(10, 10, 60, 40);
	Rect rc3 = rc1 + Size(50, 40);
	Rect rc4 = rc2 + Point(10, 10);
	Rect rc5 = rc3 & rc4; //교집합
	Rect rc6 = rc3 | rc4; //합집합

	cout << endl << "Rect Class" << endl;
	cout << "rc5: " << rc5 << endl;
	cout << "rc6: " << rc6 << endl;

	//RotatedRect Class
	RotatedRect rr1(Point2f(40, 30), Size2f(40, 20), 30.f);

	Point2f pts[4];
	rr1.points(pts);

	Rect br = rr1.boundingRect();
	Rect2f br2f = rr1.boundingRect2f();
	
	cout << endl << "Rotated Class" << endl;
	for(int i =0; i< 4; i++)
		cout << "pts"<< i<< ": " << pts[i] << endl;
	cout << "br: " << br << endl;
	cout << "br2f: " << br2f << endl;

	//Range Class
	Range r1(0, 10);
	cout << "r1 : " << r1 << endl;

	//String Class
	String str1 = "Hello";
	String str2 = "world";
	String str3 = str1 + " " + str2;
	bool ret = (str2 == "WORLD"); // ret == false 대소문자구별

}
~~~