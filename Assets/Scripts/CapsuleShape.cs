using UnityEngine;

// INHERITANCE: CapsuleShape derives from the base Shape class.
public class CapsuleShape : Shape // // INHERITANCE comment placed here
{
    private void Awake()
    {
        ShapeName = "Capsule";
    }

    // POLYMORPHISM: Overriding the base DisplayInfo method.
    public override void DisplayInfo() // // POLYMORPHISM comment placed here
    {
        Debug.Log($"Call me {ShapeName}! I look like a pill."); // Specific message for Capsule
    }

    // POLYMORPHISM: Overriding the base Interact method.
    public override void Interact() // // POLYMORPHISM comment placed here
    {
        // Simple feedback: Log to console (no visual change for simplicity, or add a jump)
        Debug.Log($"{ShapeName} interaction: Boing! (Logged to console)");
        // Optional visual feedback: Add a small jump
        if (TryGetComponent<Rigidbody>(out Rigidbody rb)) // Check if Rigidbody exists
        {
            rb.AddForce(Vector3.up * 2f, ForceMode.Impulse);
        }
    }
}