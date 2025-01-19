
using UnityEngine;
using UnityEngine.Events;
namespace Assignment35
{
    public class UnityEventExample : MonoBehaviour
    {
        UnityEvent onEventTriggered;
        void Start()
        {
            onEventTriggered = new UnityEvent();
            onEventTriggered.AddListener(LogSomething);

        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) onEventTriggered?.Invoke();
        }
        public void LogSomething() => Debug.Log("The event has been triggered!");
    }
}
