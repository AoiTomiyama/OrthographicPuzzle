using TMPro;
using UnityEngine;

public abstract class UIStatusRowBase : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI statusNameText;

    public virtual void RenderUIByData(UIElementDataBase data)
    {
        statusNameText.text = data.StatusName;
    }
}

public enum UIStatusRowType
{
    None,
    Text,
    Gauge,
    Storage,
}