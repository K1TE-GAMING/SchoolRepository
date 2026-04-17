using UnityEngine;
using UnityEngine.UI;

public class Playbutton : MonoBehaviour
{
    public GameObject Explosion;

    public void ClickExplode()
    {
        if (Explosion == null)
        {
            Debug.LogError("Explosion GameObject is not assigned in the inspector.");
            return;
        }

        //find the explosion particle system in the children of the button
        ParticleSystem[] allSystems = Explosion.GetComponentsInChildren<ParticleSystem>(true);

        //pressing button will cause the explosion to happen
        foreach (ParticleSystem ps in allSystems)
        {
            ps.Clear();
            ps.Play();
        }
    }
}
