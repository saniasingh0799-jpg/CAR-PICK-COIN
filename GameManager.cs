using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    float _currentPosOfBlockZ;

    public float CurrentPosOfBlockZ
    {
        get { return _currentPosOfBlockZ; }
        set { _currentPosOfBlockZ = value; }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
