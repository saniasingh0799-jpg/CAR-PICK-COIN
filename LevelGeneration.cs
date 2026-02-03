//using Unity.Mathematics;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{

    public static LevelGeneration Instance;
    [SerializeField]
    GameObject _blockPrefab;

    [SerializeField]
    GameObject _coin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnBlock()
    {

        int _courrentXPos = UnityEngine.Random.Range(-2, 2);

        GameObject obj = Instantiate(_coin,new Vector3(_courrentXPos, 1.5f, GameManager.instance.CurrentPosOfBlockZ), Quaternion.Euler(new Vector3(90f,0f,0f)));
        int _flagToEnableCoin = Random.Range(1,4);
        if(_flagToEnableCoin ==1)
            obj.SetActive(true);
        Instantiate(_blockPrefab,new Vector3(_courrentXPos, 0f, GameManager.instance.CurrentPosOfBlockZ),Quaternion.identity);
    }
}
