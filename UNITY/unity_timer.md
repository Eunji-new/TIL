if (time >= 0)

        {
            time += Time.deltaTime; // 프레임 수 더해준다..((delta.Time으로 어느 컴이든 같게 기준
            timeText.text = "Time : " + time.ToString("F"); //time.Tostring("F")는 소숫점 많이 방출 방지
        }
