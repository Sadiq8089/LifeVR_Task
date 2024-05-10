using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;



namespace VideoManagement
{
    public class AllVideos : MonoBehaviour
    {
        [SerializeField] private List<VideoClip> clips = new List<VideoClip>();
        public List<VideoClip> Clips { get { return clips; } }
    }

}
