using UnityEngine;

public class ShowDescription : MonoBehaviour
{
    [SerializeField] private GameObject textMeshPro;
    [SerializeField] private Animator popUpAnimation;

    private void OnTriggerEnter(Collider other)
    {
        
        popUpAnimation.SetBool("PopUp", true);
        popUpAnimation.SetBool("PopDown", false);


    }

    private void OnTriggerExit(Collider other)
    {
        popUpAnimation.SetBool("PopDown",true);

        popUpAnimation.SetBool("PopUp", false);


    }


}
