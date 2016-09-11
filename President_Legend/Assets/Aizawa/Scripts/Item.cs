using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour 
{
    [SerializeField]
    private int RecoveryAmount;
    public int recoveryAmount{ get { return RecoveryAmount;} set { RecoveryAmount = value; } }
	
    void Update()
    {
        transform.Translate(Vector2.left * MainManager.instance.scrollSpeed);
    }

}
