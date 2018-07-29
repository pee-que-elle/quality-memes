using System;
using UnityEngine;

// Token: 0x020000DD RID: 221
[AddComponentMenu("NGUI/Tween/Tween Position")]
public class JDMOPNEKJII : UITweener
{
	// Token: 0x06001A5D RID: 6749 RVA: 0x0000E0B5 File Offset: 0x0000C2B5
	public virtual void EQGCGMJNJPE()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x0000E0C3 File Offset: 0x0000C2C3
	private void CQEIGLBIJGN()
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB;
	}

	// Token: 0x06001A5F RID: 6751 RVA: 0x000B0994 File Offset: 0x000AEB94
	public static JDMOPNEKJII KBGFGBELJOG(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 NKKGPNPGDEM)
	{
		JDMOPNEKJII jdmopnekjii = UITweener.Begin<JDMOPNEKJII>(CGHIENBIHCO, CPKNEQGKQPQ, 552f);
		jdmopnekjii.CGHQEHCBQHB = jdmopnekjii.BGBMIEJJQKC;
		jdmopnekjii.BKMCCCGOGOM = NKKGPNPGDEM;
		if (CPKNEQGKQPQ <= 287f)
		{
			jdmopnekjii.Sample(1758f, true);
			jdmopnekjii.enabled = false;
		}
		return jdmopnekjii;
	}

	// Token: 0x06001A60 RID: 6752 RVA: 0x0000E0D1 File Offset: 0x0000C2D1
	private void NGJIKGJCQDQ()
	{
		this.GIPBBFDPCKG(this.CGHQEHCBQHB);
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x0000E0E7 File Offset: 0x0000C2E7
	public void EDLNIMMPPJE(Vector3 BGBMIEJJQKC)
	{
		this.GIPBBFDPCKG(BGBMIEJJQKC);
	}

	// Token: 0x06001A63 RID: 6755 RVA: 0x0000E0B5 File Offset: 0x0000C2B5
	public virtual void JPIOHGOJBBK()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x0000E0F0 File Offset: 0x0000C2F0
	public virtual void EIMMBIEJJPN()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06001A65 RID: 6757 RVA: 0x0000E0F0 File Offset: 0x0000C2F0
	public virtual void DPFLQLDQFHG()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06001A66 RID: 6758 RVA: 0x000B09E0 File Offset: 0x000AEBE0
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (!IJKDMCLDHNL && PJDGFDBEOOJ < 1f)
		{
			this.BGBMIEJJQKC = this.CGHQEHCBQHB * (1f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
		}
		else
		{
			this.BGBMIEJJQKC = this.BKMCCCGOGOM;
		}
	}

	// Token: 0x06001A67 RID: 6759 RVA: 0x000B0A30 File Offset: 0x000AEC30
	public static JDMOPNEKJII FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 NKKGPNPGDEM, bool MKCNEHFFGKB)
	{
		JDMOPNEKJII jdmopnekjii = UITweener.Begin<JDMOPNEKJII>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		jdmopnekjii.MKCNEHFFGKB = MKCNEHFFGKB;
		jdmopnekjii.CGHQEHCBQHB = jdmopnekjii.BGBMIEJJQKC;
		jdmopnekjii.BKMCCCGOGOM = NKKGPNPGDEM;
		if (CPKNEQGKQPQ <= 0f)
		{
			jdmopnekjii.Sample(1f, true);
			jdmopnekjii.enabled = false;
		}
		return jdmopnekjii;
	}

	// Token: 0x06001A68 RID: 6760 RVA: 0x0000E0FE File Offset: 0x0000C2FE
	public Vector3 LKHLDLNFDOP()
	{
		return this.BGBMIEJJQKC;
	}

	// Token: 0x06001A69 RID: 6761 RVA: 0x0000E106 File Offset: 0x0000C306
	private void PCJODQLGMKM()
	{
		this.GIPBBFDPCKG(this.BKMCCCGOGOM);
	}

	// Token: 0x06001A6A RID: 6762 RVA: 0x0000E114 File Offset: 0x0000C314
	private void Awake()
	{
		this.FBPOKBEMCEL = base.GetComponent<BLMNBILNMOE>();
	}

	// Token: 0x06001A6B RID: 6763 RVA: 0x0000E122 File Offset: 0x0000C322
	public Transform OPQOIGHGMJB()
	{
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.transform;
		}
		return this.BLLEFKOLKLP;
	}

	// Token: 0x06001A6C RID: 6764 RVA: 0x0000E144 File Offset: 0x0000C344
	private void QCICCCHGGCC()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06001A6D RID: 6765 RVA: 0x0000E122 File Offset: 0x0000C322
	public Transform CGDFDPHIENG
	{
		get
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
			}
			return this.BLLEFKOLKLP;
		}
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x0000E0B5 File Offset: 0x0000C2B5
	public virtual void IDDOPPKLPNH()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x000B0A80 File Offset: 0x000AEC80
	protected virtual void OBEHKKHPHQM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (!IJKDMCLDHNL && PJDGFDBEOOJ < 1303f)
		{
			this.GIPBBFDPCKG(this.CGHQEHCBQHB * (736f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
		}
		else
		{
			this.BGBMIEJJQKC = this.BKMCCCGOGOM;
		}
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x0000E106 File Offset: 0x0000C306
	private void CGGCCEHEEBO()
	{
		this.GIPBBFDPCKG(this.BKMCCCGOGOM);
	}

	// Token: 0x06001A71 RID: 6769 RVA: 0x0000E0C3 File Offset: 0x0000C2C3
	[ContextMenu("Assume value of 'From'")]
	private void MOKOMDGBDHD()
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB;
	}

	// Token: 0x06001A72 RID: 6770 RVA: 0x0000E144 File Offset: 0x0000C344
	[ContextMenu("Assume value of 'To'")]
	private void IQPDLQCEQHJ()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x06001A73 RID: 6771 RVA: 0x0000E0B5 File Offset: 0x0000C2B5
	public virtual void NCDDJJQMELE()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001A74 RID: 6772 RVA: 0x0000E152 File Offset: 0x0000C352
	public void PBNJNQKNKBQ(Vector3 BGBMIEJJQKC)
	{
		this.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06001A75 RID: 6773 RVA: 0x0000E0FE File Offset: 0x0000C2FE
	// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0000E152 File Offset: 0x0000C352
	[Obsolete("Use 'value' instead")]
	public Vector3 BDBBEMKFGPI
	{
		get
		{
			return this.BGBMIEJJQKC;
		}
		set
		{
			this.BGBMIEJJQKC = value;
		}
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x0000E0FE File Offset: 0x0000C2FE
	public Vector3 DCFPGDBEGQO()
	{
		return this.BGBMIEJJQKC;
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x000B0AD0 File Offset: 0x000AECD0
	public static JDMOPNEKJII FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 NKKGPNPGDEM)
	{
		JDMOPNEKJII jdmopnekjii = UITweener.Begin<JDMOPNEKJII>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		jdmopnekjii.CGHQEHCBQHB = jdmopnekjii.BGBMIEJJQKC;
		jdmopnekjii.BKMCCCGOGOM = NKKGPNPGDEM;
		if (CPKNEQGKQPQ <= 0f)
		{
			jdmopnekjii.Sample(1f, true);
			jdmopnekjii.enabled = false;
		}
		return jdmopnekjii;
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x0000E0B5 File Offset: 0x0000C2B5
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001A79 RID: 6777 RVA: 0x0000E0F0 File Offset: 0x0000C2F0
	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0000E15B File Offset: 0x0000C35B
	// (set) Token: 0x06001A7A RID: 6778 RVA: 0x000B0B1C File Offset: 0x000AED1C
	public Vector3 BGBMIEJJQKC
	{
		get
		{
			return (!this.MKCNEHFFGKB) ? this.CGDFDPHIENG.localPosition : this.CGDFDPHIENG.position;
		}
		set
		{
			if (!(this.FBPOKBEMCEL == null) && this.FBPOKBEMCEL.IEEHOJCLFDJ && !this.MKCNEHFFGKB)
			{
				value -= this.CGDFDPHIENG.localPosition;
				JNNGOIIKENH.IMEBEBEGHQI(this.FBPOKBEMCEL, value.x, value.y);
			}
			else if (this.MKCNEHFFGKB)
			{
				this.CGDFDPHIENG.position = value;
			}
			else
			{
				this.CGDFDPHIENG.localPosition = value;
			}
		}
	}

	// Token: 0x06001A7C RID: 6780 RVA: 0x0000E0FE File Offset: 0x0000C2FE
	public Vector3 HIMMJQGLLGH()
	{
		return this.BGBMIEJJQKC;
	}

	// Token: 0x06001A7D RID: 6781 RVA: 0x000B0B9C File Offset: 0x000AED9C
	public void GIPBBFDPCKG(Vector3 BGBMIEJJQKC)
	{
		if (!(this.FBPOKBEMCEL == null) && this.FBPOKBEMCEL.IEEHOJCLFDJ && !this.MKCNEHFFGKB)
		{
			BGBMIEJJQKC -= this.OPQOIGHGMJB().localPosition;
			JNNGOIIKENH.IMEBEBEGHQI(this.FBPOKBEMCEL, BGBMIEJJQKC.x, BGBMIEJJQKC.y);
		}
		else if (this.MKCNEHFFGKB)
		{
			this.OPQOIGHGMJB().position = BGBMIEJJQKC;
		}
		else
		{
			this.OPQOIGHGMJB().localPosition = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001A7F RID: 6783 RVA: 0x000B0C1C File Offset: 0x000AEE1C
	public static JDMOPNEKJII HHHQDJKJNGF(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 NKKGPNPGDEM, bool MKCNEHFFGKB)
	{
		JDMOPNEKJII jdmopnekjii = UITweener.Begin<JDMOPNEKJII>(CGHIENBIHCO, CPKNEQGKQPQ, 1716f);
		jdmopnekjii.MKCNEHFFGKB = MKCNEHFFGKB;
		jdmopnekjii.CGHQEHCBQHB = jdmopnekjii.BGBMIEJJQKC;
		jdmopnekjii.BKMCCCGOGOM = NKKGPNPGDEM;
		if (CPKNEQGKQPQ <= 1972f)
		{
			jdmopnekjii.Sample(1906f, true);
			jdmopnekjii.enabled = false;
		}
		return jdmopnekjii;
	}

	// Token: 0x04000540 RID: 1344
	public Vector3 CGHQEHCBQHB;

	// Token: 0x04000541 RID: 1345
	public Vector3 BKMCCCGOGOM;

	// Token: 0x04000542 RID: 1346
	[HideInInspector]
	public bool MKCNEHFFGKB;

	// Token: 0x04000543 RID: 1347
	private Transform BLLEFKOLKLP;

	// Token: 0x04000544 RID: 1348
	private BLMNBILNMOE FBPOKBEMCEL;
}
