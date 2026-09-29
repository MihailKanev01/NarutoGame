
# NarutoGame

A Unity 6 third-person gameplay prototype focused on player locomotion, character rotation and camera control.

## Overview

The project contains a compact third-person controller built with Unity's CharacterController and Input System.

Movement is calculated relative to the camera, while the character smoothly rotates towards the requested movement direction.

## Technical Focus

- Camera-relative player movement.
- Smooth character rotation.
- CharacterController-based locomotion.
- Animator state updates.
- Third-person camera follow behaviour.
- Mouse-controlled camera rotation with vertical limits.
- Unity Input System integration.

## Stack

**Engine:** Unity 6  
**Version:** 6000.0.41f1  
**Language:** C#

## Main Scripts

- Assets/Scripts/PlayerMovement.cs
- Assets/Scripts/CameraFollow.cs

## Run Locally

1. Clone the repository.
2. Open the project with Unity 6000.0.41f1.
3. Open Assets/Scenes/SampleScene.unity.
4. Press **Play**.

## Repository Structure

    Assets/
    ├── Models/
    ├── Scripts/
    │   ├── CameraFollow.cs
    │   └── PlayerMovement.cs
    ├── Scenes/
    └── InputSystem_Actions.inputactions
    ProjectSettings/
    └── ProjectVersion.txt

## Project Status

A focused gameplay prototype intended to demonstrate third-person movement, camera control and basic animation integration.

## License

See [LICENSE](LICENSE).
