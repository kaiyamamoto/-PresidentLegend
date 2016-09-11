using UnityEngine;
using System.Collections;
using DG.Tweening;

public class StarScript : MonoBehaviour
{
    void Start()
    {
        Sequence _myseq = DOTween.Sequence();
        _myseq.Append(transform.DOLocalMoveX(transform.position.x - 2.0f, 2));
        _myseq.Join(transform.DOLocalMoveY(transform.position.y - 2.0f, 2));
        _myseq.Join(transform.DOScale(0, 2));
    }

    // Update is called once per frame
    void Update ()
    {
        this.transform.Rotate(new Vector3(0.0f, 0.0f, 80.0f));
        if (this.transform.localScale.x <= 0) 
        {
            Destroy(gameObject);
        }
    }
}
