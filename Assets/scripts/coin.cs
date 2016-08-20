using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {

    // Use this for initialization
    public static int coinCount = 0;

	void Start () {
        coin.coinCount++;
        print(coin.coinCount);

    }

    // Update is called once per frame
    void Update () {
	    
	}

    void OnDestroy()
    {
        coin.coinCount--;

        if (coin.coinCount <= 0)
        {
            Destroy(GameObject.Find("Timer"));

            GameObject[] fireworks = GameObject.FindGameObjectsWithTag("firework");

            foreach (GameObject firework in fireworks)
                firework.GetComponent<ParticleSystem>().Play();
        }

        print(coinCount);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            Destroy(this.gameObject);
    }
}
