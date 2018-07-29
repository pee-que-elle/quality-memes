using System;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000191 RID: 401
public class Billboard : MonoBehaviour
{
	// Token: 0x06003230 RID: 12848 RVA: 0x00180840 File Offset: 0x0017EA40
	private void Start()
	{
		this.Map = MCNLIHMMLCF.QOQONHOOLNE;
		this.Quad = base.GetComponent<Renderer>();
		if (this.canDisable)
		{
			this.Quad.enabled = false;
		}
		base.transform.HIKEIBKLDOQ(new Vector3(3f, 3f, 3f));
		base.transform.eulerAngles = new Vector3(45f, 0f, 0f);
	}

	// Token: 0x06003231 RID: 12849 RVA: 0x001808B8 File Offset: 0x0017EAB8
	private void LateUpdate()
	{
		if (this.canDisable && this.Map)
		{
			if (this.Map.JEMKIKEMFPB != GameDayTime.Night)
			{
				if (this.Map.JEMKIKEMFPB != GameDayTime.Evening)
				{
					if (this.Quad.enabled)
					{
						this.Quad.enabled = false;
						return;
					}
					return;
				}
			}
			if (!this.Quad.enabled)
			{
				this.Quad.enabled = true;
			}
		}
	}

	// Token: 0x04000B99 RID: 2969
	public MCNLIHMMLCF Map;

	// Token: 0x04000B9A RID: 2970
	private Renderer Quad;

	// Token: 0x04000B9B RID: 2971
	public bool canDisable = true;
}
