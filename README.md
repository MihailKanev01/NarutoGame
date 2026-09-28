# NarutoGame

A Unity third-person character prototype centered on camera-relative movement and a smooth follow camera.

## Overview

The project contains a Unity scene with a Naruto character model and custom C# scripts for player movement and camera control.

The current implementation focuses on:

- Camera-relative player movement.
- Smooth character rotation towards the movement direction.
- Animator state updates for running.
- CharacterController-based locomotion.
- Third-person camera follow behaviour.
- Mouse-controlled camera rotation with vertical limits.

## Technical focus

**Engine:** Unity 6  
**Unity version:** 6000.0.41f1  
**Language:** C#

Main gameplay scripts:

- `Assets/Scripts/PlayerMovement.cs`
- `Assets/Scripts/CameraFollow.cs`

The repository also contains the Unity Input System action asset and project settings.

## How it works

Player movement is calculated from horizontal and vertical input, then rotated relative to the camera direction. The character smoothly turns toward the target direction while the `CharacterController` handles locomotion.

The camera follows a target transform and uses mouse input for horizontal orbiting and clamped vertical rotation.

## Run locally

1. Clone the repository.
2. Open the project with Unity 6 / editor version `6000.0.41f1`.
3. Open `Assets/Scenes/SampleScene.unity`.
4. Press **Play**.

## Repository structure

```text
Assets/
├── Models/
├── Scripts/
│   ├── CameraFollow.cs
│   └── PlayerMovement.cs
├── Scenes/
└── InputSystem_Actions.inputactions
ProjectSettings/
└── ProjectVersion.txt
```

## Project status

This repository is a focused Unity gameplay prototype. It is useful as a compact example of third-person movement, camera control and basic animation integration.

## License

See [LICENSE](LICENSE).
