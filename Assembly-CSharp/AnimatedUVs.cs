using System;
using UnityEngine;

// Token: 0x02000135 RID: 309
public class AnimatedUVs : MonoBehaviour
{
	// Token: 0x060024AD RID: 9389 RVA: 0x00013720 File Offset: 0x00011920
	private void Start()
	{
		this.rend = base.GetComponent<Renderer>();
	}

	// Token: 0x060024AE RID: 9390 RVA: 0x000EF258 File Offset: 0x000ED458
	private void Update()
	{
		this.offset = Time.time * this.scrollSpeed;
		if (!this.DifferentAxis)
		{
			this.rend.material.SetTextureOffset("_MainTex", new Vector2(0f, this.offset));
		}
		else
		{
			this.rend.material.SetTextureOffset("_MainTex", new Vector2(this.offset, 0f));
		}
	}

	// Token: 0x040007DA RID: 2010
	public float scrollSpeed = 0.5f;

	// Token: 0x040007DB RID: 2011
	public bool DifferentAxis;

	// Token: 0x040007DC RID: 2012
	public Renderer rend;

	// Token: 0x040007DD RID: 2013
	private float offset;
}
