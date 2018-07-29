using System;
using UnityEngine;

// Token: 0x0200013B RID: 315
public class AnimateUVs2 : MonoBehaviour
{
	// Token: 0x06002541 RID: 9537 RVA: 0x00013875 File Offset: 0x00011A75
	private void Start()
	{
		this.rend = base.GetComponent<Renderer>();
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x000F0C28 File Offset: 0x000EEE28
	private void Update()
	{
		this.offset = Time.time * this.scrollSpeed;
		if (!this.DifferentAxis)
		{
			this.rend.materials[this.materialID].SetTextureOffset("_MainTex", new Vector2(0f, this.offset));
		}
		else
		{
			this.rend.materials[this.materialID].SetTextureOffset("_MainTex", new Vector2(this.offset, 0f));
		}
	}

	// Token: 0x040007FE RID: 2046
	public Renderer rend;

	// Token: 0x040007FF RID: 2047
	public int materialID;

	// Token: 0x04000800 RID: 2048
	public float scrollSpeed = 0.5f;

	// Token: 0x04000801 RID: 2049
	public bool DifferentAxis;

	// Token: 0x04000802 RID: 2050
	private float offset;
}
