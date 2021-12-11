using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DetailPageManager : MonoBehaviour
{
    public int detailIndex;
    public int burgerIndex;
    public int tacoIndex;
    public int pizzaIndex;
    public int drinkIndex;
    public int friesIndex;

    private bool beingHandled = false;
    private IEnumerator coroutine;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (detailIndex == 0)
        {
            if (burgerIndex == 0)
            {
                transform.GetChild(0).GetComponent<Text>().text = "cheeseBurger";

                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("cheeseburger") as Texture;
                transform.GetChild(3).GetComponent<Text>().text = "Brood"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Kaas"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Ajuin"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Ketchup"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4


            }
            else if (burgerIndex == 1)
            {
                transform.GetChild(0).GetComponent<Text>().text = "barbecueBurger";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("baconburger") as Texture;


                transform.GetChild(3).GetComponent<Text>().text = "Brood"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Bacon"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Steak"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Ketchup"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Sesamzaad"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Selderij"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4
            }
            else if (burgerIndex == 2)
            {
                transform.GetChild(0).GetComponent<Text>().text = "doubleburger";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("doubleburger") as Texture;
                transform.GetChild(3).GetComponent<Text>().text = "Brood"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Kaas"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Rundsvlees"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Salade"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Melk"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Selderij"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Sesamzaad"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Eieren"; //allergenen4    
            }
            else if (burgerIndex == 3)
            {
                transform.GetChild(0).GetComponent<Text>().text = "big mac";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("bigmac") as Texture;

                transform.GetChild(3).GetComponent<Text>().text = "Brood"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Rundsvlees"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Hamburger"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Mosterd"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Sesamzaad"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Soja"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Eieren"; //allergenen4
            }
        }
        else if (detailIndex == 1)
        {
            if (tacoIndex == 0)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Normaal";

                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("taconormaal") as Texture;
                transform.GetChild(3).GetComponent<Text>().text = "Gehakt"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Kaas"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Ajuin"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Ketchup"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4


            }
            else if (tacoIndex == 1)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Spicy Taco";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("spicy") as Texture;


                transform.GetChild(3).GetComponent<Text>().text = "Gehakt"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Kaas"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Ajuin"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "pikante saus"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4
            }
            else if (tacoIndex == 2)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Vegetarisch";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("vegetarisch") as Texture;
                transform.GetChild(3).GetComponent<Text>().text = "mais"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Kaas"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Ajuin"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Ketchup"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4
            }
            else if (tacoIndex == 3)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Deluxe Taco";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("deluxe") as Texture;

                transform.GetChild(3).GetComponent<Text>().text = "Gehakt"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Kaas"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Ajuin"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Ketchup"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4
            }
        }
        else if (detailIndex == 2)
        {
            if (pizzaIndex == 0)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Margherite";

                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("margherita") as Texture;
                transform.GetChild(3).GetComponent<Text>().text = "Mozarella"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Kaas"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Deeg"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Tomatensaus"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4


            }
            else if (pizzaIndex == 1)
            {
                transform.GetChild(0).GetComponent<Text>().text = "4 kazen";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("4kazen") as Texture;


                transform.GetChild(3).GetComponent<Text>().text = "Mozarella"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Kaas"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Gorgonzola"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Tomatensaus"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4
            }
            else if (pizzaIndex == 2)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Hawaii";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("hawaii") as Texture;
                transform.GetChild(3).GetComponent<Text>().text = "Ananas"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Kaas"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Deeg"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Tomatensaus"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4
            }
            else if (pizzaIndex == 3)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Salami";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("salami") as Texture;

                transform.GetChild(3).GetComponent<Text>().text = "Salami"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Kaas"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Deeg"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Tomatensaus"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4
            }
        }
        else if (detailIndex == 3)
        {
            if (drinkIndex == 0)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Cola";

                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("cola") as Texture;
                transform.GetChild(3).GetComponent<Text>().text = ""; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = ""; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = ""; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = ""; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = ""; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = ""; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = ""; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = ""; //allergenen4


            }
            else if (drinkIndex == 1)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Fanta";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("fanta") as Texture;


                transform.GetChild(3).GetComponent<Text>().text = ""; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = ""; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = ""; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = ""; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = ""; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = ""; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = ""; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = ""; //allergenen4
            }
            else if (drinkIndex == 2)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Bier";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("bier") as Texture;
                transform.GetChild(3).GetComponent<Text>().text = ""; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = ""; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = ""; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = ""; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = ""; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = ""; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = ""; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = ""; //allergenen4
            }
            else if (drinkIndex == 3)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Water";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("water") as Texture;

                transform.GetChild(3).GetComponent<Text>().text = ""; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = ""; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = ""; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = ""; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = ""; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = ""; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = ""; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = ""; //allergenen4
            }
        }
        else if (detailIndex == 4)
        {
            if (friesIndex == 0)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Normaal Frieten";

                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("normaalfrieten") as Texture;
                transform.GetChild(3).GetComponent<Text>().text = "Aardappelen"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Zout"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Bloem"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = ""; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4/
           


            }
            else if (friesIndex == 1)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Grote Frieten";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("groot") as Texture;


                transform.GetChild(3).GetComponent<Text>().text = "Aardappelen"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Zout"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Bloem"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = ""; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4
            }
            else if (friesIndex == 2)
            {
                transform.GetChild(0).GetComponent<Text>().text = "Kroketten";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("kroketten") as Texture;
                transform.GetChild(3).GetComponent<Text>().text = "Aardappelen"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Zout"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Bloem"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = ""; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4
            }
            else if (friesIndex == 3)
            {
                transform.GetChild(0).GetComponent<Text>().text = "CheeseFries";
                transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load("cheesefries") as Texture;

                transform.GetChild(3).GetComponent<Text>().text = "Aardappelen"; //ingredient1
                transform.GetChild(4).GetComponent<Text>().text = "Zout"; //ingredient2
                transform.GetChild(5).GetComponent<Text>().text = "Bloem"; //ingredient3
                transform.GetChild(6).GetComponent<Text>().text = "Kaas"; //ingredient4

                transform.GetChild(8).GetComponent<Text>().text = "Gluten"; //allergenen1
                transform.GetChild(9).GetComponent<Text>().text = "Mosterd"; //allergenen2
                transform.GetChild(10).GetComponent<Text>().text = "Eieren"; //allergenen3
                transform.GetChild(11).GetComponent<Text>().text = "Noten"; //allergenen4
            }
        }
    }
}


