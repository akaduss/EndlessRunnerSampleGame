using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_ANALYTICS
using UnityEngine.Analytics;
#endif

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        if (PlayerData.instance.ftueLevel == 0)
        {
            PlayerData.instance.ftueLevel = 1;
            PlayerData.instance.Save();
#if UNITY_ANALYTICS
            AnalyticsEvent.FirstInteraction("start_button_pressed");
#endif
        }

        SceneManager.LoadScene("main");
    }
}
