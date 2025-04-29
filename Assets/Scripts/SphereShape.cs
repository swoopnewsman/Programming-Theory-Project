using UnityEngine;

// INHERITANCE: SphereShape derives from the base Shape class.
public class SphereShape : Shape // // INHERITANCE comment placed here
{
    private Vector3 originalScale;

    private void Awake()
    {
        ShapeName = "Sphere";
        originalScale = transform.localScale; // Store original scale
    }

    // POLYMORPHISM: Overriding the base DisplayInfo method.
    public override void DisplayInfo() // // POLYMORPHISM comment placed here
    {
        Debug.Log($"My name is {ShapeName}! I am round."); // Specific message for Sphere
    }

    // POLYMORPHISM: Overriding the base Interact method.
    public override void Interact() // // POLYMORPHISM comment placed here
    {
        Debug.Log($"{ShapeName} interaction: Pulsing.");
        // Simple visual feedback: Scale up briefly
        transform.localScale = originalScale * 1.4f;
        // Optionally, add a coroutine to return to original scale after a short delay
        Invoke(nameof(ResetScale), 0.2f);
    }

    private void ResetScale()
    {
        transform.localScale = originalScale;
    }
}