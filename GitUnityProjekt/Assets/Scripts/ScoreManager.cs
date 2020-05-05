using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Diagnostics;

public class ScoreManager : MonoBehaviour
{
    public class ScrewState
    {
    }

    public class ScoreManagerState
    {
        private Dictionary<string, ScrewState> DeletedScrews = new Dictionary<string, ScrewState>();
        public  Dictionary<int, int> screwsInLevel = new Dictionary<int, int>();
        public int score;

        public void deleteScrew(ScrewScript screw)
        {
            if (DeletedScrews.ContainsKey(screw.UId)) return;
            DeletedScrews.Add(screw.UId, new ScrewState());
        }
        public bool isDeletedScrew(string uId)
        {
            return DeletedScrews.ContainsKey(uId);
        }
    }

    public static ScoreManagerState Instance = new ScoreManagerState();


    public TextMeshProUGUI text;
    public int score;
    public int minScore;
    public int screwsFound = 0;
    public int screwsInLevel = 0;

    public void updateText()
    {
        text.text = screwsFound + "/" + screwsInLevel + "(" + Instance.score + ")";
    }

    public void Start()
    {
        int sceneNumber = SceneManager.GetActiveScene().buildIndex;
        if (Instance.screwsInLevel.ContainsKey(sceneNumber))
        {
            screwsInLevel = Instance.screwsInLevel[sceneNumber];
            UnityEngine.Debug.Log("Found screwsInLevel:" + screwsInLevel);
        }
        else
        {
            screwsInLevel = FindObjectsOfType(typeof(ScrewScript)).Length;
            Instance.screwsInLevel.Add(sceneNumber, screwsInLevel);
            UnityEngine.Debug.Log("Calc screwsInLevel:" + screwsInLevel);
        }
        int screwsInLevelLeft = 0;
        foreach (ScrewScript screw in FindObjectsOfType(typeof(ScrewScript)))
        {
            if (!ScoreManager.Instance.isDeletedScrew(screw.UId))
            {
                screwsInLevelLeft++;
            }
        }
        screwsFound = screwsInLevel - screwsInLevelLeft;
        updateText();
    }

    public void ChangeScore(int coinValue, ScrewScript screw)
    {
        Instance.score += coinValue;
        score += coinValue;
        Instance.deleteScrew(screw);
        screwsFound = screwsInLevel - FindObjectsOfType(typeof(ScrewScript)).Length + 1;
        updateText();
    }

}
