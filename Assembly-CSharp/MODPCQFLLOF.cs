using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000024 RID: 36
public abstract class MODPCQFLLOF : MonoBehaviour
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600059E RID: 1438
	protected abstract InvGameItem EONMHEFBHEQ { get; }

	// Token: 0x0600059F RID: 1439
	protected abstract InvGameItem FKEECBBDPFF(InvGameItem PDIBIIKFBDH);

	// Token: 0x060005A0 RID: 1440 RVA: 0x0004E35C File Offset: 0x0004C55C
	private void IFGPPIQKOPM(bool OHOBDLMNJMC)
	{
		InvGameItem invGameItem = (!OHOBDLMNJMC) ? null : this.QEHIHKOHHFJ;
		if (invGameItem != null)
		{
			InvBaseItem baseItem = invGameItem.baseItem;
			if (baseItem != null)
			{
				string text = string.Concat(new string[]
				{
					"[",
					JGDHIPBGCFP.JPHIJCIGHPQ(invGameItem.color),
					"]",
					invGameItem.name,
					"[-]\n"
				});
				string text2 = text;
				text = string.Concat(new object[]
				{
					text2,
					"[AFAFAF]Level ",
					invGameItem.itemLevel,
					" ",
					baseItem.slot
				});
				List<InvStat> list = invGameItem.QNNCKNCFNMK();
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					InvStat invStat = list[i];
					if (invStat.amount != 0)
					{
						if (invStat.amount < 0)
						{
							text = text + "\n[FF0000]" + invStat.amount;
						}
						else
						{
							text = text + "\n[00FF00]+" + invStat.amount;
						}
						if (invStat.modifier == InvStat.JPLHHNKQLOI.Percent)
						{
							text += "%";
						}
						text = text + " " + invStat.id;
						text += "[-]";
					}
					i++;
				}
				if (!string.IsNullOrEmpty(baseItem.description))
				{
					text = text + "\n[FF9900]" + baseItem.description;
				}
				GGGPJQEKNJD.MFONIPHOFGF(text);
				return;
			}
		}
		GGGPJQEKNJD.Hide();
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x000044CE File Offset: 0x000026CE
	private void OnClick()
	{
		if (MODPCQFLLOF.BPONFBHQOBF != null)
		{
			this.QMECFKNPOGJ(null);
		}
		else if (this.QEHIHKOHHFJ != null)
		{
			MODPCQFLLOF.BPONFBHQOBF = this.FKEECBBDPFF(null);
			if (MODPCQFLLOF.BPONFBHQOBF != null)
			{
				IKBQNBHOJJB.LKHCJLDFLEJ(this.BBPOMPKBNEO);
			}
			this.QJKHCNBPKPI();
		}
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x0000450D File Offset: 0x0000270D
	private void OnDrag(Vector2 JDOGIQGGLKM)
	{
		if (MODPCQFLLOF.BPONFBHQOBF == null && this.QEHIHKOHHFJ != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.BasedOnDelta;
			MODPCQFLLOF.BPONFBHQOBF = this.FKEECBBDPFF(null);
			IKBQNBHOJJB.LKHCJLDFLEJ(this.BBPOMPKBNEO);
			this.QJKHCNBPKPI();
		}
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0004E4E0 File Offset: 0x0004C6E0
	private void QMECFKNPOGJ(GameObject CGHIENBIHCO)
	{
		InvGameItem invGameItem = this.FKEECBBDPFF(MODPCQFLLOF.BPONFBHQOBF);
		if (MODPCQFLLOF.BPONFBHQOBF == invGameItem)
		{
			IKBQNBHOJJB.LKHCJLDFLEJ(this.QQMJMPJJMOP);
		}
		else if (invGameItem != null)
		{
			IKBQNBHOJJB.LKHCJLDFLEJ(this.BBPOMPKBNEO);
		}
		else
		{
			IKBQNBHOJJB.LKHCJLDFLEJ(this.LJLEPHNNOHJ);
		}
		MODPCQFLLOF.BPONFBHQOBF = invGameItem;
		this.QJKHCNBPKPI();
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00004547 File Offset: 0x00002747
	private void QJKHCNBPKPI()
	{
		if (MODPCQFLLOF.BPONFBHQOBF != null && MODPCQFLLOF.BPONFBHQOBF.baseItem != null)
		{
			HCEEMKFECPJ.PJMIKDIEGMB(MODPCQFLLOF.BPONFBHQOBF.baseItem.iconAtlas, MODPCQFLLOF.BPONFBHQOBF.baseItem.iconName);
		}
		else
		{
			HCEEMKFECPJ.CPLBKPNNHJG();
		}
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x0004E538 File Offset: 0x0004C738
	private void Update()
	{
		InvGameItem eonmhefbheq = this.EONMHEFBHEQ;
		if (this.QEHIHKOHHFJ != eonmhefbheq)
		{
			this.QEHIHKOHHFJ = eonmhefbheq;
			InvBaseItem invBaseItem = (eonmhefbheq == null) ? null : eonmhefbheq.baseItem;
			if (this.KEQMEGEHFIK != null)
			{
				string text = (eonmhefbheq == null) ? null : eonmhefbheq.name;
				if (string.IsNullOrEmpty(this.KEJFKONOJDI))
				{
					this.KEJFKONOJDI = this.KEQMEGEHFIK.PIDLOFMIEFQ;
				}
				this.KEQMEGEHFIK.PIDLOFMIEFQ = ((text == null) ? this.KEJFKONOJDI : text);
			}
			if (this.IPJPCNCDJBI != null)
			{
				if (invBaseItem != null && !(invBaseItem.iconAtlas == null))
				{
					this.IPJPCNCDJBI.QKGJDCFCPMO = invBaseItem.iconAtlas;
					this.IPJPCNCDJBI.KCLBMPFIPNQ = invBaseItem.iconName;
					this.IPJPCNCDJBI.enabled = true;
					this.IPJPCNCDJBI.IQFQEOFBQKM();
				}
				else
				{
					this.IPJPCNCDJBI.enabled = false;
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.CEGFBBHMKOE = ((eonmhefbheq == null) ? Color.white : eonmhefbheq.color);
			}
		}
	}

	// Token: 0x040000AE RID: 174
	public PLQFPBQEPJD IPJPCNCDJBI;

	// Token: 0x040000AF RID: 175
	public ENFMCDNLEQQ MCPNNHMOFQH;

	// Token: 0x040000B0 RID: 176
	public BKKHLBCLPJM KEQMEGEHFIK;

	// Token: 0x040000B1 RID: 177
	public AudioClip BBPOMPKBNEO;

	// Token: 0x040000B2 RID: 178
	public AudioClip LJLEPHNNOHJ;

	// Token: 0x040000B3 RID: 179
	public AudioClip QQMJMPJJMOP;

	// Token: 0x040000B4 RID: 180
	private InvGameItem QEHIHKOHHFJ;

	// Token: 0x040000B5 RID: 181
	private string KEJFKONOJDI = string.Empty;

	// Token: 0x040000B6 RID: 182
	private static InvGameItem BPONFBHQOBF;
}
