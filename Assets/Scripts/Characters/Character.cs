using UnityEngine;

/// <summary>
/// Mainly used as a data container to define a character. This script is attached to the prefab
/// (found in the Bundles/Characters folder) and is to define all data related to the character.
/// </summary>
public class Character : MonoBehaviour
{
    public string characterName;
    public int cost;
	public int premiumCost;

    public Animator animator;
	public Sprite icon;

	[Header("Sound")]
	public AudioClip jumpSound;
	public AudioClip hitSound;
	public AudioClip deathSound;
}
