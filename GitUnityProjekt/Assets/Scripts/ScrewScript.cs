using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrewScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.ChangeScore(coinValue, this);
        }
    }

    private ScoreManager _ScoreManager;
    
    protected ScoreManager ScoreManager
    {
        get
        {
            if (_ScoreManager != null) return _ScoreManager;
            ScoreManager sMans = (ScoreManager)FindObjectOfType(typeof(ScoreManager));
            _ScoreManager = sMans;
            return _ScoreManager;
        }
    }

    private string _uId = null;

    public string UId
    {
        get
        {
            if (_uId == null)
                _uId = SceneManager.GetActiveScene().buildIndex + "-" +
                    string.Format("{0:0.00}", this.gameObject.transform.position.x) + "-" +
                    string.Format("{0:0.00}", this.gameObject.transform.position.y) + "-" +
                    string.Format("{0:0.00}", this.gameObject.transform.position.z);
            return _uId;
        }
    }

    void Start()
    {
        if (ScoreManager.Instance != null)
        {
            if (ScoreManager.Instance.isDeletedScrew(UId))
            {
                Destroy(gameObject);
            }
        }
    }



}
