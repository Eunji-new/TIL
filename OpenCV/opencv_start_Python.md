# OpenCV시작

cmd 창에 
명령어 python -m pip install opencv-python 입력

IDLE에서 import cv2로 확인.

## 1. 이미지 띄우기

이미지 이름이 영어면 안된다.




import numpy as np

import cv2

def showImage():

        imgfile = 'images/flower.jpg'
        img = cv2.imread(imgfile, cv2.IMREAD_COLOR) # 이미지를 컬러로
        
        cv2.namedWindow('flower', cv2.WINDOW_NORMAL) # 창이름 : flower, 사진크기조절이 가능하다.
        cv2.imshow('flower',img) # 이미지 띄운다.

        k = cv2.waitKey(0) & 0xFF #누른 키 아스키 코드값으로 받는다.

        if k ==27: # ESC키를 누르면
                cv2.destroyAllWindows() # 이미지를 닫는다.
        elif k == ord('c'): # c를 누르면
                cv2.imwrite('images/flower_copy.jpg', img) # 이미지를 복사한다.
                cv2.destroyAllWindows()
                
        #cv2.waitKey(0)
        #cv2.destroyAllWindows()


showImage()

##  imgfile = 'images/flower.jpg'
이미지 파일 경로는 지금 파이썬 파일의 경로가 상대경로로 작용!! ex) C:\User\신은지\Desktop\openCV_1.py로 되어있으면 Desktop경로부터 시작~~

## img = cv2.imread(imgfile, cv2.IMREAD_GRAYSCALE)

opencv의 imread 함수는 이미지 파일을 읽기 위한 객체를 리턴합니다. 이 함수의 첫번째 인자는 읽고자 하는 이미지 파일 경로, 두번째 인자는 이미지 파일을 읽는 방식을 나타내는 플래그입니다.

### - 이미지 읽기 플래그 3가지

- cv2.IMREAD_COLOR : 컬러 이미지로 로드함. 이미지의 투명한 부분은 모두 무시된. 디폴트 플래그. 정수값.

- cv2.IMREAD_GRAYSCALE : 흑백 이미지로 로드함. 정수값은 0

- cv2.IMREAD_UNCHANGED : 알파채널을 포함하여 이미지 그대로 로드함. 정수값은 -1

##  cv2.imshow('flower',img)

cv2.imread()에 의해 반환된 이미지 객체 img를 화면에 나타내기 위한 함수입니다. 이 함수의 첫 번째 인자는 윈도우 타이틀, 두번째 인자는 화면에 표시할 이미지 객체입니다.

## cv2.waitKey(0)

정수 인자는 그만큼의 ms만큼 대기하라는 의미, 0이면 키보드 입력이 있을때까지 기다리라는 의미입니다.

## cv2.destroyAllWindows()

우리가 생성한 모든 윈도를 제거합니다.

##  cv2.imwrite('images/flower_copy.jpg', img)

img를 images폴더에 flower_copy이름으로 저장한다.

## cv2.namedWindow('flower', cv2.WINDOW_NORMAL)

- cv2.WINDOW_AUTOSIZE : 원본 이미지 크기로 고정

- cv2.WINDOW_NORMAL : 원본 이미지 크기로 윈도우 생성, 사용자가 크기 조절 가능.






