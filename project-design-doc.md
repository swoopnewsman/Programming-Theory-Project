Shape Interaction OOP Demo - Design Document
1. Project Concept
A minimal Unity prototype demonstrating the four pillars of Object-Oriented Programming (OOP). The user can click on different primitive shapes (Cube, Sphere, Capsule) in the scene. Each shape will respond to the click by performing a unique action (visual feedback or console log) and displaying its specific information (e.g., its name) to the console.

2. Core Goal
To fulfill the requirements of the "Programming Theory in Action" submission for the Unity Learn Junior Programmer Pathway, specifically demonstrating:
Inheritance
Polymorphism
Encapsulation
Abstraction
Basic Git branching and merging (main and at least one feature branch).

3. Scene Setup
Main Scene:
Main Camera
Directional Light
A Plane primitive (optional, for grounding)
One Cube primitive
One Sphere primitive
One Capsule primitive
An empty GameObject named "InteractionManager" (to hold the click handling script).
Title Scene: (TitleScreen.unity)
Canvas
UI Text (or TextMeshPro Text) displaying the project title (e.g., "Shape Interaction OOP Demo").

4. Class Structure & OOP Implementation
Base Class: Shape.cs (MonoBehaviour)
Purpose: Abstract representation of a shape. Holds common data and defines common behaviours.
Encapsulation:
private string shapeName;
public string ShapeName { get; protected set; } // Getter is public, setter is protected (only base or child classes can set it). // ENCAPSULATION
(Optionally add shapeColor if desired, following the same pattern)
Abstraction:
Provides the base structure and methods used by the ClickHandler. // ABSTRACTION (can be placed here or where base methods are defined/used).
Polymorphism:
public virtual void DisplayInfo(): Base implementation could log a generic message or nothing.
public virtual void Interact(): Base implementation could do nothing.
Child Class: CubeShape.cs (MonoBehaviour)
Inheritance: public class CubeShape : Shape // INHERITANCE
Initialization: In Awake() or Start(), set ShapeName = "Cube";
Polymorphism:
public override void DisplayInfo(): Debug.Log($"I am a {ShapeName}!"); // POLYMORPHISM
public override void Interact(): Implement cube-specific action (e.g., slight rotation transform.Rotate(...), or Debug.Log($"{ShapeName} interaction: Rotating.");). // POLYMORPHISM
Child Class: SphereShape.cs (MonoBehaviour)
Inheritance: public class SphereShape : Shape // INHERITANCE
Initialization: In Awake() or Start(), set ShapeName = "Sphere";
Polymorphism:
public override void DisplayInfo(): Debug.Log($"I am a {ShapeName}!"); // POLYMORPHISM
public override void Interact(): Implement sphere-specific action (e.g., brief scale pulse transform.localScale = ..., or Debug.Log($"{ShapeName} interaction: Pulsing.");). // POLYMORPHISM
Child Class: CapsuleShape.cs (MonoBehaviour)
Inheritance: public class CapsuleShape : Shape // INHERITANCE
Initialization: In Awake() or Start(), set ShapeName = "Capsule";
Polymorphism:
public override void DisplayInfo(): Debug.Log($"I am a {ShapeName}!"); // POLYMORPHISM
public override void Interact(): Implement capsule-specific action (e.g., slight jump transform.Translate(Vector3.up * ...) , or Debug.Log($"{ShapeName} interaction: Jumping.");). // POLYMORPHISM
Interaction Script: ClickHandler.cs (MonoBehaviour)
Purpose: Detects mouse clicks and triggers actions on clicked shapes.
Logic:
In Update(), check for Input.GetMouseButtonDown(0).
Perform a Physics.Raycast from the camera to the mouse position.
If the raycast hits a Collider:
Try to get the Shape component from the hit object (hit.collider.GetComponent<Shape>()).
If a Shape component exists:
Call shape.DisplayInfo();
Call shape.Interact();
Abstraction: This script interacts with any object that is a Shape without needing to know its specific derived type. // ABSTRACTION (Place near the shape.DisplayInfo() / shape.Interact() calls).

5. User Interaction
Primary interaction is left-clicking on the shapes in the main scene.
Feedback is provided via the Unity Console and potentially minimal visual changes to the shapes.

6. Version Control Plan
Initialize Git repository (main branch) with empty Unity project.
Create title-screen branch.
Implement the basic title screen UI on the title-screen branch.
Commit title screen changes to title-screen branch.
Switch back to main branch.
Merge title-screen branch into main.
Continue development of the core OOP features on main (or subsequent feature branches if desired), making regular commits.