using UnityEngine;

public class LinkCapsuleColiderToCaracacterControler : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private CapsuleCollider capsuleCollider;

    void Update()
    {
        capsuleCollider.center = characterController.center;
        capsuleCollider.radius = characterController.radius;
        capsuleCollider.height = characterController.height;
    }
}
