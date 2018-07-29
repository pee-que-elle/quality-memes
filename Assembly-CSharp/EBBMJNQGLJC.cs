using System;
using UnityEngine;

// Token: 0x020001C4 RID: 452
public class EBBMJNQGLJC : MonoBehaviour
{
	// Token: 0x0600396B RID: 14699 RVA: 0x000189CE File Offset: 0x00016BCE
	private void ECEBHPJHOCO()
	{
		this.LIQFBHNQCID.enabled = false;
	}

	// Token: 0x0600396C RID: 14700 RVA: 0x001B3198 File Offset: 0x001B1398
	public void JCNJFKCOBOK(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 1 && CIQFCJGQEMH < -23)
		{
			base.CancelInvoke("Weak Armor");
			this.LIQFBHNQCID.LGJOOQIBQDC(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.DNDHIMFCIQD().width;
			this.LIQFBHNQCID.DFKQMMIQDOO = this.LIQFBHNQCID.DNDHIMFCIQD().height;
			this.LIQFBHNQCID.enabled = false;
			base.Invoke("pressure", MOGLGJGFNDM);
		}
	}

	// Token: 0x0600396D RID: 14701 RVA: 0x000189DC File Offset: 0x00016BDC
	private void QPPKCBEDGQC()
	{
		this.LIQFBHNQCID.enabled = true;
	}

	// Token: 0x0600396E RID: 14702 RVA: 0x000189CE File Offset: 0x00016BCE
	private void KBGBDQBILIM()
	{
		this.LIQFBHNQCID.enabled = false;
	}

	// Token: 0x0600396F RID: 14703 RVA: 0x001B3228 File Offset: 0x001B1428
	public void ONOOKCBOPEF(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 1 && CIQFCJGQEMH < 31)
		{
			base.CancelInvoke("HideEmote");
			this.LIQFBHNQCID.KCLBMPFIPNQ = CIQFCJGQEMH.ToString();
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.GEMEQGBOLIP().width;
			this.LIQFBHNQCID.DFKQMMIQDOO = this.LIQFBHNQCID.GEMEQGBOLIP().height;
			this.LIQFBHNQCID.enabled = true;
			base.Invoke("HideEmote", MOGLGJGFNDM);
		}
	}

	// Token: 0x06003970 RID: 14704 RVA: 0x001B32B8 File Offset: 0x001B14B8
	private void QBGOGFJCLEP()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError(")_-", this);
			base.enabled = true;
		}
		this.JENJBIBHIHN();
		KGQECFKLKOP.IPOEOCFGEIP += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 0;
		this.BLIMQGKOEEN();
	}

	// Token: 0x06003971 RID: 14705 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC BJLGEDCPENQ()
	{
		return EBBMJNQGLJC.HBFFCJHOCPE;
	}

	// Token: 0x06003972 RID: 14706 RVA: 0x001B335C File Offset: 0x001B155C
	private void GNLCOJOJFBI()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("miniorcore", this);
			base.enabled = true;
		}
		this.LGFFLHHMBHH();
		KGQECFKLKOP.IPOEOCFGEIP += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 7;
		this.QKFHMEPQGCQ();
	}

	// Token: 0x06003973 RID: 14707 RVA: 0x001B3400 File Offset: 0x001B1600
	private void JHHCDBMCCFD()
	{
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 518f;
		this.BLLEFKOLKLP.localPosition = vector;
	}

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x06003974 RID: 14708 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC QOQONHOOLNE
	{
		get
		{
			return EBBMJNQGLJC.HBFFCJHOCPE;
		}
	}

	// Token: 0x06003975 RID: 14709 RVA: 0x001B3494 File Offset: 0x001B1694
	public void NJOLNFHKOHL(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 0 && CIQFCJGQEMH < 113)
		{
			base.CancelInvoke("Max:");
			this.LIQFBHNQCID.IQBBDKFDGGP(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.DNDHIMFCIQD().width;
			this.LIQFBHNQCID.DFKQMMIQDOO = this.LIQFBHNQCID.DNDHIMFCIQD().height;
			this.LIQFBHNQCID.enabled = true;
			base.Invoke("Boosts evasion in a hailstorm.", MOGLGJGFNDM);
		}
	}

	// Token: 0x06003976 RID: 14710 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC DJMGOBBECCK()
	{
		return EBBMJNQGLJC.HBFFCJHOCPE;
	}

	// Token: 0x06003977 RID: 14711 RVA: 0x001B3524 File Offset: 0x001B1724
	private void MHDGGOODPGB()
	{
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 69f;
		this.BLLEFKOLKLP.localPosition = vector;
	}

	// Token: 0x06003978 RID: 14712 RVA: 0x000189CE File Offset: 0x00016BCE
	private void HKQIBBBOLID()
	{
		this.LIQFBHNQCID.enabled = false;
	}

	// Token: 0x06003979 RID: 14713 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC CLDLLKMCPDK()
	{
		return EBBMJNQGLJC.HBFFCJHOCPE;
	}

	// Token: 0x0600397A RID: 14714 RVA: 0x001B35B8 File Offset: 0x001B17B8
	private void PGFHJKDGEMJ()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("Trade Error", this);
			base.enabled = true;
		}
		this.JENJBIBHIHN();
		KGQECFKLKOP.IPOEOCFGEIP++;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 7;
		this.JMEHPFPKPKD();
	}

	// Token: 0x0600397B RID: 14715 RVA: 0x001B365C File Offset: 0x001B185C
	private void LBIFHHFMPHD()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("Water", this);
			base.enabled = true;
		}
		this.LGFFLHHMBHH();
		KGQECFKLKOP.IPOEOCFGEIP += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 2;
		this.MQCIJICIMLB();
	}

	// Token: 0x0600397C RID: 14716 RVA: 0x001B3700 File Offset: 0x001B1900
	private void LBJDMFQGMLL()
	{
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 985f;
		this.BLLEFKOLKLP.localPosition = vector;
	}

	// Token: 0x0600397D RID: 14717 RVA: 0x000189F1 File Offset: 0x00016BF1
	public void QKFHMEPQGCQ()
	{
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 1;
	}

	// Token: 0x0600397E RID: 14718 RVA: 0x001B3794 File Offset: 0x001B1994
	private void OCQCDGIEDLK()
	{
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 544f;
		this.BLLEFKOLKLP.localPosition = vector;
	}

	// Token: 0x0600397F RID: 14719 RVA: 0x001B3828 File Offset: 0x001B1A28
	private void KHEJGQPPFOC()
	{
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1805f;
		this.BLLEFKOLKLP.localPosition = vector;
	}

	// Token: 0x06003980 RID: 14720 RVA: 0x001B38BC File Offset: 0x001B1ABC
	private void GJPGBCKQLDG()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("_WaveScale4", this);
			base.enabled = true;
		}
		this.PFFDCHBDDIL();
		KGQECFKLKOP.IPOEOCFGEIP += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 3;
		this.FIKJJBMPNBH();
	}

	// Token: 0x06003981 RID: 14721 RVA: 0x00018A06 File Offset: 0x00016C06
	public void GPJHOFPFCJD()
	{
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 5;
	}

	// Token: 0x06003982 RID: 14722 RVA: 0x001B3960 File Offset: 0x001B1B60
	public void GJJMFEIHCJO(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 0 && CIQFCJGQEMH < 80)
		{
			base.CancelInvoke("p");
			this.LIQFBHNQCID.LGJOOQIBQDC(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.DNDHIMFCIQD().width;
			this.LIQFBHNQCID.DFKQMMIQDOO = this.LIQFBHNQCID.JNCLIGQMCIQ().height;
			this.LIQFBHNQCID.enabled = true;
			base.Invoke("Script:", MOGLGJGFNDM);
		}
	}

	// Token: 0x06003983 RID: 14723 RVA: 0x001B39F0 File Offset: 0x001B1BF0
	private void NNPPKOGDNOM()
	{
		EBBMJNQGLJC.HBFFCJHOCPE = this;
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(50f, 673f, 1969f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.DEGEQEPOLOC();
		}
	}

	// Token: 0x06003984 RID: 14724 RVA: 0x001B3A90 File Offset: 0x001B1C90
	private void Start()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("Expected to have 'target' set to a valid transform", this);
			base.enabled = false;
		}
		this.HideEmote();
		KGQECFKLKOP.IPOEOCFGEIP++;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 4;
		this.GMFNGEPKPME();
	}

	// Token: 0x06003985 RID: 14725 RVA: 0x001B3B34 File Offset: 0x001B1D34
	private void PKMPEFHBDEE()
	{
		EBBMJNQGLJC.HBFFCJHOCPE = this;
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1265f, 1493f, 1219f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.DHJQCGFQONM();
		}
	}

	// Token: 0x06003986 RID: 14726 RVA: 0x000189DC File Offset: 0x00016BDC
	private void JENJBIBHIHN()
	{
		this.LIQFBHNQCID.enabled = true;
	}

	// Token: 0x06003987 RID: 14727 RVA: 0x001B3BD4 File Offset: 0x001B1DD4
	public void FFLKCCJMKMP(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 0 && CIQFCJGQEMH < 36)
		{
			base.CancelInvoke("Rainbow Badge");
			this.LIQFBHNQCID.KCLBMPFIPNQ = CIQFCJGQEMH.ToString();
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.JNCLIGQMCIQ().width;
			this.LIQFBHNQCID.DFKQMMIQDOO = this.LIQFBHNQCID.GEMEQGBOLIP().height;
			this.LIQFBHNQCID.enabled = false;
			base.Invoke(" sprang up!\r\n", MOGLGJGFNDM);
		}
	}

	// Token: 0x06003988 RID: 14728 RVA: 0x001B3C64 File Offset: 0x001B1E64
	public void HPHPONPKQIH(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 0 && CIQFCJGQEMH < -15)
		{
			base.CancelInvoke("spectator");
			this.LIQFBHNQCID.IQBBDKFDGGP(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.JNCLIGQMCIQ().width;
			this.LIQFBHNQCID.MGQIGGNBBBD(this.LIQFBHNQCID.DNDHIMFCIQD().height);
			this.LIQFBHNQCID.enabled = false;
			base.Invoke("Forward Focus", MOGLGJGFNDM);
		}
	}

	// Token: 0x06003989 RID: 14729 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC ODEDDOBINNE()
	{
		return EBBMJNQGLJC.HBFFCJHOCPE;
	}

	// Token: 0x0600398A RID: 14730 RVA: 0x00018A06 File Offset: 0x00016C06
	public void PPLNDGLBPOJ()
	{
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 5;
	}

	// Token: 0x0600398B RID: 14731 RVA: 0x00018A1B File Offset: 0x00016C1B
	public void LPCFKJMLFBN()
	{
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 8;
	}

	// Token: 0x0600398C RID: 14732 RVA: 0x001B3CF4 File Offset: 0x001B1EF4
	private void BOPOJKGDCDL()
	{
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1470f;
		this.BLLEFKOLKLP.localPosition = vector;
	}

	// Token: 0x0600398E RID: 14734 RVA: 0x001B3D88 File Offset: 0x001B1F88
	private void GGCEHHPCGQF()
	{
		EBBMJNQGLJC.HBFFCJHOCPE = this;
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(76f, 1620f, 1038f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.DGEJMBLGKDC();
		}
	}

	// Token: 0x0600398F RID: 14735 RVA: 0x001B3E28 File Offset: 0x001B2028
	private void Awake()
	{
		EBBMJNQGLJC.HBFFCJHOCPE = this;
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(-1000f, 1000f, 0f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.HideEmote();
		}
	}

	// Token: 0x06003990 RID: 14736 RVA: 0x000189CE File Offset: 0x00016BCE
	private void DEGEQEPOLOC()
	{
		this.LIQFBHNQCID.enabled = false;
	}

	// Token: 0x06003991 RID: 14737 RVA: 0x001B3EC8 File Offset: 0x001B20C8
	private void DPMNBIMDLIM()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("[PG]", this);
			base.enabled = false;
		}
		this.ECEBHPJHOCO();
		KGQECFKLKOP.IPOEOCFGEIP += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 0;
		this.HPBHGLFFGCD();
	}

	// Token: 0x06003992 RID: 14738 RVA: 0x001B3F6C File Offset: 0x001B216C
	public void GQIKBNHJCDD(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 0 && CIQFCJGQEMH < -11)
		{
			base.CancelInvoke("flowerveil");
			this.LIQFBHNQCID.JOHBNEHCEJH(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.JNCLIGQMCIQ().width;
			this.LIQFBHNQCID.DFKQMMIQDOO = this.LIQFBHNQCID.GEMEQGBOLIP().height;
			this.LIQFBHNQCID.enabled = true;
			base.Invoke("/510)", MOGLGJGFNDM);
		}
	}

	// Token: 0x06003993 RID: 14739 RVA: 0x001B3FFC File Offset: 0x001B21FC
	public void IPHLMKHDQEO(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 0 && CIQFCJGQEMH < -107)
		{
			base.CancelInvoke("party");
			this.LIQFBHNQCID.JOHBNEHCEJH(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.JNCLIGQMCIQ().width;
			this.LIQFBHNQCID.MGQIGGNBBBD(this.LIQFBHNQCID.JNCLIGQMCIQ().height);
			this.LIQFBHNQCID.enabled = true;
			base.Invoke("J10", MOGLGJGFNDM);
		}
	}

	// Token: 0x06003994 RID: 14740 RVA: 0x00018A51 File Offset: 0x00016C51
	public void GMFNGEPKPME()
	{
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
	}

	// Token: 0x06003995 RID: 14741 RVA: 0x001B408C File Offset: 0x001B228C
	private void DDBBNJKJCKG()
	{
		EBBMJNQGLJC.HBFFCJHOCPE = this;
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(878f, 398f, 1487f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.PNGPQEKJEQM();
		}
	}

	// Token: 0x06003996 RID: 14742 RVA: 0x001B412C File Offset: 0x001B232C
	public void PEDGDKNILGB(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 1 && CIQFCJGQEMH < -75)
		{
			base.CancelInvoke(" surrounds itself with electrified terrain!\r\n");
			this.LIQFBHNQCID.LGJOOQIBQDC(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.GEMEQGBOLIP().width;
			this.LIQFBHNQCID.DFKQMMIQDOO = this.LIQFBHNQCID.GEMEQGBOLIP().height;
			this.LIQFBHNQCID.enabled = false;
			base.Invoke("Snow Warning", MOGLGJGFNDM);
		}
	}

	// Token: 0x06003997 RID: 14743 RVA: 0x00018A66 File Offset: 0x00016C66
	public void MQCIJICIMLB()
	{
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 4;
	}

	// Token: 0x06003998 RID: 14744 RVA: 0x000189CE File Offset: 0x00016BCE
	private void PNGPQEKJEQM()
	{
		this.LIQFBHNQCID.enabled = false;
	}

	// Token: 0x06003999 RID: 14745 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC CLPQIKCDHPP()
	{
		return EBBMJNQGLJC.HBFFCJHOCPE;
	}

	// Token: 0x0600399A RID: 14746 RVA: 0x00018A7B File Offset: 0x00016C7B
	public void BLIMQGKOEEN()
	{
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 0;
	}

	// Token: 0x0600399B RID: 14747 RVA: 0x001B41BC File Offset: 0x001B23BC
	public void LLEMLEJHOHD(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 1 && CIQFCJGQEMH < 118)
		{
			base.CancelInvoke("achievement");
			this.LIQFBHNQCID.OGQLCMOFLLQ(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.DNDHIMFCIQD().width;
			this.LIQFBHNQCID.DFKQMMIQDOO = this.LIQFBHNQCID.DNDHIMFCIQD().height;
			this.LIQFBHNQCID.enabled = true;
			base.Invoke("'s illusion wore off!\r\n", MOGLGJGFNDM);
		}
	}

	// Token: 0x0600399C RID: 14748 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC DPJQQGKEIIF()
	{
		return EBBMJNQGLJC.HBFFCJHOCPE;
	}

	// Token: 0x0600399D RID: 14749 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC OKKCFHDIDIF()
	{
		return EBBMJNQGLJC.HBFFCJHOCPE;
	}

	// Token: 0x0600399E RID: 14750 RVA: 0x001B424C File Offset: 0x001B244C
	private void OEOJDKBDNMJ()
	{
		EBBMJNQGLJC.HBFFCJHOCPE = this;
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(740f, 701f, 899f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.DGEJMBLGKDC();
		}
	}

	// Token: 0x0600399F RID: 14751 RVA: 0x001B42EC File Offset: 0x001B24EC
	public void OIPMOOBEKIC(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 1 && CIQFCJGQEMH < 19)
		{
			base.CancelInvoke("-mega");
			this.LIQFBHNQCID.DPBGHDMHKNC(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.DNDHIMFCIQD().width;
			this.LIQFBHNQCID.DFKQMMIQDOO = this.LIQFBHNQCID.DNDHIMFCIQD().height;
			this.LIQFBHNQCID.enabled = false;
			base.Invoke("forewarn", MOGLGJGFNDM);
		}
	}

	// Token: 0x060039A0 RID: 14752 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC PFQBLOEPBJB()
	{
		return EBBMJNQGLJC.HBFFCJHOCPE;
	}

	// Token: 0x060039A1 RID: 14753 RVA: 0x000189DC File Offset: 0x00016BDC
	private void DGEJMBLGKDC()
	{
		this.LIQFBHNQCID.enabled = true;
	}

	// Token: 0x060039A2 RID: 14754 RVA: 0x001B437C File Offset: 0x001B257C
	public void DNMBDNDQIQH(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 0 && CIQFCJGQEMH < -22)
		{
			base.CancelInvoke("'s can't use its sealed [ffff00]");
			this.LIQFBHNQCID.OGQLCMOFLLQ(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.DNDHIMFCIQD().width;
			this.LIQFBHNQCID.MGQIGGNBBBD(this.LIQFBHNQCID.GEMEQGBOLIP().height);
			this.LIQFBHNQCID.enabled = false;
			base.Invoke("Open", MOGLGJGFNDM);
		}
	}

	// Token: 0x060039A3 RID: 14755 RVA: 0x000189F1 File Offset: 0x00016BF1
	public void JMEHPFPKPKD()
	{
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 1;
	}

	// Token: 0x060039A4 RID: 14756 RVA: 0x001B440C File Offset: 0x001B260C
	private void CPNQCCCNPMM()
	{
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1460f;
		this.BLLEFKOLKLP.localPosition = vector;
	}

	// Token: 0x060039A5 RID: 14757 RVA: 0x001B44A0 File Offset: 0x001B26A0
	private void NOBDHBBKKHN()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("Temp Sound Clip", this);
			base.enabled = false;
		}
		this.LGFFLHHMBHH();
		KGQECFKLKOP.IPOEOCFGEIP += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 2;
		this.FIKJJBMPNBH();
	}

	// Token: 0x060039A6 RID: 14758 RVA: 0x000189CE File Offset: 0x00016BCE
	private void HideEmote()
	{
		this.LIQFBHNQCID.enabled = false;
	}

	// Token: 0x060039A7 RID: 14759 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC MFQIJCPBPDF()
	{
		return EBBMJNQGLJC.HBFFCJHOCPE;
	}

	// Token: 0x060039A8 RID: 14760 RVA: 0x000189CE File Offset: 0x00016BCE
	private void KMCFPHNLIOI()
	{
		this.LIQFBHNQCID.enabled = false;
	}

	// Token: 0x060039A9 RID: 14761 RVA: 0x001B4544 File Offset: 0x001B2744
	public void OLDJCGPMGEG(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 0 && CIQFCJGQEMH < 90)
		{
			base.CancelInvoke("Draws in all Water-type moves. Instead of being hit by Water-type moves, it boosts its Sp. Atk.");
			this.LIQFBHNQCID.LGJOOQIBQDC(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.GEMEQGBOLIP().width;
			this.LIQFBHNQCID.MGQIGGNBBBD(this.LIQFBHNQCID.JNCLIGQMCIQ().height);
			this.LIQFBHNQCID.enabled = false;
			base.Invoke("Hydration", MOGLGJGFNDM);
		}
	}

	// Token: 0x060039AA RID: 14762 RVA: 0x000189CE File Offset: 0x00016BCE
	private void PFFDCHBDDIL()
	{
		this.LIQFBHNQCID.enabled = false;
	}

	// Token: 0x060039AB RID: 14763 RVA: 0x001B45D4 File Offset: 0x001B27D4
	private void ODIJQBBOLFI()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("shadowforce", this);
			base.enabled = false;
		}
		this.PNGPQEKJEQM();
		KGQECFKLKOP.IPOEOCFGEIP++;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 6;
		this.FIKJJBMPNBH();
	}

	// Token: 0x060039AC RID: 14764 RVA: 0x001B4678 File Offset: 0x001B2878
	private void PCHJHFGCOCK()
	{
		EBBMJNQGLJC.HBFFCJHOCPE = this;
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1787f, 498f, 1734f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.HideEmote();
		}
	}

	// Token: 0x060039AD RID: 14765 RVA: 0x000189EA File Offset: 0x00016BEA
	public static EBBMJNQGLJC EQLFQFJJNIP()
	{
		return EBBMJNQGLJC.HBFFCJHOCPE;
	}

	// Token: 0x060039AE RID: 14766 RVA: 0x001B4718 File Offset: 0x001B2918
	private void CIJOENOQKCI()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("What Pokémon will hatch from this Egg? It doesn't seem close to hatching.", this);
			base.enabled = true;
		}
		this.JENJBIBHIHN();
		KGQECFKLKOP.IPOEOCFGEIP++;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 4;
		this.FIKJJBMPNBH();
	}

	// Token: 0x060039AF RID: 14767 RVA: 0x000189CE File Offset: 0x00016BCE
	private void DHJQCGFQONM()
	{
		this.LIQFBHNQCID.enabled = false;
	}

	// Token: 0x060039B0 RID: 14768 RVA: 0x001B47BC File Offset: 0x001B29BC
	public void OQNDMEJFCEN(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 1 && CIQFCJGQEMH < -127)
		{
			base.CancelInvoke("r");
			this.LIQFBHNQCID.JLENFJGDNFN(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.GEMEQGBOLIP().width;
			this.LIQFBHNQCID.MGQIGGNBBBD(this.LIQFBHNQCID.JNCLIGQMCIQ().height);
			this.LIQFBHNQCID.enabled = false;
			base.Invoke("Daily Reset\n", MOGLGJGFNDM);
		}
	}

	// Token: 0x060039B1 RID: 14769 RVA: 0x001B484C File Offset: 0x001B2A4C
	public void OBBGPBKKOGJ(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 1 && CIQFCJGQEMH < -95)
		{
			base.CancelInvoke("3");
			this.LIQFBHNQCID.DPBGHDMHKNC(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.GEMEQGBOLIP().width;
			this.LIQFBHNQCID.MGQIGGNBBBD(this.LIQFBHNQCID.JNCLIGQMCIQ().height);
			this.LIQFBHNQCID.enabled = true;
			base.Invoke("HideEmote", MOGLGJGFNDM);
		}
	}

	// Token: 0x060039B2 RID: 14770 RVA: 0x001B48DC File Offset: 0x001B2ADC
	public void JGJOJOBHNCF(int CIQFCJGQEMH, float MOGLGJGFNDM = 4f)
	{
		if (this != null && CIQFCJGQEMH >= 1 && CIQFCJGQEMH < -67)
		{
			base.CancelInvoke("0");
			this.LIQFBHNQCID.JOHBNEHCEJH(CIQFCJGQEMH.ToString());
			this.LIQFBHNQCID.KJGMGPCEJJD = this.LIQFBHNQCID.DNDHIMFCIQD().width;
			this.LIQFBHNQCID.MGQIGGNBBBD(this.LIQFBHNQCID.GEMEQGBOLIP().height);
			this.LIQFBHNQCID.enabled = true;
			base.Invoke("ground", MOGLGJGFNDM);
		}
	}

	// Token: 0x060039B3 RID: 14771 RVA: 0x001B496C File Offset: 0x001B2B6C
	private void MBKJBIQKPGF()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("Offline", this);
			base.enabled = false;
		}
		this.PNGPQEKJEQM();
		KGQECFKLKOP.IPOEOCFGEIP++;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 1;
		this.GMFNGEPKPME();
	}

	// Token: 0x060039B4 RID: 14772 RVA: 0x00018A90 File Offset: 0x00016C90
	public void HPBHGLFFGCD()
	{
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 2;
	}

	// Token: 0x060039B5 RID: 14773 RVA: 0x001B4A10 File Offset: 0x001B2C10
	private void EKIHQDDKFJM()
	{
		EBBMJNQGLJC.HBFFCJHOCPE = this;
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1516f, 1108f, 634f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.QPPKCBEDGQC();
		}
	}

	// Token: 0x060039B6 RID: 14774 RVA: 0x00018AA5 File Offset: 0x00016CA5
	public void FIKJJBMPNBH()
	{
		this.LIQFBHNQCID.LGCLGHDGNPM = this.DOHBLEJJIQO + 6;
	}

	// Token: 0x060039B7 RID: 14775 RVA: 0x001B4AB0 File Offset: 0x001B2CB0
	private void BCDLNCLKKBM()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("BuffIcon_EncounterRateLowered", this);
			base.enabled = false;
		}
		this.HKQIBBBOLID();
		KGQECFKLKOP.IPOEOCFGEIP += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 5;
		this.JMEHPFPKPKD();
	}

	// Token: 0x060039B8 RID: 14776 RVA: 0x001B4B54 File Offset: 0x001B2D54
	private void CBIFBMPIPIC()
	{
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1563f;
		this.BLLEFKOLKLP.localPosition = vector;
	}

	// Token: 0x060039B9 RID: 14777 RVA: 0x001B4BE8 File Offset: 0x001B2DE8
	private void LKDKBNOBIPK()
	{
		EBBMJNQGLJC.HBFFCJHOCPE = this;
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1621f, 1498f, 1975f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.PNGPQEKJEQM();
		}
	}

	// Token: 0x060039BA RID: 14778 RVA: 0x001B4C88 File Offset: 0x001B2E88
	private void NDFNCDDDJPN()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError("´", this);
			base.enabled = true;
		}
		this.DEGEQEPOLOC();
		KGQECFKLKOP.IPOEOCFGEIP++;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 6;
		this.BLIMQGKOEEN();
	}

	// Token: 0x060039BB RID: 14779 RVA: 0x001B4D2C File Offset: 0x001B2F2C
	private void DHLGDLOKLKN()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
		}
		else
		{
			Debug.LogError(" evolved into ", this);
			base.enabled = false;
		}
		this.PFFDCHBDDIL();
		KGQECFKLKOP.IPOEOCFGEIP++;
		this.DOHBLEJJIQO = KGQECFKLKOP.IPOEOCFGEIP * 6;
		this.GMFNGEPKPME();
	}

	// Token: 0x060039BC RID: 14780 RVA: 0x001B4DD0 File Offset: 0x001B2FD0
	private void CHKQIFFEEPL()
	{
		EBBMJNQGLJC.HBFFCJHOCPE = this;
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(881f, 65f, 1494f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.JENJBIBHIHN();
		}
	}

	// Token: 0x060039BD RID: 14781 RVA: 0x000189DC File Offset: 0x00016BDC
	private void LGFFLHHMBHH()
	{
		this.LIQFBHNQCID.enabled = true;
	}

	// Token: 0x060039BE RID: 14782 RVA: 0x001B4E70 File Offset: 0x001B3070
	private void LateUpdate()
	{
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.BLLEFKOLKLP.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 0f;
		this.BLLEFKOLKLP.localPosition = vector;
	}

	// Token: 0x04000D3F RID: 3391
	private static EBBMJNQGLJC HBFFCJHOCPE;

	// Token: 0x04000D40 RID: 3392
	public Vector3 LCMMCNFNHMF = Vector3.zero;

	// Token: 0x04000D41 RID: 3393
	public Transform ILBCCCBJNCL;

	// Token: 0x04000D42 RID: 3394
	public Camera KCOMMGMLLEE;

	// Token: 0x04000D43 RID: 3395
	public Camera CODFIINNNPG;

	// Token: 0x04000D44 RID: 3396
	public bool EELFHGNCLKO = true;

	// Token: 0x04000D45 RID: 3397
	private Transform BLLEFKOLKLP;

	// Token: 0x04000D46 RID: 3398
	public PLQFPBQEPJD LIQFBHNQCID;

	// Token: 0x04000D47 RID: 3399
	public int DOHBLEJJIQO;

	// Token: 0x04000D48 RID: 3400
	public bool FLHBMIMMJOK = true;
}
