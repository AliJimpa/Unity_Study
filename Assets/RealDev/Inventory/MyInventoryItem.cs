using RealMethod;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItem", menuName = "Mustard/Inventory/InventoryItem", order = 1)]
public class MyInventoryItem : DataAsset, IInventoryItem
{
    [Header("Item")]
    [SerializeField]
    protected string title;
    public string NameID => title;
    [SerializeField]
    protected Texture2D _icon;
    public Texture2D Icon => _icon;
    // Functions
    public Sprite GetSpriteIcon()
    {
        return GetSpriteIcon(new Rect(0, 0, _icon.width, _icon.height),
                new Vector2(0.5f, 0.5f)
            );
    }
    public Sprite GetSpriteIcon(Rect rect, Vector2 pivot)
    {
        if (_icon != null)
        {
            return Sprite.Create(_icon, rect, pivot);
        }
        else
        {
            Debug.LogWarning("ItemAsset: Icon is not assigned for item '" + title + "'.");
            return null;
        }
    }
    public PrimitiveAsset GetAsset()
    {
        return this;
    }

    private Inventory myinventory;

    public void Cahanged(int quantity)
    {
    }
    public bool CanChange(bool IsAdded)
    {
        return true;
    }
    public bool CanDropp(Inventory owner)
    {
        return true;
    }
    public bool CanPickUp(Inventory owner)
    {
        return true;
    }
    public void Dropped(Inventory owner)
    {

    }
    public void PickedUp(Inventory owner, int quantity)
    {
        myinventory = owner;
    }


    public IResource GetResourceProvider()
    {
        return myinventory != null ? myinventory.GetResourceProvider(this) : null;
    }


#if UNITY_EDITOR
    void IItem.ChangeItemName(string NewName)
    {
        title = NewName;
    }
    // public override void OnEditorPlay()
    // {
    //     base.OnEditorPlay();
    // }
#endif

}
