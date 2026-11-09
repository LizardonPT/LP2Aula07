using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    private void Start()
    {
        // Subscribe to the KeyPress event from EventMaster
        EventMaster eventMaster = GetComponent<EventMaster>();
        eventMaster.KeyPress.AddListener(PrintOnConsole);
    }

    private void PrintOnConsole(char key)
    {
        Debug.Log($"Key Pressed: {key}");
    }
}
