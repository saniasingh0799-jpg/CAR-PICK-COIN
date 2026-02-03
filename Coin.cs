using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider col)
    {

        if(col.CompareTag("Player"))
        {

            UIManager.Instance.Score += 1;
            UIManager.Instance.UpdateScore();
            //Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }

}
