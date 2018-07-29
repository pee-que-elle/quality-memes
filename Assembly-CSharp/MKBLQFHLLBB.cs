using System;
using UnityEngine;

// Token: 0x020000E0 RID: 224
[AddComponentMenu("NGUI/Tween/Tween Transform")]
public class MKBLQFHLLBB : UITweener
{
	// Token: 0x06001AE7 RID: 6887 RVA: 0x000B1550 File Offset: 0x000AF750
	public static MKBLQFHLLBB QMLJPLKDBPH(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 149f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1298f)
		{
			mkblqfhllbb.Sample(1602f, false);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x000B1594 File Offset: 0x000AF794
	protected virtual void JKMNHIQGNLC(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1195f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1224f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (599f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (822f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x000B1750 File Offset: 0x000AF950
	public static MKBLQFHLLBB IIHGOIKDDNC(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 968f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1186f)
		{
			mkblqfhllbb.Sample(1886f, false);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x000B1794 File Offset: 0x000AF994
	public static MKBLQFHLLBB PDONGLJCDEI(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 452f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 648f)
		{
			mkblqfhllbb.Sample(868f, true);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x000B17D8 File Offset: 0x000AF9D8
	public static MKBLQFHLLBB BMMHNKJOLJN(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1654f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1801f)
		{
			mkblqfhllbb.Sample(771f, false);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x0000E43F File Offset: 0x0000C63F
	public static MKBLQFHLLBB QNGIMPBJBHC(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.FJCEGFKJLCL(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x0000E44A File Offset: 0x0000C64A
	public static MKBLQFHLLBB DNOIDPMHHMD(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.MQFKJFQGDQL(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x000B181C File Offset: 0x000AFA1C
	public static MKBLQFHLLBB MQFKJFQGDQL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1656f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 897f)
		{
			mkblqfhllbb.Sample(881f, true);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x000B1860 File Offset: 0x000AFA60
	protected virtual void IIHBCFBCFMG(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (33f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (654f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (1773f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1961f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x0000E455 File Offset: 0x0000C655
	public static MKBLQFHLLBB HHHQDJKJNGF(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.IIHGOIKDDNC(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x000B1A1C File Offset: 0x000AFC1C
	public static MKBLQFHLLBB PCNQDPHGDFJ(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 900f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 120f)
		{
			mkblqfhllbb.Sample(1041f, false);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x000B1A60 File Offset: 0x000AFC60
	protected virtual void DLKDCMBPIJJ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1312f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (214f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (584f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1043f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x000B1C1C File Offset: 0x000AFE1C
	public static MKBLQFHLLBB HBKJPKECJFK(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 677f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1815f)
		{
			mkblqfhllbb.Sample(1589f, false);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AF5 RID: 6901 RVA: 0x000B1C60 File Offset: 0x000AFE60
	protected virtual void IFPLHKJHDHJ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1543f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1030f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (32f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1220f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x000B1E1C File Offset: 0x000B001C
	protected virtual void KEBEJMQCIPD(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (58f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1816f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (302f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (294f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x0000E460 File Offset: 0x0000C660
	public static MKBLQFHLLBB OBMOOJBJECD(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.KFNDPIDQFMK(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x000B1FD8 File Offset: 0x000B01D8
	public static MKBLQFHLLBB FEBFHOPOJQN(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 55f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 169f)
		{
			mkblqfhllbb.Sample(993f, false);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x000B201C File Offset: 0x000B021C
	protected virtual void GFKNDQHJKMJ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (254f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (408f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (1026f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (947f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x0000E46B File Offset: 0x0000C66B
	public static MKBLQFHLLBB LQDNEDLHCIH(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.FOFLFHJBIOL(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x000B21D8 File Offset: 0x000B03D8
	protected virtual void BOELOGNMNQN(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1258f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (252f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (793f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1411f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x000B2394 File Offset: 0x000B0594
	public static MKBLQFHLLBB BIIGMIBHDFJ(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1924f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1293f)
		{
			mkblqfhllbb.Sample(818f, true);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x000B23D8 File Offset: 0x000B05D8
	public static MKBLQFHLLBB OCMMDMEGGOC(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1256f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 27f)
		{
			mkblqfhllbb.Sample(646f, false);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x000B241C File Offset: 0x000B061C
	public static MKBLQFHLLBB DKBOBCIJGBE(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 86f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1757f)
		{
			mkblqfhllbb.Sample(148f, false);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x000B2460 File Offset: 0x000B0660
	protected virtual void NCDPHIQEPHD(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (889f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1413f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (1242f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1369f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x000B261C File Offset: 0x000B081C
	protected virtual void PGLLINKQBFM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (487f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1254f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (964f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1966f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x0000E476 File Offset: 0x0000C676
	public static MKBLQFHLLBB HHOCDFFIBBP(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.QQNLCFBGFKC(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x000B27D8 File Offset: 0x000B09D8
	public static MKBLQFHLLBB FJJKIOEHKDG(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 15f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 228f)
		{
			mkblqfhllbb.Sample(1965f, false);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B03 RID: 6915 RVA: 0x000B281C File Offset: 0x000B0A1C
	protected virtual void GICJPIPQOPI(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1447f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (793f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (269f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1764f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B04 RID: 6916 RVA: 0x0000E481 File Offset: 0x0000C681
	public static MKBLQFHLLBB LMHHLNILKML(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.DKBOBCIJGBE(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x0000E455 File Offset: 0x0000C655
	public static MKBLQFHLLBB MJQNQQLKJHN(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.IIHGOIKDDNC(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B06 RID: 6918 RVA: 0x000B29D8 File Offset: 0x000B0BD8
	public static MKBLQFHLLBB FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 0f)
		{
			mkblqfhllbb.Sample(1f, true);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B07 RID: 6919 RVA: 0x000B2A1C File Offset: 0x000B0C1C
	public static MKBLQFHLLBB KFNDPIDQFMK(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1390f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 905f)
		{
			mkblqfhllbb.Sample(1491f, false);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B08 RID: 6920 RVA: 0x0000E48C File Offset: 0x0000C68C
	public static MKBLQFHLLBB CODDQEHNPOB(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.FEBFHOPOJQN(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B09 RID: 6921 RVA: 0x000B2A60 File Offset: 0x000B0C60
	public static MKBLQFHLLBB HKMCPJEEDLI(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1491f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 586f)
		{
			mkblqfhllbb.Sample(1347f, true);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x000B2AA4 File Offset: 0x000B0CA4
	protected virtual void GLHLBNHDKEF(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (401f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (50f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (1267f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1185f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x0000E497 File Offset: 0x0000C697
	public static MKBLQFHLLBB JICIPLDJQIG(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.KOQONHCCKLE(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x000B2C60 File Offset: 0x000B0E60
	public static MKBLQFHLLBB PPMFEQFJLNB(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1449f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 512f)
		{
			mkblqfhllbb.Sample(434f, true);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x000B2CA4 File Offset: 0x000B0EA4
	protected virtual void GCBIDJHMNOJ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1232f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1912f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (1170f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (510f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x0000E4A2 File Offset: 0x0000C6A2
	public static MKBLQFHLLBB HONHPLNBHJQ(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.KKOFKCHPCID(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x000B2E60 File Offset: 0x000B1060
	protected virtual void ODNPFCOPBON(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (307f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (820f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (675f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (478f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x000B301C File Offset: 0x000B121C
	public static MKBLQFHLLBB MONBDFEFCGB(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 289f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1733f)
		{
			mkblqfhllbb.Sample(13f, false);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B11 RID: 6929 RVA: 0x000B3060 File Offset: 0x000B1260
	public static MKBLQFHLLBB KKOFKCHPCID(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 701f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1629f)
		{
			mkblqfhllbb.Sample(1148f, true);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B12 RID: 6930 RVA: 0x000B30A4 File Offset: 0x000B12A4
	public static MKBLQFHLLBB PLGGKPOEEQP(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 402f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 397f)
		{
			mkblqfhllbb.Sample(1787f, false);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B13 RID: 6931 RVA: 0x000B30E8 File Offset: 0x000B12E8
	protected virtual void OLHPEOBNNGF(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1290f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1022f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (1577f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (582f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B14 RID: 6932 RVA: 0x000B32A4 File Offset: 0x000B14A4
	public static MKBLQFHLLBB NQHPIQDFLKH(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1008f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1968f)
		{
			mkblqfhllbb.Sample(1024f, true);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B15 RID: 6933 RVA: 0x000B32E8 File Offset: 0x000B14E8
	protected virtual void OKKFQEJJKPI(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1044f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1531f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (245f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (756f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x000B34A4 File Offset: 0x000B16A4
	protected virtual void BQMNGOKLKCD(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (185f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1939f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (213f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1124f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x0000E4AD File Offset: 0x0000C6AD
	public static MKBLQFHLLBB HHJPMHOKPKM(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.PLGGKPOEEQP(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x000B3660 File Offset: 0x000B1860
	public static MKBLQFHLLBB FOFLFHJBIOL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 756f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1897f)
		{
			mkblqfhllbb.Sample(206f, true);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x0000E46B File Offset: 0x0000C66B
	public static MKBLQFHLLBB HKJBBPFGGIH(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.FOFLFHJBIOL(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B1A RID: 6938 RVA: 0x000B36A4 File Offset: 0x000B18A4
	public static MKBLQFHLLBB KOQONHCCKLE(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 657f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 108f)
		{
			mkblqfhllbb.Sample(1686f, true);
			mkblqfhllbb.enabled = true;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B1B RID: 6939 RVA: 0x000B36E8 File Offset: 0x000B18E8
	protected virtual void QJJCMPCHKKL(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1486f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1719f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (1998f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (375f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x000B38A4 File Offset: 0x000B1AA4
	protected virtual void QIHHPHFGIED(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1340f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (655f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (1819f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1896f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x000B3A60 File Offset: 0x000B1C60
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		if (this.BKMCCCGOGOM != null)
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
				this.GKHOGHHONGB = this.BLLEFKOLKLP.position;
				this.NCDILLHBJPI = this.BLLEFKOLKLP.rotation;
				this.DGEGGLFHBKO = this.BLLEFKOLKLP.localScale;
			}
			if (this.CGHQEHCBQHB != null)
			{
				this.BLLEFKOLKLP.position = this.CGHQEHCBQHB.position * (1f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.CGHQEHCBQHB.localScale * (1f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.CGHQEHCBQHB.rotation, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			else
			{
				this.BLLEFKOLKLP.position = this.GKHOGHHONGB * (1f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.position * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.localScale = this.DGEGGLFHBKO * (1f - PJDGFDBEOOJ) + this.BKMCCCGOGOM.localScale * PJDGFDBEOOJ;
				this.BLLEFKOLKLP.rotation = Quaternion.Slerp(this.NCDILLHBJPI, this.BKMCCCGOGOM.rotation, PJDGFDBEOOJ);
			}
			if (this.GLHOBLBQKPP && IJKDMCLDHNL)
			{
				this.BLLEFKOLKLP.parent = this.BKMCCCGOGOM;
			}
		}
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x0000E43F File Offset: 0x0000C63F
	public static MKBLQFHLLBB FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.FJCEGFKJLCL(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x000B3C1C File Offset: 0x000B1E1C
	public static MKBLQFHLLBB QQNLCFBGFKC(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1362f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1286f)
		{
			mkblqfhllbb.Sample(989f, true);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x0000E460 File Offset: 0x0000C660
	public static MKBLQFHLLBB KJJQQBDHLJE(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.KFNDPIDQFMK(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x0000E43F File Offset: 0x0000C63F
	public static MKBLQFHLLBB DCDBEJPIGJK(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform BKMCCCGOGOM)
	{
		return MKBLQFHLLBB.FJCEGFKJLCL(CGHIENBIHCO, CPKNEQGKQPQ, null, BKMCCCGOGOM);
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x000B3C60 File Offset: 0x000B1E60
	public static MKBLQFHLLBB BHNPPCIDQMD(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Transform CGHQEHCBQHB, Transform BKMCCCGOGOM)
	{
		MKBLQFHLLBB mkblqfhllbb = UITweener.Begin<MKBLQFHLLBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1632f);
		mkblqfhllbb.CGHQEHCBQHB = CGHQEHCBQHB;
		mkblqfhllbb.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 733f)
		{
			mkblqfhllbb.Sample(483f, false);
			mkblqfhllbb.enabled = false;
		}
		return mkblqfhllbb;
	}

	// Token: 0x0400054E RID: 1358
	public Transform CGHQEHCBQHB;

	// Token: 0x0400054F RID: 1359
	public Transform BKMCCCGOGOM;

	// Token: 0x04000550 RID: 1360
	public bool GLHOBLBQKPP;

	// Token: 0x04000551 RID: 1361
	private Transform BLLEFKOLKLP;

	// Token: 0x04000552 RID: 1362
	private Vector3 GKHOGHHONGB;

	// Token: 0x04000553 RID: 1363
	private Quaternion NCDILLHBJPI;

	// Token: 0x04000554 RID: 1364
	private Vector3 DGEGGLFHBKO;
}
