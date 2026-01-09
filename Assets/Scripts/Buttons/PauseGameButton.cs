using DG.Tweening;
using UnityEngine;

public class PauseGameButton : MonoBehaviour
{
    public ParticleSystem buttonParticleSystem;
    
    public void OnClick()
    {
        buttonParticleSystem.Stop();
    }
}
