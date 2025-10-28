# in-class-activities
## Devlogs
### W1
Hello world!
About the game itself, I really liked the cute, calm, and relaxing vibe the visuals gave. Regarding the activity, I struggled a lot. As someone who used Github and Unity for the first time, having a lot of tabs up and going back and forth among them kind of made it confusing of where I needed to go for the next step on the instructions. I did succeed in setting up Unity, Github, and my itch.io page. I have successfully navigated around Unity as well. However, I got stuck in making the cat walk around. I did seek help from one of the LA and went over the 'add component' step, but we couldn't solve the problem on time.
### W2
1. The r, g, and b variables are floats instead of ints, bools, or strings because the varaible is in fractional numbers. 2. The _bounce variable is an int because it shows the number of bounces of the ball, thus only comes out as an integer. 3. There was an error after Step 4 because the line was missing a semicolon (;).
### W3
Group discussion [#14]: To set the light brightness based on the player's sanity level, the parameter would be the player's sanity level as a float and the return type would be void since the function changes the lighting directly and doesn't run data.
Monobehaviour Coding:
1. Metaphor: Classes are skins and compoenets are skinwalkers. The skin tells skinswalkers what to do. Methods changes the behaviors. Member variables are their traits.
2. There are no upper limits in how bright the balls can change in color.  
### W4
[Group #14]
1. "_isGrounded" is a member variable, and the type is boolean. It keeps track of whether the cat is standing on the ground.
2. This line is calling the "GetKeyDown()" method from the input component, with the parameter "KeyCode.Space" This chcekcs if the spacebar was pressed by the player and if _isGrounded(boolean) is true.
3. The line checks if the sapce key was pressed, and if the player is grounded, the code sets "_isGrounded" to false.

1. We added rigidbodies to the cat and the ball and checked Is Trigger on the goal.
2. We didn't have the rigidbody on the cat. And, this was only my problem, but I had the cat rotaing, so I froze the rotation under the constraint.

### W5
Question: What is the difference between using 'GetComponent<>()' and exposing a [SerializeField] reference in the Insepctor? 
Answer: 'GetComponent<>()' finds another component through code while the game is running. [SerializeField] lets you manually link a component or object in the Unity Inspector before the game starts.

1. The DeerW5 class needs two main variables. First, it needs a 'Transform_target' variable to represent the GameObject that the deer will walk toward. This should be serialized so that I can assign it manually in the Inspector, and it must be a Transform instead of a Vector3 beacuse a Transform holds position, rotation, and scale information. Second, the class needs a private 'NavMeshAgent _agent' variable that I can retrieve with 'GetComponent<NavMeshAgent>()' from the DeerGameObject.
2. For methods, the calss only needs 'Start(),' which is a Unity-provided method that automatically runs once when the game begins. I'll use 'Start()' to make sure the NavMeshAgent is set up before the gameplay starts. I don't need to use 'Update()' unless the target is supposed to move continuously.
3. In the 'Start()' method, the deer wil get its NavMeshAgent component using 'GetComponent<>,' check whether the '_target' variable has been assgined, and if so, call '_agent.SetDestination(_target.position)' to make the deer walk toward the assigned mushroom on the NavMesh. The 'SetDestination()' method is what tells Unity's navigation systme where the NavMeshAgent should move. 

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
