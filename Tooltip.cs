using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    RectTransform rect;

    public TextMeshProUGUI headerField;
    public TextMeshProUGUI contentField;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        transform.position = Input.mousePosition + new Vector3(15, 15);
    }

    public void SetText(string header, string content)
    {
        headerField.text = header;
        contentField.text = content;
    }
}
