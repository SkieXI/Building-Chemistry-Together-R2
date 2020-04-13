# Building-Chemistry-Together
Capstone Project for Spring 2019

# Table of contents:
* Original Concept
* Currrent Development
* Future Development
* Graphs and Flowcharts
* Video Screencast


# Original Concept

The idea for Building Chemistry Together came from asking a few students who were about to gradutate from GCU in the spring of 2018 if there were any major tools or applications that they wish they had while studying. One idea that came up several times was the idea of having an application that could display 3D models. From there, it was a matter of figuring out which game engine or IDE would be best suited for creating the program.

![Site Map](/Documentation/1B.png)

# Current Development
The main approach toward development was to follow a somewhat parallel to the MVC framework. Starting with creating classes for each element: 

```
public class H : MonoBehaviour
{
    //Constructor to apply values to each variable.
    public H(string name, int publicNumber, int valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Hydrogen";
        this.publicNumber = 1;
        this.valance = 1;
        this.protons = 1;
        this.neutrons = 0;
        this.electrons = 1;
        this.mass = 1.008;
        this.trivia = "This is hydrogen.";
    }
   
    public string name { get; set; }        // The name of the element
    public int publicNumber { get; set; }   // The number of the element
    public double mass { get; set; }        // The atomic mass
    public int valance { get; set; }        // The number of valance electrons
    public Vector3 valancePOS { get; set; } // The positions of the valance electrons
    public GameObject Hydrogen = GameObject.CreatePrimitive(PrimitiveType.Sphere);  //Which type of prefab is to be created.
    public int RayD = 1;                    // Ray Distance, the distance betweeen the nucius and the electrons
    public LayerMask Test;                  // ???
    public int protons { get; set; }        // Number of Protons 
    public int neutrons { get; set; }       // Number of Neutrons
    public int electrons { get; set; }      // Number of Electrons
    public string trivia { get; set; }      // Trivia or interesting fact.
}
```
From here, each element class would be inherited by the AtomScrip class that would match up each atomic symbol with the class name and pull the variable information and then pass it on to the class called CreateAndDrag which would instantiate a new prefab based on each element and apply different variables into it. 

From there, the prefab would follow the mouse’s movement and either remain in memory if it is inside of a cylinder mesh, or be destroyed if Unity doesn’t see the prefab colliding with said mesh. There are two different meshes that can be used to create two different atomic structures. Once development resumes, these two atomic structures can be combined for better quality of life building. 


What held back development the most were a number of personal issues and outside factors that made development hard to keep up with as they were a large toll on the developer’s mental and emotional well being. 
Despite that, once things have settled down, development was able to resume and a few features were able to be implemented in the end, though this version of the product is far from being suitable for a release state. Development will continue on during the summer. 

# Future Development

Due to the number of development setbacks, there are many functions; both basic and quality of life that are missing from the current build of the project. These functions are documented within the project’s Requirement page, and will be implements or improved upon either during the summer, or the following semester. 
These functionalities include:
* The ability to add or subtract electrons or protons.
* The ability for the game screen to display the number of valance electrons and if the atomic structure is stable or not.
* Better strut support so atoms are more rigid. 
* The ability to save and load projects for future use.
* The ability to create and save screenshots of the current atomic structures in use.
* The ability to view all information of an element in a separate screen. 

# Graphs and Flowcharts.


![Full Flowchart](/Documentation/2A.png)
Full flowchart.

![Wire Frame](/Documentation/3A.png)
Proposed Wireframe. 

# Video Screencast.

[Link to Loom Video](https://www.loom.com/share/d420bfd0f6ee4bd69a6c53216151c262)
