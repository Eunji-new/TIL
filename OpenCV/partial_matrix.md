~~~cpp

#include "opencv2/opencv.hpp"
#include <iostream>

using namespace cv;
using namespace std;

int main() {

   //부분 행렬 추출
	Mat img1 = imread("cat.bmp");
	//img1영상의 220,120 좌표부터 340*240크기 만큼 사각형 부분영상 추출
	Mat img2 = img1(Rect(220, 120, 340, 240));
	Mat img3 = img1(Rect(220, 120, 340, 240)).clone();

	Mat img4 = img1.rowRange(0, 200).clone(); //img1 row 0~200추출
	Mat img5 = img1.col(500); //열 하나
	img2 = ~img2;
	
	imshow("img1", img1);
	imshow("img2", img2);
	imshow("img3", img3);
	imshow("img4", img4);
	imshow("img5", img5);

	waitKey();
	destroyAllWindows();
}
~~~