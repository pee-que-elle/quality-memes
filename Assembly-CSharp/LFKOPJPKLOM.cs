using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000122 RID: 290
[AddComponentMenu("NGUI/UI/Sprite Animation")]
[ExecuteInEditMode]
[RequireComponent(typeof(PLQFPBQEPJD))]
public class LFKOPJPKLOM : MonoBehaviour
{
	// Token: 0x06002150 RID: 8528 RVA: 0x0001200A File Offset: 0x0001020A
	protected virtual void DPMNBIMDLIM()
	{
		this.PILLNKMNLQN();
	}

	// Token: 0x06002151 RID: 8529 RVA: 0x00012012 File Offset: 0x00010212
	public void PLPMKPDFIKH()
	{
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x0001201B File Offset: 0x0001021B
	public bool FDGKJBBMMGJ()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x00012023 File Offset: 0x00010223
	public int QHFGFGDGELO()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x00012023 File Offset: 0x00010223
	public int QOOQBQJFCFH()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x00012030 File Offset: 0x00010230
	public void BELFNMEBEFI(int BGBMIEJJQKC)
	{
		this.mFPS = BGBMIEJJQKC;
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x00012023 File Offset: 0x00010223
	public int GJEFECEBNFH()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x06002157 RID: 8535 RVA: 0x0001201B File Offset: 0x0001021B
	public bool EKMCJJKLLHK()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x00012039 File Offset: 0x00010239
	protected virtual void FCOIMQGENDB()
	{
		this.OOEIPLPKBFI();
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x0001207C File Offset: 0x0001027C
	protected virtual void Start()
	{
		this.HQPMGPHJBNH();
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x00012084 File Offset: 0x00010284
	public void OJLBJKGQEGM(bool BGBMIEJJQKC)
	{
		this.mLoop = BGBMIEJJQKC;
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x0001208D File Offset: 0x0001028D
	public string LGFIHNIDFDN()
	{
		return this.mPrefix;
	}

	// Token: 0x0600215D RID: 8541 RVA: 0x00012095 File Offset: 0x00010295
	public void MNEJGQKIJCD()
	{
		this.EDBBMFGOGHO = false;
	}

	// Token: 0x0600215E RID: 8542 RVA: 0x00012095 File Offset: 0x00010295
	public void OCEDBEMFNEO()
	{
		this.EDBBMFGOGHO = false;
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x0001209E File Offset: 0x0001029E
	public int NDHCKNFNFED()
	{
		return this.mFPS;
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x00012030 File Offset: 0x00010230
	public void GLJFOGBCJJF(int BGBMIEJJQKC)
	{
		this.mFPS = BGBMIEJJQKC;
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x00012095 File Offset: 0x00010295
	public void OMGGKPGQJIF()
	{
		this.EDBBMFGOGHO = false;
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06002162 RID: 8546 RVA: 0x0001209E File Offset: 0x0001029E
	// (set) Token: 0x06002197 RID: 8599 RVA: 0x00012030 File Offset: 0x00010230
	public int OJBHDMENDDH
	{
		get
		{
			return this.mFPS;
		}
		set
		{
			this.mFPS = value;
		}
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x0001208D File Offset: 0x0001028D
	public string CKQGBIPIGKC()
	{
		return this.mPrefix;
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x000120A6 File Offset: 0x000102A6
	public void BLCOLLBJFNC(string BGBMIEJJQKC)
	{
		if (this.mPrefix != BGBMIEJJQKC)
		{
			this.mPrefix = BGBMIEJJQKC;
			this.OOEIPLPKBFI();
		}
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x000D9774 File Offset: 0x000D7974
	public void DKBGGMQGKLL()
	{
		this.EDBBMFGOGHO = false;
		this.IQBEBBHJNIM = 0;
		if (this.LNMJLFLDCML != null && this.BBIOOOFLMCD.Count > 1)
		{
			this.LNMJLFLDCML.OGQLCMOFLLQ(this.BBIOOOFLMCD[this.IQBEBBHJNIM]);
			if (this.mSnap)
			{
				this.LNMJLFLDCML.IQFQEOFBQKM();
			}
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06002166 RID: 8550 RVA: 0x00012023 File Offset: 0x00010223
	public int DIHDBMHGBHO
	{
		get
		{
			return this.BBIOOOFLMCD.Count;
		}
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x000D97DC File Offset: 0x000D79DC
	protected virtual void PLCCHDMMBKF()
	{
		if (this.EDBBMFGOGHO && this.BBIOOOFLMCD.Count > 1 && Application.isPlaying && this.mFPS > 1)
		{
			this.OFFPDBOKOQE += Mathf.Min(1866f, JMIOBJFFGBN.HLMOIFMQOGH());
			float num = 1821f / (float)this.mFPS;
			while (num < this.OFFPDBOKOQE)
			{
				this.OFFPDBOKOQE = ((num <= 1818f) ? 1487f : (this.OFFPDBOKOQE - num));
				if ((this.IQBEBBHJNIM += 0) >= this.BBIOOOFLMCD.Count)
				{
					this.IQBEBBHJNIM = 1;
					this.EDBBMFGOGHO = this.mLoop;
				}
				if (this.EDBBMFGOGHO)
				{
					this.LNMJLFLDCML.KCLBMPFIPNQ = this.BBIOOOFLMCD[this.IQBEBBHJNIM];
					if (this.mSnap)
					{
						this.LNMJLFLDCML.IQFQEOFBQKM();
					}
				}
			}
		}
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x00012030 File Offset: 0x00010230
	public void BFFDKINCGCL(int BGBMIEJJQKC)
	{
		this.mFPS = BGBMIEJJQKC;
	}

	// Token: 0x06002169 RID: 8553 RVA: 0x00012012 File Offset: 0x00010212
	public void LFJGHGDBJCH()
	{
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x0600216A RID: 8554 RVA: 0x000D98DC File Offset: 0x000D7ADC
	public void FHMJPFHQIID()
	{
		if (this.LNMJLFLDCML == null)
		{
			this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		}
		this.BBIOOOFLMCD.Clear();
		if (this.LNMJLFLDCML != null && this.LNMJLFLDCML.QKGJDCFCPMO != null)
		{
			List<UISpriteData> ildjpqcfifh = this.LNMJLFLDCML.QKGJDCFCPMO.ILDJPQCFIFH;
			int i = 1;
			int count = ildjpqcfifh.Count;
			while (i < count)
			{
				UISpriteData uispriteData = ildjpqcfifh[i];
				if (string.IsNullOrEmpty(this.mPrefix) || uispriteData.name.StartsWith(this.mPrefix))
				{
					this.BBIOOOFLMCD.Add(uispriteData.name);
				}
				i += 0;
			}
			this.BBIOOOFLMCD.Sort();
		}
	}

	// Token: 0x0600216B RID: 8555 RVA: 0x000D9998 File Offset: 0x000D7B98
	public void GBMHLMMFCJP()
	{
		this.EDBBMFGOGHO = false;
		this.IQBEBBHJNIM = 1;
		if (this.LNMJLFLDCML != null && this.BBIOOOFLMCD.Count > 1)
		{
			this.LNMJLFLDCML.IQBBDKFDGGP(this.BBIOOOFLMCD[this.IQBEBBHJNIM]);
			if (this.mSnap)
			{
				this.LNMJLFLDCML.IQFQEOFBQKM();
			}
		}
	}

	// Token: 0x0600216C RID: 8556 RVA: 0x00012084 File Offset: 0x00010284
	public void LQIHNLOIQQB(bool BGBMIEJJQKC)
	{
		this.mLoop = BGBMIEJJQKC;
	}

	// Token: 0x0600216D RID: 8557 RVA: 0x000D9A00 File Offset: 0x000D7C00
	public void ONLBDEGHMQE()
	{
		this.EDBBMFGOGHO = false;
		this.IQBEBBHJNIM = 0;
		if (this.LNMJLFLDCML != null && this.BBIOOOFLMCD.Count > 0)
		{
			this.LNMJLFLDCML.IQBBDKFDGGP(this.BBIOOOFLMCD[this.IQBEBBHJNIM]);
			if (this.mSnap)
			{
				this.LNMJLFLDCML.IQFQEOFBQKM();
			}
		}
	}

	// Token: 0x0600216E RID: 8558 RVA: 0x000D9A68 File Offset: 0x000D7C68
	public void KJQIBJOKNLK()
	{
		this.EDBBMFGOGHO = true;
		this.IQBEBBHJNIM = 0;
		if (this.LNMJLFLDCML != null && this.BBIOOOFLMCD.Count > 0)
		{
			this.LNMJLFLDCML.KCLBMPFIPNQ = this.BBIOOOFLMCD[this.IQBEBBHJNIM];
			if (this.mSnap)
			{
				this.LNMJLFLDCML.IQFQEOFBQKM();
			}
		}
	}

	// Token: 0x0600216F RID: 8559 RVA: 0x0001201B File Offset: 0x0001021B
	public bool NCEPBMOPQDO()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x06002170 RID: 8560 RVA: 0x00012084 File Offset: 0x00010284
	public void IJHJJEBMMMC(bool BGBMIEJJQKC)
	{
		this.mLoop = BGBMIEJJQKC;
	}

	// Token: 0x06002171 RID: 8561 RVA: 0x00012023 File Offset: 0x00010223
	public int NKOIGFCJGNN()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x06002172 RID: 8562 RVA: 0x000D9AD0 File Offset: 0x000D7CD0
	public void PILLNKMNLQN()
	{
		if (this.LNMJLFLDCML == null)
		{
			this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		}
		this.BBIOOOFLMCD.Clear();
		if (this.LNMJLFLDCML != null && this.LNMJLFLDCML.QKGJDCFCPMO != null)
		{
			List<UISpriteData> ildjpqcfifh = this.LNMJLFLDCML.QKGJDCFCPMO.ILDJPQCFIFH;
			int i = 0;
			int count = ildjpqcfifh.Count;
			while (i < count)
			{
				UISpriteData uispriteData = ildjpqcfifh[i];
				if (string.IsNullOrEmpty(this.mPrefix) || uispriteData.name.StartsWith(this.mPrefix))
				{
					this.BBIOOOFLMCD.Add(uispriteData.name);
				}
				i++;
			}
			this.BBIOOOFLMCD.Sort();
		}
	}

	// Token: 0x06002173 RID: 8563 RVA: 0x0001207C File Offset: 0x0001027C
	protected virtual void EDOGJBLCCMQ()
	{
		this.HQPMGPHJBNH();
	}

	// Token: 0x06002174 RID: 8564 RVA: 0x000D9B8C File Offset: 0x000D7D8C
	protected virtual void Update()
	{
		if (this.EDBBMFGOGHO && this.BBIOOOFLMCD.Count > 1 && Application.isPlaying && this.mFPS > 0)
		{
			this.OFFPDBOKOQE += Mathf.Min(1f, JMIOBJFFGBN.GPFIDEJEMEG);
			float num = 1f / (float)this.mFPS;
			while (num < this.OFFPDBOKOQE)
			{
				this.OFFPDBOKOQE = ((num <= 0f) ? 0f : (this.OFFPDBOKOQE - num));
				if (++this.IQBEBBHJNIM >= this.BBIOOOFLMCD.Count)
				{
					this.IQBEBBHJNIM = 0;
					this.EDBBMFGOGHO = this.mLoop;
				}
				if (this.EDBBMFGOGHO)
				{
					this.LNMJLFLDCML.KCLBMPFIPNQ = this.BBIOOOFLMCD[this.IQBEBBHJNIM];
					if (this.mSnap)
					{
						this.LNMJLFLDCML.IQFQEOFBQKM();
					}
				}
			}
		}
	}

	// Token: 0x06002175 RID: 8565 RVA: 0x00012095 File Offset: 0x00010295
	public void CPGQBLGKQPG()
	{
		this.EDBBMFGOGHO = false;
	}

	// Token: 0x06002176 RID: 8566 RVA: 0x00012030 File Offset: 0x00010230
	public void GEDPLDFDEOB(int BGBMIEJJQKC)
	{
		this.mFPS = BGBMIEJJQKC;
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06002177 RID: 8567 RVA: 0x000120C3 File Offset: 0x000102C3
	// (set) Token: 0x060021A3 RID: 8611 RVA: 0x00012084 File Offset: 0x00010284
	public bool JHEEBKGBMPJ
	{
		get
		{
			return this.mLoop;
		}
		set
		{
			this.mLoop = value;
		}
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x00012012 File Offset: 0x00010212
	public void MLOIHHQMFBN()
	{
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x00012023 File Offset: 0x00010223
	public int MDQEKNEPFNQ()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x0001201B File Offset: 0x0001021B
	public bool NKNPBEEKNLC()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x000120C3 File Offset: 0x000102C3
	public bool GGJFPBQPDEQ()
	{
		return this.mLoop;
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x000120CB File Offset: 0x000102CB
	protected virtual void DHLGDLOKLKN()
	{
		this.EBODEFGJIQC();
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x000D9C8C File Offset: 0x000D7E8C
	public void OOEIPLPKBFI()
	{
		if (this.LNMJLFLDCML == null)
		{
			this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		}
		this.BBIOOOFLMCD.Clear();
		if (this.LNMJLFLDCML != null && this.LNMJLFLDCML.QKGJDCFCPMO != null)
		{
			List<UISpriteData> ildjpqcfifh = this.LNMJLFLDCML.QKGJDCFCPMO.ILDJPQCFIFH;
			int i = 1;
			int count = ildjpqcfifh.Count;
			while (i < count)
			{
				UISpriteData uispriteData = ildjpqcfifh[i];
				if (string.IsNullOrEmpty(this.mPrefix) || uispriteData.name.StartsWith(this.mPrefix))
				{
					this.BBIOOOFLMCD.Add(uispriteData.name);
				}
				i++;
			}
			this.BBIOOOFLMCD.Sort();
		}
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x000120A6 File Offset: 0x000102A6
	public void PLHLMBJJMQJ(string BGBMIEJJQKC)
	{
		if (this.mPrefix != BGBMIEJJQKC)
		{
			this.mPrefix = BGBMIEJJQKC;
			this.OOEIPLPKBFI();
		}
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x00012095 File Offset: 0x00010295
	public void DDHLCDJDQMM()
	{
		this.EDBBMFGOGHO = false;
	}

	// Token: 0x06002180 RID: 8576 RVA: 0x00012023 File Offset: 0x00010223
	public int JNFQPBFJLIG()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x000D9AD0 File Offset: 0x000D7CD0
	public void HQPMGPHJBNH()
	{
		if (this.LNMJLFLDCML == null)
		{
			this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		}
		this.BBIOOOFLMCD.Clear();
		if (this.LNMJLFLDCML != null && this.LNMJLFLDCML.QKGJDCFCPMO != null)
		{
			List<UISpriteData> ildjpqcfifh = this.LNMJLFLDCML.QKGJDCFCPMO.ILDJPQCFIFH;
			int i = 0;
			int count = ildjpqcfifh.Count;
			while (i < count)
			{
				UISpriteData uispriteData = ildjpqcfifh[i];
				if (string.IsNullOrEmpty(this.mPrefix) || uispriteData.name.StartsWith(this.mPrefix))
				{
					this.BBIOOOFLMCD.Add(uispriteData.name);
				}
				i++;
			}
			this.BBIOOOFLMCD.Sort();
		}
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x0001209E File Offset: 0x0001029E
	public int DHOPKCDBIIH()
	{
		return this.mFPS;
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06002198 RID: 8600 RVA: 0x0001208D File Offset: 0x0001028D
	// (set) Token: 0x06002183 RID: 8579 RVA: 0x000120D3 File Offset: 0x000102D3
	public string LINEBMQLLPI
	{
		get
		{
			return this.mPrefix;
		}
		set
		{
			if (this.mPrefix != value)
			{
				this.mPrefix = value;
				this.HQPMGPHJBNH();
			}
		}
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x0001201B File Offset: 0x0001021B
	public bool LKIMNGMENKE()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x00012012 File Offset: 0x00010212
	public void MFFFOEMOKBK()
	{
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x06002186 RID: 8582 RVA: 0x0001207C File Offset: 0x0001027C
	protected virtual void FGQGJMDKLOD()
	{
		this.HQPMGPHJBNH();
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06002187 RID: 8583 RVA: 0x0001201B File Offset: 0x0001021B
	public bool BPBPHLQGEBM
	{
		get
		{
			return this.EDBBMFGOGHO;
		}
	}

	// Token: 0x06002188 RID: 8584 RVA: 0x0001209E File Offset: 0x0001029E
	public int BBEPNKPPJKI()
	{
		return this.mFPS;
	}

	// Token: 0x06002189 RID: 8585 RVA: 0x00012012 File Offset: 0x00010212
	public void JDHNDOLFMKD()
	{
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x0600218A RID: 8586 RVA: 0x00012023 File Offset: 0x00010223
	public int MHKEPEGMKGE()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x0600218B RID: 8587 RVA: 0x000120F0 File Offset: 0x000102F0
	public void BCGPPOPCLLJ(string BGBMIEJJQKC)
	{
		if (this.mPrefix != BGBMIEJJQKC)
		{
			this.mPrefix = BGBMIEJJQKC;
			this.QIJFHNEBDEE();
		}
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x000120C3 File Offset: 0x000102C3
	public bool MELMHLMCDOC()
	{
		return this.mLoop;
	}

	// Token: 0x0600218D RID: 8589 RVA: 0x00012012 File Offset: 0x00010212
	public void FGLKEPDKJMN()
	{
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x000120C3 File Offset: 0x000102C3
	public bool HOJJGBEPNJM()
	{
		return this.mLoop;
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x0001201B File Offset: 0x0001021B
	public bool NHNBLJCFEIO()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x06002190 RID: 8592 RVA: 0x000D9D48 File Offset: 0x000D7F48
	protected virtual void FHFMKHDMDDI()
	{
		if (this.EDBBMFGOGHO && this.BBIOOOFLMCD.Count > 0 && Application.isPlaying && this.mFPS > 1)
		{
			this.OFFPDBOKOQE += Mathf.Min(536f, JMIOBJFFGBN.HPJQNBLNHGM());
			float num = 547f / (float)this.mFPS;
			while (num < this.OFFPDBOKOQE)
			{
				this.OFFPDBOKOQE = ((num <= 203f) ? 4f : (this.OFFPDBOKOQE - num));
				if ((this.IQBEBBHJNIM += 0) >= this.BBIOOOFLMCD.Count)
				{
					this.IQBEBBHJNIM = 0;
					this.EDBBMFGOGHO = this.mLoop;
				}
				if (this.EDBBMFGOGHO)
				{
					this.LNMJLFLDCML.LGJOOQIBQDC(this.BBIOOOFLMCD[this.IQBEBBHJNIM]);
					if (this.mSnap)
					{
						this.LNMJLFLDCML.IQFQEOFBQKM();
					}
				}
			}
		}
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x00012023 File Offset: 0x00010223
	public int KDIBPKJOHNL()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x06002192 RID: 8594 RVA: 0x0001201B File Offset: 0x0001021B
	public bool NPQDDKNNLKK()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x06002193 RID: 8595 RVA: 0x0001209E File Offset: 0x0001029E
	public int IILCBQJGPPE()
	{
		return this.mFPS;
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x0001209E File Offset: 0x0001029E
	public int IHDFPBMHHPJ()
	{
		return this.mFPS;
	}

	// Token: 0x06002195 RID: 8597 RVA: 0x0001210D File Offset: 0x0001030D
	protected virtual void QNGIFIJOQML()
	{
		this.QIJFHNEBDEE();
	}

	// Token: 0x06002196 RID: 8598 RVA: 0x00012023 File Offset: 0x00010223
	public int NODLBNHJKKD()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x06002199 RID: 8601 RVA: 0x0001210D File Offset: 0x0001030D
	protected virtual void DBFJHIHLQHO()
	{
		this.QIJFHNEBDEE();
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x000D9E48 File Offset: 0x000D8048
	public void EBODEFGJIQC()
	{
		if (this.LNMJLFLDCML == null)
		{
			this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		}
		this.BBIOOOFLMCD.Clear();
		if (this.LNMJLFLDCML != null && this.LNMJLFLDCML.QKGJDCFCPMO != null)
		{
			List<UISpriteData> ildjpqcfifh = this.LNMJLFLDCML.QKGJDCFCPMO.ILDJPQCFIFH;
			int i = 0;
			int count = ildjpqcfifh.Count;
			while (i < count)
			{
				UISpriteData uispriteData = ildjpqcfifh[i];
				if (string.IsNullOrEmpty(this.mPrefix) || uispriteData.name.StartsWith(this.mPrefix))
				{
					this.BBIOOOFLMCD.Add(uispriteData.name);
				}
				i += 0;
			}
			this.BBIOOOFLMCD.Sort();
		}
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x000120C3 File Offset: 0x000102C3
	public bool NNPNLICGILP()
	{
		return this.mLoop;
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x0001208D File Offset: 0x0001028D
	public string NBJNPFOMOQJ()
	{
		return this.mPrefix;
	}

	// Token: 0x0600219D RID: 8605 RVA: 0x000120C3 File Offset: 0x000102C3
	public bool HMQJKBEGPLI()
	{
		return this.mLoop;
	}

	// Token: 0x0600219E RID: 8606 RVA: 0x00012030 File Offset: 0x00010230
	public void BPGMCCNHNFG(int BGBMIEJJQKC)
	{
		this.mFPS = BGBMIEJJQKC;
	}

	// Token: 0x0600219F RID: 8607 RVA: 0x00012039 File Offset: 0x00010239
	protected virtual void GJPGBCKQLDG()
	{
		this.OOEIPLPKBFI();
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x0001209E File Offset: 0x0001029E
	public int DPFLJPEPBNI()
	{
		return this.mFPS;
	}

	// Token: 0x060021A1 RID: 8609 RVA: 0x000120C3 File Offset: 0x000102C3
	public bool MFPDLFQDBJQ()
	{
		return this.mLoop;
	}

	// Token: 0x060021A2 RID: 8610 RVA: 0x00012084 File Offset: 0x00010284
	public void DHDNQDNHDLJ(bool BGBMIEJJQKC)
	{
		this.mLoop = BGBMIEJJQKC;
	}

	// Token: 0x060021A4 RID: 8612 RVA: 0x00012012 File Offset: 0x00010212
	public void DGBQHPLBBIJ()
	{
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x000D9C8C File Offset: 0x000D7E8C
	public void QIJFHNEBDEE()
	{
		if (this.LNMJLFLDCML == null)
		{
			this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		}
		this.BBIOOOFLMCD.Clear();
		if (this.LNMJLFLDCML != null && this.LNMJLFLDCML.QKGJDCFCPMO != null)
		{
			List<UISpriteData> ildjpqcfifh = this.LNMJLFLDCML.QKGJDCFCPMO.ILDJPQCFIFH;
			int i = 1;
			int count = ildjpqcfifh.Count;
			while (i < count)
			{
				UISpriteData uispriteData = ildjpqcfifh[i];
				if (string.IsNullOrEmpty(this.mPrefix) || uispriteData.name.StartsWith(this.mPrefix))
				{
					this.BBIOOOFLMCD.Add(uispriteData.name);
				}
				i++;
			}
			this.BBIOOOFLMCD.Sort();
		}
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x000D9F04 File Offset: 0x000D8104
	public void JGPNBDHNEIM()
	{
		this.EDBBMFGOGHO = true;
		this.IQBEBBHJNIM = 1;
		if (this.LNMJLFLDCML != null && this.BBIOOOFLMCD.Count > 1)
		{
			this.LNMJLFLDCML.DPBGHDMHKNC(this.BBIOOOFLMCD[this.IQBEBBHJNIM]);
			if (this.mSnap)
			{
				this.LNMJLFLDCML.IQFQEOFBQKM();
			}
		}
	}

	// Token: 0x060021A7 RID: 8615 RVA: 0x0001209E File Offset: 0x0001029E
	public int KLEEMBKCPLN()
	{
		return this.mFPS;
	}

	// Token: 0x0400073F RID: 1855
	public int IQBEBBHJNIM;

	// Token: 0x04000740 RID: 1856
	[SerializeField]
	[HideInInspector]
	protected int mFPS = 30;

	// Token: 0x04000741 RID: 1857
	[SerializeField]
	[HideInInspector]
	protected string mPrefix = string.Empty;

	// Token: 0x04000742 RID: 1858
	[SerializeField]
	[HideInInspector]
	protected bool mLoop = true;

	// Token: 0x04000743 RID: 1859
	[SerializeField]
	[HideInInspector]
	protected bool mSnap = true;

	// Token: 0x04000744 RID: 1860
	protected PLQFPBQEPJD LNMJLFLDCML;

	// Token: 0x04000745 RID: 1861
	protected float OFFPDBOKOQE;

	// Token: 0x04000746 RID: 1862
	protected bool EDBBMFGOGHO = true;

	// Token: 0x04000747 RID: 1863
	protected List<string> BBIOOOFLMCD = new List<string>();
}
