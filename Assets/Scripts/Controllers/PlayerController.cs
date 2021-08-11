using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

/* Controls the player. Here we chose our "focus" and where to move. */

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public Interactable focus;

    PlayerMotor motor;      // Reference to our motor
    Camera cam;             // Reference to our camera

    // Get references
    void Start()
    {
        motor = GetComponent<PlayerMotor>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {



        // If we press left mouse
        if (Input.GetMouseButtonDown(1))
        {
            // Shoot out a ray
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // If we hit
            if (Physics.Raycast(ray, out hit, 100 /*movementMask*/))
            {
                Debug.Log("We hit" + hit.collider.name + "" + hit.point);
                motor.MoveToPoint(hit.point);

                RemoveFocus();
                //SetFocus(null);
            }
        }
         // If we press right mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Shoot out a ray
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // If we hit
            if (Physics.Raycast(ray, out hit, 100f /*interactionMask*/))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }

       
        //		

        // Set our focus to a new focus
        void SetFocus(Interactable newFocus)
        {
            focus = newFocus;
           
            //if (onFocusChangedCallback != null)
            //    onFocusChangedCallback.Invoke(newFocus);

            // If our focus has changed
            if (newFocus != focus && focus != null) 
            {
                // Let our previous focus know that it's no longer being focused
                focus.OnDefocused();
                focus = newFocus;
            }
            newFocus.OnFocused(transform);


           
        }

        void RemoveFocus()
        {
            if (focus != null)
            {
                focus.OnDefocused();
            }
            //focus.OnDefocused();
            focus = null;
        }
    }
}
