using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    // BasketpreFab, Num of baskets, Bottom Y axis value, Spacing Y axis value
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    
    void Start()
    {
        // Use For loop to create numBaskets of baskets,
        // Vector3 position initialized as (0, 0, 0), then update Y axis with BottomY and SpacingY
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGo = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGo.transform.position = pos;
        }
    }
    
    // AppleMissed()

}
