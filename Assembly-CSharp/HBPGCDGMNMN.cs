using System;
using UnityEngine;

// Token: 0x0200035C RID: 860
[HelpURL("http://www.procamera2d.com/user-guide/extension-pointer-influence/")]
public class HBPGCDGMNMN : BNEFIOCKQOE, IEMKEPEKMFN
{
	// Token: 0x06007237 RID: 29239 RVA: 0x00029DCA File Offset: 0x00027FCA
	public void QLKFINGELBB(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.BNIDHQPLJCM(GPFIDEJEMEG);
		}
	}

	// Token: 0x06007238 RID: 29240 RVA: 0x00029348 File Offset: 0x00027548
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QCMGMNJGPJL(this);
		}
	}

	// Token: 0x06007239 RID: 29241 RVA: 0x00029DDB File Offset: 0x00027FDB
	protected override void Awake()
	{
		base.Awake();
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
	}

	// Token: 0x0600723A RID: 29242 RVA: 0x00029348 File Offset: 0x00027548
	protected virtual void HFNKLOHMQFH()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QCMGMNJGPJL(this);
		}
	}

	// Token: 0x0600723C RID: 29244 RVA: 0x00029348 File Offset: 0x00027548
	protected virtual void GIBCBGBKIGQ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QCMGMNJGPJL(this);
		}
	}

	// Token: 0x0600723D RID: 29245 RVA: 0x00029E23 File Offset: 0x00028023
	public virtual void FMBEDKEPHDH()
	{
		this.LCHNCQFCLBG = Vector2.zero;
		this.IIQBILODHCN = Vector2.zero;
	}

	// Token: 0x0600723E RID: 29246 RVA: 0x00029E3B File Offset: 0x0002803B
	public void NKQIEEDKOIM(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.IENKHMECIGP(GPFIDEJEMEG);
		}
	}

	// Token: 0x06007240 RID: 29248 RVA: 0x00029E58 File Offset: 0x00028058
	public int HJNQMPPOGGO()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x06007241 RID: 29249 RVA: 0x003772B4 File Offset: 0x003754B4
	private void IENKHMECIGP(float GPFIDEJEMEG)
	{
		Vector3 vector = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToViewportPoint(Input.mousePosition);
		float num = vector.x.PMNDBPOMOGG(0f, 1f, -1f, 1f);
		float num2 = vector.y.PMNDBPOMOGG(0f, 1f, -1f, 1f);
		float x = num * this.NHBCBCJDOFL;
		float y = num2 * this.JICBLMHNHCH;
		this.LCHNCQFCLBG = Vector2.SmoothDamp(this.LCHNCQFCLBG, new Vector2(x, y), ref this.IIQBILODHCN, this.HPFJIILIHHL, float.PositiveInfinity, GPFIDEJEMEG);
		base.GPONHFNLHCN.IENKHMECIGP(this.LCHNCQFCLBG);
	}

	// Token: 0x06007242 RID: 29250 RVA: 0x00029E58 File Offset: 0x00028058
	public int GILMCQLLCNQ()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x06007243 RID: 29251 RVA: 0x00029E23 File Offset: 0x00028023
	public virtual void BBLKFIHPENI()
	{
		this.LCHNCQFCLBG = Vector2.zero;
		this.IIQBILODHCN = Vector2.zero;
	}

	// Token: 0x06007244 RID: 29252 RVA: 0x00029E60 File Offset: 0x00028060
	public void QFICEELIEQL(int BGBMIEJJQKC)
	{
		this.PMEGFIMNDBM = BGBMIEJJQKC;
	}

	// Token: 0x06007245 RID: 29253 RVA: 0x00029E3B File Offset: 0x0002803B
	public void MIMLONLGHKN(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.IENKHMECIGP(GPFIDEJEMEG);
		}
	}

	// Token: 0x06007246 RID: 29254 RVA: 0x00029DDB File Offset: 0x00027FDB
	protected virtual void CHKQIFFEEPL()
	{
		base.Awake();
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
	}

	// Token: 0x06007247 RID: 29255 RVA: 0x00377368 File Offset: 0x00375568
	private void BNIDHQPLJCM(float GPFIDEJEMEG)
	{
		Vector3 vector = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToViewportPoint(Input.mousePosition);
		float num = vector.x.PMNDBPOMOGG(479f, 1257f, 498f, 1240f);
		float num2 = vector.y.PMNDBPOMOGG(1111f, 837f, 894f, 620f);
		float x = num * this.NHBCBCJDOFL;
		float y = num2 * this.JICBLMHNHCH;
		this.LCHNCQFCLBG = Vector2.SmoothDamp(this.LCHNCQFCLBG, new Vector2(x, y), ref this.IIQBILODHCN, this.HPFJIILIHHL, 1111f, GPFIDEJEMEG);
		base.GPONHFNLHCN.IENKHMECIGP(this.LCHNCQFCLBG);
	}

	// Token: 0x170003F2 RID: 1010
	// (get) Token: 0x06007248 RID: 29256 RVA: 0x00029E58 File Offset: 0x00028058
	// (set) Token: 0x0600724D RID: 29261 RVA: 0x00029E60 File Offset: 0x00028060
	public int FDDGIKHBDNF
	{
		get
		{
			return this.PMEGFIMNDBM;
		}
		set
		{
			this.PMEGFIMNDBM = value;
		}
	}

	// Token: 0x06007249 RID: 29257 RVA: 0x00029E58 File Offset: 0x00028058
	public int PEJBDKBEIKP()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x0600724A RID: 29258 RVA: 0x00029348 File Offset: 0x00027548
	protected virtual void BHJIKJLLIQQ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QCMGMNJGPJL(this);
		}
	}

	// Token: 0x0600724B RID: 29259 RVA: 0x00029E23 File Offset: 0x00028023
	public override void NGNDCOPDNPH()
	{
		this.LCHNCQFCLBG = Vector2.zero;
		this.IIQBILODHCN = Vector2.zero;
	}

	// Token: 0x0600724C RID: 29260 RVA: 0x00029DDB File Offset: 0x00027FDB
	protected virtual void HLHPCLEMCKI()
	{
		base.Awake();
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
	}

	// Token: 0x0600724E RID: 29262 RVA: 0x0037741C File Offset: 0x0037561C
	private void EBKLFKQGEKB(float GPFIDEJEMEG)
	{
		Vector3 vector = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToViewportPoint(Input.mousePosition);
		float num = vector.x.PMNDBPOMOGG(198f, 772f, 1273f, 678f);
		float num2 = vector.y.PMNDBPOMOGG(110f, 1762f, 876f, 1515f);
		float x = num * this.NHBCBCJDOFL;
		float y = num2 * this.JICBLMHNHCH;
		this.LCHNCQFCLBG = Vector2.SmoothDamp(this.LCHNCQFCLBG, new Vector2(x, y), ref this.IIQBILODHCN, this.HPFJIILIHHL, 1804f, GPFIDEJEMEG);
		base.GPONHFNLHCN.IENKHMECIGP(this.LCHNCQFCLBG);
	}

	// Token: 0x0600724F RID: 29263 RVA: 0x003774D0 File Offset: 0x003756D0
	private void QBCIHLIKLNG(float GPFIDEJEMEG)
	{
		Vector3 vector = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToViewportPoint(Input.mousePosition);
		float num = vector.x.PMNDBPOMOGG(1423f, 150f, 367f, 1182f);
		float num2 = vector.y.PMNDBPOMOGG(796f, 1021f, 1202f, 1255f);
		float x = num * this.NHBCBCJDOFL;
		float y = num2 * this.JICBLMHNHCH;
		this.LCHNCQFCLBG = Vector2.SmoothDamp(this.LCHNCQFCLBG, new Vector2(x, y), ref this.IIQBILODHCN, this.HPFJIILIHHL, 1077f, GPFIDEJEMEG);
		base.GPONHFNLHCN.IENKHMECIGP(this.LCHNCQFCLBG);
	}

	// Token: 0x06007250 RID: 29264 RVA: 0x00029E60 File Offset: 0x00028060
	public void GMPCFNLGINH(int BGBMIEJJQKC)
	{
		this.PMEGFIMNDBM = BGBMIEJJQKC;
	}

	// Token: 0x06007251 RID: 29265 RVA: 0x00029E23 File Offset: 0x00028023
	public virtual void HOBJBNMFQMC()
	{
		this.LCHNCQFCLBG = Vector2.zero;
		this.IIQBILODHCN = Vector2.zero;
	}

	// Token: 0x06007252 RID: 29266 RVA: 0x00029DDB File Offset: 0x00027FDB
	protected virtual void HFBHKNOCLOE()
	{
		base.Awake();
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
	}

	// Token: 0x04001894 RID: 6292
	public static string OPGNGFNJDDP = "Pointer Influence";

	// Token: 0x04001895 RID: 6293
	public float NHBCBCJDOFL = 3f;

	// Token: 0x04001896 RID: 6294
	public float JICBLMHNHCH = 2f;

	// Token: 0x04001897 RID: 6295
	public float HPFJIILIHHL = 0.2f;

	// Token: 0x04001898 RID: 6296
	private Vector2 LCHNCQFCLBG;

	// Token: 0x04001899 RID: 6297
	private Vector2 IIQBILODHCN;

	// Token: 0x0400189A RID: 6298
	private int PMEGFIMNDBM = 3000;
}
