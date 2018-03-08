# Robot Arm Programming Game

You work at an automating factory job programming robot arms.
You are asked to solve automation problems. It starts simple:
Pick up item and move it to a storage container until container is full.
Then you might pick up an item and insert into a laythe, start the laythe and put item in container.
Other problems could be solved too: In a greenhouse use a robot arm on wheels to check the state of the plants and moisture of the ground.

The tools at your disposal are robot arms with attachments. You control the robot arm with a simple programming language.
The language allows you to abstract handy methods into functions, which can be reused for later problems.


## First requirements:

Menu system.
- Options
- Levels:
  - Solutions:
    Per level you can have multiple solutions (saves).
- Quit

Editor Window:
  - A code editor
  - Syntax highlighting
  - Syntax checking
  - Debug information

Documentation Window:
  - Syntax documentation
  - API documentation on highlight when in editor.

Console Window:
  - Console.log data
  - Display commands as they are executed.

Result Window:
  - A window showing you the expected results and how far you've progressed through the level.
  - Basically a graphical representation of the desired result and the differences.

Tools:
  - RelativeCoordinateFinder:
    A tool to find the relative coordinate of an object to help you with getting a coordinate in the arm' space

Robot arm:
  - 4 joints. rotation at base, hinge at base, hinge at elbow and rotation and hinge at wrist.
  - Grabber

Api:
  - `MoveToCoordinate(Vec3(), velocity)`
  - `MoveJoint(Arm.Joint, angle, angular_velocity)`
  - `GetCoordinates() -> Vec3()`
  - `GetJointAngle(Arm.Joint, angle)`
  - `Grab()`
  - `Release()`

Base API:
  - Vec3 math

Simple Levels:
- 1. Place item in a tray
- 2. Place items from one tray into another tray
- 3. Place items from one tray upside down into another tray
- 4. Place items from one tray into a laythe and return to tray.


## First steps:
  - Build menu with level selection, and creating a solution for the problem.
  - Build robot arm in blender and import to Unity.
  - Build simple editor and console window.
  - Add Robot API
  - Implement objects that can be manipulated by the arm.
  - Add start and win condition.

### Later:
  Add documentation.
  Improve editor
  Add results window

### Future ideas:
  Different attachements, i.e. camera, screwdriver
  Allow robot arm to send commands to different equipment.
