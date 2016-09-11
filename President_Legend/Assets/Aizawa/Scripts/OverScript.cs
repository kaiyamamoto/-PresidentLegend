using UnityEngine;
using System.Collections;
using DG.Tweening;

public class OverScript : MonoBehaviour
{
    public GameObject button_1;
    public GameObject button_2;
    public GameObject Black;

    // Use this for initialization
    void Start ()
    {
        Sequence _myseq = DOTween.Sequence();
        _myseq.Append(transform.DOLocalMoveY(transform.position.y + 1000.0f, 3));
        _myseq.AppendCallback(SetButton);
    }

    // Update is called once per frame
    void Update ()
    {
    }
    void SetButton()
    {
        button_1.SetActive(true);
        button_2.SetActive(true);
        Black.SetActive(true);
    }
}
