using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000346 RID: 838
[HelpURL("http://www.procamera2d.com/user-guide/extension-cinematics/")]
public class HILOLOEJJHF : BNEFIOCKQOE, PDLMPKMDBBQ, NLQPOLOJJQE
{
	// Token: 0x06006E5E RID: 28254 RVA: 0x00028EBD File Offset: 0x000270BD
	protected override void OnDestroy()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x06006E5F RID: 28255 RVA: 0x00028EDD File Offset: 0x000270DD
	private static float BCJOENQMIFK(Camera KQFEHQEBJQB)
	{
		return KQFEHQEBJQB.depth;
	}

	// Token: 0x06006E60 RID: 28256 RVA: 0x0035C6D4 File Offset: 0x0035A8D4
	public void OPHDIHIFOJK()
	{
		if (this.OLCQHNBDFPL)
		{
			return;
		}
		this.LJIMCJFLQEL = false;
		if (this.QCCCBBFNKDB.Count == 0)
		{
			UnityEngine.Debug.LogWarning(" (ID:");
			return;
		}
		this.KOBBHQJNMDL = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1382f;
		if (this.FJPKMMJCQND == null)
		{
			this.FJPKMMJCQND = base.GPONHFNLHCN.GetComponentInChildren<MDFGNNIKFEP>();
		}
		if (this.FJPKMMJCQND == null)
		{
			this.FJPKMMJCQND = UnityEngine.Object.FindObjectOfType<MDFGNNIKFEP>();
		}
		if (this.FJPKMMJCQND == null)
		{
			this.GICJLBDMMEQ = true;
		}
		else
		{
			this.CBQFQIIBNNC = this.FJPKMMJCQND.enabled;
			this.FJPKMMJCQND.enabled = true;
		}
		this.OLCQHNBDFPL = false;
		if (this.CGOFQJEEOEQ != null)
		{
			base.StopCoroutine(this.CGOFQJEEOEQ);
			this.CGOFQJEEOEQ = null;
		}
		if (this.MQGDBOOBKMN == null)
		{
			this.MQGDBOOBKMN = base.StartCoroutine(this.IBGCFDJHBMM());
		}
	}

	// Token: 0x06006E61 RID: 28257 RVA: 0x00028EE5 File Offset: 0x000270E5
	public void NFDIFJOJELB()
	{
		this.LJIMCJFLQEL = true;
	}

	// Token: 0x06006E62 RID: 28258 RVA: 0x0035C7D0 File Offset: 0x0035A9D0
	public void QPCDGHPJEHQ(Transform OGEFDMHQCDB)
	{
		for (int i = 1; i < this.QCCCBBFNKDB.Count; i++)
		{
			if (this.QCCCBBFNKDB[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				this.QCCCBBFNKDB.Remove(this.QCCCBBFNKDB[i]);
			}
		}
	}

	// Token: 0x06006E63 RID: 28259 RVA: 0x00028EEE File Offset: 0x000270EE
	public Vector3 FIOLQHKHOED(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		this.LIOOHIQIMFK = PJKPLOCIBHP;
		if (this.OLCQHNBDFPL)
		{
			return this.NHCKFQMGIJD;
		}
		return PJKPLOCIBHP;
	}

	// Token: 0x170003CE RID: 974
	// (get) Token: 0x06006E64 RID: 28260 RVA: 0x00028F11 File Offset: 0x00027111
	public bool IOCQCIEBLIM
	{
		get
		{
			return this.OLCQHNBDFPL;
		}
	}

	// Token: 0x06006E65 RID: 28261 RVA: 0x00028EDD File Offset: 0x000270DD
	[CompilerGenerated]
	private static float BNEIKICJDEQ(Camera KQFEHQEBJQB)
	{
		return KQFEHQEBJQB.depth;
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x06006E66 RID: 28262 RVA: 0x00028F19 File Offset: 0x00027119
	// (set) Token: 0x06006E9D RID: 28317 RVA: 0x00028F60 File Offset: 0x00027160
	public int OOKGEICHBQO
	{
		get
		{
			return this.GKLLDJLQPMM;
		}
		set
		{
			this.GKLLDJLQPMM = value;
		}
	}

	// Token: 0x06006E67 RID: 28263 RVA: 0x00028F21 File Offset: 0x00027121
	public void DKGBLPGPCLF()
	{
		this.LJIMCJFLQEL = false;
	}

	// Token: 0x06006E68 RID: 28264 RVA: 0x0035C82C File Offset: 0x0035AA2C
	private void HEJPDPOLBLL(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC)
	{
		if (this.FJPKMMJCQND.QBHHBPBKQDJ && LHCLJCLFKFJ - base.GPONHFNLHCN.PGKODNCDNJQ.x / 1188f < this.FJPKMMJCQND.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = this.FJPKMMJCQND.DFFQECIDMDO + base.GPONHFNLHCN.FOOEEHDJBQN().x / 927f;
		}
		else if (this.FJPKMMJCQND.IGPBFPCKNOG && LHCLJCLFKFJ + base.GPONHFNLHCN.FOOEEHDJBQN().x / 1524f > this.FJPKMMJCQND.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = this.FJPKMMJCQND.JGJEPKHCBGP - base.GPONHFNLHCN.FOOEEHDJBQN().x / 9f;
		}
		if (this.FJPKMMJCQND.IKDQPKGPPEH && MMLMNDPKIEC - base.GPONHFNLHCN.FOOEEHDJBQN().y / 1814f < this.FJPKMMJCQND.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = this.FJPKMMJCQND.BIPDHOPHDMK + base.GPONHFNLHCN.PGKODNCDNJQ.y / 288f;
		}
		else if (this.FJPKMMJCQND.PELBNKEHOHF && MMLMNDPKIEC + base.GPONHFNLHCN.FOOEEHDJBQN().y / 1262f > this.FJPKMMJCQND.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = this.FJPKMMJCQND.MMHQFDMKQDQ - base.GPONHFNLHCN.PGKODNCDNJQ.y / 1287f;
		}
	}

	// Token: 0x06006E69 RID: 28265 RVA: 0x00028F2A File Offset: 0x0002712A
	public int BNJKJCBOFMH()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x06006E6A RID: 28266 RVA: 0x0035C9B8 File Offset: 0x0035ABB8
	private IEnumerator JIGBPQBLINE()
	{
		HILOLOEJJHF.OCCDHIMJDCD occdhimjdcd = new HILOLOEJJHF.OCCDHIMJDCD();
		occdhimjdcd.QNDQJMNKFNN = this;
		return occdhimjdcd;
	}

	// Token: 0x06006E6B RID: 28267 RVA: 0x0035C9D4 File Offset: 0x0035ABD4
	private void GDCKLMOHHHD(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC)
	{
		if (this.FJPKMMJCQND.QBHHBPBKQDJ && LHCLJCLFKFJ - base.GPONHFNLHCN.FOOEEHDJBQN().x / 1508f < this.FJPKMMJCQND.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = this.FJPKMMJCQND.DFFQECIDMDO + base.GPONHFNLHCN.FOOEEHDJBQN().x / 86f;
		}
		else if (this.FJPKMMJCQND.IGPBFPCKNOG && LHCLJCLFKFJ + base.GPONHFNLHCN.FOOEEHDJBQN().x / 1326f > this.FJPKMMJCQND.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = this.FJPKMMJCQND.JGJEPKHCBGP - base.GPONHFNLHCN.PGKODNCDNJQ.x / 48f;
		}
		if (this.FJPKMMJCQND.IKDQPKGPPEH && MMLMNDPKIEC - base.GPONHFNLHCN.PGKODNCDNJQ.y / 745f < this.FJPKMMJCQND.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = this.FJPKMMJCQND.BIPDHOPHDMK + base.GPONHFNLHCN.FOOEEHDJBQN().y / 441f;
		}
		else if (this.FJPKMMJCQND.PELBNKEHOHF && MMLMNDPKIEC + base.GPONHFNLHCN.FOOEEHDJBQN().y / 142f > this.FJPKMMJCQND.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = this.FJPKMMJCQND.MMHQFDMKQDQ - base.GPONHFNLHCN.FOOEEHDJBQN().y / 1423f;
		}
	}

	// Token: 0x06006E6C RID: 28268 RVA: 0x00028F32 File Offset: 0x00027132
	protected virtual void JENKEGOEEHO()
	{
		base.Awake();
		if (this.DMNHNQEGHIH)
		{
			this.HBQEPFLPLFO();
		}
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
		base.GPONHFNLHCN.NODLKQNBMFD(this);
	}

	// Token: 0x06006E6D RID: 28269 RVA: 0x00028F60 File Offset: 0x00027160
	public void HPMFKIBNMPO(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06006E6E RID: 28270 RVA: 0x00028F60 File Offset: 0x00027160
	public void ICPPJONFDFG(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06006E6F RID: 28271 RVA: 0x0035CB60 File Offset: 0x0035AD60
	public void MLOIHHQMFBN()
	{
		if (this.OLCQHNBDFPL)
		{
			return;
		}
		this.LJIMCJFLQEL = false;
		if (this.QCCCBBFNKDB.Count == 0)
		{
			UnityEngine.Debug.LogWarning("No cinematic targets added to the list");
			return;
		}
		this.KOBBHQJNMDL = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		if (this.FJPKMMJCQND == null)
		{
			this.FJPKMMJCQND = base.GPONHFNLHCN.GetComponentInChildren<MDFGNNIKFEP>();
		}
		if (this.FJPKMMJCQND == null)
		{
			this.FJPKMMJCQND = UnityEngine.Object.FindObjectOfType<MDFGNNIKFEP>();
		}
		if (this.FJPKMMJCQND == null)
		{
			this.GICJLBDMMEQ = false;
		}
		else
		{
			this.CBQFQIIBNNC = this.FJPKMMJCQND.enabled;
			this.FJPKMMJCQND.enabled = false;
		}
		this.OLCQHNBDFPL = true;
		if (this.CGOFQJEEOEQ != null)
		{
			base.StopCoroutine(this.CGOFQJEEOEQ);
			this.CGOFQJEEOEQ = null;
		}
		if (this.MQGDBOOBKMN == null)
		{
			this.MQGDBOOBKMN = base.StartCoroutine(this.IBGCFDJHBMM());
		}
	}

	// Token: 0x06006E70 RID: 28272 RVA: 0x0035CC5C File Offset: 0x0035AE5C
	public void GCBBJNPKHPQ()
	{
		if (this.OLCQHNBDFPL)
		{
			return;
		}
		this.LJIMCJFLQEL = false;
		if (this.QCCCBBFNKDB.Count == 0)
		{
			UnityEngine.Debug.LogWarning(" was prevented from healing!\r\n");
			return;
		}
		this.KOBBHQJNMDL = base.GPONHFNLHCN.PGKODNCDNJQ.y * 450f;
		if (this.FJPKMMJCQND == null)
		{
			this.FJPKMMJCQND = base.GPONHFNLHCN.GetComponentInChildren<MDFGNNIKFEP>();
		}
		if (this.FJPKMMJCQND == null)
		{
			this.FJPKMMJCQND = UnityEngine.Object.FindObjectOfType<MDFGNNIKFEP>();
		}
		if (this.FJPKMMJCQND == null)
		{
			this.GICJLBDMMEQ = true;
		}
		else
		{
			this.CBQFQIIBNNC = this.FJPKMMJCQND.enabled;
			this.FJPKMMJCQND.enabled = true;
		}
		this.OLCQHNBDFPL = true;
		if (this.CGOFQJEEOEQ != null)
		{
			base.StopCoroutine(this.CGOFQJEEOEQ);
			this.CGOFQJEEOEQ = null;
		}
		if (this.MQGDBOOBKMN == null)
		{
			this.MQGDBOOBKMN = base.StartCoroutine(this.IBGCFDJHBMM());
		}
	}

	// Token: 0x06006E71 RID: 28273 RVA: 0x0035CD58 File Offset: 0x0035AF58
	public void JQFHQGNPMOQ()
	{
		if (!this.OLCQHNBDFPL)
		{
			return;
		}
		if (this.MQGDBOOBKMN != null)
		{
			base.StopCoroutine(this.MQGDBOOBKMN);
			this.MQGDBOOBKMN = null;
		}
		if (this.FEBBHCJQPDM != null)
		{
			base.StopCoroutine(this.FEBBHCJQPDM);
			this.FEBBHCJQPDM = null;
		}
		if (this.CGOFQJEEOEQ == null)
		{
			this.CGOFQJEEOEQ = base.StartCoroutine(this.CJCGOFJEFPP());
		}
	}

	// Token: 0x06006E72 RID: 28274 RVA: 0x0035CDC0 File Offset: 0x0035AFC0
	private void EQBEEIOIOKE()
	{
		DPIOOKQMQIE componentInChildren = base.GPONHFNLHCN.gameObject.GetComponentInChildren<DPIOOKQMQIE>();
		if (componentInChildren == null)
		{
			Camera[] array = base.GPONHFNLHCN.gameObject.GetComponentsInChildren<Camera>();
			IEnumerable<Camera> source = array;
			if (HILOLOEJJHF.HNCJFHJNHDN == null)
			{
				HILOLOEJJHF.HNCJFHJNHDN = new Func<Camera, float>(HILOLOEJJHF.JDOLBMCEBQE);
			}
			array = source.OrderByDescending(HILOLOEJJHF.HNCJFHJNHDN).ToArray<Camera>();
			array[0].gameObject.AddComponent<DPIOOKQMQIE>();
		}
		this.EEOJHEKGQDD = componentInChildren;
	}

	// Token: 0x06006E73 RID: 28275 RVA: 0x00028EE5 File Offset: 0x000270E5
	public void CPGQBLGKQPG()
	{
		this.LJIMCJFLQEL = true;
	}

	// Token: 0x06006E74 RID: 28276 RVA: 0x00028F69 File Offset: 0x00027169
	protected override void Awake()
	{
		base.Awake();
		if (this.DMNHNQEGHIH)
		{
			this.HBQEPFLPLFO();
		}
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x06006E75 RID: 28277 RVA: 0x00028F97 File Offset: 0x00027197
	public void OKMIFJCKOIF(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x06006E76 RID: 28278 RVA: 0x0035CE38 File Offset: 0x0035B038
	private void OMLLCJNIHBG(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC)
	{
		if (this.FJPKMMJCQND.QBHHBPBKQDJ && LHCLJCLFKFJ - base.GPONHFNLHCN.PGKODNCDNJQ.x / 2f < this.FJPKMMJCQND.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = this.FJPKMMJCQND.DFFQECIDMDO + base.GPONHFNLHCN.PGKODNCDNJQ.x / 2f;
		}
		else if (this.FJPKMMJCQND.IGPBFPCKNOG && LHCLJCLFKFJ + base.GPONHFNLHCN.PGKODNCDNJQ.x / 2f > this.FJPKMMJCQND.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = this.FJPKMMJCQND.JGJEPKHCBGP - base.GPONHFNLHCN.PGKODNCDNJQ.x / 2f;
		}
		if (this.FJPKMMJCQND.IKDQPKGPPEH && MMLMNDPKIEC - base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f < this.FJPKMMJCQND.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = this.FJPKMMJCQND.BIPDHOPHDMK + base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f;
		}
		else if (this.FJPKMMJCQND.PELBNKEHOHF && MMLMNDPKIEC + base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f > this.FJPKMMJCQND.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = this.FJPKMMJCQND.MMHQFDMKQDQ - base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f;
		}
	}

	// Token: 0x06006E77 RID: 28279 RVA: 0x00028EBD File Offset: 0x000270BD
	protected virtual void FBOOPIKPEQB()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x06006E78 RID: 28280 RVA: 0x00028F97 File Offset: 0x00027197
	public void CGJKLKBDFLK(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x06006E79 RID: 28281 RVA: 0x0035CFC4 File Offset: 0x0035B1C4
	public void MOEPJDNPKEQ(Transform OGEFDMHQCDB)
	{
		for (int i = 1; i < this.QCCCBBFNKDB.Count; i += 0)
		{
			if (this.QCCCBBFNKDB[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				this.QCCCBBFNKDB.Remove(this.QCCCBBFNKDB[i]);
			}
		}
	}

	// Token: 0x170003CF RID: 975
	// (get) Token: 0x06006E87 RID: 28295 RVA: 0x00028F2A File Offset: 0x0002712A
	// (set) Token: 0x06006E7A RID: 28282 RVA: 0x00028F97 File Offset: 0x00027197
	public int IDIPKDLCMCK
	{
		get
		{
			return this.HNMJQQFFBCL;
		}
		set
		{
			this.HNMJQQFFBCL = value;
		}
	}

	// Token: 0x06006E7B RID: 28283 RVA: 0x00028FA0 File Offset: 0x000271A0
	public float LCHPMFFIFLL(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (!base.enabled)
		{
			return GNBLMJIGCOD;
		}
		if (this.OLCQHNBDFPL)
		{
			return this.FHBCMICBNCE;
		}
		return GNBLMJIGCOD;
	}

	// Token: 0x06006E7C RID: 28284 RVA: 0x00028F2A File Offset: 0x0002712A
	public int GJGKDQIJDHI()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x06006E7D RID: 28285 RVA: 0x00028FBC File Offset: 0x000271BC
	public void NDOGEMQJOJF()
	{
		if (this.OLCQHNBDFPL)
		{
			this.JQFHQGNPMOQ();
		}
		else
		{
			this.MLOIHHQMFBN();
		}
	}

	// Token: 0x06006E7E RID: 28286 RVA: 0x0035D020 File Offset: 0x0035B220
	public void GOIECHNDMLK(Transform OGEFDMHQCDB, float MBHEPKFGLIQ = 1f, float BLPKINKMKCE = 1f, float FEFONHNOCKM = 1f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseOut, string LFMJQJHEKJE = "", string BMGGIHJGKBM = "", int IIHDGMLHICI = -1)
	{
		CinematicTarget item = new CinematicTarget
		{
			TargetTransform = OGEFDMHQCDB,
			EaseInDuration = MBHEPKFGLIQ,
			HoldDuration = BLPKINKMKCE,
			Zoom = FEFONHNOCKM,
			EaseType = IBMMEEDBIJB,
			SendMessageName = LFMJQJHEKJE,
			SendMessageParam = BMGGIHJGKBM
		};
		if (IIHDGMLHICI != -1 && IIHDGMLHICI <= this.QCCCBBFNKDB.Count)
		{
			this.QCCCBBFNKDB.Insert(IIHDGMLHICI, item);
		}
		else
		{
			this.QCCCBBFNKDB.Add(item);
		}
	}

	// Token: 0x06006E7F RID: 28287 RVA: 0x0035D09C File Offset: 0x0035B29C
	private void HBQEPFLPLFO()
	{
		DPIOOKQMQIE componentInChildren = base.GPONHFNLHCN.gameObject.GetComponentInChildren<DPIOOKQMQIE>();
		if (componentInChildren == null)
		{
			Camera[] array = base.GPONHFNLHCN.gameObject.GetComponentsInChildren<Camera>();
			IEnumerable<Camera> source = array;
			if (HILOLOEJJHF.HNCJFHJNHDN == null)
			{
				HILOLOEJJHF.HNCJFHJNHDN = new Func<Camera, float>(HILOLOEJJHF.BNEIKICJDEQ);
			}
			array = source.OrderByDescending(HILOLOEJJHF.HNCJFHJNHDN).ToArray<Camera>();
			array[0].gameObject.AddComponent<DPIOOKQMQIE>();
		}
		this.EEOJHEKGQDD = componentInChildren;
	}

	// Token: 0x06006E80 RID: 28288 RVA: 0x00028EBD File Offset: 0x000270BD
	protected virtual void MOPBKMJFKHF()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x06006E81 RID: 28289 RVA: 0x0035D114 File Offset: 0x0035B314
	private void DLDCHLKJDHB(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC)
	{
		if (this.FJPKMMJCQND.QBHHBPBKQDJ && LHCLJCLFKFJ - base.GPONHFNLHCN.PGKODNCDNJQ.x / 1693f < this.FJPKMMJCQND.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = this.FJPKMMJCQND.DFFQECIDMDO + base.GPONHFNLHCN.FOOEEHDJBQN().x / 1941f;
		}
		else if (this.FJPKMMJCQND.IGPBFPCKNOG && LHCLJCLFKFJ + base.GPONHFNLHCN.PGKODNCDNJQ.x / 1934f > this.FJPKMMJCQND.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = this.FJPKMMJCQND.JGJEPKHCBGP - base.GPONHFNLHCN.FOOEEHDJBQN().x / 294f;
		}
		if (this.FJPKMMJCQND.IKDQPKGPPEH && MMLMNDPKIEC - base.GPONHFNLHCN.PGKODNCDNJQ.y / 41f < this.FJPKMMJCQND.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = this.FJPKMMJCQND.BIPDHOPHDMK + base.GPONHFNLHCN.FOOEEHDJBQN().y / 848f;
		}
		else if (this.FJPKMMJCQND.PELBNKEHOHF && MMLMNDPKIEC + base.GPONHFNLHCN.FOOEEHDJBQN().y / 529f > this.FJPKMMJCQND.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = this.FJPKMMJCQND.MMHQFDMKQDQ - base.GPONHFNLHCN.FOOEEHDJBQN().y / 848f;
		}
	}

	// Token: 0x06006E82 RID: 28290 RVA: 0x0035D020 File Offset: 0x0035B220
	public void EFPIBDIDOFJ(Transform OGEFDMHQCDB, float MBHEPKFGLIQ = 1f, float BLPKINKMKCE = 1f, float FEFONHNOCKM = 1f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseOut, string LFMJQJHEKJE = "", string BMGGIHJGKBM = "", int IIHDGMLHICI = -1)
	{
		CinematicTarget item = new CinematicTarget
		{
			TargetTransform = OGEFDMHQCDB,
			EaseInDuration = MBHEPKFGLIQ,
			HoldDuration = BLPKINKMKCE,
			Zoom = FEFONHNOCKM,
			EaseType = IBMMEEDBIJB,
			SendMessageName = LFMJQJHEKJE,
			SendMessageParam = BMGGIHJGKBM
		};
		if (IIHDGMLHICI != -1 && IIHDGMLHICI <= this.QCCCBBFNKDB.Count)
		{
			this.QCCCBBFNKDB.Insert(IIHDGMLHICI, item);
		}
		else
		{
			this.QCCCBBFNKDB.Add(item);
		}
	}

	// Token: 0x06006E83 RID: 28291 RVA: 0x00028FA0 File Offset: 0x000271A0
	public float OPQBCQPOHPP(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (!base.enabled)
		{
			return GNBLMJIGCOD;
		}
		if (this.OLCQHNBDFPL)
		{
			return this.FHBCMICBNCE;
		}
		return GNBLMJIGCOD;
	}

	// Token: 0x06006E84 RID: 28292 RVA: 0x00028FD4 File Offset: 0x000271D4
	public void BDLEQLPDLPB()
	{
		this.MDMDOJLGCLE = true;
	}

	// Token: 0x06006E85 RID: 28293 RVA: 0x00028F60 File Offset: 0x00027160
	public void ILNJDKOCQGC(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06006E86 RID: 28294 RVA: 0x00028EDD File Offset: 0x000270DD
	private static float JDOLBMCEBQE(Camera KQFEHQEBJQB)
	{
		return KQFEHQEBJQB.depth;
	}

	// Token: 0x06006E88 RID: 28296 RVA: 0x0035CD58 File Offset: 0x0035AF58
	public void Stop()
	{
		if (!this.OLCQHNBDFPL)
		{
			return;
		}
		if (this.MQGDBOOBKMN != null)
		{
			base.StopCoroutine(this.MQGDBOOBKMN);
			this.MQGDBOOBKMN = null;
		}
		if (this.FEBBHCJQPDM != null)
		{
			base.StopCoroutine(this.FEBBHCJQPDM);
			this.FEBBHCJQPDM = null;
		}
		if (this.CGOFQJEEOEQ == null)
		{
			this.CGOFQJEEOEQ = base.StartCoroutine(this.CJCGOFJEFPP());
		}
	}

	// Token: 0x06006E89 RID: 28297 RVA: 0x0035C9B8 File Offset: 0x0035ABB8
	[DebuggerHidden]
	private IEnumerator CJCGOFJEFPP()
	{
		HILOLOEJJHF.OCCDHIMJDCD occdhimjdcd = new HILOLOEJJHF.OCCDHIMJDCD();
		occdhimjdcd.QNDQJMNKFNN = this;
		return occdhimjdcd;
	}

	// Token: 0x06006E8A RID: 28298 RVA: 0x0035D2A0 File Offset: 0x0035B4A0
	public void OCIHQGFELOH(Transform OGEFDMHQCDB)
	{
		for (int i = 0; i < this.QCCCBBFNKDB.Count; i++)
		{
			if (this.QCCCBBFNKDB[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				this.QCCCBBFNKDB.Remove(this.QCCCBBFNKDB[i]);
			}
		}
	}

	// Token: 0x06006E8B RID: 28299 RVA: 0x00028FDD File Offset: 0x000271DD
	public void JQFBBLKNFQM()
	{
		if (this.OLCQHNBDFPL)
		{
			this.Stop();
		}
		else
		{
			this.MLOIHHQMFBN();
		}
	}

	// Token: 0x06006E8D RID: 28301 RVA: 0x00028EDD File Offset: 0x000270DD
	private static float OCCKHBPBEPO(Camera KQFEHQEBJQB)
	{
		return KQFEHQEBJQB.depth;
	}

	// Token: 0x06006E8E RID: 28302 RVA: 0x00028F97 File Offset: 0x00027197
	public void QGOFKBMJEII(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x06006E90 RID: 28304 RVA: 0x0035D360 File Offset: 0x0035B560
	private IEnumerator MCMJGLEHDLK(CinematicTarget FEEDPIICCFO, int HILBCDNPBFD)
	{
		HILOLOEJJHF.INEJFJCPFLP inejfjcpflp = new HILOLOEJJHF.INEJFJCPFLP();
		inejfjcpflp.FEEDPIICCFO = FEEDPIICCFO;
		inejfjcpflp.HILBCDNPBFD = HILBCDNPBFD;
		inejfjcpflp.QNDQJMNKFNN = this;
		return inejfjcpflp;
	}

	// Token: 0x06006E91 RID: 28305 RVA: 0x0035D020 File Offset: 0x0035B220
	public void QDMDPHEGMLJ(Transform OGEFDMHQCDB, float MBHEPKFGLIQ = 1f, float BLPKINKMKCE = 1f, float FEFONHNOCKM = 1f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseOut, string LFMJQJHEKJE = "", string BMGGIHJGKBM = "", int IIHDGMLHICI = -1)
	{
		CinematicTarget item = new CinematicTarget
		{
			TargetTransform = OGEFDMHQCDB,
			EaseInDuration = MBHEPKFGLIQ,
			HoldDuration = BLPKINKMKCE,
			Zoom = FEFONHNOCKM,
			EaseType = IBMMEEDBIJB,
			SendMessageName = LFMJQJHEKJE,
			SendMessageParam = BMGGIHJGKBM
		};
		if (IIHDGMLHICI != -1 && IIHDGMLHICI <= this.QCCCBBFNKDB.Count)
		{
			this.QCCCBBFNKDB.Insert(IIHDGMLHICI, item);
		}
		else
		{
			this.QCCCBBFNKDB.Add(item);
		}
	}

	// Token: 0x06006E92 RID: 28306 RVA: 0x0035D38C File Offset: 0x0035B58C
	public void HFDQJQGEEJK()
	{
		if (!this.OLCQHNBDFPL)
		{
			return;
		}
		if (this.MQGDBOOBKMN != null)
		{
			base.StopCoroutine(this.MQGDBOOBKMN);
			this.MQGDBOOBKMN = null;
		}
		if (this.FEBBHCJQPDM != null)
		{
			base.StopCoroutine(this.FEBBHCJQPDM);
			this.FEBBHCJQPDM = null;
		}
		if (this.CGOFQJEEOEQ == null)
		{
			this.CGOFQJEEOEQ = base.StartCoroutine(this.JIGBPQBLINE());
		}
	}

	// Token: 0x06006E93 RID: 28307 RVA: 0x00028EEE File Offset: 0x000270EE
	public Vector3 NJEMOPHIJPG(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		this.LIOOHIQIMFK = PJKPLOCIBHP;
		if (this.OLCQHNBDFPL)
		{
			return this.NHCKFQMGIJD;
		}
		return PJKPLOCIBHP;
	}

	// Token: 0x06006E94 RID: 28308 RVA: 0x00028EEE File Offset: 0x000270EE
	public Vector3 DDMMHIKGLGQ(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		this.LIOOHIQIMFK = PJKPLOCIBHP;
		if (this.OLCQHNBDFPL)
		{
			return this.NHCKFQMGIJD;
		}
		return PJKPLOCIBHP;
	}

	// Token: 0x06006E95 RID: 28309 RVA: 0x0035C7D0 File Offset: 0x0035A9D0
	public void KMCJMECOIJN(Transform OGEFDMHQCDB)
	{
		for (int i = 1; i < this.QCCCBBFNKDB.Count; i++)
		{
			if (this.QCCCBBFNKDB[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				this.QCCCBBFNKDB.Remove(this.QCCCBBFNKDB[i]);
			}
		}
	}

	// Token: 0x06006E96 RID: 28310 RVA: 0x0035D360 File Offset: 0x0035B560
	private IEnumerator HMJILGFNDGI(CinematicTarget FEEDPIICCFO, int HILBCDNPBFD)
	{
		HILOLOEJJHF.INEJFJCPFLP inejfjcpflp = new HILOLOEJJHF.INEJFJCPFLP();
		inejfjcpflp.FEEDPIICCFO = FEEDPIICCFO;
		inejfjcpflp.HILBCDNPBFD = HILBCDNPBFD;
		inejfjcpflp.QNDQJMNKFNN = this;
		return inejfjcpflp;
	}

	// Token: 0x06006E97 RID: 28311 RVA: 0x0035D3F4 File Offset: 0x0035B5F4
	[DebuggerHidden]
	private IEnumerator IBGCFDJHBMM()
	{
		HILOLOEJJHF.EJMHLOCMJKQ ejmhlocmjkq = new HILOLOEJJHF.EJMHLOCMJKQ();
		ejmhlocmjkq.QNDQJMNKFNN = this;
		return ejmhlocmjkq;
	}

	// Token: 0x06006E98 RID: 28312 RVA: 0x0035D360 File Offset: 0x0035B560
	[DebuggerHidden]
	private IEnumerator NGHHLBHIDIB(CinematicTarget FEEDPIICCFO, int HILBCDNPBFD)
	{
		HILOLOEJJHF.INEJFJCPFLP inejfjcpflp = new HILOLOEJJHF.INEJFJCPFLP();
		inejfjcpflp.FEEDPIICCFO = FEEDPIICCFO;
		inejfjcpflp.HILBCDNPBFD = HILBCDNPBFD;
		inejfjcpflp.QNDQJMNKFNN = this;
		return inejfjcpflp;
	}

	// Token: 0x06006E99 RID: 28313 RVA: 0x0035D020 File Offset: 0x0035B220
	public void EIJFBPIHJNL(Transform OGEFDMHQCDB, float MBHEPKFGLIQ = 1f, float BLPKINKMKCE = 1f, float FEFONHNOCKM = 1f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseOut, string LFMJQJHEKJE = "", string BMGGIHJGKBM = "", int IIHDGMLHICI = -1)
	{
		CinematicTarget item = new CinematicTarget
		{
			TargetTransform = OGEFDMHQCDB,
			EaseInDuration = MBHEPKFGLIQ,
			HoldDuration = BLPKINKMKCE,
			Zoom = FEFONHNOCKM,
			EaseType = IBMMEEDBIJB,
			SendMessageName = LFMJQJHEKJE,
			SendMessageParam = BMGGIHJGKBM
		};
		if (IIHDGMLHICI != -1 && IIHDGMLHICI <= this.QCCCBBFNKDB.Count)
		{
			this.QCCCBBFNKDB.Insert(IIHDGMLHICI, item);
		}
		else
		{
			this.QCCCBBFNKDB.Add(item);
		}
	}

	// Token: 0x06006E9A RID: 28314 RVA: 0x00028F60 File Offset: 0x00027160
	public void OGLCNFOENKO(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06006E9B RID: 28315 RVA: 0x00028EDD File Offset: 0x000270DD
	private static float QKPFDIEEFIO(Camera KQFEHQEBJQB)
	{
		return KQFEHQEBJQB.depth;
	}

	// Token: 0x06006E9C RID: 28316 RVA: 0x00028F21 File Offset: 0x00027121
	public void EJBEJPGJLKJ()
	{
		this.LJIMCJFLQEL = false;
	}

	// Token: 0x06006E9E RID: 28318 RVA: 0x00028F69 File Offset: 0x00027169
	protected virtual void NGDJNKQELNO()
	{
		base.Awake();
		if (this.DMNHNQEGHIH)
		{
			this.HBQEPFLPLFO();
		}
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x06006E9F RID: 28319 RVA: 0x0035D360 File Offset: 0x0035B560
	private IEnumerator DDPHCIMFNBB(CinematicTarget FEEDPIICCFO, int HILBCDNPBFD)
	{
		HILOLOEJJHF.INEJFJCPFLP inejfjcpflp = new HILOLOEJJHF.INEJFJCPFLP();
		inejfjcpflp.FEEDPIICCFO = FEEDPIICCFO;
		inejfjcpflp.HILBCDNPBFD = HILBCDNPBFD;
		inejfjcpflp.QNDQJMNKFNN = this;
		return inejfjcpflp;
	}

	// Token: 0x0400178D RID: 6029
	public static string OPGNGFNJDDP = "Cinematics";

	// Token: 0x0400178E RID: 6030
	public UnityEvent GGBJKFLEFEO;

	// Token: 0x0400178F RID: 6031
	public CinematicEvent QMMKHNNGPFI;

	// Token: 0x04001790 RID: 6032
	public UnityEvent QCHOMBLFIJN;

	// Token: 0x04001791 RID: 6033
	private bool OLCQHNBDFPL;

	// Token: 0x04001792 RID: 6034
	public List<CinematicTarget> QCCCBBFNKDB = new List<CinematicTarget>();

	// Token: 0x04001793 RID: 6035
	public float FFPNBDNOIBM = 1f;

	// Token: 0x04001794 RID: 6036
	public GMNJJQQPEDB JQGENHKIBOF = GMNJJQQPEDB.EaseOut;

	// Token: 0x04001795 RID: 6037
	public bool GICJLBDMMEQ;

	// Token: 0x04001796 RID: 6038
	public bool DMNHNQEGHIH = true;

	// Token: 0x04001797 RID: 6039
	[Range(0f, 0.5f)]
	public float FECQQKCFMLK = 0.1f;

	// Token: 0x04001798 RID: 6040
	public float LJQMCFGBQEG = 1f;

	// Token: 0x04001799 RID: 6041
	public Color FPNMLCMOOBM = Color.black;

	// Token: 0x0400179A RID: 6042
	private float KOBBHQJNMDL;

	// Token: 0x0400179B RID: 6043
	private MDFGNNIKFEP FJPKMMJCQND;

	// Token: 0x0400179C RID: 6044
	private bool CBQFQIIBNNC;

	// Token: 0x0400179D RID: 6045
	private DPIOOKQMQIE EEOJHEKGQDD;

	// Token: 0x0400179E RID: 6046
	private Coroutine MQGDBOOBKMN;

	// Token: 0x0400179F RID: 6047
	private Coroutine FEBBHCJQPDM;

	// Token: 0x040017A0 RID: 6048
	private Coroutine CGOFQJEEOEQ;

	// Token: 0x040017A1 RID: 6049
	private bool MDMDOJLGCLE;

	// Token: 0x040017A2 RID: 6050
	private Vector3 NHCKFQMGIJD;

	// Token: 0x040017A3 RID: 6051
	private Vector3 LIOOHIQIMFK;

	// Token: 0x040017A4 RID: 6052
	private Vector3 EPMHQHOHJQC;

	// Token: 0x040017A5 RID: 6053
	private float FHBCMICBNCE;

	// Token: 0x040017A6 RID: 6054
	private bool LJIMCJFLQEL;

	// Token: 0x040017A7 RID: 6055
	private int HNMJQQFFBCL;

	// Token: 0x040017A8 RID: 6056
	private int GKLLDJLQPMM = 3000;

	// Token: 0x040017A9 RID: 6057
	[CompilerGenerated]
	private static Func<Camera, float> HNCJFHJNHDN;
}
