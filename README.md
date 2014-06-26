# GlobalGameObject

Easy to use unity globals without GameObject.find

## Why?
Sometimes you need global access to a Component in Unity. This provides a common interface to those instances, without having to pollute the global class instance with singleton instances, or the accessing class with a GameObject.Find.

## How?
Attach a GlobalGameObjectSetter to your GameObject that has the Component you need. Assign the Component to the GlobalComponent variable. Access your Component through GGO< T >.Instance. 

If an GGO< T >.Instance doesn't exist, it will automtically be created.

Make sure that GlobalGameObjectSetter is first in your execution order.

