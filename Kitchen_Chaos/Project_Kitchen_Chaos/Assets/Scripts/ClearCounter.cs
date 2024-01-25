using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchecnObjectSO;
    [SerializeField] private Transform counterToPoint;

    public void Interact()
    {
        Debug.Log("Interact!");
        Transform kitchenObjectTranform = Instantiate(kitchecnObjectSO.prefab, counterToPoint);
        kitchenObjectTranform.localPosition = Vector3.zero;

        Debug.Log(kitchenObjectTranform.GetComponent<KitchenObject>().GetKitchenObjectSO());
    }
}
