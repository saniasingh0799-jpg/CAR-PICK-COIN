using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    float _speed = 0f;

    [SerializeField]
    GameObject GameOverObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        //float _forwardMove = transform.position.z;
        //_forwardMove+=0.1f;
        //this.transform.position = new Vector3(this.transform.position.x,0.5f, _forwardMove);
        if(this.transform.position.y<0f)
        {

            Destroy(this.gameObject);
            GameOverObj.SetActive(true);
            GameManager.instance.Restart();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float _horiz = Input.GetAxis("Horizontal");
        float x = this.transform.position.x;
        x += _horiz* _speed * Time.deltaTime;
        float _forwardMove = transform.position.z;
        _forwardMove+=0.1f;
        //this.transform.position += new Vector3(, 0f, 0f);
        this.transform.position = new Vector3(x,this.transform.position.y, _forwardMove);

    }


    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.collider.CompareTag("Trigger"))
        {
            LevelGeneration.Instance.SpawnBlock();
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            LevelGeneration.Instance.SpawnBlock();
            GameManager.instance.CurrentPosOfBlockZ += 4f;
        }

        if (other.CompareTag("Coins"))
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Exit"))
        {
            //Destroy(this.gameObject);
        }
    }
}
