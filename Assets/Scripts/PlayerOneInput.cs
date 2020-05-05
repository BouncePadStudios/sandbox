using UnityEngine;

[CreateAssetMenu(menuName ="PlayerOneInput")]
public class PlayerOneInput : ScriptableObject
{
    public InputManager input;

    public Vector2 movementInput { get; private set; }
    public bool attack { get; private set; }

    private void Awake()
    {
        input = new InputManager();

        input.PlayerOneControls.Move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        input.PlayerOneControls.Attack.performed += ctx => attack = ctx.ReadValue<bool>();

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

