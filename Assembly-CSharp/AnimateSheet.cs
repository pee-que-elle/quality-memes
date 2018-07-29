using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000139 RID: 313
public class AnimateSheet : MonoBehaviour
{
	// Token: 0x060024ED RID: 9453 RVA: 0x0001381F File Offset: 0x00011A1F
	private void Start()
	{
		this.rend = base.GetComponent<Renderer>();
		base.StartCoroutine(this.updateTiling());
	}

	// Token: 0x060024EE RID: 9454 RVA: 0x000EFC04 File Offset: 0x000EDE04
	[DebuggerHidden]
	private IEnumerator updateTiling()
	{
		AnimateSheet.HPNBIOQQNOF hpnbioqqnof = new AnimateSheet.HPNBIOQQNOF();
		hpnbioqqnof.QNDQJMNKFNN = this;
		return hpnbioqqnof;
	}

	// Token: 0x040007F3 RID: 2035
	public float framesPerSecond = 10f;

	// Token: 0x040007F4 RID: 2036
	public float columns = 4f;

	// Token: 0x040007F5 RID: 2037
	public Renderer rend;

	// Token: 0x040007F6 RID: 2038
	public int MaterialID = 1;

	// Token: 0x040007F7 RID: 2039
	private int index;

	// Token: 0x040007F8 RID: 2040
	public float size = 0.125f;
}
