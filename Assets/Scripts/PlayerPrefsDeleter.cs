using UnityEngine;
using UnityEditor;


[ExecuteInEditMode]
public class PlayerPrefsDeleter : EditorWindow
{
    [MenuItem("Tools/Player Prefs Remover")]
    public static void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Player Prefs Deleted!");
    }
}
