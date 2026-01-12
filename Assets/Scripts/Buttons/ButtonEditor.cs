using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

[CustomEditor(typeof(ButtonScaler))]
public class ButtonEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        ButtonScaler scaler = (ButtonScaler)target;

        if (GUILayout.Button("Double Scale"))
        {
            scaler.Scale(2);
            Debug.Log("Doubled Scale");
        }
        
        if (GUILayout.Button("Normal Scale"))
        {
            scaler.Scale(1);
            Debug.Log("Normalized Scale");
        }
    }
    
    [MenuItem("Create/Buttons")]
    public static void CreateButton()
    {
        GameObject button = new GameObject("Button");
        button.AddComponent<Button>();
    }
}
