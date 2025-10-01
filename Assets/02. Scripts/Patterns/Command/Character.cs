using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Queue<ICommand> commandQueue = new Queue<ICommand>();


    public void AllExecuete() // 전체 명령 실행
    {
        foreach (var command in commandQueue)
        {
            command.Execute();
        }
    }
}