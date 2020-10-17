using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownControll : MonoBehaviour
{
    public RectTransform parent;

    public List<GameObject> Friends;
    public List<GameObject> Team;
    public List<GameObject> Clan;

    public GameObject TeamBtn;
    public GameObject FriendsBtn;
    public GameObject ClanBtn;


    void Start()
    {
        GetComponent<LayoutElement>().preferredHeight = -2*parent.rect.y;
        Refresh();
    }


    bool friends = false;
    public void _Friends()
    {
        friends = !friends;
        clan = false;
        team = false;
        Refresh();
    }

    bool team = false;
    public void _Team()
    {
        team = !team;
        friends = false;
        clan = false;
        Refresh();
    }

    bool clan = false;
    public void _Clan()
    {
        Debug.Log("a");
        clan = !clan;
        friends = false;
        team = false;
        Refresh();
    }

    public Scrollbar sldr;
    void Refresh()
    {
        sldr.value = 1;
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }


        GameObject btn1 = Instantiate(ClanBtn, transform);
        btn1.GetComponent<Button>().onClick.AddListener(_Clan);
        if (clan)
        {
            foreach(GameObject o in Clan)
            {
                Instantiate(o, transform);
            }
        }

        GameObject btn2 = Instantiate(FriendsBtn, transform);
        btn2.GetComponent<Button>().onClick.AddListener(_Friends);
        if (friends)
        {
            foreach (GameObject o in Friends)
            {
                Instantiate(o, transform);
            }
        }

        GameObject btn3 = Instantiate(TeamBtn, transform);
        btn3.GetComponent<Button>().onClick.AddListener(_Team);
        if (team)
        {
            foreach (GameObject o in Team)
            {
                Instantiate(o, transform);
            }
        }
    }
}
