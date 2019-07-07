### 활성 솔루션 플랫폼을 x64로

# HelloCV
   ~~~cpp 
#include "opencv2/opencv.hpp"

#include <iostream>

using namespace cv;

using namespace std;

int main()
{

	cout << "Hello OpenCV " << CV_VERSION << endl;


	Mat img;
	img = imread("lenna.bmp");

	if (img.empty()) {
		cerr << "Images load failed! " << endl;
		return -1;
	}

	namedWindow("image");
	imshow("image", img);

	waitKey();
	return 0;
}

~~~

# 주요함수 설명
1. imread(파일 이름, flags = IMREAD_COLOR)
2. imwrite(file name, img, params)
3. MAT::empty()
4. nameWindow(winname, flags = WINDOW_AUTOSIZE)
5. destroyWindow(winname)
   
    destroyAllWindow()
6. moveWindow(winname, x, y)
7. resizeWindow(winname, width, height)
8. imshow(winname, mat)
9. waitKey(delay=0) - delay시간 동안 키 입력을 기다린다. delay = 0이면 키 입력을 받을 때까지 무한히 기다린다.

* imshow() 함수만 사용해서는 영상이 화면에 나타나지 않는다.
imshow()함수 호출 후, waitKey() 함수를 호출해야 그리기 이벤트가 동작하여 영상이 화면에 출력된다.