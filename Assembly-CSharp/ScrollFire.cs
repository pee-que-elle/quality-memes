using System;
using UnityEngine;

// Token: 0x02000275 RID: 629
public class ScrollFire : MonoBehaviour
{
	// Token: 0x06005678 RID: 22136 RVA: 0x000219C1 File Offset: 0x0001FBC1
	private void Start()
	{
		if (base.GetComponent<SkinnedMeshRenderer>())
		{
			this.Fire = base.GetComponent<SkinnedMeshRenderer>().material;
		}
	}

	// Token: 0x06005679 RID: 22137 RVA: 0x002C5654 File Offset: 0x002C3854
	private void LateUpdate()
	{
		this.uvOffset += this.fsUV * Time.deltaTime * 2f;
		this.uvOffset2 += this.fsUV2 * Time.deltaTime * 2f;
		if (this.Fire != null)
		{
			this.Fire.SetTextureOffset("_Texture0", this.uvOffset);
			if (this.ScrollTexture2)
			{
				this.Fire.SetTextureOffset("_Texture1", this.uvOffset2);
			}
		}
	}

	// Token: 0x040012E4 RID: 4836
	public Vector2 fsUV = new Vector2(0f, 0.6f);

	// Token: 0x040012E5 RID: 4837
	public Vector2 fsUV2 = new Vector2(0f, 0.6f);

	// Token: 0x040012E6 RID: 4838
	public Vector2 uvOffset = Vector2.zero;

	// Token: 0x040012E7 RID: 4839
	public Vector2 uvOffset2 = Vector2.zero;

	// Token: 0x040012E8 RID: 4840
	public Material Fire;

	// Token: 0x040012E9 RID: 4841
	public bool ScrollTexture2;
}
