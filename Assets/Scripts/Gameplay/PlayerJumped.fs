
namespace Platformer.Gameplay

open Platformer.Core
open Platformer.Mechanics

/// <summary>
/// Fired when the player performs a Jump.
/// </summary>
type PlayerJumped() =
    inherit Simulation.Event<PlayerJumped>()

    member val player : PlayerController = null with get, set

    override this.Execute() =
        Debug.Log("Jump event executed from F#!")
        // if this.player.audioSource <> null && this.player.jumpAudio <> null then
            // this.player.audioSource.PlayOneShot(this.player.jumpAudio)

