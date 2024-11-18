using TMPro;
using UnityEngine;

public class BestScoreHandler : MonoBehaviour
{

public int map1score;
public int map2score;
public int map3score;
public int map4score;


public string map1username;
public string map2username;
public string map3username;
public string map4username;

public string map1teamname;
public string map2teamname;
public string map3teamname;
public string map4teamname;


public TMP_Text map1scoreText;
public TMP_Text map2scoreText;
public TMP_Text map3scoreText;
public TMP_Text map4scoreText;


    void Start()
    {
        map1score = PlayerPrefs.GetInt("HighScore_1",0);
        map2score = PlayerPrefs.GetInt("HighScore_2",0);
        map3score = PlayerPrefs.GetInt("HighScore_3",0);
        map4score = PlayerPrefs.GetInt("HighScore_4",0);

        map1username = PlayerPrefs.GetString("HighScoreUsername_1","nume1");
        map2username = PlayerPrefs.GetString("HighScoreUsername_2","nume2");
        map3username = PlayerPrefs.GetString("HighScoreUsername_3","nume3");
        map4username = PlayerPrefs.GetString("HighScoreUsername_4","nume4");

        map1teamname = PlayerPrefs.GetString("HighScoreTeamname_1","echipa1");
        map2teamname = PlayerPrefs.GetString("HighScoreTeamname_2","echipa2");
        map3teamname = PlayerPrefs.GetString("HighScoreTeamname_3","echipa3");
        map4teamname = PlayerPrefs.GetString("HighScoreTeamname_4","echipa4");


        map1scoreText.text = "BEST SCORE: " + map1teamname.ToString() + " - " + map1username.ToString() + " : " + map1score.ToString();
        map2scoreText.text = "BEST SCORE: " + map2teamname.ToString() + " - " + map2username.ToString() + " : " + map2score.ToString();
        map3scoreText.text = "BEST SCORE: " + map2teamname.ToString() + " - " + map3username.ToString() + " : " + map3score.ToString();
        map4scoreText.text = "BEST SCORE: " + map3teamname.ToString() + " - " + map4username.ToString() + " : " + map4score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
