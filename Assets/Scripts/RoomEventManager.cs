using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEventManager : MonoBehaviour
{
    public CountCapturer RoomCounter;
    int count ;

    //furniture in room
    public EventResponder bed;
    public EventResponder desk;
    public EventResponder chair;
    public EventResponder bookshelf;

    //wall & floor mesh changes
    public EventResponder wall01;
    public EventResponder floor;
    public EventResponder extView;

    //audio sources
    public AudioEventResponder musicPlayer;

    //items to spawn
    [SerializeField] GameObject book;

    //lights?
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = RoomCounter.timesEntered;
        Events();
    }

    void Events()
    {
        if (count == 8)
        {
            //items move a small increment
            Debug.Log("moving to position1");
            bed.TransformChangeOne();
            desk.TransformChangeOne();
            chair.TransformChangeOne();
            bookshelf.TransformChangeOne();
        }
        if (count == 10)
        {
            //Total Revert
            Debug.Log("reverting position");
            bed.TransformChangeTwo();
            desk.TransformChangeTwo();
            chair.TransformChangeTwo();
            bookshelf.TransformChangeTwo();
        }
        if (count == 20)
        {
            //Book Appears on Bed
            Debug.Log("creating book");
            Instantiate(book);
        }
        if (count == 22)
        {
            //Total Revert
            Debug.Log("deleting book");
            Destroy(book);
        }
        if (count == 32)
        {
            //Floor Texture slightly changes
            Debug.Log("changing Floor and wall texture");
            floor.MeshChangeOne();
            wall01.MeshChangeOne();
        }
        if (count == 26)
        {
            //Weird music starts playing
            Debug.Log("playing audio");
            musicPlayer.PlaySound(0);
        }
        if (count == 38)
        {
            //bed and desk move drastically
            Debug.Log("changing bed & desk pos");
            bed.TransformChangeThree();
            wall01.MeshChangeTwo();
            desk.TransformChangeThree();
        }
    }
}
