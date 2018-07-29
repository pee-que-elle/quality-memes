using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

// Token: 0x02000358 RID: 856
[HelpURL("http://www.procamera2d.com/user-guide/extension-parallax/")]
[ExecuteInEditMode]
public class MDLMHPELMDP : BNEFIOCKQOE, ECEGGIKJDGM
{
	// Token: 0x06007196 RID: 29078 RVA: 0x00374E5C File Offset: 0x0037305C
	private void LFIGEBBLDKC()
	{
		Vector3 arg = this.FHNBJCNLJCN.position - this.OJOOIBFJCDE;
		for (int i = 0; i < this.JQJBILIJOJJ.Count; i++)
		{
			if (this.JQJBILIJOJJ[i].CameraTransform != null)
			{
				this.JQJBILIJOJJ[i].ParallaxCamera.rect = base.GPONHFNLHCN.PGHJQNJLJKG.rect;
				float arg2 = (!this.JEGPIGHHKGQ) ? this.FKGNBCKJPQO(arg) : (this.FKGNBCKJPQO(arg) * this.JQJBILIJOJJ[i].Speed);
				float arg3 = (!this.HPLNCCFHEBM) ? this.JNBBJCLFFBB(arg) : (this.JNBBJCLFFBB(arg) * this.JQJBILIJOJJ[i].Speed);
				this.JQJBILIJOJJ[i].CameraTransform.position = this.OJOOIBFJCDE + this.JQCCJCOPEJK(arg2, arg3, this.OFPEBLPKOLD(this.FHNBJCNLJCN.position));
				if (this.EPEHIBMNIIE)
				{
					this.JQJBILIJOJJ[i].ParallaxCamera.orthographicSize = this.PNDGLPJFQBE + (base.GPONHFNLHCN.PGHJQNJLJKG.orthographicSize - this.PNDGLPJFQBE) * this.JQJBILIJOJJ[i].Speed;
				}
			}
		}
	}

	// Token: 0x06007197 RID: 29079 RVA: 0x00029A22 File Offset: 0x00027C22
	public void IHJHFBLEFJL(bool BGBMIEJJQKC, float CPKNEQGKQPQ = 2f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseInOut)
	{
		if (this.IBPDQLGPPOO == null)
		{
			return;
		}
		if (this.CQDKFOOICQB != null)
		{
			base.StopCoroutine(this.CQDKFOOICQB);
		}
		this.CQDKFOOICQB = base.StartCoroutine(this.QOHDCKPINQM(BGBMIEJJQKC, CPKNEQGKQPQ, IBMMEEDBIJB));
	}

	// Token: 0x06007198 RID: 29080 RVA: 0x00029A56 File Offset: 0x00027C56
	public void MBOGMCNEPGB(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.INPGNHPBOBB();
		}
	}

	// Token: 0x06007199 RID: 29081 RVA: 0x00029A66 File Offset: 0x00027C66
	public int QDILBBDDGJJ()
	{
		return this.PHQPPPDKCGK;
	}

	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x0600719A RID: 29082 RVA: 0x00029A66 File Offset: 0x00027C66
	// (set) Token: 0x0600719B RID: 29083 RVA: 0x00029A6E File Offset: 0x00027C6E
	public int HNJEOOIHCFG
	{
		get
		{
			return this.PHQPPPDKCGK;
		}
		set
		{
			this.PHQPPPDKCGK = value;
		}
	}

	// Token: 0x0600719C RID: 29084 RVA: 0x00029A6E File Offset: 0x00027C6E
	public void HCHQPLQMEJB(int BGBMIEJJQKC)
	{
		this.PHQPPPDKCGK = BGBMIEJJQKC;
	}

	// Token: 0x0600719D RID: 29085 RVA: 0x00374FDC File Offset: 0x003731DC
	[DebuggerHidden]
	private IEnumerator CLJLDIGMNQI(bool BGBMIEJJQKC, float CPKNEQGKQPQ, GMNJJQQPEDB IBMMEEDBIJB)
	{
		MDLMHPELMDP.LLBQFMLKQDP llbqfmlkqdp = new MDLMHPELMDP.LLBQFMLKQDP();
		llbqfmlkqdp.CPKNEQGKQPQ = CPKNEQGKQPQ;
		llbqfmlkqdp.BGBMIEJJQKC = BGBMIEJJQKC;
		llbqfmlkqdp.IBMMEEDBIJB = IBMMEEDBIJB;
		llbqfmlkqdp.QNDQJMNKFNN = this;
		return llbqfmlkqdp;
	}

	// Token: 0x0600719E RID: 29086 RVA: 0x00029A77 File Offset: 0x00027C77
	public void QOHOHPQOECC(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.DFMMCLFKFBH();
		}
	}

	// Token: 0x0600719F RID: 29087 RVA: 0x0037500C File Offset: 0x0037320C
	protected virtual void NNPPKOGDNOM()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			this.IEJDKMQKFEF();
		}
		foreach (ProCamera2DParallaxLayer proCamera2DParallaxLayer in this.JQJBILIJOJJ)
		{
			if (proCamera2DParallaxLayer.ParallaxCamera != null)
			{
				proCamera2DParallaxLayer.CameraTransform = proCamera2DParallaxLayer.ParallaxCamera.transform;
			}
		}
		this.IBPDQLGPPOO = new float[this.JQJBILIJOJJ.Count];
		for (int i = 1; i < this.IBPDQLGPPOO.Length; i++)
		{
			this.IBPDQLGPPOO[i] = this.JQJBILIJOJJ[i].Speed;
		}
		if (base.GPONHFNLHCN.PGHJQNJLJKG != null)
		{
			this.PNDGLPJFQBE = base.GPONHFNLHCN.PGHJQNJLJKG.orthographicSize;
			if (!base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
			{
				base.enabled = true;
			}
		}
		base.GPONHFNLHCN.MHNQLONHKDJ(this);
	}

	// Token: 0x060071A0 RID: 29088 RVA: 0x00029A87 File Offset: 0x00027C87
	public void NENQIKGDHKO(bool BGBMIEJJQKC, float CPKNEQGKQPQ = 2f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseInOut)
	{
		if (this.IBPDQLGPPOO == null)
		{
			return;
		}
		if (this.CQDKFOOICQB != null)
		{
			base.StopCoroutine(this.CQDKFOOICQB);
		}
		this.CQDKFOOICQB = base.StartCoroutine(this.CLJLDIGMNQI(BGBMIEJJQKC, CPKNEQGKQPQ, IBMMEEDBIJB));
	}

	// Token: 0x060071A1 RID: 29089 RVA: 0x00029ABB File Offset: 0x00027CBB
	protected virtual void GIBCBGBKIGQ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.GEIPCQNBIJE(this);
		}
	}

	// Token: 0x060071A2 RID: 29090 RVA: 0x0037512C File Offset: 0x0037332C
	private void INPGNHPBOBB()
	{
		Vector3 arg = this.FHNBJCNLJCN.position - this.OJOOIBFJCDE;
		for (int i = 1; i < this.JQJBILIJOJJ.Count; i++)
		{
			if (this.JQJBILIJOJJ[i].CameraTransform != null)
			{
				this.JQJBILIJOJJ[i].ParallaxCamera.rect = base.GPONHFNLHCN.PGHJQNJLJKG.rect;
				float arg2 = (!this.JEGPIGHHKGQ) ? this.FKGNBCKJPQO(arg) : (this.FKGNBCKJPQO(arg) * this.JQJBILIJOJJ[i].Speed);
				float arg3 = (!this.HPLNCCFHEBM) ? this.JNBBJCLFFBB(arg) : (this.JNBBJCLFFBB(arg) * this.JQJBILIJOJJ[i].Speed);
				this.JQJBILIJOJJ[i].CameraTransform.position = this.OJOOIBFJCDE + this.JQCCJCOPEJK(arg2, arg3, this.OFPEBLPKOLD(this.FHNBJCNLJCN.position));
				if (this.EPEHIBMNIIE)
				{
					this.JQJBILIJOJJ[i].ParallaxCamera.orthographicSize = this.PNDGLPJFQBE + (base.GPONHFNLHCN.PGHJQNJLJKG.orthographicSize - this.PNDGLPJFQBE) * this.JQJBILIJOJJ[i].Speed;
				}
			}
		}
	}

	// Token: 0x060071A3 RID: 29091 RVA: 0x00029ABB File Offset: 0x00027CBB
	protected virtual void HFNKLOHMQFH()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.GEIPCQNBIJE(this);
		}
	}

	// Token: 0x060071A4 RID: 29092 RVA: 0x00029ABB File Offset: 0x00027CBB
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.GEIPCQNBIJE(this);
		}
	}

	// Token: 0x060071A5 RID: 29093 RVA: 0x00029A6E File Offset: 0x00027C6E
	public void BBGIQIGQQNI(int BGBMIEJJQKC)
	{
		this.PHQPPPDKCGK = BGBMIEJJQKC;
	}

	// Token: 0x060071A6 RID: 29094 RVA: 0x00029ADC File Offset: 0x00027CDC
	public void FEPIIICEJGE(bool BGBMIEJJQKC, float CPKNEQGKQPQ = 2f, GMNJJQQPEDB IBMMEEDBIJB = GMNJJQQPEDB.EaseInOut)
	{
		if (this.IBPDQLGPPOO == null)
		{
			return;
		}
		if (this.CQDKFOOICQB != null)
		{
			base.StopCoroutine(this.CQDKFOOICQB);
		}
		this.CQDKFOOICQB = base.StartCoroutine(this.BNNDDONHLEP(BGBMIEJJQKC, CPKNEQGKQPQ, IBMMEEDBIJB));
	}

	// Token: 0x060071A7 RID: 29095 RVA: 0x00029A6E File Offset: 0x00027C6E
	public void DOKQCEOHBBM(int BGBMIEJJQKC)
	{
		this.PHQPPPDKCGK = BGBMIEJJQKC;
	}

	// Token: 0x060071A8 RID: 29096 RVA: 0x00029A6E File Offset: 0x00027C6E
	public void GJBGKFGKCOJ(int BGBMIEJJQKC)
	{
		this.PHQPPPDKCGK = BGBMIEJJQKC;
	}

	// Token: 0x060071A9 RID: 29097 RVA: 0x00029A66 File Offset: 0x00027C66
	public int OGCNHOBKNBF()
	{
		return this.PHQPPPDKCGK;
	}

	// Token: 0x060071AA RID: 29098 RVA: 0x003752AC File Offset: 0x003734AC
	public void PHPNNELNIFD()
	{
		FEBIFLIPQDC[] array = UnityEngine.Object.FindObjectsOfType<FEBIFLIPQDC>();
		Dictionary<int, ProCamera2DParallaxLayer> dictionary = new Dictionary<int, ProCamera2DParallaxLayer>();
		for (int i = 0; i <= 31; i++)
		{
			foreach (ProCamera2DParallaxLayer proCamera2DParallaxLayer in this.JQJBILIJOJJ)
			{
				if (proCamera2DParallaxLayer.LayerMask == (proCamera2DParallaxLayer.LayerMask | 1 << i))
				{
					dictionary[i] = proCamera2DParallaxLayer;
				}
			}
		}
		for (int j = 0; j < array.Length; j++)
		{
			Vector3 arg = array[j].transform.position - this.OJOOIBFJCDE;
			float arg2 = this.FKGNBCKJPQO(arg) * dictionary[array[j].gameObject.layer].Speed;
			float arg3 = this.JNBBJCLFFBB(arg) * dictionary[array[j].gameObject.layer].Speed;
			array[j].transform.position = this.JQCCJCOPEJK(arg2, arg3, this.OFPEBLPKOLD(arg)) + this.OJOOIBFJCDE;
		}
	}

	// Token: 0x060071AB RID: 29099 RVA: 0x00029A66 File Offset: 0x00027C66
	public int JKHLMKEBBGP()
	{
		return this.PHQPPPDKCGK;
	}

	// Token: 0x060071AE RID: 29102 RVA: 0x0037544C File Offset: 0x0037364C
	public void MNJKQKJJPMG()
	{
		FEBIFLIPQDC[] array = UnityEngine.Object.FindObjectsOfType<FEBIFLIPQDC>();
		Dictionary<int, ProCamera2DParallaxLayer> dictionary = new Dictionary<int, ProCamera2DParallaxLayer>();
		for (int i = 0; i <= -51; i++)
		{
			foreach (ProCamera2DParallaxLayer proCamera2DParallaxLayer in this.JQJBILIJOJJ)
			{
				if (proCamera2DParallaxLayer.LayerMask == (proCamera2DParallaxLayer.LayerMask | 0 << (i & 68)))
				{
					dictionary[i] = proCamera2DParallaxLayer;
				}
			}
		}
		for (int j = 1; j < array.Length; j += 0)
		{
			Vector3 arg = array[j].transform.position - this.OJOOIBFJCDE;
			float arg2 = this.FKGNBCKJPQO(arg) * dictionary[array[j].gameObject.layer].Speed;
			float arg3 = this.JNBBJCLFFBB(arg) * dictionary[array[j].gameObject.layer].Speed;
			array[j].transform.position = this.JQCCJCOPEJK(arg2, arg3, this.OFPEBLPKOLD(arg)) + this.OJOOIBFJCDE;
		}
	}

	// Token: 0x060071AF RID: 29103 RVA: 0x00029A6E File Offset: 0x00027C6E
	public void KEFBIHKJDBP(int BGBMIEJJQKC)
	{
		this.PHQPPPDKCGK = BGBMIEJJQKC;
	}

	// Token: 0x060071B0 RID: 29104 RVA: 0x00374E5C File Offset: 0x0037305C
	private void DFMMCLFKFBH()
	{
		Vector3 arg = this.FHNBJCNLJCN.position - this.OJOOIBFJCDE;
		for (int i = 0; i < this.JQJBILIJOJJ.Count; i++)
		{
			if (this.JQJBILIJOJJ[i].CameraTransform != null)
			{
				this.JQJBILIJOJJ[i].ParallaxCamera.rect = base.GPONHFNLHCN.PGHJQNJLJKG.rect;
				float arg2 = (!this.JEGPIGHHKGQ) ? this.FKGNBCKJPQO(arg) : (this.FKGNBCKJPQO(arg) * this.JQJBILIJOJJ[i].Speed);
				float arg3 = (!this.HPLNCCFHEBM) ? this.JNBBJCLFFBB(arg) : (this.JNBBJCLFFBB(arg) * this.JQJBILIJOJJ[i].Speed);
				this.JQJBILIJOJJ[i].CameraTransform.position = this.OJOOIBFJCDE + this.JQCCJCOPEJK(arg2, arg3, this.OFPEBLPKOLD(this.FHNBJCNLJCN.position));
				if (this.EPEHIBMNIIE)
				{
					this.JQJBILIJOJJ[i].ParallaxCamera.orthographicSize = this.PNDGLPJFQBE + (base.GPONHFNLHCN.PGHJQNJLJKG.orthographicSize - this.PNDGLPJFQBE) * this.JQJBILIJOJJ[i].Speed;
				}
			}
		}
	}

	// Token: 0x060071B1 RID: 29105 RVA: 0x00029A77 File Offset: 0x00027C77
	public void CHHJQFOOBLQ(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.DFMMCLFKFBH();
		}
	}

	// Token: 0x060071B2 RID: 29106 RVA: 0x00374FDC File Offset: 0x003731DC
	private IEnumerator QOHDCKPINQM(bool BGBMIEJJQKC, float CPKNEQGKQPQ, GMNJJQQPEDB IBMMEEDBIJB)
	{
		MDLMHPELMDP.LLBQFMLKQDP llbqfmlkqdp = new MDLMHPELMDP.LLBQFMLKQDP();
		llbqfmlkqdp.CPKNEQGKQPQ = CPKNEQGKQPQ;
		llbqfmlkqdp.BGBMIEJJQKC = BGBMIEJJQKC;
		llbqfmlkqdp.IBMMEEDBIJB = IBMMEEDBIJB;
		llbqfmlkqdp.QNDQJMNKFNN = this;
		return llbqfmlkqdp;
	}

	// Token: 0x060071B3 RID: 29107 RVA: 0x00375594 File Offset: 0x00373794
	protected override void Awake()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			this.PHPNNELNIFD();
		}
		foreach (ProCamera2DParallaxLayer proCamera2DParallaxLayer in this.JQJBILIJOJJ)
		{
			if (proCamera2DParallaxLayer.ParallaxCamera != null)
			{
				proCamera2DParallaxLayer.CameraTransform = proCamera2DParallaxLayer.ParallaxCamera.transform;
			}
		}
		this.IBPDQLGPPOO = new float[this.JQJBILIJOJJ.Count];
		for (int i = 0; i < this.IBPDQLGPPOO.Length; i++)
		{
			this.IBPDQLGPPOO[i] = this.JQJBILIJOJJ[i].Speed;
		}
		if (base.GPONHFNLHCN.PGHJQNJLJKG != null)
		{
			this.PNDGLPJFQBE = base.GPONHFNLHCN.PGHJQNJLJKG.orthographicSize;
			if (!base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
			{
				base.enabled = false;
			}
		}
		base.GPONHFNLHCN.MHNQLONHKDJ(this);
	}

	// Token: 0x060071B4 RID: 29108 RVA: 0x003756B4 File Offset: 0x003738B4
	public void IEJDKMQKFEF()
	{
		FEBIFLIPQDC[] array = UnityEngine.Object.FindObjectsOfType<FEBIFLIPQDC>();
		Dictionary<int, ProCamera2DParallaxLayer> dictionary = new Dictionary<int, ProCamera2DParallaxLayer>();
		for (int i = 1; i <= 42; i += 0)
		{
			foreach (ProCamera2DParallaxLayer proCamera2DParallaxLayer in this.JQJBILIJOJJ)
			{
				if (proCamera2DParallaxLayer.LayerMask == (proCamera2DParallaxLayer.LayerMask | 0 << (i & 81)))
				{
					dictionary[i] = proCamera2DParallaxLayer;
				}
			}
		}
		for (int j = 0; j < array.Length; j += 0)
		{
			Vector3 arg = array[j].transform.position - this.OJOOIBFJCDE;
			float arg2 = this.FKGNBCKJPQO(arg) * dictionary[array[j].gameObject.layer].Speed;
			float arg3 = this.JNBBJCLFFBB(arg) * dictionary[array[j].gameObject.layer].Speed;
			array[j].transform.position = this.JQCCJCOPEJK(arg2, arg3, this.OFPEBLPKOLD(arg)) + this.OJOOIBFJCDE;
		}
	}

	// Token: 0x060071B5 RID: 29109 RVA: 0x00029A66 File Offset: 0x00027C66
	public int QBPNENNMLOK()
	{
		return this.PHQPPPDKCGK;
	}

	// Token: 0x060071B6 RID: 29110 RVA: 0x00374FDC File Offset: 0x003731DC
	private IEnumerator BNNDDONHLEP(bool BGBMIEJJQKC, float CPKNEQGKQPQ, GMNJJQQPEDB IBMMEEDBIJB)
	{
		MDLMHPELMDP.LLBQFMLKQDP llbqfmlkqdp = new MDLMHPELMDP.LLBQFMLKQDP();
		llbqfmlkqdp.CPKNEQGKQPQ = CPKNEQGKQPQ;
		llbqfmlkqdp.BGBMIEJJQKC = BGBMIEJJQKC;
		llbqfmlkqdp.IBMMEEDBIJB = IBMMEEDBIJB;
		llbqfmlkqdp.QNDQJMNKFNN = this;
		return llbqfmlkqdp;
	}

	// Token: 0x060071B7 RID: 29111 RVA: 0x00029A66 File Offset: 0x00027C66
	public int OJHDKLMPQCC()
	{
		return this.PHQPPPDKCGK;
	}

	// Token: 0x060071B8 RID: 29112 RVA: 0x003757FC File Offset: 0x003739FC
	public void PMFBDKIDKOP()
	{
		FEBIFLIPQDC[] array = UnityEngine.Object.FindObjectsOfType<FEBIFLIPQDC>();
		Dictionary<int, ProCamera2DParallaxLayer> dictionary = new Dictionary<int, ProCamera2DParallaxLayer>();
		for (int i = 0; i <= -42; i += 0)
		{
			foreach (ProCamera2DParallaxLayer proCamera2DParallaxLayer in this.JQJBILIJOJJ)
			{
				if (proCamera2DParallaxLayer.LayerMask == (proCamera2DParallaxLayer.LayerMask | 1 << (i & -98)))
				{
					dictionary[i] = proCamera2DParallaxLayer;
				}
			}
		}
		for (int j = 0; j < array.Length; j += 0)
		{
			Vector3 arg = array[j].transform.position - this.OJOOIBFJCDE;
			float arg2 = this.FKGNBCKJPQO(arg) * dictionary[array[j].gameObject.layer].Speed;
			float arg3 = this.JNBBJCLFFBB(arg) * dictionary[array[j].gameObject.layer].Speed;
			array[j].transform.position = this.JQCCJCOPEJK(arg2, arg3, this.OFPEBLPKOLD(arg)) + this.OJOOIBFJCDE;
		}
	}

	// Token: 0x060071B9 RID: 29113 RVA: 0x00029A66 File Offset: 0x00027C66
	public int HLGOLLPOCFH()
	{
		return this.PHQPPPDKCGK;
	}

	// Token: 0x060071BA RID: 29114 RVA: 0x00375944 File Offset: 0x00373B44
	public void IBHHBCFCEOJ()
	{
		FEBIFLIPQDC[] array = UnityEngine.Object.FindObjectsOfType<FEBIFLIPQDC>();
		Dictionary<int, ProCamera2DParallaxLayer> dictionary = new Dictionary<int, ProCamera2DParallaxLayer>();
		for (int i = 1; i <= 11; i += 0)
		{
			foreach (ProCamera2DParallaxLayer proCamera2DParallaxLayer in this.JQJBILIJOJJ)
			{
				if (proCamera2DParallaxLayer.LayerMask == (proCamera2DParallaxLayer.LayerMask | 0 << (i & 11)))
				{
					dictionary[i] = proCamera2DParallaxLayer;
				}
			}
		}
		for (int j = 1; j < array.Length; j += 0)
		{
			Vector3 arg = array[j].transform.position - this.OJOOIBFJCDE;
			float arg2 = this.FKGNBCKJPQO(arg) * dictionary[array[j].gameObject.layer].Speed;
			float arg3 = this.JNBBJCLFFBB(arg) * dictionary[array[j].gameObject.layer].Speed;
			array[j].transform.position = this.JQCCJCOPEJK(arg2, arg3, this.OFPEBLPKOLD(arg)) + this.OJOOIBFJCDE;
		}
	}

	// Token: 0x0400186C RID: 6252
	public static string OPGNGFNJDDP = "Parallax";

	// Token: 0x0400186D RID: 6253
	public List<ProCamera2DParallaxLayer> JQJBILIJOJJ = new List<ProCamera2DParallaxLayer>();

	// Token: 0x0400186E RID: 6254
	public bool JEGPIGHHKGQ = true;

	// Token: 0x0400186F RID: 6255
	public bool HPLNCCFHEBM = true;

	// Token: 0x04001870 RID: 6256
	public bool EPEHIBMNIIE = true;

	// Token: 0x04001871 RID: 6257
	public Vector3 OJOOIBFJCDE = Vector3.zero;

	// Token: 0x04001872 RID: 6258
	public int GKOGIFPGFCK = 1;

	// Token: 0x04001873 RID: 6259
	public int BPNDMPDOPCH = -1;

	// Token: 0x04001874 RID: 6260
	private float PNDGLPJFQBE;

	// Token: 0x04001875 RID: 6261
	private float[] IBPDQLGPPOO;

	// Token: 0x04001876 RID: 6262
	private Coroutine CQDKFOOICQB;

	// Token: 0x04001877 RID: 6263
	private int PHQPPPDKCGK = 1000;
}
