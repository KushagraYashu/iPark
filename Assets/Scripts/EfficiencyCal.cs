using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents.Policies;
using UnityEngine;

public class EfficiencyCal : MonoBehaviour
{
    public int collisions;
    public int parked;
    public int total;
    public bool isTraining = true;
    float efficiency;

    // Start is called before the first frame update
    void Start()
    {
        if (this.GetComponent<BehaviorParameters>().Model)
        {
            isTraining = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalEfficiency()
    {
        total = parked + collisions;
        efficiency = (parked / total) * 100;
    }
}
