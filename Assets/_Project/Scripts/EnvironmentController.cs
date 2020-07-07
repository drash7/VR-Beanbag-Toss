using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{

    public GameObject[] environments;

    public void SetEnvironment(int i)
    {
        for (int j = 0; j < 3; j++)
        {
            if (j == i)
            {
                environments[j].SetActive(true);
            }
            else
            {
                environments[j].SetActive(false);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
