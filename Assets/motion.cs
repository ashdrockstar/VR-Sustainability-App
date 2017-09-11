using UnityEngine;
using System.Collections;
using System;

public class motion : MonoBehaviour
{
    private Vector3 tempPosition;
    static int towerCount;

    void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        void Start()
        {
            // Add a listener to the OVRMessenger for testing
            OVRTouchpad.TouchHandler += LocalTouchEventCallback;
        tempPosition = transform.position;
        towerCount = 0;
    }

        void Update()
        {
            OVRTouchpad.Update();
        if (Input.GetKey("down"))
        {
            if (towerCount == 1)
            {
                tempPosition.x = -1.27f;
                tempPosition.y = 7.59f;
                tempPosition.z = -6.37f;
            }
            if (towerCount == 0)
            {
                tempPosition.x = -4.81f;
                tempPosition.y = 7.59f;
                tempPosition.z = -22.74f;
            }
            if (towerCount == 2)
            {
                tempPosition.x = -32.11f;
                tempPosition.y = 7.59f;
                tempPosition.z = -29.28f;
            }
            if (towerCount == 4)
            {
                tempPosition.x = -48.01f;
                tempPosition.y = 7.59f;
                tempPosition.z = -32.61f;
            }
            if (towerCount == 3)
            {
                tempPosition.x = -1.67f;
                tempPosition.y = 7.59f;
                tempPosition.z = -47.08f;
            }
            transform.position = tempPosition;
        }
    }

        public void OnDisable()
        {
            OVRTouchpad.OnDisable();
        }

        void LocalTouchEventCallback(object sender, EventArgs args)
        {
            var touchArgs = (OVRTouchpad.TouchArgs)args;
            OVRTouchpad.TouchEvent touchEvent = touchArgs.TouchType;

            switch (touchEvent)
            {
                case OVRTouchpad.TouchEvent.SingleTap:
                //Debug.Log("SINGLE CLICK\n");
                towerCount = (towerCount + 1)%5;
                if (towerCount == 1)
                {
                    tempPosition.x = -1.27f;
                    tempPosition.y = 5.85f;
                    tempPosition.z = -6.37f;
                }
                if (towerCount == 0)
                {
                    tempPosition.x = -4.81f;
                    tempPosition.y = 5.85f;
                    tempPosition.z = -22.74f;
                }
                if (towerCount == 2)
                {
                    tempPosition.x = -32.11f;
                    tempPosition.y = 5.85f;
                    tempPosition.z = -29.28f;
                }
                if (towerCount == 4)
                {
                    tempPosition.x = -48.01f;
                    tempPosition.y = 7.59f;
                    tempPosition.z = -32.61f;
                }
                if (towerCount == 3)
                {
                    tempPosition.x = -1.67f;
                    tempPosition.y = 7.59f;
                    tempPosition.z = -47.08f;
                }
                transform.position = tempPosition;
                
                break;

                case OVRTouchpad.TouchEvent.Left:
                //Debug.Log("LEFT SWIPE\n");
                tempPosition.x -= 0.5f;
                transform.position = tempPosition;
                break;

                case OVRTouchpad.TouchEvent.Right:
                //Debug.Log("RIGHT SWIPE\n");
                tempPosition.x += 0.5f;
                transform.position = tempPosition;
                
                break;

                case OVRTouchpad.TouchEvent.Up:
                //Debug.Log("UP SWIPE\n");
                tempPosition.z -= 0.5f;
                transform.position = tempPosition;
                
                break;

                case OVRTouchpad.TouchEvent.Down:
                //Debug.Log("DOWN SWIPE\n");
                tempPosition.z += 0.5f;
                transform.position = tempPosition;

                break;
            }
        }
    }
