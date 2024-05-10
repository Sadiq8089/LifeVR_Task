using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace VideoManagement
{
    enum ButtonType
    {
        Play,
        Pause,
        Next,
        Previous,
        Forward,
        Backward, 
        Back
    }

    public class Buttons : MonoBehaviour
    {
        [SerializeField] private ButtonType _buttonType;
        private Button _button;

        private void Start()
        {
            if (_button == null)
             _button = GetComponent<Button>();

            _button.onClick.AddListener(delegate { OnButtonClick(_buttonType); });
                
        }


        /// <summary>
        /// This is to use the feature of video playeron selecting/clickinbg button
        /// </summary>
        /// <param name="buttonType"></param>
        private void OnButtonClick(ButtonType buttonType)
        {
           switch(buttonType)
            {
                case ButtonType.Play:
                    ApplicationManager._instance.videoPlayerManagement.Play();
                    break;

                case ButtonType.Pause:
                    ApplicationManager._instance.videoPlayerManagement.Pause();
                    break;

                case ButtonType.Next:
                    ApplicationManager._instance.videoPlayerManagement.Next();
                    break; 
                
                case ButtonType.Previous:
                    ApplicationManager._instance.videoPlayerManagement.Previous();
                    break;


                case ButtonType.Forward:
                    ApplicationManager._instance.videoPlayerManagement.Forward();
                    break;

                case ButtonType.Backward:
                    ApplicationManager._instance.videoPlayerManagement.Backward();
                    break;

                case ButtonType.Back:
                    ApplicationManager._instance.videoPlayerManagement.Restart();
                    break;
            }
        }
    }
}
