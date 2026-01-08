using DG.Tweening;
using UnityEngine;

public class PauseGameButton : MonoBehaviour
{
    public ParticleSystem particleSystem;
    
    public void OnClick()
    {
        particleSystem.Stop();
    }
}
