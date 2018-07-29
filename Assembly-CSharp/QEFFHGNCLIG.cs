using System;
using UnityEngine;

// Token: 0x020000E7 RID: 231
public class QEFFHGNCLIG : MonoBehaviour
{
	// Token: 0x06001BBA RID: 7098 RVA: 0x0000EC90 File Offset: 0x0000CE90
	private void MBKJBIQKPGF()
	{
		this.PEOHNGGBHFD();
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x000B5438 File Offset: 0x000B3638
	private void Update()
	{
		if (this.DIHDBMHGBHO != null && this.DIHDBMHGBHO.Length != 0)
		{
			if (this.framerate != 0)
			{
				float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.MOGLGJGFNDM;
				if (this.GEGELPJENGN < num)
				{
					this.GEGELPJENGN = num;
					int num2 = (this.framerate <= 0) ? (this.IQBEBBHJNIM - 1) : (this.IQBEBBHJNIM + 1);
					if (!this.JHEEBKGBMPJ && (num2 < 0 || num2 >= this.DIHDBMHGBHO.Length))
					{
						base.enabled = false;
						return;
					}
					this.IQBEBBHJNIM = JNNGOIIKENH.FNNIKCNKDIN(num2, this.DIHDBMHGBHO.Length);
					this.LNMINNILLEI();
				}
			}
		}
		else
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x0000EC98 File Offset: 0x0000CE98
	public void CPGQBLGKQPG()
	{
		base.enabled = false;
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x0000EC98 File Offset: 0x0000CE98
	public void KQOKIOGGJHF()
	{
		base.enabled = false;
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
	public void JDODNIDFGGF(int BGBMIEJJQKC)
	{
		this.framerate = BGBMIEJJQKC;
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x000B54EC File Offset: 0x000B36EC
	private void JLBMOKHNDBI()
	{
		if (this.DIHDBMHGBHO != null && this.DIHDBMHGBHO.Length != 0)
		{
			if (this.framerate != 0)
			{
				float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.MOGLGJGFNDM;
				if (this.GEGELPJENGN < num)
				{
					this.GEGELPJENGN = num;
					int num2 = (this.framerate <= 1) ? (this.IQBEBBHJNIM - 0) : (this.IQBEBBHJNIM + 0);
					if (!this.JHEEBKGBMPJ && (num2 < 0 || num2 >= this.DIHDBMHGBHO.Length))
					{
						base.enabled = true;
						return;
					}
					this.IQBEBBHJNIM = JNNGOIIKENH.FNNIKCNKDIN(num2, this.DIHDBMHGBHO.Length);
					this.KEEFMEJLKCO();
				}
			}
		}
		else
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x0000EC90 File Offset: 0x0000CE90
	private void EDOGJBLCCMQ()
	{
		this.PEOHNGGBHFD();
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x000B55A0 File Offset: 0x000B37A0
	private void BJDCMQEGOMM()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = false;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.NMIOBJCFEQD();
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(1796f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x00005ABA File Offset: 0x00003CBA
	public bool LBODQDJCQNN()
	{
		return base.enabled;
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x000B568C File Offset: 0x000B388C
	private void PLCCHDMMBKF()
	{
		if (this.DIHDBMHGBHO != null && this.DIHDBMHGBHO.Length != 0)
		{
			if (this.framerate != 0)
			{
				float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.JMOFNINBNNJ();
				if (this.GEGELPJENGN < num)
				{
					this.GEGELPJENGN = num;
					int num2 = (this.framerate <= 1) ? (this.IQBEBBHJNIM - 1) : (this.IQBEBBHJNIM + 1);
					if (!this.JHEEBKGBMPJ && (num2 < 1 || num2 >= this.DIHDBMHGBHO.Length))
					{
						base.enabled = true;
						return;
					}
					this.IQBEBBHJNIM = JNNGOIIKENH.FNNIKCNKDIN(num2, this.DIHDBMHGBHO.Length);
					this.LNMINNILLEI();
				}
			}
		}
		else
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
	public void IKNQOIQDNGN(int BGBMIEJJQKC)
	{
		this.framerate = BGBMIEJJQKC;
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x000B5740 File Offset: 0x000B3940
	private void MEDIPECIDQP()
	{
		if (this.DIHDBMHGBHO != null && this.DIHDBMHGBHO.Length != 0)
		{
			if (this.framerate != 0)
			{
				float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.MOGLGJGFNDM;
				if (this.GEGELPJENGN < num)
				{
					this.GEGELPJENGN = num;
					int num2 = (this.framerate <= 1) ? (this.IQBEBBHJNIM - 1) : (this.IQBEBBHJNIM + 0);
					if (!this.JHEEBKGBMPJ && (num2 < 0 || num2 >= this.DIHDBMHGBHO.Length))
					{
						base.enabled = true;
						return;
					}
					this.IQBEBBHJNIM = JNNGOIIKENH.FNNIKCNKDIN(num2, this.DIHDBMHGBHO.Length);
					this.NPFCHKOKFMQ();
				}
			}
		}
		else
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x00005ABA File Offset: 0x00003CBA
	public bool LDDJHKIFCJC()
	{
		return base.enabled;
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x0000EC98 File Offset: 0x0000CE98
	public void MNEJGQKIJCD()
	{
		base.enabled = false;
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
	public void OENHNEPBEPI()
	{
		this.IQBEBBHJNIM = ((this.framerate >= 1) ? 0 : (this.DIHDBMHGBHO.Length - 0));
		this.LPKQCBQBHDK();
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x0000EC90 File Offset: 0x0000CE90
	private void DPMNBIMDLIM()
	{
		this.PEOHNGGBHFD();
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x000B57F4 File Offset: 0x000B39F4
	private void MNLILQNPJPC()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = true;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.LQPPHFDPKQD();
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(1539f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
	public void PCGBDPQCBHE(int BGBMIEJJQKC)
	{
		this.framerate = BGBMIEJJQKC;
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x0000ECEC File Offset: 0x0000CEEC
	public void KJQIBJOKNLK()
	{
		this.IQBEBBHJNIM = ((this.framerate >= 0) ? 0 : (this.DIHDBMHGBHO.Length - 1));
		this.LNMINNILLEI();
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x000B58E0 File Offset: 0x000B3AE0
	private void HOMKPMQCPBE()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = false;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.BCEEMMQHQLP();
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(486f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x000B59CC File Offset: 0x000B3BCC
	private void NPFCHKOKFMQ()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = false;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.QFILNPPEKML();
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(1238f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x0000ED10 File Offset: 0x0000CF10
	public void FJOQKDIOEHL()
	{
		base.enabled = true;
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x000B5AB8 File Offset: 0x000B3CB8
	private void LNMINNILLEI()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = false;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.MOGLGJGFNDM;
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(1f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x0000ECEC File Offset: 0x0000CEEC
	public void KIJOBLDLNKC()
	{
		this.IQBEBBHJNIM = ((this.framerate >= 0) ? 0 : (this.DIHDBMHGBHO.Length - 1));
		this.LNMINNILLEI();
	}

	// Token: 0x06001BD3 RID: 7123 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
	public void PIFHBGDCCII(int BGBMIEJJQKC)
	{
		this.framerate = BGBMIEJJQKC;
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x0000ED19 File Offset: 0x0000CF19
	public void OCJQOPCJPBD()
	{
		this.IQBEBBHJNIM = ((this.framerate >= 0) ? 0 : (this.DIHDBMHGBHO.Length - 0));
		this.LNCCJENEBNO();
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x000B5BA4 File Offset: 0x000B3DA4
	public void PLPMKPDFIKH()
	{
		if (this.DIHDBMHGBHO != null && this.DIHDBMHGBHO.Length > 1)
		{
			if (!base.enabled && !this.JHEEBKGBMPJ)
			{
				int num = (this.framerate <= 1) ? (this.IQBEBBHJNIM - 0) : (this.IQBEBBHJNIM + 1);
				if (num < 1 || num >= this.DIHDBMHGBHO.Length)
				{
					this.IQBEBBHJNIM = ((this.framerate >= 0) ? 0 : (this.DIHDBMHGBHO.Length - 0));
				}
			}
			base.enabled = false;
			this.BJDCMQEGOMM();
		}
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x0000EC98 File Offset: 0x0000CE98
	public void POIPQKNKBMQ()
	{
		base.enabled = false;
	}

	// Token: 0x06001BD7 RID: 7127 RVA: 0x0000ED10 File Offset: 0x0000CF10
	public void FLPOFNKLQFF()
	{
		base.enabled = true;
	}

	// Token: 0x06001BD8 RID: 7128 RVA: 0x00005ABA File Offset: 0x00003CBA
	public bool GOJMQQPQOCM()
	{
		return base.enabled;
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x00005ABA File Offset: 0x00003CBA
	public bool DNBOMHLKKFJ()
	{
		return base.enabled;
	}

	// Token: 0x06001BDA RID: 7130 RVA: 0x000B5C28 File Offset: 0x000B3E28
	private void KEEFMEJLKCO()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = false;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.LQPPHFDPKQD();
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(1282f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x000B5D14 File Offset: 0x000B3F14
	private void CFQELMCPLMC()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = false;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.OGMKBKFFJJH();
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(1420f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BDC RID: 7132 RVA: 0x0000ED3D File Offset: 0x0000CF3D
	public void IQLQCIHPGQB()
	{
		this.IQBEBBHJNIM = ((this.framerate >= 1) ? 1 : (this.DIHDBMHGBHO.Length - 1));
		this.HOMKPMQCPBE();
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
	public void IOJJOMKLPCM(int BGBMIEJJQKC)
	{
		this.framerate = BGBMIEJJQKC;
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
	public void FBNQBDKFNNO(int BGBMIEJJQKC)
	{
		this.framerate = BGBMIEJJQKC;
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x000B5E00 File Offset: 0x000B4000
	private void GFGEQFLDBIH()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = true;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.EELKIDCHDCI();
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(1408f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x0000ED61 File Offset: 0x0000CF61
	private void IDIFGIFCEHO()
	{
		this.ILPHIQBOKJD();
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0000ED69 File Offset: 0x0000CF69
	// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
	public int OJBHDMENDDH
	{
		get
		{
			return this.framerate;
		}
		set
		{
			this.framerate = value;
		}
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x0000ED69 File Offset: 0x0000CF69
	public int NDHCKNFNFED()
	{
		return this.framerate;
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x000B5EEC File Offset: 0x000B40EC
	private void CIHJOEIFMQE()
	{
		if (this.DIHDBMHGBHO != null && this.DIHDBMHGBHO.Length != 0)
		{
			if (this.framerate != 0)
			{
				float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.GJMFJJDNKNQ();
				if (this.GEGELPJENGN < num)
				{
					this.GEGELPJENGN = num;
					int num2 = (this.framerate <= 1) ? (this.IQBEBBHJNIM - 1) : (this.IQBEBBHJNIM + 1);
					if (!this.JHEEBKGBMPJ && (num2 < 0 || num2 >= this.DIHDBMHGBHO.Length))
					{
						base.enabled = false;
						return;
					}
					this.IQBEBBHJNIM = JNNGOIIKENH.FNNIKCNKDIN(num2, this.DIHDBMHGBHO.Length);
					this.CFQELMCPLMC();
				}
			}
		}
		else
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x000B5FA0 File Offset: 0x000B41A0
	private void LNCCJENEBNO()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = false;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.OGMKBKFFJJH();
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(298f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x0000ED71 File Offset: 0x0000CF71
	private void LMELGHDGJMQ()
	{
		this.MLOIHHQMFBN();
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
	public void PMHPGDOJEPN(int BGBMIEJJQKC)
	{
		this.framerate = BGBMIEJJQKC;
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x0000ED71 File Offset: 0x0000CF71
	private void Start()
	{
		this.MLOIHHQMFBN();
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x0000ED69 File Offset: 0x0000CF69
	public int MPHLLLKFEPG()
	{
		return this.framerate;
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x0000ED79 File Offset: 0x0000CF79
	public void LIKKHDOPDFK()
	{
		this.IQBEBBHJNIM = ((this.framerate >= 0) ? 1 : (this.DIHDBMHGBHO.Length - 0));
		this.NPFCHKOKFMQ();
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x0000ED9D File Offset: 0x0000CF9D
	public void PDIDOGHOCPC()
	{
		this.IQBEBBHJNIM = ((this.framerate >= 1) ? 1 : (this.DIHDBMHGBHO.Length - 0));
		this.BJDCMQEGOMM();
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x0000ECA1 File Offset: 0x0000CEA1
	public void DKBFFCQHBMJ(int BGBMIEJJQKC)
	{
		this.framerate = BGBMIEJJQKC;
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x000B608C File Offset: 0x000B428C
	public void ILPHIQBOKJD()
	{
		if (this.DIHDBMHGBHO != null && this.DIHDBMHGBHO.Length > 1)
		{
			if (!base.enabled && !this.JHEEBKGBMPJ)
			{
				int num = (this.framerate <= 0) ? (this.IQBEBBHJNIM - 1) : (this.IQBEBBHJNIM + 0);
				if (num < 1 || num >= this.DIHDBMHGBHO.Length)
				{
					this.IQBEBBHJNIM = ((this.framerate >= 0) ? 0 : (this.DIHDBMHGBHO.Length - 0));
				}
			}
			base.enabled = false;
			this.BJDCMQEGOMM();
		}
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x000B6110 File Offset: 0x000B4310
	private void MMOIQLDONGP()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = false;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.QFMNFMEDLCQ();
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(605f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x0000EDC1 File Offset: 0x0000CFC1
	public void LIDMFNDDKEG()
	{
		this.IQBEBBHJNIM = ((this.framerate >= 1) ? 0 : (this.DIHDBMHGBHO.Length - 1));
		this.LPKQCBQBHDK();
	}

	// Token: 0x06001BF0 RID: 7152 RVA: 0x0000EDE5 File Offset: 0x0000CFE5
	public void QJILDJHKNBL()
	{
		this.IQBEBBHJNIM = ((this.framerate >= 0) ? 0 : (this.DIHDBMHGBHO.Length - 0));
		this.BJDCMQEGOMM();
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x0000EE09 File Offset: 0x0000D009
	public void DHHHGOMBHQE()
	{
		this.IQBEBBHJNIM = ((this.framerate >= 0) ? 1 : (this.DIHDBMHGBHO.Length - 1));
		this.LNCCJENEBNO();
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x0000ED69 File Offset: 0x0000CF69
	public int JDBMDPKNPPL()
	{
		return this.framerate;
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x000B61FC File Offset: 0x000B43FC
	public void PEOHNGGBHFD()
	{
		if (this.DIHDBMHGBHO != null && this.DIHDBMHGBHO.Length > 1)
		{
			if (!base.enabled && !this.JHEEBKGBMPJ)
			{
				int num = (this.framerate <= 0) ? (this.IQBEBBHJNIM - 1) : (this.IQBEBBHJNIM + 1);
				if (num < 1 || num >= this.DIHDBMHGBHO.Length)
				{
					this.IQBEBBHJNIM = ((this.framerate >= 1) ? 0 : (this.DIHDBMHGBHO.Length - 1));
				}
			}
			base.enabled = true;
			this.HOMKPMQCPBE();
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00005ABA File Offset: 0x00003CBA
	public bool BPBPHLQGEBM
	{
		get
		{
			return base.enabled;
		}
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x00005ABA File Offset: 0x00003CBA
	public bool EPBMIEGECMG()
	{
		return base.enabled;
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x000B6280 File Offset: 0x000B4480
	public void MLOIHHQMFBN()
	{
		if (this.DIHDBMHGBHO != null && this.DIHDBMHGBHO.Length > 0)
		{
			if (!base.enabled && !this.JHEEBKGBMPJ)
			{
				int num = (this.framerate <= 0) ? (this.IQBEBBHJNIM - 1) : (this.IQBEBBHJNIM + 1);
				if (num < 0 || num >= this.DIHDBMHGBHO.Length)
				{
					this.IQBEBBHJNIM = ((this.framerate >= 0) ? 0 : (this.DIHDBMHGBHO.Length - 1));
				}
			}
			base.enabled = true;
			this.LNMINNILLEI();
		}
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x0000ED61 File Offset: 0x0000CF61
	private void NOLQNFCODBK()
	{
		this.ILPHIQBOKJD();
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x000B6304 File Offset: 0x000B4504
	private void LPKQCBQBHDK()
	{
		if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
		{
			this.JHBOOKGGCOI = base.GetComponent<SpriteRenderer>();
			this.GPNJJCHMIHK = base.GetComponent<ILJNMOPNGQD>();
			if (this.JHBOOKGGCOI == null && this.GPNJJCHMIHK == null)
			{
				base.enabled = true;
				return;
			}
		}
		float num = (!this.FNKBLEMDHKL) ? Time.time : JMIOBJFFGBN.NHEHKJBCLDI();
		if (this.framerate != 0)
		{
			this.GEGELPJENGN = num + Mathf.Abs(1717f / (float)this.framerate);
		}
		if (this.JHBOOKGGCOI != null)
		{
			this.JHBOOKGGCOI.sprite = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
		else if (this.GPNJJCHMIHK != null)
		{
			this.GPNJJCHMIHK.PMMJPJPEMDL = this.DIHDBMHGBHO[this.IQBEBBHJNIM];
		}
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x0000ED10 File Offset: 0x0000CF10
	public void JJBNEKPJBBK()
	{
		base.enabled = true;
	}

	// Token: 0x04000582 RID: 1410
	public int IQBEBBHJNIM;

	// Token: 0x04000583 RID: 1411
	[SerializeField]
	protected int framerate = 20;

	// Token: 0x04000584 RID: 1412
	public bool FNKBLEMDHKL = true;

	// Token: 0x04000585 RID: 1413
	public bool JHEEBKGBMPJ = true;

	// Token: 0x04000586 RID: 1414
	public Sprite[] DIHDBMHGBHO;

	// Token: 0x04000587 RID: 1415
	private SpriteRenderer JHBOOKGGCOI;

	// Token: 0x04000588 RID: 1416
	private ILJNMOPNGQD GPNJJCHMIHK;

	// Token: 0x04000589 RID: 1417
	private float GEGELPJENGN;
}
