# Command Pattern

- 프로그래밈 패턴의 한 종류
- 플레이어 행동 자체를 캡슐화하고 고유 클래스의 인스턴스로 저장
- 플레이어의 행동 기록 가능 - 되돌리기 연산 가능

### 핵심
- 유저의 클릭에 따른 처리를 새로운 스크립트에서 처리하여 Decoupling을 달성하는 것
- 플레이어의 입력을 저장한다.

```C#
//ICommand.cs
public interface ICommand
{
    void Execute();
    void Undo();
}
```
```C#
//ClickCommand.cs
public class ClickCommand : ICommand// 우클릭-> 빠른작업 및 리팩터링
{
   GameObject _cube;
   Color _color;
   Color _preColor;

   public ClickCommand(GameObject cube, Color color) // 생성자 작성
   {
       _cube = cube;
       _color = color;
   } 

   public void Execute()
   {
       //현 색상을 이전색상에 저장
       // 새로운 색상으로 변경
   }
   public void Undo()
   {
       //이전 색상으로 변경
   }
}
```

## 사용
```C#
ICommand click = new ClickCommand(게임오브젝트, 색상);
click.Execute(); 
CommandManaget.Instance.AddCommand(click); //커맨드버퍼에 실행한 커맨드를 담는다.

//CommandManager.cs
List<ICommand> _commandBuffer = new List<ICommand>();

public void AddCommand(ICommand command)
{
    _commandBuffer.Add(command);
}
public void Play()
{
    StartCoroutine(PlayPlayerRoutine());
}
IEnumeratror PlayPlayerRoutine()
{
    foreach(ICommand command in _commandBuffer)
    {
        command.Execute();
        yield return new WaitForEndOfFrame();
    }
}
public void Rewind()//역숟
{
    StartCoroutine(RewindPlayerRoutine());
}
IEnumeratror RewindPlayerRoutine()
{
    foreach(ICommand command in Enumerable.Reverse(_commandBuffer))
    {
        command.undo();
        yield return new WaitForEndOfFrame();
    }
}
```