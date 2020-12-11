using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CowController : MonoBehaviour
{
    public bool hitTheGround = false;
    private float _scaleFactor;

    // Start is called before the first frame update
    void Start()
    {
        _scaleFactor = gameObject.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetCow()
    {
        hitTheGround = false;
        gameObject.transform.DOScale(new Vector3(_scaleFactor, _scaleFactor, _scaleFactor), 0);

        Debug.Log("Reset Cow");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            hitTheGround = true;

            gameObject.transform.DOScale(new Vector3(0.001f, 0.001f, 0.001f), 0.5f).SetEase(Ease.InOutElastic).SetDelay(0.5f);
        }
    }
}

