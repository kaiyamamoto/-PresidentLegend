using UnityEngine;
using System.Collections;

public class MainManager : MonoBehaviour 
{
    [SerializeField]
    private float ScrollSpeed;
    public float scrollSpeed{ get { return ScrollSpeed;} set { ScrollSpeed = value; } }

    public static MainManager instance;

    private bool resultCoroutineFlag = false;

    public bool isGameFinish = false;

    public bool isGameClear = false;

    public GameObject Clear;

    public GameObject Over;

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
	void Update ()
    {
        if(isGameFinish)
        {
            resultCoroutineFlag = true;
        }

        if(resultCoroutineFlag)
        {
            StartCoroutine(result());
        }
	}
    IEnumerator result()
    {
        yield return new WaitForSeconds(2);

        // 出す
        if(isGameClear)
        {
            Instantiate(Clear);
        }
        else
        {
            Instantiate(Over);
        }

        resultCoroutineFlag = false;
    }
}
