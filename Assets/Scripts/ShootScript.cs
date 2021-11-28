using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    [SerializeField] private Camera arCamera;
    [SerializeField] private GameObject popSound;
    [SerializeField] private Text scoreText;

    public static int score;

    public void onShootButtonClicked()
    {
        RaycastHit hits;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hits))
        {
            // Destroy balloon if raycast hit ballon
            if (hits.transform.name == "balloon1(Clone)" ||
                hits.transform.name == "balloon2(Clone)" ||
                hits.transform.name == "balloon3(Clone)")
            {
                // Destroy balloon
                Destroy(hits.transform.gameObject);

                // Play Sound
                Instantiate(popSound);

                // Increase Score by 1
                score++;
                scoreText.text = score + ""; 

            } 
        }
    }
}
