using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("BeanBag"))
            ScoresController.Instance.HitBoard();
    }

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.tag.Equals("BeanBag"))
    //        ScoresController.Instance.UnhitBoard();
    //}
}
