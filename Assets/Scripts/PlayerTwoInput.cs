using UnityEngine;

[CreateAssetMenu(menuName = "PlayerOneInput")]
public class PlayerTwoInput : ScriptableObject
{
    public InputManager input;

    public Vector2 movementInput { get; private set; }
    public bool attack { get; private set; }

    private void Awake()
    {
        input = new InputManager();

        input.PlayerTwoControls.Move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        input.PlayerTwoControls.Attack.performed += ctx => attack = ctx.ReadValue<bool>();

    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }
}
