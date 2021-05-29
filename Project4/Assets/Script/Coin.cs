using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update

    private GameManager gameManger;
    void Start()
    {
        gameManger = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,90 * Time.deltaTime , 0);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            PlayerManager.noOfCoins += 1;
            
            Destroy(gameObject);
            
        }

    }
}
