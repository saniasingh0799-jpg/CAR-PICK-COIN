using UnityEngine;

public class UIManager : MonoBehaviour
{

    public static UIManager Instance;
    [SerializeField]
    int _score = 0;
    public TMPro.TextMeshProUGUI scoretext;


    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text =  Score.ToString();

    }

    public void UpdateScore()
    {
        Debug.Log(Score);
    }
}
