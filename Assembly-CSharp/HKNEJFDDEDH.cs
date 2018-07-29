using System;
using UnityEngine;

// Token: 0x02000197 RID: 407
public class HKNEJFDDEDH : MonoBehaviour
{
	// Token: 0x0600332B RID: 13099 RVA: 0x00016B9D File Offset: 0x00014D9D
	private void Update()
	{
		this.HQLFDLHIMBP += Time.deltaTime * 0.5f;
	}

	// Token: 0x0600332C RID: 13100 RVA: 0x00016BB7 File Offset: 0x00014DB7
	private void OnEnable()
	{
		this.JHKGHDQFQNL = Shader.Find("HTE/Camera Effects Shader");
	}

	// Token: 0x0600332D RID: 13101 RVA: 0x00016BC9 File Offset: 0x00014DC9
	private void GCIOQGPOLBK()
	{
		this.JHKGHDQFQNL = Shader.Find(">");
	}

	// Token: 0x0600332E RID: 13102 RVA: 0x00016BDB File Offset: 0x00014DDB
	protected void JGPFFDGPGFJ()
	{
		if (this.NKIHFFDFMBJ)
		{
			UnityEngine.Object.DestroyImmediate(this.NKIHFFDFMBJ);
		}
	}

	// Token: 0x0600332F RID: 13103 RVA: 0x00185AA8 File Offset: 0x00183CA8
	private void NKNJKCGOCQM(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (this.PPLIPCEHGNM != null)
		{
			OBEPQQEKFLC.anisoLevel = 0;
			OBEPQQEKFLC.filterMode = FilterMode.Bilinear;
			PBHPQFLMQDB.anisoLevel = 1;
			PBHPQFLMQDB.filterMode = FilterMode.Bilinear;
			this.LGGOGQPIGNH().SetColor("[I]", (!this.LDDCIQMGMQD) ? ((!this.QIKJGLOLLGG) ? this.CEGFBBHMKOE : this.MQPOOFENGHD) : Color.white);
			this.LGGOGQPIGNH().SetFloat(", ", (!this.LDDCIQMGMQD) ? this.QNBFBLJCHDC : 1507f);
			this.LGGOGQPIGNH().SetFloat("TweenLetters encountered an unhandled case trying to modify a vertex ", this.NBJPJBEQKPI);
			this.LGGOGQPIGNH().SetFloat("stealthrock", this.LDBMOOIEBHP);
			this.LGGOGQPIGNH().SetFloat(" x ", this.DMOLEJHGHCF);
			this.PPLIPCEHGNM.SetFloat("achievement", this.LKFEFNKEFDH);
			this.LGGOGQPIGNH().SetFloat("gluttony", (!this.QIKJGLOLLGG) ? this.PLDLQOMPMHB : Mathf.Repeat(this.HQLFDLHIMBP, 1882f));
			this.LGGOGQPIGNH().SetFloat("system", (!this.QIKJGLOLLGG) ? this.GKOFGGEHFBM : Mathf.Repeat(this.HQLFDLHIMBP, 1693f));
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.PPLIPCEHGNM);
		}
	}

	// Token: 0x06003330 RID: 13104 RVA: 0x00016BDB File Offset: 0x00014DDB
	protected void OnDisable()
	{
		if (this.NKIHFFDFMBJ)
		{
			UnityEngine.Object.DestroyImmediate(this.NKIHFFDFMBJ);
		}
	}

	// Token: 0x06003331 RID: 13105 RVA: 0x00016BF5 File Offset: 0x00014DF5
	private void FLNFKFECNFJ()
	{
		this.HQLFDLHIMBP += Time.deltaTime * 1912f;
	}

	// Token: 0x06003332 RID: 13106 RVA: 0x00016C0F File Offset: 0x00014E0F
	private void MCIOHHBPLGO()
	{
		this.JHKGHDQFQNL = Shader.Find("Numeric Boundaries");
	}

	// Token: 0x06003333 RID: 13107 RVA: 0x00016C21 File Offset: 0x00014E21
	protected void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
		if (!this.JHKGHDQFQNL || !this.JHKGHDQFQNL.isSupported)
		{
			base.enabled = false;
		}
	}

	// Token: 0x06003335 RID: 13109 RVA: 0x00185C7C File Offset: 0x00183E7C
	private void OnRenderImage(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (this.PPLIPCEHGNM != null)
		{
			OBEPQQEKFLC.anisoLevel = 0;
			OBEPQQEKFLC.filterMode = FilterMode.Point;
			PBHPQFLMQDB.anisoLevel = 0;
			PBHPQFLMQDB.filterMode = FilterMode.Point;
			this.PPLIPCEHGNM.SetColor("_ColorMul", (!this.LDDCIQMGMQD) ? ((!this.QIKJGLOLLGG) ? this.CEGFBBHMKOE : this.MQPOOFENGHD) : Color.white);
			this.PPLIPCEHGNM.SetFloat("_Saturation", (!this.LDDCIQMGMQD) ? this.QNBFBLJCHDC : 0f);
			this.PPLIPCEHGNM.SetFloat("_Contrast", this.NBJPJBEQKPI);
			this.PPLIPCEHGNM.SetFloat("_DestortionAmplitude", this.LDBMOOIEBHP);
			this.PPLIPCEHGNM.SetFloat("_DestortionX", this.DMOLEJHGHCF);
			this.PPLIPCEHGNM.SetFloat("_DestortionY", this.LKFEFNKEFDH);
			this.PPLIPCEHGNM.SetFloat("_DestortionShiftX", (!this.QIKJGLOLLGG) ? this.PLDLQOMPMHB : Mathf.Repeat(this.HQLFDLHIMBP, 1f));
			this.PPLIPCEHGNM.SetFloat("_DestortionShiftY", (!this.QIKJGLOLLGG) ? this.GKOFGGEHFBM : Mathf.Repeat(this.HQLFDLHIMBP, 1f));
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.PPLIPCEHGNM);
		}
	}

	// Token: 0x06003336 RID: 13110 RVA: 0x00016C53 File Offset: 0x00014E53
	protected Material LGGOGQPIGNH()
	{
		if (this.NKIHFFDFMBJ == null)
		{
			this.NKIHFFDFMBJ = new Material(this.JHKGHDQFQNL);
			this.NKIHFFDFMBJ.hideFlags = (HideFlags)115;
		}
		return this.NKIHFFDFMBJ;
	}

	// Token: 0x06003337 RID: 13111 RVA: 0x00016C87 File Offset: 0x00014E87
	private void QFFJMIOJENJ()
	{
		this.HQLFDLHIMBP += Time.deltaTime * 834f;
	}

	// Token: 0x06003338 RID: 13112 RVA: 0x00016CA1 File Offset: 0x00014EA1
	private void IPFJMEFKGGM()
	{
		this.HQLFDLHIMBP += Time.deltaTime * 1242f;
	}

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x06003339 RID: 13113 RVA: 0x00016CBB File Offset: 0x00014EBB
	protected Material PPLIPCEHGNM
	{
		get
		{
			if (this.NKIHFFDFMBJ == null)
			{
				this.NKIHFFDFMBJ = new Material(this.JHKGHDQFQNL);
				this.NKIHFFDFMBJ.hideFlags = HideFlags.HideAndDontSave;
			}
			return this.NKIHFFDFMBJ;
		}
	}

	// Token: 0x0600333A RID: 13114 RVA: 0x00185DD8 File Offset: 0x00183FD8
	private void FPMEPHKPCDK(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (this.PPLIPCEHGNM != null)
		{
			OBEPQQEKFLC.anisoLevel = 1;
			OBEPQQEKFLC.filterMode = FilterMode.Point;
			PBHPQFLMQDB.anisoLevel = 1;
			PBHPQFLMQDB.filterMode = FilterMode.Point;
			this.PPLIPCEHGNM.SetColor("[00EE07]", (!this.LDDCIQMGMQD) ? ((!this.QIKJGLOLLGG) ? this.CEGFBBHMKOE : this.MQPOOFENGHD) : Color.white);
			this.PPLIPCEHGNM.SetFloat("Fitter Line", (!this.LDDCIQMGMQD) ? this.QNBFBLJCHDC : 270f);
			this.PPLIPCEHGNM.SetFloat("'s [ffff00]", this.NBJPJBEQKPI);
			this.PPLIPCEHGNM.SetFloat(" is fast asleep!\r\n", this.LDBMOOIEBHP);
			this.PPLIPCEHGNM.SetFloat("JOFLHFQQCKG", this.DMOLEJHGHCF);
			this.PPLIPCEHGNM.SetFloat("Crit increases the chance of landing a critical strike", this.LKFEFNKEFDH);
			this.PPLIPCEHGNM.SetFloat("ChromaScreen", (!this.QIKJGLOLLGG) ? this.PLDLQOMPMHB : Mathf.Repeat(this.HQLFDLHIMBP, 1899f));
			this.LGGOGQPIGNH().SetFloat("UNITY_COLORSPACE_GAMMA", (!this.QIKJGLOLLGG) ? this.GKOFGGEHFBM : Mathf.Repeat(this.HQLFDLHIMBP, 634f));
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.PPLIPCEHGNM);
		}
	}

	// Token: 0x0600333B RID: 13115 RVA: 0x00185F34 File Offset: 0x00184134
	private void KPKIQBDHEPF(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (this.PPLIPCEHGNM != null)
		{
			OBEPQQEKFLC.anisoLevel = 1;
			OBEPQQEKFLC.filterMode = FilterMode.Point;
			PBHPQFLMQDB.anisoLevel = 0;
			PBHPQFLMQDB.filterMode = FilterMode.Point;
			this.PPLIPCEHGNM.SetColor(" grew drowsy!\r\n", (!this.LDDCIQMGMQD) ? ((!this.QIKJGLOLLGG) ? this.CEGFBBHMKOE : this.MQPOOFENGHD) : Color.white);
			this.PPLIPCEHGNM.SetFloat("-copyboost", (!this.LDDCIQMGMQD) ? this.QNBFBLJCHDC : 1049f);
			this.PPLIPCEHGNM.SetFloat("raindance", this.NBJPJBEQKPI);
			this.PPLIPCEHGNM.SetFloat("Hidden/Post FX/Lut Generator", this.LDBMOOIEBHP);
			this.PPLIPCEHGNM.SetFloat(" clamped down on ", this.DMOLEJHGHCF);
			this.PPLIPCEHGNM.SetFloat("/", this.LKFEFNKEFDH);
			this.PPLIPCEHGNM.SetFloat(" was prevented from healing!\r\n", (!this.QIKJGLOLLGG) ? this.PLDLQOMPMHB : Mathf.Repeat(this.HQLFDLHIMBP, 405f));
			this.LGGOGQPIGNH().SetFloat("Powers up each Pokémon's Fairy-type moves.", (!this.QIKJGLOLLGG) ? this.GKOFGGEHFBM : Mathf.Repeat(this.HQLFDLHIMBP, 1197f));
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.LGGOGQPIGNH());
		}
	}

	// Token: 0x04000BB1 RID: 2993
	public bool QIKJGLOLLGG = true;

	// Token: 0x04000BB2 RID: 2994
	public bool LDDCIQMGMQD;

	// Token: 0x04000BB3 RID: 2995
	public Shader JHKGHDQFQNL;

	// Token: 0x04000BB4 RID: 2996
	public Color CEGFBBHMKOE = Color.white;

	// Token: 0x04000BB5 RID: 2997
	public Color MQPOOFENGHD = new Color(1f, 1f, 1f);

	// Token: 0x04000BB6 RID: 2998
	[Range(0f, 1f)]
	public float QNBFBLJCHDC = 1f;

	// Token: 0x04000BB7 RID: 2999
	[Range(0f, 2f)]
	public float NBJPJBEQKPI = 1f;

	// Token: 0x04000BB8 RID: 3000
	[Range(0f, 1f)]
	public float LDBMOOIEBHP = 0.001f;

	// Token: 0x04000BB9 RID: 3001
	[Range(0f, 255f)]
	public float DMOLEJHGHCF = 50f;

	// Token: 0x04000BBA RID: 3002
	[Range(0f, 255f)]
	public float LKFEFNKEFDH = 50f;

	// Token: 0x04000BBB RID: 3003
	[Range(0f, 1f)]
	public float PLDLQOMPMHB;

	// Token: 0x04000BBC RID: 3004
	[Range(0f, 1f)]
	public float GKOFGGEHFBM;

	// Token: 0x04000BBD RID: 3005
	private Material NKIHFFDFMBJ;

	// Token: 0x04000BBE RID: 3006
	private float HQLFDLHIMBP;
}
