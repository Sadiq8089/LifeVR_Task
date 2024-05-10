using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


namespace VideoManagement
{
    public class ApplicationManager : MonoBehaviour
    {
        [Header("Class References")]
        public SliderInformation sliderInformation;
        public VideoPlayerManagement videoPlayerManagement;
        public AllVideos allVideos;

        [Header("Process Data")]
        public GameObject dashboard;
        public GameObject tv;
        public GameObject videosList;
        private bool _processStarted = false;
        [SerializeField] private Button _gallery;

        public static ApplicationManager _instance = null;
        private void Awake()
        {
            if(_instance ==null)
            {
                _instance = this;
            }
            else
            {
                DestroyImmediate(this);
            }
        }

        private void Start()
        {
            if (_gallery == null)
            {
                UnityEngine.Debug.LogError("Gallery reference is missing");
                return;
            }               

            _gallery.onClick.AddListener(delegate { StartVideoPlayer(); });
        }

        /// <summary>
        /// Initializing the process for start condition
        /// </summary>
        public void Init()
        {
            _processStarted = !_processStarted;
            dashboard.SetActive(_processStarted);
            tv.SetActive(_processStarted);
            videosList.SetActive(_processStarted);
        }

        private void StartVideoPlayer()
        {
            Init();
        }

        private void Update()
        {
            //Quitting the Application with device back button
            if(Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
