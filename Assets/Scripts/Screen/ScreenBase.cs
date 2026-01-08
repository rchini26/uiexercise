using System;
using UnityEngine;
using NaughtyAttributes;
using System.Collections.Generic;
using DG.Tweening;

namespace Screens
{
    public enum ScreenType
    {
        Main_Menu_Panel
    }
    public class ScreenBase : MonoBehaviour
    {
        // public variables
        public ScreenType screenType;
        public List<Transform> listOfObjects;
        public bool startHidden = false;

        [Header("Animation")] 
        public float animationDuration = .3f;
        public float delayBetweenObjects = .05f;
        
        private void Start()
        {
            if (startHidden)
            {
                HideObjects();
            }
        }

        [Button]
        public virtual void Show()
        {
            ShowObjects();
            Debug.Log("Show");
        }

        [Button]
        public virtual void Hide()
        {
            Debug.Log("Hide");
            HideObjects();
        }

        private void HideObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(false));
        }
        
        private void ShowObjects()
        {
            for (int i = 0; i < listOfObjects.Count; i++)
            {
                var obj = listOfObjects[i];

                obj.gameObject.SetActive(true);
                
                obj.DOScale(Vector3.one, animationDuration).From().SetDelay(i * delayBetweenObjects);
            }
        }
        private void ForceShowObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(true));
        }
    }
}