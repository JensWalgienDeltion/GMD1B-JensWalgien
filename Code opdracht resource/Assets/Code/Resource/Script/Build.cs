using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Build : MonoBehaviour
{
    public Camera cam;
    public Image image;
    public GameObject house;
    bool canPlace;
    public LayerMask mask, houseMask;
    public float houseSize;

    public int wood;
    public int stone;
    public Text woodText;
    public Text stoneText;
	
	void Start ()
    {
        image.enabled = false;
	}
	
	
    //wanneer de muisknop is ingedrukt instantiate het huis wat je gekozen hebt
	void Update ()
    {
        if (Input.GetMouseButtonDown(0) && canPlace)
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, mask))
            {
                if(!Physics.CheckBox(hit.point,Vector3.one * houseSize, Quaternion.identity, houseMask))
                {
                    Instantiate(house, hit.point + Vector3.up, Quaternion.identity);
                }
            }
        }
    }

    //activeert de raycast als canPlace is true
    public void BuildHouse ()
    {
        canPlace = !canPlace;
        image.enabled = !image.enabled;
    }

    //laat in game zien hoeveel resources je hebt
    public void SetValues()
    {
        woodText.text = wood.ToString();
        stoneText.text = stone.ToString();
    }
}
