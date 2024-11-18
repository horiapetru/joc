using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public AudioSource TheMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    public int currentScore;

    public int scorePerNote = 100;

    public int scorePerGoodNote = 150;

    public int scorePerPerfectNote = 200;

    public Text scoreText;
    public Text MultiplierText;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierTresholds;

    public float totalNotes;

    public float normalHits;
    public float goodHits;
    public float perfectHits;
    public float missedNotes;

    public int highScore;


    public Animator animator;
    public GameObject Camera;


    private UnityEngine.SceneManagement.Scene scene;
    private UnityEngine.SceneManagement.Scene map1;
    private UnityEngine.SceneManagement.Scene map2;
    private UnityEngine.SceneManagement.Scene map3;
    private UnityEngine.SceneManagement.Scene map4;

    public GameObject resultsScreen;
    public GameObject HighScoreText;
    public GameObject HighScorePanel;
    public float HighScoreValue;
    public TMP_Text HighScoreValueText;
    public Text percentHitsText, normalHitsText, goodHitsText, perfectHitsText, missedHitsText, RankText, finalScoreText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;

        scene = SceneManager.GetActiveScene();
        map1 = SceneManager.GetSceneByBuildIndex(2);
        map2 = SceneManager.GetSceneByBuildIndex(3);
        map3 = SceneManager.GetSceneByBuildIndex(4);
        map4 = SceneManager.GetSceneByBuildIndex(5);

        scoreText.text = "Score: 0";
        currentMultiplier = 1;

        if (scene == map1)
        {
            highScore = PlayerPrefs.GetInt("HighScore_1", 0);
        }

        if (scene == map2)
        {
            highScore = PlayerPrefs.GetInt("HighScore_2", 0);
        }

        if (scene == map3)
        {
            highScore = PlayerPrefs.GetInt("HighScore_3", 0);
        }

        if (scene == map4)
        {
            highScore = PlayerPrefs.GetInt("HighScore_4", 0);
        }




#pragma warning disable CS0618 // Type or member is obsolete
        totalNotes = FindObjectsOfType<NoteObject>().Length;
#pragma warning restore CS0618 // Type or member is obsolete

    }

    // Update is called once per frame


    void Update()
    {

        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.HasStarted = true;
                TheMusic.Play();
            }
        }
        else
        {
            if (PauseMenu.isPaused)
            {
                TheMusic.Pause();
            }
            else if (!PauseMenu.isPaused)
            {
                TheMusic.UnPause();
            }
        }

        if (TheMusic.time >= TheMusic.clip.length && !resultsScreen.activeInHierarchy)
        {
            resultsScreen.SetActive(true);
            normalHitsText.text = "" + normalHits;
            goodHitsText.text = "" + goodHits;
            perfectHitsText.text = "" + perfectHits;
            missedHitsText.text = "" + missedNotes;


            float totalhits = normalHits + goodHits + perfectHits;
            float percentHit = (totalhits / totalNotes) * 100f;
            percentHitsText.text = percentHit.ToString("F1") + "%";

            string rankValue = "F";
            if (percentHit > 40)
            {
                rankValue = "D";
                if (percentHit > 55)
                {
                    rankValue = "C";
                    if (percentHit > 70)
                    {
                        rankValue = "B";
                        if (percentHit > 85)
                        {
                            rankValue = "A";
                            if (percentHit > 95)
                            {
                                rankValue = "S";
                            }
                        }
                    }
                }
            }

            if (scene == map1)
            {
                if (currentScore > highScore)
                {
                    Debug.Log("NEW HIGH SCORE " + currentScore);
                    HighScoreValue = currentScore;
                    HighScoreValueText.text = HighScoreValue.ToString();
                    PlayerPrefs.SetInt("HighScore_1", currentScore);
                    PlayerPrefs.Save();
                    if (!HighScoreText.activeInHierarchy)
                    {
                        HighScoreText.SetActive(true);
                    }

                }
                else if (Input.anyKeyDown)
                {
                    PauseMenu.instance.MainMenu();
                }
            }

            if (scene == map2)
            {
                if (currentScore > highScore)
                {
                    Debug.Log("NEW HIGH SCORE " + currentScore);
                    HighScoreValue = currentScore;
                    HighScoreValueText.text = HighScoreValue.ToString();
                    PlayerPrefs.SetInt("HighScore_2", currentScore);
                    PlayerPrefs.Save();
                    if (!HighScoreText.activeInHierarchy)
                    {
                        HighScoreText.SetActive(true);
                    }

                }
                else if (Input.anyKeyDown)
                {
                    PauseMenu.instance.MainMenu();
                }
            }

            if (scene == map3)
            {
                if (currentScore > highScore)
                {
                    Debug.Log("NEW HIGH SCORE " + currentScore);
                    HighScoreValue = currentScore;
                    HighScoreValueText.text = HighScoreValue.ToString();
                    PlayerPrefs.SetInt("HighScore_3", currentScore);
                    PlayerPrefs.Save();
                    if (!HighScoreText.activeInHierarchy)
                    {
                        HighScoreText.SetActive(true);
                    }

                }
                else if (Input.anyKeyDown)
                {
                    PauseMenu.instance.MainMenu();
                }
            }

            if (scene == map4)
            {
                if (currentScore > highScore)
                {
                    Debug.Log("NEW HIGH SCORE " + currentScore);
                    HighScoreValue = currentScore;
                    HighScoreValueText.text = HighScoreValue.ToString();
                    PlayerPrefs.SetInt("HighScore_4", currentScore);
                    PlayerPrefs.Save();
                    if (!HighScoreText.activeInHierarchy)
                    {
                        HighScoreText.SetActive(true);
                    }

                }
                else if (Input.anyKeyDown)
                {
                    PauseMenu.instance.MainMenu();
                }
            }


            RankText.text = rankValue;

            finalScoreText.text = currentScore.ToString();

        }

    }
    public void noteHit()
    {
        animator.SetBool("dance", true);
        //Debug.Log("hit on time");
        if (currentMultiplier - 1 < multiplierTresholds.Length)
        {
            multiplierTracker++;

            if (multiplierTresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }

        MultiplierText.text = "Multiplier: x" + currentMultiplier;

        //currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score: " + currentScore;
    }

    public void noteMissed()
    {
        animator.SetBool("dance", false);
        Debug.Log("missed note");
        currentMultiplier = 1;
        multiplierTracker = 0;

        MultiplierText.text = "Multiplier: x" + currentMultiplier;
        missedNotes++;
    }

    public void normalHit()
    {
        currentScore += scorePerNote * currentMultiplier;
        noteHit();
        normalHits++;
    }

    public void goodHit()
    {
        currentScore += scorePerGoodNote * currentMultiplier;
        noteHit();
        goodHits++;
    }
    public void perfectHit()
    {
        currentScore += scorePerPerfectNote * currentMultiplier;
        noteHit();
        perfectHits++;
    }
    public void UnpauseMusic()
    {
        TheMusic.UnPause();
    }
    public void Results()
    {
        if (currentScore > highScore)
        {
            HighScorePanel.SetActive(true);
            resultsScreen.SetActive(false);
        }
        else
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}
