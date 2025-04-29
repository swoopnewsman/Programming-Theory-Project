using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    void Update()
    {
        // Check if the left mouse button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Create a ray from the camera going through the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; // Variable to store information about what the ray hit

            // Perform the raycast
            if (Physics.Raycast(ray, out hit))
            {
                // Try to get the Shape component from the object that was hit
                // This works because CubeShape, SphereShape, and CapsuleShape ALL inherit from Shape.
                Shape shapeComponent = hit.collider.GetComponent<Shape>();

                // Check if the hit object actually has a Shape component
                if (shapeComponent != null)
                {
                    // ABSTRACTION: We call methods defined in the base Shape class.
                    // We don't need to know if it's specifically a Cube, Sphere, or Capsule here.
                    // The correct overridden method will be executed due to polymorphism.
                    shapeComponent.DisplayInfo(); // Calls the overridden DisplayInfo
                    shapeComponent.Interact();    // Calls the overridden Interact
                    // // ABSTRACTION comment placed here where the base class methods are invoked.
                }
                // Optional: Add an else block here to see what you clicked if it wasn't a shape
                else
                {
                    Debug.Log($"Clicked on {hit.collider.gameObject.name}, but it's not a Shape.");
                }
            }
        }
    }
}