using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System.IO;
using System;
using Unity.MLAgents.Policies;

public class EfficiencyCombined : MonoBehaviour
{
    public List<EfficiencyCal> efficiencyCal;
    public GameObject[] efficiencyCalGO;
    public List<string> txtString;
    public bool trainingPhase;

    public static EfficiencyCombined instance;

    private const string EffTxtFilePath = @"Assets/Text Files/Efficiency.txt";

    private void Awake()
    {

        efficiencyCal = new List<EfficiencyCal>();
        efficiencyCalGO = GameObject.FindGameObjectsWithTag("agent");

        for(int i = 0; i < efficiencyCalGO.Length; i++)
        {
            efficiencyCal.Add(efficiencyCalGO[i].GetComponent<EfficiencyCal>());
            
            //Skipping one GO, because the model is also tagged agent and it will then throw an error (refer to inspector)
            i++;
        }

        instance = this;
    }

    static EfficiencyCombined()
    {
        EditorApplication.playModeStateChanged += LogPlayModeState;
    }
    private static void LogPlayModeState(PlayModeStateChange state)
    {
        Debug.LogError(state);

        if(state.ToString() == "ExitingPlayMode")
        {
            instance.EfficiencyFinal();
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

    void EfficiencyFinal()
    {
        int totPark = 0;
        int totCollision = 0;
        int totCases = 0;

        trainingPhase = efficiencyCal[0].isTraining;

        foreach(EfficiencyCal cal in efficiencyCal)
        {
            trainingPhase = trainingPhase || cal.isTraining;
            totPark += cal.parked;
            totCollision += cal.collisions;
        }

        totCases = totPark + totCollision;

        float eff = 0;
        eff = (totPark/(float)totCases) * 100;

        if (trainingPhase)
        {
            txtString.Add("\n" + DateTime.Now.ToString() + " (Training Model)");
        }
        else
        {
            txtString.Add("\n" + DateTime.Now.ToString() + " (Testing Model " + "\"" + efficiencyCal[0].GetComponent<BehaviorParameters>().Model + "\"" + ")");
        }
        txtString.Add("Efficiency " + eff + "%");
        txtString.Add("Total Park " + totPark);
        txtString.Add("Total Collision " + totCollision);
        txtString.Add("Total Cases " + totCases);


        File.AppendAllLines(EffTxtFilePath, txtString);

        Debug.LogError("Park " + totPark);
        Debug.LogError("Total " + totCases);
        Debug.LogError("eff " + eff + "%");
    }
}
