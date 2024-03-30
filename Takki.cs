using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Takki : MonoBehaviour
{
    public TextMeshProUGUI texti;

    public void Start()
    {
        // athugar hvort virka senu sé þriðja senan
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            // uppfærir textann til að sýna talningu frá PlayerMovement
            texti.text = "Lokastig: " + PlayerMovment.count.ToString();
        }

    }
    public void Byrja() // aðferð til að hlaða seinni senu
    {
        SceneManager.LoadScene(1);
    }
    public void Endir() // aðferð til að hlaða fyrstu senu og endurstilla fjölda á núll
    {
        SceneManager.LoadScene(0);
        PlayerMovment.count = 0;
    }

}