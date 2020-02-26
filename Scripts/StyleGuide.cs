using UnityEngine;

[System.Serializable]
public class StyleGuide : MonoBehaviour
{
    public GUIStyle primaryButton;
    public Rect primaryButtonPositionCenter;

    private void Start() {
        primaryButton.normal.textColor = Color.black;
        primaryButton.fontSize = 16;
        primaryButton.alignment = TextAnchor.MiddleCenter;
        primaryButton.normal.background = Resources.Load<Texture2D>("primaryButton");
        primaryButton.font = Resources.Load<Font>("primaryFont");
        
        primaryButtonPositionCenter = new Rect(
                                        Screen.width/2-Screen.width/4, 
                                        Screen.height/2, 
                                        Screen.width/2, 
                                        50
                                    );
    }

}