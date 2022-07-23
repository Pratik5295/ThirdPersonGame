using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public int testID;
    public Animator animator;

    public float counter; //Testing updating value

    private void Start()
    {
        animator = this.GetComponent<Animator>();
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
}
