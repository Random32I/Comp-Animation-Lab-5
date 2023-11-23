using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DitzelGames.FastIK;

public class Legs : MonoBehaviour
{
    [SerializeField] FastIKFabric fabric;
    GameObject point;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.up * -1, out hit))
        {
            if (point)
            {
                Destroy(point);
            }
            point = new GameObject();
            point.transform.position = hit.point;
            fabric.Target = point.transform;
        }
    }
}
