using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagsController : Singleton<BagsController>
{

    public GameObject beanbagPrefab;
    public GameObject beanbag;
    public Transform _ondeckLocation;
    private Transform _bagsContainer;
    private GameObject BagsContainer;
    public Transform inplayLocation;

    //private void Awake()
    //{
    //    if (instance != null)
    //    {
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //}

    void Start()
    {
        // create a new private empty game object called "Bags Container"
        BagsContainer = new GameObject();
        BagOnDeck();
    }

    void Update()
    {

    }

    public void BagOnDeck()
    {
        // instantiate a new beanbag at the ondeck position and rotation
        // as a child of the "Bags Container" game object
        beanbag = Instantiate(beanbagPrefab, _ondeckLocation.position, _ondeckLocation.rotation);
        beanbag.transform.parent = BagsContainer.transform;
        beanbag.SetActive(true);

    }

    public void BagInPlay()
    {
        beanbag.transform.position = inplayLocation.position;
        beanbag.transform.rotation = inplayLocation.rotation;
    }

    public void ResetBags()
    {
        foreach (Transform child in BagsContainer.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
