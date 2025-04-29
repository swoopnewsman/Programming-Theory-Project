using UnityEngine;

// INHERITANCE: CubeShape derives from the base Shape class.
public class CubeShape : Shape // // INHERITANCE comment placed here
{
    private void Awake()
    {
        // Set the specific name for this shape type using the protected setter from the base class.
        ShapeName = "Cube";
    }

    // POLYMORPHISM: Overriding the base DisplayInfo method.
    public override void DisplayInfo() // // POLYMORPHISM comment placed here
    {
        Debug.Log($"I am a {ShapeName}! Click me!"); // Specific message for Cube
    }

    // POLYMORPHISM: Overriding the base Interact method.
    public override void Interact() // // POLYMORPHISM comment placed here
    {
        Debug.Log($"{ShapeName} interaction: Rotating slightly.");
        // Simple visual feedback: Rotate a bit when clicked
        transform.Rotate(Vector3.up, 30.0f);
    }
}