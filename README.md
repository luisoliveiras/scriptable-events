# Scriptable Events
![GitHub package.json version](https://img.shields.io/github/package-json/v/luisoliveiras/scriptable-events?color=green)

## What is this?
The Scriptable Events are serializable unity events added to a `ScriptableObject`. Create scene independent and reusable events with just a few lines of code.

---
## Installation:
##### On Unity 2018.4:
Download this package to your disk.
Open the package manager on _**Window > Package Manager**_ and select the **+** button and click on the **Add package from disk...** option. Add the ScriptableEvents package.

##### On Unity 2019.1 and above:
Open the project manifest file under the Packages folder and add these lines to the dependencies:
```json
"dependencies": {
  ...
    "com.loophouse.scriptable-events":"https://github.com/luisoliveiras/scriptable-events.git",
  ...
}

```

##### On Unity 2019.3 and above:
Open the package manager on _**Window > Package Manager**_ and select the **+** button and click on the **Add package from git URL...** option.
- Add the ScriptableEvents package from: https://github.com/luisoliveiras/scriptable-events.git

_\** You can also add it from disk if you want, just follow the steps from 2018.4 install guide._

---
## How to Use
#### Events and Listeners:

Create a _scriptable event asset_ from the _**Scriptable Events**_ option on the _**Create**_ menu. With this event you are able to register other _scriptable objects_ to listen to the event from the inspector. You can also create a reference to it in a _MonoBehaviour_ class and trigger the event using the method _Invoke()_ or _Invoke(T parameter)_.

![Scriptable event asset example](https://raw.githubusercontent.com/luisoliveiras/project-images/master/scriptable-events/scriptable_event_example.png)

Add a _ScriptableEventListener_ component of the corresponding event type to your gameobject to be able to register your components' methods as listeners to the event.

![Scriptable event asset example](https://raw.githubusercontent.com/luisoliveiras/project-images/master/scriptable-events/event_listener_examples.png)

You can also create events for your own types just following the examples in the samples folder.

---
## Samples
#### Basic Events and Listeners:

**What:** This sample contains events and listeners to `int`, `float`, `string`, `bool`, `Vector2` and `Vector3`.

**How:** Import the sample and move the scripts to a folder of your preference. The _"Scriptable Events"_ option will become available the Create menu.

![Basic Events and Listeners Example](https://raw.githubusercontent.com/luisoliveiras/project-images/master/scriptable-events/sample_01_use_example.gif)
