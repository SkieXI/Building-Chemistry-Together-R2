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

As of the current build of the Buliding Chemistry Together, there are a lot of influences and ideas that were taken into account and tested, and replaced with different code. At first, 

There were a few features that were major hurdles from the very beginning that haulted development. For the first sprint, Weeks 1-3, they were dedicated to figuring out how to get an atom to spawn when a button was clicked. Sadly, there were many articles and turtorials on Unity that came close, but were flawed for our solutions. At one point, there was a glitch were if you click anywhere on the screen, an atom would spawn in the upper right corner of the screen, regardless of which button was pressed. Yet oddly enough, when you randomly clicked on the screen, you can see that the atoms spawned were somewhat in relation to the mouse's position. However, ultimatly this script was scrapped. 

The second sprint, weeks 3-5, were dedicated to refining the GUI, (Graphic User Interface) of the project and getting a proper menu of options to appear in the top left corner. This also proved to be more of a hassle than intended as bugs and errors from the attempted atom spwaning scripts casued a number of compiling errors. Yet, when the menu came together and it expanded and folded up as intended, it was a huge moral boost. 

The third sprint, weeks 6-7, were dedicated toward a save and loading feature. And this one was a bit of an odd ball to test out. The script, GameSaveManger.cs was not very difficult to put together. As well as the loading feature, though it is hard to test due to the AtomHolder script not being completed. 
```
public void SaveGame()
    {
        //If a savedata directory doesn't exist, then it will create a new folder.
        if (!IsSaveFile())
        {
            Debug.Log("Creating new folder in " + Application.persistentDataPath);
            Directory.CreateDirectory(Application.persistentDataPath + "/SaveData");
        }

        Debug.Log("Save folder located at: " + Application.persistentDataPath);
        //Construct a new BinaryFormatter.
        BinaryFormatter bf = new BinaryFormatter();

        //Opens a stream to create the new file using JSON formatting. 
        FileStream file = File.Create(Application.persistentDataPath + "/SaveData/BCTSAVE.BCT");
        var Json = JsonUtility.ToJson(Molucule);

        //Close the stream after all processes are done.
        file.Close();
    }
```

The fourth sprint, weeks 8-9, were used to go back and to create a new test object to try to figure out why the atoms were not following the mouse pointer. It was theorized that the way the atom was located on screen that the background of the application, which is a solid UI plane that is displayed over a 3D scene that is not used. A placeholder atom that was already spawned was placed in the center of the screen with a new file that was attached; DragDrop. This proved to be more problematic than expcted as when looking for a solution, there were a number of approaches that were demostrated, however, this is where a key technical issue revealed itself: Unity has a few modes that a developer can choose from when creating a new project, a pure 2D project, or a 3D project. For BCT, I chose a 3D project and that caused more than a fair share of troubles. Most of the tutorials and explanations were only valid using 2D Unity projects as they used a number of libraries that were designed solely for 2D projects. There was a 3D turtorial that was found that did allow a user to move around a 3D object while locking its Z axis. However, it is not fully understood how to check collision detection for when a user drops a atom in the tray, or just anywhere in the screen. 



# Future Development

Near the end of development, there were new videos that came out a few months within the semester that demostrated new memory management libraries that would allow gameobjects to be easily converted into "entities" which are similar to objects that relate data to objects that are displayed on screen. The main problem is that entities are not supported with the 2018 version of Unity and are only included with version 2019.3 which came out in Jaunary 2020. By the time I discovered this breakthrough, I did not want to risk updating and breaking the project.

Another thing to note about entities is that there is still a lot of debate among developers for what the best practices are, and if more traditional approaches are still viable. In time, I am sure that more developers will come up with better explanations and documentation as to how everything works with this new framework. 

Beyond these new 

# Graphs and Flowcharts.


![Full Flowchart](/Documentation/2A.png)
Full flowchart.

![Wire Frame](/Documentation/3A.png)
Proposed Wireframe. 

# Video Screencast.

[Link to Loom Video](https://www.loom.com/share/d420bfd0f6ee4bd69a6c53216151c262)
