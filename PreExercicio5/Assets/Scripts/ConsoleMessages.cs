using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    private EventMaster eventMaster;

    private void Awake()
    {
        // Subscribe to the KeyPress event from EventMaster
        eventMaster = GetComponent<EventMaster>();
    }

    private void OnEnable()
    {
        eventMaster.KeyPress += PrintOnConsole;
    }

    private void OnDisable()
    {
        eventMaster.KeyPress -= PrintOnConsole;
    }

    private void PrintOnConsole(char key)
    {
        Debug.Log($"Key Pressed: {key}");
    }
}
