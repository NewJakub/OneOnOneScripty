using UnityEngine;
using UnityEngine.Networking;

#pragma warning disable CS0618 // Type or member is obsolete
public class PlayerSetup : NetworkBehaviour
#pragma warning restore CS0618 // Type or member is obsolete
{
    
    [SerializeField]
    Behaviour[] componentsToDisable;

    Camera sceneCamera;


    void Start()
    {
        if (!isLocalPlayer)
        {
             for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
        }
        else
        {
            sceneCamera = Camera.main;
            if(sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
        }

    }

    void OnDisable()
    {
        if(sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
    }

   
}
  