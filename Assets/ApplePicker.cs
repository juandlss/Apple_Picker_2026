using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    // BasketpreFab, Num of baskets, Bottom Y axis value, Spacing Y axis value
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    
    void Start()
    {
        // Use For loop to create numBaskets of baskets,
        // Vector3 position initialized as (0, 0, 0), then update Y axis with BottomY and SpacingY
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGo = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGo.transform.position = pos;
            basketList.Add(tBasketGo);
        }
    }
    
    // AppleMissed()
    public void AppleMissed()
    {
        // Destroy all of the falling apples
        GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tApple in appleArray)
        {
            Destroy(tApple);
        }

        // Destroy one of the Baskets
        int basketIndex = basketList.Count - 1;
        // Get the index of the last Basket in basketList
        GameObject basketGo = basketList[basketIndex];
        // Get a reference to that Basket GameObject
        // Remove the Basket from the list and destroy the GameObject
        basketList.RemoveAt(basketIndex);
        Destroy(basketGo);
        
        // If there are no Baskets left, restart the game
        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("_Scene_0");
        }
    }

}
