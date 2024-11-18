using UnityEngine;

public class InputFieldGrabber : MonoBehaviour
{

    public string UsernameInputText;
    public string TeamNameInputText;
    public string HighScoreUsername_1, HighScoreTeamname_1;
    public string HighScoreUsername_2, HighScoreTeamname_2;
    public string HighScoreUsername_3, HighScoreTeamname_3;
    public string HighScoreUsername_4, HighScoreTeamname_4;
    

    void Start()
    {
        HighScoreUsername_1 = PlayerPrefs.GetString("HighScoreUsername_1", "nume1");
        HighScoreTeamname_1 = PlayerPrefs.GetString("HighScoreTeamname_1", "echipa1");

        HighScoreUsername_2 = PlayerPrefs.GetString("HighScoreUsername_2", "nume2");
        HighScoreTeamname_2 = PlayerPrefs.GetString("HighScoreTeamname_2", "echipa2");

        HighScoreUsername_3 = PlayerPrefs.GetString("HighScoreUsername_3", "nume3");
        HighScoreTeamname_3 = PlayerPrefs.GetString("HighScoreTeamname_3", "echipa3");

        HighScoreUsername_4 = PlayerPrefs.GetString("HighScoreUsername_4", "nume4");
        HighScoreTeamname_4 = PlayerPrefs.GetString("HighScoreTeamname_4", "echipa4");
 

    }


    public void UsernameInputField_1(string username)
    {
        PlayerPrefs.SetString("HighScoreUsername_1",username);
        
    }
    
    public void TeamNameInputField_1(string teamname)
    {
        PlayerPrefs.SetString("HighScoreTeamname_1",teamname);
    }




    public void UsernameInputField_2(string username)
    {
        PlayerPrefs.SetString("HighScoreUsername_2",username);
        
    }
    
    public void TeamNameInputField_2(string teamname)
    {
        PlayerPrefs.SetString("HighScoreTeamname_2",teamname);
    }




    public void UsernameInputField_3(string username)
    {
        PlayerPrefs.SetString("HighScoreUsername_3",username);
        
    }
    
    public void TeamNameInputField_3(string teamname)
    {
        PlayerPrefs.SetString("HighScoreTeamname_3",teamname);
    }




    public void UsernameInputField_4(string username)
    {
        PlayerPrefs.SetString("HighScoreUsername_4",username);
        
    }
    
    public void TeamNameInputField_4(string teamname)
    {
        PlayerPrefs.SetString("HighScoreTeamname_4",teamname);
    }
}
