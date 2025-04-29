using UnityEngine;

// Base class for all shapes
public class Shape : MonoBehaviour
{
    // ENCAPSULATION: Private field backing the public property.
    private string shapeName;

    // ENCAPSULATION: Public property with a public getter and a protected setter.
    // This means any code can read the name, but only this class or derived classes can set it.
    public string ShapeName
    {
        get { return shapeName; } // Getter allows reading the name
        protected set { shapeName = value; } // Protected setter allows setting only from this class or children
                                             // // ENCAPSULATION comment placed here for clarity on the property itself
    }

    // POLYMORPHISM: Base virtual method for displaying info. Can be overridden by children.
    public virtual void DisplayInfo()
    {
        Debug.Log("This is a generic shape."); // Default behavior
    }

    // POLYMORPHISM: Base virtual method for interaction. Can be overridden by children.
    public virtual void Interact()
    {
        // Default interaction - maybe do nothing or log a generic message
        Debug.Log("Generic shape interaction.");
    }

    // ABSTRACTION: The existence of this base class itself is a form of abstraction.
    // Other scripts (like ClickHandler) can interact with any 'Shape'
    // without needing to know the specifics of CubeShape, SphereShape, etc.
    // // ABSTRACTION comment placed here to indicate the class's role.
}