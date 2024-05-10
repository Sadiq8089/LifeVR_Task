using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VideoManagement;

public class ScrollViewUI : MonoBehaviour
{
        
    public void SelectVideos(int val)
    {
        ApplicationManager._instance.videoPlayerManagement.PlayVideo(val);
    }
}
