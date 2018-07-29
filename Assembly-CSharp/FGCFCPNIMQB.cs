using System;
using UnityEngine;

// Token: 0x020000E1 RID: 225
[AddComponentMenu("NGUI/Tween/Tween Volume")]
[RequireComponent(typeof(AudioSource))]
public class FGCFCPNIMQB : UITweener
{
	// Token: 0x06001B23 RID: 6947 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
	public void KPEFQHMGEJC(float BGBMIEJJQKC)
	{
		if (this.LHDCQHQMGMB != null)
		{
			this.EIDCLNMCJQM.volume = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
	public void JQEHPLFNOFD(float BGBMIEJJQKC)
	{
		this.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x0000E4DD File Offset: 0x0000C6DD
	public virtual void QGLGMHGNKKG()
	{
		this.BKMCCCGOGOM = this.PKCFICKIKCJ();
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x000B3CA4 File Offset: 0x000B1EA4
	public AudioSource LHHHIEMILQK()
	{
		if (this.EIDCLNMCJQM == null)
		{
			this.EIDCLNMCJQM = base.GetComponent<AudioSource>();
			if (this.EIDCLNMCJQM == null)
			{
				this.EIDCLNMCJQM = base.GetComponent<AudioSource>();
				if (this.EIDCLNMCJQM == null)
				{
					Debug.LogError("(V)", this);
					base.enabled = false;
				}
			}
		}
		return this.EIDCLNMCJQM;
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x0000E4EB File Offset: 0x0000C6EB
	public virtual void LECEQHOMDLO()
	{
		this.BKMCCCGOGOM = this.BCCIEGQBFKL();
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x0000E4EB File Offset: 0x0000C6EB
	public virtual void PGLHIIQJGHE()
	{
		this.BKMCCCGOGOM = this.BCCIEGQBFKL();
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0000E4F9 File Offset: 0x0000C6F9
	// (set) Token: 0x06001B33 RID: 6963 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
	[Obsolete("Use 'value' instead")]
	public float KKKLPHMOKBP
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

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0000E501 File Offset: 0x0000C701
	// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
	public float BGBMIEJJQKC
	{
		get
		{
			return (!(this.LHDCQHQMGMB != null)) ? 0f : this.EIDCLNMCJQM.volume;
		}
		set
		{
			if (this.LHDCQHQMGMB != null)
			{
				this.EIDCLNMCJQM.volume = value;
			}
		}
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x0000E4DD File Offset: 0x0000C6DD
	public virtual void PMCHLMOELLB()
	{
		this.BKMCCCGOGOM = this.PKCFICKIKCJ();
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x0000E523 File Offset: 0x0000C723
	public float DOQJPGKKHKP()
	{
		return (!(this.LHDCQHQMGMB != null)) ? 450f : this.EIDCLNMCJQM.volume;
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x0000E545 File Offset: 0x0000C745
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x0000E553 File Offset: 0x0000C753
	protected virtual void LMDGINJPDPE(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB * (507f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
		this.EIDCLNMCJQM.enabled = (this.EIDCLNMCJQM.volume > 1805f);
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x0000E4DD File Offset: 0x0000C6DD
	public virtual void KCCHGJMLDOP()
	{
		this.BKMCCCGOGOM = this.PKCFICKIKCJ();
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x0000E5AD File Offset: 0x0000C7AD
	public void KFQHEKBNPDQ(float BGBMIEJJQKC)
	{
		this.DGOHLHBIEBK(BGBMIEJJQKC);
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x0000E5B6 File Offset: 0x0000C7B6
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x0000E5C4 File Offset: 0x0000C7C4
	public float CIOIJEIQDEJ()
	{
		return this.PKCFICKIKCJ();
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x0000E5CC File Offset: 0x0000C7CC
	protected virtual void QDMILBGLJKB(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.KIGFOKPIBHK(this.CGHQEHCBQHB * (995f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
		this.EIDCLNMCJQM.enabled = (this.EIDCLNMCJQM.volume > 889f);
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x0000E545 File Offset: 0x0000C745
	public virtual void NLJFKEQHEBF()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06001B38 RID: 6968 RVA: 0x000B3D0C File Offset: 0x000B1F0C
	public AudioSource LHDCQHQMGMB
	{
		get
		{
			if (this.EIDCLNMCJQM == null)
			{
				this.EIDCLNMCJQM = base.GetComponent<AudioSource>();
				if (this.EIDCLNMCJQM == null)
				{
					this.EIDCLNMCJQM = base.GetComponent<AudioSource>();
					if (this.EIDCLNMCJQM == null)
					{
						Debug.LogError("TweenVolume needs an AudioSource to work with", this);
						base.enabled = false;
					}
				}
			}
			return this.EIDCLNMCJQM;
		}
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x0000E608 File Offset: 0x0000C808
	public void KIGFOKPIBHK(float BGBMIEJJQKC)
	{
		if (this.LHHHIEMILQK() != null)
		{
			this.EIDCLNMCJQM.volume = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x0000E624 File Offset: 0x0000C824
	protected virtual void GLCDMLHOQGQ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.OHECNGBGKCP(this.CGHQEHCBQHB * (1303f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
		this.EIDCLNMCJQM.enabled = (this.EIDCLNMCJQM.volume > 907f);
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x0000E4DD File Offset: 0x0000C6DD
	public virtual void JPIOHGOJBBK()
	{
		this.BKMCCCGOGOM = this.PKCFICKIKCJ();
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
	public void FDQDGHQOPIF(float BGBMIEJJQKC)
	{
		if (this.LHDCQHQMGMB != null)
		{
			this.EIDCLNMCJQM.volume = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x0000E660 File Offset: 0x0000C860
	public float BCCIEGQBFKL()
	{
		return (!(this.LHHHIEMILQK() != null)) ? 1880f : this.EIDCLNMCJQM.volume;
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x000B3D74 File Offset: 0x000B1F74
	public static FGCFCPNIMQB FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BMCKQHKEKKB)
	{
		FGCFCPNIMQB fgcfcpnimqb = UITweener.Begin<FGCFCPNIMQB>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		fgcfcpnimqb.CGHQEHCBQHB = fgcfcpnimqb.BGBMIEJJQKC;
		fgcfcpnimqb.BKMCCCGOGOM = BMCKQHKEKKB;
		if (BMCKQHKEKKB > 0f)
		{
			AudioSource lhdcqhqmgmb = fgcfcpnimqb.LHDCQHQMGMB;
			lhdcqhqmgmb.enabled = true;
			lhdcqhqmgmb.Play();
		}
		return fgcfcpnimqb;
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x000B3DC0 File Offset: 0x000B1FC0
	public static FGCFCPNIMQB QQNLCFBGFKC(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BMCKQHKEKKB)
	{
		FGCFCPNIMQB fgcfcpnimqb = UITweener.Begin<FGCFCPNIMQB>(CGHIENBIHCO, CPKNEQGKQPQ, 740f);
		fgcfcpnimqb.CGHQEHCBQHB = fgcfcpnimqb.BCCIEGQBFKL();
		fgcfcpnimqb.BKMCCCGOGOM = BMCKQHKEKKB;
		if (BMCKQHKEKKB > 322f)
		{
			AudioSource audioSource = fgcfcpnimqb.LHHHIEMILQK();
			audioSource.enabled = false;
			audioSource.Play();
		}
		return fgcfcpnimqb;
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x0000E682 File Offset: 0x0000C882
	public void FHMPCLOOGKC(float BGBMIEJJQKC)
	{
		this.OHECNGBGKCP(BGBMIEJJQKC);
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
	public void OHECNGBGKCP(float BGBMIEJJQKC)
	{
		if (this.LHDCQHQMGMB != null)
		{
			this.EIDCLNMCJQM.volume = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x0000E68B File Offset: 0x0000C88B
	public virtual void JMHCCGEHJDF()
	{
		this.BKMCCCGOGOM = this.DOQJPGKKHKP();
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
	public void NLFMEBBPGDN(float BGBMIEJJQKC)
	{
		if (this.LHDCQHQMGMB != null)
		{
			this.EIDCLNMCJQM.volume = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x000B3E0C File Offset: 0x000B200C
	public static FGCFCPNIMQB DCMLJEIPFMF(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BMCKQHKEKKB)
	{
		FGCFCPNIMQB fgcfcpnimqb = UITweener.Begin<FGCFCPNIMQB>(CGHIENBIHCO, CPKNEQGKQPQ, 1982f);
		fgcfcpnimqb.CGHQEHCBQHB = fgcfcpnimqb.BGBMIEJJQKC;
		fgcfcpnimqb.BKMCCCGOGOM = BMCKQHKEKKB;
		if (BMCKQHKEKKB > 232f)
		{
			AudioSource lhdcqhqmgmb = fgcfcpnimqb.LHDCQHQMGMB;
			lhdcqhqmgmb.enabled = true;
			lhdcqhqmgmb.Play();
		}
		return fgcfcpnimqb;
	}

	// Token: 0x06001B45 RID: 6981 RVA: 0x0000E699 File Offset: 0x0000C899
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB * (1f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
		this.EIDCLNMCJQM.enabled = (this.EIDCLNMCJQM.volume > 0.01f);
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x0000E5B6 File Offset: 0x0000C7B6
	public virtual void IEMEFIDMKMI()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
	public void DGOHLHBIEBK(float BGBMIEJJQKC)
	{
		if (this.LHDCQHQMGMB != null)
		{
			this.EIDCLNMCJQM.volume = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x0000E6D5 File Offset: 0x0000C8D5
	public float PKCFICKIKCJ()
	{
		return (!(this.LHDCQHQMGMB != null)) ? 1585f : this.EIDCLNMCJQM.volume;
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x0000E608 File Offset: 0x0000C808
	public void DCLFPNMBHII(float BGBMIEJJQKC)
	{
		if (this.LHHHIEMILQK() != null)
		{
			this.EIDCLNMCJQM.volume = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x000B3E58 File Offset: 0x000B2058
	public static FGCFCPNIMQB KBGFGBELJOG(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BMCKQHKEKKB)
	{
		FGCFCPNIMQB fgcfcpnimqb = UITweener.Begin<FGCFCPNIMQB>(CGHIENBIHCO, CPKNEQGKQPQ, 1383f);
		fgcfcpnimqb.CGHQEHCBQHB = fgcfcpnimqb.BGBMIEJJQKC;
		fgcfcpnimqb.BKMCCCGOGOM = BMCKQHKEKKB;
		if (BMCKQHKEKKB > 1411f)
		{
			AudioSource audioSource = fgcfcpnimqb.LHHHIEMILQK();
			audioSource.enabled = false;
			audioSource.Play();
		}
		return fgcfcpnimqb;
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x0000E6F7 File Offset: 0x0000C8F7
	protected virtual void OBEHKKHPHQM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.KIGFOKPIBHK(this.CGHQEHCBQHB * (979f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
		this.EIDCLNMCJQM.enabled = (this.EIDCLNMCJQM.volume > 539f);
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x0000E733 File Offset: 0x0000C933
	protected virtual void DPBHFMKGFKH(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.DCLFPNMBHII(this.CGHQEHCBQHB * (1821f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
		this.EIDCLNMCJQM.enabled = (this.EIDCLNMCJQM.volume > 1893f);
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x0000E682 File Offset: 0x0000C882
	public void QQNNJCDKNLI(float BGBMIEJJQKC)
	{
		this.OHECNGBGKCP(BGBMIEJJQKC);
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x0000E608 File Offset: 0x0000C808
	public void QOLLFLKGKHM(float BGBMIEJJQKC)
	{
		if (this.LHHHIEMILQK() != null)
		{
			this.EIDCLNMCJQM.volume = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x000B3EA4 File Offset: 0x000B20A4
	public static FGCFCPNIMQB QNGIMPBJBHC(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BMCKQHKEKKB)
	{
		FGCFCPNIMQB fgcfcpnimqb = UITweener.Begin<FGCFCPNIMQB>(CGHIENBIHCO, CPKNEQGKQPQ, 1553f);
		fgcfcpnimqb.CGHQEHCBQHB = fgcfcpnimqb.BGBMIEJJQKC;
		fgcfcpnimqb.BKMCCCGOGOM = BMCKQHKEKKB;
		if (BMCKQHKEKKB > 1701f)
		{
			AudioSource lhdcqhqmgmb = fgcfcpnimqb.LHDCQHQMGMB;
			lhdcqhqmgmb.enabled = true;
			lhdcqhqmgmb.Play();
		}
		return fgcfcpnimqb;
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x0000E76F File Offset: 0x0000C96F
	public void DCHFKONJKBE(float BGBMIEJJQKC)
	{
		this.FDQDGHQOPIF(BGBMIEJJQKC);
	}

	// Token: 0x04000555 RID: 1365
	[Range(0f, 1f)]
	public float CGHQEHCBQHB = 1f;

	// Token: 0x04000556 RID: 1366
	[Range(0f, 1f)]
	public float BKMCCCGOGOM = 1f;

	// Token: 0x04000557 RID: 1367
	private AudioSource EIDCLNMCJQM;
}
