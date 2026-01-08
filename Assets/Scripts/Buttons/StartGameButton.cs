using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    public ParticleSystem particleSystem;
    
    public void OnClick()
    {
        particleSystem.Play();
    }
}
