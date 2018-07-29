using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000324 RID: 804
public abstract class BNEFIOCKQOE : MonoBehaviour
{
	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x06006B8D RID: 27533 RVA: 0x0034A614 File Offset: 0x00348814
	// (set) Token: 0x06006B8E RID: 27534 RVA: 0x00028579 File Offset: 0x00026779
	public GNKDCOHMFEG GPONHFNLHCN
	{
		get
		{
			if (this._pc2D != null)
			{
				return this._pc2D;
			}
			if (Camera.main != null)
			{
				this._pc2D = Camera.main.GetComponent<GNKDCOHMFEG>();
			}
			if (this._pc2D == null)
			{
				this._pc2D = (UnityEngine.Object.FindObjectOfType(typeof(GNKDCOHMFEG)) as GNKDCOHMFEG);
			}
			return this._pc2D;
		}
		set
		{
			this._pc2D = value;
		}
	}

	// Token: 0x06006B8F RID: 27535 RVA: 0x00028582 File Offset: 0x00026782
	protected virtual void Awake()
	{
		this.FHNBJCNLJCN = base.transform;
		if (base.enabled)
		{
			this.FHKIQHPOIOC();
		}
		this.FBJHQMMMFBI();
	}

	// Token: 0x06006B90 RID: 27536 RVA: 0x000285A4 File Offset: 0x000267A4
	protected virtual void OnEnable()
	{
		this.FHKIQHPOIOC();
	}

	// Token: 0x06006B91 RID: 27537 RVA: 0x000285AC File Offset: 0x000267AC
	protected virtual void OnDisable()
	{
		this.JNDDMKHOEJI();
	}

	// Token: 0x06006B92 RID: 27538 RVA: 0x000285AC File Offset: 0x000267AC
	protected virtual void OnDestroy()
	{
		this.JNDDMKHOEJI();
	}

	// Token: 0x06006B93 RID: 27539 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void NGNDCOPDNPH()
	{
	}

	// Token: 0x06006B94 RID: 27540 RVA: 0x0034A684 File Offset: 0x00348884
	private void FHKIQHPOIOC()
	{
		if (!this.GLENFIGIEQB && !(this._pc2D == null))
		{
			this.GLENFIGIEQB = true;
			GNKDCOHMFEG pc2D = this._pc2D;
			pc2D.NGNDCOPDNPH = (Action)Delegate.Combine(pc2D.NGNDCOPDNPH, new Action(this.NGNDCOPDNPH));
			return;
		}
	}

	// Token: 0x06006B95 RID: 27541 RVA: 0x0034A6D8 File Offset: 0x003488D8
	private void JNDDMKHOEJI()
	{
		if (this._pc2D != null && this.GLENFIGIEQB)
		{
			this.GLENFIGIEQB = false;
			GNKDCOHMFEG pc2D = this._pc2D;
			pc2D.NGNDCOPDNPH = (Action)Delegate.Remove(pc2D.NGNDCOPDNPH, new Action(this.NGNDCOPDNPH));
		}
	}

	// Token: 0x06006B96 RID: 27542 RVA: 0x0034A72C File Offset: 0x0034892C
	private void FBJHQMMMFBI()
	{
		if (this.FKGNBCKJPQO == null && !(this.GPONHFNLHCN == null))
		{
			CDLKIQJJHKE mllmoqqnkmc = this._pc2D.MLLMOQQNKMC;
			if (mllmoqqnkmc != CDLKIQJJHKE.XY)
			{
				if (mllmoqqnkmc != CDLKIQJJHKE.XZ)
				{
					if (mllmoqqnkmc == CDLKIQJJHKE.YZ)
					{
						if (BNEFIOCKQOE.LBOLIPKBDBL == null)
						{
							BNEFIOCKQOE.LBOLIPKBDBL = new Func<Vector3, float>(BNEFIOCKQOE.DKHIOCFOJDF);
						}
						this.FKGNBCKJPQO = BNEFIOCKQOE.LBOLIPKBDBL;
						if (BNEFIOCKQOE.CEPOLPBOPEP == null)
						{
							BNEFIOCKQOE.CEPOLPBOPEP = new Func<Vector3, float>(BNEFIOCKQOE.GPFFKBCOKIJ);
						}
						this.JNBBJCLFFBB = BNEFIOCKQOE.CEPOLPBOPEP;
						if (BNEFIOCKQOE.MEKLOPDEIJG == null)
						{
							BNEFIOCKQOE.MEKLOPDEIJG = new Func<Vector3, float>(BNEFIOCKQOE.PBDPGPGDDPL);
						}
						this.OFPEBLPKOLD = BNEFIOCKQOE.MEKLOPDEIJG;
						if (BNEFIOCKQOE.JPGKCMJGHOD == null)
						{
							BNEFIOCKQOE.JPGKCMJGHOD = new Func<float, float, Vector3>(BNEFIOCKQOE.IMBMNCJEFJE);
						}
						this.QMEMFMDBHLI = BNEFIOCKQOE.JPGKCMJGHOD;
						if (BNEFIOCKQOE.DOLPFDKLKPE == null)
						{
							BNEFIOCKQOE.DOLPFDKLKPE = new Func<float, float, float, Vector3>(BNEFIOCKQOE.MMBECMOQGGD);
						}
						this.JQCCJCOPEJK = BNEFIOCKQOE.DOLPFDKLKPE;
					}
				}
				else
				{
					if (BNEFIOCKQOE.LDLHIHLGMOP == null)
					{
						BNEFIOCKQOE.LDLHIHLGMOP = new Func<Vector3, float>(BNEFIOCKQOE.KEHBGLBCLFI);
					}
					this.FKGNBCKJPQO = BNEFIOCKQOE.LDLHIHLGMOP;
					if (BNEFIOCKQOE.OEPCQKQDIJD == null)
					{
						BNEFIOCKQOE.OEPCQKQDIJD = new Func<Vector3, float>(BNEFIOCKQOE.GFEOFJJIKLG);
					}
					this.JNBBJCLFFBB = BNEFIOCKQOE.OEPCQKQDIJD;
					if (BNEFIOCKQOE.MMPJPDBKOOM == null)
					{
						BNEFIOCKQOE.MMPJPDBKOOM = new Func<Vector3, float>(BNEFIOCKQOE.IPCJMQGQBQI);
					}
					this.OFPEBLPKOLD = BNEFIOCKQOE.MMPJPDBKOOM;
					if (BNEFIOCKQOE.EQLOFOGBJIO == null)
					{
						BNEFIOCKQOE.EQLOFOGBJIO = new Func<float, float, Vector3>(BNEFIOCKQOE.HJLLOBLBLHH);
					}
					this.QMEMFMDBHLI = BNEFIOCKQOE.EQLOFOGBJIO;
					if (BNEFIOCKQOE.KLJBBNHCHKB == null)
					{
						BNEFIOCKQOE.KLJBBNHCHKB = new Func<float, float, float, Vector3>(BNEFIOCKQOE.FNFLJGPLFFP);
					}
					this.JQCCJCOPEJK = BNEFIOCKQOE.KLJBBNHCHKB;
				}
			}
			else
			{
				if (BNEFIOCKQOE.HNCJFHJNHDN == null)
				{
					BNEFIOCKQOE.HNCJFHJNHDN = new Func<Vector3, float>(BNEFIOCKQOE.IDKMCEIKPHK);
				}
				this.FKGNBCKJPQO = BNEFIOCKQOE.HNCJFHJNHDN;
				if (BNEFIOCKQOE.BIJFPHIBEDK == null)
				{
					BNEFIOCKQOE.BIJFPHIBEDK = new Func<Vector3, float>(BNEFIOCKQOE.BHLECHJMLGF);
				}
				this.JNBBJCLFFBB = BNEFIOCKQOE.BIJFPHIBEDK;
				if (BNEFIOCKQOE.KKGPFHKPCFG == null)
				{
					BNEFIOCKQOE.KKGPFHKPCFG = new Func<Vector3, float>(BNEFIOCKQOE.QLKOPDPLEHD);
				}
				this.OFPEBLPKOLD = BNEFIOCKQOE.KKGPFHKPCFG;
				if (BNEFIOCKQOE.FFMGNIDNMII == null)
				{
					BNEFIOCKQOE.FFMGNIDNMII = new Func<float, float, Vector3>(BNEFIOCKQOE.DPQKKBMCDNQ);
				}
				this.QMEMFMDBHLI = BNEFIOCKQOE.FFMGNIDNMII;
				if (BNEFIOCKQOE.MLDNMQMBDGF == null)
				{
					BNEFIOCKQOE.MLDNMQMBDGF = new Func<float, float, float, Vector3>(BNEFIOCKQOE.QLLNFGGKDKK);
				}
				this.JQCCJCOPEJK = BNEFIOCKQOE.MLDNMQMBDGF;
			}
			return;
		}
	}

	// Token: 0x06006B97 RID: 27543 RVA: 0x000285B4 File Offset: 0x000267B4
	[CompilerGenerated]
	private static float IDKMCEIKPHK(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006B98 RID: 27544 RVA: 0x000285BD File Offset: 0x000267BD
	[CompilerGenerated]
	private static float BHLECHJMLGF(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006B99 RID: 27545 RVA: 0x000285C6 File Offset: 0x000267C6
	[CompilerGenerated]
	private static float QLKOPDPLEHD(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006B9A RID: 27546 RVA: 0x000285CF File Offset: 0x000267CF
	[CompilerGenerated]
	private static Vector3 DPQKKBMCDNQ(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, ECFKEFOFQGB, 0f);
	}

	// Token: 0x06006B9B RID: 27547 RVA: 0x000285DD File Offset: 0x000267DD
	[CompilerGenerated]
	private static Vector3 QLLNFGGKDKK(float ONOGHDLFKLH, float ECFKEFOFQGB, float EKDDQNPBPJL)
	{
		return new Vector3(ONOGHDLFKLH, ECFKEFOFQGB, EKDDQNPBPJL);
	}

	// Token: 0x06006B9C RID: 27548 RVA: 0x000285B4 File Offset: 0x000267B4
	[CompilerGenerated]
	private static float KEHBGLBCLFI(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006B9D RID: 27549 RVA: 0x000285C6 File Offset: 0x000267C6
	[CompilerGenerated]
	private static float GFEOFJJIKLG(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006B9E RID: 27550 RVA: 0x000285BD File Offset: 0x000267BD
	[CompilerGenerated]
	private static float IPCJMQGQBQI(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006B9F RID: 27551 RVA: 0x000285E7 File Offset: 0x000267E7
	[CompilerGenerated]
	private static Vector3 HJLLOBLBLHH(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, 0f, ECFKEFOFQGB);
	}

	// Token: 0x06006BA0 RID: 27552 RVA: 0x000285F5 File Offset: 0x000267F5
	[CompilerGenerated]
	private static Vector3 FNFLJGPLFFP(float ONOGHDLFKLH, float ECFKEFOFQGB, float EKDDQNPBPJL)
	{
		return new Vector3(ONOGHDLFKLH, EKDDQNPBPJL, ECFKEFOFQGB);
	}

	// Token: 0x06006BA1 RID: 27553 RVA: 0x000285C6 File Offset: 0x000267C6
	[CompilerGenerated]
	private static float DKHIOCFOJDF(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006BA2 RID: 27554 RVA: 0x000285BD File Offset: 0x000267BD
	[CompilerGenerated]
	private static float GPFFKBCOKIJ(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006BA3 RID: 27555 RVA: 0x000285B4 File Offset: 0x000267B4
	[CompilerGenerated]
	private static float PBDPGPGDDPL(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006BA4 RID: 27556 RVA: 0x000285FF File Offset: 0x000267FF
	[CompilerGenerated]
	private static Vector3 IMBMNCJEFJE(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(0f, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x06006BA5 RID: 27557 RVA: 0x0002860D File Offset: 0x0002680D
	[CompilerGenerated]
	private static Vector3 MMBECMOQGGD(float ONOGHDLFKLH, float ECFKEFOFQGB, float EKDDQNPBPJL)
	{
		return new Vector3(EKDDQNPBPJL, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x0400168E RID: 5774
	[SerializeField]
	private GNKDCOHMFEG _pc2D;

	// Token: 0x0400168F RID: 5775
	protected Func<Vector3, float> FKGNBCKJPQO;

	// Token: 0x04001690 RID: 5776
	protected Func<Vector3, float> JNBBJCLFFBB;

	// Token: 0x04001691 RID: 5777
	protected Func<Vector3, float> OFPEBLPKOLD;

	// Token: 0x04001692 RID: 5778
	protected Func<float, float, Vector3> QMEMFMDBHLI;

	// Token: 0x04001693 RID: 5779
	protected Func<float, float, float, Vector3> JQCCJCOPEJK;

	// Token: 0x04001694 RID: 5780
	protected Transform FHNBJCNLJCN;

	// Token: 0x04001695 RID: 5781
	private bool GLENFIGIEQB;

	// Token: 0x04001696 RID: 5782
	[CompilerGenerated]
	private static Func<Vector3, float> HNCJFHJNHDN;

	// Token: 0x04001697 RID: 5783
	[CompilerGenerated]
	private static Func<Vector3, float> BIJFPHIBEDK;

	// Token: 0x04001698 RID: 5784
	[CompilerGenerated]
	private static Func<Vector3, float> KKGPFHKPCFG;

	// Token: 0x04001699 RID: 5785
	[CompilerGenerated]
	private static Func<float, float, Vector3> FFMGNIDNMII;

	// Token: 0x0400169A RID: 5786
	[CompilerGenerated]
	private static Func<float, float, float, Vector3> MLDNMQMBDGF;

	// Token: 0x0400169B RID: 5787
	[CompilerGenerated]
	private static Func<Vector3, float> LDLHIHLGMOP;

	// Token: 0x0400169C RID: 5788
	[CompilerGenerated]
	private static Func<Vector3, float> OEPCQKQDIJD;

	// Token: 0x0400169D RID: 5789
	[CompilerGenerated]
	private static Func<Vector3, float> MMPJPDBKOOM;

	// Token: 0x0400169E RID: 5790
	[CompilerGenerated]
	private static Func<float, float, Vector3> EQLOFOGBJIO;

	// Token: 0x0400169F RID: 5791
	[CompilerGenerated]
	private static Func<float, float, float, Vector3> KLJBBNHCHKB;

	// Token: 0x040016A0 RID: 5792
	[CompilerGenerated]
	private static Func<Vector3, float> LBOLIPKBDBL;

	// Token: 0x040016A1 RID: 5793
	[CompilerGenerated]
	private static Func<Vector3, float> CEPOLPBOPEP;

	// Token: 0x040016A2 RID: 5794
	[CompilerGenerated]
	private static Func<Vector3, float> MEKLOPDEIJG;

	// Token: 0x040016A3 RID: 5795
	[CompilerGenerated]
	private static Func<float, float, Vector3> JPGKCMJGHOD;

	// Token: 0x040016A4 RID: 5796
	[CompilerGenerated]
	private static Func<float, float, float, Vector3> DOLPFDKLKPE;
}
