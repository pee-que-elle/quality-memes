using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200022D RID: 557
public class LPEQICNMHIL : MonoBehaviour
{
	// Token: 0x06004BF6 RID: 19446 RVA: 0x0001F29B File Offset: 0x0001D49B
	public void GDMIEJMOEJN(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(true);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004BF7 RID: 19447 RVA: 0x0027727C File Offset: 0x0027547C
	private void GBGEGKHDQKB()
	{
		this.QDMOOFCIEBO = new Dictionary<string, List<LPEQICNMHIL.MBHEKOHFPLI>>();
		foreach (LPEQICNMHIL.Pool pool in this.KIIICOOJGNL)
		{
			List<LPEQICNMHIL.MBHEKOHFPLI> list = new List<LPEQICNMHIL.MBHEKOHFPLI>();
			for (int i = 1; i < pool.size; i++)
			{
				LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
				mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(pool.prefab);
				mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
				mbhekohfpli.JDKLKGQNKKB.SetActive(true);
				mbhekohfpli.ELPCFQKDKKF = false;
				list.Add(mbhekohfpli);
			}
			this.QDMOOFCIEBO.Add(pool.tag, list);
		}
		this.KNDEJLKEQBE = new int[this.KIIICOOJGNL.Count];
	}

	// Token: 0x06004BF8 RID: 19448 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void NPEJDHMIFDJ()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004BF9 RID: 19449 RVA: 0x00277364 File Offset: 0x00275564
	private void QBGOGFJCLEP()
	{
		this.QDMOOFCIEBO = new Dictionary<string, List<LPEQICNMHIL.MBHEKOHFPLI>>();
		foreach (LPEQICNMHIL.Pool pool in this.KIIICOOJGNL)
		{
			List<LPEQICNMHIL.MBHEKOHFPLI> list = new List<LPEQICNMHIL.MBHEKOHFPLI>();
			for (int i = 0; i < pool.size; i += 0)
			{
				LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
				mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(pool.prefab);
				mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
				mbhekohfpli.JDKLKGQNKKB.SetActive(true);
				mbhekohfpli.ELPCFQKDKKF = true;
				list.Add(mbhekohfpli);
			}
			this.QDMOOFCIEBO.Add(pool.tag, list);
		}
		this.KNDEJLKEQBE = new int[this.KIIICOOJGNL.Count];
	}

	// Token: 0x06004BFA RID: 19450 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void QOGBNEJFCFJ()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004BFB RID: 19451 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL DJMGOBBECCK()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x06004BFC RID: 19452 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void Awake()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004BFD RID: 19453 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL QDGLKKGJDGI()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x06004BFE RID: 19454 RVA: 0x0027744C File Offset: 0x0027564C
	private void JHQCMGKJCCI()
	{
		this.QDMOOFCIEBO = new Dictionary<string, List<LPEQICNMHIL.MBHEKOHFPLI>>();
		foreach (LPEQICNMHIL.Pool pool in this.KIIICOOJGNL)
		{
			List<LPEQICNMHIL.MBHEKOHFPLI> list = new List<LPEQICNMHIL.MBHEKOHFPLI>();
			for (int i = 1; i < pool.size; i += 0)
			{
				LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
				mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(pool.prefab);
				mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
				mbhekohfpli.JDKLKGQNKKB.SetActive(true);
				mbhekohfpli.ELPCFQKDKKF = false;
				list.Add(mbhekohfpli);
			}
			this.QDMOOFCIEBO.Add(pool.tag, list);
		}
		this.KNDEJLKEQBE = new int[this.KIIICOOJGNL.Count];
	}

	// Token: 0x06004BFF RID: 19455 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL NKDNGLNOJJG()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x06004C00 RID: 19456 RVA: 0x0001F29B File Offset: 0x0001D49B
	public void QGHHECDQCDI(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(true);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C01 RID: 19457 RVA: 0x00277534 File Offset: 0x00275734
	public void PFHDQJEDJMO(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		this.KNDEJLKEQBE[NMBNJJIHMJH] = 0;
		foreach (LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli in this.QDMOOFCIEBO[GQFFOBCKGKG])
		{
			mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
			mbhekohfpli.JDKLKGQNKKB.SetActive(false);
			mbhekohfpli.ELPCFQKDKKF = false;
		}
	}

	// Token: 0x06004C02 RID: 19458 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void PBENCICMMLI()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C03 RID: 19459 RVA: 0x002775BC File Offset: 0x002757BC
	private void OLLNOFNEEIL()
	{
		this.QDMOOFCIEBO = new Dictionary<string, List<LPEQICNMHIL.MBHEKOHFPLI>>();
		foreach (LPEQICNMHIL.Pool pool in this.KIIICOOJGNL)
		{
			List<LPEQICNMHIL.MBHEKOHFPLI> list = new List<LPEQICNMHIL.MBHEKOHFPLI>();
			for (int i = 0; i < pool.size; i += 0)
			{
				LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
				mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(pool.prefab);
				mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
				mbhekohfpli.JDKLKGQNKKB.SetActive(false);
				mbhekohfpli.ELPCFQKDKKF = true;
				list.Add(mbhekohfpli);
			}
			this.QDMOOFCIEBO.Add(pool.tag, list);
		}
		this.KNDEJLKEQBE = new int[this.KIIICOOJGNL.Count];
	}

	// Token: 0x06004C04 RID: 19460 RVA: 0x002776A4 File Offset: 0x002758A4
	public GameObject FCIIBFEGBML(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		for (int i = this.KNDEJLKEQBE[NMBNJJIHMJH]; i < this.QDMOOFCIEBO[GQFFOBCKGKG].Count; i++)
		{
			if (!this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF)
			{
				this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF = false;
				this.KNDEJLKEQBE[NMBNJJIHMJH] = i;
				return this.QDMOOFCIEBO[GQFFOBCKGKG][i].JDKLKGQNKKB;
			}
		}
		this.KNDEJLKEQBE[NMBNJJIHMJH] = this.QDMOOFCIEBO[GQFFOBCKGKG].Count - 1;
		LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
		mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(this.KIIICOOJGNL[NMBNJJIHMJH].prefab);
		mbhekohfpli.JDKLKGQNKKB.SetActive(true);
		mbhekohfpli.ELPCFQKDKKF = true;
		this.QDMOOFCIEBO[GQFFOBCKGKG].Add(mbhekohfpli);
		return mbhekohfpli.JDKLKGQNKKB;
	}

	// Token: 0x06004C05 RID: 19461 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void OJJILLOOFKF()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C06 RID: 19462 RVA: 0x00277794 File Offset: 0x00275994
	public GameObject CMEFGCPOGFO(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		for (int i = this.KNDEJLKEQBE[NMBNJJIHMJH]; i < this.QDMOOFCIEBO[GQFFOBCKGKG].Count; i++)
		{
			if (!this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF)
			{
				this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF = false;
				this.KNDEJLKEQBE[NMBNJJIHMJH] = i;
				return this.QDMOOFCIEBO[GQFFOBCKGKG][i].JDKLKGQNKKB;
			}
		}
		this.KNDEJLKEQBE[NMBNJJIHMJH] = this.QDMOOFCIEBO[GQFFOBCKGKG].Count - 1;
		LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
		mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(this.KIIICOOJGNL[NMBNJJIHMJH].prefab);
		mbhekohfpli.JDKLKGQNKKB.SetActive(false);
		mbhekohfpli.ELPCFQKDKKF = false;
		this.QDMOOFCIEBO[GQFFOBCKGKG].Add(mbhekohfpli);
		return mbhekohfpli.JDKLKGQNKKB;
	}

	// Token: 0x06004C07 RID: 19463 RVA: 0x00277884 File Offset: 0x00275A84
	public void IPJOKJPLMIE(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		this.KNDEJLKEQBE[NMBNJJIHMJH] = 0;
		foreach (LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli in this.QDMOOFCIEBO[GQFFOBCKGKG])
		{
			mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
			mbhekohfpli.JDKLKGQNKKB.SetActive(false);
			mbhekohfpli.ELPCFQKDKKF = true;
		}
	}

	// Token: 0x06004C08 RID: 19464 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
	public void OKNBGPNOJDL(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(false);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C09 RID: 19465 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL FPQNIQELKMC()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x06004C0A RID: 19466 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void LIPJCQHLQCQ()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C0B RID: 19467 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
	public void PEFKLGMDHEO(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(false);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C0C RID: 19468 RVA: 0x00277534 File Offset: 0x00275734
	public void BLBBJJPDLDC(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		this.KNDEJLKEQBE[NMBNJJIHMJH] = 0;
		foreach (LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli in this.QDMOOFCIEBO[GQFFOBCKGKG])
		{
			mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
			mbhekohfpli.JDKLKGQNKKB.SetActive(false);
			mbhekohfpli.ELPCFQKDKKF = false;
		}
	}

	// Token: 0x06004C0D RID: 19469 RVA: 0x0027790C File Offset: 0x00275B0C
	public GameObject PEJIFGJPCGD(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		for (int i = this.KNDEJLKEQBE[NMBNJJIHMJH]; i < this.QDMOOFCIEBO[GQFFOBCKGKG].Count; i += 0)
		{
			if (!this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF)
			{
				this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF = false;
				this.KNDEJLKEQBE[NMBNJJIHMJH] = i;
				return this.QDMOOFCIEBO[GQFFOBCKGKG][i].JDKLKGQNKKB;
			}
		}
		this.KNDEJLKEQBE[NMBNJJIHMJH] = this.QDMOOFCIEBO[GQFFOBCKGKG].Count - 0;
		LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
		mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(this.KIIICOOJGNL[NMBNJJIHMJH].prefab);
		mbhekohfpli.JDKLKGQNKKB.SetActive(false);
		mbhekohfpli.ELPCFQKDKKF = false;
		this.QDMOOFCIEBO[GQFFOBCKGKG].Add(mbhekohfpli);
		return mbhekohfpli.JDKLKGQNKKB;
	}

	// Token: 0x06004C0E RID: 19470 RVA: 0x002779FC File Offset: 0x00275BFC
	public GameObject GKNLQNEMKKF(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		for (int i = this.KNDEJLKEQBE[NMBNJJIHMJH]; i < this.QDMOOFCIEBO[GQFFOBCKGKG].Count; i++)
		{
			if (!this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF)
			{
				this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF = true;
				this.KNDEJLKEQBE[NMBNJJIHMJH] = i;
				return this.QDMOOFCIEBO[GQFFOBCKGKG][i].JDKLKGQNKKB;
			}
		}
		this.KNDEJLKEQBE[NMBNJJIHMJH] = this.QDMOOFCIEBO[GQFFOBCKGKG].Count - 0;
		LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
		mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(this.KIIICOOJGNL[NMBNJJIHMJH].prefab);
		mbhekohfpli.JDKLKGQNKKB.SetActive(false);
		mbhekohfpli.ELPCFQKDKKF = true;
		this.QDMOOFCIEBO[GQFFOBCKGKG].Add(mbhekohfpli);
		return mbhekohfpli.JDKLKGQNKKB;
	}

	// Token: 0x06004C0F RID: 19471 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL IDQMHCMCJDL()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x06004C10 RID: 19472 RVA: 0x00277AEC File Offset: 0x00275CEC
	public void ENQLFNNNDPO(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		this.KNDEJLKEQBE[NMBNJJIHMJH] = 1;
		foreach (LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli in this.QDMOOFCIEBO[GQFFOBCKGKG])
		{
			mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
			mbhekohfpli.JDKLKGQNKKB.SetActive(false);
			mbhekohfpli.ELPCFQKDKKF = false;
		}
	}

	// Token: 0x06004C12 RID: 19474 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void OEOJDKBDNMJ()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C13 RID: 19475 RVA: 0x0001F29B File Offset: 0x0001D49B
	public void NOONCJPPGJD(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(true);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C14 RID: 19476 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL CPLQICHLGCI()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x06004C15 RID: 19477 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL QOQONHOOLNE
	{
		get
		{
			return LPEQICNMHIL.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004C16 RID: 19478 RVA: 0x00277B74 File Offset: 0x00275D74
	private void MBKJBIQKPGF()
	{
		this.QDMOOFCIEBO = new Dictionary<string, List<LPEQICNMHIL.MBHEKOHFPLI>>();
		foreach (LPEQICNMHIL.Pool pool in this.KIIICOOJGNL)
		{
			List<LPEQICNMHIL.MBHEKOHFPLI> list = new List<LPEQICNMHIL.MBHEKOHFPLI>();
			for (int i = 0; i < pool.size; i++)
			{
				LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
				mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(pool.prefab);
				mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
				mbhekohfpli.JDKLKGQNKKB.SetActive(false);
				mbhekohfpli.ELPCFQKDKKF = true;
				list.Add(mbhekohfpli);
			}
			this.QDMOOFCIEBO.Add(pool.tag, list);
		}
		this.KNDEJLKEQBE = new int[this.KIIICOOJGNL.Count];
	}

	// Token: 0x06004C17 RID: 19479 RVA: 0x00277C5C File Offset: 0x00275E5C
	private void IJNCFJMGKDE()
	{
		this.QDMOOFCIEBO = new Dictionary<string, List<LPEQICNMHIL.MBHEKOHFPLI>>();
		foreach (LPEQICNMHIL.Pool pool in this.KIIICOOJGNL)
		{
			List<LPEQICNMHIL.MBHEKOHFPLI> list = new List<LPEQICNMHIL.MBHEKOHFPLI>();
			for (int i = 0; i < pool.size; i++)
			{
				LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
				mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(pool.prefab);
				mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
				mbhekohfpli.JDKLKGQNKKB.SetActive(false);
				mbhekohfpli.ELPCFQKDKKF = false;
				list.Add(mbhekohfpli);
			}
			this.QDMOOFCIEBO.Add(pool.tag, list);
		}
		this.KNDEJLKEQBE = new int[this.KIIICOOJGNL.Count];
	}

	// Token: 0x06004C18 RID: 19480 RVA: 0x0001F29B File Offset: 0x0001D49B
	public void JGMGKPKJJQH(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(true);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C19 RID: 19481 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL BBCBOIFQDBK()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x06004C1A RID: 19482 RVA: 0x00277D44 File Offset: 0x00275F44
	public void DIOQIGEOJLE(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		this.KNDEJLKEQBE[NMBNJJIHMJH] = 1;
		foreach (LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli in this.QDMOOFCIEBO[GQFFOBCKGKG])
		{
			mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
			mbhekohfpli.JDKLKGQNKKB.SetActive(true);
			mbhekohfpli.ELPCFQKDKKF = true;
		}
	}

	// Token: 0x06004C1B RID: 19483 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL LGIPDGGFINQ()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x06004C1C RID: 19484 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void COFPBILHHNO()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C1D RID: 19485 RVA: 0x0001F29B File Offset: 0x0001D49B
	public void GICMLGFNLNL(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(true);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C1E RID: 19486 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void MBDGLQOGLDJ()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C1F RID: 19487 RVA: 0x00277534 File Offset: 0x00275734
	public void PDBGQNOLMBG(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		this.KNDEJLKEQBE[NMBNJJIHMJH] = 0;
		foreach (LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli in this.QDMOOFCIEBO[GQFFOBCKGKG])
		{
			mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
			mbhekohfpli.JDKLKGQNKKB.SetActive(false);
			mbhekohfpli.ELPCFQKDKKF = false;
		}
	}

	// Token: 0x06004C20 RID: 19488 RVA: 0x00277DCC File Offset: 0x00275FCC
	public GameObject JPODNGNQBKQ(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		for (int i = this.KNDEJLKEQBE[NMBNJJIHMJH]; i < this.QDMOOFCIEBO[GQFFOBCKGKG].Count; i++)
		{
			if (!this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF)
			{
				this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF = true;
				this.KNDEJLKEQBE[NMBNJJIHMJH] = i;
				return this.QDMOOFCIEBO[GQFFOBCKGKG][i].JDKLKGQNKKB;
			}
		}
		this.KNDEJLKEQBE[NMBNJJIHMJH] = this.QDMOOFCIEBO[GQFFOBCKGKG].Count - 1;
		LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
		mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(this.KIIICOOJGNL[NMBNJJIHMJH].prefab);
		mbhekohfpli.JDKLKGQNKKB.SetActive(false);
		mbhekohfpli.ELPCFQKDKKF = true;
		this.QDMOOFCIEBO[GQFFOBCKGKG].Add(mbhekohfpli);
		return mbhekohfpli.JDKLKGQNKKB;
	}

	// Token: 0x06004C21 RID: 19489 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
	public void HPEHCEBQJGI(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(false);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C22 RID: 19490 RVA: 0x00277EBC File Offset: 0x002760BC
	public GameObject FIGMKCDNCJM(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		for (int i = this.KNDEJLKEQBE[NMBNJJIHMJH]; i < this.QDMOOFCIEBO[GQFFOBCKGKG].Count; i += 0)
		{
			if (!this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF)
			{
				this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF = true;
				this.KNDEJLKEQBE[NMBNJJIHMJH] = i;
				return this.QDMOOFCIEBO[GQFFOBCKGKG][i].JDKLKGQNKKB;
			}
		}
		this.KNDEJLKEQBE[NMBNJJIHMJH] = this.QDMOOFCIEBO[GQFFOBCKGKG].Count - 1;
		LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
		mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(this.KIIICOOJGNL[NMBNJJIHMJH].prefab);
		mbhekohfpli.JDKLKGQNKKB.SetActive(true);
		mbhekohfpli.ELPCFQKDKKF = false;
		this.QDMOOFCIEBO[GQFFOBCKGKG].Add(mbhekohfpli);
		return mbhekohfpli.JDKLKGQNKKB;
	}

	// Token: 0x06004C23 RID: 19491 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void LKDKBNOBIPK()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C24 RID: 19492 RVA: 0x0001F29B File Offset: 0x0001D49B
	public void FBBLQKFFIPC(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(true);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C25 RID: 19493 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL MKPBQJDCPIL()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x06004C26 RID: 19494 RVA: 0x0001F29B File Offset: 0x0001D49B
	public void EPGKCMBINEO(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(true);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C27 RID: 19495 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void PEOBQCMFLML()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C28 RID: 19496 RVA: 0x00277FAC File Offset: 0x002761AC
	public void KNJDCJDDLDF(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		this.KNDEJLKEQBE[NMBNJJIHMJH] = 1;
		foreach (LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli in this.QDMOOFCIEBO[GQFFOBCKGKG])
		{
			mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
			mbhekohfpli.JDKLKGQNKKB.SetActive(true);
			mbhekohfpli.ELPCFQKDKKF = false;
		}
	}

	// Token: 0x06004C29 RID: 19497 RVA: 0x00278034 File Offset: 0x00276234
	public void NLBGHMLEJOO(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		this.KNDEJLKEQBE[NMBNJJIHMJH] = 1;
		foreach (LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli in this.QDMOOFCIEBO[GQFFOBCKGKG])
		{
			mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
			mbhekohfpli.JDKLKGQNKKB.SetActive(false);
			mbhekohfpli.ELPCFQKDKKF = true;
		}
	}

	// Token: 0x06004C2A RID: 19498 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL DKJQQCEGJKO()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x06004C2B RID: 19499 RVA: 0x002780BC File Offset: 0x002762BC
	public void LQBLJKDOFKC(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		this.KNDEJLKEQBE[NMBNJJIHMJH] = 0;
		foreach (LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli in this.QDMOOFCIEBO[GQFFOBCKGKG])
		{
			mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
			mbhekohfpli.JDKLKGQNKKB.SetActive(true);
			mbhekohfpli.ELPCFQKDKKF = false;
		}
	}

	// Token: 0x06004C2C RID: 19500 RVA: 0x0001F29B File Offset: 0x0001D49B
	public void HBEBEOPGHPM(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(true);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C2D RID: 19501 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
	public void HJGBDJEFOJK(GameObject CBNJEBCHOEC)
	{
		CBNJEBCHOEC.SetActive(false);
		CBNJEBCHOEC.transform.parent = base.transform;
	}

	// Token: 0x06004C2E RID: 19502 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void QHQEBPKMNLD()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C2F RID: 19503 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void LJBKGHHLMFB()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C30 RID: 19504 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void LQFEFNKLPBG()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C31 RID: 19505 RVA: 0x0001F2BD File Offset: 0x0001D4BD
	public static LPEQICNMHIL GGBPGMMCGLI()
	{
		return LPEQICNMHIL.HBFFCJHOCPE;
	}

	// Token: 0x06004C32 RID: 19506 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void PGJHPMOLHKN()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C33 RID: 19507 RVA: 0x00277C5C File Offset: 0x00275E5C
	private void Start()
	{
		this.QDMOOFCIEBO = new Dictionary<string, List<LPEQICNMHIL.MBHEKOHFPLI>>();
		foreach (LPEQICNMHIL.Pool pool in this.KIIICOOJGNL)
		{
			List<LPEQICNMHIL.MBHEKOHFPLI> list = new List<LPEQICNMHIL.MBHEKOHFPLI>();
			for (int i = 0; i < pool.size; i++)
			{
				LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
				mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(pool.prefab);
				mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
				mbhekohfpli.JDKLKGQNKKB.SetActive(false);
				mbhekohfpli.ELPCFQKDKKF = false;
				list.Add(mbhekohfpli);
			}
			this.QDMOOFCIEBO.Add(pool.tag, list);
		}
		this.KNDEJLKEQBE = new int[this.KIIICOOJGNL.Count];
	}

	// Token: 0x06004C34 RID: 19508 RVA: 0x00277EBC File Offset: 0x002760BC
	public GameObject HCOQJPNIEHI(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		for (int i = this.KNDEJLKEQBE[NMBNJJIHMJH]; i < this.QDMOOFCIEBO[GQFFOBCKGKG].Count; i += 0)
		{
			if (!this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF)
			{
				this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF = true;
				this.KNDEJLKEQBE[NMBNJJIHMJH] = i;
				return this.QDMOOFCIEBO[GQFFOBCKGKG][i].JDKLKGQNKKB;
			}
		}
		this.KNDEJLKEQBE[NMBNJJIHMJH] = this.QDMOOFCIEBO[GQFFOBCKGKG].Count - 1;
		LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
		mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(this.KIIICOOJGNL[NMBNJJIHMJH].prefab);
		mbhekohfpli.JDKLKGQNKKB.SetActive(true);
		mbhekohfpli.ELPCFQKDKKF = false;
		this.QDMOOFCIEBO[GQFFOBCKGKG].Add(mbhekohfpli);
		return mbhekohfpli.JDKLKGQNKKB;
	}

	// Token: 0x06004C35 RID: 19509 RVA: 0x0027727C File Offset: 0x0027547C
	private void COOEINBIIIE()
	{
		this.QDMOOFCIEBO = new Dictionary<string, List<LPEQICNMHIL.MBHEKOHFPLI>>();
		foreach (LPEQICNMHIL.Pool pool in this.KIIICOOJGNL)
		{
			List<LPEQICNMHIL.MBHEKOHFPLI> list = new List<LPEQICNMHIL.MBHEKOHFPLI>();
			for (int i = 1; i < pool.size; i++)
			{
				LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
				mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(pool.prefab);
				mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
				mbhekohfpli.JDKLKGQNKKB.SetActive(true);
				mbhekohfpli.ELPCFQKDKKF = false;
				list.Add(mbhekohfpli);
			}
			this.QDMOOFCIEBO.Add(pool.tag, list);
		}
		this.KNDEJLKEQBE = new int[this.KIIICOOJGNL.Count];
	}

	// Token: 0x06004C36 RID: 19510 RVA: 0x00277FAC File Offset: 0x002761AC
	public void MIECCNEBLPD(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		this.KNDEJLKEQBE[NMBNJJIHMJH] = 1;
		foreach (LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli in this.QDMOOFCIEBO[GQFFOBCKGKG])
		{
			mbhekohfpli.JDKLKGQNKKB.transform.parent = base.transform;
			mbhekohfpli.JDKLKGQNKKB.SetActive(true);
			mbhekohfpli.ELPCFQKDKKF = false;
		}
	}

	// Token: 0x06004C37 RID: 19511 RVA: 0x00278144 File Offset: 0x00276344
	public GameObject QIQPJQFDBCP(string GQFFOBCKGKG, int NMBNJJIHMJH)
	{
		for (int i = this.KNDEJLKEQBE[NMBNJJIHMJH]; i < this.QDMOOFCIEBO[GQFFOBCKGKG].Count; i++)
		{
			if (!this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF)
			{
				this.QDMOOFCIEBO[GQFFOBCKGKG][i].ELPCFQKDKKF = true;
				this.KNDEJLKEQBE[NMBNJJIHMJH] = i;
				return this.QDMOOFCIEBO[GQFFOBCKGKG][i].JDKLKGQNKKB;
			}
		}
		this.KNDEJLKEQBE[NMBNJJIHMJH] = this.QDMOOFCIEBO[GQFFOBCKGKG].Count - 0;
		LPEQICNMHIL.MBHEKOHFPLI mbhekohfpli = new LPEQICNMHIL.MBHEKOHFPLI();
		mbhekohfpli.JDKLKGQNKKB = UnityEngine.Object.Instantiate<GameObject>(this.KIIICOOJGNL[NMBNJJIHMJH].prefab);
		mbhekohfpli.JDKLKGQNKKB.SetActive(false);
		mbhekohfpli.ELPCFQKDKKF = false;
		this.QDMOOFCIEBO[GQFFOBCKGKG].Add(mbhekohfpli);
		return mbhekohfpli.JDKLKGQNKKB;
	}

	// Token: 0x06004C38 RID: 19512 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
	private void OEEPBOFIEQF()
	{
		LPEQICNMHIL.HBFFCJHOCPE = this;
	}

	// Token: 0x04001054 RID: 4180
	private static LPEQICNMHIL HBFFCJHOCPE;

	// Token: 0x04001055 RID: 4181
	public List<LPEQICNMHIL.Pool> KIIICOOJGNL;

	// Token: 0x04001056 RID: 4182
	public Dictionary<string, List<LPEQICNMHIL.MBHEKOHFPLI>> QDMOOFCIEBO;

	// Token: 0x04001057 RID: 4183
	private int[] KNDEJLKEQBE;

	// Token: 0x0200022E RID: 558
	[Serializable]
	public class Pool
	{
		// Token: 0x04001058 RID: 4184
		public string tag;

		// Token: 0x04001059 RID: 4185
		public GameObject prefab;

		// Token: 0x0400105A RID: 4186
		public int size;
	}

	// Token: 0x0200022F RID: 559
	public class MBHEKOHFPLI
	{
		// Token: 0x0400105B RID: 4187
		public GameObject JDKLKGQNKKB;

		// Token: 0x0400105C RID: 4188
		public bool ELPCFQKDKKF;
	}
}
