using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000241 RID: 577
public static class MBIOQICLCNO
{
	// Token: 0x06004E8B RID: 20107 RVA: 0x0028E390 File Offset: 0x0028C590
	[DebuggerHidden]
	public static IEnumerator KFKMPKNNMKK(this Animation LNHJPKIQPHD)
	{
		MBIOQICLCNO.IKDFPHHEBQF ikdfphhebqf = new MBIOQICLCNO.IKDFPHHEBQF();
		ikdfphhebqf.LNHJPKIQPHD = LNHJPKIQPHD;
		return ikdfphhebqf;
	}

	// Token: 0x06004E8C RID: 20108 RVA: 0x0028E3AC File Offset: 0x0028C5AC
	public static IEnumerator KFKMPKNNMKK(this Animation LNHJPKIQPHD, string CKDGKCFKJBG)
	{
		LNHJPKIQPHD.Stop();
		LNHJPKIQPHD.PlayQueued(CKDGKCFKJBG);
		yield return LNHJPKIQPHD.KFKMPKNNMKK();
		return 1;
		yield break;
	}
}
