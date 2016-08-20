using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float maxTime = 60;

    [SerializeField]
    private float countdown = 0;
    
    // Use this for initialization
	void Start () {

        countdown = maxTime;
	
	}
	
	// Update is called once per frame
	void Update () {

        countdown -= Time.deltaTime;

        if(countdown <= 0)
        {
            coin.coinCount = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	
	}
}
