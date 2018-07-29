using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000137 RID: 311
public class AnimateServerRack : MonoBehaviour
{
	// Token: 0x060024B5 RID: 9397 RVA: 0x000EF470 File Offset: 0x000ED670
	private void Start()
	{
		if (this.randomFPS)
		{
			this.framesPerSecond = 1.5f + UnityEngine.Random.Range(0f, 2f);
		}
		this.size = 1f / this.columns;
		this.rend = base.GetComponent<Renderer>();
		base.StartCoroutine(this.updateTiling());
	}

	// Token: 0x060024B6 RID: 9398 RVA: 0x000EF4CC File Offset: 0x000ED6CC
	[DebuggerHidden]
	private IEnumerator updateTiling()
	{
		AnimateServerRack.GOEJIBOBKDF goejibobkdf = new AnimateServerRack.GOEJIBOBKDF();
		goejibobkdf.QNDQJMNKFNN = this;
		return goejibobkdf;
	}

	// Token: 0x040007E7 RID: 2023
	public bool randomFPS = true;

	// Token: 0x040007E8 RID: 2024
	public float framesPerSecond = 10f;

	// Token: 0x040007E9 RID: 2025
	public float columns = 4f;

	// Token: 0x040007EA RID: 2026
	public Renderer rend;

	// Token: 0x040007EB RID: 2027
	public int MaterialID = 1;

	// Token: 0x040007EC RID: 2028
	private int index;

	// Token: 0x040007ED RID: 2029
	private float size = 1f;
}
