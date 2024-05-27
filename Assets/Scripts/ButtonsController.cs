using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    public GameObject stats;

    public EfficiencyCombined effComb;

    public GameObject chooseModel;
    public GameObject buttons;

    public void Reset()
    {
        SceneManager.LoadScene(1);
        effComb.EfficiencyFinal();
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(0);
        effComb.EfficiencyFinal();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            effComb.EfficiencyFinal();
            stats.SetActive(true);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void LoadFinal()
    {
        SceneManager.LoadScene(1);
    }

    public void StartButton()
    {
        chooseModel.SetActive(true);
        buttons.SetActive(false);
    }

    public void BackButton()
    {
        chooseModel.SetActive(false);
        buttons.SetActive(true);
    }

    public void DeveloperStats()
    {
        Application.OpenURL("https://drive.google.com/file/d/12hHaFeRKo8kNAxDjVWZjuMduY9Lgu6-W/view?usp=sharing");
    }

}
