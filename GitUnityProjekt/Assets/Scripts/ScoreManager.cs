using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager Instance;
    public TextMeshProUGUI text;
    //int score; alt
    public int score;





    // Start is called before the first frame update
    void Start()
    {
       if(Instance == null)
        {
            Instance = this;
        }
    }




    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
