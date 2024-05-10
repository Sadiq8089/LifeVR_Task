using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


namespace VideoManagement
{
    public class SliderInformation : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        private VideoPlayer _videoPlayer;

        private void Start()
        {
            //Getting videoPlayer reference
            _videoPlayer = ApplicationManager._instance.videoPlayerManagement.VideoPlayer;
            Init();
        }

        private void Init()
        {
            //Setting slider maxValue
            _slider.maxValue = (float)_videoPlayer.frameCount / _videoPlayer.frameRate;
        }

        private void Update()
        {
            //If video is playing, slider progress will change
            if(_videoPlayer.isPlaying)
            {
                _slider.value = (float)_videoPlayer.time;
            }
        }

    }
}
