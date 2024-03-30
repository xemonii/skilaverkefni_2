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
        // athugar hvort virka senu s� �ri�ja senan
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            // uppf�rir textann til a� s�na talningu fr� PlayerMovement
            texti.text = "Lokastig: " + PlayerMovment.count.ToString();
        }

    }
    public void Byrja() // a�fer� til a� hla�a seinni senu
    {
        SceneManager.LoadScene(1);
    }
    public void Endir() // a�fer� til a� hla�a fyrstu senu og endurstilla fj�lda � n�ll
    {
        SceneManager.LoadScene(0);
        PlayerMovment.count = 0;
    }

}