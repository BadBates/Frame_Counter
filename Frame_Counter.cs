using UnityEngine;

public class Frame_Counter : MonoBehaviour
{
    public Rect fpsRect;
    GUIStyle style;

    private void Start()
    {
        fpsRect = new Rect(5, 5, 10, 10);
        style = new GUIStyle();
        style.fontSize = 10;
    }

    public void OnGUI()
    {
        //float fps = 1 / Time.deltaTime;

        int fps = 1 / 24;

        fps / Time.deltaTime;

        GUI.Label(fpsRect, "FPS:" + string.Format("{0:0}", fps), style);
    }
}