using System.Collections.Generic;
using QFramework;
using UnityEngine;
using Utils;

//May be use IBlock with BlockSolid and BlockLiquid as father?

public interface IBlockSolid
{
    public Rigidbody GetRigidbody();

    public BoxCollider GetSolidCollider();
}

public interface IBlockLiquid
{
    public void flow();
    public void updateTexture(); 
}

public enum BlockType
{
    Dirt,
    Stone,
    Water
}

public abstract class Block
{
    private BindableProperty<(int, int, int)> location;

    public abstract bool onGenerate(int x, int y, int z);
    public abstract bool onDestory(int x, int y, int z);
}

public class DirtBlock : Block, IBlockSolid
{

    
    private Rigidbody body;
    private BoxCollider collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public BindableProperty<(int, int, int)> position { get; }
    public override bool onGenerate(int x, int y, int z)
    {
        return true;
    }

    public override bool onDestory(int x, int y, int z)
    {
        return true;
    }

    public Rigidbody GetRigidbody()
    {
        return body;
    }

    public BoxCollider GetSolidCollider()
    {
        return collider;
    }
}
