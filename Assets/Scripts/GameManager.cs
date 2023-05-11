using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public float playerNumber;
    [SerializeField] public List<GameObject> playerList;

    #region Counting Laps

    [SerializeField] public List<int> playerLapCount;
    [SerializeField] public List<bool> playerCheckpointed;

    #endregion

    public GameObject playerPrefab;

    [HideInInspector]
    
    private void Start()
    {
        for (int i = 0; i < playerNumber; i++)
        {
            playerList.Add(Instantiate<GameObject>(playerPrefab));
            playerList[i].name = "Player " + (i+1);

            playerLapCount.Add(0);
            playerCheckpointed.Add(false);
        }
    }

}
