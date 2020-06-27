using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public Button button;
    GameObject[] buttonTextGOs;

    private GameController gameController;

    void Start()
    {
        buttonTextGOs = GameObject.FindGameObjectsWithTag("ButtonText");
    }

    public void SetSpace(int index)
    {
        buttonTextGOs[index].GetComponent<Text>().text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }

    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }
}
