using UnityEngine;
using System.Collections;

public class MainManager : MonoBehaviour 
{
    [SerializeField]
    private float ScrollSpeed;
    public float scrollSpeed{ get { return ScrollSpeed;} set { ScrollSpeed = value; } }

    public static MainManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
