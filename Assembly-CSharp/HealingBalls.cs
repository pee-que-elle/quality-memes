using System;
using UnityEngine;

// Token: 0x020001FA RID: 506
public class HealingBalls : MonoBehaviour
{
	// Token: 0x0600426C RID: 17004 RVA: 0x0020B998 File Offset: 0x00209B98
	public void Show(int amount)
	{
		if (amount > 6)
		{
			amount = 6;
		}
		base.CancelInvoke("Hide");
		for (int i = 0; i < amount; i++)
		{
			this.Balls[i].SetActive(true);
		}
		base.Invoke("Hide", 3.5f);
	}

	// Token: 0x0600426D RID: 17005 RVA: 0x0020B9E4 File Offset: 0x00209BE4
	public void Hide()
	{
		for (int i = 0; i < 6; i++)
		{
			this.Balls[i].SetActive(false);
		}
	}

	// Token: 0x04000E73 RID: 3699
	public GameObject[] Balls;
}
