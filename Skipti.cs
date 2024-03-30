using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skipti : MonoBehaviour
{
    void Start()
    {
        Debug.Log("byrja");
    }
    private void OnTriggerEnter(Collider other) // kveikt þegar annar árekstur fer inn í árekstur þessa hlutar
    {
        // slökkt á hinum leikhlutnum
        other.gameObject.SetActive(false);
        StartCoroutine(Bida());
    }
    IEnumerator Bida() // bíða í nokkrar sekúndur áður en haldið er áfram
    {
        yield return new WaitForSeconds(3);
        Endurræsa();
    }
    public void Endurræsa() // aðferð til að hlaða næstu senu
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//næsta sena
    }

}