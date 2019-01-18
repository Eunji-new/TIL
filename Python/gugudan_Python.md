## 구구단함수를 만들어봤다..(연습문제)

>> def gugudan():

    for i in range(2,10):

        for j in range(1,10):

            print('%d * %d = %d' % (i,j,i*j))

        i = i+1