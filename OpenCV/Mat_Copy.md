#include "opencv2/opencv.hpp"

#include <iostream>

using namespace cv;

using namespace std;

int main() {

	Mat img1 = imread("dog.bmp");

	Mat img2 = img1; //얕은 복사 : 행렬의 원소 데이터를 공유.

	Mat img3;
	img3 = img1; //얕은 복사


	//깊은 복사 : clone이나 copyTo사용. 메모리 공간을 새로 할당하여 픽셀데이터 전체 복사.
	Mat img4 = img1.clone();
	Mat img5;
	img1.copyTo(img5);

	img1.setTo(Scalar(0, 255, 255));

	imshow("img1", img1);
	imshow("img2", img2);
	imshow("img3", img3);
	imshow("img4", img4);
	imshow("img5", img5);

	waitKey();
	destroyAllWindows();
}