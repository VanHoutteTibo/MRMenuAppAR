using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelGroupManager : MonoBehaviour
{

    private Vector3 pos;
    private bool movingRight = false;
    public int index = 0;
    private int speed = 100000;
    public PlacementCont placement;

    RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {
        rt = this.GetComponent<RectTransform>();
        pos = rt.position - (new Vector3((1440 * 0.75f), 0, 0) * index); 
        Debug.Log(rt.position);
    }

    void OnEnable()
    {
        speed = 100000;
        rt = this.GetComponent<RectTransform>();
        rt.position = new Vector3(540, 1140, 0);
        pos = rt.position - (new Vector3((1440 * 0.75f), 0, 0) * index);
        Debug.Log(index);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0, 0, right) * Time.deltaTime;
        
            rt.position = Vector3.MoveTowards(rt.position, pos, Time.deltaTime * speed);

            //if (rt.position.x <= posX - (1440 * 0.75)) movingRight = false;
       
        
    }

    public void moveRight()
    {
        //rt.position += new Vector3(transform.position.x - 100, 0,0);
        if(placement.detailIsActive)
        {
           switch(placement.managerD.detailIndex)
            {
                case 0:
                    placement.managerD.burgerIndex += 1;
                    if (placement.managerD.burgerIndex > 3) placement.managerD.burgerIndex -= 1;
                    break;
                case 1:
                    placement.managerD.tacoIndex += 1;
                    if (placement.managerD.tacoIndex > 3) placement.managerD.tacoIndex -= 1;
                    break;
                case 2:
                    placement.managerD.pizzaIndex += 1;
                    if (placement.managerD.pizzaIndex > 3) placement.managerD.pizzaIndex -= 1;
                    break;
                case 3:
                    placement.managerD.drinkIndex += 1;
                    if (placement.managerD.drinkIndex > 3) placement.managerD.drinkIndex -= 1;
                    break;
                case 4:
                    placement.managerD.friesIndex += 1;
                    if (placement.managerD.friesIndex > 3) placement.managerD.friesIndex -= 1;
                    break;
            }
        } else
        {
            speed = 3000;
            index++;
            if (index > 4)
            {
                index = 4;
            }
            else
            {
                pos -= new Vector3((1440 * 0.75f), 0, 0);
            }
        }
       
    }

    public void moveLeft()
    {
        if (placement.detailIsActive)
        {
            switch (placement.managerD.detailIndex)
            {
                case 0:
                    placement.managerD.burgerIndex -= 1;
                    if (placement.managerD.burgerIndex < 0) placement.managerD.burgerIndex += 1;
                    break;
                case 1:
                    placement.managerD.tacoIndex -= 1;
                    if (placement.managerD.tacoIndex < 0) placement.managerD.tacoIndex += 1;
                    break;
                case 2:
                    placement.managerD.pizzaIndex -= 1;
                    if (placement.managerD.pizzaIndex < 0) placement.managerD.pizzaIndex += 1;
                    break;
                case 3:
                    placement.managerD.drinkIndex -= 1;
                    if (placement.managerD.drinkIndex < 0) placement.managerD.drinkIndex += 1;
                    break;
                case 4:
                    placement.managerD.friesIndex -= 1;
                    if (placement.managerD.friesIndex < 0) placement.managerD.friesIndex += 1;
                    break;
            }
        }
        else
        {
            speed = 3000;
            index--;
            if (index < 0)
            {
                index = 0;
            }
            else
            {
                pos += new Vector3((1440 * 0.75f), 0, 0);
            }
        }
    }
}
