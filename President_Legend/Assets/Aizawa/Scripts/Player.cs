using UnityEngine;
using System.Collections;

public class Player : Charactor
{
    [SerializeField]
    private int staminaMax = 10;

    [SerializeField]
    private float tackleTime = 0.2f;

    private Animator animator;
    public bool isTackle { get; private set;}
    public int stamina { get; private set;}

    void Awake()
    {
        animator = GetComponent<Animator>();
        stamina = staminaMax;
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().WakeUp();
    }


    //タックル攻撃
    public void Tackle()
    {
        StartCoroutine(TackleCoroutine());
    }


    //スタミナをnだけ消費する
    public void ConsumeStamina(int n)
    {
        stamina -= n;
        if (stamina <= 0) 
        {
            stamina = 0;
            isDied = true;
        }
    }



    IEnumerator TackleCoroutine()
    {
        animator.SetTrigger("Tackle");
        ConsumeStamina(1);
        isTackle = true;

        yield return new WaitForSeconds(tackleTime);

        isTackle = false;
    }


    private void PickUpItem(GameObject item)
    {
        GameObject itemParent = item.transform.parent.gameObject;
        //スタミナ回復
        stamina += itemParent.GetComponent<Item>().recoveryAmount;
        if (stamina >= staminaMax) { stamina = staminaMax; }

        GameObject particle = itemParent.transform.FindChild("HealEffect").gameObject;
        particle.SetActive(true);
        Destroy(item);
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag != "Item") return;

        //タックル中ならアイテムを拾う
        if (isTackle)
        {
            PickUpItem(other.gameObject);
        }
    }





}


public class Charactor : MonoBehaviour
{
    public bool isDied { get; protected set;}   //死んでいるかどうか

    void Awake()
    {
        isDied = false;
    }
}

