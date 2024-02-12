using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolControl : MonoBehaviour
{
    public Transform toolHolder;
    public Tool currentTool;


    // Start is called before the first frame update
    void Start()
    {
        GetCurrentTool();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(currentTool != null)
            {
                currentTool.Activate();
            }
            else
            {
                Debug.Log("No tool equipped");
            }
        }
    }

    public void GetCurrentTool()
    {
        currentTool = toolHolder.GetComponentInChildren<Tool>();
    }

    public void UpdateTool(GameObject toolPrefab)
    {
        if(toolPrefab.GetComponent<Tool>() != null)
        {
            Destroy(currentTool);
            currentTool = Instantiate(toolPrefab, toolHolder.position, toolHolder.rotation).GetComponent<Tool>();
            currentTool.gameObject.transform.parent = toolHolder;
        }
        else
        {
            Debug.Log($"No Tool Script detected on {toolPrefab.name}");
        }

    }
}
