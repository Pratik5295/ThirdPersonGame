using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementController : MonoBehaviour
{
    public int testID;
    public Animator animator;

    public float counter; //Testing updating value

    [SerializeField] private CharacterController characterController;
    [SerializeField] private StarterAssetsInputs _input;

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
    private PlayerInput _playerInput;
#endif

    private void Start()
    {
        animator = this.GetComponent<Animator>();
        characterController = this.GetComponent<CharacterController>();
        _input = GetComponent<StarterAssetsInputs>();
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
        _playerInput = GetComponent<PlayerInput>();
#endif

        AssignAnimIDs();
    }

    void AssignAnimIDs()
    {
        testID = Animator.StringToHash("test");
    }

    void IncreaseCounterTimer()
    {
        counter += Time.deltaTime;
    }

    void ChangeAnimation()
    {
        if(counter > 9)
        {
            counter = 0f;
            Debug.Log("Reset");
        }
        animator.SetFloat(testID, counter);
    }
    private void Update()
    {
        ChangeAnimation();
    }
    private void FixedUpdate()
    {
        IncreaseCounterTimer();
        
    }

    private void Move()
    {
        
    }
}
