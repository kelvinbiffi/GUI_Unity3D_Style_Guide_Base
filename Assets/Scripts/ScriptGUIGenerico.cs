using UnityEngine;

public class ScriptGUIGenerico : StyleGuide
{
    public string labelButtonPlay = "Play";

    private void Awake() {

    }
    private void OnGUI() {

        if (GUI.Button(primaryButtonPositionCenter, labelButtonPlay, primaryButton)) {
            Debug.Log("Gui Clicked!");
        }
    }
}
