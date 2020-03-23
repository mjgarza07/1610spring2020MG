
using System;
using UnityEngine;
using UnityEngine.Events;

public partial class MouseEvents : MonoBehaviour
{

    public UnityEvent mouseDownEvent, mouseEnterEvent, mouseUpEvent, mouseDragEvent, mouseOverEvent, mouseExitEvent;


    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }

    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
    }

    private void OnMouseDrag()
    {
        mouseDragEvent.Invoke();
    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }
}

public partial class MouseEvents

{
    public UnityEvent destroyEvent, enableEvent;

    private void OnDestroy()
    {
       destroyEvent.Invoke();
    }

    private void OnEnable()
    {
        enableEvent.Invoke();
    }
}
