using UnityEngine;

public class GameApplication : MonoBehaviour
{
    private void Awake()
    {
        // 게임 실행 중 화면이 꺼지지 않도록 설정
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
        // 가로 화면으로
        Screen.orientation = ScreenOrientation.LandscapeRight;

        // 60 FPS로 고정
        Application.targetFrameRate = 60;
    }
}
