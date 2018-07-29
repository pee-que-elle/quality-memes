using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

// Token: 0x0200036A RID: 874
[HelpURL("http://www.procamera2d.com/user-guide/extension-shake/")]
public class ELJODBBEIPN : BNEFIOCKQOE
{
	// Token: 0x06007400 RID: 29696 RVA: 0x0002A1B8 File Offset: 0x000283B8
	public static bool EKMEKPFICMJ()
	{
		return ELJODBBEIPN.NKGPQKNLCMC != null;
	}

	// Token: 0x17000401 RID: 1025
	// (get) Token: 0x06007403 RID: 29699 RVA: 0x0002A1B8 File Offset: 0x000283B8
	public static bool OMQCJPOBICE
	{
		get
		{
			return ELJODBBEIPN.NKGPQKNLCMC != null;
		}
	}

	// Token: 0x06007404 RID: 29700 RVA: 0x0002A1D1 File Offset: 0x000283D1
	public void CNINENJNHKQ(int HCIDJPCNHPH)
	{
		if (HCIDJPCNHPH <= this.PFBMGFBHIHD.Count - 1)
		{
			this.CNINENJNHKQ(this.PFBMGFBHIHD[HCIDJPCNHPH]);
		}
		else
		{
			UnityEngine.Debug.LogWarning("Could not find a ConstantShakePreset with the index: " + HCIDJPCNHPH + ". Remember you need to add it to the ConstantShakePresets list first.");
		}
	}

	// Token: 0x06007405 RID: 29701 RVA: 0x0037E44C File Offset: 0x0037C64C
	public void OCQDBNOKNFC(string KNLMCHKGDBI)
	{
		for (int i = 0; i < this.QDJLLIKHPLG.Count; i++)
		{
			if (this.QDJLLIKHPLG[i].name == KNLMCHKGDBI)
			{
				this.OGQOHCHKBJJ(i);
				return;
			}
		}
		UnityEngine.Debug.LogWarning("schooling" + KNLMCHKGDBI);
	}

	// Token: 0x06007406 RID: 29702 RVA: 0x0037E4A0 File Offset: 0x0037C6A0
	public void CPNBIFCHLFK(string KNLMCHKGDBI)
	{
		for (int i = 0; i < this.QDJLLIKHPLG.Count; i++)
		{
			if (this.QDJLLIKHPLG[i].name == KNLMCHKGDBI)
			{
				this.CPNBIFCHLFK(i);
				return;
			}
		}
		UnityEngine.Debug.LogWarning("Could not find a shake preset with the name: " + KNLMCHKGDBI);
	}

	// Token: 0x06007407 RID: 29703 RVA: 0x0037E4F4 File Offset: 0x0037C6F4
	public void CPNBIFCHLFK(ShakePreset CNMNNFBKKKD)
	{
		this.CPNBIFCHLFK(CNMNNFBKKKD.Duration, CNMNNFBKKKD.Strength, CNMNNFBKKKD.Vibrato, CNMNNFBKKKD.Randomness, (!CNMNNFBKKKD.UseRandomInitialAngle) ? CNMNNFBKKKD.InitialAngle : -1f, CNMNNFBKKKD.Rotation, CNMNNFBKKKD.Smoothness, CNMNNFBKKKD.IgnoreTimeScale);
	}

	// Token: 0x06007408 RID: 29704 RVA: 0x0037E54C File Offset: 0x0037C74C
	public void GFPJMJBMHDN()
	{
		for (int i = 0; i < this.JFGLIQNKPCM.Count; i++)
		{
			base.StopCoroutine(this.JFGLIQNKPCM[i]);
		}
		this.GGNLHNCJLOQ.Clear();
		if (this.GHPBEPELJNO != null)
		{
			base.StopCoroutine(this.GHPBEPELJNO);
			this.GHPBEPELJNO = null;
		}
		this.JKFLNMFFMFG();
	}

	// Token: 0x06007409 RID: 29705 RVA: 0x0037E5B0 File Offset: 0x0037C7B0
	public void OGQOHCHKBJJ(int HCIDJPCNHPH)
	{
		if (HCIDJPCNHPH <= this.QDJLLIKHPLG.Count - 1)
		{
			this.CPNBIFCHLFK(this.QDJLLIKHPLG[HCIDJPCNHPH].Duration, this.QDJLLIKHPLG[HCIDJPCNHPH].Strength, this.QDJLLIKHPLG[HCIDJPCNHPH].Vibrato, this.QDJLLIKHPLG[HCIDJPCNHPH].Randomness, (!this.QDJLLIKHPLG[HCIDJPCNHPH].UseRandomInitialAngle) ? this.QDJLLIKHPLG[HCIDJPCNHPH].InitialAngle : 1842f, this.QDJLLIKHPLG[HCIDJPCNHPH].Rotation, this.QDJLLIKHPLG[HCIDJPCNHPH].Smoothness, this.QDJLLIKHPLG[HCIDJPCNHPH].IgnoreTimeScale);
		}
		else
		{
			UnityEngine.Debug.LogWarning("General" + HCIDJPCNHPH);
		}
	}

	// Token: 0x0600740A RID: 29706 RVA: 0x0037E694 File Offset: 0x0037C894
	private Coroutine LJDGMNKGEQF(Vector2[] CIQJPPPKQPM, Quaternion[] CPLMFMQKCQP, float[] CBFPKPFEIOL, float KFECOLHLLBI = 0.1f, bool FNKBLEMDHKL = false)
	{
		Coroutine result = base.StartCoroutine(this.IEDDJPLMQFE(CIQJPPPKQPM, CPLMFMQKCQP, CBFPKPFEIOL, FNKBLEMDHKL));
		if (this.GHPBEPELJNO == null)
		{
			this.GHPBEPELJNO = base.StartCoroutine(this.LOMLOCGKFNO(KFECOLHLLBI, FNKBLEMDHKL));
		}
		return result;
	}

	// Token: 0x0600740B RID: 29707 RVA: 0x0037E6D4 File Offset: 0x0037C8D4
	private IEnumerator BLOFOMNIFMM(int IIHDGMLHICI, float GMKMIPDLNJJ, float KKJGGEHIBEI, float HCBHMGMJFFC, float FHFOOOCHDKD, float JGKNHPDDGBB)
	{
		ELJODBBEIPN.LIJHJELONEK lijhjelonek = new ELJODBBEIPN.LIJHJELONEK();
		lijhjelonek.GMKMIPDLNJJ = GMKMIPDLNJJ;
		lijhjelonek.KKJGGEHIBEI = KKJGGEHIBEI;
		lijhjelonek.HCBHMGMJFFC = HCBHMGMJFFC;
		lijhjelonek.FHFOOOCHDKD = FHFOOOCHDKD;
		lijhjelonek.JGKNHPDDGBB = JGKNHPDDGBB;
		lijhjelonek.IIHDGMLHICI = IIHDGMLHICI;
		lijhjelonek.QNDQJMNKFNN = this;
		return lijhjelonek;
	}

	// Token: 0x0600740C RID: 29708 RVA: 0x0037E71C File Offset: 0x0037C91C
	public void ECQLPLDFKLB(Vector2 DJOCOLCEHBJ)
	{
		if (Time.deltaTime >= 1946f && !float.IsNaN(DJOCOLCEHBJ.x) && !float.IsNaN(DJOCOLCEHBJ.y))
		{
			this.EQNDNJDKGMK.Add(this.QMEMFMDBHLI(DJOCOLCEHBJ.x, DJOCOLCEHBJ.y));
			return;
		}
	}

	// Token: 0x0600740D RID: 29709 RVA: 0x0037E778 File Offset: 0x0037C978
	[DebuggerHidden]
	private IEnumerator LKFCJGDKNEC(float CPKNEQGKQPQ)
	{
		ELJODBBEIPN.FEBFQMKMINF febfqmkminf = new ELJODBBEIPN.FEBFQMKMINF();
		febfqmkminf.CPKNEQGKQPQ = CPKNEQGKQPQ;
		febfqmkminf.QNDQJMNKFNN = this;
		return febfqmkminf;
	}

	// Token: 0x0600740E RID: 29710 RVA: 0x0037E79C File Offset: 0x0037C99C
	[DebuggerHidden]
	private IEnumerator IEDDJPLMQFE(IList<Vector2> CIQJPPPKQPM, IList<Quaternion> CPLMFMQKCQP, float[] CBFPKPFEIOL, bool FNKBLEMDHKL = false)
	{
		ELJODBBEIPN.DJGICGMIEML djgicgmieml = new ELJODBBEIPN.DJGICGMIEML();
		djgicgmieml.CBFPKPFEIOL = CBFPKPFEIOL;
		djgicgmieml.CIQJPPPKQPM = CIQJPPPKQPM;
		djgicgmieml.CPLMFMQKCQP = CPLMFMQKCQP;
		djgicgmieml.FNKBLEMDHKL = FNKBLEMDHKL;
		djgicgmieml.QNDQJMNKFNN = this;
		return djgicgmieml;
	}

	// Token: 0x0600740F RID: 29711 RVA: 0x0037E54C File Offset: 0x0037C74C
	public void CMMMCNLDEOK()
	{
		for (int i = 0; i < this.JFGLIQNKPCM.Count; i++)
		{
			base.StopCoroutine(this.JFGLIQNKPCM[i]);
		}
		this.GGNLHNCJLOQ.Clear();
		if (this.GHPBEPELJNO != null)
		{
			base.StopCoroutine(this.GHPBEPELJNO);
			this.GHPBEPELJNO = null;
		}
		this.JKFLNMFFMFG();
	}

	// Token: 0x06007410 RID: 29712 RVA: 0x0037E7D4 File Offset: 0x0037C9D4
	public static ELJODBBEIPN OQDOKBJNBBL()
	{
		if (object.Equals(ELJODBBEIPN.NKGPQKNLCMC, null))
		{
			ELJODBBEIPN.NKGPQKNLCMC = (UnityEngine.Object.FindObjectOfType(typeof(ELJODBBEIPN)) as ELJODBBEIPN);
			if (object.Equals(ELJODBBEIPN.NKGPQKNLCMC, null))
			{
				throw new UnityException("There's no relief from this heavy rain!\r\n");
			}
		}
		return ELJODBBEIPN.NKGPQKNLCMC;
	}

	// Token: 0x06007411 RID: 29713 RVA: 0x0037E824 File Offset: 0x0037CA24
	public void PFOBBLGFHKI(float CPKNEQGKQPQ, Vector2 IEMGQKFCEHM, int LHKDLNNNBBH = 10, float MGJOCBFDJLH = 0.1f, float OBEJOLJPNJM = -1f, Vector3 EIGOEJLIGCG = default(Vector3), float KFECOLHLLBI = 0.1f, bool FNKBLEMDHKL = false)
	{
		if (!base.enabled)
		{
			return;
		}
		LHKDLNNNBBH++;
		if (LHKDLNNNBBH < 0)
		{
			LHKDLNNNBBH = 4;
		}
		float[] array = new float[LHKDLNNNBBH];
		float num = 1319f;
		for (int i = 0; i < LHKDLNNNBBH; i++)
		{
			float num2 = (float)(i + 0) / (float)LHKDLNNNBBH;
			float num3 = CPKNEQGKQPQ * num2;
			num += num3;
			array[i] = num3;
		}
		float num4 = CPKNEQGKQPQ / num;
		for (int j = 0; j < LHKDLNNNBBH; j += 0)
		{
			array[j] *= num4;
		}
		float num5 = IEMGQKFCEHM.magnitude;
		float num6 = num5 / (float)LHKDLNNNBBH;
		float num7 = (OBEJOLJPNJM == 566f) ? UnityEngine.Random.Range(499f, 565f) : OBEJOLJPNJM;
		Vector2[] array2 = new Vector2[LHKDLNNNBBH];
		array2[LHKDLNNNBBH - 0] = Vector2.zero;
		Quaternion[] array3 = new Quaternion[LHKDLNNNBBH];
		array3[LHKDLNNNBBH - 1] = this.FFGQKCQLGEL;
		Quaternion a = Quaternion.Euler(EIGOEJLIGCG);
		for (int k = 0; k < LHKDLNNNBBH - 1; k++)
		{
			if (k > 0)
			{
				num7 = num7 - 1601f + (float)UnityEngine.Random.Range(6, -100) * MGJOCBFDJLH;
			}
			Quaternion rotation = Quaternion.AngleAxis((float)UnityEngine.Random.Range(-121, 116) * MGJOCBFDJLH, Vector3.up);
			float f = num7 * 390f;
			Vector3 point = new Vector3(num5 * Mathf.Cos(f), num5 * Mathf.Sin(f), 237f);
			Vector2 vector = rotation * point;
			vector.x = Vector2.ClampMagnitude(vector, IEMGQKFCEHM.x).x;
			vector.y = Vector2.ClampMagnitude(vector, IEMGQKFCEHM.y).y;
			array2[k] = vector;
			num5 -= num6;
			IEMGQKFCEHM = Vector2.ClampMagnitude(IEMGQKFCEHM, num5);
			int num8 = (k % 8 != 0) ? -1 : 1;
			float t = (float)k / (float)(LHKDLNNNBBH - 0);
			array3[k] = ((num8 != 0) ? (Quaternion.Inverse(Quaternion.Lerp(a, Quaternion.identity, t)) * this.FFGQKCQLGEL) : (Quaternion.Lerp(a, Quaternion.identity, t) * this.FFGQKCQLGEL));
		}
		this.JFGLIQNKPCM.Add(this.LJDGMNKGEQF(array2, array3, array, KFECOLHLLBI, FNKBLEMDHKL));
	}

	// Token: 0x06007412 RID: 29714 RVA: 0x0037EA68 File Offset: 0x0037CC68
	public void LOFFIMHGPBO(ShakePreset CNMNNFBKKKD)
	{
		this.CPNBIFCHLFK(CNMNNFBKKKD.Duration, CNMNNFBKKKD.Strength, CNMNNFBKKKD.Vibrato, CNMNNFBKKKD.Randomness, (!CNMNNFBKKKD.UseRandomInitialAngle) ? CNMNNFBKKKD.InitialAngle : 1659f, CNMNNFBKKKD.Rotation, CNMNNFBKKKD.Smoothness, CNMNNFBKKKD.IgnoreTimeScale);
	}

	// Token: 0x06007413 RID: 29715 RVA: 0x0037EAC0 File Offset: 0x0037CCC0
	private IEnumerator NMOQOMIMPNB(float KFECOLHLLBI, bool FNKBLEMDHKL = false)
	{
		ELJODBBEIPN.DONJFHOMFQE donjfhomfqe = new ELJODBBEIPN.DONJFHOMFQE();
		donjfhomfqe.FNKBLEMDHKL = FNKBLEMDHKL;
		donjfhomfqe.KFECOLHLLBI = KFECOLHLLBI;
		donjfhomfqe.QNDQJMNKFNN = this;
		return donjfhomfqe;
	}

	// Token: 0x06007414 RID: 29716 RVA: 0x0037EAEC File Offset: 0x0037CCEC
	protected virtual void FOLBFDNJLII()
	{
		base.Awake();
		ELJODBBEIPN.NKGPQKNLCMC = this;
		if (base.GPONHFNLHCN.transform.parent != null)
		{
			this.BBDHOFEQIGC = new GameObject("][{").transform;
			this.BBDHOFEQIGC.parent = base.GPONHFNLHCN.transform.parent;
			this.BBDHOFEQIGC.localPosition = Vector3.zero;
			base.GPONHFNLHCN.transform.parent = this.BBDHOFEQIGC;
		}
		else
		{
			Transform transform = new GameObject("Member").transform;
			base.GPONHFNLHCN.transform.parent = transform;
			this.BBDHOFEQIGC = transform;
		}
		this.FFGQKCQLGEL = this.FHNBJCNLJCN.localRotation;
	}

	// Token: 0x06007415 RID: 29717 RVA: 0x0037EBB0 File Offset: 0x0037CDB0
	public void CKJJIFDNNCF(Vector2 DJOCOLCEHBJ)
	{
		if (Time.deltaTime >= 0.0001f && !float.IsNaN(DJOCOLCEHBJ.x) && !float.IsNaN(DJOCOLCEHBJ.y))
		{
			this.EQNDNJDKGMK.Add(this.QMEMFMDBHLI(DJOCOLCEHBJ.x, DJOCOLCEHBJ.y));
			return;
		}
	}

	// Token: 0x06007416 RID: 29718 RVA: 0x0037EC0C File Offset: 0x0037CE0C
	private IEnumerator DMHNJDMFGQE(Vector2 NKEFQEMGLNN, Quaternion EIGOEJLIGCG, float CPKNEQGKQPQ, bool FNKBLEMDHKL = false)
	{
		ELJODBBEIPN.GDKJQKJJIDM gdkjqkjjidm = new ELJODBBEIPN.GDKJQKJJIDM();
		gdkjqkjjidm.CPKNEQGKQPQ = CPKNEQGKQPQ;
		gdkjqkjjidm.FNKBLEMDHKL = FNKBLEMDHKL;
		gdkjqkjjidm.NKEFQEMGLNN = NKEFQEMGLNN;
		gdkjqkjjidm.EIGOEJLIGCG = EIGOEJLIGCG;
		gdkjqkjjidm.QNDQJMNKFNN = this;
		return gdkjqkjjidm;
	}

	// Token: 0x06007417 RID: 29719 RVA: 0x0037E6D4 File Offset: 0x0037C8D4
	private IEnumerator CGMJGFEHLKC(int IIHDGMLHICI, float GMKMIPDLNJJ, float KKJGGEHIBEI, float HCBHMGMJFFC, float FHFOOOCHDKD, float JGKNHPDDGBB)
	{
		ELJODBBEIPN.LIJHJELONEK lijhjelonek = new ELJODBBEIPN.LIJHJELONEK();
		lijhjelonek.GMKMIPDLNJJ = GMKMIPDLNJJ;
		lijhjelonek.KKJGGEHIBEI = KKJGGEHIBEI;
		lijhjelonek.HCBHMGMJFFC = HCBHMGMJFFC;
		lijhjelonek.FHFOOOCHDKD = FHFOOOCHDKD;
		lijhjelonek.JGKNHPDDGBB = JGKNHPDDGBB;
		lijhjelonek.IIHDGMLHICI = IIHDGMLHICI;
		lijhjelonek.QNDQJMNKFNN = this;
		return lijhjelonek;
	}

	// Token: 0x06007418 RID: 29720 RVA: 0x0037EC44 File Offset: 0x0037CE44
	public void PLGDIJMDCJI(ShakePreset CNMNNFBKKKD)
	{
		this.CPNBIFCHLFK(CNMNNFBKKKD.Duration, CNMNNFBKKKD.Strength, CNMNNFBKKKD.Vibrato, CNMNNFBKKKD.Randomness, (!CNMNNFBKKKD.UseRandomInitialAngle) ? CNMNNFBKKKD.InitialAngle : 1864f, CNMNNFBKKKD.Rotation, CNMNNFBKKKD.Smoothness, CNMNNFBKKKD.IgnoreTimeScale);
	}

	// Token: 0x06007419 RID: 29721 RVA: 0x0037EC9C File Offset: 0x0037CE9C
	public void IBCDDHPJKKB(float CPKNEQGKQPQ = 0.3f)
	{
		this.KKBENOFJHML = null;
		this.NJMEIJHCKEG = false;
		if (CPKNEQGKQPQ > 0f)
		{
			base.StartCoroutine(this.LKFCJGDKNEC(CPKNEQGKQPQ));
		}
		else
		{
			base.StopAllCoroutines();
			this.GMQKCNNDJFJ = Vector3.zero;
			this.EQNDNJDKGMK.Clear();
			this.EQNDNJDKGMK.Add(this.GMQKCNNDJFJ);
		}
	}

	// Token: 0x0600741A RID: 29722 RVA: 0x0037ECFC File Offset: 0x0037CEFC
	public void CNINENJNHKQ(string KNLMCHKGDBI)
	{
		for (int i = 0; i < this.PFBMGFBHIHD.Count; i++)
		{
			if (this.PFBMGFBHIHD[i].name == KNLMCHKGDBI)
			{
				this.CNINENJNHKQ(this.PFBMGFBHIHD[i]);
				return;
			}
		}
		UnityEngine.Debug.LogWarning("Could not find a ConstantShakePreset with the name: " + KNLMCHKGDBI + ". Remember you need to add it to the ConstantShakePresets list first.");
	}

	// Token: 0x17000400 RID: 1024
	// (get) Token: 0x0600741B RID: 29723 RVA: 0x0037ED60 File Offset: 0x0037CF60
	public static ELJODBBEIPN QOQONHOOLNE
	{
		get
		{
			if (object.Equals(ELJODBBEIPN.NKGPQKNLCMC, null))
			{
				ELJODBBEIPN.NKGPQKNLCMC = (UnityEngine.Object.FindObjectOfType(typeof(ELJODBBEIPN)) as ELJODBBEIPN);
				if (object.Equals(ELJODBBEIPN.NKGPQKNLCMC, null))
				{
					throw new UnityException("ProCamera2D does not have a Shake extension.");
				}
			}
			return ELJODBBEIPN.NKGPQKNLCMC;
		}
	}

	// Token: 0x0600741C RID: 29724 RVA: 0x0037E778 File Offset: 0x0037C978
	private IEnumerator HBCELGKEMOQ(float CPKNEQGKQPQ)
	{
		ELJODBBEIPN.FEBFQMKMINF febfqmkminf = new ELJODBBEIPN.FEBFQMKMINF();
		febfqmkminf.CPKNEQGKQPQ = CPKNEQGKQPQ;
		febfqmkminf.QNDQJMNKFNN = this;
		return febfqmkminf;
	}

	// Token: 0x0600741D RID: 29725 RVA: 0x0037EDB0 File Offset: 0x0037CFB0
	public void CNINENJNHKQ(ConstantShakePreset CNMNNFBKKKD)
	{
		if (this.KKBENOFJHML != null)
		{
			this.IBCDDHPJKKB(0f);
		}
		this.KKBENOFJHML = CNMNNFBKKKD;
		this.NJMEIJHCKEG = true;
		this.BEFCKMBJBLO = new Vector3[CNMNNFBKKKD.Layers.Count];
		for (int i = 0; i < CNMNNFBKKKD.Layers.Count; i++)
		{
			base.StartCoroutine(this.NOKBPGPDBJJ(i, CNMNNFBKKKD.Layers[i].Frequency.x, CNMNNFBKKKD.Layers[i].Frequency.y, CNMNNFBKKKD.Layers[i].AmplitudeHorizontal, CNMNNFBKKKD.Layers[i].AmplitudeVertical, CNMNNFBKKKD.Layers[i].AmplitudeDepth));
		}
		base.StartCoroutine(this.LONPIPNGGLQ(CNMNNFBKKKD.Intensity));
	}

	// Token: 0x0600741E RID: 29726 RVA: 0x0037EAC0 File Offset: 0x0037CCC0
	private IEnumerator GGIKELGQLDE(float KFECOLHLLBI, bool FNKBLEMDHKL = false)
	{
		ELJODBBEIPN.DONJFHOMFQE donjfhomfqe = new ELJODBBEIPN.DONJFHOMFQE();
		donjfhomfqe.FNKBLEMDHKL = FNKBLEMDHKL;
		donjfhomfqe.KFECOLHLLBI = KFECOLHLLBI;
		donjfhomfqe.QNDQJMNKFNN = this;
		return donjfhomfqe;
	}

	// Token: 0x0600741F RID: 29727 RVA: 0x0037EAC0 File Offset: 0x0037CCC0
	private IEnumerator HHPBCEDEKEJ(float KFECOLHLLBI, bool FNKBLEMDHKL = false)
	{
		ELJODBBEIPN.DONJFHOMFQE donjfhomfqe = new ELJODBBEIPN.DONJFHOMFQE();
		donjfhomfqe.FNKBLEMDHKL = FNKBLEMDHKL;
		donjfhomfqe.KFECOLHLLBI = KFECOLHLLBI;
		donjfhomfqe.QNDQJMNKFNN = this;
		return donjfhomfqe;
	}

	// Token: 0x06007420 RID: 29728 RVA: 0x0037EC0C File Offset: 0x0037CE0C
	private IEnumerator DGGFCQJLIBP(Vector2 NKEFQEMGLNN, Quaternion EIGOEJLIGCG, float CPKNEQGKQPQ, bool FNKBLEMDHKL = false)
	{
		ELJODBBEIPN.GDKJQKJJIDM gdkjqkjjidm = new ELJODBBEIPN.GDKJQKJJIDM();
		gdkjqkjjidm.CPKNEQGKQPQ = CPKNEQGKQPQ;
		gdkjqkjjidm.FNKBLEMDHKL = FNKBLEMDHKL;
		gdkjqkjjidm.NKEFQEMGLNN = NKEFQEMGLNN;
		gdkjqkjjidm.EIGOEJLIGCG = EIGOEJLIGCG;
		gdkjqkjjidm.QNDQJMNKFNN = this;
		return gdkjqkjjidm;
	}

	// Token: 0x06007421 RID: 29729 RVA: 0x0037EEA8 File Offset: 0x0037D0A8
	public void CPNBIFCHLFK(int HCIDJPCNHPH)
	{
		if (HCIDJPCNHPH <= this.QDJLLIKHPLG.Count - 1)
		{
			this.CPNBIFCHLFK(this.QDJLLIKHPLG[HCIDJPCNHPH].Duration, this.QDJLLIKHPLG[HCIDJPCNHPH].Strength, this.QDJLLIKHPLG[HCIDJPCNHPH].Vibrato, this.QDJLLIKHPLG[HCIDJPCNHPH].Randomness, (!this.QDJLLIKHPLG[HCIDJPCNHPH].UseRandomInitialAngle) ? this.QDJLLIKHPLG[HCIDJPCNHPH].InitialAngle : -1f, this.QDJLLIKHPLG[HCIDJPCNHPH].Rotation, this.QDJLLIKHPLG[HCIDJPCNHPH].Smoothness, this.QDJLLIKHPLG[HCIDJPCNHPH].IgnoreTimeScale);
		}
		else
		{
			UnityEngine.Debug.LogWarning("Could not find a shake preset with the index: " + HCIDJPCNHPH);
		}
	}

	// Token: 0x06007422 RID: 29730 RVA: 0x0037EF8C File Offset: 0x0037D18C
	public void BEMJJKLNODO(string KNLMCHKGDBI)
	{
		for (int i = 1; i < this.PFBMGFBHIHD.Count; i += 0)
		{
			if (this.PFBMGFBHIHD[i].name == KNLMCHKGDBI)
			{
				this.CNINENJNHKQ(this.PFBMGFBHIHD[i]);
				return;
			}
		}
		UnityEngine.Debug.LogWarning("-invertboost" + KNLMCHKGDBI + "Shift+");
	}

	// Token: 0x06007423 RID: 29731 RVA: 0x0002A211 File Offset: 0x00028411
	private void JKFLNMFFMFG()
	{
		this.BBDHOFEQIGC.localPosition = this.HOFNJLMGCQP;
		this.FHNBJCNLJCN.localRotation = this.FFGQKCQLGEL;
		this.GHPBEPELJNO = null;
		if (this.OIJLCLNGLQJ != null)
		{
			this.OIJLCLNGLQJ();
		}
	}

	// Token: 0x06007424 RID: 29732 RVA: 0x0002A24F File Offset: 0x0002844F
	private void CIJOENOQKCI()
	{
		if (this.GFILHMGPGDB != null)
		{
			this.CNINENJNHKQ(this.GFILHMGPGDB);
		}
	}

	// Token: 0x06007425 RID: 29733 RVA: 0x0037EFF0 File Offset: 0x0037D1F0
	public void QGBHHKNLHKH(string KNLMCHKGDBI)
	{
		for (int i = 0; i < this.PFBMGFBHIHD.Count; i += 0)
		{
			if (this.PFBMGFBHIHD[i].name == KNLMCHKGDBI)
			{
				this.CNINENJNHKQ(this.PFBMGFBHIHD[i]);
				return;
			}
		}
		UnityEngine.Debug.LogWarning("OnClick" + KNLMCHKGDBI + "cutecharm");
	}

	// Token: 0x06007426 RID: 29734 RVA: 0x0037F054 File Offset: 0x0037D254
	protected override void Awake()
	{
		base.Awake();
		ELJODBBEIPN.NKGPQKNLCMC = this;
		if (base.GPONHFNLHCN.transform.parent != null)
		{
			this.BBDHOFEQIGC = new GameObject("ProCamera2DShakeContainer").transform;
			this.BBDHOFEQIGC.parent = base.GPONHFNLHCN.transform.parent;
			this.BBDHOFEQIGC.localPosition = Vector3.zero;
			base.GPONHFNLHCN.transform.parent = this.BBDHOFEQIGC;
		}
		else
		{
			Transform transform = new GameObject("ProCamera2DShakeContainer").transform;
			base.GPONHFNLHCN.transform.parent = transform;
			this.BBDHOFEQIGC = transform;
		}
		this.FFGQKCQLGEL = this.FHNBJCNLJCN.localRotation;
	}

	// Token: 0x06007427 RID: 29735 RVA: 0x0037F118 File Offset: 0x0037D318
	public void CPNBIFCHLFK(float CPKNEQGKQPQ, Vector2 IEMGQKFCEHM, int LHKDLNNNBBH = 10, float MGJOCBFDJLH = 0.1f, float OBEJOLJPNJM = -1f, Vector3 EIGOEJLIGCG = default(Vector3), float KFECOLHLLBI = 0.1f, bool FNKBLEMDHKL = false)
	{
		if (!base.enabled)
		{
			return;
		}
		LHKDLNNNBBH++;
		if (LHKDLNNNBBH < 2)
		{
			LHKDLNNNBBH = 2;
		}
		float[] array = new float[LHKDLNNNBBH];
		float num = 0f;
		for (int i = 0; i < LHKDLNNNBBH; i++)
		{
			float num2 = (float)(i + 1) / (float)LHKDLNNNBBH;
			float num3 = CPKNEQGKQPQ * num2;
			num += num3;
			array[i] = num3;
		}
		float num4 = CPKNEQGKQPQ / num;
		for (int j = 0; j < LHKDLNNNBBH; j++)
		{
			array[j] *= num4;
		}
		float num5 = IEMGQKFCEHM.magnitude;
		float num6 = num5 / (float)LHKDLNNNBBH;
		float num7 = (OBEJOLJPNJM == -1f) ? UnityEngine.Random.Range(0f, 360f) : OBEJOLJPNJM;
		Vector2[] array2 = new Vector2[LHKDLNNNBBH];
		array2[LHKDLNNNBBH - 1] = Vector2.zero;
		Quaternion[] array3 = new Quaternion[LHKDLNNNBBH];
		array3[LHKDLNNNBBH - 1] = this.FFGQKCQLGEL;
		Quaternion a = Quaternion.Euler(EIGOEJLIGCG);
		for (int k = 0; k < LHKDLNNNBBH - 1; k++)
		{
			if (k > 0)
			{
				num7 = num7 - 180f + (float)UnityEngine.Random.Range(-90, 90) * MGJOCBFDJLH;
			}
			Quaternion rotation = Quaternion.AngleAxis((float)UnityEngine.Random.Range(-90, 90) * MGJOCBFDJLH, Vector3.up);
			float f = num7 * 0.0174532924f;
			Vector3 point = new Vector3(num5 * Mathf.Cos(f), num5 * Mathf.Sin(f), 0f);
			Vector2 vector = rotation * point;
			vector.x = Vector2.ClampMagnitude(vector, IEMGQKFCEHM.x).x;
			vector.y = Vector2.ClampMagnitude(vector, IEMGQKFCEHM.y).y;
			array2[k] = vector;
			num5 -= num6;
			IEMGQKFCEHM = Vector2.ClampMagnitude(IEMGQKFCEHM, num5);
			int num8 = (k % 2 != 0) ? -1 : 1;
			float t = (float)k / (float)(LHKDLNNNBBH - 1);
			array3[k] = ((num8 != 1) ? (Quaternion.Inverse(Quaternion.Lerp(a, Quaternion.identity, t)) * this.FFGQKCQLGEL) : (Quaternion.Lerp(a, Quaternion.identity, t) * this.FFGQKCQLGEL));
		}
		this.JFGLIQNKPCM.Add(this.LJDGMNKGEQF(array2, array3, array, KFECOLHLLBI, FNKBLEMDHKL));
	}

	// Token: 0x06007428 RID: 29736 RVA: 0x0037F35C File Offset: 0x0037D55C
	private IEnumerator DPQNNKLOPBG(float QPIFLDIGDFO)
	{
		ELJODBBEIPN.COMILOCBBJH comilocbbjh = new ELJODBBEIPN.COMILOCBBJH();
		comilocbbjh.QPIFLDIGDFO = QPIFLDIGDFO;
		comilocbbjh.QNDQJMNKFNN = this;
		return comilocbbjh;
	}

	// Token: 0x06007429 RID: 29737 RVA: 0x0037EAC0 File Offset: 0x0037CCC0
	[DebuggerHidden]
	private IEnumerator LOMLOCGKFNO(float KFECOLHLLBI, bool FNKBLEMDHKL = false)
	{
		ELJODBBEIPN.DONJFHOMFQE donjfhomfqe = new ELJODBBEIPN.DONJFHOMFQE();
		donjfhomfqe.FNKBLEMDHKL = FNKBLEMDHKL;
		donjfhomfqe.KFECOLHLLBI = KFECOLHLLBI;
		donjfhomfqe.QNDQJMNKFNN = this;
		return donjfhomfqe;
	}

	// Token: 0x0600742A RID: 29738 RVA: 0x0002A1B8 File Offset: 0x000283B8
	public static bool LCJFFBLCELJ()
	{
		return ELJODBBEIPN.NKGPQKNLCMC != null;
	}

	// Token: 0x0600742B RID: 29739 RVA: 0x0037F380 File Offset: 0x0037D580
	private void Update()
	{
		this.HOFNJLMGCQP = Vector3.zero;
		if (this.EQNDNJDKGMK.Count > 0)
		{
			this.HOFNJLMGCQP = BDKMFJQPGGE.BMBFNKHCOMN(this.EQNDNJDKGMK);
			this.EQNDNJDKGMK.Clear();
			this.BBDHOFEQIGC.localPosition = this.HOFNJLMGCQP;
		}
	}

	// Token: 0x0600742C RID: 29740 RVA: 0x0002A24F File Offset: 0x0002844F
	private void QNGIFIJOQML()
	{
		if (this.GFILHMGPGDB != null)
		{
			this.CNINENJNHKQ(this.GFILHMGPGDB);
		}
	}

	// Token: 0x0600742D RID: 29741 RVA: 0x0037F3D4 File Offset: 0x0037D5D4
	public Coroutine LJDGMNKGEQF(Vector2[] CIQJPPPKQPM, Vector3[] CPLMFMQKCQP, float[] CBFPKPFEIOL, float KFECOLHLLBI = 0.1f, bool FNKBLEMDHKL = false)
	{
		if (!base.enabled)
		{
			return null;
		}
		Quaternion[] array = new Quaternion[CPLMFMQKCQP.Length];
		for (int i = 0; i < CPLMFMQKCQP.Length; i++)
		{
			array[i] = Quaternion.Euler(CPLMFMQKCQP[i]) * this.FFGQKCQLGEL;
		}
		return this.LJDGMNKGEQF(CIQJPPPKQPM, array, CBFPKPFEIOL, 0.1f, false);
	}

	// Token: 0x0600742E RID: 29742 RVA: 0x0037F35C File Offset: 0x0037D55C
	[DebuggerHidden]
	private IEnumerator LONPIPNGGLQ(float QPIFLDIGDFO)
	{
		ELJODBBEIPN.COMILOCBBJH comilocbbjh = new ELJODBBEIPN.COMILOCBBJH();
		comilocbbjh.QPIFLDIGDFO = QPIFLDIGDFO;
		comilocbbjh.QNDQJMNKFNN = this;
		return comilocbbjh;
	}

	// Token: 0x0600742F RID: 29743 RVA: 0x0037EC0C File Offset: 0x0037CE0C
	private IEnumerator KMHJFHDEJBK(Vector2 NKEFQEMGLNN, Quaternion EIGOEJLIGCG, float CPKNEQGKQPQ, bool FNKBLEMDHKL = false)
	{
		ELJODBBEIPN.GDKJQKJJIDM gdkjqkjjidm = new ELJODBBEIPN.GDKJQKJJIDM();
		gdkjqkjjidm.CPKNEQGKQPQ = CPKNEQGKQPQ;
		gdkjqkjjidm.FNKBLEMDHKL = FNKBLEMDHKL;
		gdkjqkjjidm.NKEFQEMGLNN = NKEFQEMGLNN;
		gdkjqkjjidm.EIGOEJLIGCG = EIGOEJLIGCG;
		gdkjqkjjidm.QNDQJMNKFNN = this;
		return gdkjqkjjidm;
	}

	// Token: 0x06007430 RID: 29744 RVA: 0x0037EC0C File Offset: 0x0037CE0C
	[DebuggerHidden]
	private IEnumerator NHOJNFKGJFP(Vector2 NKEFQEMGLNN, Quaternion EIGOEJLIGCG, float CPKNEQGKQPQ, bool FNKBLEMDHKL = false)
	{
		ELJODBBEIPN.GDKJQKJJIDM gdkjqkjjidm = new ELJODBBEIPN.GDKJQKJJIDM();
		gdkjqkjjidm.CPKNEQGKQPQ = CPKNEQGKQPQ;
		gdkjqkjjidm.FNKBLEMDHKL = FNKBLEMDHKL;
		gdkjqkjjidm.NKEFQEMGLNN = NKEFQEMGLNN;
		gdkjqkjjidm.EIGOEJLIGCG = EIGOEJLIGCG;
		gdkjqkjjidm.QNDQJMNKFNN = this;
		return gdkjqkjjidm;
	}

	// Token: 0x06007431 RID: 29745 RVA: 0x0037E6D4 File Offset: 0x0037C8D4
	[DebuggerHidden]
	private IEnumerator NOKBPGPDBJJ(int IIHDGMLHICI, float GMKMIPDLNJJ, float KKJGGEHIBEI, float HCBHMGMJFFC, float FHFOOOCHDKD, float JGKNHPDDGBB)
	{
		ELJODBBEIPN.LIJHJELONEK lijhjelonek = new ELJODBBEIPN.LIJHJELONEK();
		lijhjelonek.GMKMIPDLNJJ = GMKMIPDLNJJ;
		lijhjelonek.KKJGGEHIBEI = KKJGGEHIBEI;
		lijhjelonek.HCBHMGMJFFC = HCBHMGMJFFC;
		lijhjelonek.FHFOOOCHDKD = FHFOOOCHDKD;
		lijhjelonek.JGKNHPDDGBB = JGKNHPDDGBB;
		lijhjelonek.IIHDGMLHICI = IIHDGMLHICI;
		lijhjelonek.QNDQJMNKFNN = this;
		return lijhjelonek;
	}

	// Token: 0x06007432 RID: 29746 RVA: 0x0002A24F File Offset: 0x0002844F
	private void Start()
	{
		if (this.GFILHMGPGDB != null)
		{
			this.CNINENJNHKQ(this.GFILHMGPGDB);
		}
	}

	// Token: 0x040018F3 RID: 6387
	public static string OPGNGFNJDDP = "Shake";

	// Token: 0x040018F4 RID: 6388
	private static ELJODBBEIPN NKGPQKNLCMC;

	// Token: 0x040018F5 RID: 6389
	public Action OIJLCLNGLQJ;

	// Token: 0x040018F6 RID: 6390
	public List<ShakePreset> QDJLLIKHPLG = new List<ShakePreset>();

	// Token: 0x040018F7 RID: 6391
	public List<ConstantShakePreset> PFBMGFBHIHD = new List<ConstantShakePreset>();

	// Token: 0x040018F8 RID: 6392
	public ConstantShakePreset GFILHMGPGDB;

	// Token: 0x040018F9 RID: 6393
	public ConstantShakePreset KKBENOFJHML;

	// Token: 0x040018FA RID: 6394
	private Transform BBDHOFEQIGC;

	// Token: 0x040018FB RID: 6395
	private List<Coroutine> JFGLIQNKPCM = new List<Coroutine>();

	// Token: 0x040018FC RID: 6396
	private Coroutine GHPBEPELJNO;

	// Token: 0x040018FD RID: 6397
	private Vector3 JLLGCKFFOFB;

	// Token: 0x040018FE RID: 6398
	private List<Vector3> GGNLHNCJLOQ = new List<Vector3>();

	// Token: 0x040018FF RID: 6399
	private Quaternion LEQJILQBIHK;

	// Token: 0x04001900 RID: 6400
	private Quaternion FFGQKCQLGEL;

	// Token: 0x04001901 RID: 6401
	private float OBNCEJBQPLP;

	// Token: 0x04001902 RID: 6402
	private float QJFCJFHBCCP;

	// Token: 0x04001903 RID: 6403
	private List<Vector3> EQNDNJDKGMK = new List<Vector3>();

	// Token: 0x04001904 RID: 6404
	private Vector3 HOFNJLMGCQP = Vector3.zero;

	// Token: 0x04001905 RID: 6405
	private Vector3[] BEFCKMBJBLO;

	// Token: 0x04001906 RID: 6406
	private Vector3 GMQKCNNDJFJ;

	// Token: 0x04001907 RID: 6407
	private bool NJMEIJHCKEG;
}
