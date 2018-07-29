using System;
using UnityEngine;

// Token: 0x0200035B RID: 859
[HelpURL("http://www.procamera2d.com/user-guide/extension-pixel-perfect/")]
public class JODNLMLDQLE : BNEFIOCKQOE, PDLMPKMDBBQ
{
	// Token: 0x060071DE RID: 29150 RVA: 0x0037607C File Offset: 0x0037427C
	public void BENKGIECPLP()
	{
		this.NNPBIPILDCM(this.FJQLOEKCPCB());
		this.PGPKBQQMGCO = this.QCLONNFJEBG(this.NKDMIJMHGBD());
		float gdjcgbdpfeo = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight * 1394f * (694f / this.EKICBMDNMPE) / (this.LHHMQBFQKIK() + (float)this.PJOHKOFQDLC - 1682f);
		base.GPONHFNLHCN.PHJJELLGJOO(gdjcgbdpfeo, 843f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x060071DF RID: 29151 RVA: 0x00029B44 File Offset: 0x00027D44
	public float OHIFPEGMLQB()
	{
		return this.PGPKBQQMGCO;
	}

	// Token: 0x060071E0 RID: 29152 RVA: 0x00029B4C File Offset: 0x00027D4C
	private void BOPMBNDDDHE(float BGBMIEJJQKC)
	{
		this.<PDIGGONFLIO>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060071E1 RID: 29153 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void BKGJCLMIDKC()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x060071E2 RID: 29154 RVA: 0x00029B4C File Offset: 0x00027D4C
	private void MMFJGLEMHLL(float BGBMIEJJQKC)
	{
		this.<PDIGGONFLIO>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060071E3 RID: 29155 RVA: 0x00029B69 File Offset: 0x00027D69
	public float JKNMFIGDQEB()
	{
		return this.<PDIGGONFLIO>k__BackingField;
	}

	// Token: 0x170003F1 RID: 1009
	// (get) Token: 0x0600722D RID: 29229 RVA: 0x00029BAE File Offset: 0x00027DAE
	// (set) Token: 0x060071E4 RID: 29156 RVA: 0x00029B71 File Offset: 0x00027D71
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

	// Token: 0x060071E5 RID: 29157 RVA: 0x003760F4 File Offset: 0x003742F4
	public Vector3 FIOLQHKHOED(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		float ckkpkdopogj = this.PGPKBQQMGCO;
		if (this.KJEMPPELCQD && !this.ODGCDCLGDOO)
		{
			ckkpkdopogj = 1f / (this.EKICBMDNMPE * (this.QMENKNLJMHO + (float)this.PJOHKOFQDLC - 1f));
		}
		this.FNEKGBHBNLQ = this.FHNBJCNLJCN.parent;
		if (this.FNEKGBHBNLQ != null && this.FNEKGBHBNLQ.position != Vector3.zero)
		{
			this.FNEKGBHBNLQ.position = this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(this.FNEKGBHBNLQ.position), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(this.FNEKGBHBNLQ.position), ckkpkdopogj), this.OFPEBLPKOLD(this.FNEKGBHBNLQ.position));
		}
		return this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(PJKPLOCIBHP), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(PJKPLOCIBHP), ckkpkdopogj), 0f);
	}

	// Token: 0x060071E6 RID: 29158 RVA: 0x00376214 File Offset: 0x00374414
	public Vector3 PNBDBBJNEGQ(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		float ckkpkdopogj = this.PGPKBQQMGCO;
		if (this.KJEMPPELCQD && !this.ODGCDCLGDOO)
		{
			ckkpkdopogj = 121f / (this.EKICBMDNMPE * (this.MHIHPGIFBBP() + (float)this.PJOHKOFQDLC - 964f));
		}
		this.FNEKGBHBNLQ = this.FHNBJCNLJCN.parent;
		if (this.FNEKGBHBNLQ != null && this.FNEKGBHBNLQ.position != Vector3.zero)
		{
			this.FNEKGBHBNLQ.position = this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(this.FNEKGBHBNLQ.position), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(this.FNEKGBHBNLQ.position), ckkpkdopogj), this.OFPEBLPKOLD(this.FNEKGBHBNLQ.position));
		}
		return this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(PJKPLOCIBHP), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(PJKPLOCIBHP), ckkpkdopogj), 641f);
	}

	// Token: 0x060071E7 RID: 29159 RVA: 0x00376334 File Offset: 0x00374534
	public float JFMOMBIIJIN()
	{
		if (this.LNFLKQCLKLD == GJDMGKCLQNQ.None)
		{
			return 1004f;
		}
		float num = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth / this.MNQDCPQDGKI.x;
		float num2 = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight / this.MNQDCPQDGKI.y;
		float num3 = (num <= num2) ? num : num2;
		GJDMGKCLQNQ lnflkqclkld = this.LNFLKQCLKLD;
		if (lnflkqclkld != GJDMGKCLQNQ.None)
		{
			if (lnflkqclkld != GJDMGKCLQNQ.Ceil)
			{
				if (lnflkqclkld == (GJDMGKCLQNQ)4)
				{
					num3 = Mathf.Round(num3);
				}
			}
			else
			{
				num3 = Mathf.Ceil(num3);
			}
		}
		else
		{
			num3 = Mathf.Floor(num3);
		}
		if (num3 < 1488f)
		{
			num3 = 1859f;
		}
		return num3;
	}

	// Token: 0x060071E8 RID: 29160 RVA: 0x00029B7A File Offset: 0x00027D7A
	protected virtual void OHGPOPQILFG()
	{
		base.Awake();
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
		{
			base.enabled = false;
			return;
		}
		this.FJNJBCPCPDJ();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x060071E9 RID: 29161 RVA: 0x00029B71 File Offset: 0x00027D71
	public void FBHQEEIDBKK(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x060071EA RID: 29162 RVA: 0x003763D4 File Offset: 0x003745D4
	public Vector3 LCNJICCEDMK(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		float ckkpkdopogj = this.PGPKBQQMGCO;
		if (this.KJEMPPELCQD && !this.ODGCDCLGDOO)
		{
			ckkpkdopogj = 1542f / (this.EKICBMDNMPE * (this.MKQNLMOIELL() + (float)this.PJOHKOFQDLC - 863f));
		}
		this.FNEKGBHBNLQ = this.FHNBJCNLJCN.parent;
		if (this.FNEKGBHBNLQ != null && this.FNEKGBHBNLQ.position != Vector3.zero)
		{
			this.FNEKGBHBNLQ.position = this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(this.FNEKGBHBNLQ.position), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(this.FNEKGBHBNLQ.position), ckkpkdopogj), this.OFPEBLPKOLD(this.FNEKGBHBNLQ.position));
		}
		return this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(PJKPLOCIBHP), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(PJKPLOCIBHP), ckkpkdopogj), 1349f);
	}

	// Token: 0x060071EB RID: 29163 RVA: 0x00029BAE File Offset: 0x00027DAE
	public int KJEGEBJNLCO()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x060071EC RID: 29164 RVA: 0x00029B71 File Offset: 0x00027D71
	public void LGFICHPHJMD(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x060071ED RID: 29165 RVA: 0x00029BB6 File Offset: 0x00027DB6
	protected virtual void MCPOMCHMKJK()
	{
		base.Awake();
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
		{
			base.enabled = false;
			return;
		}
		this.BENKGIECPLP();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x060071EE RID: 29166 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void CGELNINGDBE()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x060071EF RID: 29167 RVA: 0x00029BAE File Offset: 0x00027DAE
	public int NMCDNIGQQQL()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x060071F0 RID: 29168 RVA: 0x00029B69 File Offset: 0x00027D69
	// (set) Token: 0x060071F3 RID: 29171 RVA: 0x00029B4C File Offset: 0x00027D4C
	public float QMENKNLJMHO { get; private set; }

	// Token: 0x060071F1 RID: 29169 RVA: 0x003764F4 File Offset: 0x003746F4
	public float EOFIEEBOLQD()
	{
		if (this.LNFLKQCLKLD == GJDMGKCLQNQ.None)
		{
			return 1437f;
		}
		float num = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth / this.MNQDCPQDGKI.x;
		float num2 = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight / this.MNQDCPQDGKI.y;
		float num3 = (num <= num2) ? num : num2;
		GJDMGKCLQNQ lnflkqclkld = this.LNFLKQCLKLD;
		if (lnflkqclkld != GJDMGKCLQNQ.None)
		{
			if (lnflkqclkld != GJDMGKCLQNQ.Floor)
			{
				if (lnflkqclkld == GJDMGKCLQNQ.Floor)
				{
					num3 = Mathf.Round(num3);
				}
			}
			else
			{
				num3 = Mathf.Ceil(num3);
			}
		}
		else
		{
			num3 = Mathf.Floor(num3);
		}
		if (num3 < 677f)
		{
			num3 = 158f;
		}
		return num3;
	}

	// Token: 0x060071F2 RID: 29170 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void MKHEGJPOBFG()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x060071F4 RID: 29172 RVA: 0x00029B44 File Offset: 0x00027D44
	public float GBCIGMCNLHB()
	{
		return this.PGPKBQQMGCO;
	}

	// Token: 0x060071F5 RID: 29173 RVA: 0x00376594 File Offset: 0x00374794
	public float FJQLOEKCPCB()
	{
		if (this.LNFLKQCLKLD == GJDMGKCLQNQ.None)
		{
			return 1297f;
		}
		float num = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth / this.MNQDCPQDGKI.x;
		float num2 = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight / this.MNQDCPQDGKI.y;
		float num3 = (num <= num2) ? num : num2;
		GJDMGKCLQNQ lnflkqclkld = this.LNFLKQCLKLD;
		if (lnflkqclkld != GJDMGKCLQNQ.Floor)
		{
			if (lnflkqclkld != (GJDMGKCLQNQ)7)
			{
				if (lnflkqclkld == (GJDMGKCLQNQ)5)
				{
					num3 = Mathf.Round(num3);
				}
			}
			else
			{
				num3 = Mathf.Ceil(num3);
			}
		}
		else
		{
			num3 = Mathf.Floor(num3);
		}
		if (num3 < 379f)
		{
			num3 = 1410f;
		}
		return num3;
	}

	// Token: 0x060071F7 RID: 29175 RVA: 0x00376634 File Offset: 0x00374834
	public float IFGDDLOIFHC()
	{
		if (this.LNFLKQCLKLD == GJDMGKCLQNQ.None)
		{
			return 1f;
		}
		float num = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth / this.MNQDCPQDGKI.x;
		float num2 = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight / this.MNQDCPQDGKI.y;
		float num3 = (num <= num2) ? num : num2;
		GJDMGKCLQNQ lnflkqclkld = this.LNFLKQCLKLD;
		if (lnflkqclkld != GJDMGKCLQNQ.Floor)
		{
			if (lnflkqclkld != GJDMGKCLQNQ.Ceil)
			{
				if (lnflkqclkld == GJDMGKCLQNQ.Round)
				{
					num3 = Mathf.Round(num3);
				}
			}
			else
			{
				num3 = Mathf.Ceil(num3);
			}
		}
		else
		{
			num3 = Mathf.Floor(num3);
		}
		if (num3 < 1f)
		{
			num3 = 1f;
		}
		return num3;
	}

	// Token: 0x060071F8 RID: 29176 RVA: 0x00029B71 File Offset: 0x00027D71
	public void JKCGQKPEMJC(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x060071F9 RID: 29177 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void NDCLKKLFPBN()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x060071FA RID: 29178 RVA: 0x00029BF6 File Offset: 0x00027DF6
	protected override void Awake()
	{
		base.Awake();
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
		{
			base.enabled = false;
			return;
		}
		this.LNJFBDOHQMQ();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x060071FB RID: 29179 RVA: 0x00029BAE File Offset: 0x00027DAE
	public int KJHQMCHHDKG()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x060071FC RID: 29180 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void FGONNFBLJDD()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x060071FD RID: 29181 RVA: 0x003766D4 File Offset: 0x003748D4
	public float GLEIBPKFEMJ()
	{
		if (this.LNFLKQCLKLD == GJDMGKCLQNQ.None)
		{
			return 1004f;
		}
		float num = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth / this.MNQDCPQDGKI.x;
		float num2 = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight / this.MNQDCPQDGKI.y;
		float num3 = (num <= num2) ? num : num2;
		GJDMGKCLQNQ lnflkqclkld = this.LNFLKQCLKLD;
		if (lnflkqclkld != GJDMGKCLQNQ.Floor)
		{
			if (lnflkqclkld != GJDMGKCLQNQ.Round)
			{
				if (lnflkqclkld == (GJDMGKCLQNQ)4)
				{
					num3 = Mathf.Round(num3);
				}
			}
			else
			{
				num3 = Mathf.Ceil(num3);
			}
		}
		else
		{
			num3 = Mathf.Floor(num3);
		}
		if (num3 < 1119f)
		{
			num3 = 553f;
		}
		return num3;
	}

	// Token: 0x060071FE RID: 29182 RVA: 0x00376774 File Offset: 0x00374974
	public void IBLFDOEOCGG()
	{
		this.NNPBIPILDCM(this.MHOLQEHLFKD());
		this.PGPKBQQMGCO = this.QCLONNFJEBG(this.NKDMIJMHGBD());
		float gdjcgbdpfeo = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight * 251f * (430f / this.EKICBMDNMPE) / (this.LHHMQBFQKIK() + (float)this.PJOHKOFQDLC - 1774f);
		base.GPONHFNLHCN.PHJJELLGJOO(gdjcgbdpfeo, 1686f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x060071FF RID: 29183 RVA: 0x003767EC File Offset: 0x003749EC
	public float QCNLFEPQNPM()
	{
		if (this.LNFLKQCLKLD == GJDMGKCLQNQ.None)
		{
			return 1894f;
		}
		float num = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth / this.MNQDCPQDGKI.x;
		float num2 = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight / this.MNQDCPQDGKI.y;
		float num3 = (num <= num2) ? num : num2;
		GJDMGKCLQNQ lnflkqclkld = this.LNFLKQCLKLD;
		if (lnflkqclkld != GJDMGKCLQNQ.Floor)
		{
			if (lnflkqclkld != (GJDMGKCLQNQ)8)
			{
				if (lnflkqclkld == GJDMGKCLQNQ.Floor)
				{
					num3 = Mathf.Round(num3);
				}
			}
			else
			{
				num3 = Mathf.Ceil(num3);
			}
		}
		else
		{
			num3 = Mathf.Floor(num3);
		}
		if (num3 < 1457f)
		{
			num3 = 1729f;
		}
		return num3;
	}

	// Token: 0x06007200 RID: 29184 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void JOLDGDIPFEC()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x06007201 RID: 29185 RVA: 0x0037688C File Offset: 0x00374A8C
	public Vector3 LDCQLGKDLNP(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		float ckkpkdopogj = this.PGPKBQQMGCO;
		if (this.KJEMPPELCQD && !this.ODGCDCLGDOO)
		{
			ckkpkdopogj = 1474f / (this.EKICBMDNMPE * (this.QMENKNLJMHO + (float)this.PJOHKOFQDLC - 1541f));
		}
		this.FNEKGBHBNLQ = this.FHNBJCNLJCN.parent;
		if (this.FNEKGBHBNLQ != null && this.FNEKGBHBNLQ.position != Vector3.zero)
		{
			this.FNEKGBHBNLQ.position = this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(this.FNEKGBHBNLQ.position), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(this.FNEKGBHBNLQ.position), ckkpkdopogj), this.OFPEBLPKOLD(this.FNEKGBHBNLQ.position));
		}
		return this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(PJKPLOCIBHP), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(PJKPLOCIBHP), ckkpkdopogj), 1676f);
	}

	// Token: 0x06007202 RID: 29186 RVA: 0x00029B4C File Offset: 0x00027D4C
	private void EEOCOMJPNKD(float BGBMIEJJQKC)
	{
		this.<PDIGGONFLIO>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007203 RID: 29187 RVA: 0x003769AC File Offset: 0x00374BAC
	public Vector3 HCEDDEMEDKG(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		float ckkpkdopogj = this.PGPKBQQMGCO;
		if (this.KJEMPPELCQD && !this.ODGCDCLGDOO)
		{
			ckkpkdopogj = 1593f / (this.EKICBMDNMPE * (this.MKQNLMOIELL() + (float)this.PJOHKOFQDLC - 1537f));
		}
		this.FNEKGBHBNLQ = this.FHNBJCNLJCN.parent;
		if (this.FNEKGBHBNLQ != null && this.FNEKGBHBNLQ.position != Vector3.zero)
		{
			this.FNEKGBHBNLQ.position = this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(this.FNEKGBHBNLQ.position), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(this.FNEKGBHBNLQ.position), ckkpkdopogj), this.OFPEBLPKOLD(this.FNEKGBHBNLQ.position));
		}
		return this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(PJKPLOCIBHP), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(PJKPLOCIBHP), ckkpkdopogj), 1946f);
	}

	// Token: 0x06007204 RID: 29188 RVA: 0x00029B4C File Offset: 0x00027D4C
	private void CCHNJBEOCDK(float BGBMIEJJQKC)
	{
		this.<PDIGGONFLIO>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007205 RID: 29189 RVA: 0x00376ACC File Offset: 0x00374CCC
	public void FJNJBCPCPDJ()
	{
		this.IPNDEMIIFMM(this.JFMOMBIIJIN());
		this.PGPKBQQMGCO = this.CNOGNOJDMDD(this.MKQNLMOIELL());
		float gdjcgbdpfeo = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight * 541f * (1569f / this.EKICBMDNMPE) / (this.LHHMQBFQKIK() + (float)this.PJOHKOFQDLC - 1522f);
		base.GPONHFNLHCN.LHCFKHKLLOL(gdjcgbdpfeo, 515f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x06007206 RID: 29190 RVA: 0x00029BAE File Offset: 0x00027DAE
	public int BPHKIHFGIQH()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x06007207 RID: 29191 RVA: 0x00376B44 File Offset: 0x00374D44
	public void JHCJCCCPLIE()
	{
		this.HKHCBJMCPMB(this.OKBMNFJEBPQ());
		this.PGPKBQQMGCO = this.BDOQBQGBNMC(this.EQDHFENOLPK());
		float gdjcgbdpfeo = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight * 434f * (1035f / this.EKICBMDNMPE) / (this.LHHMQBFQKIK() + (float)this.PJOHKOFQDLC - 972f);
		base.GPONHFNLHCN.LHCFKHKLLOL(gdjcgbdpfeo, 1505f, GMNJJQQPEDB.EaseInOut);
	}

	// Token: 0x06007208 RID: 29192 RVA: 0x00376BBC File Offset: 0x00374DBC
	public float OKBMNFJEBPQ()
	{
		if (this.LNFLKQCLKLD == GJDMGKCLQNQ.None)
		{
			return 203f;
		}
		float num = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth / this.MNQDCPQDGKI.x;
		float num2 = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight / this.MNQDCPQDGKI.y;
		float num3 = (num <= num2) ? num : num2;
		GJDMGKCLQNQ lnflkqclkld = this.LNFLKQCLKLD;
		if (lnflkqclkld != GJDMGKCLQNQ.None)
		{
			if (lnflkqclkld != (GJDMGKCLQNQ)7)
			{
				if (lnflkqclkld == GJDMGKCLQNQ.None)
				{
					num3 = Mathf.Round(num3);
				}
			}
			else
			{
				num3 = Mathf.Ceil(num3);
			}
		}
		else
		{
			num3 = Mathf.Floor(num3);
		}
		if (num3 < 724f)
		{
			num3 = 1924f;
		}
		return num3;
	}

	// Token: 0x06007209 RID: 29193 RVA: 0x00029C2A File Offset: 0x00027E2A
	private float CNOGNOJDMDD(float HIOBDNHNGKB)
	{
		return (!this.KJEMPPELCQD) ? (448f / (this.EKICBMDNMPE * (HIOBDNHNGKB + (float)this.PJOHKOFQDLC - 535f))) : (1108f / this.EKICBMDNMPE);
	}

	// Token: 0x0600720A RID: 29194 RVA: 0x00376C5C File Offset: 0x00374E5C
	public void BDJEMOLKJDE()
	{
		this.QMENKNLJMHO = this.EOFIEEBOLQD();
		this.PGPKBQQMGCO = this.CNOGNOJDMDD(this.MHIHPGIFBBP());
		float gdjcgbdpfeo = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight * 1638f * (1915f / this.EKICBMDNMPE) / (this.EQDHFENOLPK() + (float)this.PJOHKOFQDLC - 894f);
		base.GPONHFNLHCN.PHJJELLGJOO(gdjcgbdpfeo, 1572f, GMNJJQQPEDB.EaseInOut);
	}

	// Token: 0x0600720B RID: 29195 RVA: 0x00376CD4 File Offset: 0x00374ED4
	public void LNJFBDOHQMQ()
	{
		this.QMENKNLJMHO = this.IFGDDLOIFHC();
		this.PGPKBQQMGCO = this.QCLONNFJEBG(this.QMENKNLJMHO);
		float gdjcgbdpfeo = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight * 0.5f * (1f / this.EKICBMDNMPE) / (this.QMENKNLJMHO + (float)this.PJOHKOFQDLC - 1f);
		base.GPONHFNLHCN.LHCFKHKLLOL(gdjcgbdpfeo, 0f, GMNJJQQPEDB.EaseInOut);
	}

	// Token: 0x0600720C RID: 29196 RVA: 0x00029B4C File Offset: 0x00027D4C
	private void HKHCBJMCPMB(float BGBMIEJJQKC)
	{
		this.<PDIGGONFLIO>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600720D RID: 29197 RVA: 0x00029C5E File Offset: 0x00027E5E
	private float BDOQBQGBNMC(float HIOBDNHNGKB)
	{
		return (!this.KJEMPPELCQD) ? (1619f / (this.EKICBMDNMPE * (HIOBDNHNGKB + (float)this.PJOHKOFQDLC - 1341f))) : (771f / this.EKICBMDNMPE);
	}

	// Token: 0x0600720E RID: 29198 RVA: 0x00376D4C File Offset: 0x00374F4C
	public Vector3 HJMKOGJNBKD(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		float ckkpkdopogj = this.PGPKBQQMGCO;
		if (this.KJEMPPELCQD && !this.ODGCDCLGDOO)
		{
			ckkpkdopogj = 1745f / (this.EKICBMDNMPE * (this.EQDHFENOLPK() + (float)this.PJOHKOFQDLC - 564f));
		}
		this.FNEKGBHBNLQ = this.FHNBJCNLJCN.parent;
		if (this.FNEKGBHBNLQ != null && this.FNEKGBHBNLQ.position != Vector3.zero)
		{
			this.FNEKGBHBNLQ.position = this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(this.FNEKGBHBNLQ.position), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(this.FNEKGBHBNLQ.position), ckkpkdopogj), this.OFPEBLPKOLD(this.FNEKGBHBNLQ.position));
		}
		return this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(PJKPLOCIBHP), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(PJKPLOCIBHP), ckkpkdopogj), 1538f);
	}

	// Token: 0x0600720F RID: 29199 RVA: 0x00376E6C File Offset: 0x0037506C
	public void HEIDDQGKJJG()
	{
		this.IPNDEMIIFMM(this.MHOLQEHLFKD());
		this.PGPKBQQMGCO = this.GHIPOIFPOGQ(this.EQDHFENOLPK());
		float gdjcgbdpfeo = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight * 629f * (353f / this.EKICBMDNMPE) / (this.EQDHFENOLPK() + (float)this.PJOHKOFQDLC - 358f);
		base.GPONHFNLHCN.PHJJELLGJOO(gdjcgbdpfeo, 336f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x06007210 RID: 29200 RVA: 0x00029C92 File Offset: 0x00027E92
	protected virtual void IPKCDQONLBJ()
	{
		base.Awake();
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
		{
			base.enabled = false;
			return;
		}
		this.IBLFDOEOCGG();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x06007211 RID: 29201 RVA: 0x00029B69 File Offset: 0x00027D69
	public float NKDMIJMHGBD()
	{
		return this.<PDIGGONFLIO>k__BackingField;
	}

	// Token: 0x06007212 RID: 29202 RVA: 0x00029B71 File Offset: 0x00027D71
	public void FNLEPLHPPQJ(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x06007213 RID: 29203 RVA: 0x00376EE4 File Offset: 0x003750E4
	public void LNQCPQBFFDK()
	{
		this.NNPBIPILDCM(this.QCNLFEPQNPM());
		this.PGPKBQQMGCO = this.BDOQBQGBNMC(this.QMENKNLJMHO);
		float gdjcgbdpfeo = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight * 1641f * (1030f / this.EKICBMDNMPE) / (this.MHIHPGIFBBP() + (float)this.PJOHKOFQDLC - 1190f);
		base.GPONHFNLHCN.PHJJELLGJOO(gdjcgbdpfeo, 1964f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x06007214 RID: 29204 RVA: 0x00029B71 File Offset: 0x00027D71
	public void ICJJKBBCMQO(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x06007215 RID: 29205 RVA: 0x00029B69 File Offset: 0x00027D69
	public float MKQNLMOIELL()
	{
		return this.<PDIGGONFLIO>k__BackingField;
	}

	// Token: 0x06007216 RID: 29206 RVA: 0x00029B69 File Offset: 0x00027D69
	public float EQDHFENOLPK()
	{
		return this.<PDIGGONFLIO>k__BackingField;
	}

	// Token: 0x06007217 RID: 29207 RVA: 0x00029B69 File Offset: 0x00027D69
	public float LHHMQBFQKIK()
	{
		return this.<PDIGGONFLIO>k__BackingField;
	}

	// Token: 0x06007218 RID: 29208 RVA: 0x00029CC6 File Offset: 0x00027EC6
	protected virtual void ICINMCLMJDJ()
	{
		base.Awake();
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
		{
			base.enabled = false;
			return;
		}
		this.BDJEMOLKJDE();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x06007219 RID: 29209 RVA: 0x00029CFA File Offset: 0x00027EFA
	private float QCLONNFJEBG(float HIOBDNHNGKB)
	{
		return (!this.KJEMPPELCQD) ? (1f / (this.EKICBMDNMPE * (HIOBDNHNGKB + (float)this.PJOHKOFQDLC - 1f))) : (1f / this.EKICBMDNMPE);
	}

	// Token: 0x0600721A RID: 29210 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void HMNFDLJGBIM()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x0600721B RID: 29211 RVA: 0x00029D2E File Offset: 0x00027F2E
	protected virtual void NKFQOJPEFKD()
	{
		base.Awake();
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
		{
			base.enabled = true;
			return;
		}
		this.BDJEMOLKJDE();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x170003F0 RID: 1008
	// (get) Token: 0x0600721C RID: 29212 RVA: 0x00029B44 File Offset: 0x00027D44
	public float GDDPQBJPKLP
	{
		get
		{
			return this.PGPKBQQMGCO;
		}
	}

	// Token: 0x0600721D RID: 29213 RVA: 0x00029B71 File Offset: 0x00027D71
	public void HDHHGPOQGGJ(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x0600721E RID: 29214 RVA: 0x00376F5C File Offset: 0x0037515C
	public void HQEEOGCPMHJ()
	{
		this.BOPMBNDDDHE(this.IFGDDLOIFHC());
		this.PGPKBQQMGCO = this.QCLONNFJEBG(this.QMENKNLJMHO);
		float gdjcgbdpfeo = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight * 1551f * (49f / this.EKICBMDNMPE) / (this.MKQNLMOIELL() + (float)this.PJOHKOFQDLC - 555f);
		base.GPONHFNLHCN.LHCFKHKLLOL(gdjcgbdpfeo, 1138f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x0600721F RID: 29215 RVA: 0x00029B71 File Offset: 0x00027D71
	public void PFDEINMLOLN(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x06007221 RID: 29217 RVA: 0x00029B44 File Offset: 0x00027D44
	public float QLIFMBPBHQL()
	{
		return this.PGPKBQQMGCO;
	}

	// Token: 0x06007222 RID: 29218 RVA: 0x00029B4C File Offset: 0x00027D4C
	private void NNPBIPILDCM(float BGBMIEJJQKC)
	{
		this.<PDIGGONFLIO>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007223 RID: 29219 RVA: 0x00029B44 File Offset: 0x00027D44
	public float CEQMFPNGKLH()
	{
		return this.PGPKBQQMGCO;
	}

	// Token: 0x06007224 RID: 29220 RVA: 0x00377054 File Offset: 0x00375254
	public float MHOLQEHLFKD()
	{
		if (this.LNFLKQCLKLD == GJDMGKCLQNQ.None)
		{
			return 696f;
		}
		float num = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth / this.MNQDCPQDGKI.x;
		float num2 = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight / this.MNQDCPQDGKI.y;
		float num3 = (num <= num2) ? num : num2;
		GJDMGKCLQNQ lnflkqclkld = this.LNFLKQCLKLD;
		if (lnflkqclkld != GJDMGKCLQNQ.None)
		{
			if (lnflkqclkld != (GJDMGKCLQNQ)8)
			{
				if (lnflkqclkld == (GJDMGKCLQNQ)5)
				{
					num3 = Mathf.Round(num3);
				}
			}
			else
			{
				num3 = Mathf.Ceil(num3);
			}
		}
		else
		{
			num3 = Mathf.Floor(num3);
		}
		if (num3 < 661f)
		{
			num3 = 1460f;
		}
		return num3;
	}

	// Token: 0x06007225 RID: 29221 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void GDDBJCOJNKC()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x06007226 RID: 29222 RVA: 0x00029B55 File Offset: 0x00027D55
	protected override void OnDestroy()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x06007227 RID: 29223 RVA: 0x00029BAE File Offset: 0x00027DAE
	public int OOLOINHCLHO()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x06007228 RID: 29224 RVA: 0x00029D62 File Offset: 0x00027F62
	protected virtual void KLFJOJOOECI()
	{
		base.Awake();
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
		{
			base.enabled = false;
			return;
		}
		this.JHCJCCCPLIE();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x06007229 RID: 29225 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void FOJBEMBDPQI()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x0600722A RID: 29226 RVA: 0x00029D96 File Offset: 0x00027F96
	private float GHIPOIFPOGQ(float HIOBDNHNGKB)
	{
		return (!this.KJEMPPELCQD) ? (1290f / (this.EKICBMDNMPE * (HIOBDNHNGKB + (float)this.PJOHKOFQDLC - 811f))) : (897f / this.EKICBMDNMPE);
	}

	// Token: 0x0600722B RID: 29227 RVA: 0x00029C92 File Offset: 0x00027E92
	protected virtual void COGJQEEGCFB()
	{
		base.Awake();
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
		{
			base.enabled = false;
			return;
		}
		this.IBLFDOEOCGG();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x0600722C RID: 29228 RVA: 0x003770F4 File Offset: 0x003752F4
	public Vector3 FJNLCIFDHQI(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		float ckkpkdopogj = this.PGPKBQQMGCO;
		if (this.KJEMPPELCQD && !this.ODGCDCLGDOO)
		{
			ckkpkdopogj = 685f / (this.EKICBMDNMPE * (this.EQDHFENOLPK() + (float)this.PJOHKOFQDLC - 1982f));
		}
		this.FNEKGBHBNLQ = this.FHNBJCNLJCN.parent;
		if (this.FNEKGBHBNLQ != null && this.FNEKGBHBNLQ.position != Vector3.zero)
		{
			this.FNEKGBHBNLQ.position = this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(this.FNEKGBHBNLQ.position), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(this.FNEKGBHBNLQ.position), ckkpkdopogj), this.OFPEBLPKOLD(this.FNEKGBHBNLQ.position));
		}
		return this.JQCCJCOPEJK(BDKMFJQPGGE.EFJBNBNMJMH(this.FKGNBCKJPQO(PJKPLOCIBHP), ckkpkdopogj), BDKMFJQPGGE.EFJBNBNMJMH(this.JNBBJCLFFBB(PJKPLOCIBHP), ckkpkdopogj), 1706f);
	}

	// Token: 0x0600722E RID: 29230 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void EBIOOCEIFLL()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x0600722F RID: 29231 RVA: 0x00029B69 File Offset: 0x00027D69
	public float MHIHPGIFBBP()
	{
		return this.<PDIGGONFLIO>k__BackingField;
	}

	// Token: 0x06007230 RID: 29232 RVA: 0x00029B4C File Offset: 0x00027D4C
	private void MMNQCIHFIKK(float BGBMIEJJQKC)
	{
		this.<PDIGGONFLIO>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007231 RID: 29233 RVA: 0x00029B71 File Offset: 0x00027D71
	public void EBBEIILCLNQ(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x06007232 RID: 29234 RVA: 0x00029B4C File Offset: 0x00027D4C
	private void IPNDEMIIFMM(float BGBMIEJJQKC)
	{
		this.<PDIGGONFLIO>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007233 RID: 29235 RVA: 0x00029B55 File Offset: 0x00027D55
	protected virtual void EFOICIBCCQB()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
	}

	// Token: 0x06007234 RID: 29236 RVA: 0x00029BAE File Offset: 0x00027DAE
	public int NPQGOEONJBF()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x06007235 RID: 29237 RVA: 0x00377214 File Offset: 0x00375414
	public float PBDQKECFEEL()
	{
		if (this.LNFLKQCLKLD == GJDMGKCLQNQ.None)
		{
			return 717f;
		}
		float num = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth / this.MNQDCPQDGKI.x;
		float num2 = (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight / this.MNQDCPQDGKI.y;
		float num3 = (num <= num2) ? num : num2;
		GJDMGKCLQNQ lnflkqclkld = this.LNFLKQCLKLD;
		if (lnflkqclkld != GJDMGKCLQNQ.None)
		{
			if (lnflkqclkld != GJDMGKCLQNQ.Round)
			{
				if (lnflkqclkld == (GJDMGKCLQNQ)7)
				{
					num3 = Mathf.Round(num3);
				}
			}
			else
			{
				num3 = Mathf.Ceil(num3);
			}
		}
		else
		{
			num3 = Mathf.Floor(num3);
		}
		if (num3 < 1010f)
		{
			num3 = 914f;
		}
		return num3;
	}

	// Token: 0x06007236 RID: 29238 RVA: 0x00029B44 File Offset: 0x00027D44
	public float OPOILLKHENB()
	{
		return this.PGPKBQQMGCO;
	}

	// Token: 0x04001886 RID: 6278
	public static string OPGNGFNJDDP = "Pixel Perfect";

	// Token: 0x04001887 RID: 6279
	public float EKICBMDNMPE = 32f;

	// Token: 0x04001888 RID: 6280
	public GJDMGKCLQNQ LNFLKQCLKLD = GJDMGKCLQNQ.Round;

	// Token: 0x04001889 RID: 6281
	public Vector2 MNQDCPQDGKI = new Vector2(80f, 50f);

	// Token: 0x0400188A RID: 6282
	[Range(1f, 32f)]
	public int PJOHKOFQDLC = 1;

	// Token: 0x0400188B RID: 6283
	public bool KJEMPPELCQD;

	// Token: 0x0400188C RID: 6284
	public bool ODGCDCLGDOO = true;

	// Token: 0x0400188D RID: 6285
	public bool MJLNNOLPHFH;

	// Token: 0x0400188E RID: 6286
	public Color MEGNEKEIGOO = new Color(1f, 0f, 0f, 0.1f);

	// Token: 0x0400188F RID: 6287
	public float GNNGBOILMKC;

	// Token: 0x04001891 RID: 6289
	private float PGPKBQQMGCO = -1f;

	// Token: 0x04001892 RID: 6290
	private Transform FNEKGBHBNLQ;

	// Token: 0x04001893 RID: 6291
	private int HNMJQQFFBCL = 2000;
}
