using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Save()
    {
        PlayerPrefs.Save();
    }
}
