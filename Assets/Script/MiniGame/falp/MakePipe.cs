using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;
    public float timediff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timediff)
        {
            GameObject newpipe = Instantiate(Pipe);
            newpipe.transform.position = new Vector3(11f, Random.Range(-1.8f, 3.4f), 0);
            timer = 0;
            Destroy(newpipe, 11.0f);
        }
        
    }
}
