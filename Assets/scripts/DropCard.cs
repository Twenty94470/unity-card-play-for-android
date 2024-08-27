using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCard : MonoBehaviour
{
    public GameObject Cards01, Cards02, Cards03;
    public GameObject originalObject;
    public Transform Cardcontainer;


    // Start is called before the first frame update
    void Start()
    {
        Cards01 = GameObject.Find("bookmon");
        Cards02 = GameObject.Find("harpoonmon");
        Cards03 = GameObject.Find("sandwimon");
        Cardcontainer = GameObject.Find("card-container").GetComponent<Transform>();
}

    public void DropNewCards()
    {
        int randomNumber = Random.Range(0, 3);
        switch (randomNumber)
        {
            case 0:
                originalObject = Cards01;
                break;

            case 1:
                originalObject = Cards02;
                break;

            case 2:
                originalObject = Cards03;
                break;

            default:
                originalObject = Cards01;
                break;
        }

        GameObject clonedObject = Instantiate(originalObject);

        // Définit l'objet parent du clone
        clonedObject.transform.SetParent(Cardcontainer);

        // Optionnel : Réinitialiser la position locale du clone
        clonedObject.transform.localPosition = Vector3.zero;
        clonedObject.transform.localRotation = Quaternion.identity;
        clonedObject.transform.localScale = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
