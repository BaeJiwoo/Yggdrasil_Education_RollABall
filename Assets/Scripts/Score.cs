using UnityEngine;

public class Score : MonoBehaviour
{
    SphereCollider _sphereCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _sphereCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        // 점수 관련된 스크립트
        if(other.tag == "Player")
        {
            // logic
            other.GetComponent<PlayerScore>().SetScore(1);
        }


        Destroy(gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }
}
