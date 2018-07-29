using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

// Token: 0x0200038A RID: 906
[RequireComponent(typeof(Camera))]
[HelpURL("http://www.procamera2d.com/user-guide/core/")]
public class GNKDCOHMFEG : MonoBehaviour, ISerializationCallbackReceiver
{
	// Token: 0x060078BA RID: 30906 RVA: 0x0039ED64 File Offset: 0x0039CF64
	public YieldInstruction ECIOFNPQPGP()
	{
		CLQIOKJENKD epgicgghoqi = this.EPGICGGHOQI;
		if (epgicgghoqi != CLQIOKJENKD.FixedUpdate)
		{
			return null;
		}
		return this.NQBGPPPKHCM;
	}

	// Token: 0x060078BB RID: 30907 RVA: 0x0002B26B File Offset: 0x0002946B
	public Vector3 LHHHEMHLKPL()
	{
		return this.<LOPEFEPJCHE>k__BackingField;
	}

	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x060078BC RID: 30908 RVA: 0x0002B26B File Offset: 0x0002946B
	// (set) Token: 0x06007913 RID: 30995 RVA: 0x0002B528 File Offset: 0x00029728
	public Vector3 JCEGQKEQHEF { get; private set; }

	// Token: 0x060078BD RID: 30909 RVA: 0x000285CF File Offset: 0x000267CF
	[CompilerGenerated]
	private static Vector3 DPQKKBMCDNQ(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, ECFKEFOFQGB, 0f);
	}

	// Token: 0x060078BE RID: 30910 RVA: 0x0002B273 File Offset: 0x00029473
	public void PKCLIDDHIKF()
	{
		if (this.NGNDCOPDNPH != null)
		{
			this.NGNDCOPDNPH();
		}
	}

	// Token: 0x060078BF RID: 30911 RVA: 0x0002B288 File Offset: 0x00029488
	public void CIDMBQQGPNM(NLQPOLOJJQE GQIPQBKIDBE)
	{
		this.FMMMQQEODPH.Add(GQIPQBKIDBE);
	}

	// Token: 0x060078C0 RID: 30912 RVA: 0x0002B296 File Offset: 0x00029496
	public Coroutine HILONLEQJDH(CameraTarget IJJMIMFQPEC, float DCHDDIDNKPM, float OLNHHIBFGKL, float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ > 0f)
		{
			return base.StartCoroutine(this.LGQHGIQEFEI(IJJMIMFQPEC, DCHDDIDNKPM, OLNHHIBFGKL, CPKNEQGKQPQ, false));
		}
		IJJMIMFQPEC.TargetInfluenceH = DCHDDIDNKPM;
		IJJMIMFQPEC.TargetInfluenceV = OLNHHIBFGKL;
		return null;
	}

	// Token: 0x060078C1 RID: 30913 RVA: 0x0002B2C3 File Offset: 0x000294C3
	public Vector3 KEQQHBKDJHP()
	{
		return this.<QQNHLJJMHOG>k__BackingField;
	}

	// Token: 0x060078C2 RID: 30914 RVA: 0x000285C6 File Offset: 0x000267C6
	[CompilerGenerated]
	private static float GFEOFJJIKLG(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x060078C3 RID: 30915 RVA: 0x0002B2CB File Offset: 0x000294CB
	private void ENECNILLLHH(Vector2 BGBMIEJJQKC)
	{
		this.<CHOIQCQDJCB>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x17000432 RID: 1074
	// (get) Token: 0x060078C4 RID: 30916 RVA: 0x0002B2D4 File Offset: 0x000294D4
	// (set) Token: 0x0600792A RID: 31018 RVA: 0x0002B5DB File Offset: 0x000297DB
	public Vector3 PFBFIECJEJO { get; private set; }

	// Token: 0x060078C5 RID: 30917 RVA: 0x0002B2DC File Offset: 0x000294DC
	private float GLFGGFEFICD(float CLELOFNIEJK, float LHMEQNKFHIB)
	{
		return LHMEQNKFHIB / (2f * Mathf.Tan(0.5f * CLELOFNIEJK * 0.0174532924f));
	}

	// Token: 0x060078C6 RID: 30918 RVA: 0x0002B2F8 File Offset: 0x000294F8
	private static int DQNQOBBFCKQ(IEMKEPEKMFN ECHMFPQNBMC)
	{
		return ECHMFPQNBMC.FDDGIKHBDNF;
	}

	// Token: 0x060078C7 RID: 30919 RVA: 0x0002B300 File Offset: 0x00029500
	private float GQHKMFDLEOD(float CLELOFNIEJK, float LHMEQNKFHIB)
	{
		return LHMEQNKFHIB / (719f * Mathf.Tan(177f * CLELOFNIEJK * 1623f));
	}

	// Token: 0x060078C8 RID: 30920 RVA: 0x0002B31C File Offset: 0x0002951C
	public void JKNBMCKEBOF(LIJCFDMDDIJ INDKHOBOEPN)
	{
		this.CMHHCJOLLQG.Add(INDKHOBOEPN);
	}

	// Token: 0x060078C9 RID: 30921 RVA: 0x0002B32A File Offset: 0x0002952A
	public void IEFGKEDBIGD()
	{
		IEnumerable<ECEGGIKJDGM> jhkjeqbbbgb = this.JHKJEQBBBGB;
		if (GNKDCOHMFEG.OIQQMHFMIIC == null)
		{
			GNKDCOHMFEG.OIQQMHFMIIC = new Func<ECEGGIKJDGM, int>(GNKDCOHMFEG.MHBKHGJJMDE);
		}
		this.JHKJEQBBBGB = jhkjeqbbbgb.OrderBy(GNKDCOHMFEG.OIQQMHFMIIC).ToList<ECEGGIKJDGM>();
	}

	// Token: 0x060078CA RID: 30922 RVA: 0x0002B35F File Offset: 0x0002955F
	public void LCGGKBJFLQD(IEMKEPEKMFN HBGMQNPBKOI)
	{
		this.HFJGOFLGKIP.Add(HBGMQNPBKOI);
	}

	// Token: 0x060078CB RID: 30923 RVA: 0x0039ED84 File Offset: 0x0039CF84
	public void DFMMCLFKFBH(float GPFIDEJEMEG)
	{
		this.NMOHPQICBEO = this.FHNBJCNLJCN.localPosition;
		if (Screen.width != this.EBLNDNNFDPD || Screen.height != this.HNJCIQCOLDO)
		{
			this.GIEHLCEMPKF();
		}
		this.JLHLDNHPINI = GPFIDEJEMEG;
		if (this.JLHLDNHPINI < 0.0001f)
		{
			return;
		}
		if (this.QCFEHBPOCGC != null)
		{
			this.QCFEHBPOCGC(this.JLHLDNHPINI);
		}
		for (int i = 0; i < this.HFJGOFLGKIP.Count; i++)
		{
			this.HFJGOFLGKIP[i].NKQIEEDKOIM(GPFIDEJEMEG);
		}
		this.LDDLLQGMKFK = this.HGNEKQHNFCC;
		this.HGNEKQHNFCC = this.IIQFDNIMJLF(ref this.DBLIJKDNBLI);
		this.PFBFIECJEJO = this.HGNEKQHNFCC;
		this.HOFNJLMGCQP = BDKMFJQPGGE.BMBFNKHCOMN(this.EQNDNJDKGMK);
		this.PFBFIECJEJO += this.HOFNJLMGCQP;
		this.EQNDNJDKGMK.Clear();
		float num = (!this.MDGMJQMKEOK) ? this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) : this.FKGNBCKJPQO(this.PFBFIECJEJO);
		float num2 = (!this.IMJODMILBFD) ? this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) : this.JNBBJCLFFBB(this.PFBFIECJEJO);
		this.PFBFIECJEJO = this.QMEMFMDBHLI(num - this.FKGNBCKJPQO(this.JCEGQKEQHEF), num2 - this.JNBBJCLFFBB(this.JCEGQKEQHEF));
		if (this.JQPHDHIICJE != null)
		{
			this.PFBFIECJEJO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.JQPHDHIICJE.Value) - this.FKGNBCKJPQO(this.JCEGQKEQHEF), this.JNBBJCLFFBB(this.JQPHDHIICJE.Value) - this.JNBBJCLFFBB(this.JCEGQKEQHEF));
			this.JQPHDHIICJE = null;
		}
		this.PFBFIECJEJO += this.QMEMFMDBHLI((!this.MDGMJQMKEOK) ? 0f : this.PDOGMKKLQFL(), (!this.IMJODMILBFD) ? 0f : this.COBOKEGHNJP());
		this.EEDKPPIKFKG = BDKMFJQPGGE.EEHCCCJBEOG(this.EEDKPPIKFKG, this.IIJELHFCNJG, this.FKGNBCKJPQO(this.PFBFIECJEJO), 1f / this.LBJLGDGHFBJ, this.JLHLDNHPINI);
		this.IIJELHFCNJG = this.EEDKPPIKFKG;
		this.NNGFLMFCBBI = BDKMFJQPGGE.EEHCCCJBEOG(this.NNGFLMFCBBI, this.GQQLGPJQPFO, this.JNBBJCLFFBB(this.PFBFIECJEJO), 1f / this.EQGPIDFNHHG, this.JLHLDNHPINI);
		this.GQQLGPJQPFO = this.NNGFLMFCBBI;
		float arg = this.EEDKPPIKFKG - this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition);
		float arg2 = this.NNGFLMFCBBI - this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition);
		Vector3 vector = this.QMEMFMDBHLI(arg, arg2);
		float num3 = 0f;
		for (int j = 0; j < this.HFQOJBPLKJO.Count; j++)
		{
			num3 = this.HFQOJBPLKJO[j].HGENPJMHEBI(GPFIDEJEMEG, num3);
		}
		float num4 = this.PGKODNCDNJQ.y * 0.5f + num3;
		for (int k = 0; k < this.FMMMQQEODPH.Count; k++)
		{
			num4 = this.FMMMQQEODPH[k].LCHPMFFIFLL(GPFIDEJEMEG, num4);
		}
		if (num4 != this.PGKODNCDNJQ.y * 0.5f)
		{
			this.LPNBKEJBHBM(num4);
		}
		for (int l = 0; l < this.CMHHCJOLLQG.Count; l++)
		{
			vector = this.CMHHCJOLLQG[l].MKKGHGDNEOK(GPFIDEJEMEG, vector);
		}
		Vector3 vector2 = this.HMCOIDFCKPM + vector;
		for (int m = 0; m < this.DBILEBCQIBD.Count; m++)
		{
			vector2 = this.DBILEBCQIBD[m].FIOLQHKHOED(GPFIDEJEMEG, vector2);
		}
		this.FHNBJCNLJCN.localPosition = this.JQCCJCOPEJK(this.FKGNBCKJPQO(vector2), this.JNBBJCLFFBB(vector2), this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition));
		for (int n = 0; n < this.JHKJEQBBBGB.Count; n++)
		{
			this.JHKJEQBBBGB[n].QOHOHPQOECC(GPFIDEJEMEG);
		}
		if (this.EGOKFPNIMBH != null)
		{
			this.EGOKFPNIMBH(this.JLHLDNHPINI);
		}
	}

	// Token: 0x060078CC RID: 30924 RVA: 0x000285BD File Offset: 0x000267BD
	private static float KFCIIKPEIPL(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x060078CD RID: 30925 RVA: 0x000285FF File Offset: 0x000267FF
	[CompilerGenerated]
	private static Vector3 IMBMNCJEFJE(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(0f, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x060078CE RID: 30926 RVA: 0x0002B36D File Offset: 0x0002956D
	// (set) Token: 0x060078EE RID: 30958 RVA: 0x0002B3AF File Offset: 0x000295AF
	public Vector2 GFQDCHOQHGP { get; private set; }

	// Token: 0x060078CF RID: 30927 RVA: 0x0002B375 File Offset: 0x00029575
	private void FNNIFQIECCK(Vector3 BGBMIEJJQKC)
	{
		this.<HPCCKQHFMBF>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060078D0 RID: 30928 RVA: 0x0002B37E File Offset: 0x0002957E
	private void LateUpdate()
	{
		if (this.EPGICGGHOQI == CLQIOKJENKD.LateUpdate)
		{
			this.DFMMCLFKFBH(Time.smoothDeltaTime);
		}
	}

	// Token: 0x060078D1 RID: 30929 RVA: 0x0039F250 File Offset: 0x0039D450
	private IEnumerator KKDLFKBKJLM(IList<Vector2> GEKPJCGDMKB, float[] CBFPKPFEIOL)
	{
		GNKDCOHMFEG.CENDMLOMHEP cendmlomhep = new GNKDCOHMFEG.CENDMLOMHEP();
		cendmlomhep.CBFPKPFEIOL = CBFPKPFEIOL;
		cendmlomhep.GEKPJCGDMKB = GEKPJCGDMKB;
		cendmlomhep.QNDQJMNKFNN = this;
		return cendmlomhep;
	}

	// Token: 0x060078D2 RID: 30930 RVA: 0x0002B393 File Offset: 0x00029593
	private float BEGMGNCPOEE(float CLELOFNIEJK, float LHMEQNKFHIB)
	{
		return LHMEQNKFHIB / (89f * Mathf.Tan(626f * CLELOFNIEJK * 1596f));
	}

	// Token: 0x060078D3 RID: 30931 RVA: 0x0002B3AF File Offset: 0x000295AF
	private void HCKQLCEMBGI(Vector2 BGBMIEJJQKC)
	{
		this.<NKQIQDDCKKH>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060078D4 RID: 30932 RVA: 0x0002B3B8 File Offset: 0x000295B8
	public void QFBENEFFDBN()
	{
		IEnumerable<PDLMPKMDBBQ> dbilebcqibd = this.DBILEBCQIBD;
		if (GNKDCOHMFEG.LQIHFPPLONG == null)
		{
			GNKDCOHMFEG.LQIHFPPLONG = new Func<PDLMPKMDBBQ, int>(GNKDCOHMFEG.OPPDELPMDQE);
		}
		this.DBILEBCQIBD = dbilebcqibd.OrderBy(GNKDCOHMFEG.LQIHFPPLONG).ToList<PDLMPKMDBBQ>();
	}

	// Token: 0x060078D5 RID: 30933 RVA: 0x0002B3ED File Offset: 0x000295ED
	public void OnAfterDeserialize()
	{
		this.FBJHQMMMFBI();
	}

	// Token: 0x060078D6 RID: 30934 RVA: 0x0002B3F5 File Offset: 0x000295F5
	public void GEIPCQNBIJE(ECEGGIKJDGM HBGMQNPBKOI)
	{
		this.JHKJEQBBBGB.Remove(HBGMQNPBKOI);
	}

	// Token: 0x060078D7 RID: 30935 RVA: 0x0039F27C File Offset: 0x0039D47C
	public void IELCMEQQMBM(Vector2 GDJCGBDPFEO = default(Vector2))
	{
		if (GDJCGBDPFEO != default(Vector2))
		{
			this.GFQDCHOQHGP = GDJCGBDPFEO;
		}
		else
		{
			this.GFQDCHOQHGP = BDKMFJQPGGE.MLQHJBIONCC(this.PGHJQNJLJKG, Mathf.Abs(this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition)));
		}
	}

	// Token: 0x060078D8 RID: 30936 RVA: 0x0039F2D0 File Offset: 0x0039D4D0
	public void BMICOLEIFDP(Vector2 QEOOQIOKOCG)
	{
		this.FHNBJCNLJCN.localPosition = this.JQCCJCOPEJK(QEOOQIOKOCG.x, QEOOQIOKOCG.y, this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition));
		this.HEMBFJCMQNE();
	}

	// Token: 0x060078D9 RID: 30937 RVA: 0x0039F320 File Offset: 0x0039D520
	[DebuggerHidden]
	private IEnumerator LGKBPMGHEEC(float JHMKKEQDGMG, float CPKNEQGKQPQ, GMNJJQQPEDB IBMMEEDBIJB)
	{
		GNKDCOHMFEG.BDFJMMEOELO bdfjmmeoelo = new GNKDCOHMFEG.BDFJMMEOELO();
		bdfjmmeoelo.CPKNEQGKQPQ = CPKNEQGKQPQ;
		bdfjmmeoelo.JHMKKEQDGMG = JHMKKEQDGMG;
		bdfjmmeoelo.IBMMEEDBIJB = IBMMEEDBIJB;
		bdfjmmeoelo.QNDQJMNKFNN = this;
		return bdfjmmeoelo;
	}

	// Token: 0x17000433 RID: 1075
	// (get) Token: 0x0600793D RID: 31037 RVA: 0x0002B62E File Offset: 0x0002982E
	// (set) Token: 0x060078DA RID: 30938 RVA: 0x0002B404 File Offset: 0x00029604
	public float JLHLDNHPINI { get; private set; }

	// Token: 0x060078DB RID: 30939 RVA: 0x0039F250 File Offset: 0x0039D450
	private IEnumerator HPNHPPPMNND(IList<Vector2> GEKPJCGDMKB, float[] CBFPKPFEIOL)
	{
		GNKDCOHMFEG.CENDMLOMHEP cendmlomhep = new GNKDCOHMFEG.CENDMLOMHEP();
		cendmlomhep.CBFPKPFEIOL = CBFPKPFEIOL;
		cendmlomhep.GEKPJCGDMKB = GEKPJCGDMKB;
		cendmlomhep.QNDQJMNKFNN = this;
		return cendmlomhep;
	}

	// Token: 0x060078DC RID: 30940 RVA: 0x0002B40D File Offset: 0x0002960D
	private static int LQJPKKOLQEF(NODOBJOMQDI ECHMFPQNBMC)
	{
		return ECHMFPQNBMC.QQFIBLGBMKQ;
	}

	// Token: 0x060078DD RID: 30941 RVA: 0x000285BD File Offset: 0x000267BD
	private static float PIDGNOGDPGP(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x060078DE RID: 30942 RVA: 0x0002B36D File Offset: 0x0002956D
	public Vector2 LPEMLNLJNME()
	{
		return this.<NKQIQDDCKKH>k__BackingField;
	}

	// Token: 0x060078DF RID: 30943 RVA: 0x00002300 File Offset: 0x00000500
	public void OnBeforeSerialize()
	{
	}

	// Token: 0x060078E0 RID: 30944 RVA: 0x000285BD File Offset: 0x000267BD
	private static float GGMGECFEOOJ(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x060078E1 RID: 30945 RVA: 0x0039F350 File Offset: 0x0039D550
	public CameraTarget BNELEJIBECK(Transform OGEFDMHQCDB)
	{
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				return this.DBLIJKDNBLI[i];
			}
		}
		return null;
	}

	// Token: 0x060078E2 RID: 30946 RVA: 0x000285DD File Offset: 0x000267DD
	[CompilerGenerated]
	private static Vector3 QLLNFGGKDKK(float ONOGHDLFKLH, float ECFKEFOFQGB, float EKDDQNPBPJL)
	{
		return new Vector3(ONOGHDLFKLH, ECFKEFOFQGB, EKDDQNPBPJL);
	}

	// Token: 0x060078E3 RID: 30947 RVA: 0x0002B415 File Offset: 0x00029615
	public Coroutine QHQJBDMBPJK(Vector2[] GEKPJCGDMKB, float[] CBFPKPFEIOL)
	{
		return base.StartCoroutine(this.ELDLDHGCOJO(GEKPJCGDMKB, CBFPKPFEIOL));
	}

	// Token: 0x060078E4 RID: 30948 RVA: 0x0039F3A4 File Offset: 0x0039D5A4
	private void JGQMJMCKFLH(float GDJCGBDPFEO)
	{
		if (this.PGHJQNJLJKG.orthographic)
		{
			GDJCGBDPFEO = Mathf.Max(GDJCGBDPFEO, 1189f);
			this.PGHJQNJLJKG.orthographicSize = GDJCGBDPFEO;
		}
		else if (this.KCLCCJEBJPL)
		{
			float value = 1801f * Mathf.Atan(GDJCGBDPFEO / Mathf.Abs(this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition))) * 178f;
			this.PGHJQNJLJKG.fieldOfView = Mathf.Clamp(value, 790f, 827f);
		}
		else
		{
			this.FHNBJCNLJCN.localPosition = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition), this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition), GDJCGBDPFEO / Mathf.Tan(this.PGHJQNJLJKG.fieldOfView * 954f * 1303f) * this.NQKQLHLINBC);
		}
		this.ENECNILLLHH(new Vector2(GDJCGBDPFEO * 1212f * this.PGHJQNJLJKG.aspect, GDJCGBDPFEO * 200f));
		if (this.JMHEIMQEQON != null)
		{
			this.JMHEIMQEQON(this.PGKODNCDNJQ);
		}
	}

	// Token: 0x060078E5 RID: 30949 RVA: 0x000285BD File Offset: 0x000267BD
	[CompilerGenerated]
	private static float GPFFKBCOKIJ(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x060078E6 RID: 30950 RVA: 0x0039F4D8 File Offset: 0x0039D6D8
	private void LPNBKEJBHBM(float GDJCGBDPFEO)
	{
		if (this.PGHJQNJLJKG.orthographic)
		{
			GDJCGBDPFEO = Mathf.Max(GDJCGBDPFEO, 0.1f);
			this.PGHJQNJLJKG.orthographicSize = GDJCGBDPFEO;
		}
		else if (this.KCLCCJEBJPL)
		{
			float value = 2f * Mathf.Atan(GDJCGBDPFEO / Mathf.Abs(this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition))) * 57.29578f;
			this.PGHJQNJLJKG.fieldOfView = Mathf.Clamp(value, 0.1f, 179.9f);
		}
		else
		{
			this.FHNBJCNLJCN.localPosition = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition), this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition), GDJCGBDPFEO / Mathf.Tan(this.PGHJQNJLJKG.fieldOfView * 0.5f * 0.0174532924f) * this.NQKQLHLINBC);
		}
		this.PGKODNCDNJQ = new Vector2(GDJCGBDPFEO * 2f * this.PGHJQNJLJKG.aspect, GDJCGBDPFEO * 2f);
		if (this.JMHEIMQEQON != null)
		{
			this.JMHEIMQEQON(this.PGKODNCDNJQ);
		}
	}

	// Token: 0x060078E7 RID: 30951 RVA: 0x0002B425 File Offset: 0x00029625
	private void KDDKQGCFDGI()
	{
		GNKDCOHMFEG.NKGPQKNLCMC = null;
	}

	// Token: 0x060078E8 RID: 30952 RVA: 0x0039F60C File Offset: 0x0039D80C
	private void Start()
	{
		this.QCJCOLOIFFN();
		this.IQGNEJLMCFG();
		this.QFBENEFFDBN();
		this.CNKHLOLQCKP();
		this.CEPGQHPMIDI();
		this.IEFGKEDBIGD();
		this.HGNEKQHNFCC = this.IIQFDNIMJLF(ref this.DBLIJKDNBLI);
		this.EEDKPPIKFKG = this.FKGNBCKJPQO(this.HGNEKQHNFCC);
		this.NNGFLMFCBBI = this.JNBBJCLFFBB(this.HGNEKQHNFCC);
		this.JLHLDNHPINI = Time.deltaTime;
		if (this.LCEFCFMHCLN && this.DBLIJKDNBLI.Count > 0)
		{
			Vector3 arg = this.IIQFDNIMJLF(ref this.DBLIJKDNBLI);
			float x = (!this.MDGMJQMKEOK) ? this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) : this.FKGNBCKJPQO(arg);
			float y = (!this.IMJODMILBFD) ? this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) : this.JNBBJCLFFBB(arg);
			Vector2 vector = new Vector2(x, y);
			vector += new Vector2(this.PDOGMKKLQFL() - this.FKGNBCKJPQO(this.JCEGQKEQHEF), this.COBOKEGHNJP() - this.JNBBJCLFFBB(this.JCEGQKEQHEF));
			this.BMICOLEIFDP(vector);
		}
		else
		{
			this.PFBFIECJEJO = this.FHNBJCNLJCN.position - this.JCEGQKEQHEF;
			this.EEDKPPIKFKG = this.FKGNBCKJPQO(this.PFBFIECJEJO);
			this.IIJELHFCNJG = this.EEDKPPIKFKG;
			this.NNGFLMFCBBI = this.JNBBJCLFFBB(this.PFBFIECJEJO);
			this.GQQLGPJQPFO = this.NNGFLMFCBBI;
		}
	}

	// Token: 0x060078E9 RID: 30953 RVA: 0x0002B42D File Offset: 0x0002962D
	public void QCJCOLOIFFN()
	{
		IEnumerable<IEMKEPEKMFN> hfjgoflgkip = this.HFJGOFLGKIP;
		if (GNKDCOHMFEG.DFPECDNEONJ == null)
		{
			GNKDCOHMFEG.DFPECDNEONJ = new Func<IEMKEPEKMFN, int>(GNKDCOHMFEG.HLKFDDGOLDC);
		}
		this.HFJGOFLGKIP = hfjgoflgkip.OrderBy(GNKDCOHMFEG.DFPECDNEONJ).ToList<IEMKEPEKMFN>();
	}

	// Token: 0x060078EA RID: 30954 RVA: 0x0002B462 File Offset: 0x00029662
	public void NKHBPPNMLHG()
	{
		IEnumerable<NLQPOLOJJQE> fmmmqqeodph = this.FMMMQQEODPH;
		if (GNKDCOHMFEG.JJQEEKDKODJ == null)
		{
			GNKDCOHMFEG.JJQEEKDKODJ = new Func<NLQPOLOJJQE, int>(GNKDCOHMFEG.OEGJNDIPIBN);
		}
		this.FMMMQQEODPH = fmmmqqeodph.OrderBy(GNKDCOHMFEG.JJQEEKDKODJ).ToList<NLQPOLOJJQE>();
	}

	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x06007938 RID: 31032 RVA: 0x0002B54F File Offset: 0x0002974F
	// (set) Token: 0x060078EB RID: 30955 RVA: 0x0002B497 File Offset: 0x00029697
	public Vector2 EQCLOIQEDLC
	{
		get
		{
			return new Vector2(this.EEDKPPIKFKG, this.NNGFLMFCBBI);
		}
		set
		{
			this.EEDKPPIKFKG = value.x;
			this.NNGFLMFCBBI = value.y;
		}
	}

	// Token: 0x060078EC RID: 30956 RVA: 0x0002B4B3 File Offset: 0x000296B3
	[CompilerGenerated]
	private static int OEGJNDIPIBN(NLQPOLOJJQE ECHMFPQNBMC)
	{
		return ECHMFPQNBMC.OOKGEICHBQO;
	}

	// Token: 0x060078ED RID: 30957 RVA: 0x0039F27C File Offset: 0x0039D47C
	public void HJIQOOPKMQO(Vector2 GDJCGBDPFEO = default(Vector2))
	{
		if (GDJCGBDPFEO != default(Vector2))
		{
			this.GFQDCHOQHGP = GDJCGBDPFEO;
		}
		else
		{
			this.GFQDCHOQHGP = BDKMFJQPGGE.MLQHJBIONCC(this.PGHJQNJLJKG, Mathf.Abs(this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition)));
		}
	}

	// Token: 0x060078EF RID: 30959 RVA: 0x0002B4BB File Offset: 0x000296BB
	public void CONFHHMNMDH(NLQPOLOJJQE GQIPQBKIDBE)
	{
		this.FMMMQQEODPH.Remove(GQIPQBKIDBE);
	}

	// Token: 0x060078F0 RID: 30960 RVA: 0x000285C6 File Offset: 0x000267C6
	[CompilerGenerated]
	private static float QLKOPDPLEHD(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x060078F1 RID: 30961 RVA: 0x000285B4 File Offset: 0x000267B4
	[CompilerGenerated]
	private static float KEHBGLBCLFI(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x060078F2 RID: 30962 RVA: 0x0039F320 File Offset: 0x0039D520
	private IEnumerator BKCDOMHBIJK(float JHMKKEQDGMG, float CPKNEQGKQPQ, GMNJJQQPEDB IBMMEEDBIJB)
	{
		GNKDCOHMFEG.BDFJMMEOELO bdfjmmeoelo = new GNKDCOHMFEG.BDFJMMEOELO();
		bdfjmmeoelo.CPKNEQGKQPQ = CPKNEQGKQPQ;
		bdfjmmeoelo.JHMKKEQDGMG = JHMKKEQDGMG;
		bdfjmmeoelo.IBMMEEDBIJB = IBMMEEDBIJB;
		bdfjmmeoelo.QNDQJMNKFNN = this;
		return bdfjmmeoelo;
	}

	// Token: 0x060078F3 RID: 30963 RVA: 0x0002B4CA File Offset: 0x000296CA
	public void MPHJLPNDJJL(PDLMPKMDBBQ GQIPQBKIDBE)
	{
		this.DBILEBCQIBD.Add(GQIPQBKIDBE);
	}

	// Token: 0x060078F4 RID: 30964 RVA: 0x0039F7BC File Offset: 0x0039D9BC
	private void EOLPGNCNQFG()
	{
		CDLKIQJJHKE mllmoqqnkmc = this.MLLMOQQNKMC;
		if (mllmoqqnkmc != CDLKIQJJHKE.XY)
		{
			if (mllmoqqnkmc != CDLKIQJJHKE.XZ)
			{
				if (mllmoqqnkmc == CDLKIQJJHKE.YZ)
				{
					if (GNKDCOHMFEG.LBOLIPKBDBL == null)
					{
						GNKDCOHMFEG.LBOLIPKBDBL = new Func<Vector3, float>(GNKDCOHMFEG.DKHIOCFOJDF);
					}
					this.FKGNBCKJPQO = GNKDCOHMFEG.LBOLIPKBDBL;
					if (GNKDCOHMFEG.CEPOLPBOPEP == null)
					{
						GNKDCOHMFEG.CEPOLPBOPEP = new Func<Vector3, float>(GNKDCOHMFEG.GPFFKBCOKIJ);
					}
					this.JNBBJCLFFBB = GNKDCOHMFEG.CEPOLPBOPEP;
					if (GNKDCOHMFEG.MEKLOPDEIJG == null)
					{
						GNKDCOHMFEG.MEKLOPDEIJG = new Func<Vector3, float>(GNKDCOHMFEG.PBDPGPGDDPL);
					}
					this.OFPEBLPKOLD = GNKDCOHMFEG.MEKLOPDEIJG;
					if (GNKDCOHMFEG.JPGKCMJGHOD == null)
					{
						GNKDCOHMFEG.JPGKCMJGHOD = new Func<float, float, Vector3>(GNKDCOHMFEG.IMBMNCJEFJE);
					}
					this.QMEMFMDBHLI = GNKDCOHMFEG.JPGKCMJGHOD;
					if (GNKDCOHMFEG.DOLPFDKLKPE == null)
					{
						GNKDCOHMFEG.DOLPFDKLKPE = new Func<float, float, float, Vector3>(GNKDCOHMFEG.MMBECMOQGGD);
					}
					this.JQCCJCOPEJK = GNKDCOHMFEG.DOLPFDKLKPE;
				}
			}
			else
			{
				if (GNKDCOHMFEG.LDLHIHLGMOP == null)
				{
					GNKDCOHMFEG.LDLHIHLGMOP = new Func<Vector3, float>(GNKDCOHMFEG.KEHBGLBCLFI);
				}
				this.FKGNBCKJPQO = GNKDCOHMFEG.LDLHIHLGMOP;
				if (GNKDCOHMFEG.OEPCQKQDIJD == null)
				{
					GNKDCOHMFEG.OEPCQKQDIJD = new Func<Vector3, float>(GNKDCOHMFEG.GFEOFJJIKLG);
				}
				this.JNBBJCLFFBB = GNKDCOHMFEG.OEPCQKQDIJD;
				if (GNKDCOHMFEG.MMPJPDBKOOM == null)
				{
					GNKDCOHMFEG.MMPJPDBKOOM = new Func<Vector3, float>(GNKDCOHMFEG.IPCJMQGQBQI);
				}
				this.OFPEBLPKOLD = GNKDCOHMFEG.MMPJPDBKOOM;
				if (GNKDCOHMFEG.EQLOFOGBJIO == null)
				{
					GNKDCOHMFEG.EQLOFOGBJIO = new Func<float, float, Vector3>(GNKDCOHMFEG.HJLLOBLBLHH);
				}
				this.QMEMFMDBHLI = GNKDCOHMFEG.EQLOFOGBJIO;
				if (GNKDCOHMFEG.KLJBBNHCHKB == null)
				{
					GNKDCOHMFEG.KLJBBNHCHKB = new Func<float, float, float, Vector3>(GNKDCOHMFEG.FNFLJGPLFFP);
				}
				this.JQCCJCOPEJK = GNKDCOHMFEG.KLJBBNHCHKB;
			}
		}
		else
		{
			if (GNKDCOHMFEG.HNCJFHJNHDN == null)
			{
				GNKDCOHMFEG.HNCJFHJNHDN = new Func<Vector3, float>(GNKDCOHMFEG.IDKMCEIKPHK);
			}
			this.FKGNBCKJPQO = GNKDCOHMFEG.HNCJFHJNHDN;
			if (GNKDCOHMFEG.BIJFPHIBEDK == null)
			{
				GNKDCOHMFEG.BIJFPHIBEDK = new Func<Vector3, float>(GNKDCOHMFEG.PIDGNOGDPGP);
			}
			this.JNBBJCLFFBB = GNKDCOHMFEG.BIJFPHIBEDK;
			if (GNKDCOHMFEG.KKGPFHKPCFG == null)
			{
				GNKDCOHMFEG.KKGPFHKPCFG = new Func<Vector3, float>(GNKDCOHMFEG.QLKOPDPLEHD);
			}
			this.OFPEBLPKOLD = GNKDCOHMFEG.KKGPFHKPCFG;
			if (GNKDCOHMFEG.FFMGNIDNMII == null)
			{
				GNKDCOHMFEG.FFMGNIDNMII = new Func<float, float, Vector3>(GNKDCOHMFEG.DPQKKBMCDNQ);
			}
			this.QMEMFMDBHLI = GNKDCOHMFEG.FFMGNIDNMII;
			if (GNKDCOHMFEG.MLDNMQMBDGF == null)
			{
				GNKDCOHMFEG.MLDNMQMBDGF = new Func<float, float, float, Vector3>(GNKDCOHMFEG.QLLNFGGKDKK);
			}
			this.JQCCJCOPEJK = GNKDCOHMFEG.MLDNMQMBDGF;
		}
	}

	// Token: 0x060078F5 RID: 30965 RVA: 0x000285C6 File Offset: 0x000267C6
	[CompilerGenerated]
	private static float DKHIOCFOJDF(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x060078F6 RID: 30966 RVA: 0x0039FA00 File Offset: 0x0039DC00
	public static GNKDCOHMFEG QOQONHOOLNE
	{
		get
		{
			if (object.Equals(GNKDCOHMFEG.NKGPQKNLCMC, null))
			{
				GNKDCOHMFEG.NKGPQKNLCMC = (UnityEngine.Object.FindObjectOfType(typeof(GNKDCOHMFEG)) as GNKDCOHMFEG);
				if (object.Equals(GNKDCOHMFEG.NKGPQKNLCMC, null))
				{
					throw new UnityException("ProCamera2D does not exist.");
				}
			}
			return GNKDCOHMFEG.NKGPQKNLCMC;
		}
	}

	// Token: 0x060078F7 RID: 30967 RVA: 0x0002B273 File Offset: 0x00029473
	public void CQODJEOHECI()
	{
		if (this.NGNDCOPDNPH != null)
		{
			this.NGNDCOPDNPH();
		}
	}

	// Token: 0x060078F8 RID: 30968 RVA: 0x0039FA50 File Offset: 0x0039DC50
	public Coroutine HILONLEQJDH(Transform JPEDMPHJINI, float DCHDDIDNKPM, float OLNHHIBFGKL, float CPKNEQGKQPQ = 0f)
	{
		CameraTarget cameraTarget = this.BNELEJIBECK(JPEDMPHJINI);
		if (cameraTarget == null)
		{
			return null;
		}
		return this.HILONLEQJDH(cameraTarget, DCHDDIDNKPM, OLNHHIBFGKL, CPKNEQGKQPQ);
	}

	// Token: 0x060078F9 RID: 30969 RVA: 0x0039FA78 File Offset: 0x0039DC78
	public void IENKHMECIGP(Vector2 DJOCOLCEHBJ)
	{
		if (Time.deltaTime >= 0.0001f && !float.IsNaN(DJOCOLCEHBJ.x) && !float.IsNaN(DJOCOLCEHBJ.y))
		{
			this.EQNDNJDKGMK.Add(this.QMEMFMDBHLI(DJOCOLCEHBJ.x, DJOCOLCEHBJ.y));
			return;
		}
	}

	// Token: 0x060078FA RID: 30970 RVA: 0x0002B2F8 File Offset: 0x000294F8
	[CompilerGenerated]
	private static int HLKFDDGOLDC(IEMKEPEKMFN ECHMFPQNBMC)
	{
		return ECHMFPQNBMC.FDDGIKHBDNF;
	}

	// Token: 0x060078FB RID: 30971 RVA: 0x0039FAD4 File Offset: 0x0039DCD4
	public void PHJJELLGJOO(float GDJCGBDPFEO, float CPKNEQGKQPQ = 0f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseInOut)
	{
		if (!base.enabled)
		{
			return;
		}
		if (this.KFHCMFDFECM != null)
		{
			base.StopCoroutine(this.KFHCMFDFECM);
		}
		if (CPKNEQGKQPQ > 1135f)
		{
			this.KFHCMFDFECM = base.StartCoroutine(this.FPQJIFBLOGB(GDJCGBDPFEO, CPKNEQGKQPQ, IBMMEEDBIJB));
		}
		else
		{
			this.JGQMJMCKFLH(GDJCGBDPFEO);
		}
	}

	// Token: 0x060078FC RID: 30972 RVA: 0x0039FB24 File Offset: 0x0039DD24
	public float COBOKEGHNJP()
	{
		return (!this.JEKKLIIQHML) ? this.DGHDICJIMQI : (this.DGHDICJIMQI * this.PGKODNCDNJQ.y * 0.5f);
	}

	// Token: 0x060078FD RID: 30973 RVA: 0x0002B40D File Offset: 0x0002960D
	private static int OFGNOELCONM(NODOBJOMQDI ECHMFPQNBMC)
	{
		return ECHMFPQNBMC.QQFIBLGBMKQ;
	}

	// Token: 0x060078FE RID: 30974 RVA: 0x0002B497 File Offset: 0x00029697
	public void PJPMKJGIPOO(Vector2 BGBMIEJJQKC)
	{
		this.EEDKPPIKFKG = BGBMIEJJQKC.x;
		this.NNGFLMFCBBI = BGBMIEJJQKC.y;
	}

	// Token: 0x060078FF RID: 30975 RVA: 0x0002B4D8 File Offset: 0x000296D8
	public void CQCBELCFQBK(LIJCFDMDDIJ INDKHOBOEPN)
	{
		this.CMHHCJOLLQG.Remove(INDKHOBOEPN);
	}

	// Token: 0x06007900 RID: 30976 RVA: 0x0002B4BB File Offset: 0x000296BB
	public void QNDGKBBGHNK(NLQPOLOJJQE GQIPQBKIDBE)
	{
		this.FMMMQQEODPH.Remove(GQIPQBKIDBE);
	}

	// Token: 0x06007901 RID: 30977 RVA: 0x0002B37E File Offset: 0x0002957E
	private void IEBQOMBIIKB()
	{
		if (this.EPGICGGHOQI == CLQIOKJENKD.LateUpdate)
		{
			this.DFMMCLFKFBH(Time.smoothDeltaTime);
		}
	}

	// Token: 0x06007902 RID: 30978 RVA: 0x0002B4E7 File Offset: 0x000296E7
	public void ENQCBPLGIQO(NODOBJOMQDI INDKHOBOEPN)
	{
		this.HFQOJBPLKJO.Remove(INDKHOBOEPN);
	}

	// Token: 0x06007903 RID: 30979 RVA: 0x0002B4F6 File Offset: 0x000296F6
	public void COLMPQPBLFH(NODOBJOMQDI INDKHOBOEPN)
	{
		this.HFQOJBPLKJO.Add(INDKHOBOEPN);
	}

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x0600794E RID: 31054 RVA: 0x0002B68D File Offset: 0x0002988D
	// (set) Token: 0x06007904 RID: 30980 RVA: 0x0039FB5C File Offset: 0x0039DD5C
	public Rect LKBEGMFPMEP
	{
		get
		{
			return this.PGHJQNJLJKG.rect;
		}
		set
		{
			this.PGHJQNJLJKG.rect = value;
			MDLMHPELMDP componentInChildren = base.GetComponentInChildren<MDLMHPELMDP>();
			if (componentInChildren != null)
			{
				for (int i = 0; i < componentInChildren.JQJBILIJOJJ.Count; i++)
				{
					componentInChildren.JQJBILIJOJJ[i].ParallaxCamera.rect = value;
				}
			}
		}
	}

	// Token: 0x06007905 RID: 30981 RVA: 0x0002B504 File Offset: 0x00029704
	public void QPGOJCKJFBQ(IList<CameraTarget> PMILHIFHLND)
	{
		this.DBLIJKDNBLI.AddRange(PMILHIFHLND);
	}

	// Token: 0x06007906 RID: 30982 RVA: 0x0039FBB4 File Offset: 0x0039DDB4
	public void GGONPHMOELG()
	{
		this.PGHJQNJLJKG.ResetAspect();
		this.CMJBQJBJCDN(BDKMFJQPGGE.MLQHJBIONCC(this.PGHJQNJLJKG, Mathf.Abs(this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition))));
		this.EBLNDNNFDPD = Screen.width;
		this.HNJCIQCOLDO = Screen.height;
	}

	// Token: 0x06007907 RID: 30983 RVA: 0x0002B512 File Offset: 0x00029712
	public void MHNQLONHKDJ(ECEGGIKJDGM HBGMQNPBKOI)
	{
		this.JHKJEQBBBGB.Add(HBGMQNPBKOI);
	}

	// Token: 0x06007908 RID: 30984 RVA: 0x0002B425 File Offset: 0x00029625
	private void OnApplicationQuit()
	{
		GNKDCOHMFEG.NKGPQKNLCMC = null;
	}

	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x0600792E RID: 31022 RVA: 0x0002B5E4 File Offset: 0x000297E4
	// (set) Token: 0x06007909 RID: 30985 RVA: 0x0002B375 File Offset: 0x00029575
	public Vector3 LDDLLQGMKFK { get; private set; }

	// Token: 0x0600790A RID: 30986 RVA: 0x0039FC10 File Offset: 0x0039DE10
	[DebuggerHidden]
	private IEnumerator FPQJIFBLOGB(float FIDDHHCOCCD, float CPKNEQGKQPQ, GMNJJQQPEDB IBMMEEDBIJB)
	{
		GNKDCOHMFEG.POJKPCCQBJE pojkpccqbje = new GNKDCOHMFEG.POJKPCCQBJE();
		pojkpccqbje.CPKNEQGKQPQ = CPKNEQGKQPQ;
		pojkpccqbje.FIDDHHCOCCD = FIDDHHCOCCD;
		pojkpccqbje.IBMMEEDBIJB = IBMMEEDBIJB;
		pojkpccqbje.QNDQJMNKFNN = this;
		return pojkpccqbje;
	}

	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x0600790B RID: 30987 RVA: 0x0039FC40 File Offset: 0x0039DE40
	public bool BHQOFDQCCCG
	{
		get
		{
			return this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) != this.FKGNBCKJPQO(this.NMOHPQICBEO) || this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) != this.JNBBJCLFFBB(this.NMOHPQICBEO);
		}
	}

	// Token: 0x0600790C RID: 30988 RVA: 0x000285BD File Offset: 0x000267BD
	[CompilerGenerated]
	private static float BHLECHJMLGF(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x0600790D RID: 30989 RVA: 0x0039F250 File Offset: 0x0039D450
	[DebuggerHidden]
	private IEnumerator ELDLDHGCOJO(IList<Vector2> GEKPJCGDMKB, float[] CBFPKPFEIOL)
	{
		GNKDCOHMFEG.CENDMLOMHEP cendmlomhep = new GNKDCOHMFEG.CENDMLOMHEP();
		cendmlomhep.CBFPKPFEIOL = CBFPKPFEIOL;
		cendmlomhep.GEKPJCGDMKB = GEKPJCGDMKB;
		cendmlomhep.QNDQJMNKFNN = this;
		return cendmlomhep;
	}

	// Token: 0x0600790E RID: 30990 RVA: 0x0002B520 File Offset: 0x00029720
	[CompilerGenerated]
	private static int LQIPNNCHEHH(LIJCFDMDDIJ ECHMFPQNBMC)
	{
		return ECHMFPQNBMC.DPGOQJMLMNF;
	}

	// Token: 0x0600790F RID: 30991 RVA: 0x0002B4F6 File Offset: 0x000296F6
	public void FHCNNFQNMLD(NODOBJOMQDI INDKHOBOEPN)
	{
		this.HFQOJBPLKJO.Add(INDKHOBOEPN);
	}

	// Token: 0x06007910 RID: 30992 RVA: 0x0039FCA8 File Offset: 0x0039DEA8
	public void DQHLBFINOKC(float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ == 0f)
		{
			this.DBLIJKDNBLI.Clear();
		}
		else
		{
			for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
			{
				base.StartCoroutine(this.LGQHGIQEFEI(this.DBLIJKDNBLI[i], 0f, 0f, CPKNEQGKQPQ, true));
			}
		}
	}

	// Token: 0x06007911 RID: 30993 RVA: 0x0039FD08 File Offset: 0x0039DF08
	public void QMHDHFCQOIG(IList<Transform> BKCGINQGQFF, float KLLBFFNMBKP = 1f, float QLOOPBKMLHJ = 1f, float CPKNEQGKQPQ = 0f, Vector2 FOMLEOIJCQN = default(Vector2))
	{
		for (int i = 0; i < BKCGINQGQFF.Count; i++)
		{
			this.HJMBBIGEMNC(BKCGINQGQFF[i], KLLBFFNMBKP, QLOOPBKMLHJ, CPKNEQGKQPQ, FOMLEOIJCQN);
		}
	}

	// Token: 0x06007912 RID: 30994 RVA: 0x0039FD3C File Offset: 0x0039DF3C
	public void FLKOEDEIJHG(float IBJMEHLHLLO, float CPKNEQGKQPQ = 1f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseInOut)
	{
		if (!base.enabled)
		{
			return;
		}
		if (this.PGHJQNJLJKG.orthographic)
		{
			UnityEngine.Debug.LogWarning("Dolly zooming is only supported on perspective cameras");
			return;
		}
		if (this.FGIPHFFHIBI != null)
		{
			base.StopCoroutine(this.FGIPHFFHIBI);
		}
		IBJMEHLHLLO = Mathf.Clamp(IBJMEHLHLLO, 0.1f, 179.9f);
		if (CPKNEQGKQPQ <= 0f)
		{
			this.PGHJQNJLJKG.fieldOfView = IBJMEHLHLLO;
			this.FHNBJCNLJCN.localPosition = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition), this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition), this.GLFGGFEFICD(this.PGHJQNJLJKG.fieldOfView, this.PGKODNCDNJQ.y) * this.NQKQLHLINBC);
		}
		else
		{
			base.StartCoroutine(this.LGKBPMGHEEC(IBJMEHLHLLO, CPKNEQGKQPQ, IBMMEEDBIJB));
		}
	}

	// Token: 0x06007914 RID: 30996 RVA: 0x0039FE20 File Offset: 0x0039E020
	public float PDOGMKKLQFL()
	{
		return (!this.JEKKLIIQHML) ? this.FFJQFOJCDQN : (this.FFJQFOJCDQN * this.PGKODNCDNJQ.x * 0.5f);
	}

	// Token: 0x06007915 RID: 30997 RVA: 0x0002B462 File Offset: 0x00029662
	public void CEPGQHPMIDI()
	{
		IEnumerable<NLQPOLOJJQE> fmmmqqeodph = this.FMMMQQEODPH;
		if (GNKDCOHMFEG.JJQEEKDKODJ == null)
		{
			GNKDCOHMFEG.JJQEEKDKODJ = new Func<NLQPOLOJJQE, int>(GNKDCOHMFEG.OEGJNDIPIBN);
		}
		this.FMMMQQEODPH = fmmmqqeodph.OrderBy(GNKDCOHMFEG.JJQEEKDKODJ).ToList<NLQPOLOJJQE>();
	}

	// Token: 0x06007916 RID: 30998 RVA: 0x0002B520 File Offset: 0x00029720
	private static int MLPQCGBBELL(LIJCFDMDDIJ ECHMFPQNBMC)
	{
		return ECHMFPQNBMC.DPGOQJMLMNF;
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x06007917 RID: 30999 RVA: 0x0002B531 File Offset: 0x00029731
	public Vector3 HMOMIBIPFLH
	{
		get
		{
			return this.HOFNJLMGCQP;
		}
	}

	// Token: 0x06007918 RID: 31000 RVA: 0x0002B504 File Offset: 0x00029704
	public void QMHDHFCQOIG(IList<CameraTarget> PMILHIFHLND)
	{
		this.DBLIJKDNBLI.AddRange(PMILHIFHLND);
	}

	// Token: 0x06007919 RID: 31001 RVA: 0x0002B539 File Offset: 0x00029739
	private void DCGCBDGKEJK()
	{
		if (this.EPGICGGHOQI == CLQIOKJENKD.FixedUpdate)
		{
			this.DFMMCLFKFBH(Time.fixedDeltaTime);
		}
	}

	// Token: 0x0600791A RID: 31002 RVA: 0x0002B54F File Offset: 0x0002974F
	public Vector2 EKNKJLCLLCQ()
	{
		return new Vector2(this.EEDKPPIKFKG, this.NNGFLMFCBBI);
	}

	// Token: 0x0600791B RID: 31003 RVA: 0x0002B562 File Offset: 0x00029762
	[CompilerGenerated]
	private static int MHBKHGJJMDE(ECEGGIKJDGM ECHMFPQNBMC)
	{
		return ECHMFPQNBMC.HNJEOOIHCFG;
	}

	// Token: 0x0600791C RID: 31004 RVA: 0x0002B2CB File Offset: 0x000294CB
	private void CMJBQJBJCDN(Vector2 BGBMIEJJQKC)
	{
		this.<CHOIQCQDJCB>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600791D RID: 31005 RVA: 0x0002B56A File Offset: 0x0002976A
	public void CNLPQCQKDMG(bool KMCHIBKIGOG = true, bool OOPKCBGOOCE = true, bool PPFGJHGCGEB = true)
	{
		if (KMCHIBKIGOG)
		{
			this.ONFFPIKKECJ();
		}
		else
		{
			this.HEMBFJCMQNE();
		}
		if (OOPKCBGOOCE)
		{
			this.MIHGEDLDDCO();
		}
		if (PPFGJHGCGEB)
		{
			this.CQODJEOHECI();
		}
	}

	// Token: 0x0600791E RID: 31006 RVA: 0x0039FE58 File Offset: 0x0039E058
	[DebuggerHidden]
	private IEnumerator LGQHGIQEFEI(CameraTarget IJJMIMFQPEC, float IHEMDFFFPDL, float CLGQIQMBJDI, float CPKNEQGKQPQ, bool HHBFKGODNQI = false)
	{
		GNKDCOHMFEG.OPBCLINOGME opbclinogme = new GNKDCOHMFEG.OPBCLINOGME();
		opbclinogme.IJJMIMFQPEC = IJJMIMFQPEC;
		opbclinogme.CPKNEQGKQPQ = CPKNEQGKQPQ;
		opbclinogme.IHEMDFFFPDL = IHEMDFFFPDL;
		opbclinogme.CLGQIQMBJDI = CLGQIQMBJDI;
		opbclinogme.HHBFKGODNQI = HHBFKGODNQI;
		opbclinogme.QNDQJMNKFNN = this;
		return opbclinogme;
	}

	// Token: 0x0600791F RID: 31007 RVA: 0x0039FE98 File Offset: 0x0039E098
	[DebuggerHidden]
	private IEnumerator PBECGOICKHD(Vector2 DJOCOLCEHBJ, float CPKNEQGKQPQ)
	{
		GNKDCOHMFEG.DLOBIMGNIPC dlobimgnipc = new GNKDCOHMFEG.DLOBIMGNIPC();
		dlobimgnipc.CPKNEQGKQPQ = CPKNEQGKQPQ;
		dlobimgnipc.DJOCOLCEHBJ = DJOCOLCEHBJ;
		dlobimgnipc.QNDQJMNKFNN = this;
		return dlobimgnipc;
	}

	// Token: 0x06007920 RID: 31008 RVA: 0x0002B58F File Offset: 0x0002978F
	public void IQGNEJLMCFG()
	{
		IEnumerable<LIJCFDMDDIJ> cmhhcjollqg = this.CMHHCJOLLQG;
		if (GNKDCOHMFEG.BEBLCEOJHDB == null)
		{
			GNKDCOHMFEG.BEBLCEOJHDB = new Func<LIJCFDMDDIJ, int>(GNKDCOHMFEG.LQIPNNCHEHH);
		}
		this.CMHHCJOLLQG = cmhhcjollqg.OrderBy(GNKDCOHMFEG.BEBLCEOJHDB).ToList<LIJCFDMDDIJ>();
	}

	// Token: 0x06007921 RID: 31009 RVA: 0x0002B5C4 File Offset: 0x000297C4
	public void QCMGMNJGPJL(IEMKEPEKMFN HBGMQNPBKOI)
	{
		this.HFJGOFLGKIP.Remove(HBGMQNPBKOI);
	}

	// Token: 0x06007922 RID: 31010 RVA: 0x000285B4 File Offset: 0x000267B4
	[CompilerGenerated]
	private static float IDKMCEIKPHK(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06007923 RID: 31011 RVA: 0x0002B404 File Offset: 0x00029604
	private void KPGDOHLLICH(float BGBMIEJJQKC)
	{
		this.<EKPJGEJMPJD>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007924 RID: 31012 RVA: 0x0039FEC4 File Offset: 0x0039E0C4
	private void Awake()
	{
		GNKDCOHMFEG.NKGPQKNLCMC = this;
		this.FHNBJCNLJCN = base.transform;
		if (this.FHNBJCNLJCN.parent != null)
		{
			this.JCEGQKEQHEF = this.FHNBJCNLJCN.parent.position;
		}
		if (this.PGHJQNJLJKG == null)
		{
			this.PGHJQNJLJKG = base.GetComponent<Camera>();
		}
		if (this.PGHJQNJLJKG == null)
		{
			UnityEngine.Debug.LogError("Unity Camera not set and not found on the GameObject: " + base.gameObject.name);
		}
		this.FBJHQMMMFBI();
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform == null)
			{
				this.DBLIJKDNBLI.RemoveAt(i);
			}
		}
		this.GIEHLCEMPKF();
		this.IELCMEQQMBM(default(Vector2));
		this.NQKQLHLINBC = Mathf.Sign(this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition));
	}

	// Token: 0x06007925 RID: 31013 RVA: 0x0039FFC8 File Offset: 0x0039E1C8
	public void ONFFPIKKECJ()
	{
		Vector3 arg = this.IIQFDNIMJLF(ref this.DBLIJKDNBLI);
		Vector2 vector = new Vector2(this.FKGNBCKJPQO(arg), this.JNBBJCLFFBB(arg));
		vector += new Vector2(this.PDOGMKKLQFL(), this.COBOKEGHNJP());
		this.BMICOLEIFDP(vector);
	}

	// Token: 0x06007926 RID: 31014 RVA: 0x003A0020 File Offset: 0x0039E220
	public void HFMONPFPPFG()
	{
		this.PGHJQNJLJKG.ResetAspect();
		this.PGKODNCDNJQ = BDKMFJQPGGE.MLQHJBIONCC(this.PGHJQNJLJKG, Mathf.Abs(this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition)));
		this.EBLNDNNFDPD = Screen.width;
		this.HNJCIQCOLDO = Screen.height;
	}

	// Token: 0x06007927 RID: 31015 RVA: 0x003A007C File Offset: 0x0039E27C
	public static GNKDCOHMFEG GHFFHFCEENG()
	{
		if (object.Equals(GNKDCOHMFEG.NKGPQKNLCMC, null))
		{
			GNKDCOHMFEG.NKGPQKNLCMC = (UnityEngine.Object.FindObjectOfType(typeof(GNKDCOHMFEG)) as GNKDCOHMFEG);
			if (object.Equals(GNKDCOHMFEG.NKGPQKNLCMC, null))
			{
				throw new UnityException("Gives priority to a healing move.");
			}
		}
		return GNKDCOHMFEG.NKGPQKNLCMC;
	}

	// Token: 0x06007928 RID: 31016 RVA: 0x0039FA50 File Offset: 0x0039DC50
	public Coroutine IHGLMMHHDOO(Transform JPEDMPHJINI, float DCHDDIDNKPM, float OLNHHIBFGKL, float CPKNEQGKQPQ = 0f)
	{
		CameraTarget cameraTarget = this.BNELEJIBECK(JPEDMPHJINI);
		if (cameraTarget == null)
		{
			return null;
		}
		return this.HILONLEQJDH(cameraTarget, DCHDDIDNKPM, OLNHHIBFGKL, CPKNEQGKQPQ);
	}

	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x06007929 RID: 31017 RVA: 0x0002B5D3 File Offset: 0x000297D3
	// (set) Token: 0x0600792C RID: 31020 RVA: 0x0002B2CB File Offset: 0x000294CB
	public Vector2 PGKODNCDNJQ { get; private set; }

	// Token: 0x0600792B RID: 31019 RVA: 0x000285E7 File Offset: 0x000267E7
	[CompilerGenerated]
	private static Vector3 HJLLOBLBLHH(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, 0f, ECFKEFOFQGB);
	}

	// Token: 0x0600792D RID: 31021 RVA: 0x003A00CC File Offset: 0x0039E2CC
	public void NMDIHJGEEPG(float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ == 1152f)
		{
			this.DBLIJKDNBLI.Clear();
		}
		else
		{
			for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
			{
				base.StartCoroutine(this.LGQHGIQEFEI(this.DBLIJKDNBLI[i], 241f, 153f, CPKNEQGKQPQ, false));
			}
		}
	}

	// Token: 0x0600792F RID: 31023 RVA: 0x0002B288 File Offset: 0x00029488
	public void NODLKQNBMFD(NLQPOLOJJQE GQIPQBKIDBE)
	{
		this.FMMMQQEODPH.Add(GQIPQBKIDBE);
	}

	// Token: 0x06007930 RID: 31024 RVA: 0x000285F5 File Offset: 0x000267F5
	[CompilerGenerated]
	private static Vector3 FNFLJGPLFFP(float ONOGHDLFKLH, float ECFKEFOFQGB, float EKDDQNPBPJL)
	{
		return new Vector3(ONOGHDLFKLH, EKDDQNPBPJL, ECFKEFOFQGB);
	}

	// Token: 0x1700042D RID: 1069
	// (get) Token: 0x06007931 RID: 31025 RVA: 0x0002B5EC File Offset: 0x000297EC
	// (set) Token: 0x0600794B RID: 31051 RVA: 0x0002B67F File Offset: 0x0002987F
	public Vector3 HMCOIDFCKPM
	{
		get
		{
			return this.FHNBJCNLJCN.localPosition;
		}
		set
		{
			this.FHNBJCNLJCN.localPosition = value;
		}
	}

	// Token: 0x06007932 RID: 31026 RVA: 0x003A012C File Offset: 0x0039E32C
	public void PJOHKOFQDLC(float PMDMDQBHIOF, float CPKNEQGKQPQ = 0f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseInOut)
	{
		this.LHCFKHKLLOL(this.PGKODNCDNJQ.y * 0.5f + PMDMDQBHIOF, CPKNEQGKQPQ, IBMMEEDBIJB);
	}

	// Token: 0x06007933 RID: 31027 RVA: 0x003A0158 File Offset: 0x0039E358
	public void MOILDMCLGPL()
	{
		this.PGHJQNJLJKG.ResetAspect();
		this.ENECNILLLHH(BDKMFJQPGGE.MLQHJBIONCC(this.PGHJQNJLJKG, Mathf.Abs(this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition))));
		this.EBLNDNNFDPD = Screen.width;
		this.HNJCIQCOLDO = Screen.height;
	}

	// Token: 0x06007934 RID: 31028 RVA: 0x003A01B4 File Offset: 0x0039E3B4
	public void HEMBFJCMQNE()
	{
		this.PFBFIECJEJO = this.FHNBJCNLJCN.localPosition;
		this.EEDKPPIKFKG = this.FKGNBCKJPQO(this.PFBFIECJEJO);
		this.NNGFLMFCBBI = this.JNBBJCLFFBB(this.PFBFIECJEJO);
		this.IIJELHFCNJG = this.EEDKPPIKFKG;
		this.GQQLGPJQPFO = this.NNGFLMFCBBI;
	}

	// Token: 0x06007935 RID: 31029 RVA: 0x0002B528 File Offset: 0x00029728
	private void DJGOQHMNFGC(Vector3 BGBMIEJJQKC)
	{
		this.<LOPEFEPJCHE>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007936 RID: 31030 RVA: 0x0002B539 File Offset: 0x00029739
	private void FixedUpdate()
	{
		if (this.EPGICGGHOQI == CLQIOKJENKD.FixedUpdate)
		{
			this.DFMMCLFKFBH(Time.fixedDeltaTime);
		}
	}

	// Token: 0x06007939 RID: 31033 RVA: 0x003A02C4 File Offset: 0x0039E4C4
	public void JCMJOPMHJFM()
	{
		this.LPNBKEJBHBM(this.GFQDCHOQHGP.y / 2f);
	}

	// Token: 0x0600793A RID: 31034 RVA: 0x0002B5F9 File Offset: 0x000297F9
	public void CNKHLOLQCKP()
	{
		IEnumerable<NODOBJOMQDI> hfqojbplkjo = this.HFQOJBPLKJO;
		if (GNKDCOHMFEG.GEQHDCDLHDN == null)
		{
			GNKDCOHMFEG.GEQHDCDLHDN = new Func<NODOBJOMQDI, int>(GNKDCOHMFEG.KIFKKGDMKGD);
		}
		this.HFQOJBPLKJO = hfqojbplkjo.OrderBy(GNKDCOHMFEG.GEQHDCDLHDN).ToList<NODOBJOMQDI>();
	}

	// Token: 0x0600793B RID: 31035 RVA: 0x003A02EC File Offset: 0x0039E4EC
	public CameraTarget HJMBBIGEMNC(Transform OGEFDMHQCDB, float DCHDDIDNKPM = 1f, float OLNHHIBFGKL = 1f, float CPKNEQGKQPQ = 0f, Vector2 FOMLEOIJCQN = default(Vector2))
	{
		CameraTarget cameraTarget = new CameraTarget
		{
			TargetTransform = OGEFDMHQCDB,
			TargetInfluenceH = DCHDDIDNKPM,
			TargetInfluenceV = OLNHHIBFGKL,
			TargetOffset = FOMLEOIJCQN
		};
		this.DBLIJKDNBLI.Add(cameraTarget);
		if (CPKNEQGKQPQ > 0f)
		{
			cameraTarget.TargetInfluence = 0f;
			base.StartCoroutine(this.LGQHGIQEFEI(cameraTarget, DCHDDIDNKPM, OLNHHIBFGKL, CPKNEQGKQPQ, false));
		}
		return cameraTarget;
	}

	// Token: 0x0600793C RID: 31036 RVA: 0x000285DD File Offset: 0x000267DD
	private static Vector3 EPQLLLEJNNL(float ONOGHDLFKLH, float ECFKEFOFQGB, float EKDDQNPBPJL)
	{
		return new Vector3(ONOGHDLFKLH, ECFKEFOFQGB, EKDDQNPBPJL);
	}

	// Token: 0x0600793E RID: 31038 RVA: 0x0002B636 File Offset: 0x00029836
	[CompilerGenerated]
	private static int OPPDELPMDQE(PDLMPKMDBBQ ECHMFPQNBMC)
	{
		return ECHMFPQNBMC.IDIPKDLCMCK;
	}

	// Token: 0x0600793F RID: 31039 RVA: 0x000285B4 File Offset: 0x000267B4
	[CompilerGenerated]
	private static float PBDPGPGDDPL(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06007940 RID: 31040 RVA: 0x0002B4E7 File Offset: 0x000296E7
	public void CQIPIPOJKDH(NODOBJOMQDI INDKHOBOEPN)
	{
		this.HFQOJBPLKJO.Remove(INDKHOBOEPN);
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x06007941 RID: 31041 RVA: 0x0002B63E File Offset: 0x0002983E
	public static bool OMQCJPOBICE
	{
		get
		{
			return GNKDCOHMFEG.NKGPQKNLCMC != null;
		}
	}

	// Token: 0x06007942 RID: 31042 RVA: 0x000285BD File Offset: 0x000267BD
	[CompilerGenerated]
	private static float IPCJMQGQBQI(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x06007943 RID: 31043 RVA: 0x0002B2C3 File Offset: 0x000294C3
	// (set) Token: 0x06007951 RID: 31057 RVA: 0x0002B69A File Offset: 0x0002989A
	public Vector3 HGNEKQHNFCC { get; private set; }

	// Token: 0x06007944 RID: 31044 RVA: 0x0002B5D3 File Offset: 0x000297D3
	public Vector2 FOOEEHDJBQN()
	{
		return this.<CHOIQCQDJCB>k__BackingField;
	}

	// Token: 0x06007945 RID: 31045 RVA: 0x003A0354 File Offset: 0x0039E554
	public void MIHGEDLDDCO()
	{
		this.JGQMJMCKFLH(this.LPEMLNLJNME().y / 279f);
	}

	// Token: 0x06007946 RID: 31046 RVA: 0x0002B64B File Offset: 0x0002984B
	public void Reset(bool KMCHIBKIGOG = true, bool OOPKCBGOOCE = true, bool PPFGJHGCGEB = true)
	{
		if (KMCHIBKIGOG)
		{
			this.ONFFPIKKECJ();
		}
		else
		{
			this.HEMBFJCMQNE();
		}
		if (OOPKCBGOOCE)
		{
			this.JCMJOPMHJFM();
		}
		if (PPFGJHGCGEB)
		{
			this.PKCLIDDHIKF();
		}
	}

	// Token: 0x06007947 RID: 31047 RVA: 0x0002860D File Offset: 0x0002680D
	private static Vector3 QQQJFHNOPMQ(float ONOGHDLFKLH, float ECFKEFOFQGB, float EKDDQNPBPJL)
	{
		return new Vector3(EKDDQNPBPJL, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x06007948 RID: 31048 RVA: 0x003A037C File Offset: 0x0039E57C
	private Vector3 IIQFDNIMJLF(ref List<CameraTarget> LQBFBGBNHHC)
	{
		float num = 0f;
		float num2 = 0f;
		if (LQBFBGBNHHC.Count == 0)
		{
			return base.transform.localPosition;
		}
		float num3 = 0f;
		float num4 = 0f;
		int num5 = 0;
		int num6 = 0;
		for (int i = 0; i < LQBFBGBNHHC.Count; i++)
		{
			if (LQBFBGBNHHC[i] != null && !(LQBFBGBNHHC[i].TargetTransform == null))
			{
				num += (this.FKGNBCKJPQO(LQBFBGBNHHC[i].TargetPosition) + LQBFBGBNHHC[i].TargetOffset.x) * LQBFBGBNHHC[i].TargetInfluenceH;
				num2 += (this.JNBBJCLFFBB(LQBFBGBNHHC[i].TargetPosition) + LQBFBGBNHHC[i].TargetOffset.y) * LQBFBGBNHHC[i].TargetInfluenceV;
				num3 += LQBFBGBNHHC[i].TargetInfluenceH;
				num4 += LQBFBGBNHHC[i].TargetInfluenceV;
				if (LQBFBGBNHHC[i].TargetInfluenceH > 0f)
				{
					num5++;
				}
				if (LQBFBGBNHHC[i].TargetInfluenceV > 0f)
				{
					num6++;
				}
			}
			else
			{
				LQBFBGBNHHC.RemoveAt(i);
			}
		}
		if (num3 < 1f && num5 == 1)
		{
			num3 += 1f - num3;
		}
		if (num4 < 1f && num6 == 1)
		{
			num4 += 1f - num4;
		}
		if (num3 > 0.0001f)
		{
			num /= num3;
		}
		if (num4 > 0.0001f)
		{
			num2 /= num4;
		}
		return this.QMEMFMDBHLI(num, num2);
	}

	// Token: 0x06007949 RID: 31049 RVA: 0x0002B40D File Offset: 0x0002960D
	[CompilerGenerated]
	private static int KIFKKGDMKGD(NODOBJOMQDI ECHMFPQNBMC)
	{
		return ECHMFPQNBMC.QQFIBLGBMKQ;
	}

	// Token: 0x0600794A RID: 31050 RVA: 0x0002B670 File Offset: 0x00029870
	public void BOFHBQKBBFC(PDLMPKMDBBQ GQIPQBKIDBE)
	{
		this.DBILEBCQIBD.Remove(GQIPQBKIDBE);
	}

	// Token: 0x0600794C RID: 31052 RVA: 0x003A0534 File Offset: 0x0039E734
	public void LHCFKHKLLOL(float GDJCGBDPFEO, float CPKNEQGKQPQ = 0f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseInOut)
	{
		if (!base.enabled)
		{
			return;
		}
		if (this.KFHCMFDFECM != null)
		{
			base.StopCoroutine(this.KFHCMFDFECM);
		}
		if (CPKNEQGKQPQ > 0f)
		{
			this.KFHCMFDFECM = base.StartCoroutine(this.FPQJIFBLOGB(GDJCGBDPFEO, CPKNEQGKQPQ, IBMMEEDBIJB));
		}
		else
		{
			this.LPNBKEJBHBM(GDJCGBDPFEO);
		}
	}

	// Token: 0x0600794D RID: 31053 RVA: 0x003A0584 File Offset: 0x0039E784
	public void MJOCMCCPMFC(Transform OGEFDMHQCDB, float CPKNEQGKQPQ = 0f)
	{
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				if (CPKNEQGKQPQ > 0f)
				{
					base.StartCoroutine(this.LGQHGIQEFEI(this.DBLIJKDNBLI[i], 0f, 0f, CPKNEQGKQPQ, true));
				}
				else
				{
					this.DBLIJKDNBLI.Remove(this.DBLIJKDNBLI[i]);
				}
			}
		}
	}

	// Token: 0x0600794F RID: 31055 RVA: 0x003A060C File Offset: 0x0039E80C
	private void FBJHQMMMFBI()
	{
		CDLKIQJJHKE mllmoqqnkmc = this.MLLMOQQNKMC;
		if (mllmoqqnkmc != CDLKIQJJHKE.XY)
		{
			if (mllmoqqnkmc != CDLKIQJJHKE.XZ)
			{
				if (mllmoqqnkmc == CDLKIQJJHKE.YZ)
				{
					if (GNKDCOHMFEG.LBOLIPKBDBL == null)
					{
						GNKDCOHMFEG.LBOLIPKBDBL = new Func<Vector3, float>(GNKDCOHMFEG.DKHIOCFOJDF);
					}
					this.FKGNBCKJPQO = GNKDCOHMFEG.LBOLIPKBDBL;
					if (GNKDCOHMFEG.CEPOLPBOPEP == null)
					{
						GNKDCOHMFEG.CEPOLPBOPEP = new Func<Vector3, float>(GNKDCOHMFEG.GPFFKBCOKIJ);
					}
					this.JNBBJCLFFBB = GNKDCOHMFEG.CEPOLPBOPEP;
					if (GNKDCOHMFEG.MEKLOPDEIJG == null)
					{
						GNKDCOHMFEG.MEKLOPDEIJG = new Func<Vector3, float>(GNKDCOHMFEG.PBDPGPGDDPL);
					}
					this.OFPEBLPKOLD = GNKDCOHMFEG.MEKLOPDEIJG;
					if (GNKDCOHMFEG.JPGKCMJGHOD == null)
					{
						GNKDCOHMFEG.JPGKCMJGHOD = new Func<float, float, Vector3>(GNKDCOHMFEG.IMBMNCJEFJE);
					}
					this.QMEMFMDBHLI = GNKDCOHMFEG.JPGKCMJGHOD;
					if (GNKDCOHMFEG.DOLPFDKLKPE == null)
					{
						GNKDCOHMFEG.DOLPFDKLKPE = new Func<float, float, float, Vector3>(GNKDCOHMFEG.MMBECMOQGGD);
					}
					this.JQCCJCOPEJK = GNKDCOHMFEG.DOLPFDKLKPE;
				}
			}
			else
			{
				if (GNKDCOHMFEG.LDLHIHLGMOP == null)
				{
					GNKDCOHMFEG.LDLHIHLGMOP = new Func<Vector3, float>(GNKDCOHMFEG.KEHBGLBCLFI);
				}
				this.FKGNBCKJPQO = GNKDCOHMFEG.LDLHIHLGMOP;
				if (GNKDCOHMFEG.OEPCQKQDIJD == null)
				{
					GNKDCOHMFEG.OEPCQKQDIJD = new Func<Vector3, float>(GNKDCOHMFEG.GFEOFJJIKLG);
				}
				this.JNBBJCLFFBB = GNKDCOHMFEG.OEPCQKQDIJD;
				if (GNKDCOHMFEG.MMPJPDBKOOM == null)
				{
					GNKDCOHMFEG.MMPJPDBKOOM = new Func<Vector3, float>(GNKDCOHMFEG.IPCJMQGQBQI);
				}
				this.OFPEBLPKOLD = GNKDCOHMFEG.MMPJPDBKOOM;
				if (GNKDCOHMFEG.EQLOFOGBJIO == null)
				{
					GNKDCOHMFEG.EQLOFOGBJIO = new Func<float, float, Vector3>(GNKDCOHMFEG.HJLLOBLBLHH);
				}
				this.QMEMFMDBHLI = GNKDCOHMFEG.EQLOFOGBJIO;
				if (GNKDCOHMFEG.KLJBBNHCHKB == null)
				{
					GNKDCOHMFEG.KLJBBNHCHKB = new Func<float, float, float, Vector3>(GNKDCOHMFEG.FNFLJGPLFFP);
				}
				this.JQCCJCOPEJK = GNKDCOHMFEG.KLJBBNHCHKB;
			}
		}
		else
		{
			if (GNKDCOHMFEG.HNCJFHJNHDN == null)
			{
				GNKDCOHMFEG.HNCJFHJNHDN = new Func<Vector3, float>(GNKDCOHMFEG.IDKMCEIKPHK);
			}
			this.FKGNBCKJPQO = GNKDCOHMFEG.HNCJFHJNHDN;
			if (GNKDCOHMFEG.BIJFPHIBEDK == null)
			{
				GNKDCOHMFEG.BIJFPHIBEDK = new Func<Vector3, float>(GNKDCOHMFEG.BHLECHJMLGF);
			}
			this.JNBBJCLFFBB = GNKDCOHMFEG.BIJFPHIBEDK;
			if (GNKDCOHMFEG.KKGPFHKPCFG == null)
			{
				GNKDCOHMFEG.KKGPFHKPCFG = new Func<Vector3, float>(GNKDCOHMFEG.QLKOPDPLEHD);
			}
			this.OFPEBLPKOLD = GNKDCOHMFEG.KKGPFHKPCFG;
			if (GNKDCOHMFEG.FFMGNIDNMII == null)
			{
				GNKDCOHMFEG.FFMGNIDNMII = new Func<float, float, Vector3>(GNKDCOHMFEG.DPQKKBMCDNQ);
			}
			this.QMEMFMDBHLI = GNKDCOHMFEG.FFMGNIDNMII;
			if (GNKDCOHMFEG.MLDNMQMBDGF == null)
			{
				GNKDCOHMFEG.MLDNMQMBDGF = new Func<float, float, float, Vector3>(GNKDCOHMFEG.QLLNFGGKDKK);
			}
			this.JQCCJCOPEJK = GNKDCOHMFEG.MLDNMQMBDGF;
		}
	}

	// Token: 0x06007950 RID: 31056 RVA: 0x0039FE98 File Offset: 0x0039E098
	private IEnumerator IKKGCDDGFJI(Vector2 DJOCOLCEHBJ, float CPKNEQGKQPQ)
	{
		GNKDCOHMFEG.DLOBIMGNIPC dlobimgnipc = new GNKDCOHMFEG.DLOBIMGNIPC();
		dlobimgnipc.CPKNEQGKQPQ = CPKNEQGKQPQ;
		dlobimgnipc.DJOCOLCEHBJ = DJOCOLCEHBJ;
		dlobimgnipc.QNDQJMNKFNN = this;
		return dlobimgnipc;
	}

	// Token: 0x06007952 RID: 31058 RVA: 0x003A0020 File Offset: 0x0039E220
	public void GIEHLCEMPKF()
	{
		this.PGHJQNJLJKG.ResetAspect();
		this.PGKODNCDNJQ = BDKMFJQPGGE.MLQHJBIONCC(this.PGHJQNJLJKG, Mathf.Abs(this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition)));
		this.EBLNDNNFDPD = Screen.width;
		this.HNJCIQCOLDO = Screen.height;
	}

	// Token: 0x06007953 RID: 31059 RVA: 0x0039F250 File Offset: 0x0039D450
	private IEnumerator BNNGMKDLMNE(IList<Vector2> GEKPJCGDMKB, float[] CBFPKPFEIOL)
	{
		GNKDCOHMFEG.CENDMLOMHEP cendmlomhep = new GNKDCOHMFEG.CENDMLOMHEP();
		cendmlomhep.CBFPKPFEIOL = CBFPKPFEIOL;
		cendmlomhep.GEKPJCGDMKB = GEKPJCGDMKB;
		cendmlomhep.QNDQJMNKFNN = this;
		return cendmlomhep;
	}

	// Token: 0x06007954 RID: 31060 RVA: 0x0002860D File Offset: 0x0002680D
	[CompilerGenerated]
	private static Vector3 MMBECMOQGGD(float ONOGHDLFKLH, float ECFKEFOFQGB, float EKDDQNPBPJL)
	{
		return new Vector3(EKDDQNPBPJL, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x06007955 RID: 31061 RVA: 0x0002B6A3 File Offset: 0x000298A3
	private static Vector3 QQPNKEBNKFO(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, 294f, ECFKEFOFQGB);
	}

	// Token: 0x06007957 RID: 31063 RVA: 0x003A0850 File Offset: 0x0039EA50
	private void QBCNICQMEBG(float GDJCGBDPFEO)
	{
		if (this.PGHJQNJLJKG.orthographic)
		{
			GDJCGBDPFEO = Mathf.Max(GDJCGBDPFEO, 1609f);
			this.PGHJQNJLJKG.orthographicSize = GDJCGBDPFEO;
		}
		else if (this.KCLCCJEBJPL)
		{
			float value = 1857f * Mathf.Atan(GDJCGBDPFEO / Mathf.Abs(this.OFPEBLPKOLD(this.FHNBJCNLJCN.localPosition))) * 1567f;
			this.PGHJQNJLJKG.fieldOfView = Mathf.Clamp(value, 1205f, 1220f);
		}
		else
		{
			this.FHNBJCNLJCN.localPosition = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition), this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition), GDJCGBDPFEO / Mathf.Tan(this.PGHJQNJLJKG.fieldOfView * 707f * 989f) * this.NQKQLHLINBC);
		}
		this.PGKODNCDNJQ = new Vector2(GDJCGBDPFEO * 1778f * this.PGHJQNJLJKG.aspect, GDJCGBDPFEO * 140f);
		if (this.JMHEIMQEQON != null)
		{
			this.JMHEIMQEQON(this.FOOEEHDJBQN());
		}
	}

	// Token: 0x06007958 RID: 31064 RVA: 0x0002B6C2 File Offset: 0x000298C2
	private static Vector3 JPDDIGFECFK(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(1286f, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x04001A1E RID: 6686
	public const string NKKMJICKKLB = "Pro Camera 2D";

	// Token: 0x04001A1F RID: 6687
	public static readonly Version EBDMBIIOKFJ = new Version("2.6.3");

	// Token: 0x04001A20 RID: 6688
	public List<CameraTarget> DBLIJKDNBLI = new List<CameraTarget>();

	// Token: 0x04001A21 RID: 6689
	public bool LCEFCFMHCLN;

	// Token: 0x04001A22 RID: 6690
	public CDLKIQJJHKE MLLMOQQNKMC;

	// Token: 0x04001A23 RID: 6691
	public CLQIOKJENKD EPGICGGHOQI;

	// Token: 0x04001A24 RID: 6692
	public bool MDGMJQMKEOK = true;

	// Token: 0x04001A25 RID: 6693
	public float LBJLGDGHFBJ = 0.15f;

	// Token: 0x04001A26 RID: 6694
	public bool IMJODMILBFD = true;

	// Token: 0x04001A27 RID: 6695
	public float EQGPIDFNHHG = 0.15f;

	// Token: 0x04001A28 RID: 6696
	[Range(-1f, 1f)]
	public float FFJQFOJCDQN;

	// Token: 0x04001A29 RID: 6697
	[Range(-1f, 1f)]
	public float DGHDICJIMQI;

	// Token: 0x04001A2A RID: 6698
	public bool JEKKLIIQHML = true;

	// Token: 0x04001A2B RID: 6699
	public bool KCLCCJEBJPL;

	// Token: 0x04001A2C RID: 6700
	private static GNKDCOHMFEG NKGPQKNLCMC;

	// Token: 0x04001A2D RID: 6701
	private float EEDKPPIKFKG;

	// Token: 0x04001A2E RID: 6702
	private float NNGFLMFCBBI;

	// Token: 0x04001A36 RID: 6710
	private Vector3 HOFNJLMGCQP = Vector3.zero;

	// Token: 0x04001A37 RID: 6711
	public Action<float> QCFEHBPOCGC;

	// Token: 0x04001A38 RID: 6712
	public Action<float> EGOKFPNIMBH;

	// Token: 0x04001A39 RID: 6713
	public Action<Vector2> JMHEIMQEQON;

	// Token: 0x04001A3A RID: 6714
	public Action<float> DILINFLCCPI;

	// Token: 0x04001A3B RID: 6715
	public Action<float> QFDDLFNDCFM;

	// Token: 0x04001A3C RID: 6716
	public Action NGNDCOPDNPH;

	// Token: 0x04001A3D RID: 6717
	public Vector3? JQPHDHIICJE;

	// Token: 0x04001A3E RID: 6718
	public int BPEDJKLJDMJ;

	// Token: 0x04001A3F RID: 6719
	public bool GBLMKLCEOJD;

	// Token: 0x04001A40 RID: 6720
	public bool IKMGDQCOMMP;

	// Token: 0x04001A41 RID: 6721
	public bool GQEBOLFGLDE;

	// Token: 0x04001A42 RID: 6722
	public bool BCPMLPJKKDJ;

	// Token: 0x04001A43 RID: 6723
	public Camera PGHJQNJLJKG;

	// Token: 0x04001A44 RID: 6724
	private Func<Vector3, float> FKGNBCKJPQO;

	// Token: 0x04001A45 RID: 6725
	private Func<Vector3, float> JNBBJCLFFBB;

	// Token: 0x04001A46 RID: 6726
	private Func<Vector3, float> OFPEBLPKOLD;

	// Token: 0x04001A47 RID: 6727
	private Func<float, float, Vector3> QMEMFMDBHLI;

	// Token: 0x04001A48 RID: 6728
	private Func<float, float, float, Vector3> JQCCJCOPEJK;

	// Token: 0x04001A49 RID: 6729
	private Coroutine KFHCMFDFECM;

	// Token: 0x04001A4A RID: 6730
	private Coroutine FGIPHFFHIBI;

	// Token: 0x04001A4B RID: 6731
	private List<Vector3> EQNDNJDKGMK = new List<Vector3>();

	// Token: 0x04001A4C RID: 6732
	private float NQKQLHLINBC;

	// Token: 0x04001A4D RID: 6733
	private float IIJELHFCNJG;

	// Token: 0x04001A4E RID: 6734
	private float GQQLGPJQPFO;

	// Token: 0x04001A4F RID: 6735
	private int EBLNDNNFDPD;

	// Token: 0x04001A50 RID: 6736
	private int HNJCIQCOLDO;

	// Token: 0x04001A51 RID: 6737
	private Vector3 NMOHPQICBEO;

	// Token: 0x04001A52 RID: 6738
	private WaitForFixedUpdate NQBGPPPKHCM = new WaitForFixedUpdate();

	// Token: 0x04001A53 RID: 6739
	private Transform FHNBJCNLJCN;

	// Token: 0x04001A54 RID: 6740
	private List<IEMKEPEKMFN> HFJGOFLGKIP = new List<IEMKEPEKMFN>();

	// Token: 0x04001A55 RID: 6741
	private List<LIJCFDMDDIJ> CMHHCJOLLQG = new List<LIJCFDMDDIJ>();

	// Token: 0x04001A56 RID: 6742
	private List<PDLMPKMDBBQ> DBILEBCQIBD = new List<PDLMPKMDBBQ>();

	// Token: 0x04001A57 RID: 6743
	private List<NODOBJOMQDI> HFQOJBPLKJO = new List<NODOBJOMQDI>();

	// Token: 0x04001A58 RID: 6744
	private List<NLQPOLOJJQE> FMMMQQEODPH = new List<NLQPOLOJJQE>();

	// Token: 0x04001A59 RID: 6745
	private List<ECEGGIKJDGM> JHKJEQBBBGB = new List<ECEGGIKJDGM>();

	// Token: 0x04001A5A RID: 6746
	[CompilerGenerated]
	private static Func<Vector3, float> HNCJFHJNHDN;

	// Token: 0x04001A5B RID: 6747
	[CompilerGenerated]
	private static Func<Vector3, float> BIJFPHIBEDK;

	// Token: 0x04001A5C RID: 6748
	[CompilerGenerated]
	private static Func<Vector3, float> KKGPFHKPCFG;

	// Token: 0x04001A5D RID: 6749
	[CompilerGenerated]
	private static Func<float, float, Vector3> FFMGNIDNMII;

	// Token: 0x04001A5E RID: 6750
	[CompilerGenerated]
	private static Func<float, float, float, Vector3> MLDNMQMBDGF;

	// Token: 0x04001A5F RID: 6751
	[CompilerGenerated]
	private static Func<Vector3, float> LDLHIHLGMOP;

	// Token: 0x04001A60 RID: 6752
	[CompilerGenerated]
	private static Func<Vector3, float> OEPCQKQDIJD;

	// Token: 0x04001A61 RID: 6753
	[CompilerGenerated]
	private static Func<Vector3, float> MMPJPDBKOOM;

	// Token: 0x04001A62 RID: 6754
	[CompilerGenerated]
	private static Func<float, float, Vector3> EQLOFOGBJIO;

	// Token: 0x04001A63 RID: 6755
	[CompilerGenerated]
	private static Func<float, float, float, Vector3> KLJBBNHCHKB;

	// Token: 0x04001A64 RID: 6756
	[CompilerGenerated]
	private static Func<Vector3, float> LBOLIPKBDBL;

	// Token: 0x04001A65 RID: 6757
	[CompilerGenerated]
	private static Func<Vector3, float> CEPOLPBOPEP;

	// Token: 0x04001A66 RID: 6758
	[CompilerGenerated]
	private static Func<Vector3, float> MEKLOPDEIJG;

	// Token: 0x04001A67 RID: 6759
	[CompilerGenerated]
	private static Func<float, float, Vector3> JPGKCMJGHOD;

	// Token: 0x04001A68 RID: 6760
	[CompilerGenerated]
	private static Func<float, float, float, Vector3> DOLPFDKLKPE;

	// Token: 0x04001A69 RID: 6761
	[CompilerGenerated]
	private static Func<IEMKEPEKMFN, int> DFPECDNEONJ;

	// Token: 0x04001A6A RID: 6762
	[CompilerGenerated]
	private static Func<LIJCFDMDDIJ, int> BEBLCEOJHDB;

	// Token: 0x04001A6B RID: 6763
	[CompilerGenerated]
	private static Func<PDLMPKMDBBQ, int> LQIHFPPLONG;

	// Token: 0x04001A6C RID: 6764
	[CompilerGenerated]
	private static Func<NODOBJOMQDI, int> GEQHDCDLHDN;

	// Token: 0x04001A6D RID: 6765
	[CompilerGenerated]
	private static Func<NLQPOLOJJQE, int> JJQEEKDKODJ;

	// Token: 0x04001A6E RID: 6766
	[CompilerGenerated]
	private static Func<ECEGGIKJDGM, int> OIQQMHFMIIC;
}
