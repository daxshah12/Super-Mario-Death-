using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecreaseHealth1 : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        HUD.health -= 1;
    }



}
