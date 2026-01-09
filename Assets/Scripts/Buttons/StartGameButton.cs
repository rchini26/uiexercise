using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    public ParticleSystem buttonParticleSystem;
    
    public void OnClick()
    {
        buttonParticleSystem.Play();
    }
}
