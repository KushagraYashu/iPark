using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Barracuda;
using Unity.MLAgents.Policies;
using Unity.VisualScripting;
using UnityEngine;

public class ModelChoose : MonoBehaviour
{
    public GameObject chooseModel;
    public GameObject restUI;

    public GameObject[] agentPrefab = new GameObject[16];
    public GameObject[] array = new GameObject[32];

    public void Awake()
    {
        /*array = GameObject.FindGameObjectsWithTag("agent");
        int j = 0;
        for (int i=0; i<array.Length;i=i+2)
        {
            agentPrefab[j] = array[i];
            j++;
        }*/
    }

    public void ChooseModel(NNModel model)
    {
        foreach (var agent in agentPrefab)
        {
            agent.GetComponent<BehaviorParameters>().Model = model;
        }
        chooseModel.SetActive(false);
        restUI.SetActive(true);
    }
}
