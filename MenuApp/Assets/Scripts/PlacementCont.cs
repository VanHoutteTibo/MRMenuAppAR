using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Localization.Settings;

public class PlacementCont : MonoBehaviour
{
    // Start is called before the first frame update
   

    [SerializeField]
    private PlacementObject[] placedObjects;

    [SerializeField]
    private Camera arCamera;

    private Vector2 touchPosition = default;

    [SerializeField]
    private bool displayOverlay = false;

    public GameObject menu;
    public GameObject buttons;
    public GameObject panelDetails;
    public GameObject languageDropdown;
    public PanelGroupManager manager;
    public DetailPageManager managerD;
    public GameObject buttonExit;
    public GameObject buttonBack;
    private string category = "burger";
    public bool detailIsActive = false;
    private bool languageButtonIsActive = false;

    void Awake()
    {

    }

    void Start()
    {
        ChangeSelectedObject(placedObjects[0]);
    }

   

    void Update()
    {
        // do not capture events unless the welcome panel is hidden
       

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchPosition = touch.position;

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if (Physics.Raycast(ray, out hitObject))
                {
                    PlacementObject placementObject = hitObject.transform.GetComponent<PlacementObject>();
                    Debug.Log(placementObject.tag);
                    if (placementObject != null)
                    {
                        ChangeSelectedObject(placementObject);
                    }
                }
            }
        }
    }

    public void disableUI()
    {
        menu.SetActive(false);
        buttons.SetActive(false);
    }

    void ChangeSelectedObject(PlacementObject selected)
    {
        foreach (PlacementObject current in placedObjects)
        {
           
            Debug.Log(selected.tag);
            if(selected.tag != "")
            {
                //Show ui
                Debug.Log("tag found");
                

                if (selected.tag == "burger")
                {
                    Debug.Log(selected.tag);
                    category = "burger";
                    manager.index = 0;
                    Debug.Log(manager.index);
                } 
                else if(selected.tag == "taco")
                {
                    Debug.Log(selected.tag);
                    category = "taco";
                    manager.index = 1;
                    Debug.Log(manager.index);
                }
                else if (selected.tag == "pizza")
                {
                    category = "pizza";
                    manager.index = 2;
                }
                else if (selected.tag == "drink")
                {
                    category = "drink";
                    manager.index = 3;
                }
                else if (selected.tag == "fries")
                {
                    category = "fries";
                    manager.index = 4;
                }
            }

            menu.SetActive(true);
            buttons.SetActive(true);
            buttonBack.SetActive(false);
            buttonExit.SetActive(true);

        }
    }

    public void changeToDetail()
    {
        switch(manager.index)
        {
            case 0:
                Debug.Log(int.Parse(EventSystem.current.currentSelectedGameObject.name));
                managerD.burgerIndex = int.Parse(EventSystem.current.currentSelectedGameObject.name); //welke burger?
                managerD.detailIndex = 0; //Welke category?
                break;
            case 1:
                Debug.Log(int.Parse(EventSystem.current.currentSelectedGameObject.name));
                managerD.tacoIndex = int.Parse(EventSystem.current.currentSelectedGameObject.name);
                managerD.detailIndex = 1;
                break;
            case 2:
                Debug.Log(int.Parse(EventSystem.current.currentSelectedGameObject.name));
                managerD.pizzaIndex = int.Parse(EventSystem.current.currentSelectedGameObject.name);
                managerD.detailIndex = 2;
                break;
            case 3:
                Debug.Log(int.Parse(EventSystem.current.currentSelectedGameObject.name));
                managerD.drinkIndex = int.Parse(EventSystem.current.currentSelectedGameObject.name);
                managerD.detailIndex = 3;
                break;
            case 4:
                Debug.Log(int.Parse(EventSystem.current.currentSelectedGameObject.name));
                managerD.friesIndex = int.Parse(EventSystem.current.currentSelectedGameObject.name);
                managerD.detailIndex = 4;
                break;
        }
   
        menu.SetActive(false);
        panelDetails.SetActive(true);
        buttonBack.SetActive(true);
        buttonExit.SetActive(false);
        detailIsActive = true;
    }

    public void changeToCategory()
    {
        menu.SetActive(true);
        panelDetails.SetActive(false);
        buttonBack.SetActive(false);
        buttonExit.SetActive(true);
        detailIsActive = false;
    }

    public void toggleLanguageDropdown()
    {
        if(languageButtonIsActive) //toggle between dropdown and no dropdown
        {
            languageDropdown.SetActive(false);
            languageButtonIsActive = false;
        }
        else
        {
            languageDropdown.SetActive(true);
            languageButtonIsActive = true;
        }
    }

    public void setLanguage(int i)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[i];
        languageDropdown.SetActive(false);
        languageButtonIsActive = false;
    }
}
