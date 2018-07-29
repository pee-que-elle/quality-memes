using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000325 RID: 805
public abstract class JKQPIHPQDHQ : BNEFIOCKQOE
{
	// Token: 0x06006BA7 RID: 27559 RVA: 0x0034A990 File Offset: 0x00348B90
	protected override void Awake()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.PHFGINEKBGQ = base.GetInstanceID();
		this.DDOHKDQFNDH += UnityEngine.Random.Range(-0.02f, 0.02f);
		this.JQFBBLKNFQM(true);
	}

	// Token: 0x06006BA8 RID: 27560 RVA: 0x00028631 File Offset: 0x00026831
	protected override void OnEnable()
	{
		base.OnEnable();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		if (this.PNJNPEEFFPI)
		{
			this.JQFBBLKNFQM(true);
		}
	}

	// Token: 0x06006BA9 RID: 27561 RVA: 0x00028657 File Offset: 0x00026857
	protected override void OnDisable()
	{
		base.OnDisable();
		this.IDEJEEPQPQQ = null;
	}

	// Token: 0x06006BAA RID: 27562 RVA: 0x0034A9E4 File Offset: 0x00348BE4
	public void JQFBBLKNFQM(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			if (this.IDEJEEPQPQQ == null)
			{
				this.IDEJEEPQPQQ = base.StartCoroutine(this.LGHEPDEJNKI());
			}
			this.PNJNPEEFFPI = true;
		}
		else
		{
			if (this.IDEJEEPQPQQ != null)
			{
				base.StopCoroutine(this.IDEJEEPQPQQ);
				this.IDEJEEPQPQQ = null;
			}
			if (this.JJCNPCLINKD)
			{
				this.FPFNBIDJHKM();
			}
			this.PNJNPEEFFPI = false;
		}
	}

	// Token: 0x06006BAB RID: 27563 RVA: 0x0034AA48 File Offset: 0x00348C48
	public void GJNLHJCDQQF()
	{
		Vector3 arg = base.GPONHFNLHCN.HGNEKQHNFCC;
		if (!this.OCGFLQMHBBG && this.HLFEKPCOELI != null)
		{
			arg = this.HLFEKPCOELI.position;
		}
		if (this.FGNPCLCCJPJ == LMPIFDFMHKP.RECTANGLE && BDKMFJQPGGE.NDDFJBMCIDB(this.FKGNBCKJPQO(this.FHNBJCNLJCN.position), this.JNBBJCLFFBB(this.FHNBJCNLJCN.position), this.FKGNBCKJPQO(this.FHNBJCNLJCN.localScale), this.JNBBJCLFFBB(this.FHNBJCNLJCN.localScale), this.FKGNBCKJPQO(arg), this.JNBBJCLFFBB(arg)))
		{
			if (!this.JJCNPCLINKD)
			{
				this.DOJBNQQEFBE();
			}
		}
		else if (this.FGNPCLCCJPJ == LMPIFDFMHKP.CIRCLE && BDKMFJQPGGE.KHGFDLKPNIQ(this.FKGNBCKJPQO(this.FHNBJCNLJCN.position), this.JNBBJCLFFBB(this.FHNBJCNLJCN.position), (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localScale) + this.JNBBJCLFFBB(this.FHNBJCNLJCN.localScale)) * 0.25f, this.FKGNBCKJPQO(arg), this.JNBBJCLFFBB(arg)))
		{
			if (!this.JJCNPCLINKD)
			{
				this.DOJBNQQEFBE();
			}
		}
		else if (this.JJCNPCLINKD)
		{
			this.FPFNBIDJHKM();
		}
	}

	// Token: 0x06006BAC RID: 27564 RVA: 0x00028666 File Offset: 0x00026866
	protected virtual void DOJBNQQEFBE()
	{
		this.JJCNPCLINKD = true;
		if (this.DNJGBMOBEPI != null)
		{
			this.DNJGBMOBEPI();
		}
	}

	// Token: 0x06006BAD RID: 27565 RVA: 0x00028682 File Offset: 0x00026882
	protected virtual void FPFNBIDJHKM()
	{
		this.JJCNPCLINKD = false;
		if (this.BKKNCFDQHMP != null)
		{
			this.BKKNCFDQHMP();
		}
	}

	// Token: 0x06006BAE RID: 27566 RVA: 0x0034ABC4 File Offset: 0x00348DC4
	[DebuggerHidden]
	private IEnumerator LGHEPDEJNKI()
	{
		JKQPIHPQDHQ.BEQEIBINBPJ beqeibinbpj = new JKQPIHPQDHQ.BEQEIBINBPJ();
		beqeibinbpj.QNDQJMNKFNN = this;
		return beqeibinbpj;
	}

	// Token: 0x06006BAF RID: 27567 RVA: 0x0034ABE0 File Offset: 0x00348DE0
	protected float OMFMKLNPGPP(Vector2 NKNELLKPMEB)
	{
		this.MCQFMHIHMFB = NKNELLKPMEB - new Vector2(this.FKGNBCKJPQO(this.FHNBJCNLJCN.position), this.JNBBJCLFFBB(this.FHNBJCNLJCN.position));
		if (this.FGNPCLCCJPJ == LMPIFDFMHKP.RECTANGLE)
		{
			float f = this.FKGNBCKJPQO(this.MCQFMHIHMFB) / (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localScale) * 0.5f);
			float f2 = this.JNBBJCLFFBB(this.MCQFMHIHMFB) / (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localScale) * 0.5f);
			return Mathf.Max(Mathf.Abs(f), Mathf.Abs(f2)).PMNDBPOMOGG(this.DKKMNJCDGCK, 1f, 0f, 1f);
		}
		return (this.MCQFMHIHMFB.magnitude / ((this.FKGNBCKJPQO(this.FHNBJCNLJCN.localScale) + this.JNBBJCLFFBB(this.FHNBJCNLJCN.localScale)) * 0.25f)).PMNDBPOMOGG(this.DKKMNJCDGCK, 1f, 0f, 1f);
	}

	// Token: 0x040016A5 RID: 5797
	public Action DNJGBMOBEPI;

	// Token: 0x040016A6 RID: 5798
	public Action BKKNCFDQHMP;

	// Token: 0x040016A7 RID: 5799
	[Tooltip("Every X seconds detect collision. Smaller intervals are more precise but also require more processing.")]
	public float DDOHKDQFNDH = 0.1f;

	// Token: 0x040016A8 RID: 5800
	public LMPIFDFMHKP FGNPCLCCJPJ;

	// Token: 0x040016A9 RID: 5801
	[Tooltip("If enabled, use the targets mid point to know when inside/outside the trigger.")]
	public bool OCGFLQMHBBG = true;

	// Token: 0x040016AA RID: 5802
	[Tooltip("If UseTargetsMidPoint is disabled, use this transform to know when inside/outside the trigger.")]
	public Transform HLFEKPCOELI;

	// Token: 0x040016AB RID: 5803
	protected float DKKMNJCDGCK;

	// Token: 0x040016AC RID: 5804
	private Coroutine IDEJEEPQPQQ;

	// Token: 0x040016AD RID: 5805
	protected bool JJCNPCLINKD;

	// Token: 0x040016AE RID: 5806
	protected Vector2 MCQFMHIHMFB;

	// Token: 0x040016AF RID: 5807
	protected int PHFGINEKBGQ;

	// Token: 0x040016B0 RID: 5808
	private bool PNJNPEEFFPI;
}
