using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beanbag : MonoBehaviour
{

    public void Thrown()
    {
        BagsController.Instance.BagOnDeck();
        BagsController.Instance.beanbag.GetComponent<CardboardInteractable>().enabled = false;
    }

    public void Grabbed()
    {
        BagsController.Instance.BagInPlay();
        BagsController.Instance.beanbag.GetComponent<Rigidbody>().isKinematic = false;
    }
}
