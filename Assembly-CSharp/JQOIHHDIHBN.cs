using System;
using PSXAPI.Response;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x02000198 RID: 408
public class JQOIHHDIHBN : MonoBehaviour
{
	// Token: 0x0600333C RID: 13116 RVA: 0x00186090 File Offset: 0x00184290
	public void KHPMDBMNCGC(bool NPODEKJKOII)
	{
		this.FEKENKHMOIK = NPODEKJKOII;
		if (NPODEKJKOII)
		{
			this.ENLBIQODMCC.nearClipPlane = 0.1f;
			this.ENLBIQODMCC.farClipPlane = 55f;
			this.ENLBIQODMCC.orthographic = false;
		}
		else
		{
			this.ENLBIQODMCC.orthographic = true;
			this.ENLBIQODMCC.nearClipPlane = 0f;
			this.ENLBIQODMCC.farClipPlane = 80f;
		}
		this.MOHHNKNPKLE();
	}

	// Token: 0x0600333D RID: 13117 RVA: 0x00016CEF File Offset: 0x00014EEF
	public static JQOIHHDIHBN GFJGPNOPEPC()
	{
		return JQOIHHDIHBN.HBFFCJHOCPE;
	}

	// Token: 0x0600333E RID: 13118 RVA: 0x00016CF6 File Offset: 0x00014EF6
	private void Start()
	{
		this.PDDEIHNJOGE = base.transform;
		this.EFOQFENPFHO = this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.settings;
		this.ENLBIQODMCC = base.GetComponent<Camera>();
	}

	// Token: 0x0600333F RID: 13119 RVA: 0x00016D2B File Offset: 0x00014F2B
	private void JHQCMGKJCCI()
	{
		this.PDDEIHNJOGE = base.transform;
		this.EFOQFENPFHO = this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.DCBJMHJEFMG();
		this.ENLBIQODMCC = base.GetComponent<Camera>();
	}

	// Token: 0x06003340 RID: 13120 RVA: 0x00186108 File Offset: 0x00184308
	public void MOHHNKNPKLE()
	{
		if (!this.FEKENKHMOIK)
		{
			this.KDMKDDDNBGL = this.KPGQFHGNGOP;
			base.transform.eulerAngles = new Vector3(45f, 0f, 0f);
			this.ENLBIQODMCC.nearClipPlane = 0f;
			this.ENLBIQODMCC.farClipPlane = 80f;
		}
		else if (this.LIQLFCKICLQ.LIQLFCKICLQ != null)
		{
			this.ENLBIQODMCC.nearClipPlane = 0.1f;
			this.ENLBIQODMCC.farClipPlane = 55f;
			this.GDMIEPEBGJI = this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors;
			if (this.GDMIEPEBGJI)
			{
				this.KDMKDDDNBGL = this.JKEJFDODEPN;
				base.transform.eulerAngles = new Vector3(45f, 0f, 0f);
			}
			else
			{
				this.KDMKDDDNBGL = this.BEPPQCJJPPD;
				base.transform.eulerAngles = new Vector3(45f, 0f, 0f);
			}
		}
		this.PDDEIHNJOGE.position = this.JILENMCJCHF.position + this.KDMKDDDNBGL;
	}

	// Token: 0x06003341 RID: 13121 RVA: 0x00016D60 File Offset: 0x00014F60
	public void EEQIIJPCCKM(bool CBNDPKQNBCN)
	{
		this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.enabled = CBNDPKQNBCN;
	}

	// Token: 0x06003342 RID: 13122 RVA: 0x0018623C File Offset: 0x0018443C
	public void JJQPJNHNIBG()
	{
		if (!this.FEKENKHMOIK)
		{
			this.KDMKDDDNBGL = this.KPGQFHGNGOP;
			base.transform.eulerAngles = new Vector3(481f, 395f, 1011f);
			this.ENLBIQODMCC.nearClipPlane = 1831f;
			this.ENLBIQODMCC.farClipPlane = 560f;
		}
		else if (this.LIQLFCKICLQ.LIQLFCKICLQ != null)
		{
			this.ENLBIQODMCC.nearClipPlane = 704f;
			this.ENLBIQODMCC.farClipPlane = 278f;
			this.GDMIEPEBGJI = this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors;
			if (this.GDMIEPEBGJI)
			{
				this.KDMKDDDNBGL = this.JKEJFDODEPN;
				base.transform.eulerAngles = new Vector3(663f, 429f, 1003f);
			}
			else
			{
				this.KDMKDDDNBGL = this.BEPPQCJJPPD;
				base.transform.eulerAngles = new Vector3(1256f, 176f, 1614f);
			}
		}
		this.PDDEIHNJOGE.position = this.JILENMCJCHF.position + this.KDMKDDDNBGL;
	}

	// Token: 0x06003343 RID: 13123 RVA: 0x00016D78 File Offset: 0x00014F78
	public void HCMEBHBGEHE(bool CBNDPKQNBCN)
	{
		this.KBOHFDLMMBM.MQPNOMLJGKF.ambientOcclusion.enabled = CBNDPKQNBCN;
	}

	// Token: 0x06003344 RID: 13124 RVA: 0x00016D90 File Offset: 0x00014F90
	public void QGIIDDOHCEM()
	{
		this.PDDEIHNJOGE.position = this.JILENMCJCHF.position + this.KDMKDDDNBGL;
	}

	// Token: 0x06003345 RID: 13125 RVA: 0x00016DB3 File Offset: 0x00014FB3
	private void PIQDBCGQDCH()
	{
		this.PDDEIHNJOGE.position = Vector3.Lerp(this.PDDEIHNJOGE.position, this.JILENMCJCHF.position + this.KDMKDDDNBGL, this.KDEMMJKGDJM * UnityEngine.Time.deltaTime);
	}

	// Token: 0x06003346 RID: 13126 RVA: 0x00186370 File Offset: 0x00184570
	public void MOPNHMMKKEL()
	{
		if (!this.FEKENKHMOIK)
		{
			this.KDMKDDDNBGL = this.KPGQFHGNGOP;
			base.transform.eulerAngles = new Vector3(1296f, 1162f, 160f);
			this.ENLBIQODMCC.nearClipPlane = 68f;
			this.ENLBIQODMCC.farClipPlane = 1398f;
		}
		else if (this.LIQLFCKICLQ.LIQLFCKICLQ != null)
		{
			this.ENLBIQODMCC.nearClipPlane = 1804f;
			this.ENLBIQODMCC.farClipPlane = 1582f;
			this.GDMIEPEBGJI = this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors;
			if (this.GDMIEPEBGJI)
			{
				this.KDMKDDDNBGL = this.JKEJFDODEPN;
				base.transform.eulerAngles = new Vector3(991f, 395f, 1537f);
			}
			else
			{
				this.KDMKDDDNBGL = this.BEPPQCJJPPD;
				base.transform.eulerAngles = new Vector3(1340f, 1209f, 62f);
			}
		}
		this.PDDEIHNJOGE.position = this.JILENMCJCHF.position + this.KDMKDDDNBGL;
	}

	// Token: 0x17000238 RID: 568
	// (get) Token: 0x06003347 RID: 13127 RVA: 0x00016CEF File Offset: 0x00014EEF
	public static JQOIHHDIHBN QOQONHOOLNE
	{
		get
		{
			return JQOIHHDIHBN.HBFFCJHOCPE;
		}
	}

	// Token: 0x06003348 RID: 13128 RVA: 0x00016DF2 File Offset: 0x00014FF2
	private void PNJGKKPBDEB()
	{
		JQOIHHDIHBN.HBFFCJHOCPE = this;
	}

	// Token: 0x06003349 RID: 13129 RVA: 0x00016DFA File Offset: 0x00014FFA
	private void KPKQNOCFGIB()
	{
		this.PDDEIHNJOGE = base.transform;
		this.EFOQFENPFHO = this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.OILMJDEQKHM();
		this.ENLBIQODMCC = base.GetComponent<Camera>();
	}

	// Token: 0x0600334A RID: 13130 RVA: 0x00016D78 File Offset: 0x00014F78
	public void JGBBPFKCMEN(bool CBNDPKQNBCN)
	{
		this.KBOHFDLMMBM.MQPNOMLJGKF.ambientOcclusion.enabled = CBNDPKQNBCN;
	}

	// Token: 0x0600334B RID: 13131 RVA: 0x00016DB3 File Offset: 0x00014FB3
	private void BJFCILIPEMI()
	{
		this.PDDEIHNJOGE.position = Vector3.Lerp(this.PDDEIHNJOGE.position, this.JILENMCJCHF.position + this.KDMKDDDNBGL, this.KDEMMJKGDJM * UnityEngine.Time.deltaTime);
	}

	// Token: 0x0600334C RID: 13132 RVA: 0x00016DB3 File Offset: 0x00014FB3
	private void Update()
	{
		this.PDDEIHNJOGE.position = Vector3.Lerp(this.PDDEIHNJOGE.position, this.JILENMCJCHF.position + this.KDMKDDDNBGL, this.KDEMMJKGDJM * UnityEngine.Time.deltaTime);
	}

	// Token: 0x0600334D RID: 13133 RVA: 0x001864A4 File Offset: 0x001846A4
	public void EEJKLBOHOBH()
	{
		if (!this.FEKENKHMOIK)
		{
			this.KDMKDDDNBGL = this.KPGQFHGNGOP;
			base.transform.eulerAngles = new Vector3(1809f, 1405f, 103f);
			this.ENLBIQODMCC.nearClipPlane = 1066f;
			this.ENLBIQODMCC.farClipPlane = 1475f;
		}
		else if (this.LIQLFCKICLQ.LIQLFCKICLQ != null)
		{
			this.ENLBIQODMCC.nearClipPlane = 1958f;
			this.ENLBIQODMCC.farClipPlane = 1814f;
			this.GDMIEPEBGJI = this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors;
			if (this.GDMIEPEBGJI)
			{
				this.KDMKDDDNBGL = this.JKEJFDODEPN;
				base.transform.eulerAngles = new Vector3(1345f, 416f, 1731f);
			}
			else
			{
				this.KDMKDDDNBGL = this.BEPPQCJJPPD;
				base.transform.eulerAngles = new Vector3(1673f, 1567f, 1306f);
			}
		}
		this.PDDEIHNJOGE.position = this.JILENMCJCHF.position + this.KDMKDDDNBGL;
	}

	// Token: 0x0600334E RID: 13134 RVA: 0x001865D8 File Offset: 0x001847D8
	public void QKDQEDFIEOH()
	{
		if (this.LIQLFCKICLQ.LIQLFCKICLQ != null)
		{
			if (!this.FEKENKHMOIK)
			{
				this.KDMKDDDNBGL = this.KPGQFHGNGOP;
			}
			else if (this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors != this.GDMIEPEBGJI)
			{
				this.GDMIEPEBGJI = this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors;
				if (this.GDMIEPEBGJI)
				{
					this.KDMKDDDNBGL = this.JKEJFDODEPN;
					base.transform.eulerAngles = new Vector3(746f, 429f, 394f);
				}
				else
				{
					this.KDMKDDDNBGL = this.BEPPQCJJPPD;
					base.transform.eulerAngles = new Vector3(1831f, 498f, 845f);
				}
			}
			if (!this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors && !this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Cave && !this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Dark)
			{
				if (this.LIQLFCKICLQ.JEMKIKEMFPB == GameDayTime.Night)
				{
					if (this.QMDONJGIKDQ != 78f)
					{
						this.QMDONJGIKDQ = 1030f;
						this.EFOQFENPFHO.bloom.intensity = 332f;
						this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.DGLGPOBMNLQ(this.EFOQFENPFHO);
					}
				}
				else if (this.LIQLFCKICLQ.JEMKIKEMFPB == (GameDayTime)8)
				{
					if (this.QMDONJGIKDQ != 1734f)
					{
						this.QMDONJGIKDQ = 1611f;
						this.EFOQFENPFHO.bloom.intensity = 1761f;
						this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.FBHPICJCHLD(this.EFOQFENPFHO);
					}
				}
				else if (this.LIQLFCKICLQ.JEMKIKEMFPB == GameDayTime.Morning)
				{
					if (this.QMDONJGIKDQ != 877f)
					{
						this.QMDONJGIKDQ = 377f;
						this.EFOQFENPFHO.bloom.intensity = 736f;
						this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.settings = this.EFOQFENPFHO;
					}
				}
				else if (this.QMDONJGIKDQ != 697f)
				{
					this.QMDONJGIKDQ = 895f;
					this.EFOQFENPFHO.bloom.intensity = 1268f;
					this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.EOONHGFEMDO(this.EFOQFENPFHO);
				}
			}
			else if (this.QMDONJGIKDQ != 413f)
			{
				this.QMDONJGIKDQ = 216f;
				this.EFOQFENPFHO.bloom.intensity = 485f;
				this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.EOONHGFEMDO(this.EFOQFENPFHO);
			}
		}
	}

	// Token: 0x0600334F RID: 13135 RVA: 0x00016D60 File Offset: 0x00014F60
	public void ELQCCCEQDHD(bool CBNDPKQNBCN)
	{
		this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.enabled = CBNDPKQNBCN;
	}

	// Token: 0x06003350 RID: 13136 RVA: 0x001868A4 File Offset: 0x00184AA4
	public void DHHEBDMNPIC()
	{
		if (!this.FEKENKHMOIK)
		{
			this.KDMKDDDNBGL = this.KPGQFHGNGOP;
			base.transform.eulerAngles = new Vector3(608f, 1718f, 835f);
			this.ENLBIQODMCC.nearClipPlane = 405f;
			this.ENLBIQODMCC.farClipPlane = 900f;
		}
		else if (this.LIQLFCKICLQ.LIQLFCKICLQ != null)
		{
			this.ENLBIQODMCC.nearClipPlane = 906f;
			this.ENLBIQODMCC.farClipPlane = 1782f;
			this.GDMIEPEBGJI = this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors;
			if (this.GDMIEPEBGJI)
			{
				this.KDMKDDDNBGL = this.JKEJFDODEPN;
				base.transform.eulerAngles = new Vector3(365f, 1437f, 657f);
			}
			else
			{
				this.KDMKDDDNBGL = this.BEPPQCJJPPD;
				base.transform.eulerAngles = new Vector3(653f, 360f, 1634f);
			}
		}
		this.PDDEIHNJOGE.position = this.JILENMCJCHF.position + this.KDMKDDDNBGL;
	}

	// Token: 0x06003351 RID: 13137 RVA: 0x001869D8 File Offset: 0x00184BD8
	public void LateUpdate()
	{
		if (this.LIQLFCKICLQ.LIQLFCKICLQ != null)
		{
			if (!this.FEKENKHMOIK)
			{
				this.KDMKDDDNBGL = this.KPGQFHGNGOP;
			}
			else if (this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors != this.GDMIEPEBGJI)
			{
				this.GDMIEPEBGJI = this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors;
				if (this.GDMIEPEBGJI)
				{
					this.KDMKDDDNBGL = this.JKEJFDODEPN;
					base.transform.eulerAngles = new Vector3(45f, 0f, 0f);
				}
				else
				{
					this.KDMKDDDNBGL = this.BEPPQCJJPPD;
					base.transform.eulerAngles = new Vector3(45f, 0f, 0f);
				}
			}
			if (!this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Indoors && !this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Cave && !this.LIQLFCKICLQ.LIQLFCKICLQ.Settings.Dark)
			{
				if (this.LIQLFCKICLQ.JEMKIKEMFPB == GameDayTime.Night)
				{
					if (this.QMDONJGIKDQ != 0.25f)
					{
						this.QMDONJGIKDQ = 0.25f;
						this.EFOQFENPFHO.bloom.intensity = 0.25f;
						this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.settings = this.EFOQFENPFHO;
					}
				}
				else if (this.LIQLFCKICLQ.JEMKIKEMFPB == GameDayTime.Evening)
				{
					if (this.QMDONJGIKDQ != 0.2f)
					{
						this.QMDONJGIKDQ = 0.2f;
						this.EFOQFENPFHO.bloom.intensity = 0.2f;
						this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.settings = this.EFOQFENPFHO;
					}
				}
				else if (this.LIQLFCKICLQ.JEMKIKEMFPB == GameDayTime.Morning)
				{
					if (this.QMDONJGIKDQ != 0.15f)
					{
						this.QMDONJGIKDQ = 0.15f;
						this.EFOQFENPFHO.bloom.intensity = 0.15f;
						this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.settings = this.EFOQFENPFHO;
					}
				}
				else if (this.QMDONJGIKDQ != 0.1f)
				{
					this.QMDONJGIKDQ = 0.1f;
					this.EFOQFENPFHO.bloom.intensity = 0.1f;
					this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.settings = this.EFOQFENPFHO;
				}
			}
			else if (this.QMDONJGIKDQ != 0.15f)
			{
				this.QMDONJGIKDQ = 0.15f;
				this.EFOQFENPFHO.bloom.intensity = 0.15f;
				this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.settings = this.EFOQFENPFHO;
			}
		}
	}

	// Token: 0x06003352 RID: 13138 RVA: 0x00186CA4 File Offset: 0x00184EA4
	public void PIHMFKPIHGH(bool NPODEKJKOII)
	{
		this.FEKENKHMOIK = NPODEKJKOII;
		if (NPODEKJKOII)
		{
			this.ENLBIQODMCC.nearClipPlane = 1032f;
			this.ENLBIQODMCC.farClipPlane = 1098f;
			this.ENLBIQODMCC.orthographic = true;
		}
		else
		{
			this.ENLBIQODMCC.orthographic = true;
			this.ENLBIQODMCC.nearClipPlane = 492f;
			this.ENLBIQODMCC.farClipPlane = 1305f;
		}
		this.DHHEBDMNPIC();
	}

	// Token: 0x06003353 RID: 13139 RVA: 0x00016D90 File Offset: 0x00014F90
	public void LMLMEHQHQPQ()
	{
		this.PDDEIHNJOGE.position = this.JILENMCJCHF.position + this.KDMKDDDNBGL;
	}

	// Token: 0x06003354 RID: 13140 RVA: 0x00016DF2 File Offset: 0x00014FF2
	private void CGGDNNKBIJC()
	{
		JQOIHHDIHBN.HBFFCJHOCPE = this;
	}

	// Token: 0x06003355 RID: 13141 RVA: 0x00016D60 File Offset: 0x00014F60
	public void GONOKHFOOBP(bool CBNDPKQNBCN)
	{
		this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.enabled = CBNDPKQNBCN;
	}

	// Token: 0x06003356 RID: 13142 RVA: 0x00016CF6 File Offset: 0x00014EF6
	private void JDLQNCEDMPI()
	{
		this.PDDEIHNJOGE = base.transform;
		this.EFOQFENPFHO = this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.settings;
		this.ENLBIQODMCC = base.GetComponent<Camera>();
	}

	// Token: 0x06003357 RID: 13143 RVA: 0x00016CEF File Offset: 0x00014EEF
	public static JQOIHHDIHBN BJLGEDCPENQ()
	{
		return JQOIHHDIHBN.HBFFCJHOCPE;
	}

	// Token: 0x06003358 RID: 13144 RVA: 0x00016D78 File Offset: 0x00014F78
	public void LDIMJKNQBPB(bool CBNDPKQNBCN)
	{
		this.KBOHFDLMMBM.MQPNOMLJGKF.ambientOcclusion.enabled = CBNDPKQNBCN;
	}

	// Token: 0x06003359 RID: 13145 RVA: 0x00016D90 File Offset: 0x00014F90
	public void JEFHGMOKOHI()
	{
		this.PDDEIHNJOGE.position = this.JILENMCJCHF.position + this.KDMKDDDNBGL;
	}

	// Token: 0x0600335B RID: 13147 RVA: 0x00016D60 File Offset: 0x00014F60
	public void LKIGEOOBLID(bool CBNDPKQNBCN)
	{
		this.KBOHFDLMMBM.MQPNOMLJGKF.bloom.enabled = CBNDPKQNBCN;
	}

	// Token: 0x0600335C RID: 13148 RVA: 0x00016D90 File Offset: 0x00014F90
	public void BHFPMMKFCLD()
	{
		this.PDDEIHNJOGE.position = this.JILENMCJCHF.position + this.KDMKDDDNBGL;
	}

	// Token: 0x0600335D RID: 13149 RVA: 0x00016DF2 File Offset: 0x00014FF2
	private void Awake()
	{
		JQOIHHDIHBN.HBFFCJHOCPE = this;
	}

	// Token: 0x04000BBF RID: 3007
	private static JQOIHHDIHBN HBFFCJHOCPE;

	// Token: 0x04000BC0 RID: 3008
	private Transform PDDEIHNJOGE;

	// Token: 0x04000BC1 RID: 3009
	public Vector3 BEPPQCJJPPD;

	// Token: 0x04000BC2 RID: 3010
	public Vector3 JKEJFDODEPN;

	// Token: 0x04000BC3 RID: 3011
	public Vector3 KPGQFHGNGOP;

	// Token: 0x04000BC4 RID: 3012
	public bool FEKENKHMOIK = true;

	// Token: 0x04000BC5 RID: 3013
	public Camera ENLBIQODMCC;

	// Token: 0x04000BC6 RID: 3014
	public float QGBLOPMKLMP = 64f;

	// Token: 0x04000BC7 RID: 3015
	public Vector3 KDMKDDDNBGL;

	// Token: 0x04000BC8 RID: 3016
	public Transform JILENMCJCHF;

	// Token: 0x04000BC9 RID: 3017
	public MCNLIHMMLCF LIQLFCKICLQ;

	// Token: 0x04000BCA RID: 3018
	public CNCJKLNHQBH EJHIHINFCGL;

	// Token: 0x04000BCB RID: 3019
	private BloomModel.Settings EFOQFENPFHO;

	// Token: 0x04000BCC RID: 3020
	private bool GDMIEPEBGJI = true;

	// Token: 0x04000BCD RID: 3021
	public OKCGKHQHCGE KBOHFDLMMBM;

	// Token: 0x04000BCE RID: 3022
	private float QMDONJGIKDQ;

	// Token: 0x04000BCF RID: 3023
	public float KDEMMJKGDJM = 0.3f;
}
