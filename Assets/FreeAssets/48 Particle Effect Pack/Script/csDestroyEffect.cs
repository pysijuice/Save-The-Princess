using UnityEngine;
using System.Collections;

public class csDestroyEffect : MonoBehaviour {

    private float timer;
	void Update () 
    {
        timer += Time.deltaTime;
        if (timer >= 2.0f)
        {
            Destroy(gameObject);
        }      
    }
}
