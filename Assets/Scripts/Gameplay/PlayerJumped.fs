
namespace Platformer.Gameplay

open Platformer.Core
open Platformer.Mechanics

/// <summary>
/// Fired when the player performs a Jump.
/// </summary>
type PlayerJumped() =
    inherit Simulation.Event<PlayerJumped>()

    // Используем auto-property для имитации публичного поля C#
    member val player : PlayerController = null with get, set

    override this.Execute() =
        Debug.Log("Jump event executed from F#!")
