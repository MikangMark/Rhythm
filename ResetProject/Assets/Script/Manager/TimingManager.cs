using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{

    public List<GameObject> boxNoteList = new List<GameObject>();
    [SerializeField]
    Transform Center = null;
    [SerializeField]
    RectTransform[] timingRect = null;
    Vector2[] timingBoxs = null;

    // Start is called before the first frame update
    void Start()
    {
        timingBoxs = new Vector2[timingRect.Length];
        for(int i = 0; i < timingRect.Length; i++)
        {
            timingBoxs[i].Set(Center.localPosition.y - timingRect[i].rect.height * 0.5f, Center.localPosition.y + timingRect[i].rect.height * 0.5f);
        }
    }
    public void CheckTiming()
    {
        for(int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosY = boxNoteList[i].transform.localPosition.y;

            for(int y = 0; y < timingBoxs.Length; y++)
            {
                if (timingBoxs[y].y <= t_notePosY && t_notePosY <= timingBoxs[y].x)
                {

                }
            }
        }
    }
}
