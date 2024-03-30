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
    private void OnTriggerEnter(Collider other) // kveikt �egar annar �rekstur fer inn � �rekstur �essa hlutar
    {
        // sl�kkt � hinum leikhlutnum
        other.gameObject.SetActive(false);
        StartCoroutine(Bida());
    }
    IEnumerator Bida() // b��a � nokkrar sek�ndur ��ur en haldi� er �fram
    {
        yield return new WaitForSeconds(3);
        Endurr�sa();
    }
    public void Endurr�sa() // a�fer� til a� hla�a n�stu senu
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//n�sta sena
    }

}