using System;
using UnityEngine;

// Token: 0x0200031F RID: 799
public class PresentFXPlayer : MonoBehaviour
{
	// Token: 0x06006AEF RID: 27375 RVA: 0x00028421 File Offset: 0x00026621
	public void PlayIdleFX()
	{
		this.PlayFX(this.idleFX);
	}

	// Token: 0x06006AF0 RID: 27376 RVA: 0x0002842F File Offset: 0x0002662F
	public void PlayBreathFX()
	{
		this.PlayFX(this.breathFX);
	}

	// Token: 0x06006AF1 RID: 27377 RVA: 0x0002843D File Offset: 0x0002663D
	public void PlayJumpFX()
	{
		this.PlayFX(this.jumpFX);
	}

	// Token: 0x06006AF2 RID: 27378 RVA: 0x0002844B File Offset: 0x0002664B
	public void PlayOpenFX()
	{
		this.PlayFX(this.openFX);
	}

	// Token: 0x06006AF3 RID: 27379 RVA: 0x00028459 File Offset: 0x00026659
	public void PlayExplodeFX()
	{
		this.PlayFX(this.explodeFX);
	}

	// Token: 0x06006AF4 RID: 27380 RVA: 0x0034A254 File Offset: 0x00348454
	private void PlayFX(FX[] fxs)
	{
		if (fxs == null || fxs.Length == 0)
		{
			return;
		}
		if (this.lastFX == fxs[0])
		{
			return;
		}
		this.lastFX = fxs[0];
		foreach (FX fx in fxs)
		{
			if (!(fx.fx == null))
			{
				ParticleSystem particleSystem = UnityEngine.Object.Instantiate<ParticleSystem>(fx.fx);
				particleSystem.transform.SetParent(base.transform);
				particleSystem.transform.rotation = particleSystem.transform.rotation * base.transform.rotation;
				particleSystem.transform.localPosition = fx.Offset;
				particleSystem.Play();
			}
		}
	}

	// Token: 0x04001680 RID: 5760
	[SerializeField]
	private FX[] idleFX;

	// Token: 0x04001681 RID: 5761
	[SerializeField]
	private FX[] breathFX;

	// Token: 0x04001682 RID: 5762
	[SerializeField]
	private FX[] jumpFX;

	// Token: 0x04001683 RID: 5763
	[SerializeField]
	private FX[] openFX;

	// Token: 0x04001684 RID: 5764
	[SerializeField]
	private FX[] explodeFX;

	// Token: 0x04001685 RID: 5765
	private FX lastFX;
}
