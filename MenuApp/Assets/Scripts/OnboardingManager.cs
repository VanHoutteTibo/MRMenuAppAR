using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnboardingManager : MonoBehaviour
{

    private Vector3 pos;
    private bool movingRight = false;
    public int index = 0;
    private int speed = 3000;
    RectTransform rt;

    // Start is called before the first frame update
    void Start()
    {
        rt = this.GetComponent<RectTransform>();
        pos = rt.position - (new Vector3((1440 * 0.75f), 0, 0) * index);
    }

    // Update is called once per frame
    void Update()
    {
        rt.position = Vector3.MoveTowards(rt.position, pos, Time.deltaTime * speed);
    }

    public void move()
    {
        pos -= new Vector3((1440 * 0.75f), 0, 0);
    }

    public void disable()
    {
        this.gameObject.SetActive(false);
    }
}
