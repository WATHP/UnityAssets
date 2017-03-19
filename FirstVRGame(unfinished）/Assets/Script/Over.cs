using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour {

    public GameController gameController;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Enemy")
        {
            EnemyMover monster = collider.gameObject.GetComponent<EnemyMover>();
            if (!monster.IsDying())
            {
                gameController.GameOver(false);
            }
        }
    }
}
