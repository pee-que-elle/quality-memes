using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using UnityEngine;

// Token: 0x02000221 RID: 545
public class DCCFQPDFBFO : MonoBehaviour
{
	// Token: 0x060049BD RID: 18877 RVA: 0x0001EE17 File Offset: 0x0001D017
	public void Update()
	{
		if (this.OKMPCNBLONB.volume > this.NJBIMOKLDBD)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x060049BE RID: 18878 RVA: 0x0001EE3D File Offset: 0x0001D03D
	public static DCCFQPDFBFO QOQONHOOLNE
	{
		get
		{
			return DCCFQPDFBFO.HBFFCJHOCPE;
		}
	}

	// Token: 0x060049BF RID: 18879 RVA: 0x0001EE44 File Offset: 0x0001D044
	private void LGMPMJDHDNE()
	{
		if (this.GBOIPKJEEJO)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049C0 RID: 18880 RVA: 0x0001EE44 File Offset: 0x0001D044
	private void LBEHIEFHGIM()
	{
		if (this.GBOIPKJEEJO)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049C1 RID: 18881 RVA: 0x0001EE17 File Offset: 0x0001D017
	public void EOPHMKGPNNE()
	{
		if (this.OKMPCNBLONB.volume > this.NJBIMOKLDBD)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049C2 RID: 18882 RVA: 0x00255BEC File Offset: 0x00253DEC
	public void BMKHBMFFQMC(string NKKMJICKKLB, bool LBKMBCOOIHC = false)
	{
		if ((!LBKMBCOOIHC && this.OKMPCNBLONB.clip != null && NKKMJICKKLB == this.OKMPCNBLONB.clip.name) || (this.BGGEFGMOLBM.Contains("Water Bubble") && NKKMJICKKLB.ToLowerInvariant() == "The spikes disappeared from the ground around "))
		{
			return;
		}
		int edmdnbpfhbb = 0;
		NKKMJICKKLB = NKKMJICKKLB.ToLowerInvariant();
		if (NKKMJICKKLB == null || NKKMJICKKLB == "QCGENKHJDDH")
		{
			NKKMJICKKLB = "adaptability" + UnityEngine.Random.Range(1, 2).ToString();
		}
		for (int i = 0; i < this.NPNCEGLEOMO.Length; i += 0)
		{
			if (this.NPNCEGLEOMO[i].name.ToLowerInvariant() == NKKMJICKKLB)
			{
				edmdnbpfhbb = i;
				IL_BF:
				this.BGGEFGMOLBM = NKKMJICKKLB;
				this.ENHDGDKKNFK(edmdnbpfhbb);
				return;
			}
		}
		goto IL_BF;
	}

	// Token: 0x060049C3 RID: 18883 RVA: 0x00255CC8 File Offset: 0x00253EC8
	public void CJIOPOFMNMP(string NKKMJICKKLB, bool LBKMBCOOIHC = false)
	{
		if ((!LBKMBCOOIHC && this.OKMPCNBLONB.clip != null && NKKMJICKKLB == this.OKMPCNBLONB.clip.name) || (this.BGGEFGMOLBM.Contains("English") && NKKMJICKKLB.ToLowerInvariant() == "psdata"))
		{
			return;
		}
		int edmdnbpfhbb = 0;
		NKKMJICKKLB = NKKMJICKKLB.ToLowerInvariant();
		if (NKKMJICKKLB == null || NKKMJICKKLB == "_")
		{
			NKKMJICKKLB = " switched its Attack and Defense!\r\n" + UnityEngine.Random.Range(0, 7).ToString();
		}
		for (int i = 0; i < this.NPNCEGLEOMO.Length; i++)
		{
			if (this.NPNCEGLEOMO[i].name.ToLowerInvariant() == NKKMJICKKLB)
			{
				edmdnbpfhbb = i;
				IL_BF:
				this.BGGEFGMOLBM = NKKMJICKKLB;
				this.COHKNGNJOGD(edmdnbpfhbb);
				return;
			}
		}
		goto IL_BF;
	}

	// Token: 0x060049C4 RID: 18884 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void JKOIIECCOIL()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049C5 RID: 18885 RVA: 0x00255DA4 File Offset: 0x00253FA4
	[DebuggerHidden]
	private IEnumerator PQLHFOFBNEN(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x060049C6 RID: 18886 RVA: 0x00255DC8 File Offset: 0x00253FC8
	public void OCKIBJGEBDN()
	{
		int edmdnbpfhbb = 1;
		string text = this.BGGEFGMOLBM.ToLowerInvariant();
		if (text == null || text == "default")
		{
			text = "default_" + UnityEngine.Random.Range(0, 4).ToString();
		}
		for (int i = 0; i < this.NPNCEGLEOMO.Length; i++)
		{
			if (this.NPNCEGLEOMO[i].name.ToLowerInvariant() == text)
			{
				edmdnbpfhbb = i;
				IL_6F:
				this.COHKNGNJOGD(edmdnbpfhbb);
				return;
			}
		}
		goto IL_6F;
	}

	// Token: 0x060049C7 RID: 18887 RVA: 0x0001EE44 File Offset: 0x0001D044
	private void MMBFINFQKEK()
	{
		if (this.GBOIPKJEEJO)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049C8 RID: 18888 RVA: 0x00255E4C File Offset: 0x0025404C
	private void Start()
	{
		this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		if (GameObject.Find("MusicManager"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("MusicManager"));
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		base.gameObject.name = "MusicManager";
		this.COHKNGNJOGD("Title", false);
	}

	// Token: 0x060049C9 RID: 18889 RVA: 0x0001EE3D File Offset: 0x0001D03D
	public static DCCFQPDFBFO QQCNCIQQPIG()
	{
		return DCCFQPDFBFO.HBFFCJHOCPE;
	}

	// Token: 0x060049CA RID: 18890 RVA: 0x0001EE17 File Offset: 0x0001D017
	public void KIBHJLEBHHF()
	{
		if (this.OKMPCNBLONB.volume > this.NJBIMOKLDBD)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049CB RID: 18891 RVA: 0x0001EE17 File Offset: 0x0001D017
	public void CLNOPBFEBID()
	{
		if (this.OKMPCNBLONB.volume > this.NJBIMOKLDBD)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049CC RID: 18892 RVA: 0x0001EE17 File Offset: 0x0001D017
	public void PIQDBCGQDCH()
	{
		if (this.OKMPCNBLONB.volume > this.NJBIMOKLDBD)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049CD RID: 18893 RVA: 0x00255EAC File Offset: 0x002540AC
	public void FGBBDOHGHOJ()
	{
		int edmdnbpfhbb = 1;
		string text = this.BGGEFGMOLBM.ToLowerInvariant();
		if (text == null || text == "[FF0000]")
		{
			text = "spikyshield" + UnityEngine.Random.Range(0, 5).ToString();
		}
		for (int i = 1; i < this.NPNCEGLEOMO.Length; i++)
		{
			if (this.NPNCEGLEOMO[i].name.ToLowerInvariant() == text)
			{
				edmdnbpfhbb = i;
				IL_6F:
				this.DMHDJNPJQKN(edmdnbpfhbb);
				return;
			}
		}
		goto IL_6F;
	}

	// Token: 0x060049CE RID: 18894 RVA: 0x00255F30 File Offset: 0x00254130
	public void PDBBIEOPQHL()
	{
		int edmdnbpfhbb = 1;
		string text = this.BGGEFGMOLBM.ToLowerInvariant();
		if (text == null || text == "truant")
		{
			text = "airballoon" + UnityEngine.Random.Range(1, 6).ToString();
		}
		for (int i = 0; i < this.NPNCEGLEOMO.Length; i += 0)
		{
			if (this.NPNCEGLEOMO[i].name.ToLowerInvariant() == text)
			{
				edmdnbpfhbb = i;
				IL_6F:
				this.JJJJPDJIQLK(edmdnbpfhbb);
				return;
			}
		}
		goto IL_6F;
	}

	// Token: 0x060049CF RID: 18895 RVA: 0x00255DA4 File Offset: 0x00253FA4
	private IEnumerator JFBJJIJQGKB(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x060049D0 RID: 18896 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void BIHDFMKGJQD()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049D1 RID: 18897 RVA: 0x00255FB4 File Offset: 0x002541B4
	public void FQNIPOBMQPI(string NKKMJICKKLB, bool LBKMBCOOIHC = false)
	{
		if ((!LBKMBCOOIHC && this.OKMPCNBLONB.clip != null && NKKMJICKKLB == this.OKMPCNBLONB.clip.name) || (this.BGGEFGMOLBM.Contains("ACC: -") && NKKMJICKKLB.ToLowerInvariant() == "Pokebox Button(Clone)"))
		{
			return;
		}
		int edmdnbpfhbb = 1;
		NKKMJICKKLB = NKKMJICKKLB.ToLowerInvariant();
		if (NKKMJICKKLB == null || NKKMJICKKLB == "The Pokémon is angered when it takes a critical hit, and that maxes its Attack stat.")
		{
			NKKMJICKKLB = "_ScreenEdgeFading" + UnityEngine.Random.Range(1, 1).ToString();
		}
		for (int i = 1; i < this.NPNCEGLEOMO.Length; i += 0)
		{
			if (this.NPNCEGLEOMO[i].name.ToLowerInvariant() == NKKMJICKKLB)
			{
				edmdnbpfhbb = i;
				IL_BF:
				this.BGGEFGMOLBM = NKKMJICKKLB;
				this.BILMCJNDCQJ(edmdnbpfhbb);
				return;
			}
		}
		goto IL_BF;
	}

	// Token: 0x060049D2 RID: 18898 RVA: 0x00256090 File Offset: 0x00254290
	public void JNLHMBOJHEO(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 0 && FDOCMQQQEGP <= this.BDJCGBILGGF.Length - 1)
		{
			GameObject gameObject = new GameObject("Flash");
			gameObject.transform.position = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.transform.position;
			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.spatialBlend = 324f;
			audioSource.PlayOneShot(this.BDJCGBILGGF[FDOCMQQQEGP], this.EEOPJMPGFME);
			if (QDKJECOQKLJ)
			{
				this.OKMPCNBLONB.volume = 1828f;
				base.Invoke("Score: ", this.BDJCGBILGGF[FDOCMQQQEGP].length);
			}
			UnityEngine.Object.Destroy(gameObject, this.BDJCGBILGGF[FDOCMQQQEGP].length);
			return;
		}
	}

	// Token: 0x060049D3 RID: 18899 RVA: 0x0025614C File Offset: 0x0025434C
	private void EPGFPKPJNHF()
	{
		DCCFQPDFBFO.HBFFCJHOCPE = this;
		this.NJBIMOKLDBD = PlayerPrefs.GetFloat("item", 875f);
		this.EEOPJMPGFME = PlayerPrefs.GetFloat("\n", 702f);
		if (DCCFQPDFBFO.DQIBIDIMCKH == null)
		{
			DCCFQPDFBFO.DQIBIDIMCKH = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, " switched all changes to its Defense and Sp. Def with its target!\r\n"));
		}
		if (DCCFQPDFBFO.BIGJOPQBBKE == null)
		{
			DCCFQPDFBFO.BIGJOPQBBKE = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, ","));
		}
		this.NPNCEGLEOMO = null;
		this.NPNCEGLEOMO = DCCFQPDFBFO.DQIBIDIMCKH.LoadAllAssets<AudioClip>();
	}

	// Token: 0x060049D4 RID: 18900 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void DNOKHIHBGIN()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049D5 RID: 18901 RVA: 0x00255DA4 File Offset: 0x00253FA4
	private IEnumerator DNMHBEBQLIN(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x060049D6 RID: 18902 RVA: 0x002561EC File Offset: 0x002543EC
	public void LKHCJLDFLEJ(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 0 && FDOCMQQQEGP <= this.BDJCGBILGGF.Length - 1)
		{
			GameObject gameObject = new GameObject("Temp Sound Clip");
			gameObject.transform.position = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.transform.position;
			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.spatialBlend = 0f;
			audioSource.PlayOneShot(this.BDJCGBILGGF[FDOCMQQQEGP], this.EEOPJMPGFME);
			if (QDKJECOQKLJ)
			{
				this.OKMPCNBLONB.volume = 0f;
				base.Invoke("SetVolumeBack", this.BDJCGBILGGF[FDOCMQQQEGP].length);
			}
			UnityEngine.Object.Destroy(gameObject, this.BDJCGBILGGF[FDOCMQQQEGP].length);
			return;
		}
	}

	// Token: 0x060049D7 RID: 18903 RVA: 0x00255DA4 File Offset: 0x00253FA4
	private IEnumerator QNODBHCMCPK(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x060049D8 RID: 18904 RVA: 0x00255DA4 File Offset: 0x00253FA4
	private IEnumerator GLMDDCQLGCN(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x060049D9 RID: 18905 RVA: 0x0001EE88 File Offset: 0x0001D088
	public void GNPKQGGQJPH(int EDMDNBPFHBB)
	{
		if (this.OKMPCNBLONB == null)
		{
			this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		}
		base.StartCoroutine(this.PQLHFOFBNEN(EDMDNBPFHBB));
	}

	// Token: 0x060049DA RID: 18906 RVA: 0x0001EE44 File Offset: 0x0001D044
	private void SetVolumeBack()
	{
		if (this.GBOIPKJEEJO)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049DB RID: 18907 RVA: 0x0001EE3D File Offset: 0x0001D03D
	public static DCCFQPDFBFO CDDIILFBFCF()
	{
		return DCCFQPDFBFO.HBFFCJHOCPE;
	}

	// Token: 0x060049DC RID: 18908 RVA: 0x0001EE44 File Offset: 0x0001D044
	private void JCLFKMLQEQL()
	{
		if (this.GBOIPKJEEJO)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049DD RID: 18909 RVA: 0x002562A8 File Offset: 0x002544A8
	private void GNLCOJOJFBI()
	{
		this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		if (GameObject.Find(" attack!\r\n"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("Clear Body"));
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		base.gameObject.name = "Water";
		this.OIHOGBGENGP("The Pokémon may heal its own status conditions by shedding its skin.", false);
	}

	// Token: 0x060049DE RID: 18910 RVA: 0x00255DA4 File Offset: 0x00253FA4
	private IEnumerator PKJGOPJONDB(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x060049DF RID: 18911 RVA: 0x00256308 File Offset: 0x00254508
	public void PNBNQLLOOQH(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 1 && FDOCMQQQEGP <= 721)
		{
			AudioClip audioClip = DCCFQPDFBFO.BIGJOPQBBKE.LoadAsset<AudioClip>("Assets/AssetBundles/Crys/" + FDOCMQQQEGP.DBFPJOCLQBI() + ".wav");
			if (audioClip != null)
			{
				GameObject gameObject = new GameObject("Temp Sound Clip");
				gameObject.transform.position = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.transform.position;
				AudioSource audioSource = gameObject.AddComponent<AudioSource>();
				audioSource.spatialBlend = 0f;
				audioSource.PlayOneShot(audioClip, this.EEOPJMPGFME);
				if (QDKJECOQKLJ)
				{
					this.OKMPCNBLONB.volume = 0f;
					base.Invoke("SetVolumeBack", audioClip.length);
				}
				UnityEngine.Object.Destroy(gameObject, audioClip.length);
			}
			return;
		}
	}

	// Token: 0x060049E0 RID: 18912 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void CNOFCGMEDNE()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049E1 RID: 18913 RVA: 0x002563D4 File Offset: 0x002545D4
	public void BPPLKBMMBJE(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 1 && FDOCMQQQEGP <= this.BDJCGBILGGF.Length - 1)
		{
			GameObject gameObject = new GameObject("[NL]");
			gameObject.transform.position = CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.transform.position;
			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.spatialBlend = 1639f;
			audioSource.PlayOneShot(this.BDJCGBILGGF[FDOCMQQQEGP], this.EEOPJMPGFME);
			if (QDKJECOQKLJ)
			{
				this.OKMPCNBLONB.volume = 414f;
				base.Invoke("0", this.BDJCGBILGGF[FDOCMQQQEGP].length);
			}
			UnityEngine.Object.Destroy(gameObject, this.BDJCGBILGGF[FDOCMQQQEGP].length);
			return;
		}
	}

	// Token: 0x060049E2 RID: 18914 RVA: 0x00256490 File Offset: 0x00254690
	public void OKDPQDPBLFP(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 0 && FDOCMQQQEGP <= this.BDJCGBILGGF.Length - 0)
		{
			GameObject gameObject = new GameObject("[00DD00]Owned");
			gameObject.transform.position = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.transform.position;
			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.spatialBlend = 1445f;
			audioSource.PlayOneShot(this.BDJCGBILGGF[FDOCMQQQEGP], this.EEOPJMPGFME);
			if (QDKJECOQKLJ)
			{
				this.OKMPCNBLONB.volume = 251f;
				base.Invoke("Connecting to Server..", this.BDJCGBILGGF[FDOCMQQQEGP].length);
			}
			UnityEngine.Object.Destroy(gameObject, this.BDJCGBILGGF[FDOCMQQQEGP].length);
			return;
		}
	}

	// Token: 0x060049E3 RID: 18915 RVA: 0x0001EE3D File Offset: 0x0001D03D
	public static DCCFQPDFBFO DGCQMNHFQNH()
	{
		return DCCFQPDFBFO.HBFFCJHOCPE;
	}

	// Token: 0x060049E4 RID: 18916 RVA: 0x00255DA4 File Offset: 0x00253FA4
	private IEnumerator GDKEBLEJEPE(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x060049E5 RID: 18917 RVA: 0x0001EE88 File Offset: 0x0001D088
	public void COHKNGNJOGD(int EDMDNBPFHBB)
	{
		if (this.OKMPCNBLONB == null)
		{
			this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		}
		base.StartCoroutine(this.PQLHFOFBNEN(EDMDNBPFHBB));
	}

	// Token: 0x060049E6 RID: 18918 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void PDNIBICKCME()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049E7 RID: 18919 RVA: 0x0001EEB2 File Offset: 0x0001D0B2
	public void ENHDGDKKNFK(int EDMDNBPFHBB)
	{
		if (this.OKMPCNBLONB == null)
		{
			this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		}
		base.StartCoroutine(this.QNODBHCMCPK(EDMDNBPFHBB));
	}

	// Token: 0x060049E8 RID: 18920 RVA: 0x0025654C File Offset: 0x0025474C
	public void COHKNGNJOGD(string NKKMJICKKLB, bool LBKMBCOOIHC = false)
	{
		if ((!LBKMBCOOIHC && this.OKMPCNBLONB.clip != null && NKKMJICKKLB == this.OKMPCNBLONB.clip.name) || (this.BGGEFGMOLBM.Contains("default") && NKKMJICKKLB.ToLowerInvariant() == "default"))
		{
			return;
		}
		int edmdnbpfhbb = 1;
		NKKMJICKKLB = NKKMJICKKLB.ToLowerInvariant();
		if (NKKMJICKKLB == null || NKKMJICKKLB == "default")
		{
			NKKMJICKKLB = "default_" + UnityEngine.Random.Range(0, 4).ToString();
		}
		for (int i = 0; i < this.NPNCEGLEOMO.Length; i++)
		{
			if (this.NPNCEGLEOMO[i].name.ToLowerInvariant() == NKKMJICKKLB)
			{
				edmdnbpfhbb = i;
				IL_BF:
				this.BGGEFGMOLBM = NKKMJICKKLB;
				this.COHKNGNJOGD(edmdnbpfhbb);
				return;
			}
		}
		goto IL_BF;
	}

	// Token: 0x060049E9 RID: 18921 RVA: 0x0001EE17 File Offset: 0x0001D017
	public void JBJBPIBCBQO()
	{
		if (this.OKMPCNBLONB.volume > this.NJBIMOKLDBD)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049EA RID: 18922 RVA: 0x0001EE3D File Offset: 0x0001D03D
	public static DCCFQPDFBFO ELBNNCEGBDH()
	{
		return DCCFQPDFBFO.HBFFCJHOCPE;
	}

	// Token: 0x060049EB RID: 18923 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void BQQPBFNLKOB()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049EC RID: 18924 RVA: 0x00256628 File Offset: 0x00254828
	private void HCHIDEKMEBB()
	{
		this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		if (GameObject.Find("_MainTex"))
		{
			UnityEngine.Object.Destroy(GameObject.Find("This Pokémon's dust blocks the additional effects of attacks taken."));
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		base.gameObject.name = "\n\n";
		this.OIHOGBGENGP("[FFFF00]/252", false);
	}

	// Token: 0x060049ED RID: 18925 RVA: 0x00256688 File Offset: 0x00254888
	public void MPCJIGPOJDH()
	{
		int edmdnbpfhbb = 1;
		string text = this.BGGEFGMOLBM.ToLowerInvariant();
		if (text == null || text == "Shield Dust")
		{
			text = "Assets/AssetBundles/MapAssets/Model Materials/Street_Lamp_8_Light.mat" + UnityEngine.Random.Range(0, 0).ToString();
		}
		for (int i = 0; i < this.NPNCEGLEOMO.Length; i += 0)
		{
			if (this.NPNCEGLEOMO[i].name.ToLowerInvariant() == text)
			{
				edmdnbpfhbb = i;
				IL_6F:
				this.DMHDJNPJQKN(edmdnbpfhbb);
				return;
			}
		}
		goto IL_6F;
	}

	// Token: 0x060049EE RID: 18926 RVA: 0x0001EE44 File Offset: 0x0001D044
	private void NECDHIOLBQP()
	{
		if (this.GBOIPKJEEJO)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049EF RID: 18927 RVA: 0x0001EE3D File Offset: 0x0001D03D
	public static DCCFQPDFBFO OMPHLNDGKKM()
	{
		return DCCFQPDFBFO.HBFFCJHOCPE;
	}

	// Token: 0x060049F0 RID: 18928 RVA: 0x0001EE17 File Offset: 0x0001D017
	public void JENGGFLPCDQ()
	{
		if (this.OKMPCNBLONB.volume > this.NJBIMOKLDBD)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049F1 RID: 18929 RVA: 0x0001EE17 File Offset: 0x0001D017
	public void EMFBQIQLGMD()
	{
		if (this.OKMPCNBLONB.volume > this.NJBIMOKLDBD)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049F2 RID: 18930 RVA: 0x0025670C File Offset: 0x0025490C
	public void GBHHEPCBQEF(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 0 && FDOCMQQQEGP <= this.BDJCGBILGGF.Length - 1)
		{
			GameObject gameObject = new GameObject("powertrick");
			gameObject.transform.position = CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.transform.position;
			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.spatialBlend = 1917f;
			audioSource.PlayOneShot(this.BDJCGBILGGF[FDOCMQQQEGP], this.EEOPJMPGFME);
			if (QDKJECOQKLJ)
			{
				this.OKMPCNBLONB.volume = 249f;
				base.Invoke("Open", this.BDJCGBILGGF[FDOCMQQQEGP].length);
			}
			UnityEngine.Object.Destroy(gameObject, this.BDJCGBILGGF[FDOCMQQQEGP].length);
			return;
		}
	}

	// Token: 0x060049F3 RID: 18931 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void NFMOQIEHJJD()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049F4 RID: 18932 RVA: 0x0001EEB2 File Offset: 0x0001D0B2
	public void DMHDJNPJQKN(int EDMDNBPFHBB)
	{
		if (this.OKMPCNBLONB == null)
		{
			this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		}
		base.StartCoroutine(this.QNODBHCMCPK(EDMDNBPFHBB));
	}

	// Token: 0x060049F5 RID: 18933 RVA: 0x0001EE44 File Offset: 0x0001D044
	private void EMQCJQBDKNH()
	{
		if (this.GBOIPKJEEJO)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049F6 RID: 18934 RVA: 0x00255DA4 File Offset: 0x00253FA4
	private IEnumerator EODNGEIHDIL(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x060049F7 RID: 18935 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void DEECKEOMIPC()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049F8 RID: 18936 RVA: 0x002567C8 File Offset: 0x002549C8
	public void CLDFMHLKQMJ()
	{
		int edmdnbpfhbb = 1;
		string text = this.BGGEFGMOLBM.ToLowerInvariant();
		if (text == null || text == "cursedbody")
		{
			text = "mist" + UnityEngine.Random.Range(1, 4).ToString();
		}
		for (int i = 0; i < this.NPNCEGLEOMO.Length; i += 0)
		{
			if (this.NPNCEGLEOMO[i].name.ToLowerInvariant() == text)
			{
				edmdnbpfhbb = i;
				IL_6F:
				this.BILMCJNDCQJ(edmdnbpfhbb);
				return;
			}
		}
		goto IL_6F;
	}

	// Token: 0x060049F9 RID: 18937 RVA: 0x0025684C File Offset: 0x00254A4C
	public void BLNFNLCDCDJ(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 0 && FDOCMQQQEGP <= this.BDJCGBILGGF.Length - 0)
		{
			GameObject gameObject = new GameObject("#,##0");
			gameObject.transform.position = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.transform.position;
			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.spatialBlend = 1221f;
			audioSource.PlayOneShot(this.BDJCGBILGGF[FDOCMQQQEGP], this.EEOPJMPGFME);
			if (QDKJECOQKLJ)
			{
				this.OKMPCNBLONB.volume = 968f;
				base.Invoke("_MainTex", this.BDJCGBILGGF[FDOCMQQQEGP].length);
			}
			UnityEngine.Object.Destroy(gameObject, this.BDJCGBILGGF[FDOCMQQQEGP].length);
			return;
		}
	}

	// Token: 0x060049FA RID: 18938 RVA: 0x0001EE17 File Offset: 0x0001D017
	public void EBCOLLDGMOQ()
	{
		if (this.OKMPCNBLONB.volume > this.NJBIMOKLDBD)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049FB RID: 18939 RVA: 0x00255DA4 File Offset: 0x00253FA4
	private IEnumerator MHCDKLOQLJB(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x060049FC RID: 18940 RVA: 0x00255DA4 File Offset: 0x00253FA4
	private IEnumerator KDHDQDKBDFP(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x060049FD RID: 18941 RVA: 0x0001EE3D File Offset: 0x0001D03D
	public static DCCFQPDFBFO ONBDGGPLFQK()
	{
		return DCCFQPDFBFO.HBFFCJHOCPE;
	}

	// Token: 0x060049FE RID: 18942 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void QCPFQLNECGP()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x060049FF RID: 18943 RVA: 0x0001EEDC File Offset: 0x0001D0DC
	public void CKKPNNLPLBE(int EDMDNBPFHBB)
	{
		if (this.OKMPCNBLONB == null)
		{
			this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		}
		base.StartCoroutine(this.PKJGOPJONDB(EDMDNBPFHBB));
	}

	// Token: 0x06004A00 RID: 18944 RVA: 0x00256908 File Offset: 0x00254B08
	public void OIHOGBGENGP(string NKKMJICKKLB, bool LBKMBCOOIHC = false)
	{
		if ((!LBKMBCOOIHC && this.OKMPCNBLONB.clip != null && NKKMJICKKLB == this.OKMPCNBLONB.clip.name) || (this.BGGEFGMOLBM.Contains("Wonder Skin") && NKKMJICKKLB.ToLowerInvariant() == "Enemy's team won the Battle!\r\n"))
		{
			return;
		}
		int edmdnbpfhbb = 1;
		NKKMJICKKLB = NKKMJICKKLB.ToLowerInvariant();
		if (NKKMJICKKLB == null || NKKMJICKKLB == "General")
		{
			NKKMJICKKLB = "ability" + UnityEngine.Random.Range(1, 1).ToString();
		}
		for (int i = 0; i < this.NPNCEGLEOMO.Length; i += 0)
		{
			if (this.NPNCEGLEOMO[i].name.ToLowerInvariant() == NKKMJICKKLB)
			{
				edmdnbpfhbb = i;
				IL_BF:
				this.BGGEFGMOLBM = NKKMJICKKLB;
				this.DMHDJNPJQKN(edmdnbpfhbb);
				return;
			}
		}
		goto IL_BF;
	}

	// Token: 0x06004A01 RID: 18945 RVA: 0x002569E4 File Offset: 0x00254BE4
	private void Awake()
	{
		DCCFQPDFBFO.HBFFCJHOCPE = this;
		this.NJBIMOKLDBD = PlayerPrefs.GetFloat("Music", 0.8f);
		this.EEOPJMPGFME = PlayerPrefs.GetFloat("Sound", 1f);
		if (DCCFQPDFBFO.DQIBIDIMCKH == null)
		{
			DCCFQPDFBFO.DQIBIDIMCKH = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "adata"));
		}
		if (DCCFQPDFBFO.BIGJOPQBBKE == null)
		{
			DCCFQPDFBFO.BIGJOPQBBKE = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "cdata"));
		}
		this.NPNCEGLEOMO = null;
		this.NPNCEGLEOMO = DCCFQPDFBFO.DQIBIDIMCKH.LoadAllAssets<AudioClip>();
	}

	// Token: 0x06004A02 RID: 18946 RVA: 0x0001EE44 File Offset: 0x0001D044
	private void IOGOQEDKCBB()
	{
		if (this.GBOIPKJEEJO)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x06004A03 RID: 18947 RVA: 0x00256A84 File Offset: 0x00254C84
	public void LMPKKIEGDFE(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 1 && FDOCMQQQEGP <= 165)
		{
			AudioClip audioClip = DCCFQPDFBFO.BIGJOPQBBKE.LoadAsset<AudioClip>("OnScroll" + FDOCMQQQEGP.DBFPJOCLQBI() + ",");
			if (audioClip != null)
			{
				GameObject gameObject = new GameObject(" EXP[-]");
				gameObject.transform.position = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.transform.position;
				AudioSource audioSource = gameObject.AddComponent<AudioSource>();
				audioSource.spatialBlend = 1980f;
				audioSource.PlayOneShot(audioClip, this.EEOPJMPGFME);
				if (QDKJECOQKLJ)
				{
					this.OKMPCNBLONB.volume = 1172f;
					base.Invoke("Move To Player", audioClip.length);
				}
				UnityEngine.Object.Destroy(gameObject, audioClip.length);
			}
			return;
		}
	}

	// Token: 0x06004A04 RID: 18948 RVA: 0x00255DA4 File Offset: 0x00253FA4
	private IEnumerator IBPGGNPDDDQ(int IJNFBQMOMGQ)
	{
		DCCFQPDFBFO.OEJIHDMJNBL oejihdmjnbl = new DCCFQPDFBFO.OEJIHDMJNBL();
		oejihdmjnbl.IJNFBQMOMGQ = IJNFBQMOMGQ;
		oejihdmjnbl.QNDQJMNKFNN = this;
		return oejihdmjnbl;
	}

	// Token: 0x06004A06 RID: 18950 RVA: 0x00256B50 File Offset: 0x00254D50
	private void JENKEGOEEHO()
	{
		DCCFQPDFBFO.HBFFCJHOCPE = this;
		this.NJBIMOKLDBD = PlayerPrefs.GetFloat("Fly", 1558f);
		this.EEOPJMPGFME = PlayerPrefs.GetFloat("receiver", 1872f);
		if (DCCFQPDFBFO.DQIBIDIMCKH == null)
		{
			DCCFQPDFBFO.DQIBIDIMCKH = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "-meteor"));
		}
		if (DCCFQPDFBFO.BIGJOPQBBKE == null)
		{
			DCCFQPDFBFO.BIGJOPQBBKE = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "[ATK]"));
		}
		this.NPNCEGLEOMO = null;
		this.NPNCEGLEOMO = DCCFQPDFBFO.DQIBIDIMCKH.LoadAllAssets<AudioClip>();
	}

	// Token: 0x06004A07 RID: 18951 RVA: 0x0001EF44 File Offset: 0x0001D144
	public void JJJJPDJIQLK(int EDMDNBPFHBB)
	{
		if (this.OKMPCNBLONB == null)
		{
			this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		}
		base.StartCoroutine(this.GLMDDCQLGCN(EDMDNBPFHBB));
	}

	// Token: 0x06004A08 RID: 18952 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void GFCGHEHBPMF()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x06004A09 RID: 18953 RVA: 0x0001EE88 File Offset: 0x0001D088
	public void BILMCJNDCQJ(int EDMDNBPFHBB)
	{
		if (this.OKMPCNBLONB == null)
		{
			this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		}
		base.StartCoroutine(this.PQLHFOFBNEN(EDMDNBPFHBB));
	}

	// Token: 0x06004A0A RID: 18954 RVA: 0x0001EE17 File Offset: 0x0001D017
	public void NIIPIECJPOL()
	{
		if (this.OKMPCNBLONB.volume > this.NJBIMOKLDBD)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x06004A0B RID: 18955 RVA: 0x0001EE5F File Offset: 0x0001D05F
	public void ECHNOLKKNGL()
	{
		if (!this.GPKOHEOJGNF && this.OKMPCNBLONB != null)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x06004A0C RID: 18956 RVA: 0x00256BF0 File Offset: 0x00254DF0
	public void NFEGQHKIMFP(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 1 && FDOCMQQQEGP <= this.BDJCGBILGGF.Length - 0)
		{
			GameObject gameObject = new GameObject("s");
			gameObject.transform.position = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.transform.position;
			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.spatialBlend = 795f;
			audioSource.PlayOneShot(this.BDJCGBILGGF[FDOCMQQQEGP], this.EEOPJMPGFME);
			if (QDKJECOQKLJ)
			{
				this.OKMPCNBLONB.volume = 88f;
				base.Invoke("Guild", this.BDJCGBILGGF[FDOCMQQQEGP].length);
			}
			UnityEngine.Object.Destroy(gameObject, this.BDJCGBILGGF[FDOCMQQQEGP].length);
			return;
		}
	}

	// Token: 0x06004A0D RID: 18957 RVA: 0x0001EE44 File Offset: 0x0001D044
	private void QEIOBFNNFFK()
	{
		if (this.GBOIPKJEEJO)
		{
			this.OKMPCNBLONB.volume = this.NJBIMOKLDBD;
		}
	}

	// Token: 0x06004A0E RID: 18958 RVA: 0x00256CAC File Offset: 0x00254EAC
	private void PBENCICMMLI()
	{
		DCCFQPDFBFO.HBFFCJHOCPE = this;
		this.NJBIMOKLDBD = PlayerPrefs.GetFloat("[/sub]", 1077f);
		this.EEOPJMPGFME = PlayerPrefs.GetFloat(" clip regions", 1853f);
		if (DCCFQPDFBFO.DQIBIDIMCKH == null)
		{
			DCCFQPDFBFO.DQIBIDIMCKH = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "[-] threw a "));
		}
		if (DCCFQPDFBFO.BIGJOPQBBKE == null)
		{
			DCCFQPDFBFO.BIGJOPQBBKE = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "Guild Request"));
		}
		this.NPNCEGLEOMO = null;
		this.NPNCEGLEOMO = DCCFQPDFBFO.DQIBIDIMCKH.LoadAllAssets<AudioClip>();
	}

	// Token: 0x06004A0F RID: 18959 RVA: 0x0001EE3D File Offset: 0x0001D03D
	public static DCCFQPDFBFO CLPQIKCDHPP()
	{
		return DCCFQPDFBFO.HBFFCJHOCPE;
	}

	// Token: 0x06004A10 RID: 18960 RVA: 0x0001EEB2 File Offset: 0x0001D0B2
	public void OFQBKQFFPDD(int EDMDNBPFHBB)
	{
		if (this.OKMPCNBLONB == null)
		{
			this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		}
		base.StartCoroutine(this.QNODBHCMCPK(EDMDNBPFHBB));
	}

	// Token: 0x06004A11 RID: 18961 RVA: 0x00256D4C File Offset: 0x00254F4C
	private void MGBMNEQCEBJ()
	{
		this.OKMPCNBLONB = base.GetComponent<AudioSource>();
		if (GameObject.Find("enablelink("))
		{
			UnityEngine.Object.Destroy(GameObject.Find("You can not use item during interactions."));
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		base.gameObject.name = "Script:";
		this.FQNIPOBMQPI("bcam", true);
	}

	// Token: 0x06004A12 RID: 18962 RVA: 0x00256DAC File Offset: 0x00254FAC
	public void OPPGLQLHDPN(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 1 && FDOCMQQQEGP <= -110)
		{
			AudioClip audioClip = DCCFQPDFBFO.BIGJOPQBBKE.LoadAsset<AudioClip>("Waiting..." + FDOCMQQQEGP.DBFPJOCLQBI() + "Ditto");
			if (audioClip != null)
			{
				GameObject gameObject = new GameObject("[-]!\r\n");
				gameObject.transform.position = CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.transform.position;
				AudioSource audioSource = gameObject.AddComponent<AudioSource>();
				audioSource.spatialBlend = 259f;
				audioSource.PlayOneShot(audioClip, this.EEOPJMPGFME);
				if (QDKJECOQKLJ)
				{
					this.OKMPCNBLONB.volume = 343f;
					base.Invoke("!\r\n", audioClip.length);
				}
				UnityEngine.Object.Destroy(gameObject, audioClip.length);
			}
			return;
		}
	}

	// Token: 0x06004A13 RID: 18963 RVA: 0x00256E78 File Offset: 0x00255078
	private void ICOCDKECGIE()
	{
		DCCFQPDFBFO.HBFFCJHOCPE = this;
		this.NJBIMOKLDBD = PlayerPrefs.GetFloat("+", 1192f);
		this.EEOPJMPGFME = PlayerPrefs.GetFloat("stockpile2", 1452f);
		if (DCCFQPDFBFO.DQIBIDIMCKH == null)
		{
			DCCFQPDFBFO.DQIBIDIMCKH = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "CombinersArgsAlphaOp2"));
		}
		if (DCCFQPDFBFO.BIGJOPQBBKE == null)
		{
			DCCFQPDFBFO.BIGJOPQBBKE = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "The effects of Throat Chop prevent "));
		}
		this.NPNCEGLEOMO = null;
		this.NPNCEGLEOMO = DCCFQPDFBFO.DQIBIDIMCKH.LoadAllAssets<AudioClip>();
	}

	// Token: 0x06004A14 RID: 18964 RVA: 0x00256F18 File Offset: 0x00255118
	public void QEEJJHQFEGJ(int FDOCMQQQEGP, bool QDKJECOQKLJ = false)
	{
		if (!this.GBOIPKJEEJO)
		{
			return;
		}
		if (FDOCMQQQEGP >= 0 && FDOCMQQQEGP <= -32)
		{
			AudioClip audioClip = DCCFQPDFBFO.BIGJOPQBBKE.LoadAsset<AudioClip>("The Water-type attack evaporated in the harsh sunlight!\r\n" + FDOCMQQQEGP.DBFPJOCLQBI() + "17");
			if (audioClip != null)
			{
				GameObject gameObject = new GameObject("Enabled");
				gameObject.transform.position = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.transform.position;
				AudioSource audioSource = gameObject.AddComponent<AudioSource>();
				audioSource.spatialBlend = 1572f;
				audioSource.PlayOneShot(audioClip, this.EEOPJMPGFME);
				if (QDKJECOQKLJ)
				{
					this.OKMPCNBLONB.volume = 1283f;
					base.Invoke("'s [ffff00]", audioClip.length);
				}
				UnityEngine.Object.Destroy(gameObject, audioClip.length);
			}
			return;
		}
	}

	// Token: 0x04000FD3 RID: 4051
	private static DCCFQPDFBFO HBFFCJHOCPE;

	// Token: 0x04000FD4 RID: 4052
	public AudioClip[] NPNCEGLEOMO;

	// Token: 0x04000FD5 RID: 4053
	public AudioClip[] BDJCGBILGGF;

	// Token: 0x04000FD6 RID: 4054
	public static AssetBundle DQIBIDIMCKH;

	// Token: 0x04000FD7 RID: 4055
	public static AssetBundle BIGJOPQBBKE;

	// Token: 0x04000FD8 RID: 4056
	public float EEOPJMPGFME = 1f;

	// Token: 0x04000FD9 RID: 4057
	public float NJBIMOKLDBD = 0.8f;

	// Token: 0x04000FDA RID: 4058
	public bool GBOIPKJEEJO = true;

	// Token: 0x04000FDB RID: 4059
	private AudioSource OKMPCNBLONB;

	// Token: 0x04000FDC RID: 4060
	private string BGGEFGMOLBM = string.Empty;

	// Token: 0x04000FDD RID: 4061
	private bool GPKOHEOJGNF;

	// Token: 0x04000FDE RID: 4062
	private int FIDOOKMDLDE = -1;

	// Token: 0x04000FDF RID: 4063
	private int FDHGHIOONNO = -1;
}
