using UnityEngine;

[CreateAssetMenu (fileName = "Item", menuName = "Create new item")]
public class Item : ScriptableObject
{
    [field: SerializeField] public string itemName { get; private set; }
    
    [field: SerializeField] public Sprite itemSprite { get; private set; }
    
    [field: SerializeField] public Color itemRarityColor { get; private set; }
    
    [field: SerializeField] public int itemRarityPercent { get; private set; }
}
