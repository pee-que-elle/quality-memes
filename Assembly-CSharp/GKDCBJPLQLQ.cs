using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200011E RID: 286
[AddComponentMenu("NGUI/UI/Root")]
[ExecuteInEditMode]
public class GKDCBJPLQLQ : MonoBehaviour
{
	// Token: 0x06002084 RID: 8324 RVA: 0x00011BC5 File Offset: 0x0000FDC5
	protected virtual void DCJQFJOICGQ()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x00011BD3 File Offset: 0x0000FDD3
	private void Update()
	{
		this.KQLOHLEOQIB(true);
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x00011BDC File Offset: 0x0000FDDC
	protected virtual void OQOKEHJOCDK()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Add(this);
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x00011BE9 File Offset: 0x0000FDE9
	public GKDCBJPLQLQ.OCEIGEJIQLI CHDBFCQQFOC()
	{
		if (this.JJLIDHKCCJM)
		{
			if (this.IOJPPEMFHQF)
			{
				return GKDCBJPLQLQ.OCEIGEJIQLI.Fill;
			}
			return (GKDCBJPLQLQ.OCEIGEJIQLI)8;
		}
		else
		{
			if (this.IOJPPEMFHQF)
			{
				return (GKDCBJPLQLQ.OCEIGEJIQLI)5;
			}
			return GKDCBJPLQLQ.OCEIGEJIQLI.Fit;
		}
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x00011BC5 File Offset: 0x0000FDC5
	protected virtual void FBDGLDFKODD()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x00011BDC File Offset: 0x0000FDDC
	protected virtual void KPKPCBGJIDM()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Add(this);
	}

	// Token: 0x0600208A RID: 8330 RVA: 0x000D5C40 File Offset: 0x000D3E40
	public void KQLOHLEOQIB(bool NMOPFIDPGDB = true)
	{
		if (this.BLLEFKOLKLP != null)
		{
			float num = (float)this.IINCKPHJGPC;
			if (num > 0f)
			{
				float num2 = 2f / num;
				Vector3 localScale = this.BLLEFKOLKLP.localScale;
				if (Mathf.Abs(localScale.x - num2) > 1.401298E-45f || Mathf.Abs(localScale.y - num2) > 1.401298E-45f || Mathf.Abs(localScale.z - num2) > 1.401298E-45f)
				{
					this.BLLEFKOLKLP.localScale = new Vector3(num2, num2, num2);
					if (NMOPFIDPGDB)
					{
						base.BroadcastMessage("UpdateAnchors", SendMessageOptions.DontRequireReceiver);
					}
				}
			}
		}
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x000D5CE4 File Offset: 0x000D3EE4
	public static void PJEILKLPHQB(string OELBCGGGCIP, object ODCOBDIHEQB)
	{
		if (ODCOBDIHEQB == null)
		{
			Debug.LogError("Shed Skin");
		}
		else
		{
			int i = 0;
			int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
				if (gkdcbjplqlq != null)
				{
					gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, ODCOBDIHEQB, SendMessageOptions.DontRequireReceiver);
				}
				i += 0;
			}
		}
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x000D5D38 File Offset: 0x000D3F38
	protected virtual void GBGEGKHDQKB()
	{
		IPPMCDQNMML componentInChildren = base.GetComponentInChildren<IPPMCDQNMML>();
		if (componentInChildren != null)
		{
			Debug.LogWarning("roughskin", componentInChildren);
			Camera component = componentInChildren.gameObject.GetComponent<Camera>();
			componentInChildren.enabled = false;
			if (component != null)
			{
				component.orthographicSize = 419f;
			}
		}
		else
		{
			this.BBEPBKCGLIM(true);
		}
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x00011BDC File Offset: 0x0000FDDC
	protected virtual void IIKNHGOMQEG()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Add(this);
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x000D5D90 File Offset: 0x000D3F90
	public GKDCBJPLQLQ.KHMJPIFKCNE QQEINHMJEPJ()
	{
		GKDCBJPLQLQ.KHMJPIFKCNE kmhncclcddp = this.KMHNCCLCDDP;
		if (kmhncclcddp == (GKDCBJPLQLQ.KHMJPIFKCNE)7)
		{
			return GKDCBJPLQLQ.KHMJPIFKCNE.Flexible;
		}
		return kmhncclcddp;
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x000D5DAC File Offset: 0x000D3FAC
	public float OFECKJIIIIF(int DFKQMMIQDOO)
	{
		DFKQMMIQDOO = Mathf.Max(5, DFKQMMIQDOO);
		if (this.JCLPPCOHQEI == GKDCBJPLQLQ.KHMJPIFKCNE.Constrained)
		{
			return (float)this.ILQIODGPBCD() / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO < this.FBPMGLPJNDP)
		{
			return (float)this.FBPMGLPJNDP / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO > this.GQDEIICHJPC)
		{
			return (float)this.GQDEIICHJPC / (float)DFKQMMIQDOO;
		}
		return 850f;
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x000D5E04 File Offset: 0x000D4004
	public int CBENPIBLJLQ()
	{
		if (this.BFMEKNIHJHH() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI oceigejiqli = this.MJCHMJFBNCB();
		if (oceigejiqli == (GKDCBJPLQLQ.OCEIGEJIQLI)5)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.Fill)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli != GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x06002091 RID: 8337 RVA: 0x00011C0A File Offset: 0x0000FE0A
	protected virtual void LBJMPMHKMEL()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Remove(this);
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x000D5F74 File Offset: 0x000D4174
	protected virtual void BBGHCDGEDEJ()
	{
		IPPMCDQNMML componentInChildren = base.GetComponentInChildren<IPPMCDQNMML>();
		if (componentInChildren != null)
		{
			Debug.LogWarning("Volt Absorb", componentInChildren);
			Camera component = componentInChildren.gameObject.GetComponent<Camera>();
			componentInChildren.enabled = true;
			if (component != null)
			{
				component.orthographicSize = 983f;
			}
		}
		else
		{
			this.GEFMOEGEGGQ(true);
		}
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06002093 RID: 8339 RVA: 0x000D5FCC File Offset: 0x000D41CC
	public GKDCBJPLQLQ.KHMJPIFKCNE JCLPPCOHQEI
	{
		get
		{
			GKDCBJPLQLQ.KHMJPIFKCNE kmhncclcddp = this.KMHNCCLCDDP;
			if (kmhncclcddp == GKDCBJPLQLQ.KHMJPIFKCNE.ConstrainedOnMobiles)
			{
				return GKDCBJPLQLQ.KHMJPIFKCNE.Flexible;
			}
			return kmhncclcddp;
		}
	}

	// Token: 0x06002094 RID: 8340 RVA: 0x000D5FE8 File Offset: 0x000D41E8
	public GKDCBJPLQLQ.KHMJPIFKCNE JIIKBENEFPQ()
	{
		GKDCBJPLQLQ.KHMJPIFKCNE kmhncclcddp = this.KMHNCCLCDDP;
		if (kmhncclcddp == GKDCBJPLQLQ.KHMJPIFKCNE.ConstrainedOnMobiles)
		{
			return GKDCBJPLQLQ.KHMJPIFKCNE.Constrained;
		}
		return kmhncclcddp;
	}

	// Token: 0x06002095 RID: 8341 RVA: 0x000D6004 File Offset: 0x000D4204
	public GKDCBJPLQLQ.KHMJPIFKCNE NGDQOCMKPCG()
	{
		GKDCBJPLQLQ.KHMJPIFKCNE kmhncclcddp = this.KMHNCCLCDDP;
		if (kmhncclcddp == (GKDCBJPLQLQ.KHMJPIFKCNE)3)
		{
			return GKDCBJPLQLQ.KHMJPIFKCNE.Constrained;
		}
		return kmhncclcddp;
	}

	// Token: 0x06002096 RID: 8342 RVA: 0x000D6020 File Offset: 0x000D4220
	public float JCGLMKGEJQG()
	{
		int num = Mathf.RoundToInt(IKBQNBHOJJB.FMDDDQOPBEI.y);
		return (num != -1) ? this.CMPJLKBOPBP(num) : 1074f;
	}

	// Token: 0x06002097 RID: 8343 RVA: 0x000D6054 File Offset: 0x000D4254
	public void BBEPBKCGLIM(bool NMOPFIDPGDB = true)
	{
		if (this.BLLEFKOLKLP != null)
		{
			float num = (float)this.BEBHMIFIFGC();
			if (num > 1502f)
			{
				float num2 = 506f / num;
				Vector3 localScale = this.BLLEFKOLKLP.localScale;
				if (Mathf.Abs(localScale.x - num2) > 822f || Mathf.Abs(localScale.y - num2) > 1338f || Mathf.Abs(localScale.z - num2) > 1692f)
				{
					this.BLLEFKOLKLP.localScale = new Vector3(num2, num2, num2);
					if (NMOPFIDPGDB)
					{
						base.BroadcastMessage("[epic]", SendMessageOptions.DontRequireReceiver);
					}
				}
			}
		}
	}

	// Token: 0x06002098 RID: 8344 RVA: 0x00011BDC File Offset: 0x0000FDDC
	protected virtual void FFBFMBJNGQI()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Add(this);
	}

	// Token: 0x06002099 RID: 8345 RVA: 0x000D60F8 File Offset: 0x000D42F8
	public float NIJOIGBGGPC(int DFKQMMIQDOO)
	{
		DFKQMMIQDOO = Mathf.Max(6, DFKQMMIQDOO);
		if (this.QQDGMEMQOHF() == GKDCBJPLQLQ.KHMJPIFKCNE.Constrained)
		{
			return (float)this.QIEKBBQKDCN() / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO < this.FBPMGLPJNDP)
		{
			return (float)this.FBPMGLPJNDP / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO > this.GQDEIICHJPC)
		{
			return (float)this.GQDEIICHJPC / (float)DFKQMMIQDOO;
		}
		return 149f;
	}

	// Token: 0x0600209A RID: 8346 RVA: 0x000D6150 File Offset: 0x000D4350
	public static float MOJIBBKMLKO(GameObject CGHIENBIHCO)
	{
		GKDCBJPLQLQ gkdcbjplqlq = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(CGHIENBIHCO);
		return (!(gkdcbjplqlq != null)) ? 92f : gkdcbjplqlq.JCGLMKGEJQG();
	}

	// Token: 0x0600209B RID: 8347 RVA: 0x000D617C File Offset: 0x000D437C
	public static void KBLHGOKEJGI(string OELBCGGGCIP)
	{
		int i = 1;
		int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
		while (i < count)
		{
			GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
			if (gkdcbjplqlq != null)
			{
				gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, SendMessageOptions.DontRequireReceiver);
			}
			i++;
		}
	}

	// Token: 0x0600209C RID: 8348 RVA: 0x00011C18 File Offset: 0x0000FE18
	public GKDCBJPLQLQ.OCEIGEJIQLI JECNOKBPFNL()
	{
		if (this.JJLIDHKCCJM)
		{
			if (this.IOJPPEMFHQF)
			{
				return GKDCBJPLQLQ.OCEIGEJIQLI.Fit;
			}
			return (GKDCBJPLQLQ.OCEIGEJIQLI)4;
		}
		else
		{
			if (this.IOJPPEMFHQF)
			{
				return GKDCBJPLQLQ.OCEIGEJIQLI.Fit;
			}
			return GKDCBJPLQLQ.OCEIGEJIQLI.Fill;
		}
	}

	// Token: 0x0600209D RID: 8349 RVA: 0x000D61C0 File Offset: 0x000D43C0
	public int LKGMHOOFCCQ()
	{
		if (this.OLJHKKDBPHD() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI oceigejiqli = this.JECNOKBPFNL();
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.FitWidth)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.FitWidth)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli != GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x0600209E RID: 8350 RVA: 0x00011BD3 File Offset: 0x0000FDD3
	private void JOMCJOMCOIQ()
	{
		this.KQLOHLEOQIB(true);
	}

	// Token: 0x0600209F RID: 8351 RVA: 0x000D6330 File Offset: 0x000D4530
	public void HKJKFNQJLJL(bool NMOPFIDPGDB = true)
	{
		if (this.BLLEFKOLKLP != null)
		{
			float num = (float)this.JDMPLGBGNFB();
			if (num > 460f)
			{
				float num2 = 680f / num;
				Vector3 localScale = this.BLLEFKOLKLP.localScale;
				if (Mathf.Abs(localScale.x - num2) > 196f || Mathf.Abs(localScale.y - num2) > 753f || Mathf.Abs(localScale.z - num2) > 1484f)
				{
					this.BLLEFKOLKLP.localScale = new Vector3(num2, num2, num2);
					if (NMOPFIDPGDB)
					{
						base.BroadcastMessage("Cheek Pouch", SendMessageOptions.RequireReceiver);
					}
				}
			}
		}
	}

	// Token: 0x060020A0 RID: 8352 RVA: 0x000D63D4 File Offset: 0x000D45D4
	public GKDCBJPLQLQ.KHMJPIFKCNE BFMEKNIHJHH()
	{
		GKDCBJPLQLQ.KHMJPIFKCNE kmhncclcddp = this.KMHNCCLCDDP;
		if (kmhncclcddp == (GKDCBJPLQLQ.KHMJPIFKCNE)8)
		{
			return GKDCBJPLQLQ.KHMJPIFKCNE.Flexible;
		}
		return kmhncclcddp;
	}

	// Token: 0x060020A1 RID: 8353 RVA: 0x000D63F0 File Offset: 0x000D45F0
	public static void QQKBCFOLNQC(string OELBCGGGCIP, object ODCOBDIHEQB)
	{
		if (ODCOBDIHEQB == null)
		{
			Debug.LogError("[");
		}
		else
		{
			int i = 0;
			int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
				if (gkdcbjplqlq != null)
				{
					gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, ODCOBDIHEQB, SendMessageOptions.RequireReceiver);
				}
				i++;
			}
		}
	}

	// Token: 0x060020A2 RID: 8354 RVA: 0x000D6444 File Offset: 0x000D4644
	public static void CQMEMNBPFLI(string OELBCGGGCIP, object ODCOBDIHEQB)
	{
		if (ODCOBDIHEQB == null)
		{
			Debug.LogError("Assets/AssetBundles/MapAssets/Models/Materials/Street_Lamp_8_Light.mat");
		}
		else
		{
			int i = 0;
			int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
				if (gkdcbjplqlq != null)
				{
					gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, ODCOBDIHEQB, SendMessageOptions.RequireReceiver);
				}
				i++;
			}
		}
	}

	// Token: 0x060020A3 RID: 8355 RVA: 0x000D6498 File Offset: 0x000D4698
	public float FLICOPFPPCL(int DFKQMMIQDOO)
	{
		DFKQMMIQDOO = Mathf.Max(6, DFKQMMIQDOO);
		if (this.BFMEKNIHJHH() == GKDCBJPLQLQ.KHMJPIFKCNE.Constrained)
		{
			return (float)this.ILQIODGPBCD() / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO < this.FBPMGLPJNDP)
		{
			return (float)this.FBPMGLPJNDP / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO > this.GQDEIICHJPC)
		{
			return (float)this.GQDEIICHJPC / (float)DFKQMMIQDOO;
		}
		return 905f;
	}

	// Token: 0x060020A4 RID: 8356 RVA: 0x000D64F0 File Offset: 0x000D46F0
	public void MKQDGFKOLQP(bool NMOPFIDPGDB = true)
	{
		if (this.BLLEFKOLKLP != null)
		{
			float num = (float)this.QNGBNNMFGFQ();
			if (num > 208f)
			{
				float num2 = 63f / num;
				Vector3 localScale = this.BLLEFKOLKLP.localScale;
				if (Mathf.Abs(localScale.x - num2) > 927f || Mathf.Abs(localScale.y - num2) > 430f || Mathf.Abs(localScale.z - num2) > 649f)
				{
					this.BLLEFKOLKLP.localScale = new Vector3(num2, num2, num2);
					if (NMOPFIDPGDB)
					{
						base.BroadcastMessage("#,##0", SendMessageOptions.RequireReceiver);
					}
				}
			}
		}
	}

	// Token: 0x060020A5 RID: 8357 RVA: 0x00011BC5 File Offset: 0x0000FDC5
	protected virtual void CBIFGBNDMHB()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060020A6 RID: 8358 RVA: 0x000D6594 File Offset: 0x000D4794
	public int PJKMJPJJJJP()
	{
		if (this.NGDQOCMKPCG() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI oceigejiqli = this.CHDBFCQQFOC();
		if (oceigejiqli == (GKDCBJPLQLQ.OCEIGEJIQLI)8)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (oceigejiqli == (GKDCBJPLQLQ.OCEIGEJIQLI)8)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli != GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x060020A7 RID: 8359 RVA: 0x00011C39 File Offset: 0x0000FE39
	private void HCHNCCPGFCB()
	{
		this.BBEPBKCGLIM(true);
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x00011C42 File Offset: 0x0000FE42
	public GKDCBJPLQLQ.OCEIGEJIQLI MJCHMJFBNCB()
	{
		if (this.JJLIDHKCCJM)
		{
			if (this.IOJPPEMFHQF)
			{
				return GKDCBJPLQLQ.OCEIGEJIQLI.Fit;
			}
			return GKDCBJPLQLQ.OCEIGEJIQLI.FitHeight;
		}
		else
		{
			if (this.IOJPPEMFHQF)
			{
				return (GKDCBJPLQLQ.OCEIGEJIQLI)4;
			}
			return GKDCBJPLQLQ.OCEIGEJIQLI.Fill;
		}
	}

	// Token: 0x060020A9 RID: 8361 RVA: 0x00011BC5 File Offset: 0x0000FDC5
	protected virtual void OJQHKOJJNCP()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060020AA RID: 8362 RVA: 0x000D6704 File Offset: 0x000D4904
	public static void OELIBIIBOBC(string OELBCGGGCIP)
	{
		int i = 0;
		int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
		while (i < count)
		{
			GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
			if (gkdcbjplqlq != null)
			{
				gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, SendMessageOptions.DontRequireReceiver);
			}
			i++;
		}
	}

	// Token: 0x060020AB RID: 8363 RVA: 0x00011BDC File Offset: 0x0000FDDC
	protected virtual void HNHIPMHELHB()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Add(this);
	}

	// Token: 0x060020AC RID: 8364 RVA: 0x00011C63 File Offset: 0x0000FE63
	private void EGFFPGCMFOO()
	{
		this.HKJKFNQJLJL(true);
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x00011BDC File Offset: 0x0000FDDC
	protected virtual void MCIOHHBPLGO()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Add(this);
	}

	// Token: 0x060020AE RID: 8366 RVA: 0x00011C0A File Offset: 0x0000FE0A
	protected virtual void ENEEJOGCLEB()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Remove(this);
	}

	// Token: 0x060020AF RID: 8367 RVA: 0x000D6748 File Offset: 0x000D4948
	public int QIEKBBQKDCN()
	{
		if (this.IJBJBBPBOGB() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI emghfhnqodd = this.EMGHFHNQODD;
		if (emghfhnqodd == (GKDCBJPLQLQ.OCEIGEJIQLI)7)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (emghfhnqodd == (GKDCBJPLQLQ.OCEIGEJIQLI)4)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (emghfhnqodd == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (emghfhnqodd != GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x000D68B8 File Offset: 0x000D4AB8
	public void FOLEBHELPBD(bool NMOPFIDPGDB = true)
	{
		if (this.BLLEFKOLKLP != null)
		{
			float num = (float)this.PJKMJPJJJJP();
			if (num > 1147f)
			{
				float num2 = 625f / num;
				Vector3 localScale = this.BLLEFKOLKLP.localScale;
				if (Mathf.Abs(localScale.x - num2) > 673f || Mathf.Abs(localScale.y - num2) > 671f || Mathf.Abs(localScale.z - num2) > 1150f)
				{
					this.BLLEFKOLKLP.localScale = new Vector3(num2, num2, num2);
					if (NMOPFIDPGDB)
					{
						base.BroadcastMessage("[ff6600]", SendMessageOptions.DontRequireReceiver);
					}
				}
			}
		}
	}

	// Token: 0x060020B1 RID: 8369 RVA: 0x000D695C File Offset: 0x000D4B5C
	public int MBHLPLLDDNJ()
	{
		if (this.QQDGMEMQOHF() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI oceigejiqli = this.JECNOKBPFNL();
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.FitWidth)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (oceigejiqli == (GKDCBJPLQLQ.OCEIGEJIQLI)6)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli != GKDCBJPLQLQ.OCEIGEJIQLI.Fill)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x060020B2 RID: 8370 RVA: 0x000D6ACC File Offset: 0x000D4CCC
	public float PNBFQDLQENI
	{
		get
		{
			int num = Mathf.RoundToInt(IKBQNBHOJJB.FMDDDQOPBEI.y);
			return (num != -1) ? this.CLBGPGKBPQK(num) : 1f;
		}
	}

	// Token: 0x060020B3 RID: 8371 RVA: 0x000D6B00 File Offset: 0x000D4D00
	public GKDCBJPLQLQ.KHMJPIFKCNE DMKLBKIBFME()
	{
		GKDCBJPLQLQ.KHMJPIFKCNE kmhncclcddp = this.KMHNCCLCDDP;
		if (kmhncclcddp == (GKDCBJPLQLQ.KHMJPIFKCNE)4)
		{
			return GKDCBJPLQLQ.KHMJPIFKCNE.Flexible;
		}
		return kmhncclcddp;
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x000D6B1C File Offset: 0x000D4D1C
	protected virtual void DGMPMICDCIO()
	{
		IPPMCDQNMML componentInChildren = base.GetComponentInChildren<IPPMCDQNMML>();
		if (componentInChildren != null)
		{
			Debug.LogWarning("UI", componentInChildren);
			Camera component = componentInChildren.gameObject.GetComponent<Camera>();
			componentInChildren.enabled = true;
			if (component != null)
			{
				component.orthographicSize = 1310f;
			}
		}
		else
		{
			this.HKJKFNQJLJL(true);
		}
	}

	// Token: 0x060020B5 RID: 8373 RVA: 0x000D6B74 File Offset: 0x000D4D74
	public static void DQMDJBNDBLM(string OELBCGGGCIP, object ODCOBDIHEQB)
	{
		if (ODCOBDIHEQB == null)
		{
			Debug.LogError("0");
		}
		else
		{
			int i = 0;
			int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
				if (gkdcbjplqlq != null)
				{
					gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, ODCOBDIHEQB, SendMessageOptions.RequireReceiver);
				}
				i++;
			}
		}
	}

	// Token: 0x060020B6 RID: 8374 RVA: 0x00011BDC File Offset: 0x0000FDDC
	protected virtual void HOQHKBCMPEK()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Add(this);
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x000D6BC8 File Offset: 0x000D4DC8
	public static float OPGIJMDLBLK(GameObject CGHIENBIHCO)
	{
		GKDCBJPLQLQ gkdcbjplqlq = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(CGHIENBIHCO);
		return (!(gkdcbjplqlq != null)) ? 116f : gkdcbjplqlq.JCGLMKGEJQG();
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x00011BDC File Offset: 0x0000FDDC
	protected virtual void NKKHLBMNPML()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Add(this);
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x060020BA RID: 8378 RVA: 0x000D6BF4 File Offset: 0x000D4DF4
	public int IINCKPHJGPC
	{
		get
		{
			if (this.JCLPPCOHQEI == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
			{
				Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
				float num = fmdddqopbei.x / fmdddqopbei.y;
				if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
				{
					fmdddqopbei.y = (float)this.FBPMGLPJNDP;
					fmdddqopbei.x = fmdddqopbei.y * num;
				}
				else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
				{
					fmdddqopbei.y = (float)this.GQDEIICHJPC;
					fmdddqopbei.x = fmdddqopbei.y * num;
				}
				int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
				return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
			}
			GKDCBJPLQLQ.OCEIGEJIQLI emghfhnqodd = this.EMGHFHNQODD;
			if (emghfhnqodd == GKDCBJPLQLQ.OCEIGEJIQLI.FitHeight)
			{
				return this.MGEBMHBMKOF;
			}
			Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
			float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
			float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
			if (emghfhnqodd == GKDCBJPLQLQ.OCEIGEJIQLI.FitWidth)
			{
				return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
			}
			if (emghfhnqodd == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
			{
				return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
			}
			if (emghfhnqodd != GKDCBJPLQLQ.OCEIGEJIQLI.Fill)
			{
				return this.MGEBMHBMKOF;
			}
			return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
	}

	// Token: 0x060020BB RID: 8379 RVA: 0x000D6D64 File Offset: 0x000D4F64
	public int CBFBCDJGHBN()
	{
		if (this.BFMEKNIHJHH() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI emghfhnqodd = this.EMGHFHNQODD;
		if (emghfhnqodd == (GKDCBJPLQLQ.OCEIGEJIQLI)6)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (emghfhnqodd == GKDCBJPLQLQ.OCEIGEJIQLI.FitWidth)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (emghfhnqodd == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (emghfhnqodd != GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x060020BC RID: 8380 RVA: 0x000D6ED4 File Offset: 0x000D50D4
	public int BEBHMIFIFGC()
	{
		if (this.JCLPPCOHQEI == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI oceigejiqli = this.MJCHMJFBNCB();
		if (oceigejiqli == (GKDCBJPLQLQ.OCEIGEJIQLI)7)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (oceigejiqli == (GKDCBJPLQLQ.OCEIGEJIQLI)8)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli != GKDCBJPLQLQ.OCEIGEJIQLI.Fill)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x060020BD RID: 8381 RVA: 0x00011BC5 File Offset: 0x0000FDC5
	protected virtual void BCEKGNDIIOE()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060020BE RID: 8382 RVA: 0x000D7044 File Offset: 0x000D5244
	public float OHPNFMPOOCO(int DFKQMMIQDOO)
	{
		DFKQMMIQDOO = Mathf.Max(3, DFKQMMIQDOO);
		if (this.IJBJBBPBOGB() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			return (float)this.QIEKBBQKDCN() / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO < this.FBPMGLPJNDP)
		{
			return (float)this.FBPMGLPJNDP / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO > this.GQDEIICHJPC)
		{
			return (float)this.GQDEIICHJPC / (float)DFKQMMIQDOO;
		}
		return 1755f;
	}

	// Token: 0x060020BF RID: 8383 RVA: 0x000D709C File Offset: 0x000D529C
	public void GEFMOEGEGGQ(bool NMOPFIDPGDB = true)
	{
		if (this.BLLEFKOLKLP != null)
		{
			float num = (float)this.JDMPLGBGNFB();
			if (num > 1760f)
			{
				float num2 = 1667f / num;
				Vector3 localScale = this.BLLEFKOLKLP.localScale;
				if (Mathf.Abs(localScale.x - num2) > 884f || Mathf.Abs(localScale.y - num2) > 1462f || Mathf.Abs(localScale.z - num2) > 922f)
				{
					this.BLLEFKOLKLP.localScale = new Vector3(num2, num2, num2);
					if (NMOPFIDPGDB)
					{
						base.BroadcastMessage("Blank", SendMessageOptions.RequireReceiver);
					}
				}
			}
		}
	}

	// Token: 0x060020C0 RID: 8384 RVA: 0x000D7140 File Offset: 0x000D5340
	public static void PHJKKLCPIGL(string OELBCGGGCIP, object ODCOBDIHEQB)
	{
		if (ODCOBDIHEQB == null)
		{
			Debug.LogError("s");
		}
		else
		{
			int i = 1;
			int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
				if (gkdcbjplqlq != null)
				{
					gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, ODCOBDIHEQB, SendMessageOptions.RequireReceiver);
				}
				i += 0;
			}
		}
	}

	// Token: 0x060020C1 RID: 8385 RVA: 0x00011BC5 File Offset: 0x0000FDC5
	protected virtual void KLFJOJOOECI()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060020C2 RID: 8386 RVA: 0x000D7194 File Offset: 0x000D5394
	public int ILQIODGPBCD()
	{
		if (this.JIIKBENEFPQ() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI emghfhnqodd = this.EMGHFHNQODD;
		if (emghfhnqodd == (GKDCBJPLQLQ.OCEIGEJIQLI)6)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (emghfhnqodd == (GKDCBJPLQLQ.OCEIGEJIQLI)4)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (emghfhnqodd == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (emghfhnqodd != GKDCBJPLQLQ.OCEIGEJIQLI.Fill)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x060020C3 RID: 8387 RVA: 0x00011C78 File Offset: 0x0000FE78
	private void JQPKDIBJHHF()
	{
		this.HKJKFNQJLJL(false);
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x000D7304 File Offset: 0x000D5504
	public float JOGIQGQOEIP()
	{
		int num = Mathf.RoundToInt(IKBQNBHOJJB.FMDDDQOPBEI.y);
		return (num != -1) ? this.CMPJLKBOPBP(num) : 413f;
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x000D7338 File Offset: 0x000D5538
	public float CMPJLKBOPBP(int DFKQMMIQDOO)
	{
		DFKQMMIQDOO = Mathf.Max(3, DFKQMMIQDOO);
		if (this.DMKLBKIBFME() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			return (float)this.ILQIODGPBCD() / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO < this.FBPMGLPJNDP)
		{
			return (float)this.FBPMGLPJNDP / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO > this.GQDEIICHJPC)
		{
			return (float)this.GQDEIICHJPC / (float)DFKQMMIQDOO;
		}
		return 111f;
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x000D7390 File Offset: 0x000D5590
	public static float NHONOIHGKGI(GameObject CGHIENBIHCO)
	{
		GKDCBJPLQLQ gkdcbjplqlq = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(CGHIENBIHCO);
		return (!(gkdcbjplqlq != null)) ? 2f : gkdcbjplqlq.JCGLMKGEJQG();
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x000D73BC File Offset: 0x000D55BC
	public static void IDLHMQJLIGH(string OELBCGGGCIP, object ODCOBDIHEQB)
	{
		if (ODCOBDIHEQB == null)
		{
			Debug.LogError("The effects of Throat Chop prevent ");
		}
		else
		{
			int i = 0;
			int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
				if (gkdcbjplqlq != null)
				{
					gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, ODCOBDIHEQB, SendMessageOptions.DontRequireReceiver);
				}
				i++;
			}
		}
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x00011C0A File Offset: 0x0000FE0A
	protected virtual void OnDisable()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Remove(this);
	}

	// Token: 0x060020C9 RID: 8393 RVA: 0x000D7410 File Offset: 0x000D5610
	public GKDCBJPLQLQ.KHMJPIFKCNE OLJHKKDBPHD()
	{
		GKDCBJPLQLQ.KHMJPIFKCNE kmhncclcddp = this.KMHNCCLCDDP;
		if (kmhncclcddp == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			return GKDCBJPLQLQ.KHMJPIFKCNE.Flexible;
		}
		return kmhncclcddp;
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x00011BDC File Offset: 0x0000FDDC
	protected virtual void OnEnable()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Add(this);
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x00011C81 File Offset: 0x0000FE81
	private void GBGQDEMQHPE()
	{
		this.IIGFHJOOGBL(true);
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x000D742C File Offset: 0x000D562C
	public void IIGFHJOOGBL(bool NMOPFIDPGDB = true)
	{
		if (this.BLLEFKOLKLP != null)
		{
			float num = (float)this.BEBHMIFIFGC();
			if (num > 1854f)
			{
				float num2 = 574f / num;
				Vector3 localScale = this.BLLEFKOLKLP.localScale;
				if (Mathf.Abs(localScale.x - num2) > 1346f || Mathf.Abs(localScale.y - num2) > 783f || Mathf.Abs(localScale.z - num2) > 276f)
				{
					this.BLLEFKOLKLP.localScale = new Vector3(num2, num2, num2);
					if (NMOPFIDPGDB)
					{
						base.BroadcastMessage("/", SendMessageOptions.DontRequireReceiver);
					}
				}
			}
		}
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x000D74D0 File Offset: 0x000D56D0
	public float CLBGPGKBPQK(int DFKQMMIQDOO)
	{
		DFKQMMIQDOO = Mathf.Max(2, DFKQMMIQDOO);
		if (this.JCLPPCOHQEI == GKDCBJPLQLQ.KHMJPIFKCNE.Constrained)
		{
			return (float)this.IINCKPHJGPC / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO < this.FBPMGLPJNDP)
		{
			return (float)this.FBPMGLPJNDP / (float)DFKQMMIQDOO;
		}
		if (DFKQMMIQDOO > this.GQDEIICHJPC)
		{
			return (float)this.GQDEIICHJPC / (float)DFKQMMIQDOO;
		}
		return 1f;
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x000D7528 File Offset: 0x000D5728
	public static float BEOJQLMPEOC(GameObject CGHIENBIHCO)
	{
		GKDCBJPLQLQ gkdcbjplqlq = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(CGHIENBIHCO);
		return (!(gkdcbjplqlq != null)) ? 989f : gkdcbjplqlq.JCGLMKGEJQG();
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x000D7554 File Offset: 0x000D5754
	public float KFLGCIPQMGJ()
	{
		int num = Mathf.RoundToInt(IKBQNBHOJJB.FMDDDQOPBEI.y);
		return (num != -1) ? this.NIJOIGBGGPC(num) : 881f;
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x000D7588 File Offset: 0x000D5788
	public static float CLBGPGKBPQK(GameObject CGHIENBIHCO)
	{
		GKDCBJPLQLQ gkdcbjplqlq = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(CGHIENBIHCO);
		return (!(gkdcbjplqlq != null)) ? 1f : gkdcbjplqlq.PNBFQDLQENI;
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x000D75B4 File Offset: 0x000D57B4
	public int MDCMIKCOHMQ()
	{
		if (this.QQDGMEMQOHF() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI emghfhnqodd = this.EMGHFHNQODD;
		if (emghfhnqodd == (GKDCBJPLQLQ.OCEIGEJIQLI)7)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (emghfhnqodd == (GKDCBJPLQLQ.OCEIGEJIQLI)7)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (emghfhnqodd == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (emghfhnqodd != GKDCBJPLQLQ.OCEIGEJIQLI.Fill)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x000D7724 File Offset: 0x000D5924
	public GKDCBJPLQLQ.KHMJPIFKCNE MFLHQDHPNHH()
	{
		GKDCBJPLQLQ.KHMJPIFKCNE kmhncclcddp = this.KMHNCCLCDDP;
		if (kmhncclcddp == (GKDCBJPLQLQ.KHMJPIFKCNE)6)
		{
			return GKDCBJPLQLQ.KHMJPIFKCNE.Constrained;
		}
		return kmhncclcddp;
	}

	// Token: 0x060020D3 RID: 8403 RVA: 0x000D7740 File Offset: 0x000D5940
	protected virtual void Start()
	{
		IPPMCDQNMML componentInChildren = base.GetComponentInChildren<IPPMCDQNMML>();
		if (componentInChildren != null)
		{
			Debug.LogWarning("UIRoot should not be active at the same time as UIOrthoCamera. Disabling UIOrthoCamera.", componentInChildren);
			Camera component = componentInChildren.gameObject.GetComponent<Camera>();
			componentInChildren.enabled = false;
			if (component != null)
			{
				component.orthographicSize = 1f;
			}
		}
		else
		{
			this.KQLOHLEOQIB(false);
		}
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x000D7798 File Offset: 0x000D5998
	public static void PKDQFHPQINH(string OELBCGGGCIP, object ODCOBDIHEQB)
	{
		if (ODCOBDIHEQB == null)
		{
			Debug.LogError("Powers up moves of the same type as the Pokémon.");
		}
		else
		{
			int i = 0;
			int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
				if (gkdcbjplqlq != null)
				{
					gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, ODCOBDIHEQB, SendMessageOptions.RequireReceiver);
				}
				i += 0;
			}
		}
	}

	// Token: 0x060020D5 RID: 8405 RVA: 0x00011BC5 File Offset: 0x0000FDC5
	protected virtual void Awake()
	{
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060020D7 RID: 8407 RVA: 0x000D77EC File Offset: 0x000D59EC
	public static void LIMJQHHIIPN(string OELBCGGGCIP, object ODCOBDIHEQB)
	{
		if (ODCOBDIHEQB == null)
		{
			Debug.LogError("_VolumetricFogDepthTexture");
		}
		else
		{
			int i = 0;
			int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
				if (gkdcbjplqlq != null)
				{
					gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, ODCOBDIHEQB, SendMessageOptions.RequireReceiver);
				}
				i += 0;
			}
		}
	}

	// Token: 0x060020D8 RID: 8408 RVA: 0x000D7840 File Offset: 0x000D5A40
	public GKDCBJPLQLQ.KHMJPIFKCNE QQDGMEMQOHF()
	{
		GKDCBJPLQLQ.KHMJPIFKCNE kmhncclcddp = this.KMHNCCLCDDP;
		if (kmhncclcddp == (GKDCBJPLQLQ.KHMJPIFKCNE)6)
		{
			return GKDCBJPLQLQ.KHMJPIFKCNE.Flexible;
		}
		return kmhncclcddp;
	}

	// Token: 0x060020D9 RID: 8409 RVA: 0x000D785C File Offset: 0x000D5A5C
	public int QNGBNNMFGFQ()
	{
		if (this.QQDGMEMQOHF() == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI oceigejiqli = this.MJCHMJFBNCB();
		if (oceigejiqli == (GKDCBJPLQLQ.OCEIGEJIQLI)8)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (oceigejiqli == (GKDCBJPLQLQ.OCEIGEJIQLI)8)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli != GKDCBJPLQLQ.OCEIGEJIQLI.Fill)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x060020DA RID: 8410 RVA: 0x00011CC5 File Offset: 0x0000FEC5
	public GKDCBJPLQLQ.OCEIGEJIQLI EMGHFHNQODD
	{
		get
		{
			if (this.JJLIDHKCCJM)
			{
				if (this.IOJPPEMFHQF)
				{
					return GKDCBJPLQLQ.OCEIGEJIQLI.Fit;
				}
				return GKDCBJPLQLQ.OCEIGEJIQLI.FitWidth;
			}
			else
			{
				if (this.IOJPPEMFHQF)
				{
					return GKDCBJPLQLQ.OCEIGEJIQLI.FitHeight;
				}
				return GKDCBJPLQLQ.OCEIGEJIQLI.Fill;
			}
		}
	}

	// Token: 0x060020DB RID: 8411 RVA: 0x000D79CC File Offset: 0x000D5BCC
	public int JDMPLGBGNFB()
	{
		if (this.JCLPPCOHQEI == GKDCBJPLQLQ.KHMJPIFKCNE.Flexible)
		{
			Vector2 fmdddqopbei = IKBQNBHOJJB.FMDDDQOPBEI;
			float num = fmdddqopbei.x / fmdddqopbei.y;
			if (fmdddqopbei.y < (float)this.FBPMGLPJNDP)
			{
				fmdddqopbei.y = (float)this.FBPMGLPJNDP;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			else if (fmdddqopbei.y > (float)this.GQDEIICHJPC)
			{
				fmdddqopbei.y = (float)this.GQDEIICHJPC;
				fmdddqopbei.x = fmdddqopbei.y * num;
			}
			int num2 = Mathf.RoundToInt((!this.BIGOEBEQLHG || fmdddqopbei.y <= fmdddqopbei.x) ? fmdddqopbei.y : (fmdddqopbei.y / num));
			return (!this.KBHKEOMMHGJ) ? num2 : JNNGOIIKENH.MPJPNENGCGH((float)num2);
		}
		GKDCBJPLQLQ.OCEIGEJIQLI oceigejiqli = this.JECNOKBPFNL();
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return this.MGEBMHBMKOF;
		}
		Vector2 fmdddqopbei2 = IKBQNBHOJJB.FMDDDQOPBEI;
		float num3 = fmdddqopbei2.x / fmdddqopbei2.y;
		float num4 = (float)this.NNCBGMFKKEO / (float)this.MGEBMHBMKOF;
		if (oceigejiqli == (GKDCBJPLQLQ.OCEIGEJIQLI)4)
		{
			return Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli == GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return (num4 <= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
		}
		if (oceigejiqli != GKDCBJPLQLQ.OCEIGEJIQLI.Fit)
		{
			return this.MGEBMHBMKOF;
		}
		return (num4 >= num3) ? this.MGEBMHBMKOF : Mathf.RoundToInt((float)this.NNCBGMFKKEO / num3);
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x00011C0A File Offset: 0x0000FE0A
	protected virtual void JGPFFDGPGFJ()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Remove(this);
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x000D7B3C File Offset: 0x000D5D3C
	public GKDCBJPLQLQ.KHMJPIFKCNE IJBJBBPBOGB()
	{
		GKDCBJPLQLQ.KHMJPIFKCNE kmhncclcddp = this.KMHNCCLCDDP;
		if (kmhncclcddp == (GKDCBJPLQLQ.KHMJPIFKCNE)7)
		{
			return GKDCBJPLQLQ.KHMJPIFKCNE.Constrained;
		}
		return kmhncclcddp;
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x00011BDC File Offset: 0x0000FDDC
	protected virtual void MGNCJDGGKGH()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Add(this);
	}

	// Token: 0x060020DF RID: 8415 RVA: 0x000D7B58 File Offset: 0x000D5D58
	public static void OELIBIIBOBC(string OELBCGGGCIP, object ODCOBDIHEQB)
	{
		if (ODCOBDIHEQB == null)
		{
			Debug.LogError("SendMessage is bugged when you try to pass 'null' in the parameter field. It behaves as if no parameter was specified.");
		}
		else
		{
			int i = 0;
			int count = GKDCBJPLQLQ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				GKDCBJPLQLQ gkdcbjplqlq = GKDCBJPLQLQ.NGDBDCQFDHI[i];
				if (gkdcbjplqlq != null)
				{
					gkdcbjplqlq.BroadcastMessage(OELBCGGGCIP, ODCOBDIHEQB, SendMessageOptions.DontRequireReceiver);
				}
				i++;
			}
		}
	}

	// Token: 0x060020E0 RID: 8416 RVA: 0x00011C0A File Offset: 0x0000FE0A
	protected virtual void NQOGCEDFBPC()
	{
		GKDCBJPLQLQ.NGDBDCQFDHI.Remove(this);
	}

	// Token: 0x04000726 RID: 1830
	public static List<GKDCBJPLQLQ> NGDBDCQFDHI = new List<GKDCBJPLQLQ>();

	// Token: 0x04000727 RID: 1831
	public GKDCBJPLQLQ.KHMJPIFKCNE KMHNCCLCDDP;

	// Token: 0x04000728 RID: 1832
	public int NNCBGMFKKEO = 1280;

	// Token: 0x04000729 RID: 1833
	public int MGEBMHBMKOF = 720;

	// Token: 0x0400072A RID: 1834
	public int FBPMGLPJNDP = 320;

	// Token: 0x0400072B RID: 1835
	public int GQDEIICHJPC = 1536;

	// Token: 0x0400072C RID: 1836
	public bool JJLIDHKCCJM;

	// Token: 0x0400072D RID: 1837
	public bool IOJPPEMFHQF = true;

	// Token: 0x0400072E RID: 1838
	public bool KBHKEOMMHGJ;

	// Token: 0x0400072F RID: 1839
	public bool BIGOEBEQLHG;

	// Token: 0x04000730 RID: 1840
	private Transform BLLEFKOLKLP;

	// Token: 0x0200011F RID: 287
	public enum KHMJPIFKCNE
	{
		// Token: 0x04000732 RID: 1842
		Flexible,
		// Token: 0x04000733 RID: 1843
		Constrained,
		// Token: 0x04000734 RID: 1844
		ConstrainedOnMobiles
	}

	// Token: 0x02000120 RID: 288
	public enum OCEIGEJIQLI
	{
		// Token: 0x04000736 RID: 1846
		Fit,
		// Token: 0x04000737 RID: 1847
		Fill,
		// Token: 0x04000738 RID: 1848
		FitWidth,
		// Token: 0x04000739 RID: 1849
		FitHeight
	}
}
