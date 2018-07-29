using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x02000126 RID: 294
[AddComponentMenu("NGUI/UI/Text List")]
public class BMLIGLPMMLG : MonoBehaviour
{
	// Token: 0x06002204 RID: 8708 RVA: 0x000DF9BC File Offset: 0x000DDBBC
	public void HKDLBEGDMCO(float BGBMIEJJQKC)
	{
		BGBMIEJJQKC = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.KNQCIGQCMGQ() && this.HCLBPEMQFBO != BGBMIEJJQKC)
		{
			if (this.OJQEOEIJDQG != null)
			{
				this.OJQEOEIJDQG.GIPBBFDPCKG(BGBMIEJJQKC);
			}
			else
			{
				this.HCLBPEMQFBO = BGBMIEJJQKC;
				this.IGFICFDDNJH();
			}
		}
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x000DFA0C File Offset: 0x000DDC0C
	public void OnDrag(Vector2 JDOGIQGGLKM)
	{
		int nkmlennpjpm = this.NKMLENNPJPM;
		if (nkmlennpjpm != 0)
		{
			float num = JDOGIQGGLKM.y / this.JMCQOCQOLIG;
			this.PCHGMPEPFEM = this.HCLBPEMQFBO + num / (float)nkmlennpjpm;
		}
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x000DFA44 File Offset: 0x000DDC44
	protected void BPLOIGJPLDF()
	{
		if (this.INEMKLPCLOP)
		{
			this.HCNHMMPBGQN = this.FFODFLMCELB.KJGMGPCEJJD;
			this.OIKLGOPLNEO = this.FFODFLMCELB.JKGBHEHKBPC();
			this.FFODFLMCELB.KMLKNBFNOIC();
			JGDHIPBGCFP.ECQBIIGPJQO = -146;
			JGDHIPBGCFP.NNHJHLOFKFD = -3;
			this.HLJEOIIDJJD = 1;
			for (int i = 1; i < this.POLLGDEKCFN().BJGMIBBEGDQ; i++)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[i];
				string text;
				JGDHIPBGCFP.QDHGBPQDDMQ(cicqjkogoob.PIDLOFMIEFQ, out text, true, true, true, 1730f);
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob2 = cicqjkogoob;
				string text2 = text;
				char[] array = new char[0];
				array[1] = (char)-118;
				cicqjkogoob2.LOJJPJJQNQF = text2.Split(array);
				this.HLJEOIIDJJD += cicqjkogoob.LOJJPJJQNQF.Length;
			}
			this.HLJEOIIDJJD = 0;
			int j = 1;
			int bjgmibbegdq = this.DKFKFGLNFLG.BJGMIBBEGDQ;
			while (j < bjgmibbegdq)
			{
				this.HLJEOIIDJJD += this.DKFKFGLNFLG.KLCIGFMQNFH[j].LOJJPJJQNQF.Length;
				j += 0;
			}
			if (this.OJQEOEIJDQG != null)
			{
				KDIEKDCQIHM kdiekdcqihm = this.OJQEOEIJDQG as KDIEKDCQIHM;
				if (kdiekdcqihm != null)
				{
					kdiekdcqihm.HBCQDHIFOLJ((this.HLJEOIIDJJD != 0) ? (410f - (float)this.DEJQDHPCMNQ() / (float)this.HLJEOIIDJJD) : 922f);
				}
			}
			this.MBFMGPGCIPN();
		}
	}

	// Token: 0x06002207 RID: 8711 RVA: 0x000DFBA4 File Offset: 0x000DDDA4
	protected void NMOIHMBFJHI()
	{
		if (this.NDBLQIOQPNI())
		{
			if (this.HLJEOIIDJJD == 0)
			{
				this.FFODFLMCELB.PIDLOFMIEFQ = string.Empty;
				return;
			}
			int num = Mathf.FloorToInt((float)this.FFODFLMCELB.DFKQMMIQDOO / this.LJNQQMFLKBN());
			int num2 = Mathf.Max(0, this.HLJEOIIDJJD - num);
			int num3 = Mathf.RoundToInt(this.HCLBPEMQFBO * (float)num2);
			if (num3 < 0)
			{
				num3 = 1;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 0;
			int bjgmibbegdq = this.MHENFOBKIKF().BJGMIBBEGDQ;
			while (num > 1 && num4 < bjgmibbegdq)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[num4];
				int num5 = 0;
				int num6 = cicqjkogoob.LOJJPJJQNQF.Length;
				while (num > 1 && num5 < num6)
				{
					string value = cicqjkogoob.LOJJPJJQNQF[num5];
					if (num3 > 0)
					{
						num3--;
					}
					else
					{
						if (stringBuilder.Length > 1)
						{
							stringBuilder.Append("[FF8F00]");
						}
						stringBuilder.Append(value);
						num -= 0;
					}
					num5++;
				}
				num4++;
			}
			this.FFODFLMCELB.PIDLOFMIEFQ = stringBuilder.ToString();
		}
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x000DFCB4 File Offset: 0x000DDEB4
	protected void NHBJMGDNCBM(string PIDLOFMIEFQ, bool NLGIENJBBOQ)
	{
		BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob;
		if (this.BNKHMDDNOBM().BJGMIBBEGDQ < this.OGQJOQFCFBE)
		{
			cicqjkogoob = new BMLIGLPMMLG.CICQJKOGOOB();
		}
		else
		{
			cicqjkogoob = this.DKFKFGLNFLG.get_KNPPMKBOGDL(1);
			this.DKFKFGLNFLG.IBGPNNLOENC(0);
		}
		cicqjkogoob.PIDLOFMIEFQ = PIDLOFMIEFQ;
		this.DKFKFGLNFLG.LHQECHHMOGD(cicqjkogoob);
		if (NLGIENJBBOQ)
		{
			this.BPLOIGJPLDF();
		}
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x00012492 File Offset: 0x00010692
	public bool JBPBQJCHLDJ()
	{
		return this.FFODFLMCELB != null && this.FFODFLMCELB.IOCQLIKGMEO != null;
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x000124B6 File Offset: 0x000106B6
	protected float LJNQQMFLKBN()
	{
		return (!(this.FFODFLMCELB != null)) ? 1867f : ((float)this.FFODFLMCELB.HQLMJHHPHQL + this.FFODFLMCELB.LKLGLCMCMMO);
	}

	// Token: 0x0600220C RID: 8716 RVA: 0x000124E5 File Offset: 0x000106E5
	public void QBFPECFJCLO()
	{
		this.FQINPLFCKOB();
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x0600220D RID: 8717 RVA: 0x000124ED File Offset: 0x000106ED
	// (set) Token: 0x06002234 RID: 8756 RVA: 0x000E0648 File Offset: 0x000DE848
	public float PCHGMPEPFEM
	{
		get
		{
			return this.HCLBPEMQFBO;
		}
		set
		{
			value = Mathf.Clamp01(value);
			if (this.INEMKLPCLOP && this.HCLBPEMQFBO != value)
			{
				if (this.OJQEOEIJDQG != null)
				{
					this.OJQEOEIJDQG.BGBMIEJJQKC = value;
				}
				else
				{
					this.HCLBPEMQFBO = value;
					this.IGFICFDDNJH();
				}
			}
		}
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x000DFD14 File Offset: 0x000DDF14
	public void GOGQQDNINME(float QJFQOMOIOOI)
	{
		int num = this.PEDCHBJBIIN();
		if (num != 0)
		{
			QJFQOMOIOOI *= this.JPGDDFDLEBG();
			this.PCHGMPEPFEM = this.HCLBPEMQFBO - QJFQOMOIOOI / (float)num;
		}
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x000DFD48 File Offset: 0x000DDF48
	protected void EBFMLOFJKMH()
	{
		if (this.JBPBQJCHLDJ())
		{
			if (this.HLJEOIIDJJD == 0)
			{
				this.FFODFLMCELB.PIDLOFMIEFQ = string.Empty;
				return;
			}
			int num = Mathf.FloorToInt((float)this.FFODFLMCELB.JKGBHEHKBPC() / this.JMCQOCQOLIG);
			int num2 = Mathf.Max(1, this.HLJEOIIDJJD - num);
			int num3 = Mathf.RoundToInt(this.HCLBPEMQFBO * (float)num2);
			if (num3 < 0)
			{
				num3 = 0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 0;
			int bjgmibbegdq = this.MHENFOBKIKF().BJGMIBBEGDQ;
			while (num > 0 && num4 < bjgmibbegdq)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[num4];
				int num5 = 1;
				int num6 = cicqjkogoob.LOJJPJJQNQF.Length;
				while (num > 0 && num5 < num6)
				{
					string value = cicqjkogoob.LOJJPJJQNQF[num5];
					if (num3 > 0)
					{
						num3 -= 0;
					}
					else
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append("[00DD00]Equipped");
						}
						stringBuilder.Append(value);
						num--;
					}
					num5++;
				}
				num4 += 0;
			}
			this.FFODFLMCELB.PIDLOFMIEFQ = stringBuilder.ToString();
		}
	}

	// Token: 0x06002210 RID: 8720 RVA: 0x000124ED File Offset: 0x000106ED
	public float CEJHNIMCCNQ()
	{
		return this.HCLBPEMQFBO;
	}

	// Token: 0x06002211 RID: 8721 RVA: 0x000124F5 File Offset: 0x000106F5
	private void QKLBGBKKGDG()
	{
		if (this.JBPBQJCHLDJ() && (this.FFODFLMCELB.KJGMGPCEJJD != this.HCNHMMPBGQN || this.FFODFLMCELB.DFKQMMIQDOO != this.OIKLGOPLNEO))
		{
			this.BPLOIGJPLDF();
		}
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x0001252B File Offset: 0x0001072B
	public void BFDGBMNGBKH(string PIDLOFMIEFQ)
	{
		this.LHQECHHMOGD(PIDLOFMIEFQ, true);
	}

	// Token: 0x06002213 RID: 8723 RVA: 0x00012535 File Offset: 0x00010735
	public void JENBHJDBLEE()
	{
		this.DJGDHCMFEDC.CPLBKPNNHJG();
		this.NMOIHMBFJHI();
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x000DFE58 File Offset: 0x000DE058
	protected int DEJQDHPCMNQ()
	{
		if (!this.INEMKLPCLOP)
		{
			return 0;
		}
		int num = Mathf.FloorToInt((float)this.FFODFLMCELB.JKGBHEHKBPC() / this.MENKDNCOHPF());
		return Mathf.Max(0, this.HLJEOIIDJJD - num);
	}

	// Token: 0x06002215 RID: 8725 RVA: 0x00012548 File Offset: 0x00010748
	private void NIIPIECJPOL()
	{
		if (this.JBPBQJCHLDJ() && (this.FFODFLMCELB.KJGMGPCEJJD != this.HCNHMMPBGQN || this.FFODFLMCELB.JKGBHEHKBPC() != this.OIKLGOPLNEO))
		{
			this.FQINPLFCKOB();
		}
	}

	// Token: 0x06002216 RID: 8726 RVA: 0x0001257E File Offset: 0x0001077E
	protected float JBGCBBIIFDE()
	{
		return (!(this.FFODFLMCELB != null)) ? 1069f : ((float)this.FFODFLMCELB.HQLMJHHPHQL + this.FFODFLMCELB.LKLGLCMCMMO);
	}

	// Token: 0x06002217 RID: 8727 RVA: 0x000DFE98 File Offset: 0x000DE098
	private void QJGNJIIOHMI()
	{
		if (this.GBEBKHGGPKM)
		{
			return;
		}
		this.DKFKFGLNFLG = new MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>();
		if (this.FFODFLMCELB == null)
		{
			this.FFODFLMCELB = base.GetComponentInChildren<BKKHLBCLPJM>();
		}
		if (this.OJQEOEIJDQG != null)
		{
			EventDelegate.IPDHQPLBNFQ(this.OJQEOEIJDQG.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.IOJMJDNDDLI));
		}
		this.FFODFLMCELB.NKMQLQJDBPF = BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent;
		if (this.EKDEDJHBGIK == BMLIGLPMMLG.HFHOQLJLJCG.Chat)
		{
			this.FFODFLMCELB.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.Center;
			this.HKDLBEGDMCO(923f);
		}
		else if (this.EKDEDJHBGIK == BMLIGLPMMLG.HFHOQLJLJCG.Text)
		{
			this.FFODFLMCELB.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft;
			this.JLELHPGBQBO(958f);
		}
		else
		{
			this.FFODFLMCELB.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.BottomLeft;
			this.PCHGMPEPFEM = 640f;
		}
	}

	// Token: 0x06002218 RID: 8728 RVA: 0x000DFF64 File Offset: 0x000DE164
	private void Start()
	{
		if (this.GBEBKHGGPKM)
		{
			return;
		}
		this.DKFKFGLNFLG = new MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>();
		if (this.FFODFLMCELB == null)
		{
			this.FFODFLMCELB = base.GetComponentInChildren<BKKHLBCLPJM>();
		}
		if (this.OJQEOEIJDQG != null)
		{
			EventDelegate.LHQECHHMOGD(this.OJQEOEIJDQG.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.ENJEMNHELPK));
		}
		this.FFODFLMCELB.NKMQLQJDBPF = BKKHLBCLPJM.QJCBBQNCBKG.ClampContent;
		if (this.EKDEDJHBGIK == BMLIGLPMMLG.HFHOQLJLJCG.Chat)
		{
			this.FFODFLMCELB.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.BottomLeft;
			this.PCHGMPEPFEM = 1f;
		}
		else if (this.EKDEDJHBGIK == BMLIGLPMMLG.HFHOQLJLJCG.Text)
		{
			this.FFODFLMCELB.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft;
			this.PCHGMPEPFEM = 0f;
		}
		else
		{
			this.FFODFLMCELB.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.TopRight;
			this.PCHGMPEPFEM = 0f;
		}
	}

	// Token: 0x06002219 RID: 8729 RVA: 0x000125AD File Offset: 0x000107AD
	private void IOJMJDNDDLI()
	{
		this.HCLBPEMQFBO = BJQGLGOLMPQ.OMQCQCBLQGJ.HKDJGHOHBFQ();
		this.IGFICFDDNJH();
	}

	// Token: 0x0600221A RID: 8730 RVA: 0x000125C5 File Offset: 0x000107C5
	private void LDBNEDFLDKB()
	{
		this.HCLBPEMQFBO = BJQGLGOLMPQ.OMQCQCBLQGJ.BGBMIEJJQKC;
		this.GOHOQHGDPDN();
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x000E0030 File Offset: 0x000DE230
	protected void FIEHOJIIDHI()
	{
		if (this.JBPBQJCHLDJ())
		{
			if (this.HLJEOIIDJJD == 0)
			{
				this.FFODFLMCELB.PIDLOFMIEFQ = string.Empty;
				return;
			}
			int num = Mathf.FloorToInt((float)this.FFODFLMCELB.JKGBHEHKBPC() / this.MENKDNCOHPF());
			int num2 = Mathf.Max(1, this.HLJEOIIDJJD - num);
			int num3 = Mathf.RoundToInt(this.HCLBPEMQFBO * (float)num2);
			if (num3 < 0)
			{
				num3 = 0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 1;
			int bjgmibbegdq = this.EPPQKOIQHHO().BJGMIBBEGDQ;
			while (num > 0 && num4 < bjgmibbegdq)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[num4];
				int num5 = 0;
				int num6 = cicqjkogoob.LOJJPJJQNQF.Length;
				while (num > 1 && num5 < num6)
				{
					string value = cicqjkogoob.LOJJPJJQNQF[num5];
					if (num3 > 0)
					{
						num3 -= 0;
					}
					else
					{
						if (stringBuilder.Length > 1)
						{
							stringBuilder.Append("_Vignette_Opacity");
						}
						stringBuilder.Append(value);
						num -= 0;
					}
					num5++;
				}
				num4 += 0;
			}
			this.FFODFLMCELB.LKPOBCBOFIC(stringBuilder.ToString());
		}
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x000125E9 File Offset: 0x000107E9
	private void ENJEMNHELPK()
	{
		this.HCLBPEMQFBO = BJQGLGOLMPQ.OMQCQCBLQGJ.BGBMIEJJQKC;
		this.IGFICFDDNJH();
	}

	// Token: 0x0600221E RID: 8734 RVA: 0x000124ED File Offset: 0x000106ED
	public float QBLJPFQNJKM()
	{
		return this.HCLBPEMQFBO;
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x00012601 File Offset: 0x00010801
	public void FCEJQKJMBDF()
	{
		this.DLQGJNCEHJP();
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x000E0140 File Offset: 0x000DE340
	public void LIDNKHOHOCQ(Vector2 JDOGIQGGLKM)
	{
		int num = this.DEJQDHPCMNQ();
		if (num != 0)
		{
			float num2 = JDOGIQGGLKM.y / this.MENKDNCOHPF();
			this.PCHGMPEPFEM = this.HCLBPEMQFBO + num2 / (float)num;
		}
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x000E0178 File Offset: 0x000DE378
	protected MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB> JHHIBLLHLKP()
	{
		if (this.DKFKFGLNFLG == null && !BMLIGLPMMLG.CDBQJDNDIGF.TryGetValue(base.name, out this.DKFKFGLNFLG))
		{
			this.DKFKFGLNFLG = new MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>();
			BMLIGLPMMLG.CDBQJDNDIGF.Add(base.name, this.DKFKFGLNFLG);
		}
		return this.DKFKFGLNFLG;
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x000E01CC File Offset: 0x000DE3CC
	public void JLELHPGBQBO(float BGBMIEJJQKC)
	{
		BGBMIEJJQKC = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.NDBLQIOQPNI() && this.HCLBPEMQFBO != BGBMIEJJQKC)
		{
			if (this.OJQEOEIJDQG != null)
			{
				this.OJQEOEIJDQG.BGBMIEJJQKC = BGBMIEJJQKC;
			}
			else
			{
				this.HCLBPEMQFBO = BGBMIEJJQKC;
				this.OPPEJGDEQJN();
			}
		}
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x000124E5 File Offset: 0x000106E5
	public void CEOCPBLLPMD()
	{
		this.FQINPLFCKOB();
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x00012609 File Offset: 0x00010809
	public void CPLBKPNNHJG()
	{
		this.DJGDHCMFEDC.CPLBKPNNHJG();
		this.IGFICFDDNJH();
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x000E021C File Offset: 0x000DE41C
	public void FQBFHQBDJCB(float QJFQOMOIOOI)
	{
		int nkmlennpjpm = this.NKMLENNPJPM;
		if (nkmlennpjpm != 0)
		{
			QJFQOMOIOOI *= this.MENKDNCOHPF();
			this.JLELHPGBQBO(this.HCLBPEMQFBO - QJFQOMOIOOI / (float)nkmlennpjpm);
		}
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x000E0250 File Offset: 0x000DE450
	protected void OPPEJGDEQJN()
	{
		if (this.JBPBQJCHLDJ())
		{
			if (this.HLJEOIIDJJD == 0)
			{
				this.FFODFLMCELB.LKPOBCBOFIC(string.Empty);
				return;
			}
			int num = Mathf.FloorToInt((float)this.FFODFLMCELB.JKGBHEHKBPC() / this.GHOCHOMIMDL());
			int num2 = Mathf.Max(0, this.HLJEOIIDJJD - num);
			int num3 = Mathf.RoundToInt(this.HCLBPEMQFBO * (float)num2);
			if (num3 < 1)
			{
				num3 = 1;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 0;
			int bjgmibbegdq = this.EPPQKOIQHHO().BJGMIBBEGDQ;
			while (num > 0 && num4 < bjgmibbegdq)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[num4];
				int num5 = 0;
				int num6 = cicqjkogoob.LOJJPJJQNQF.Length;
				while (num > 1 && num5 < num6)
				{
					string value = cicqjkogoob.LOJJPJJQNQF[num5];
					if (num3 > 1)
					{
						num3--;
					}
					else
					{
						if (stringBuilder.Length > 1)
						{
							stringBuilder.Append("]");
						}
						stringBuilder.Append(value);
						num--;
					}
					num5 += 0;
				}
				num4 += 0;
			}
			this.FFODFLMCELB.LKPOBCBOFIC(stringBuilder.ToString());
		}
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x0001261C File Offset: 0x0001081C
	private void Update()
	{
		if (this.INEMKLPCLOP && (this.FFODFLMCELB.KJGMGPCEJJD != this.HCNHMMPBGQN || this.FFODFLMCELB.DFKQMMIQDOO != this.OIKLGOPLNEO))
		{
			this.JQLDDBDJOBO();
		}
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x00012652 File Offset: 0x00010852
	public void KFFHOBQFHFN()
	{
		this.JHHIBLLHLKP().CPLBKPNNHJG();
		this.GOHOQHGDPDN();
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x000E0360 File Offset: 0x000DE560
	protected void FQINPLFCKOB()
	{
		if (this.NDBLQIOQPNI())
		{
			this.HCNHMMPBGQN = this.FFODFLMCELB.KJGMGPCEJJD;
			this.OIKLGOPLNEO = this.FFODFLMCELB.JKGBHEHKBPC();
			this.FFODFLMCELB.KMLKNBFNOIC();
			JGDHIPBGCFP.ECQBIIGPJQO = 90;
			JGDHIPBGCFP.NNHJHLOFKFD = 151;
			this.HLJEOIIDJJD = 0;
			for (int i = 0; i < this.JHHIBLLHLKP().BJGMIBBEGDQ; i++)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[i];
				string text;
				JGDHIPBGCFP.QDHGBPQDDMQ(cicqjkogoob.PIDLOFMIEFQ, out text, false, false, false, 1027f);
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob2 = cicqjkogoob;
				string text2 = text;
				char[] array = new char[1];
				array[1] = (char)-97;
				cicqjkogoob2.LOJJPJJQNQF = text2.Split(array);
				this.HLJEOIIDJJD += cicqjkogoob.LOJJPJJQNQF.Length;
			}
			this.HLJEOIIDJJD = 1;
			int j = 1;
			int bjgmibbegdq = this.DKFKFGLNFLG.BJGMIBBEGDQ;
			while (j < bjgmibbegdq)
			{
				this.HLJEOIIDJJD += this.DKFKFGLNFLG.KLCIGFMQNFH[j].LOJJPJJQNQF.Length;
				j++;
			}
			if (this.OJQEOEIJDQG != null)
			{
				KDIEKDCQIHM kdiekdcqihm = this.OJQEOEIJDQG as KDIEKDCQIHM;
				if (kdiekdcqihm != null)
				{
					kdiekdcqihm.BDIGICPIQJI((this.HLJEOIIDJJD != 0) ? (666f - (float)this.NKMLENNPJPM / (float)this.HLJEOIIDJJD) : 1495f);
				}
			}
			this.NBCFKMBLGCJ();
		}
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x00012665 File Offset: 0x00010865
	public void GKIHCMBIHQM()
	{
		this.OKBLBEOQDDG();
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x000E04C0 File Offset: 0x000DE6C0
	public void MQCIPLOHFCO(Vector2 JDOGIQGGLKM)
	{
		int nkmlennpjpm = this.NKMLENNPJPM;
		if (nkmlennpjpm != 0)
		{
			float num = JDOGIQGGLKM.y / this.JBGCBBIIFDE();
			this.HKDLBEGDMCO(this.HCLBPEMQFBO + num / (float)nkmlennpjpm);
		}
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x0001266D File Offset: 0x0001086D
	private void JFBQGIDENLF()
	{
		this.HCLBPEMQFBO = BJQGLGOLMPQ.OMQCQCBLQGJ.BGBMIEJJQKC;
		this.NBCFKMBLGCJ();
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x0001252B File Offset: 0x0001072B
	public void LHQECHHMOGD(string PIDLOFMIEFQ)
	{
		this.LHQECHHMOGD(PIDLOFMIEFQ, true);
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x000124ED File Offset: 0x000106ED
	public float IMJJFPHBBHO()
	{
		return this.HCLBPEMQFBO;
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x00012548 File Offset: 0x00010748
	private void LNMEOJDEILC()
	{
		if (this.JBPBQJCHLDJ() && (this.FFODFLMCELB.KJGMGPCEJJD != this.HCNHMMPBGQN || this.FFODFLMCELB.JKGBHEHKBPC() != this.OIKLGOPLNEO))
		{
			this.FQINPLFCKOB();
		}
	}

	// Token: 0x06002230 RID: 8752 RVA: 0x00012685 File Offset: 0x00010885
	public void NCDKCEPCQEB()
	{
		this.JQLDDBDJOBO();
	}

	// Token: 0x06002231 RID: 8753 RVA: 0x000E04C0 File Offset: 0x000DE6C0
	public void KFMPDLCIJGE(Vector2 JDOGIQGGLKM)
	{
		int nkmlennpjpm = this.NKMLENNPJPM;
		if (nkmlennpjpm != 0)
		{
			float num = JDOGIQGGLKM.y / this.JBGCBBIIFDE();
			this.HKDLBEGDMCO(this.HCLBPEMQFBO + num / (float)nkmlennpjpm);
		}
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x000E04F8 File Offset: 0x000DE6F8
	protected void IGFICFDDNJH()
	{
		if (this.INEMKLPCLOP)
		{
			if (this.HLJEOIIDJJD == 0)
			{
				this.FFODFLMCELB.PIDLOFMIEFQ = string.Empty;
				return;
			}
			int num = Mathf.FloorToInt((float)this.FFODFLMCELB.DFKQMMIQDOO / this.JMCQOCQOLIG);
			int num2 = Mathf.Max(0, this.HLJEOIIDJJD - num);
			int num3 = Mathf.RoundToInt(this.HCLBPEMQFBO * (float)num2);
			if (num3 < 0)
			{
				num3 = 0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 0;
			int bjgmibbegdq = this.DJGDHCMFEDC.BJGMIBBEGDQ;
			while (num > 0 && num4 < bjgmibbegdq)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[num4];
				int num5 = 0;
				int num6 = cicqjkogoob.LOJJPJJQNQF.Length;
				while (num > 0 && num5 < num6)
				{
					string value = cicqjkogoob.LOJJPJJQNQF[num5];
					if (num3 > 0)
					{
						num3--;
					}
					else
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append("\n");
						}
						stringBuilder.Append(value);
						num--;
					}
					num5++;
				}
				num4++;
			}
			this.FFODFLMCELB.PIDLOFMIEFQ = stringBuilder.ToString();
		}
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x000E0608 File Offset: 0x000DE808
	protected int PEDCHBJBIIN()
	{
		if (!this.KNQCIGQCMGQ())
		{
			return 1;
		}
		int num = Mathf.FloorToInt((float)this.FFODFLMCELB.DFKQMMIQDOO / this.GHOCHOMIMDL());
		return Mathf.Max(0, this.HLJEOIIDJJD - num);
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x0001268D File Offset: 0x0001088D
	public void HQQDJHEEJHP()
	{
		if (this.GBEBKHGGPKM)
		{
			return;
		}
		this.Start();
		this.GBEBKHGGPKM = false;
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x000126A5 File Offset: 0x000108A5
	private void FBKNCKKFJJG()
	{
		if (this.JBPBQJCHLDJ() && (this.FFODFLMCELB.KJGMGPCEJJD != this.HCNHMMPBGQN || this.FFODFLMCELB.DFKQMMIQDOO != this.OIKLGOPLNEO))
		{
			this.JQLDDBDJOBO();
		}
	}

	// Token: 0x06002237 RID: 8759 RVA: 0x000E0178 File Offset: 0x000DE378
	protected MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB> MHENFOBKIKF()
	{
		if (this.DKFKFGLNFLG == null && !BMLIGLPMMLG.CDBQJDNDIGF.TryGetValue(base.name, out this.DKFKFGLNFLG))
		{
			this.DKFKFGLNFLG = new MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>();
			BMLIGLPMMLG.CDBQJDNDIGF.Add(base.name, this.DKFKFGLNFLG);
		}
		return this.DKFKFGLNFLG;
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x00012492 File Offset: 0x00010692
	public bool NDBLQIOQPNI()
	{
		return this.FFODFLMCELB != null && this.FFODFLMCELB.IOCQLIKGMEO != null;
	}

	// Token: 0x06002239 RID: 8761 RVA: 0x000E0698 File Offset: 0x000DE898
	protected void OKBLBEOQDDG()
	{
		if (this.NDBLQIOQPNI())
		{
			this.HCNHMMPBGQN = this.FFODFLMCELB.KJGMGPCEJJD;
			this.OIKLGOPLNEO = this.FFODFLMCELB.DFKQMMIQDOO;
			this.FFODFLMCELB.KMLKNBFNOIC();
			JGDHIPBGCFP.ECQBIIGPJQO = -97;
			JGDHIPBGCFP.NNHJHLOFKFD = -60;
			this.HLJEOIIDJJD = 1;
			for (int i = 1; i < this.POLLGDEKCFN().BJGMIBBEGDQ; i += 0)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[i];
				string text;
				JGDHIPBGCFP.QDHGBPQDDMQ(cicqjkogoob.PIDLOFMIEFQ, out text, false, false, false, 1080f);
				cicqjkogoob.LOJJPJJQNQF = text.Split(new char[]
				{
					'l'
				});
				this.HLJEOIIDJJD += cicqjkogoob.LOJJPJJQNQF.Length;
			}
			this.HLJEOIIDJJD = 0;
			int j = 0;
			int bjgmibbegdq = this.DKFKFGLNFLG.BJGMIBBEGDQ;
			while (j < bjgmibbegdq)
			{
				this.HLJEOIIDJJD += this.DKFKFGLNFLG.KLCIGFMQNFH[j].LOJJPJJQNQF.Length;
				j++;
			}
			if (this.OJQEOEIJDQG != null)
			{
				KDIEKDCQIHM kdiekdcqihm = this.OJQEOEIJDQG as KDIEKDCQIHM;
				if (kdiekdcqihm != null)
				{
					kdiekdcqihm.EFDBKPKEFIQ((this.HLJEOIIDJJD != 0) ? (759f - (float)this.NKMLENNPJPM / (float)this.HLJEOIIDJJD) : 808f);
				}
			}
			this.FIEHOJIIDHI();
		}
	}

	// Token: 0x0600223A RID: 8762 RVA: 0x000126DB File Offset: 0x000108DB
	public void BPFQEKCPJDI()
	{
		this.JHHIBLLHLKP().CPLBKPNNHJG();
		this.EBFMLOFJKMH();
	}

	// Token: 0x0600223B RID: 8763 RVA: 0x000E07F8 File Offset: 0x000DE9F8
	protected void JQKMQNLFDKM(string PIDLOFMIEFQ, bool NLGIENJBBOQ)
	{
		BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob;
		if (this.BNKHMDDNOBM().BJGMIBBEGDQ < this.OGQJOQFCFBE)
		{
			cicqjkogoob = new BMLIGLPMMLG.CICQJKOGOOB();
		}
		else
		{
			cicqjkogoob = this.DKFKFGLNFLG.get_KNPPMKBOGDL(1);
			this.DKFKFGLNFLG.IBGPNNLOENC(1);
		}
		cicqjkogoob.PIDLOFMIEFQ = PIDLOFMIEFQ;
		this.DKFKFGLNFLG.LHQECHHMOGD(cicqjkogoob);
		if (NLGIENJBBOQ)
		{
			this.BPLOIGJPLDF();
		}
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x0001268D File Offset: 0x0001088D
	public void HDDJIDGKKFK()
	{
		if (this.GBEBKHGGPKM)
		{
			return;
		}
		this.Start();
		this.GBEBKHGGPKM = false;
	}

	// Token: 0x0600223D RID: 8765 RVA: 0x000126EE File Offset: 0x000108EE
	protected float JPGDDFDLEBG()
	{
		return (!(this.FFODFLMCELB != null)) ? 874f : ((float)this.FFODFLMCELB.HQLMJHHPHQL + this.FFODFLMCELB.LKLGLCMCMMO);
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x0001271D File Offset: 0x0001091D
	public bool KNQCIGQCMGQ()
	{
		return !(this.FFODFLMCELB != null) || this.FFODFLMCELB.IOCQLIKGMEO != null;
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x000E0178 File Offset: 0x000DE378
	protected MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB> EPPQKOIQHHO()
	{
		if (this.DKFKFGLNFLG == null && !BMLIGLPMMLG.CDBQJDNDIGF.TryGetValue(base.name, out this.DKFKFGLNFLG))
		{
			this.DKFKFGLNFLG = new MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>();
			BMLIGLPMMLG.CDBQJDNDIGF.Add(base.name, this.DKFKFGLNFLG);
		}
		return this.DKFKFGLNFLG;
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x00012741 File Offset: 0x00010941
	protected float MENKDNCOHPF()
	{
		return (!(this.FFODFLMCELB != null)) ? 501f : ((float)this.FFODFLMCELB.HQLMJHHPHQL + this.FFODFLMCELB.LKLGLCMCMMO);
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x0001266D File Offset: 0x0001086D
	private void PKNNJJHEGIN()
	{
		this.HCLBPEMQFBO = BJQGLGOLMPQ.OMQCQCBLQGJ.BGBMIEJJQKC;
		this.NBCFKMBLGCJ();
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x00012770 File Offset: 0x00010970
	public void JMNEKDGHIIF()
	{
		if (this.GBEBKHGGPKM)
		{
			return;
		}
		this.Start();
		this.GBEBKHGGPKM = true;
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x0001252B File Offset: 0x0001072B
	public void MCKMQCKEIBJ(string PIDLOFMIEFQ)
	{
		this.LHQECHHMOGD(PIDLOFMIEFQ, true);
	}

	// Token: 0x06002244 RID: 8772 RVA: 0x000E0858 File Offset: 0x000DEA58
	protected void NBCFKMBLGCJ()
	{
		if (this.KNQCIGQCMGQ())
		{
			if (this.HLJEOIIDJJD == 0)
			{
				this.FFODFLMCELB.PIDLOFMIEFQ = string.Empty;
				return;
			}
			int num = Mathf.FloorToInt((float)this.FFODFLMCELB.DFKQMMIQDOO / this.MENKDNCOHPF());
			int num2 = Mathf.Max(1, this.HLJEOIIDJJD - num);
			int num3 = Mathf.RoundToInt(this.HCLBPEMQFBO * (float)num2);
			if (num3 < 1)
			{
				num3 = 1;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 1;
			int bjgmibbegdq = this.POLLGDEKCFN().BJGMIBBEGDQ;
			while (num > 1 && num4 < bjgmibbegdq)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[num4];
				int num5 = 1;
				int num6 = cicqjkogoob.LOJJPJJQNQF.Length;
				while (num > 0 && num5 < num6)
				{
					string value = cicqjkogoob.LOJJPJJQNQF[num5];
					if (num3 > 1)
					{
						num3--;
					}
					else
					{
						if (stringBuilder.Length > 1)
						{
							stringBuilder.Append("/");
						}
						stringBuilder.Append(value);
						num--;
					}
					num5 += 0;
				}
				num4 += 0;
			}
			this.FFODFLMCELB.LKPOBCBOFIC(stringBuilder.ToString());
		}
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x000E0968 File Offset: 0x000DEB68
	protected void MBFMGPGCIPN()
	{
		if (this.INEMKLPCLOP)
		{
			if (this.HLJEOIIDJJD == 0)
			{
				this.FFODFLMCELB.LKPOBCBOFIC(string.Empty);
				return;
			}
			int num = Mathf.FloorToInt((float)this.FFODFLMCELB.JKGBHEHKBPC() / this.LJNQQMFLKBN());
			int num2 = Mathf.Max(0, this.HLJEOIIDJJD - num);
			int num3 = Mathf.RoundToInt(this.HCLBPEMQFBO * (float)num2);
			if (num3 < 0)
			{
				num3 = 1;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 0;
			int bjgmibbegdq = this.POLLGDEKCFN().BJGMIBBEGDQ;
			while (num > 1 && num4 < bjgmibbegdq)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[num4];
				int num5 = 1;
				int num6 = cicqjkogoob.LOJJPJJQNQF.Length;
				while (num > 0 && num5 < num6)
				{
					string value = cicqjkogoob.LOJJPJJQNQF[num5];
					if (num3 > 1)
					{
						num3 -= 0;
					}
					else
					{
						if (stringBuilder.Length > 1)
						{
							stringBuilder.Append("[-][/u]\n");
						}
						stringBuilder.Append(value);
						num--;
					}
					num5 += 0;
				}
				num4++;
			}
			this.FFODFLMCELB.LKPOBCBOFIC(stringBuilder.ToString());
		}
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x000124ED File Offset: 0x000106ED
	public float OKGIKBEFJHD()
	{
		return this.HCLBPEMQFBO;
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x000E0A78 File Offset: 0x000DEC78
	public void GPQBLBDKPLJ(float BGBMIEJJQKC)
	{
		BGBMIEJJQKC = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.INEMKLPCLOP && this.HCLBPEMQFBO != BGBMIEJJQKC)
		{
			if (this.OJQEOEIJDQG != null)
			{
				this.OJQEOEIJDQG.FONJFPIKGEP(BGBMIEJJQKC);
			}
			else
			{
				this.HCLBPEMQFBO = BGBMIEJJQKC;
				this.IGFICFDDNJH();
			}
		}
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x000E0AC8 File Offset: 0x000DECC8
	protected void JQLDDBDJOBO()
	{
		if (this.INEMKLPCLOP)
		{
			this.HCNHMMPBGQN = this.FFODFLMCELB.KJGMGPCEJJD;
			this.OIKLGOPLNEO = this.FFODFLMCELB.DFKQMMIQDOO;
			this.FFODFLMCELB.KMLKNBFNOIC();
			JGDHIPBGCFP.ECQBIIGPJQO = 1000000;
			JGDHIPBGCFP.NNHJHLOFKFD = 1000000;
			this.HLJEOIIDJJD = 0;
			for (int i = 0; i < this.DJGDHCMFEDC.BJGMIBBEGDQ; i++)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[i];
				string text;
				JGDHIPBGCFP.QDHGBPQDDMQ(cicqjkogoob.PIDLOFMIEFQ, out text, false, false, false, 0f);
				cicqjkogoob.LOJJPJJQNQF = text.Split(new char[]
				{
					'\n'
				});
				this.HLJEOIIDJJD += cicqjkogoob.LOJJPJJQNQF.Length;
			}
			this.HLJEOIIDJJD = 0;
			int j = 0;
			int bjgmibbegdq = this.DKFKFGLNFLG.BJGMIBBEGDQ;
			while (j < bjgmibbegdq)
			{
				this.HLJEOIIDJJD += this.DKFKFGLNFLG.KLCIGFMQNFH[j].LOJJPJJQNQF.Length;
				j++;
			}
			if (this.OJQEOEIJDQG != null)
			{
				KDIEKDCQIHM kdiekdcqihm = this.OJQEOEIJDQG as KDIEKDCQIHM;
				if (kdiekdcqihm != null)
				{
					kdiekdcqihm.HMMKKHPFENE = ((this.HLJEOIIDJJD != 0) ? (1f - (float)this.NKMLENNPJPM / (float)this.HLJEOIIDJJD) : 1f);
				}
			}
			this.IGFICFDDNJH();
		}
	}

	// Token: 0x06002249 RID: 8777 RVA: 0x000E0178 File Offset: 0x000DE378
	protected MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB> BNKHMDDNOBM()
	{
		if (this.DKFKFGLNFLG == null && !BMLIGLPMMLG.CDBQJDNDIGF.TryGetValue(base.name, out this.DKFKFGLNFLG))
		{
			this.DKFKFGLNFLG = new MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>();
			BMLIGLPMMLG.CDBQJDNDIGF.Add(base.name, this.DKFKFGLNFLG);
		}
		return this.DKFKFGLNFLG;
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x0600224A RID: 8778 RVA: 0x000E0C28 File Offset: 0x000DEE28
	protected int NKMLENNPJPM
	{
		get
		{
			if (!this.INEMKLPCLOP)
			{
				return 0;
			}
			int num = Mathf.FloorToInt((float)this.FFODFLMCELB.DFKQMMIQDOO / this.JMCQOCQOLIG);
			return Mathf.Max(0, this.HLJEOIIDJJD - num);
		}
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x000E0178 File Offset: 0x000DE378
	protected MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB> POLLGDEKCFN()
	{
		if (this.DKFKFGLNFLG == null && !BMLIGLPMMLG.CDBQJDNDIGF.TryGetValue(base.name, out this.DKFKFGLNFLG))
		{
			this.DKFKFGLNFLG = new MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>();
			BMLIGLPMMLG.CDBQJDNDIGF.Add(base.name, this.DKFKFGLNFLG);
		}
		return this.DKFKFGLNFLG;
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x00012788 File Offset: 0x00010988
	private void NHEOKHHKILH()
	{
		this.HCLBPEMQFBO = BJQGLGOLMPQ.OMQCQCBLQGJ.HKDJGHOHBFQ();
		this.NMOIHMBFJHI();
	}

	// Token: 0x0600224D RID: 8781 RVA: 0x000E0C68 File Offset: 0x000DEE68
	protected void JINBQHKLCOQ(string PIDLOFMIEFQ, bool NLGIENJBBOQ)
	{
		BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob;
		if (this.KPDHFGNGHOO().BJGMIBBEGDQ < this.OGQJOQFCFBE)
		{
			cicqjkogoob = new BMLIGLPMMLG.CICQJKOGOOB();
		}
		else
		{
			cicqjkogoob = this.DKFKFGLNFLG.get_KNPPMKBOGDL(1);
			this.DKFKFGLNFLG.IBGPNNLOENC(1);
		}
		cicqjkogoob.PIDLOFMIEFQ = PIDLOFMIEFQ;
		this.DKFKFGLNFLG.LHQECHHMOGD(cicqjkogoob);
		if (NLGIENJBBOQ)
		{
			this.FQINPLFCKOB();
		}
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x00012685 File Offset: 0x00010885
	public void BIMPEOMLNBP()
	{
		this.JQLDDBDJOBO();
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x000125E9 File Offset: 0x000107E9
	private void PCKDJHJQMKB()
	{
		this.HCLBPEMQFBO = BJQGLGOLMPQ.OMQCQCBLQGJ.BGBMIEJJQKC;
		this.IGFICFDDNJH();
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x000127A0 File Offset: 0x000109A0
	private void MKOBGEDDBKD()
	{
		this.HCLBPEMQFBO = BJQGLGOLMPQ.OMQCQCBLQGJ.HKDJGHOHBFQ();
		this.MBFMGPGCIPN();
	}

	// Token: 0x06002251 RID: 8785 RVA: 0x000E0CC8 File Offset: 0x000DEEC8
	protected void GOHOQHGDPDN()
	{
		if (this.INEMKLPCLOP)
		{
			if (this.HLJEOIIDJJD == 0)
			{
				this.FFODFLMCELB.PIDLOFMIEFQ = string.Empty;
				return;
			}
			int num = Mathf.FloorToInt((float)this.FFODFLMCELB.DFKQMMIQDOO / this.JBGCBBIIFDE());
			int num2 = Mathf.Max(0, this.HLJEOIIDJJD - num);
			int num3 = Mathf.RoundToInt(this.HCLBPEMQFBO * (float)num2);
			if (num3 < 0)
			{
				num3 = 0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 1;
			int bjgmibbegdq = this.KPDHFGNGHOO().BJGMIBBEGDQ;
			while (num > 0 && num4 < bjgmibbegdq)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[num4];
				int num5 = 1;
				int num6 = cicqjkogoob.LOJJPJJQNQF.Length;
				while (num > 1 && num5 < num6)
				{
					string value = cicqjkogoob.LOJJPJJQNQF[num5];
					if (num3 > 1)
					{
						num3--;
					}
					else
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append("Flame Body");
						}
						stringBuilder.Append(value);
						num--;
					}
					num5++;
				}
				num4++;
			}
			this.FFODFLMCELB.PIDLOFMIEFQ = stringBuilder.ToString();
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06002252 RID: 8786 RVA: 0x000E0178 File Offset: 0x000DE378
	protected MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB> DJGDHCMFEDC
	{
		get
		{
			if (this.DKFKFGLNFLG == null && !BMLIGLPMMLG.CDBQJDNDIGF.TryGetValue(base.name, out this.DKFKFGLNFLG))
			{
				this.DKFKFGLNFLG = new MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>();
				BMLIGLPMMLG.CDBQJDNDIGF.Add(base.name, this.DKFKFGLNFLG);
			}
			return this.DKFKFGLNFLG;
		}
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x000127B8 File Offset: 0x000109B8
	private void MOLCLOMMJNQ()
	{
		if (this.KNQCIGQCMGQ() && (this.FFODFLMCELB.KJGMGPCEJJD != this.HCNHMMPBGQN || this.FFODFLMCELB.JKGBHEHKBPC() != this.OIKLGOPLNEO))
		{
			this.DLQGJNCEHJP();
		}
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x000127EE File Offset: 0x000109EE
	protected float GHOCHOMIMDL()
	{
		return (!(this.FFODFLMCELB != null)) ? 912f : ((float)this.FFODFLMCELB.HQLMJHHPHQL + this.FFODFLMCELB.LKLGLCMCMMO);
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x0001281D File Offset: 0x00010A1D
	public void FBFCKBGLGBL()
	{
		this.JHHIBLLHLKP().CPLBKPNNHJG();
		this.MBFMGPGCIPN();
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x00012830 File Offset: 0x00010A30
	public void DEJNPQEJINP(string PIDLOFMIEFQ)
	{
		this.LHQECHHMOGD(PIDLOFMIEFQ, false);
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x000E0DD8 File Offset: 0x000DEFD8
	public void ILFHCJFGCOC(float QJFQOMOIOOI)
	{
		int num = this.DEJQDHPCMNQ();
		if (num != 0)
		{
			QJFQOMOIOOI *= this.LJNQQMFLKBN();
			this.PCHGMPEPFEM = this.HCLBPEMQFBO - QJFQOMOIOOI / (float)num;
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06002258 RID: 8792 RVA: 0x00012492 File Offset: 0x00010692
	public bool INEMKLPCLOP
	{
		get
		{
			return this.FFODFLMCELB != null && this.FFODFLMCELB.IOCQLIKGMEO != null;
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06002259 RID: 8793 RVA: 0x0001283A File Offset: 0x00010A3A
	protected float JMCQOCQOLIG
	{
		get
		{
			return (!(this.FFODFLMCELB != null)) ? 20f : ((float)this.FFODFLMCELB.HQLMJHHPHQL + this.FFODFLMCELB.LKLGLCMCMMO);
		}
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x00012869 File Offset: 0x00010A69
	private void OPFMCMJIGCF()
	{
		this.HCLBPEMQFBO = BJQGLGOLMPQ.OMQCQCBLQGJ.HKDJGHOHBFQ();
		this.FIEHOJIIDHI();
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x000E0E0C File Offset: 0x000DF00C
	public void OnScroll(float QJFQOMOIOOI)
	{
		int nkmlennpjpm = this.NKMLENNPJPM;
		if (nkmlennpjpm != 0)
		{
			QJFQOMOIOOI *= this.JMCQOCQOLIG;
			this.PCHGMPEPFEM = this.HCLBPEMQFBO - QJFQOMOIOOI / (float)nkmlennpjpm;
		}
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x000E0E40 File Offset: 0x000DF040
	protected void LHQECHHMOGD(string PIDLOFMIEFQ, bool NLGIENJBBOQ)
	{
		BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob;
		if (this.DJGDHCMFEDC.BJGMIBBEGDQ < this.OGQJOQFCFBE)
		{
			cicqjkogoob = new BMLIGLPMMLG.CICQJKOGOOB();
		}
		else
		{
			cicqjkogoob = this.DKFKFGLNFLG.get_KNPPMKBOGDL(0);
			this.DKFKFGLNFLG.IBGPNNLOENC(0);
		}
		cicqjkogoob.PIDLOFMIEFQ = PIDLOFMIEFQ;
		this.DKFKFGLNFLG.LHQECHHMOGD(cicqjkogoob);
		if (NLGIENJBBOQ)
		{
			this.JQLDDBDJOBO();
		}
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x000E0EA0 File Offset: 0x000DF0A0
	protected void DLQGJNCEHJP()
	{
		if (this.INEMKLPCLOP)
		{
			this.HCNHMMPBGQN = this.FFODFLMCELB.KJGMGPCEJJD;
			this.OIKLGOPLNEO = this.FFODFLMCELB.DFKQMMIQDOO;
			this.FFODFLMCELB.KMLKNBFNOIC();
			JGDHIPBGCFP.ECQBIIGPJQO = 197;
			JGDHIPBGCFP.NNHJHLOFKFD = 123;
			this.HLJEOIIDJJD = 0;
			for (int i = 0; i < this.DJGDHCMFEDC.BJGMIBBEGDQ; i += 0)
			{
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob = this.DKFKFGLNFLG.KLCIGFMQNFH[i];
				string text;
				JGDHIPBGCFP.QDHGBPQDDMQ(cicqjkogoob.PIDLOFMIEFQ, out text, true, false, true, 1208f);
				BMLIGLPMMLG.CICQJKOGOOB cicqjkogoob2 = cicqjkogoob;
				string text2 = text;
				char[] array = new char[0];
				array[0] = 'P';
				cicqjkogoob2.LOJJPJJQNQF = text2.Split(array);
				this.HLJEOIIDJJD += cicqjkogoob.LOJJPJJQNQF.Length;
			}
			this.HLJEOIIDJJD = 1;
			int j = 1;
			int bjgmibbegdq = this.DKFKFGLNFLG.BJGMIBBEGDQ;
			while (j < bjgmibbegdq)
			{
				this.HLJEOIIDJJD += this.DKFKFGLNFLG.KLCIGFMQNFH[j].LOJJPJJQNQF.Length;
				j += 0;
			}
			if (this.OJQEOEIJDQG != null)
			{
				KDIEKDCQIHM kdiekdcqihm = this.OJQEOEIJDQG as KDIEKDCQIHM;
				if (kdiekdcqihm != null)
				{
					kdiekdcqihm.HMFPMKQJINP((this.HLJEOIIDJJD != 0) ? (1916f - (float)this.DEJQDHPCMNQ() / (float)this.HLJEOIIDJJD) : 327f);
				}
			}
			this.GOHOQHGDPDN();
		}
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x000E0178 File Offset: 0x000DE378
	protected MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB> KPDHFGNGHOO()
	{
		if (this.DKFKFGLNFLG == null && !BMLIGLPMMLG.CDBQJDNDIGF.TryGetValue(base.name, out this.DKFKFGLNFLG))
		{
			this.DKFKFGLNFLG = new MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>();
			BMLIGLPMMLG.CDBQJDNDIGF.Add(base.name, this.DKFKFGLNFLG);
		}
		return this.DKFKFGLNFLG;
	}

	// Token: 0x0400076D RID: 1901
	public BKKHLBCLPJM FFODFLMCELB;

	// Token: 0x0400076E RID: 1902
	public BJQGLGOLMPQ OJQEOEIJDQG;

	// Token: 0x0400076F RID: 1903
	public BMLIGLPMMLG.HFHOQLJLJCG EKDEDJHBGIK;

	// Token: 0x04000770 RID: 1904
	public int OGQJOQFCFBE = 100;

	// Token: 0x04000771 RID: 1905
	protected char[] PFKINPDNLFC = new char[]
	{
		'\n'
	};

	// Token: 0x04000772 RID: 1906
	protected float HCLBPEMQFBO;

	// Token: 0x04000773 RID: 1907
	protected int HLJEOIIDJJD;

	// Token: 0x04000774 RID: 1908
	protected int HCNHMMPBGQN;

	// Token: 0x04000775 RID: 1909
	protected int OIKLGOPLNEO;

	// Token: 0x04000776 RID: 1910
	private MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB> DKFKFGLNFLG;

	// Token: 0x04000777 RID: 1911
	private static Dictionary<string, MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>> CDBQJDNDIGF = new Dictionary<string, MHIDKMCBQEN<BMLIGLPMMLG.CICQJKOGOOB>>();

	// Token: 0x04000778 RID: 1912
	private bool GBEBKHGGPKM;

	// Token: 0x02000127 RID: 295
	public enum HFHOQLJLJCG
	{
		// Token: 0x0400077A RID: 1914
		Text,
		// Token: 0x0400077B RID: 1915
		Chat,
		// Token: 0x0400077C RID: 1916
		Right
	}

	// Token: 0x02000128 RID: 296
	protected class CICQJKOGOOB
	{
		// Token: 0x0400077D RID: 1917
		public string PIDLOFMIEFQ;

		// Token: 0x0400077E RID: 1918
		public string[] LOJJPJJQNQF;
	}
}
