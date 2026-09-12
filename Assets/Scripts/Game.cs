using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    private static bool isGameStarted = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // show the start screen
        CanvasGroupDisplayer.Show(CanvasGroup);
        
        // Not in the video, but added because if you try to run the game multiple times,
        // you could previously start dropping balls with the start screen still up.
        // This is because isGameStarted is declared and initialized as false the FIRST TIME the game runs,
        // but afterward, it only stays as true from the OnStartButtonClicked() method and never resets to false.
        isGameStarted = false;
    }

    public void OnStartButtonClicked()
    {
        // hide the start screen
        CanvasGroupDisplayer.Hide(CanvasGroup);
        // remember that the game has started
        isGameStarted = true;
    }

    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
}
