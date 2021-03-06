﻿using UnityEngine;

[AddComponentMenu("Scripts/Utility/Credits")]
public class Creditos : ActionBase {

    // Lista de objetos a serem destruídos.
    public GameObject menu;
	public GameObject creditoPosition;

    public override void Activate() {

        base.Activate();
        //menu.SetActive(true);
        //menu.GetComponent<RectTransform>().SetParent(creditoPosition.transform);
        GameController.instance.currentState = GameController.GameState.Cutscene;
        FindObjectOfType<PlayerMovement>().StartCutscene();

    }
}
