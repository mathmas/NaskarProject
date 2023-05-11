using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCounter : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider col)
    {
        foreach(GameObject gameObject in gameManager.playerList)
        {
            if (col.gameObject == gameObject)
            {
                int index = gameManager.playerList.IndexOf(gameObject);
                if(gameManager.playerCheckpointed[index])
                {
                    gameManager.playerLapCount[index] += 1;
                    gameManager.playerCheckpointed[index] = false;

                    Debug.Log(gameObject.name + " finished lap: " + gameManager.playerLapCount[index]);
                }
            }
        }
    }
}
