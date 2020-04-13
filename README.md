# Building-Chemistry-Together
Capstone Project for Spring 2020

# Table of contents:
* Original Concept
* Technologies Used
* Currrent Development
* Future Development


# Original Concept

The idea for Building Chemistry Together came from asking a few students who were about to gradutate from GCU in the spring of 2018 if there were any major tools or applications that they wish they had while studying. One idea that came up several times was the idea of having an application that could display 3D models. From there, it was a matter of figuring out which game engine or IDE would be best suited for creating the program.

![Wire Frame](/Documentation/3A.png)
Proposed Wireframe. 

The idea is that you can click on any button within the Periodic Table and a 3D sphere representing that atom would appear under under the user's mouse point. From there, they can drag it to a Tray at the bottom of the screen and drop it off. From there, you can grab another element from the periodic table and drag it to the tray as well, and depending on the valance electrons, it could either attach or say that it is missing another element to become stable. 

To do this, each elemenet is based on a template called AtomHolder that stores all the information about that element in a script. This object is then saved in another object called AtomModel. 
```
public abstract class AtomHolder : ScriptableObject
{
    //All values that are guaranteed to be used.

    //Name of the element
    public new string name;
    //The type of prefab
    public GameObject Sphere;
    //The Atomic Number
    public int number;
    //Atomic Mass
    public double mass;
    //Number of Protrons
    public int protons;
    //Number of Neurtrons
    public int neutrons;
    //The number of valance electrons
    public int valance;
    //Total Number of electrons
    public int electrons;
    //Random fact of the day.
    public string trivia;

    //Possible values.
    public string shell; // IE: 2p

    //If the atom is diatomic
    // - Diatomic means that the atom cannot exist by itself, it needs two of itself to remain stable.
    public bool diatomic;
    //Is the atom radioactive.
    // - In the grand scheme of things, this doensn't mean anything here, but it might be good for future proofing.
    public bool radioactive;
}

```
When you click on an atom, all of this informatnion is used to create a gameobject that has all of these variables created in a new object. 

# Current Development 



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
