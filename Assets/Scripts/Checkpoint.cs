using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider col)
    {
        foreach (GameObject gameObject in gameManager.playerList)
        {
            if (col.gameObject == gameObject)
            {
                int index = gameManager.playerList.IndexOf(gameObject);
                gameManager.playerCheckpointed[index] = true;

                Debug.Log(gameObject.name + " checkpointed");
            }
        }
    }
}
